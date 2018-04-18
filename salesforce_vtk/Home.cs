using salesforce_vtk.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salesforce_vtk
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape){
                this.Close();
            }else if (e.KeyCode == Keys.F1){
                openForm(1);
            }else if (e.KeyCode == Keys.F2){
                openForm(2);
            }
            else if (e.KeyCode == Keys.F3){
                openForm(3);
            }
        }

        private void btnCostumers_Click(object sender, EventArgs e)
        {
            openForm(1);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            openForm(2);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            openForm(3);
        }

        private void openForm(int i)
        {
            switch (i)
            {
                case 1:
                    FormCostumers fc = new FormCostumers();
                    this.Visible = false;
                    fc.ShowDialog();
                    if (fc.DialogResult == DialogResult.OK)
                    {
                        this.Visible = true;
                    }
                    break;
                case 2:
                    FormProducts fp = new FormProducts();
                    this.Visible = false;
                    fp.ShowDialog();
                    if (fp.DialogResult == DialogResult.OK)
                    {
                        this.Visible = true;
                    }
                    break;
                case 3:
                    FormSales fs = new FormSales();
                    this.Visible = false;
                    fs.ShowDialog();
                    if (fs.DialogResult == DialogResult.OK)
                    {
                        this.Visible = true;
                    }
                    break;
            }
        }
    }
}
