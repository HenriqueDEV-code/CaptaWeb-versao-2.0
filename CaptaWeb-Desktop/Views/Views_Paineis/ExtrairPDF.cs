using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaptaWeb_Desktop.Views.Views_Paineis
{
    public partial class ExtrairPDF : Form
    {
        private Action<Form, object> _openChild;
        public ExtrairPDF(Action<Form, object> openChild)
        {
            InitializeComponent();
            this.KeyPreview = true; // <<< Permite que o formulário capture teclas
            this.KeyDown += new KeyEventHandler(this.ExtrairPDF_KeyDown); // <<< Associa o evento de tecla
            _openChild = openChild;
        }
        public ExtrairPDF()
        {
            InitializeComponent();
            
        }




        private void ExtrairPDF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                _openChild(new Views_Paineis.PaineldeControle(_openChild), sender);
                e.Handled = true;
            }

        }
    }
}
