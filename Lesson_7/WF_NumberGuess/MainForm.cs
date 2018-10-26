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
    public partial class MainForm : Form
    {
        NumberClass guessingNumber;
        InputForm inputForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblResult.Text = "Угадайте число от 1 до 100";
            guessingNumber = new NumberClass(1, 100);
            inputForm = new InputForm(this);
            inputForm.Show();
        }

        public void CheckNumber(int testNumber)
        {
            if (testNumber > guessingNumber.Number)
            {
                lblResult.Text =  $"{testNumber} больше загаданного.";
            }
            else if (testNumber < guessingNumber.Number)
            {
                lblResult.Text = $"{testNumber} меньше загаданного.";
            }
            else
            {
                lblResult.Text = "Поздравляю! Вы угадали число.";
                var result = MessageBox.Show("Начать новую игру?", "Победа", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    lblResult.Text = "Угадайте число от 1 до 100";
                    guessingNumber.GetNewNumber(1, 100);
                }
                else
                {
                    this.Close();
                }
            }
                
        }
    }
}
