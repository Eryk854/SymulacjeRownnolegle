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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 518);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 1000);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1203, 42);
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
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1194, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1193, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
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
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1452, 520);
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
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label currently_population_label;
        private System.Windows.Forms.Label currently_population_value;
        private System.Windows.Forms.Label currently_left_label;
        private System.Windows.Forms.Label currently_left_value;
        private System.Windows.Forms.Label currently_right_label;
        private System.Windows.Forms.Label currently_right_value;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label population_counter_label;
        private System.Windows.Forms.Label population_counter_value;
        private System.Windows.Forms.Label right_group_finished_label;
        private System.Windows.Forms.Label right_group_finished_value;
        private System.Windows.Forms.Label left_group_finished_label;
        private System.Windows.Forms.Label left_group_finished_value;
    }
}

