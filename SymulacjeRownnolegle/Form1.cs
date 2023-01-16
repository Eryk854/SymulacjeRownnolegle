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
            RedrawPeople();
        }

        private void RedrawPeople()
        {
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
                    person.DrawPerson(this.panel1);
                    int new_center_x = person.center_x + person.speed;
                    int rand_value = rnd.Next(-person.speed, person.speed);
                    int new_center_y = person.center_y + rand_value;
                    //Person new_person = new Person(new_center_x, new_center_y, 20);
                    if((100 < new_center_y - person.radius) && (new_center_y + person.radius < 300) ) // && (person.start_y - 25 < new_center_y) && (person.start_y + 25 > new_center_y)
                    {
                        bool collision = person.CheckCollisionBetweenNew(this.people, new_center_x, new_center_y);
                           
                        if (!collision)
                        {
                            person.center_x = new_center_x;
                            person.center_y = new_center_y;
                            Console.WriteLine(person.center_x);
                        }

                        if (person.center_x >= person.end_point_x)
                            person.status = 0;
                        
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
            while(people.Count<3)
            {
                int y = rnd.Next(100, 300);
                Person new_person = new Person(10, y, 20);
                bool start_collision = new_person.CheckCollisionBetweenExistingPeople(people);
                bool wall_collision = new_person.CheckCollisionWithWalls();
                
                if(!start_collision && ! wall_collision)
                    people.Add(new_person);
            }
            this.people = people;
        }
    }
    public class Person
    {
        public int end_point_x, end_point_y, center_x, center_y, start_x, start_y;
        public int radius;
        public int status;
        public int speed;

        public Person(int center_x, int center_y, int radius)
        {
            Random rnd = new Random();
            this.radius = radius;
            this.center_x = center_x;
            this.center_y = center_y;
            this.start_x = center_x;
            this.start_y = center_y;
            this.end_point_x = 500;
            this.end_point_y = rnd.Next(200, 450);
            this.status = 1;
            this.speed = 2;
        }

        public bool CheckCollisionBetweenExistingPeople(List<Person> people)
        {
            bool collision = false;
            foreach (Person p in people)
            {
                if (this != p && p.status==1)
                {
                    double distance = Math.Sqrt(Math.Pow(this.center_x - p.center_x, 2) + Math.Pow(this.center_y - p.center_y, 2));
                    if (distance <= this.radius + p.radius)
                        collision = true;

                }
            }
            return collision;
        }

        public bool CheckCollisionBetweenNew(List<Person> people, int center_x, int center_y)
        {
            bool collision = false;
            Person new_person = new Person(center_x, center_y, 20);
            foreach (Person p in people)
            {
                if (this != p && p.status == 1)
                {
                    double distance = Math.Sqrt(Math.Pow(new_person.center_x - p.center_x, 2) + Math.Pow(new_person.center_y - p.center_y, 2));
                    if (distance <= new_person.radius + p.radius)
                        collision = true;

                }
            }
            return collision;
        }

        public bool CheckCollisionWithWalls()
        {
            bool collision = false;
            if ((this.center_y - this.radius < 100) && (this.center_y + this.radius > 300))
                collision = true;
            return collision;
        }


        public void DrawPerson(Panel panel)
        {
            Pen pen = new Pen(Color.Red);
            Graphics g0 = panel.CreateGraphics();
            g0.DrawEllipse(pen, this.center_x - this.radius / 2, this.center_y - this.radius / 2, this.radius * 2, this.radius * 2);
        }
    }
}
