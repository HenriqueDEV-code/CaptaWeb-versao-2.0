using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaptaWeb_Desktop.Views.Views_Paineis
{
    public partial class Imoveis : Form
    {
        private Action<Form, object> _openChild;
        public Imoveis(Action<Form, object> openChild)
        {
            InitializeComponent();
            this.KeyPreview = true; // <<< Permite que o formulário capture teclas
            this.KeyDown += new KeyEventHandler(this.Imoveis_keyDown); // <<< Associa o evento de tecla
            _openChild = openChild;
        }
        public Imoveis()
        {
            InitializeComponent();
            
        }

        private void Imoveis_keyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                _openChild(new Views_Paineis.PaineldeControle(_openChild), sender);
                e.Handled = true;
            }
        }

    }
}
