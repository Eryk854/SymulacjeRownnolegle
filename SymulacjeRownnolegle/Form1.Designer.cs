namespace SymulacjeRownnolegle
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.recalculation_timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.timer_initialize_new_person = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.currently_population_label = new System.Windows.Forms.Label();
            this.currently_population_value = new System.Windows.Forms.Label();
            this.currently_left_label = new System.Windows.Forms.Label();
            this.currently_left_value = new System.Windows.Forms.Label();
            this.currently_right_label = new System.Windows.Forms.Label();
            this.currently_right_value = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.population_counter_label = new System.Windows.Forms.Label();
            this.population_counter_value = new System.Windows.Forms.Label();
            this.right_group_finished_label = new System.Windows.Forms.Label();
            this.right_group_finished_value = new System.Windows.Forms.Label();
            this.left_group_finished_label = new System.Windows.Forms.Label();
            this.left_group_finished_value = new System.Windows.Forms.Label();
            this.scroll_population_number = new System.Windows.Forms.HScrollBar();
            this.numeric_population_number = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numeric_new_person = new System.Windows.Forms.NumericUpDown();
            this.scroll_new_person = new System.Windows.Forms.HScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric_population_speed = new System.Windows.Forms.NumericUpDown();
            this.scroll_population_speed = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_population_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_new_person)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_population_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // recalculation_timer
            // 
            this.recalculation_timer.Interval = 20;
            this.recalculation_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1333, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1180, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Start simulation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer_initialize_new_person
            // 
            this.timer_initialize_new_person.Interval = 1000;
            this.timer_initialize_new_person.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1069, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reset simulation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // currently_population_label
            // 
            this.currently_population_label.AutoSize = true;
            this.currently_population_label.Location = new System.Drawing.Point(1042, 231);
            this.currently_population_label.Name = "currently_population_label";
            this.currently_population_label.Size = new System.Drawing.Size(125, 32);
            this.currently_population_label.TabIndex = 6;
            this.currently_population_label.Text = "Currently population\r\n count";
            // 
            // currently_population_value
            // 
            this.currently_population_value.AutoSize = true;
            this.currently_population_value.Location = new System.Drawing.Point(1052, 277);
            this.currently_population_value.Name = "currently_population_value";
            this.currently_population_value.Size = new System.Drawing.Size(100, 32);
            this.currently_population_value.TabIndex = 7;
            this.currently_population_value.Text = "Start simulation \r\nto see results";
            // 
            // currently_left_label
            // 
            this.currently_left_label.AutoSize = true;
            this.currently_left_label.Location = new System.Drawing.Point(1173, 231);
            this.currently_left_label.Name = "currently_left_label";
            this.currently_left_label.Size = new System.Drawing.Size(120, 32);
            this.currently_left_label.TabIndex = 8;
            this.currently_left_label.Text = "Currently left group \r\ncount";
            // 
            // currently_left_value
            // 
            this.currently_left_value.AutoSize = true;
            this.currently_left_value.Location = new System.Drawing.Point(1177, 277);
            this.currently_left_value.Name = "currently_left_value";
            this.currently_left_value.Size = new System.Drawing.Size(100, 32);
            this.currently_left_value.TabIndex = 9;
            this.currently_left_value.Text = "Start simulation \r\nto see results";
            // 
            // currently_right_label
            // 
            this.currently_right_label.AutoSize = true;
            this.currently_right_label.Location = new System.Drawing.Point(1299, 231);
            this.currently_right_label.Name = "currently_right_label";
            this.currently_right_label.Size = new System.Drawing.Size(128, 32);
            this.currently_right_label.TabIndex = 10;
            this.currently_right_label.Text = "Currently right group \r\ncount";
            // 
            // currently_right_value
            // 
            this.currently_right_value.AutoSize = true;
            this.currently_right_value.Location = new System.Drawing.Point(1308, 277);
            this.currently_right_value.Name = "currently_right_value";
            this.currently_right_value.Size = new System.Drawing.Size(100, 32);
            this.currently_right_value.TabIndex = 11;
            this.currently_right_value.Text = "Start simulation \r\nto see results";
            // 
            // population_counter_label
            // 
            this.population_counter_label.AutoSize = true;
            this.population_counter_label.Location = new System.Drawing.Point(1036, 352);
            this.population_counter_label.Name = "population_counter_label";
            this.population_counter_label.Size = new System.Drawing.Size(139, 32);
            this.population_counter_label.TabIndex = 12;
            this.population_counter_label.Text = "Number of people \r\nin the whole simulation";
            // 
            // population_counter_value
            // 
            this.population_counter_value.AutoSize = true;
            this.population_counter_value.Location = new System.Drawing.Point(1052, 400);
            this.population_counter_value.Name = "population_counter_value";
            this.population_counter_value.Size = new System.Drawing.Size(100, 32);
            this.population_counter_value.TabIndex = 13;
            this.population_counter_value.Text = "Start simulation \r\nto see results";
            // 
            // right_group_finished_label
            // 
            this.right_group_finished_label.AutoSize = true;
            this.right_group_finished_label.Location = new System.Drawing.Point(1299, 352);
            this.right_group_finished_label.Name = "right_group_finished_label";
            this.right_group_finished_label.Size = new System.Drawing.Size(125, 16);
            this.right_group_finished_label.TabIndex = 14;
            this.right_group_finished_label.Text = "Right group finished";
            // 
            // right_group_finished_value
            // 
            this.right_group_finished_value.AutoSize = true;
            this.right_group_finished_value.Location = new System.Drawing.Point(1308, 400);
            this.right_group_finished_value.Name = "right_group_finished_value";
            this.right_group_finished_value.Size = new System.Drawing.Size(100, 32);
            this.right_group_finished_value.TabIndex = 15;
            this.right_group_finished_value.Text = "Start simulation \r\nto see results";
            // 
            // left_group_finished_label
            // 
            this.left_group_finished_label.AutoSize = true;
            this.left_group_finished_label.Location = new System.Drawing.Point(1173, 352);
            this.left_group_finished_label.Name = "left_group_finished_label";
            this.left_group_finished_label.Size = new System.Drawing.Size(115, 16);
            this.left_group_finished_label.TabIndex = 16;
            this.left_group_finished_label.Text = "Left group finished";
            // 
            // left_group_finished_value
            // 
            this.left_group_finished_value.AutoSize = true;
            this.left_group_finished_value.Location = new System.Drawing.Point(1177, 400);
            this.left_group_finished_value.Name = "left_group_finished_value";
            this.left_group_finished_value.Size = new System.Drawing.Size(100, 32);
            this.left_group_finished_value.TabIndex = 17;
            this.left_group_finished_value.Text = "Start simulation \r\nto see results";
            // 
            // scroll_population_number
            // 
            this.scroll_population_number.LargeChange = 1;
            this.scroll_population_number.Location = new System.Drawing.Point(1017, 77);
            this.scroll_population_number.Minimum = 1;
            this.scroll_population_number.Name = "scroll_population_number";
            this.scroll_population_number.Size = new System.Drawing.Size(135, 29);
            this.scroll_population_number.TabIndex = 18;
            this.scroll_population_number.Value = 30;
            this.scroll_population_number.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // numeric_population_number
            // 
            this.numeric_population_number.Location = new System.Drawing.Point(1017, 52);
            this.numeric_population_number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_population_number.Name = "numeric_population_number";
            this.numeric_population_number.Size = new System.Drawing.Size(135, 22);
            this.numeric_population_number.TabIndex = 20;
            this.numeric_population_number.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numeric_population_number.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1028, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Maximum number \r\nof people";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 1000);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1187, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Speed of new\r\npeople";
            // 
            // numeric_new_person
            // 
            this.numeric_new_person.Location = new System.Drawing.Point(1176, 52);
            this.numeric_new_person.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numeric_new_person.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numeric_new_person.Name = "numeric_new_person";
            this.numeric_new_person.Size = new System.Drawing.Size(135, 22);
            this.numeric_new_person.TabIndex = 10;
            this.numeric_new_person.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numeric_new_person.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // scroll_new_person
            // 
            this.scroll_new_person.LargeChange = 1;
            this.scroll_new_person.Location = new System.Drawing.Point(1176, 77);
            this.scroll_new_person.Maximum = 2000;
            this.scroll_new_person.Minimum = 20;
            this.scroll_new_person.Name = "scroll_new_person";
            this.scroll_new_person.Size = new System.Drawing.Size(135, 29);
            this.scroll_new_person.TabIndex = 10;
            this.scroll_new_person.Value = 500;
            this.scroll_new_person.ValueChanged += new System.EventHandler(this.hScrollBar2_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1432, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 25);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1344, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "People speed";
            // 
            // numeric_population_speed
            // 
            this.numeric_population_speed.Location = new System.Drawing.Point(1333, 52);
            this.numeric_population_speed.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numeric_population_speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_population_speed.Name = "numeric_population_speed";
            this.numeric_population_speed.Size = new System.Drawing.Size(135, 22);
            this.numeric_population_speed.TabIndex = 5;
            this.numeric_population_speed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numeric_population_speed.ValueChanged += new System.EventHandler(this.numeric_population_speed_ValueChanged);
            // 
            // scroll_population_speed
            // 
            this.scroll_population_speed.LargeChange = 1;
            this.scroll_population_speed.Location = new System.Drawing.Point(1333, 77);
            this.scroll_population_speed.Maximum = 200;
            this.scroll_population_speed.Minimum = 1;
            this.scroll_population_speed.Name = "scroll_population_speed";
            this.scroll_population_speed.Size = new System.Drawing.Size(135, 29);
            this.scroll_population_speed.TabIndex = 2;
            this.scroll_population_speed.Value = 50;
            this.scroll_population_speed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll_population_speed_Scroll);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1491, 520);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numeric_population_speed);
            this.Controls.Add(this.scroll_population_speed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeric_new_person);
            this.Controls.Add(this.scroll_new_person);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_population_number);
            this.Controls.Add(this.scroll_population_number);
            this.Controls.Add(this.left_group_finished_value);
            this.Controls.Add(this.left_group_finished_label);
            this.Controls.Add(this.right_group_finished_value);
            this.Controls.Add(this.right_group_finished_label);
            this.Controls.Add(this.population_counter_value);
            this.Controls.Add(this.population_counter_label);
            this.Controls.Add(this.currently_right_value);
            this.Controls.Add(this.currently_right_label);
            this.Controls.Add(this.currently_left_value);
            this.Controls.Add(this.currently_left_label);
            this.Controls.Add(this.currently_population_value);
            this.Controls.Add(this.currently_population_label);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_population_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_new_person)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_population_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer recalculation_timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer_initialize_new_person;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label currently_population_label;
        private System.Windows.Forms.Label currently_population_value;
        private System.Windows.Forms.Label currently_left_label;
        private System.Windows.Forms.Label currently_left_value;
        private System.Windows.Forms.Label currently_right_label;
        private System.Windows.Forms.Label currently_right_value;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label population_counter_label;
        private System.Windows.Forms.Label population_counter_value;
        private System.Windows.Forms.Label right_group_finished_label;
        private System.Windows.Forms.Label right_group_finished_value;
        private System.Windows.Forms.Label left_group_finished_label;
        private System.Windows.Forms.Label left_group_finished_value;
        private System.Windows.Forms.HScrollBar scroll_population_number;
        private System.Windows.Forms.NumericUpDown numeric_population_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeric_new_person;
        private System.Windows.Forms.HScrollBar scroll_new_person;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeric_population_speed;
        private System.Windows.Forms.HScrollBar scroll_population_speed;
    }
}

