using salesforce_vtk.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salesforce_vtk.View
{
    public partial class FormCostumers : Form
    {
        UtillityController controller;
        public FormCostumers()
        {
            InitializeComponent();
            controller = new UtillityController();
        }

        private void FormCostumers_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            controller.clearFields(this.Controls);
            txtName.Focus();
        }

        private void FormCostumers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                exit();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (validateFields())
                {
                    clear();
                }
            }
        }

        private bool validateFields()
        {
            return true;
        }

        private void exit()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
