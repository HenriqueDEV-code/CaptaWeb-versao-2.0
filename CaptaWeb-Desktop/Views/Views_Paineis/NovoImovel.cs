using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CaptaWeb_Desktop.Interfaces;

namespace CaptaWeb_Desktop.Views.Views_Paineis
{


    public partial class NovoImovel : Form
    {
        private Action<Form, object> _openChild;

        public NovoImovel(Action<Form, object> openChild)
        {
            InitializeComponent();
            _openChild = openChild;
        }
        public NovoImovel()
        {
            InitializeComponent();
           
        }

        private void Btn_Novo_proprietario_Click(object sender, EventArgs e)
        {
            _openChild(new Views_Paineis.NovoProprietario(_openChild), sender);
        }
    }
}
