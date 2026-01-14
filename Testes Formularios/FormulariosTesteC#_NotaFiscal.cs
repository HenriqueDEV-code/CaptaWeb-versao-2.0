using System;
using System.Globalization;
using System.IO;
using iText.Forms;
using iText.Forms.Fields;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Annot;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

public static class PdfFormularioCapitacao
{
    public static void Gerar(string outputPdfPath)
    {
        // A4
        var pageSize = PageSize.A4;

        using var writer = new PdfWriter(outputPdfPath);
        using var pdf = new PdfDocument(writer);
        using var doc = new Document(pdf, pageSize);

        // Fundo suave (simulação usando uma área com cor)
        // (iText7 não tem "background da página" direto no Layout API,
        //  então fazemos com uma tabela grande ou canvas; aqui simplificamos.)
        doc.SetMargins(60, 60, 60, 60);

        // Título
        var title = new Paragraph("Preenche o formulário")
            .SetTextAlignment(TextAlignment.CENTER)
            .SetFontSize(22)
            .SetBold()
            .SetMarginBottom(30);

        doc.Add(title);

        // Criar formulário
        PdfAcroForm form = PdfAcroForm.GetAcroForm(pdf, true);

        // Layout tipo "labels à esquerda + campos à direita"
        // Uma tabela facilita alinhar como na imagem.
        var table = new Table(new float[] { 170, 1, 260 })
            .UseAllAvailableWidth()
            .SetMarginTop(10);

        // Helper para criar linhas
        void AddRow(string label, string fieldName, bool isNumeric, string placeholder = "")
        {
            table.AddCell(new Cell().Add(new Paragraph(label).SetFontSize(12))
                .SetBorder(iText.Layout.Borders.Border.NO_BORDER)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetPaddingRight(10));

            table.AddCell(new Cell().Add(new Paragraph(":"))
                .SetBorder(iText.Layout.Borders.Border.NO_BORDER)
                .SetTextAlignment(TextAlignment.CENTER));

            // Espaço do campo (o campo real será posicionado por retângulo absoluto)
            // Aqui colocamos um "vazio" para reservar altura.
            table.AddCell(new Cell().Add(new Paragraph(" "))
                .SetBorder(iText.Layout.Borders.Border.NO_BORDER)
                .SetMinHeight(28));
        }

        AddRow("Nome Completo", "nomeCompleto", isNumeric: false);
        AddRow("Quantas captações", "qtdCapitacoes", isNumeric: true);
        AddRow("Valor da Captação", "valorCapitacao", isNumeric: true);
        AddRow("Data", "data", isNumeric: false);
        AddRow("Total", "total", isNumeric: true);

        doc.Add(table);

        // Precisamos obter coordenadas para posicionar os campos.
        // A forma mais estável é definir retângulos absolutos manualmente.
        // Considerando as margens e a posição aproximada das linhas.

        // Base (ajuste fino se quiser deixar idêntico ao seu print)
        float left = 60 + 170 + 1 + 10;       // margem + largura label + ":" + padding
        float fieldWidth = 260;
        float fieldHeight = 20;

        // Y inicial abaixo do título (A4 ~ 842pt de altura)
        // Como o layout pode variar, definimos posições aproximadas.
        // Se quiser 100% pixel-perfect, você ajusta esses Y.
        float startY = 842 - 60 - 110; // topo - margem - “altura do título”
        float gapY = 36;

        // Campos (Nome, Qtd, Valor, Data, Total)
        var nomeRect  = new Rectangle(left, startY, fieldWidth, fieldHeight);
        var qtdRect   = new Rectangle(left, startY - gapY, fieldWidth, fieldHeight);
        var valorRect = new Rectangle(left, startY - 2 * gapY, fieldWidth, fieldHeight);
        var dataRect  = new Rectangle(left, startY - 3 * gapY, fieldWidth, fieldHeight);
        var totalRect = new Rectangle(left, startY - 4 * gapY, fieldWidth, fieldHeight);

        // Estilo padrão do campo
        PdfFormField MakeTextField(string name, Rectangle rect, bool readOnly = false)
        {
            var tf = PdfFormField.CreateText(pdf, rect, name, "");
            tf.SetFontSize(11);
            tf.SetBorderColor(ColorConstants.LIGHT_GRAY);
            tf.SetBorderWidth(1);
            tf.SetBackgroundColor(new DeviceRgb(255, 255, 255));
            tf.SetJustification(PdfFormField.ALIGN_LEFT);

            if (readOnly)
                tf.SetFieldFlag(PdfFormField.FF_READ_ONLY, true);

            return tf;
        }

        // Criar campos
        var nome = MakeTextField("nomeCompleto", nomeRect);
        var qtd = MakeTextField("qtdCapitacoes", qtdRect);
        var valor = MakeTextField("valorCapitacao", valorRect);
        var data = MakeTextField("data", dataRect);
        var total = MakeTextField("total", totalRect, readOnly: true);

        // Dicas/ajustes
        qtd.SetJustification(PdfFormField.ALIGN_RIGHT);
        valor.SetJustification(PdfFormField.ALIGN_RIGHT);
        total.SetJustification(PdfFormField.ALIGN_RIGHT);

        // Adicionar ao form
        form.AddField(nome);
        form.AddField(qtd);
        form.AddField(valor);
        form.AddField(data);
        form.AddField(total);

        // JavaScript de cálculo:
        // - normaliza vírgula/ponto
        // - calcula qtd * valor
        // - formata com 2 casas
        // Observação: JavaScript de PDF varia por leitor; Adobe costuma suportar muito bem.
        string calcScript = @"
(function () {
  function toNumber(v) {
    if (!v) return 0;
    v = ('' + v).trim();
    v = v.replace(/\./g, '');      // remove separador milhar se vier
    v = v.replace(',', '.');       // vírgula -> ponto
    var n = parseFloat(v);
    return isNaN(n) ? 0 : n;
  }
  var qtd = toNumber(this.getField('qtdCapitacoes').value);
  var val = toNumber(this.getField('valorCapitacao').value);
  var tot = qtd * val;
  this.getField('total').value = tot.toFixed(2);
})();";

        // Para recalcular quando Qtd ou Valor mudar:
        // iText7 permite setar ação adicional (keystroke/validate) nos campos.
        qtd.SetAdditionalAction(PdfName.K, PdfAction.CreateJavaScript(calcScript));
        valor.SetAdditionalAction(PdfName.K, PdfAction.CreateJavaScript(calcScript));

        // Também recalcular ao sair do campo (Blur)
        qtd.SetAdditionalAction(PdfName.V, PdfAction.CreateJavaScript(calcScript));
        valor.SetAdditionalAction(PdfName.V, PdfAction.CreateJavaScript(calcScript));

        // Texto final / botão ilustrativo (o PDF não "salva no banco"; isso é no seu app)
        doc.Add(new Paragraph("\nDica: preencha Quantas captações e Valor da Captação para o Total calcular automaticamente.")
            .SetFontSize(10)
            .SetFontColor(ColorConstants.DARK_GRAY));

        doc.Close();
    }
}




 //  Como Chamar 
 /* 
     PdfFormularioCapitacao.Gerar(@"C:\Temp\FormularioCapitacao.pdf");

     */
