using salesforce_vtk.Controller;
using salesforce_vtk.Model;
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
        Costumer costumer;
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
            if (validateFields())
            {
                if (costumer == null)
                {
                    costumer = new Costumer();
                }

                costumer.name = txtName.Text;
                costumer.address = txtAddress.Text;
                costumer.reference = txtReference.Text;
                costumer.contact = txtContact.Text;

                /*if(dao.insert(costumer)){
                 * 
                }*/
            }
        }

        private void clearForm()
        {
            controller.clearFields(this.Controls);
            txtName.Focus();
        }

        private void FormCostumers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if((txtName.Text.Trim().Length > 0) || (txtAddress.Text.Trim().Length > 0) || (txtContact.Text.Trim().Length > 0))
                {
                    if(MessageBox.Show("Deseja realmente cancelar cadastro?","Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        clearForm();
                    }
                }
                else
                {
                    exit();
                }
            }
        }

        private bool validateFields()
        {
            notify.Clear();
            if (txtName.Text.Trim().Length < 5)
            {
                notify.SetError(txtName, "Nome inválido!");
                return false;
            }
            else if (txtAddress.Text.Trim().Length < 10)
            {
                notify.SetError(txtAddress, "Endereço inválido!");
                return false;
            }
            else if (txtContact.Text.Trim().Length < 10)
            {
                notify.SetError(txtContact, "Contato inválido!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void exit()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void FormCostumers_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
