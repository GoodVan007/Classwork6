using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class MainForm : Form
    {

        private AuxiliaryForm form;

        public MainForm()
        {
            InitializeComponent();

            form = new AuxiliaryForm();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }       

        private void openButton1_Click(object sender, EventArgs e)
        {
            //var form = new AuxiliaryForm();
            form.Show();
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
