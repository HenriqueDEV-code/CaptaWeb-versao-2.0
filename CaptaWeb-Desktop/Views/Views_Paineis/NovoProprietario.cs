using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace CaptaWeb_Desktop.Views.Views_Paineis
{
    public partial class NovoProprietario : Form
    {
        public NovoProprietario(Action<Form, object> openChild)
        {
            InitializeComponent();
        }
        public NovoProprietario()
        {
            InitializeComponent();
        }
    }
}
