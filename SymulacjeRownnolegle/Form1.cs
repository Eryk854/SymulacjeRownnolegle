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
        public int person_radius = 10;
        public int start_population = 5;

        public Graphics main_simulation;
        public Bitmap main_simulation_bitmap;


        Random rnd = new Random();
        Thread_A thread_object_a;
        ThreadStart thread_start_a;
        Thread thread_a;
        public Form1()
        {
            InitializeComponent();
        }


        private void RecalculatePeoplePositions()
        {
            
            foreach (Person person in this.population.people)
            {
                if (person.status == 1)
                {
                    
                    int rand_value = rnd.Next(-person.speed, person.speed + 1);
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
                        else
                        {
                            Tuple<Person, Person> collision_persons;
                            collision_persons = new_person.CheckCollisionBetweenPeople1(filterd_persons);
                            Person person1 = null;
                            Person person2 = null;
                            foreach (Person item in this.population.people)
                            {
                                if (item.center_x == person.center_x && item.center_y == person.center_y)
                                    person1 = item;
                                if (item.center_x == collision_persons.Item2.center_x && item.center_y == collision_persons.Item2.center_y)
                                    person2 = item;
                            }

                            rand_value = rnd.Next(-person.speed * 2, (person.speed + 1) * 2);

                            Person personn1 = new Person(person1.center_x, person1.center_y + person1.radius/2 + 1, person1.radius, person1.group);
                            Person personn2 = new Person(person2.center_x, person2.center_y - person2.radius/2 - 1, person2.radius, person2.group);

                            bool wall_collision1 = personn1.CheckCollisionWithWalls();
                            bool wall_collision2 = personn2.CheckCollisionWithWalls();

                            filtering_query = this.population.people.Where(person_filter => person_filter != person1 && person_filter != person2);
                            filterd_persons = filtering_query.ToList();
                            filterd_persons.Add(personn2);
                            collision = personn1.CheckCollisionBetweenPeople(filterd_persons);

                            filtering_query = this.population.people.Where(person_filter => person_filter != person1 && person_filter != person2);
                            filterd_persons = filtering_query.ToList();
                            filterd_persons.Add(personn1);
                            bool collision1 = personn2.CheckCollisionBetweenPeople(filterd_persons);

                            if (collision == false && wall_collision1 == false)
                            {
                                person1.center_x = personn1.center_x;
                                person1.center_y = personn1.center_y;
                            }

                            if (collision1 == false && wall_collision2 == false)
                            {
                                person2.center_x = personn2.center_x;
                                person2.center_y = personn2.center_y;
                            }
                        }

                        if (person.center_x >= person.end_point_x && person.group == "left")
                        {
                            person.status = 0;
                            this.population.population_count -= 1;
                            this.population.current_left_group -= 1;
                            this.population.finished_left_group += 1;
                        }

                        if (person.center_x <= person.end_point_x && person.group == "right")
                        {
                            person.status = 0;
                            this.population.population_count -= 1;
                            this.population.current_right_group -= 1;
                            this.population.finished_right_group += 1;
                        }
                            
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RecalculatePeoplePositions();
            DrawPopulation();
            currently_population_value.Text = this.population.population_count.ToString();
            currently_left_value.Text = this.population.current_left_group.ToString();
            currently_right_value.Text = this.population.current_right_group.ToString();
            right_group_finished_value.Text = this.population.finished_right_group.ToString();
            left_group_finished_value.Text = this.population.finished_left_group.ToString();
            population_counter_value.Text = this.population.population_counter.ToString();
            
        }

        private void InitializePeople()
        {
            List<Person> people = new List<Person>();
            int init_left_group = 0;
            int init_right_group = 0;
            while (people.Count < this.start_population)
            {
                int group_loss = this.rnd.Next(0, 2);
                int y = rnd.Next(Global.TopWall, Global.BottomWall);
                Person new_person;
                if (group_loss == 0)
                    new_person = new Person(Global.LeftEntranceX, y, this.person_radius, "left");
                else
                    new_person = new Person(Global.RightEntranceX, y, this.person_radius, "right");
                bool start_collision = new_person.CheckCollisionBetweenPeople(people);
                bool wall_collision = new_person.CheckCollisionWithWalls();

                if (!start_collision && !wall_collision)
                {
                    people.Add(new_person);
                    if (new_person.group == "left")
                        init_left_group += 1;
                    else
                        init_right_group += 1;
                }
            }
            Population population = new Population();
            population.people = people;
            population.population_count = this.start_population;
            population.current_left_group = init_left_group;
            population.current_right_group = init_right_group;
            population.population_counter = (uint)this.start_population;
            this.population = population;
        }

        public void InitializeNewPerson()
        {
            if(this.population.population_count < this.population.max_population_count)
            {
                int group_loss = this.rnd.Next(0, 2);
                int y = this.rnd.Next(Global.TopWall, Global.BottomWall);
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
                        this.population.current_left_group += 1;
                    else
                        this.population.current_right_group += 1;
                    this.population.population_count += 1;
                    this.population.population_counter += 1;
                }    
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //if(thread_a == null)
            //{
            //    this.population.run_simulation = true;
            //    thread_object_a = new Thread_A(this.population, this.panel1);
            //    thread_start_a = new ThreadStart(thread_object_a.RedrawPeople);
            //    thread_a = new Thread(thread_start_a);
            //    timer2.Enabled = true;
            //    button1.Text = "Stop simulation";
            //    thread_a.Start();

            //}
            //else
            //{
            //    this.population.run_simulation = false;
            //    thread_a.Join();
            //    thread_a.Interrupt();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(recalculation_timer.Enabled)
            {
                recalculation_timer.Enabled = false;
                timer_initialize_new_person.Enabled = false;
                button2.Text = "Rerun simulation";
            }
            else
            {
                recalculation_timer.Enabled = true;
                timer_initialize_new_person.Enabled = true;
                button2.Text = "Stop simulation";
            }
                
        }

        public void DrawPopulation()
        {
            main_simulation.Clear(Color.White);
            Pen blackPen = new Pen(Color.Black, Global.WallSize);
            main_simulation.DrawLine(blackPen, Global.LeftEntranceX - 10, Global.TopWall - Global.WallSize, Global.RightEntranceX, Global.TopWall - Global.WallSize);
            main_simulation.DrawLine(blackPen, Global.LeftEntranceX - 10, Global.BottomWall + Global.WallSize, Global.RightEntranceX, Global.BottomWall+Global.WallSize);

            foreach (Person person in this.population.people)
            {
                if (person.status == 1)
                    main_simulation.FillEllipse(person.brush, person.center_x - person.radius / 2, person.center_y - person.radius / 2, person.radius * 2, person.radius * 2);
                
            }
            pictureBox1.Refresh();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            InitializeNewPerson();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numeric_population_number.Value = 30;
            numeric_new_person.Value = 500;
            numeric_population_speed.Value = 50;
            initialize_elements();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int new_population_count = (int)scroll_population_number.Value;
            numeric_population_number.Value = new_population_count;
            this.population.max_population_count = new_population_count;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int new_population_count = (int)numeric_population_number.Value;
            scroll_population_number.Value =new_population_count;
            this.population.max_population_count = new_population_count;
        }


        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int new_person_interval = (int)numeric_new_person.Value;
            scroll_new_person.Value = new_person_interval;
            timer_initialize_new_person.Interval = new_person_interval;
        }

        private void hScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            int new_person_interval = (int)scroll_new_person.Value;
            numeric_new_person.Value = new_person_interval;
            timer_initialize_new_person.Interval = new_person_interval;
        }

        public void initialize_elements()
        {
            main_simulation_bitmap = new Bitmap(1000, 1000);
            pictureBox1.Image = main_simulation_bitmap;
            main_simulation = Graphics.FromImage(main_simulation_bitmap);
            main_simulation.Clear(Color.White);

            Pen blackPen = new Pen(Color.Black, Global.WallSize);
            main_simulation.DrawLine(blackPen, Global.LeftEntranceX - 10, Global.TopWall - Global.WallSize, Global.RightEntranceX, Global.TopWall - Global.WallSize);
            main_simulation.DrawLine(blackPen, Global.LeftEntranceX - 10, Global.BottomWall + Global.WallSize, Global.RightEntranceX, Global.BottomWall + Global.WallSize);

            InitializePeople();
            RecalculatePeoplePositions();
            DrawPopulation();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            initialize_elements();
        }

        private void numeric_population_speed_ValueChanged(object sender, EventArgs e)
        {
            int population_speed = (int)numeric_population_speed.Value;
            int max_population_speed = (int)numeric_population_speed.Maximum;
            scroll_population_speed.Value = population_speed;
            recalculation_timer.Interval = max_population_speed - population_speed+1;
        }

        private void scroll_population_speed_Scroll(object sender, ScrollEventArgs e)
        {
            int population_speed = (int)scroll_population_speed.Value;
            int max_population_speed = (int)scroll_population_speed.Maximum;
            numeric_population_speed.Value = population_speed;
            recalculation_timer.Interval = max_population_speed - population_speed+1;
        }
    }
    public class Person
    {
        public int end_point_x, end_point_y, center_x, center_y, start_x, start_y;
        public int radius;
        public int status;
        public int speed;
        public int x_direction;
        public Brush brush;
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
                this.brush = Brushes.Red;
            }
            else
            {
                this.x_direction = -speed;
                this.end_point_x = Global.LeftEntranceX;
                this.brush = Brushes.Green;
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

        public Tuple<Person, Person> CheckCollisionBetweenPeople1(List<Person> people)
        {
            Tuple<Person, Person> result = null;
            foreach (Person p in people)
            {
                if (this != p && p.status == 1)
                {
                    double distance = Math.Sqrt(Math.Pow(this.center_x - p.center_x, 2) + Math.Pow(this.center_y - p.center_y, 2));
                    if (distance <= this.radius + p.radius)
                        result = Tuple.Create(this, p);
                }
            }
            return result;
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
            Graphics g0 = panel.CreateGraphics();
            g0.FillEllipse(this.brush, this.center_x - this.radius / 2, this.center_y - this.radius / 2, this.radius * 2, this.radius * 2);
        }
    }

    public class Population
    {
        public List<Person> people = new List <Person>();
        public int max_population_count = 30;
        public uint population_counter = 0;
        public int population_count = 0;
        public int current_right_group = 0;
        public int current_left_group = 0;
        public int finished_right_group = 0;
        public int finished_left_group = 0;
        public int person_spped = 5;
        public int person_radius = 5;
        public bool run_simulation = false;
    }

    static class Global
    {
        private static int _left_entrance_x = 10;
        private static int _right_entrance_x = 500;
        private static int _top_wall = 100;
        private static int _bottom_wall = 300;
        private static int _wall_size = 5;

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
        public static int TopWall
        {
            get { return _top_wall; }
            set { _top_wall = value; }
        }
        public static int BottomWall
        {
            get { return _bottom_wall; }
            set { _bottom_wall = value; }
        }
        public static int WallSize
        {
            get { return _wall_size; }
            set { _wall_size = value; }
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
