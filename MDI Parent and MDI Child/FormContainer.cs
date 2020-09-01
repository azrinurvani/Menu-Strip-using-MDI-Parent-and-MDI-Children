using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Parent_and_MDI_Child
{
    public partial class formContainer : Form
    {
        public formContainer()
        {
            InitializeComponent();
        }

        //this form will open only one time
        private void openSingleTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach(Form f in Application.OpenForms)
            {
                if(f.Text == "Form1")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                Form1 f1 = new Form1();
                f1.MdiParent = this;
                f1.Show();
            }
        }

        private void openMultipleTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();

        }

        private void closeAllOpenFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form form in this.MdiChildren)
            {
                if (!form.Focused)
                {
                    form.Visible = false;
                    form.Dispose();
                }
            }
            //Note: Active Form will Not Closed
        }
    }
}
