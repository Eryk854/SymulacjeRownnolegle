using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymulacjeRownnolegle
{

    public partial class Form1 : Form
    {
        public Population population;
        public int person_spped = 5;
        public int person_radius = 5;
        public int start_population = 6;


        Random rnd = new Random();
        Thread_A thread_object_a;
        ThreadStart thread_start_a;
        Thread thread_a;
        public Form1()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            InitializePeople();
            RecalculatePeoplePositions();
            DrawPopulation();
            
        }

        private void RecalculatePeoplePositions()
        {
            
            foreach (Person person in this.population.people)
            {
                if (person.status == 1)
                {
                    
                    int rand_value = rnd.Next(-person.speed, person.speed + 1);
                    Console.WriteLine(rand_value);
                    int new_center_y = person.center_y + rand_value;
                    int new_center_x = person.center_x + person.x_direction;
                    Person new_person = new Person(new_center_x, new_center_y, person.radius, person.group);
                    bool wall_collision = new_person.CheckCollisionWithWalls();
                    if(!wall_collision)
                    {
                        //bool collision = person.CheckCollisionBetweenNew(this.population.people, new_center_x, new_center_y);
                        IEnumerable<Person> filtering_query = this.population.people.Where(person_filter => person_filter != person);
                        List<Person> filterd_persons = filtering_query.ToList();
                        bool collision = new_person.CheckCollisionBetweenPeople(filterd_persons);
                        if (!collision)
                        {
                            person.center_x = new_center_x;
                            person.center_y = new_center_y;
                        }

                        if (person.center_x >= person.end_point_x && person.group == "left")
                        {
                            person.status = 0;
                            this.population.population_count -= 1;
                            this.population.left_group -= 1;
                        }

                        if (person.center_x <= person.end_point_x && person.group == "right")
                        {
                            person.status = 0;
                            this.population.population_count -= 1;
                            this.population.right_group -= 1;
                            
                        }
                            
                    }
                    //if ((100 < new_center_y - person.radius) && (new_center_y + person.radius < 300) ) // && (person.start_y - 25 < new_center_y) && (person.start_y + 25 > new_center_y)
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RecalculatePeoplePositions();
            DrawPopulation();
            label2.Text = this.population.population_count.ToString();
            label4.Text = this.population.left_group.ToString();
            label6.Text = this.population.right_group.ToString();
            
        }

        private void InitializePeople()
        {
            List<Person> people = new List<Person>();
            Random rnd = new Random();
            while(people.Count<this.start_population)
            {
                int y = rnd.Next(100, 300);
                Person new_person = new Person(Global.RightEntranceX, y, this.person_radius, "right");
                bool start_collision = new_person.CheckCollisionBetweenPeople(people);
                bool wall_collision = new_person.CheckCollisionWithWalls();
                
                if(!start_collision && ! wall_collision)
                    people.Add(new_person);
            }
            Population population = new Population(people);
            population.population_count = this.start_population;
            population.left_group = this.start_population;
            this.population = population;
        }

        public void InitializeNewPerson()
        {
            if(this.population.population_count < this.population.max_population_count)
            {
                int group_loss = this.rnd.Next(0, 2);
                int y = this.rnd.Next(100, 300);
                Person new_person;
                if(group_loss==0)
                    new_person = new Person(Global.LeftEntranceX, y, this.person_radius, "left");
                else
                    new_person = new Person(Global.RightEntranceX, y, this.person_radius, "right");
                bool start_collision = new_person.CheckCollisionBetweenPeople(this.population.people);
                bool wall_collision = new_person.CheckCollisionWithWalls();

                if (!start_collision && !wall_collision)
                {
                    this.population.people.Add(new_person);
                    if (new_person.group == "left")
                        this.population.left_group += 1;
                    else
                        this.population.right_group += 1;
                    this.population.population_count += 1;
                }
                    
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(thread_a == null)
            {
                this.population.run_simulation = true;
                thread_object_a = new Thread_A(this.population, this.panel1);
                thread_start_a = new ThreadStart(thread_object_a.RedrawPeople);
                thread_a = new Thread(thread_start_a);
                timer2.Enabled = true;
                button1.Text = "Stop simulation";
                thread_a.Start();

            }
            else
            {
                this.population.run_simulation = false;
                thread_a.Join();
                thread_a.Interrupt();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
            {
                timer1.Enabled = false;
                //timer3.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
                //timer3.Enabled = true;
            }
                
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(this.population.run_simulation)
                DrawPopulation();
        }

        public void DrawPopulation()
        {
            Graphics g0 = panel1.CreateGraphics();
            g0.Clear(Color.White);
            Pen blackPen = new Pen(Color.Black, 20);
            g0.DrawLine(blackPen, 20, 100, 500, 100);
            g0.DrawLine(blackPen, 20, 300, 500, 300);

            foreach (Person person in this.population.people)
            {
                if(person.status==1)
                {
                    person.DrawPerson(panel1);
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            InitializeNewPerson();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> fruits =
                new List<string> { "apple", "passionfruit", "banana", "mango",
                    "orange", "blueberry", "grape", "strawberry" };

            IEnumerable<string> query = fruits.Where(fruit => fruit.Length < 6);
        }

    }
    public class Person
    {
        public int end_point_x, end_point_y, center_x, center_y, start_x, start_y;
        public int radius;
        public int status;
        public int speed;
        public int x_direction;
        public string group;

        public Person(int center_x, int center_y, int radius, string group)
        {
            Random rnd = new Random();
            this.radius = radius;
            this.speed = 2;
            this.center_x = center_x;
            this.center_y = center_y;
            this.start_x = center_x;
            this.start_y = center_y;
            this.group = group;
            if (this.group == "left")
            {
                this.x_direction = speed;
                this.end_point_x = Global.RightEntranceX;
            }
            else
            {
                this.x_direction = -speed;
                this.end_point_x = Global.LeftEntranceX;
            }
            this.end_point_y = rnd.Next(200, 450);
            this.status = 1;
            
        }

        public bool CheckCollisionBetweenPeople(List<Person> people)
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

        public bool CheckCollisionWithWalls()
        {
            bool collision = false;
            if ((this.center_y - this.radius < 100) || (this.center_y + this.radius > 300))
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

    public class Population
    {
        public List<Person> people;
        public int max_population_count = 30;
        public int population_count = 0;
        public int right_group = 0;
        public int left_group = 0;
        public int person_spped = 5;
        public int person_radius = 5;
        public bool run_simulation = false;

        public Population(List<Person> people)
        {
            this.people= people;
        }
    }

    static class Global
    {
        private static int _left_entrance_x = 10;
        private static int _right_entrance_x = 500;

        public static int LeftEntranceX
        {
            get { return _left_entrance_x; }
            set { _left_entrance_x = value; }
        }
        public static int RightEntranceX
        {
            get { return _right_entrance_x; }
            set { _right_entrance_x = value; }
        }
    }
    public class Thread_A
    {
        public Population population;
        public Panel panel;

        public Thread_A(Population population, Panel panel)
        {
            this.population = population;
            this.panel = panel;
        }
        public void RedrawPeople()
        {
            while (this.population.run_simulation)
            {
                //Graphics g0 = this.panel.CreateGraphics();
                //g0.Clear(Color.White);
                //Pen blackPen = new Pen(Color.Black, 20);
                //g0.DrawLine(blackPen, 20, 100, 500, 100);
                //g0.DrawLine(blackPen, 20, 300, 500, 300);

                //Random rnd = new Random();
                //foreach (Person person in this.population.people)
                //{
                //    if (person.status == 1)
                //    {
                //        //person.DrawPerson(this.panel);
                //        int new_center_x = person.center_x + person.speed;
                //        int rand_value = rnd.Next(-person.speed, person.speed);
                //        int new_center_y = person.center_y + rand_value;
                //        Person new_person = new Person(new_center_x, new_center_y, 5);
                //        bool wall_collision = new_person.CheckCollisionWithWalls();
                //        if (!wall_collision)
                //        {
                //            bool collision = person.CheckCollisionBetweenNew(this.population.people, new_center_x, new_center_y);

                //            if (!collision)
                //            {
                //                person.center_x = new_center_x;
                //                person.center_y = new_center_y;
                //            }

                //            if (person.center_x >= person.end_point_x)
                //                person.status = 0;
                //        }
                //        //if ((100 < new_center_y - person.radius) && (new_center_y + person.radius < 300) ) // && (person.start_y - 25 < new_center_y) && (person.start_y + 25 > new_center_y)
                //    }
                //}
                //System.Threading.Thread.Sleep(100);
            }
        }
    }
}
