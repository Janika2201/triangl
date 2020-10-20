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
        Label lA, lB, lC, lH;
        TextBox txtA, txtB, txtC, txtH;
        public Form3()
        {
                this.Size = new Size(300, 450);
                list_ = new ListBox();
                list_.Location = new Point(10, 10);
                list_.Size = new Size(265, 150);
                list_.Items.Add("Напиши внизу цифры");

                btn = new Button();
                btn.Location = new Point(100, 350);
                btn.Size = new Size(80, 40);
                btn.Click += Btn_Click;
                btn.Text = "Запуск";

                lA = new Label();
                lA.Size = new Size(70, 30);
                lA.Location = new Point(50, 180);
                lA.Text = "Сторона А";

                lB = new Label();
                lB.Size = new Size(70, 30);
                lB.Location = new Point(50, 210);
                lB.Text = "Сторона B";

                lC = new Label();
                lC.Size = new Size(70, 30);
                lC.Location = new Point(50, 240);
                lC.Text = "Сторона C";

                lH = new Label();
                lH.Size = new Size(70, 30);
                lH.Location = new Point(50, 270);
                lH.Text = "Сторона H";

                txtA = new TextBox();
                txtA.Location = new Point(120, 180);

                txtB = new TextBox();
                txtB.Location = new Point(120, 210);

                txtC = new TextBox();
                txtC.Location = new Point(120, 240);

                txtH = new TextBox();
                txtH.Location = new Point(120, 270);

                Controls.Add(list_);
                Controls.Add(btn);
                Controls.Add(lA);
                Controls.Add(lB);
                Controls.Add(lC);
                Controls.Add(lH);
                Controls.Add(txtA);
                Controls.Add(txtB);
                Controls.Add(txtC);
                Controls.Add(txtH);
        }

            private void Btn_Click(object sender, EventArgs e)
            {
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