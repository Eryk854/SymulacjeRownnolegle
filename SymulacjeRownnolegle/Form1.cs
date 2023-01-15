using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymulacjeRownnolegle
{

    public partial class Form1 : Form
    {
        public List<Person> people;
        public int person_spped = 5;
        public Form1()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            InitializePeople();
            Pen blackPen = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(blackPen, 20, 100, 500, 200);
            RedrawPeople();
        }

        private void RedrawPeople()
        {
            Pen p = new Pen(Color.Red);
            Graphics g0 = this.panel1.CreateGraphics();
            g0.Clear(Color.White);

            Pen blackPen = new Pen(Color.Black, 3);
            g0.DrawLine(blackPen, 20, 100, 500, 100);
            g0.DrawLine(blackPen, 20, 300, 500, 300);

            Random rnd = new Random();
            foreach (Person person in this.people)
            {
                if (person.status == 1)
                {
                    g0.DrawEllipse(p, person.cx, person.cy, person.radius * 2, person.radius * 2);
                    int cx = person.cx + person.speed;
                    int cy = person.cy + rnd.Next(-person.speed, person.speed);
                    if((100 < cy) && (cy < 300))
                    {
                        bool collision = false;
                        foreach (Person person_collision in this.people)
                        {
                            if (person != person_collision)
                            {
                                double distance = Math.Sqrt(Math.Pow(person.center_x - person_collision.center_x, 2) + Math.Pow(person.center_y - person_collision.center_y, 2));
                                if (distance < person.radius + person_collision.radius)
                                {
                                    collision = true;
                                }
                            }
                        }
                        if (!collision)
                        {
                            person.cx = cx;
                            person.cy = cy;
                            person.center_x = person.cx + person.radius;
                            person.center_y = person.cy + person.radius;

                            Console.WriteLine(person.cx);

                            if (person.cx >= person.end_point_x)
                            {
                                person.status = 0;
                            }
                        }
                    }
                }
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RedrawPeople();
        }

        private void InitializePeople()
        {
            List<Person> people = new List<Person>();
            Random rnd = new Random();
            for (int i=0; i<5; i++)
            {
                int y = rnd.Next(100, 300);
                people.Add(new Person(10, y));
            }
            this.people = people;
        }
    }
    public class Person
    {
        public int cx, cy, end_point_x, end_point_y, center_x, center_y;
        public int radius;
        public int status;
        public int speed;

        public Person(int cx, int cy)
        {
            Random rnd = new Random();
            this.radius = 2;
            this.cx = cx;
            this.cy = cy;
            this.end_point_x = 500;
            this.end_point_y = rnd.Next(200, 450);
            this.center_x = this.cx + radius;
            this.center_y = this.cy + radius;
            this.status = 1;
            this.speed = 2;
            
        }
    }
}
