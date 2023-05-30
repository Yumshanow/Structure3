using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct student
        {
            public int rus;
            public int phis;
            public int math;

            public student(int rus, int math, int phis)
            {
                this.rus = rus;
                this.math = math;
                this.phis = phis;
            }

            public double getAver()
            {
                return (rus + math + phis) / 3;
            }
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            student[] student = new student[10];
            Random rnd = new Random();

            for (int i = 0; i < student.Length; i++)
            {
                int f = rnd.Next(2, 6);
                int s = rnd.Next(2, 6);
                int t = rnd.Next(2, 6);

                student[i] = new student(f, s, t);

                listBox1.Items.Add($"Ученик {i + 1}:");
                listBox1.Items.Add($"Русский: { f}, Математика: { s}, Физика: { t}");


            }


            double sum = 0;
            for (int i = 0; i < student.Length; i++)
            {
                double aver = student[i].getAver();
                listBox1.Items.Add($"Средний балл ученика {i + 1}: {aver}");
                sum += aver;

            }

            double ClassAver = sum / student.Length;
            MessageBox.Show($"Средний балл класса: {ClassAver}");

            listBox1.Items.Add("Ученики, баллы которых выше среднего балла в классе");
            for (int i = 0; i < student.Length; i++)
            {
                double aver = student[i].getAver();
                
                if (aver > ClassAver)
                {

                    listBox1.Items.Add($"Средний балл ученика {i + 1}: {aver}");
                }
            }
        }
    }
}
