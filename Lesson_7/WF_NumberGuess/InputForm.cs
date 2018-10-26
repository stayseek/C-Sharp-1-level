using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_NumberGuess
{
    public partial class InputForm : Form
    {
        MainForm mainForm;

        public InputForm()
        {
            InitializeComponent();
        }

        public InputForm ( MainForm mainForm ) : this()
        {
            this.mainForm = mainForm;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            mainForm.CheckNumber(int.Parse(tbNumber.Text));
            tbNumber.Clear();
        }
    }
}
