using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFStudents
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            tbBinded.DataBindings.Add("Text", nudBinded, "Value");

            Type dateTime = typeof(DateTime);
            var propertiesArray = dateTime.GetProperties();
            foreach (var i in propertiesArray)
            {
                tbDateTime.Text += i.Name + "\r\n";
            }
        }
    }
}
