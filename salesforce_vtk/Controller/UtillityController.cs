using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salesforce_vtk.Controller
{
    class UtillityController
    {
        public void clearFields(Control.ControlCollection cs)
        {
            foreach(Control c in cs)
            {
                if(c is TextBox)
                {
                    TextBox txt = (TextBox)c;
                    txt.Text = String.Empty;
                }
            }
        }
    }
}
