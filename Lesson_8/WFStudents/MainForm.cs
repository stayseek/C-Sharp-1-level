//Домашнее задание №8
//Автор: Станислав Митрофанов

//1. С помощью рефлексии выведите все свойства структуры DateTime

//Реализовано в AboutForm

//2. Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством
//Value элемента NumericUpDown

//Реализовано в AboutForm

//3. а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок(не
//создана база данных, обращение к несуществующему вопросу, открытие слишком большого
//файла и т.д.).
//б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив
//другие «косметические» улучшения на свое усмотрение.
//в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия,
//авторские права и др.).
//г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных
//(элемент SaveFileDialog).
//4. * Используя полученные знания и класс TrueFalse в качестве шаблона, разработать
//собственную утилиту хранения данных(Например: Дни рождения, Траты, Напоминалка,
//Английские слова и другие).
//5. ** Написать программу-преобразователь из CSV в XML-файл с информацией о студентах(6
//урок)

//Функционал реализован в этом приложении.

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
    public partial class MainForm : Form
    {
        StudentsBase database;
        BindingSource bs;

        public MainForm()
        {
            InitializeComponent();
        }

        void UpdateDataBindings()
        {
            bs = new BindingSource();
            bs.DataSource = database;
            bs.DataMember = "List";
            tbFirstName.DataBindings.Add("Text", bs, "FirstName");
            tbLastName.DataBindings.Add("Text", bs, "LastName");
            tbUniversity.DataBindings.Add("Text", bs, "University");
            tbFaculty.DataBindings.Add("Text", bs, "Faculty");
            tbDepartment.DataBindings.Add("Text", bs, "Department");
            nudCourse.DataBindings.Add("Value", bs, "Course");
            nudAge.DataBindings.Add("Value", bs, "Age");
            nudGroup.DataBindings.Add("Value", bs, "Group");
            tbCity.DataBindings.Add("Text", bs, "City");
            bindingNavigator1.BindingSource = bs;
            DGV.DataSource = bs;
        }
        void ClearBindings()
        {
            tbFirstName.DataBindings.Clear();
            tbLastName.DataBindings.Clear();
            tbUniversity.DataBindings.Clear();
            tbFaculty.DataBindings.Clear();
            tbDepartment.DataBindings.Clear();
            nudCourse.DataBindings.Clear();
            nudAge.DataBindings.Clear();
            nudGroup.DataBindings.Clear();
            tbCity.DataBindings.Clear();
        }
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML файлы|*.xml|Все файлы(*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new StudentsBase(saveFileDialog.FileName);
                this.Text = saveFileDialog.FileName;
                ClearBindings();
                UpdateDataBindings();
            };

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML файлы|*.xml|Все файлы(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new StudentsBase(openFileDialog.FileName);
                database.Load();
                this.Text = openFileDialog.FileName;

                ClearBindings();
                UpdateDataBindings();
                
            }
        }

        private void импортироватьИзCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV файлы|*.csv|Все файлы(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new StudentsBase(string.Empty);
                database.ImportFromCSV(openFileDialog.FileName);
                this.Text = openFileDialog.FileName;

                ClearBindings();
                UpdateDataBindings();
                
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                if (database.FileName == string.Empty)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "XML файлы|*.xml|Все файлы(*.*)|*.*";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        database.FileName = saveFileDialog.FileName;
                        this.Text = saveFileDialog.FileName;
                    }
                }
                database.Save(database.FileName);
            }
            else
            {
                MessageBox.Show("Для продолжения работы создайте,\nоткройте или импортируйте базу.","База не создана");
            }

        }

        private void сохранитькакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XML файлы|*.xml|Все файлы(*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    database.Save(saveFileDialog.FileName);
                    this.Text = saveFileDialog.FileName;
                }
            }
            else
            {
                MessageBox.Show("Для продолжения работы создайте,\nоткройте или импортируйте базу.", "База не создана");
            }
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                bs.EndEdit();
                e.Handled = true;
            }
        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                bs.EndEdit();
                e.Handled = true;
            }
        }

        private void tbUniversity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                bs.EndEdit();
                e.Handled = true;
            }
        }

        private void tbFaculty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                bs.EndEdit();
                e.Handled = true;
            }
        }

        private void tbDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                bs.EndEdit();
                e.Handled = true;
            }
        }

        private void tbCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                bs.EndEdit();
                e.Handled = true;
            }
        }

        private void nudCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                bs.EndEdit();
                e.Handled = true;
            }
        }

        private void nudAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                bs.EndEdit();
                e.Handled = true;
            }
        }

        private void nudGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                bs.EndEdit();
                e.Handled = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (database != null)
            {
                if (MessageBox.Show("Вы хотите сохранить данные?", "Выход из программы.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (database.FileName == string.Empty)
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "XML файлы|*.xml|Все файлы(*.*)|*.*";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            database.FileName = saveFileDialog.FileName;
                            this.Text = saveFileDialog.FileName;
                        }
                    }
                    database.Save(database.FileName);
                }
            }
        }
    }
}
