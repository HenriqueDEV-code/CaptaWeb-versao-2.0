using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaptaWeb_Desktop.Views.Views_Paineis
{
    public partial class ExtrairTXT : Form
    {
        private Action<Form, object> _openChild;
        public ExtrairTXT(Action<Form, object> openChild)
        {
            InitializeComponent();
            _openChild = openChild;
            this.KeyPreview = true; // <<< Permite que o formulário capture teclas
            this.KeyDown += new KeyEventHandler(this.ExtrairTXT_KeyDown); // <<< Associa o evento de tecla
        }

        public ExtrairTXT()
        {
            InitializeComponent();
        }


        private void ExtrairTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                _openChild(new Views_Paineis.PaineldeControle(_openChild), sender);
                e.Handled = true;
            }

        }



    }
}
