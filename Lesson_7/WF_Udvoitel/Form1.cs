using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Udvoitel
{
    public partial class MainForm : Form
    {
        Udvoitel udvoitel;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            udvoitel = new Udvoitel(10, 100);
            UpdateInfo();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            udvoitel.Reset();
            UpdateInfo();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            udvoitel.Undo();
            UpdateInfo();
        }

        private void btnMulty_Click(object sender, EventArgs e)
        {
            udvoitel.Multi();
            UpdateInfo();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            udvoitel.Plus();
            UpdateInfo();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            udvoitel.GenFinish(10, 100);
            UpdateInfo();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateInfo()
        {
            lblNumber.Text = udvoitel.Finish.ToString();
            lblCurNumber.Text = udvoitel.Current.ToString();
            lblCurSteps.Text = udvoitel.StepsDone.ToString();
            //Код окончания игры.
            if (udvoitel.Current == udvoitel.Finish)
            {
                MessageBox.Show($"Вы достигли необходимого числа.\nВы сделали {udvoitel.StepsDone} ходов.\nЭто можно было сделать за {udvoitel.MinSteps} ходов.", "Победа!");
                udvoitel.GenFinish(10, 100);
                UpdateInfo();
            }

        }
    }
}
