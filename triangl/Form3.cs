using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
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
        PictureBox pic1, pic2, pic3;
        RadioButton radio1, radio2;
        public Form3()
        {
            this.Height = 500;
            this.Width = 700;
            this.Text = "Windows Form3 Triangle";
            this.BackColor = Color.BlanchedAlmond;
            this.Icon = new Icon("triangle.ico");
            list_ = new ListBox();
            list_.Location = new Point(10, 10);
            list_.Size = new Size(210, 170);
            list_.Items.Add("Таблица с значением");
            list_.BackColor = Color.Tan;

            btn = new Button();//кнопка запуск
            btn.Location = new Point(100, 350);
            btn.Size = new Size(110, 40);
            btn.Click += Btn_Click;
            btn.Text = "Запуск";
            btn.BackColor = Color.LightPink;
            btn.ForeColor = Color.Red;

            lblA = new Label();//label Стороны А
            lblA.Size = new Size(70, 30);
            lblA.Location = new Point(50, 180);
            lblA.Text = "Сторона А";
            lblA.ForeColor = Color.Black;
            lblA.BackColor = Color.GreenYellow;

            lblB = new Label();//label Стороны B
            lblB.Size = new Size(70, 30);
            lblB.Location = new Point(50, 210);
            lblB.Text = "Сторона B";
            lblB.ForeColor = Color.Black;
            lblB.BackColor = Color.GreenYellow;

            lblC = new Label();//label Стороны C
            lblC.Size = new Size(70, 30);
            lblC.Location = new Point(50, 240);
            lblC.Text = "Сторона C";
            lblC.ForeColor = Color.Black;
            lblC.BackColor = Color.GreenYellow;


            lblH = new Label();//label Стороны H
            lblH.Size = new Size(70, 30);
            lblH.Location = new Point(50, 270);
            lblH.Text = "Сторона H";
            lblH.ForeColor = Color.Black;
            lblH.BackColor = Color.GreenYellow;

            txtA = new TextBox();//txt ящик
            txtA.Size = new Size(100,30);
            txtA.Location = new Point(130, 180);
            txtA.BackColor = Color.SeaShell;

            txtB = new TextBox();//txt ящик
            txtB.Location = new Point(130, 210);
            txtB.BackColor = Color.SeaShell;


            txtC = new TextBox();//txt ящик
            txtC.Location = new Point(130, 240);
            txtC.BackColor = Color.SeaShell;

            txtH = new TextBox();//txt ящик
            txtH.Location = new Point(130, 270);
            txtH.BackColor = Color.SeaShell;
            
            pic1 = new PictureBox();//PixBox
            pic1.Image = Image.FromFile("tri.png");
            pic1.Location = new Point(340, 220);
            pic1.Size = new Size(200, 200);
            pic1.SizeMode = PictureBoxSizeMode.Zoom;
            pic1.BorderStyle = BorderStyle.FixedSingle;


            pic2 = new PictureBox();//PixBox
            pic2.Image = Image.FromFile("trian.gif");
            pic2.Location = new Point(250, 50);
            pic2.Size = new Size(100, 100);
            pic2.SizeMode = PictureBoxSizeMode.Zoom;
            pic2.BorderStyle = BorderStyle.FixedSingle;

            pic3 = new PictureBox();//PixBox
            pic3.Image = Image.FromFile("tro.gif");
            pic3.Location = new Point(410, 10);
            pic3.Size = new Size(200, 200);
            pic3.SizeMode = PictureBoxSizeMode.Zoom;
            pic3.BorderStyle = BorderStyle.FixedSingle;


            radio1 = new RadioButton();//кнопка запуск
            radio1.Location = new Point(40, 400);
            radio1.Size = new Size(110, 40);
            radio1.Click += Radio1_Click; ;
            radio1.Text = "a, b, c";
            radio1.BackColor = Color.LightPink;
            radio1.ForeColor = Color.Red;

            MainMenu menu = new MainMenu();
            BackColor = Color.White;
            ForeColor = Color.Black;
            MenuItem item1 = new MenuItem("File");//файл
            item1.MenuItems.Add("Edit");
            item1.MenuItems.Add("Exit", new EventHandler(exit));//выход
            MenuItem my = new MenuItem("My");//мое меню
            my.MenuItems.Add("Random color", new EventHandler(colors1));//рандомный цвет фона
            my.MenuItems.Add("Restarting the program", new EventHandler(item1_restart));//перезагрузка программы
            my.MenuItems.Add("Website MY", new EventHandler(item1_website));//ссылка на мой сайт 
            menu.MenuItems.Add(item1);
            menu.MenuItems.Add(my);
            this.Menu = menu;



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
            Controls.Add(pic2);
            Controls.Add(pic3);
            Controls.Add(radio1);

        }

        private void Radio1_Click(object sender, EventArgs e)
        {
            txtC.Visible = true;
            lblC.Visible = true;
            lblB.Text = "Сторона B";
            if (!radio1.Checked)
                radio2.Checked = true;
        }

        private void item1_website(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Janika2201/triangl");
        }

        private void item1_restart(object sender, EventArgs e)
        {
            Application.Restart();
        }

        Random random_color = new Random();
        private void colors1(object sender, EventArgs e)
        {
            int Red = random_color.Next(0, 255);
            int Green = random_color.Next(0, 255);
            int Blue = random_color.Next(0, 255);
            this.BackColor = Color.FromArgb(Red, Green, Blue);
        }

        private void exit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kas oled kindel?", "Küsimus", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
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
                list_.Items.Add("ПолуПериметр:" + " " + Convert.ToString(triangle.HalfPerimeter()));
                list_.Items.Add("Площадь:" + " " + Convert.ToString(triangle.Surface()));
                if (triangle.ExistTriangle) { list_.Items.Add("Существует?  Существует"); }
                else list_.Items.Add("Существует?  Не существует");
                list_.Items.Add("Спецификатор:" + " " + triangle.TypeOfTriangle());
                list_.Items.Add("Медиана:" + " " + Convert.ToString(triangle.mediana()));
                list_.Items.Add("Биссектриса:" + " " + Convert.ToString(triangle.bisectrisa()));
                list_.Items.Add("Cинус угла А:" + " " + Convert.ToString(triangle.sinA()));
        }
    }
 }