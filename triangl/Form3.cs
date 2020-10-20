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
    public partial class Form3 : Form
    {
        ListBox list_;
        Button btn;
        Label lblA, lblB, lblC, lblH;
        TextBox txtA, txtB, txtC, txtH;
        PictureBox pic1;
        public Form3()
        {
            this.Height = 500;
            this.Width = 600;
            this.Text = "Windows Form Triangle";
            list_ = new ListBox();
            list_.Location = new Point(10, 10);
            list_.Size = new Size(265, 150);
            list_.Items.Add("Таблица");
            list_.BackColor = Color.AntiqueWhite;

            btn = new Button();
            btn.Location = new Point(100, 350);
            btn.Size = new Size(80, 40);
            btn.Click += Btn_Click;
            btn.Text = "Запуск";
            btn.BackColor = Color.LightPink;

            lblA = new Label();
            lblA.Size = new Size(70, 30);
            lblA.Location = new Point(50, 180);
            lblA.Text = "Сторона А";

            lblB = new Label();
            lblB.Size = new Size(70, 30);
            lblB.Location = new Point(50, 210);
            lblB.Text = "Сторона B";

            lblC = new Label();
            lblC.Size = new Size(70, 30);
            lblC.Location = new Point(50, 240);
            lblC.Text = "Сторона C";

            lblH = new Label();
            lblH.Size = new Size(70, 30);
            lblH.Location = new Point(50, 270);
            lblH.Text = "Сторона H";

            txtA = new TextBox();
            txtA.Location = new Point(120, 180);
            txtA.BackColor = Color.SeaShell;

            txtB = new TextBox();
            txtB.Location = new Point(120, 210);
            txtB.BackColor = Color.SeaShell;


            txtC = new TextBox();
            txtC.Location = new Point(120, 240);
            txtC.BackColor = Color.SeaShell;

            txtH = new TextBox();
            txtH.Location = new Point(120, 270);
            txtH.BackColor = Color.SeaShell;

            pic1 = new PictureBox();
            pic1.Image = Image.FromFile("tri.png");
            pic1.Location = new Point(340, 220);
            pic1.Size = new Size(200, 200);
            pic1.SizeMode = PictureBoxSizeMode.Zoom;
            pic1.BorderStyle = BorderStyle.FixedSingle;

            Controls.Add(list_);
            Controls.Add(btn);
            Controls.Add(lblA);
            Controls.Add(lblB);
            Controls.Add(lblC);
            Controls.Add(lblH);
            Controls.Add(txtA);
            Controls.Add(txtB);
            Controls.Add(txtC);
            Controls.Add(txtH);
            Controls.Add(pic1);
        }

            private void Btn_Click(object sender, EventArgs e)
            {
                btn.BackColor = Color.Transparent;
                list_.Items.Clear();
                double a, b, c, h;
                if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "" || txtH.Text == "")
                {
                    a = 0;
                    b = 0;
                    c = 0;
                    h = 0;
                }
                else
                {
                    a = Convert.ToDouble(txtA.Text);
                    b = Convert.ToDouble(txtB.Text);
                    c = Convert.ToDouble(txtC.Text);
                    h = Convert.ToDouble(txtH.Text);
                }
                Triangle triangle = new Triangle(a, b, c, h);
                list_.Items.Add("Сторона а:" + " " + triangle.outputA());
                list_.Items.Add("Сторона b:" + " " + triangle.outputB());
                list_.Items.Add("Сторона c:" + " " + triangle.outputC());
                list_.Items.Add("Высота:" + " " + triangle.outputH());
                list_.Items.Add("Периметр:" + " " + Convert.ToString(triangle.Perimeter()));
                list_.Items.Add("Площадь:" + " " + Convert.ToString(triangle.Surface()));
                if (triangle.ExistTriangle) { list_.Items.Add("Существует?  Существует"); }
                else list_.Items.Add("Существует?  Не существует");
                list_.Items.Add("Спецификатор:" + " " + triangle.TypeOfTriangle());
                list_.Items.Add("Медиана:" + " " + Convert.ToString(triangle.mediana()));
                list_.Items.Add("Биссектриса:" + " " + Convert.ToString(triangle.bisectrisa()));
        }
    }
 }