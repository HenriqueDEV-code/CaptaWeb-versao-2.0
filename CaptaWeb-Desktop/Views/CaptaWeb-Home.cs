using CaptaWeb_Desktop.Interfaces;
using CaptaWeb_Desktop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace CaptaWeb_Desktop.Views
{
    public partial class CaptaWeb_Home : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex = -1;  // initialized to an invalid index
        private Form activeForm;

        // Constructor
        public CaptaWeb_Home()
        {
            InitializeComponent();
            random = new Random();
            Bnt_Painel_Controle_Click(this.Bnt_Painel_Controle, EventArgs.Empty);
            this.label_titleBar_PanelSuperior.Text = "CaptaWeb - Painel de Controle";
        }

        // Métodos
        private Color SelectThemeColor()
        {
            if (ThemeColor.ColorList == null || ThemeColor.ColorList.Count == 0)
                throw new InvalidOperationException("ThemeColor.ColorList está vazia ou nula.");

            int index;
            do
            {
                index = random.Next(ThemeColor.ColorList.Count);
            } while (index == tempIndex && ThemeColor.ColorList.Count > 1);
            tempIndex = index;

            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                var button = btnSender as Button;
                if (button != null && currentButton != button)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = button;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Arial", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void DisableButton()
        {
            if (Panel_Lateral_Home != null)
            {
                foreach (Control previousBtn in Panel_Lateral_Home.Controls)
                {
                    if (previousBtn is Button btn)
                    {
                        btn.BackColor = Color.FromArgb(46, 139, 192);
                        btn.ForeColor = Color.White;
                        btn.Font = new Font("Arial", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
                    }
                }
            }
        }


        private void OpenChildForm(Form childForm, object? btnSender = null)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panel_Desktop.Controls.Add(childForm);
            this.panel_Desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label_titleBar_PanelSuperior.Text = " CaptaWeb - " + childForm.Text;
        }

        private void ArrendondarButton(Button btn, int raio)
        {
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);

            GraphicsPath path = new GraphicsPath();

            int d = raio * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90); // Canto superior esquerdo
            path.AddArc(rect.X + rect.Width - d, rect.Y, d, d, 270, 90); // Canto superior direito
            path.AddArc(rect.X + rect.Width - d, rect.Y + rect.Height - d, d, d, 0, 90); // Canto inferior direito
            path.AddArc(rect.X, rect.Y + rect.Height - d, d, d, 90, 90); // Canto inferior esquerdo

            btn.Region = new Region(path);
        }


        private void Bnt_Painel_Controle_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views_Paineis.PaineldeControle(OpenChildForm), sender);
            this.Text = "CaptaWeb - Painel de Controle";

        }

        private void Bnt_Novo_Imovel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views_Paineis.NovoImovel(OpenChildForm), sender);
            this.Text = "CaptaWeb - Novo Imóvel";

        }

        private void Bnt_Novo_Proprietario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views_Paineis.NovoProprietario(OpenChildForm), sender);
            this.Text = "CaptaWeb - Novo Proprietário";

        }

        private void Bnt_Nova_Parceria_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views_Paineis.NovaParceria(OpenChildForm), sender);
            this.Text = "CaptaWeb - Nova Parceria";

        }

        private void Bnt_Lista_de_imoveis_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views_Paineis.Imoveis(OpenChildForm), sender);
            this.Text = "CaptaWeb - Lista de Imóveis";

        }

        private void Bnt_Bloco_de_notas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views_Paineis.BlocoNotas(OpenChildForm), sender);
            this.Text = "CaptaWeb - Bloco de Notas";

        }
        private void Bnt_NotasRecibos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views_Paineis.NotasRecibos(OpenChildForm), sender);
            this.Text = "CaptaWeb - Notas e Recibos";
        }
        private void Bnt_ExtrairTXT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views_Paineis.ExtrairTXT(OpenChildForm), sender);
            this.Text = "CaptaWeb - Extrair para TXT";
        }

        private void CaptaWeb_Home_Load(object sender, EventArgs e)
        {
            ArrendondarButton(Bnt_Painel_Controle, 12);
            ArrendondarButton(Bnt_Novo_Imovel, 12);
            ArrendondarButton(Bnt_Novo_Proprietario, 12);
            ArrendondarButton(Bnt_Nova_Parceria, 12);
            ArrendondarButton(Bnt_Lista_de_imoveis, 12);
            ArrendondarButton(Bnt_NotasRecibos, 12);
            ArrendondarButton(Bnt_Bloco_de_notas, 12);
            ArrendondarButton(Bnt_ExtrairTXT, 12);

        }

        
    }
}
