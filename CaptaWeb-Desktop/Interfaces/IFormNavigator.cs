using CaptaWeb_Desktop.Views.Views_Paineis;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptaWeb_Desktop.Interfaces
{
    public interface IFormNavigator
    {
        void Navigate(FormatException childForm, Object? btnSender = null);
        
    }
}
