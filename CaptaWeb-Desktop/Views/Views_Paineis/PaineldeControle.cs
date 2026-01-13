using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaptaWeb_Desktop.Views.Views_Paineis
{
    public partial class PaineldeControle : Form
    {

        public PaineldeControle(Action<Form, object> openChild)
        {
            InitializeComponent();
            
            
        }
        public PaineldeControle()
        {
            InitializeComponent();
        }



    }
}
