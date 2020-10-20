using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)//кнопка запуск
        {
            double a, b, c;
            if (txtA.Text == "" && txtB.Text == "" && txtC.Text == "")
            {
                a = 7;
                b = 5;
                c = 2;
            }
            else
            {
                a = Convert.ToDouble(txtA.Text);// считываем значение стороны а
                b = Convert.ToDouble(txtB.Text);// считываем значение стороны b
                c = Convert.ToDouble(txtC.Text);// считываем значение стороны c
            }
            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Add("Сторона а");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Высота  h");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.HeightOfTriangle()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { listView1.Items[6].SubItems.Add("Существует"); }
            else listView1.Items[6].SubItems.Add("Не существует");
            listView1.Items[7].SubItems.Add(triangle.TypeOfTriangle());
            pictureBox1.Image = Image.FromFile(triangle.ImageType());

        }
        private void Run_button_DobleClick(object sender, MouseEventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}