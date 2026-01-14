namespace CaptaWeb_Desktop.Views.Views_Paineis
{
    partial class NovoProprietario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            uiLabel5 = new Sunny.UI.UILabel();
            DGV_ListaProprietarios = new Sunny.UI.UIDataGridView();
            Btn_SalvarCadastroProprietario = new Button();
            TxB_NumeroProprietario = new Sunny.UI.UITextBox();
            uiLine1 = new Sunny.UI.UILine();
            uiLabel6 = new Sunny.UI.UILabel();
            Lab_IdEmpresaViews = new Sunny.UI.UILabel();
            uiLine4 = new Sunny.UI.UILine();
            TxB_EmailProprietario = new Sunny.UI.UITextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            TxB_DDDProprietario = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            TxB_DocumentoProprietario = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            Combox_TipoPessoaProprietario = new Sunny.UI.UIComboBox();
            uiLabel1 = new Sunny.UI.UILabel();
            TxB_NomeProprietario = new Sunny.UI.UITextBox();
            uiLabel25 = new Sunny.UI.UILabel();
            uiAvatar1 = new Sunny.UI.UIAvatar();
            uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_ListaProprietarios).BeginInit();
            SuspendLayout();
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiGroupBox1.Controls.Add(uiLabel5);
            uiGroupBox1.Controls.Add(DGV_ListaProprietarios);
            uiGroupBox1.Controls.Add(Btn_SalvarCadastroProprietario);
            uiGroupBox1.Controls.Add(TxB_NumeroProprietario);
            uiGroupBox1.Controls.Add(uiLine1);
            uiGroupBox1.Controls.Add(uiLabel6);
            uiGroupBox1.Controls.Add(Lab_IdEmpresaViews);
            uiGroupBox1.Controls.Add(uiLine4);
            uiGroupBox1.Controls.Add(TxB_EmailProprietario);
            uiGroupBox1.Controls.Add(uiLabel4);
            uiGroupBox1.Controls.Add(TxB_DDDProprietario);
            uiGroupBox1.Controls.Add(uiLabel3);
            uiGroupBox1.Controls.Add(TxB_DocumentoProprietario);
            uiGroupBox1.Controls.Add(uiLabel2);
            uiGroupBox1.Controls.Add(Combox_TipoPessoaProprietario);
            uiGroupBox1.Controls.Add(uiLabel1);
            uiGroupBox1.Controls.Add(TxB_NomeProprietario);
            uiGroupBox1.Controls.Add(uiLabel25);
            uiGroupBox1.Controls.Add(uiAvatar1);
            uiGroupBox1.FillColor = Color.Transparent;
            uiGroupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiGroupBox1.ForeColor = Color.RoyalBlue;
            uiGroupBox1.Location = new Point(0, 0);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(1661, 925);
            uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            uiGroupBox1.TabIndex = 0;
            uiGroupBox1.Text = null;
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            uiLabel5.BackColor = Color.Transparent;
            uiLabel5.Font = new Font("Sans Serif Collection", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(858, 53);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(791, 77);
            uiLabel5.TabIndex = 5040;
            uiLabel5.Text = "LISTA DE PROPRIETÁRIOS";
            // 
            // DGV_ListaProprietarios
            // 
            DGV_ListaProprietarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            DGV_ListaProprietarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGV_ListaProprietarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_ListaProprietarios.BackgroundColor = Color.White;
            DGV_ListaProprietarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGV_ListaProprietarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV_ListaProprietarios.ColumnHeadersHeight = 32;
            DGV_ListaProprietarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGV_ListaProprietarios.DefaultCellStyle = dataGridViewCellStyle3;
            DGV_ListaProprietarios.EnableHeadersVisualStyles = false;
            DGV_ListaProprietarios.Font = new Font("Microsoft Sans Serif", 12F);
            DGV_ListaProprietarios.GridColor = Color.FromArgb(80, 160, 255);
            DGV_ListaProprietarios.Location = new Point(858, 133);
            DGV_ListaProprietarios.Name = "DGV_ListaProprietarios";
            DGV_ListaProprietarios.ReadOnly = true;
            DGV_ListaProprietarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGV_ListaProprietarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            DGV_ListaProprietarios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            DGV_ListaProprietarios.SelectedIndex = -1;
            DGV_ListaProprietarios.Size = new Size(791, 574);
            DGV_ListaProprietarios.StripeOddColor = Color.FromArgb(235, 243, 255);
            DGV_ListaProprietarios.TabIndex = 5039;
            // 
            // Btn_SalvarCadastroProprietario
            // 
            Btn_SalvarCadastroProprietario.Anchor = AnchorStyles.Left;
            Btn_SalvarCadastroProprietario.Font = new Font("Mongolian Baiti", 15.75F);
            Btn_SalvarCadastroProprietario.Image = Properties.Resources.icons8_salvar_32;
            Btn_SalvarCadastroProprietario.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_SalvarCadastroProprietario.Location = new Point(629, 858);
            Btn_SalvarCadastroProprietario.Name = "Btn_SalvarCadastroProprietario";
            Btn_SalvarCadastroProprietario.Size = new Size(200, 54);
            Btn_SalvarCadastroProprietario.TabIndex = 6;
            Btn_SalvarCadastroProprietario.Text = "   Salvar Cadastro";
            Btn_SalvarCadastroProprietario.TextAlign = ContentAlignment.MiddleLeft;
            Btn_SalvarCadastroProprietario.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_SalvarCadastroProprietario.UseVisualStyleBackColor = true;
            // 
            // TxB_NumeroProprietario
            // 
            TxB_NumeroProprietario.Anchor = AnchorStyles.Left;
            TxB_NumeroProprietario.Font = new Font("Microsoft Sans Serif", 12F);
            TxB_NumeroProprietario.Location = new Point(274, 514);
            TxB_NumeroProprietario.Margin = new Padding(4, 5, 4, 5);
            TxB_NumeroProprietario.MinimumSize = new Size(1, 16);
            TxB_NumeroProprietario.Name = "TxB_NumeroProprietario";
            TxB_NumeroProprietario.Padding = new Padding(5);
            TxB_NumeroProprietario.ShowText = false;
            TxB_NumeroProprietario.Size = new Size(217, 29);
            TxB_NumeroProprietario.TabIndex = 4;
            TxB_NumeroProprietario.TextAlignment = ContentAlignment.MiddleLeft;
            TxB_NumeroProprietario.Watermark = "";
            // 
            // uiLine1
            // 
            uiLine1.BackColor = Color.Transparent;
            uiLine1.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            uiLine1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLine1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine1.Location = new Point(3, 16);
            uiLine1.MinimumSize = new Size(1, 1);
            uiLine1.Name = "uiLine1";
            uiLine1.Size = new Size(17, 902);
            uiLine1.TabIndex = 5037;
            // 
            // uiLabel6
            // 
            uiLabel6.BackColor = Color.Transparent;
            uiLabel6.Enabled = false;
            uiLabel6.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel6.Location = new Point(26, 32);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(100, 23);
            uiLabel6.TabIndex = 3;
            uiLabel6.Text = "Empresa: ";
            // 
            // Lab_IdEmpresaViews
            // 
            Lab_IdEmpresaViews.Enabled = false;
            Lab_IdEmpresaViews.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lab_IdEmpresaViews.ForeColor = Color.FromArgb(48, 48, 48);
            Lab_IdEmpresaViews.Location = new Point(132, 32);
            Lab_IdEmpresaViews.Name = "Lab_IdEmpresaViews";
            Lab_IdEmpresaViews.Size = new Size(58, 23);
            Lab_IdEmpresaViews.TabIndex = 4;
            Lab_IdEmpresaViews.Text = "0";
            // 
            // uiLine4
            // 
            uiLine4.BackColor = Color.Transparent;
            uiLine4.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            uiLine4.Font = new Font("Microsoft Sans Serif", 12F);
            uiLine4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine4.Location = new Point(835, 17);
            uiLine4.MinimumSize = new Size(1, 1);
            uiLine4.Name = "uiLine4";
            uiLine4.Size = new Size(17, 905);
            uiLine4.TabIndex = 5036;
            // 
            // TxB_EmailProprietario
            // 
            TxB_EmailProprietario.Anchor = AnchorStyles.Left;
            TxB_EmailProprietario.Font = new Font("Microsoft Sans Serif", 12F);
            TxB_EmailProprietario.Location = new Point(213, 471);
            TxB_EmailProprietario.Margin = new Padding(4, 5, 4, 5);
            TxB_EmailProprietario.MinimumSize = new Size(1, 16);
            TxB_EmailProprietario.Name = "TxB_EmailProprietario";
            TxB_EmailProprietario.Padding = new Padding(5);
            TxB_EmailProprietario.ShowText = false;
            TxB_EmailProprietario.Size = new Size(563, 29);
            TxB_EmailProprietario.TabIndex = 2;
            TxB_EmailProprietario.TextAlignment = ContentAlignment.MiddleLeft;
            TxB_EmailProprietario.Watermark = "";
            // 
            // uiLabel4
            // 
            uiLabel4.Anchor = AnchorStyles.Left;
            uiLabel4.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(137, 477);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(69, 23);
            uiLabel4.TabIndex = 5035;
            uiLabel4.Text = "Email:";
            // 
            // TxB_DDDProprietario
            // 
            TxB_DDDProprietario.Anchor = AnchorStyles.Left;
            TxB_DDDProprietario.Font = new Font("Microsoft Sans Serif", 12F);
            TxB_DDDProprietario.Location = new Point(213, 514);
            TxB_DDDProprietario.Margin = new Padding(4, 5, 4, 5);
            TxB_DDDProprietario.MinimumSize = new Size(1, 16);
            TxB_DDDProprietario.Name = "TxB_DDDProprietario";
            TxB_DDDProprietario.Padding = new Padding(5);
            TxB_DDDProprietario.ShowText = false;
            TxB_DDDProprietario.Size = new Size(55, 29);
            TxB_DDDProprietario.TabIndex = 3;
            TxB_DDDProprietario.TextAlignment = ContentAlignment.MiddleLeft;
            TxB_DDDProprietario.Watermark = "";
            // 
            // uiLabel3
            // 
            uiLabel3.Anchor = AnchorStyles.Left;
            uiLabel3.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(114, 520);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(92, 23);
            uiLabel3.TabIndex = 5033;
            uiLabel3.Text = "Telefone:";
            // 
            // TxB_DocumentoProprietario
            // 
            TxB_DocumentoProprietario.Anchor = AnchorStyles.Left;
            TxB_DocumentoProprietario.Font = new Font("Microsoft Sans Serif", 12F);
            TxB_DocumentoProprietario.Location = new Point(213, 428);
            TxB_DocumentoProprietario.Margin = new Padding(4, 5, 4, 5);
            TxB_DocumentoProprietario.MinimumSize = new Size(1, 16);
            TxB_DocumentoProprietario.Name = "TxB_DocumentoProprietario";
            TxB_DocumentoProprietario.Padding = new Padding(5);
            TxB_DocumentoProprietario.ShowText = false;
            TxB_DocumentoProprietario.Size = new Size(563, 29);
            TxB_DocumentoProprietario.TabIndex = 1;
            TxB_DocumentoProprietario.TextAlignment = ContentAlignment.MiddleLeft;
            TxB_DocumentoProprietario.Watermark = "";
            // 
            // uiLabel2
            // 
            uiLabel2.Anchor = AnchorStyles.Left;
            uiLabel2.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(91, 434);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(115, 23);
            uiLabel2.TabIndex = 5031;
            uiLabel2.Text = "Documento:";
            // 
            // Combox_TipoPessoaProprietario
            // 
            Combox_TipoPessoaProprietario.Anchor = AnchorStyles.Left;
            Combox_TipoPessoaProprietario.DataSource = null;
            Combox_TipoPessoaProprietario.FillColor = Color.White;
            Combox_TipoPessoaProprietario.Font = new Font("Microsoft Sans Serif", 12F);
            Combox_TipoPessoaProprietario.ItemHoverColor = Color.FromArgb(155, 200, 255);
            Combox_TipoPessoaProprietario.Items.AddRange(new object[] { "Física", "Júridica" });
            Combox_TipoPessoaProprietario.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            Combox_TipoPessoaProprietario.Location = new Point(213, 555);
            Combox_TipoPessoaProprietario.Margin = new Padding(4, 5, 4, 5);
            Combox_TipoPessoaProprietario.MinimumSize = new Size(63, 0);
            Combox_TipoPessoaProprietario.Name = "Combox_TipoPessoaProprietario";
            Combox_TipoPessoaProprietario.Padding = new Padding(0, 0, 30, 2);
            Combox_TipoPessoaProprietario.Size = new Size(278, 29);
            Combox_TipoPessoaProprietario.SymbolSize = 24;
            Combox_TipoPessoaProprietario.TabIndex = 5;
            Combox_TipoPessoaProprietario.TextAlignment = ContentAlignment.MiddleLeft;
            Combox_TipoPessoaProprietario.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.Anchor = AnchorStyles.Left;
            uiLabel1.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(62, 561);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(144, 23);
            uiLabel1.TabIndex = 5027;
            uiLabel1.Text = "Tipo de pessoa:";
            // 
            // TxB_NomeProprietario
            // 
            TxB_NomeProprietario.Anchor = AnchorStyles.Left;
            TxB_NomeProprietario.Font = new Font("Microsoft Sans Serif", 12F);
            TxB_NomeProprietario.Location = new Point(213, 385);
            TxB_NomeProprietario.Margin = new Padding(4, 5, 4, 5);
            TxB_NomeProprietario.MinimumSize = new Size(1, 16);
            TxB_NomeProprietario.Name = "TxB_NomeProprietario";
            TxB_NomeProprietario.Padding = new Padding(5);
            TxB_NomeProprietario.ShowText = false;
            TxB_NomeProprietario.Size = new Size(563, 29);
            TxB_NomeProprietario.TabIndex = 0;
            TxB_NomeProprietario.TextAlignment = ContentAlignment.MiddleLeft;
            TxB_NomeProprietario.Watermark = "";
            // 
            // uiLabel25
            // 
            uiLabel25.Anchor = AnchorStyles.Left;
            uiLabel25.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel25.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel25.Location = new Point(137, 391);
            uiLabel25.Name = "uiLabel25";
            uiLabel25.Size = new Size(69, 23);
            uiLabel25.TabIndex = 5026;
            uiLabel25.Text = "Nome:";
            // 
            // uiAvatar1
            // 
            uiAvatar1.Anchor = AnchorStyles.Left;
            uiAvatar1.AvatarSize = 64;
            uiAvatar1.FillColor = Color.Transparent;
            uiAvatar1.Font = new Font("Microsoft Sans Serif", 12F);
            uiAvatar1.ForeColor = Color.RoyalBlue;
            uiAvatar1.Location = new Point(213, 309);
            uiAvatar1.MinimumSize = new Size(1, 1);
            uiAvatar1.Name = "uiAvatar1";
            uiAvatar1.Size = new Size(563, 68);
            uiAvatar1.Style = Sunny.UI.UIStyle.Custom;
            uiAvatar1.TabIndex = 0;
            uiAvatar1.Text = "uiAvatar1";
            // 
            // NovoProprietario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1661, 925);
            Controls.Add(uiGroupBox1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(640, 540);
            Name = "NovoProprietario";
            ShowIcon = false;
            Text = " Novo Proprietário";
            uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_ListaProprietarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox TxB_NomeProprietario;
        private Sunny.UI.UILabel uiLabel25;
        private Sunny.UI.UIComboBox Combox_TipoPessoaProprietario;
        private Sunny.UI.UITextBox TxB_DocumentoProprietario;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox TxB_DDDProprietario;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox TxB_EmailProprietario;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine4;
        private Sunny.UI.UITextBox TxB_NumeroProprietario;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel Lab_IdEmpresaViews;
        private Button Btn_SalvarCadastroProprietario;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIDataGridView DGV_ListaProprietarios;
    }
}