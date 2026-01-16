namespace CaptaWeb_Desktop.Views.Views_Paineis
{
    partial class Imoveis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imoveis));
            uiPanel3 = new Sunny.UI.UIPanel();
            uiLabel5 = new Sunny.UI.UILabel();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            uiPanel2 = new Sunny.UI.UIPanel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel6 = new Sunny.UI.UILabel();
            uiLabel7 = new Sunny.UI.UILabel();
            uiLabel8 = new Sunny.UI.UILabel();
            uiLabel9 = new Sunny.UI.UILabel();
            uiLabel11 = new Sunny.UI.UILabel();
            uiPanel1 = new Sunny.UI.UIPanel();
            Txb_NumeroAp_Filtro = new Sunny.UI.UITextBox();
            uiLabel13 = new Sunny.UI.UILabel();
            DataTimeFim_Filtro = new DateTimePicker();
            uiLabel12 = new Sunny.UI.UILabel();
            Combox_Numero_Filtro = new Sunny.UI.UITextBox();
            uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            Txb_Rua_Filtro = new Sunny.UI.UITextBox();
            Txb_Contato_Filtro = new Sunny.UI.UITextBox();
            DataTimeInicio_Filtro = new DateTimePicker();
            Txb_Nome_Filtro = new Sunny.UI.UITextBox();
            Combox_Pretensao_Filtro = new Sunny.UI.UIComboBox();
            Combox_Condominio_Filtro = new Sunny.UI.UIComboBox();
            Combox_Bairro_Filtro = new Sunny.UI.UIComboBox();
            uiLabel10 = new Sunny.UI.UILabel();
            uiPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            uiPanel2.SuspendLayout();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel3
            // 
            uiPanel3.Controls.Add(uiLabel5);
            uiPanel3.Controls.Add(uiDataGridView1);
            uiPanel3.Dock = DockStyle.Fill;
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel3.Location = new Point(389, 0);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Size = new Size(1272, 925);
            uiPanel3.TabIndex = 5041;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabel5
            // 
            uiLabel5.BackColor = Color.Transparent;
            uiLabel5.Font = new Font("Sans Serif Collection", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(12, 6);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(361, 67);
            uiLabel5.TabIndex = 5041;
            uiLabel5.Text = "LISTA DE IMÓVEIS";
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiDataGridView1.BackgroundColor = Color.White;
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("Microsoft Sans Serif", 12F);
            uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.Location = new Point(12, 79);
            uiDataGridView1.Name = "uiDataGridView1";
            uiDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.Size = new Size(1248, 834);
            uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.TabIndex = 12;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(uiLabel1);
            uiPanel2.Dock = DockStyle.Top;
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(0, 0);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new Size(389, 81);
            uiPanel2.TabIndex = 5040;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            uiLabel1.Font = new Font("Sans Serif Collection", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(91, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(159, 73);
            uiLabel1.TabIndex = 5042;
            uiLabel1.Text = "Filtrar";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(4, 112);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(132, 23);
            uiLabel2.TabIndex = 5042;
            uiLabel2.Text = "Data Início";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(3, 192);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(66, 23);
            uiLabel3.TabIndex = 5043;
            uiLabel3.Text = "Nome";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(1, 233);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(83, 23);
            uiLabel4.TabIndex = 5046;
            uiLabel4.Text = "Contato";
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel6.Location = new Point(5, 274);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(50, 23);
            uiLabel6.TabIndex = 5047;
            uiLabel6.Text = "Rua";
            // 
            // uiLabel7
            // 
            uiLabel7.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel7.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel7.Location = new Point(5, 315);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new Size(64, 23);
            uiLabel7.TabIndex = 5049;
            uiLabel7.Text = "Bairro";
            // 
            // uiLabel8
            // 
            uiLabel8.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel8.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel8.Location = new Point(5, 356);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new Size(118, 23);
            uiLabel8.TabIndex = 5051;
            uiLabel8.Text = "Condomínio";
            // 
            // uiLabel9
            // 
            uiLabel9.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel9.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel9.Location = new Point(5, 397);
            uiLabel9.Name = "uiLabel9";
            uiLabel9.Size = new Size(118, 23);
            uiLabel9.TabIndex = 5053;
            uiLabel9.Text = "Pretensão";
            // 
            // uiLabel11
            // 
            uiLabel11.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel11.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel11.Location = new Point(3, 438);
            uiLabel11.Name = "uiLabel11";
            uiLabel11.Size = new Size(133, 23);
            uiLabel11.TabIndex = 5056;
            uiLabel11.Text = "Número";
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(Txb_NumeroAp_Filtro);
            uiPanel1.Controls.Add(uiLabel13);
            uiPanel1.Controls.Add(DataTimeFim_Filtro);
            uiPanel1.Controls.Add(uiLabel12);
            uiPanel1.Controls.Add(Combox_Numero_Filtro);
            uiPanel1.Controls.Add(uiCheckBoxGroup1);
            uiPanel1.Controls.Add(Txb_Rua_Filtro);
            uiPanel1.Controls.Add(Txb_Contato_Filtro);
            uiPanel1.Controls.Add(DataTimeInicio_Filtro);
            uiPanel1.Controls.Add(Txb_Nome_Filtro);
            uiPanel1.Controls.Add(uiLabel11);
            uiPanel1.Controls.Add(uiLabel9);
            uiPanel1.Controls.Add(Combox_Pretensao_Filtro);
            uiPanel1.Controls.Add(uiLabel8);
            uiPanel1.Controls.Add(Combox_Condominio_Filtro);
            uiPanel1.Controls.Add(uiLabel7);
            uiPanel1.Controls.Add(Combox_Bairro_Filtro);
            uiPanel1.Controls.Add(uiLabel6);
            uiPanel1.Controls.Add(uiLabel4);
            uiPanel1.Controls.Add(uiLabel3);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(uiPanel2);
            uiPanel1.Controls.Add(uiLabel10);
            uiPanel1.Dock = DockStyle.Left;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(389, 925);
            uiPanel1.TabIndex = 5039;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // Txb_NumeroAp_Filtro
            // 
            Txb_NumeroAp_Filtro.Font = new Font("Microsoft Sans Serif", 12F);
            Txb_NumeroAp_Filtro.Location = new Point(148, 473);
            Txb_NumeroAp_Filtro.Margin = new Padding(4, 5, 4, 5);
            Txb_NumeroAp_Filtro.MinimumSize = new Size(1, 16);
            Txb_NumeroAp_Filtro.Multiline = true;
            Txb_NumeroAp_Filtro.Name = "Txb_NumeroAp_Filtro";
            Txb_NumeroAp_Filtro.Padding = new Padding(5);
            Txb_NumeroAp_Filtro.ShowText = false;
            Txb_NumeroAp_Filtro.Size = new Size(234, 29);
            Txb_NumeroAp_Filtro.TabIndex = 10;
            Txb_NumeroAp_Filtro.TextAlignment = ContentAlignment.MiddleLeft;
            Txb_NumeroAp_Filtro.Watermark = "";
            // 
            // uiLabel13
            // 
            uiLabel13.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel13.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel13.Location = new Point(5, 479);
            uiLabel13.Name = "uiLabel13";
            uiLabel13.Size = new Size(133, 23);
            uiLabel13.TabIndex = 5065;
            uiLabel13.Text = "Número Ap.";
            // 
            // DataTimeFim_Filtro
            // 
            DataTimeFim_Filtro.CalendarForeColor = Color.FromArgb(80, 160, 255);
            DataTimeFim_Filtro.CalendarMonthBackground = Color.White;
            DataTimeFim_Filtro.CalendarTitleForeColor = Color.FromArgb(80, 160, 255);
            DataTimeFim_Filtro.CalendarTrailingForeColor = Color.FromArgb(80, 160, 255);
            DataTimeFim_Filtro.Checked = false;
            DataTimeFim_Filtro.Cursor = Cursors.Hand;
            DataTimeFim_Filtro.Font = new Font("Microsoft Sans Serif", 12F);
            DataTimeFim_Filtro.Location = new Point(146, 147);
            DataTimeFim_Filtro.Margin = new Padding(4, 5, 4, 5);
            DataTimeFim_Filtro.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            DataTimeFim_Filtro.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            DataTimeFim_Filtro.MinimumSize = new Size(63, 0);
            DataTimeFim_Filtro.Name = "DataTimeFim_Filtro";
            DataTimeFim_Filtro.RightToLeft = RightToLeft.No;
            DataTimeFim_Filtro.ShowCheckBox = true;
            DataTimeFim_Filtro.Size = new Size(234, 26);
            DataTimeFim_Filtro.TabIndex = 2;
            DataTimeFim_Filtro.Value = new DateTime(2026, 1, 13, 10, 40, 36, 676);
            // 
            // uiLabel12
            // 
            uiLabel12.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel12.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel12.Location = new Point(3, 150);
            uiLabel12.Name = "uiLabel12";
            uiLabel12.Size = new Size(133, 23);
            uiLabel12.TabIndex = 5063;
            uiLabel12.Text = "Data Fim";
            // 
            // Combox_Numero_Filtro
            // 
            Combox_Numero_Filtro.Font = new Font("Microsoft Sans Serif", 12F);
            Combox_Numero_Filtro.Location = new Point(146, 432);
            Combox_Numero_Filtro.Margin = new Padding(4, 5, 4, 5);
            Combox_Numero_Filtro.MinimumSize = new Size(1, 16);
            Combox_Numero_Filtro.Multiline = true;
            Combox_Numero_Filtro.Name = "Combox_Numero_Filtro";
            Combox_Numero_Filtro.Padding = new Padding(5);
            Combox_Numero_Filtro.ShowText = false;
            Combox_Numero_Filtro.Size = new Size(234, 29);
            Combox_Numero_Filtro.TabIndex = 9;
            Combox_Numero_Filtro.TextAlignment = ContentAlignment.MiddleLeft;
            Combox_Numero_Filtro.Watermark = "";
            // 
            // uiCheckBoxGroup1
            // 
            uiCheckBoxGroup1.Cursor = Cursors.Hand;
            uiCheckBoxGroup1.Font = new Font("Microsoft Sans Serif", 12F);
            uiCheckBoxGroup1.Items.AddRange(new object[] { "Apartamento", "Casa", "Casa Condomínio", "Terreno", "Flat", "Kitnet", "Chacara" });
            uiCheckBoxGroup1.Location = new Point(146, 497);
            uiCheckBoxGroup1.Margin = new Padding(4, 5, 4, 5);
            uiCheckBoxGroup1.MinimumSize = new Size(1, 1);
            uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            uiCheckBoxGroup1.Padding = new Padding(0, 32, 0, 0);
            uiCheckBoxGroup1.SelectedIndexes = (List<int>)resources.GetObject("uiCheckBoxGroup1.SelectedIndexes");
            uiCheckBoxGroup1.Size = new Size(234, 254);
            uiCheckBoxGroup1.TabIndex = 11;
            uiCheckBoxGroup1.Text = null;
            uiCheckBoxGroup1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // Txb_Rua_Filtro
            // 
            Txb_Rua_Filtro.Font = new Font("Microsoft Sans Serif", 12F);
            Txb_Rua_Filtro.Location = new Point(146, 268);
            Txb_Rua_Filtro.Margin = new Padding(4, 5, 4, 5);
            Txb_Rua_Filtro.MinimumSize = new Size(1, 16);
            Txb_Rua_Filtro.Multiline = true;
            Txb_Rua_Filtro.Name = "Txb_Rua_Filtro";
            Txb_Rua_Filtro.Padding = new Padding(5);
            Txb_Rua_Filtro.ShowText = false;
            Txb_Rua_Filtro.Size = new Size(234, 29);
            Txb_Rua_Filtro.TabIndex = 5;
            Txb_Rua_Filtro.TextAlignment = ContentAlignment.MiddleLeft;
            Txb_Rua_Filtro.Watermark = "";
            // 
            // Txb_Contato_Filtro
            // 
            Txb_Contato_Filtro.Font = new Font("Microsoft Sans Serif", 12F);
            Txb_Contato_Filtro.Location = new Point(146, 227);
            Txb_Contato_Filtro.Margin = new Padding(4, 5, 4, 5);
            Txb_Contato_Filtro.MinimumSize = new Size(1, 16);
            Txb_Contato_Filtro.Multiline = true;
            Txb_Contato_Filtro.Name = "Txb_Contato_Filtro";
            Txb_Contato_Filtro.Padding = new Padding(5);
            Txb_Contato_Filtro.ShowText = false;
            Txb_Contato_Filtro.Size = new Size(234, 29);
            Txb_Contato_Filtro.TabIndex = 4;
            Txb_Contato_Filtro.TextAlignment = ContentAlignment.MiddleLeft;
            Txb_Contato_Filtro.Watermark = "";
            // 
            // DataTimeInicio_Filtro
            // 
            DataTimeInicio_Filtro.CalendarForeColor = Color.FromArgb(80, 160, 255);
            DataTimeInicio_Filtro.CalendarMonthBackground = Color.White;
            DataTimeInicio_Filtro.CalendarTitleForeColor = Color.FromArgb(80, 160, 255);
            DataTimeInicio_Filtro.CalendarTrailingForeColor = Color.FromArgb(80, 160, 255);
            DataTimeInicio_Filtro.Checked = false;
            DataTimeInicio_Filtro.Cursor = Cursors.Hand;
            DataTimeInicio_Filtro.Font = new Font("Microsoft Sans Serif", 12F);
            DataTimeInicio_Filtro.Location = new Point(147, 109);
            DataTimeInicio_Filtro.Margin = new Padding(4, 5, 4, 5);
            DataTimeInicio_Filtro.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            DataTimeInicio_Filtro.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            DataTimeInicio_Filtro.MinimumSize = new Size(63, 0);
            DataTimeInicio_Filtro.Name = "DataTimeInicio_Filtro";
            DataTimeInicio_Filtro.RightToLeft = RightToLeft.No;
            DataTimeInicio_Filtro.ShowCheckBox = true;
            DataTimeInicio_Filtro.Size = new Size(234, 26);
            DataTimeInicio_Filtro.TabIndex = 1;
            DataTimeInicio_Filtro.Value = new DateTime(2026, 1, 13, 10, 40, 36, 676);
            // 
            // Txb_Nome_Filtro
            // 
            Txb_Nome_Filtro.Font = new Font("Microsoft Sans Serif", 12F);
            Txb_Nome_Filtro.Location = new Point(146, 186);
            Txb_Nome_Filtro.Margin = new Padding(4, 5, 4, 5);
            Txb_Nome_Filtro.MinimumSize = new Size(1, 16);
            Txb_Nome_Filtro.Multiline = true;
            Txb_Nome_Filtro.Name = "Txb_Nome_Filtro";
            Txb_Nome_Filtro.Padding = new Padding(5);
            Txb_Nome_Filtro.ShowText = false;
            Txb_Nome_Filtro.Size = new Size(234, 29);
            Txb_Nome_Filtro.TabIndex = 3;
            Txb_Nome_Filtro.TextAlignment = ContentAlignment.MiddleLeft;
            Txb_Nome_Filtro.Watermark = "";
            // 
            // Combox_Pretensao_Filtro
            // 
            Combox_Pretensao_Filtro.DataSource = null;
            Combox_Pretensao_Filtro.FillColor = Color.White;
            Combox_Pretensao_Filtro.Font = new Font("Microsoft Sans Serif", 12F);
            Combox_Pretensao_Filtro.ItemHoverColor = Color.FromArgb(155, 200, 255);
            Combox_Pretensao_Filtro.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            Combox_Pretensao_Filtro.Location = new Point(146, 391);
            Combox_Pretensao_Filtro.Margin = new Padding(4, 5, 4, 5);
            Combox_Pretensao_Filtro.MinimumSize = new Size(63, 0);
            Combox_Pretensao_Filtro.Name = "Combox_Pretensao_Filtro";
            Combox_Pretensao_Filtro.Padding = new Padding(0, 0, 30, 2);
            Combox_Pretensao_Filtro.Size = new Size(234, 29);
            Combox_Pretensao_Filtro.SymbolSize = 24;
            Combox_Pretensao_Filtro.TabIndex = 8;
            Combox_Pretensao_Filtro.TextAlignment = ContentAlignment.MiddleLeft;
            Combox_Pretensao_Filtro.Watermark = "";
            // 
            // Combox_Condominio_Filtro
            // 
            Combox_Condominio_Filtro.DataSource = null;
            Combox_Condominio_Filtro.FillColor = Color.White;
            Combox_Condominio_Filtro.Font = new Font("Microsoft Sans Serif", 12F);
            Combox_Condominio_Filtro.ItemHoverColor = Color.FromArgb(155, 200, 255);
            Combox_Condominio_Filtro.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            Combox_Condominio_Filtro.Location = new Point(146, 350);
            Combox_Condominio_Filtro.Margin = new Padding(4, 5, 4, 5);
            Combox_Condominio_Filtro.MinimumSize = new Size(63, 0);
            Combox_Condominio_Filtro.Name = "Combox_Condominio_Filtro";
            Combox_Condominio_Filtro.Padding = new Padding(0, 0, 30, 2);
            Combox_Condominio_Filtro.Size = new Size(234, 29);
            Combox_Condominio_Filtro.SymbolSize = 24;
            Combox_Condominio_Filtro.TabIndex = 7;
            Combox_Condominio_Filtro.TextAlignment = ContentAlignment.MiddleLeft;
            Combox_Condominio_Filtro.Watermark = "";
            // 
            // Combox_Bairro_Filtro
            // 
            Combox_Bairro_Filtro.DataSource = null;
            Combox_Bairro_Filtro.FillColor = Color.White;
            Combox_Bairro_Filtro.Font = new Font("Microsoft Sans Serif", 12F);
            Combox_Bairro_Filtro.ItemHoverColor = Color.FromArgb(155, 200, 255);
            Combox_Bairro_Filtro.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            Combox_Bairro_Filtro.Location = new Point(146, 309);
            Combox_Bairro_Filtro.Margin = new Padding(4, 5, 4, 5);
            Combox_Bairro_Filtro.MinimumSize = new Size(63, 0);
            Combox_Bairro_Filtro.Name = "Combox_Bairro_Filtro";
            Combox_Bairro_Filtro.Padding = new Padding(0, 0, 30, 2);
            Combox_Bairro_Filtro.Size = new Size(234, 29);
            Combox_Bairro_Filtro.SymbolSize = 24;
            Combox_Bairro_Filtro.TabIndex = 6;
            Combox_Bairro_Filtro.TextAlignment = ContentAlignment.MiddleLeft;
            Combox_Bairro_Filtro.Watermark = "";
            // 
            // uiLabel10
            // 
            uiLabel10.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel10.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel10.Location = new Point(2, 518);
            uiLabel10.Name = "uiLabel10";
            uiLabel10.Size = new Size(148, 23);
            uiLabel10.TabIndex = 5055;
            uiLabel10.Text = "Tipo de imóvel";
            // 
            // Imoveis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1661, 925);
            Controls.Add(uiPanel3);
            Controls.Add(uiPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(640, 540);
            Name = "Imoveis";
            ShowIcon = false;
            Text = " Lista de Imoveis";
            uiPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            uiPanel2.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITextBox Txb_Nome_Filtro;
        private Sunny.UI.UITextBox Combox_Numero_Filtro;
        private Sunny.UI.UIComboBox Combox_Pretensao_Filtro;
        private Sunny.UI.UIComboBox Combox_Condominio_Filtro;
        private Sunny.UI.UIComboBox Combox_Bairro_Filtro;
        private DateTimePicker DataTimeInicio_Filtro;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup1;
        private Sunny.UI.UITextBox Txb_Rua_Filtro;
        private Sunny.UI.UITextBox Txb_Contato_Filtro;
        private Sunny.UI.UILabel uiLabel10;
        private DateTimePicker DataTimeFim_Filtro;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UITextBox Txb_NumeroAp_Filtro;
        private Sunny.UI.UILabel uiLabel13;
    }
}