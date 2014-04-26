﻿namespace Teacher
{
    partial class TeacherInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_menu_logout = new System.Windows.Forms.Button();
            this.button_menu_account = new System.Windows.Forms.Button();
            this.button_menu_students = new System.Windows.Forms.Button();
            this.button_menu_exercises = new System.Windows.Forms.Button();
            this.button_menu_classes = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_classes = new System.Windows.Forms.Panel();
            this.tabs_classes = new System.Windows.Forms.TabControl();
            this.tab_classes_students = new System.Windows.Forms.TabPage();
            this.listBox_classes_studentPerformance = new System.Windows.Forms.ListBox();
            this.listBox_classes_students = new System.Windows.Forms.ListBox();
            this.tab_classes_enrollment = new System.Windows.Forms.TabPage();
            this.listBox_classes_studentsEnrolled = new System.Windows.Forms.ListBox();
            this.listBox_classes_studentsNotEnrolled = new System.Windows.Forms.ListBox();
            this.tab_classes_exercises = new System.Windows.Forms.TabPage();
            this.listBox_classes_exercisesIn = new System.Windows.Forms.ListBox();
            this.listBox_classes_exercisesNotIn = new System.Windows.Forms.ListBox();
            this.listBox_classes = new System.Windows.Forms.ListBox();
            this.panel_exercises = new System.Windows.Forms.Panel();
            this.button_exercises_save = new System.Windows.Forms.Button();
            this.button_exercises_delete = new System.Windows.Forms.Button();
            this.button_exercises_reset = new System.Windows.Forms.Button();
            this.button_exercises_new = new System.Windows.Forms.Button();
            this.textBox_exercises_text = new System.Windows.Forms.TextBox();
            this.textBox_exercises_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_exercises = new System.Windows.Forms.ListBox();
            this.panel_students = new System.Windows.Forms.Panel();
            this.button_students_save = new System.Windows.Forms.Button();
            this.button_students_delete = new System.Windows.Forms.Button();
            this.button_students_reset = new System.Windows.Forms.Button();
            this.button_students_new = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_students_classes = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox_students = new System.Windows.Forms.ListBox();
            this.panel_account = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel_menu.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_classes.SuspendLayout();
            this.tabs_classes.SuspendLayout();
            this.tab_classes_students.SuspendLayout();
            this.tab_classes_enrollment.SuspendLayout();
            this.tab_classes_exercises.SuspendLayout();
            this.panel_exercises.SuspendLayout();
            this.panel_students.SuspendLayout();
            this.panel_account.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.button_menu_logout);
            this.panel_menu.Controls.Add(this.button_menu_account);
            this.panel_menu.Controls.Add(this.button_menu_students);
            this.panel_menu.Controls.Add(this.button_menu_exercises);
            this.panel_menu.Controls.Add(this.button_menu_classes);
            this.panel_menu.Location = new System.Drawing.Point(12, 12);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(140, 495);
            this.panel_menu.TabIndex = 0;
            // 
            // button_menu_logout
            // 
            this.button_menu_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu_logout.Location = new System.Drawing.Point(3, 455);
            this.button_menu_logout.Name = "button_menu_logout";
            this.button_menu_logout.Size = new System.Drawing.Size(134, 37);
            this.button_menu_logout.TabIndex = 4;
            this.button_menu_logout.Text = "Logout";
            this.button_menu_logout.UseVisualStyleBackColor = true;
            this.button_menu_logout.Click += new System.EventHandler(this.button_menu_logout_Click);
            // 
            // button_menu_account
            // 
            this.button_menu_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu_account.Location = new System.Drawing.Point(3, 132);
            this.button_menu_account.Name = "button_menu_account";
            this.button_menu_account.Size = new System.Drawing.Size(134, 37);
            this.button_menu_account.TabIndex = 3;
            this.button_menu_account.Text = "My Account";
            this.button_menu_account.UseVisualStyleBackColor = true;
            this.button_menu_account.Click += new System.EventHandler(this.button_menu_account_Click);
            // 
            // button_menu_students
            // 
            this.button_menu_students.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu_students.Location = new System.Drawing.Point(3, 89);
            this.button_menu_students.Name = "button_menu_students";
            this.button_menu_students.Size = new System.Drawing.Size(134, 37);
            this.button_menu_students.TabIndex = 2;
            this.button_menu_students.Text = "Students";
            this.button_menu_students.UseVisualStyleBackColor = true;
            this.button_menu_students.Click += new System.EventHandler(this.button_menu_students_Click);
            // 
            // button_menu_exercises
            // 
            this.button_menu_exercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu_exercises.Location = new System.Drawing.Point(3, 46);
            this.button_menu_exercises.Name = "button_menu_exercises";
            this.button_menu_exercises.Size = new System.Drawing.Size(134, 37);
            this.button_menu_exercises.TabIndex = 1;
            this.button_menu_exercises.Text = "Exercises";
            this.button_menu_exercises.UseVisualStyleBackColor = true;
            this.button_menu_exercises.Click += new System.EventHandler(this.button_menu_exercises_Click);
            // 
            // button_menu_classes
            // 
            this.button_menu_classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu_classes.Location = new System.Drawing.Point(3, 3);
            this.button_menu_classes.Name = "button_menu_classes";
            this.button_menu_classes.Size = new System.Drawing.Size(134, 37);
            this.button_menu_classes.TabIndex = 0;
            this.button_menu_classes.Text = "Classes";
            this.button_menu_classes.UseVisualStyleBackColor = true;
            this.button_menu_classes.Click += new System.EventHandler(this.button_menu_classes_Click);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_classes);
            this.panel_main.Controls.Add(this.panel_exercises);
            this.panel_main.Controls.Add(this.panel_students);
            this.panel_main.Controls.Add(this.panel_account);
            this.panel_main.Location = new System.Drawing.Point(159, 12);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(778, 495);
            this.panel_main.TabIndex = 1;
            // 
            // panel_classes
            // 
            this.panel_classes.Controls.Add(this.tabs_classes);
            this.panel_classes.Controls.Add(this.listBox_classes);
            this.panel_classes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_classes.Location = new System.Drawing.Point(0, 0);
            this.panel_classes.Name = "panel_classes";
            this.panel_classes.Size = new System.Drawing.Size(778, 495);
            this.panel_classes.TabIndex = 0;
            this.panel_classes.Visible = false;
            // 
            // tabs_classes
            // 
            this.tabs_classes.Controls.Add(this.tab_classes_students);
            this.tabs_classes.Controls.Add(this.tab_classes_enrollment);
            this.tabs_classes.Controls.Add(this.tab_classes_exercises);
            this.tabs_classes.Location = new System.Drawing.Point(129, 3);
            this.tabs_classes.Name = "tabs_classes";
            this.tabs_classes.SelectedIndex = 0;
            this.tabs_classes.Size = new System.Drawing.Size(646, 489);
            this.tabs_classes.TabIndex = 1;
            // 
            // tab_classes_students
            // 
            this.tab_classes_students.Controls.Add(this.listBox_classes_studentPerformance);
            this.tab_classes_students.Controls.Add(this.listBox_classes_students);
            this.tab_classes_students.Location = new System.Drawing.Point(4, 22);
            this.tab_classes_students.Name = "tab_classes_students";
            this.tab_classes_students.Padding = new System.Windows.Forms.Padding(3);
            this.tab_classes_students.Size = new System.Drawing.Size(638, 463);
            this.tab_classes_students.TabIndex = 0;
            this.tab_classes_students.Text = "Students";
            this.tab_classes_students.UseVisualStyleBackColor = true;
            // 
            // listBox_classes_studentPerformance
            // 
            this.listBox_classes_studentPerformance.FormattingEnabled = true;
            this.listBox_classes_studentPerformance.Location = new System.Drawing.Point(189, 6);
            this.listBox_classes_studentPerformance.Name = "listBox_classes_studentPerformance";
            this.listBox_classes_studentPerformance.Size = new System.Drawing.Size(443, 446);
            this.listBox_classes_studentPerformance.TabIndex = 3;
            // 
            // listBox_classes_students
            // 
            this.listBox_classes_students.FormattingEnabled = true;
            this.listBox_classes_students.Location = new System.Drawing.Point(6, 6);
            this.listBox_classes_students.Name = "listBox_classes_students";
            this.listBox_classes_students.Size = new System.Drawing.Size(177, 446);
            this.listBox_classes_students.TabIndex = 2;
            // 
            // tab_classes_enrollment
            // 
            this.tab_classes_enrollment.Controls.Add(this.listBox_classes_studentsEnrolled);
            this.tab_classes_enrollment.Controls.Add(this.listBox_classes_studentsNotEnrolled);
            this.tab_classes_enrollment.Location = new System.Drawing.Point(4, 22);
            this.tab_classes_enrollment.Name = "tab_classes_enrollment";
            this.tab_classes_enrollment.Padding = new System.Windows.Forms.Padding(3);
            this.tab_classes_enrollment.Size = new System.Drawing.Size(638, 463);
            this.tab_classes_enrollment.TabIndex = 1;
            this.tab_classes_enrollment.Text = "Enrollment";
            this.tab_classes_enrollment.UseVisualStyleBackColor = true;
            // 
            // listBox_classes_studentsEnrolled
            // 
            this.listBox_classes_studentsEnrolled.FormattingEnabled = true;
            this.listBox_classes_studentsEnrolled.Location = new System.Drawing.Point(375, 6);
            this.listBox_classes_studentsEnrolled.Name = "listBox_classes_studentsEnrolled";
            this.listBox_classes_studentsEnrolled.Size = new System.Drawing.Size(257, 446);
            this.listBox_classes_studentsEnrolled.TabIndex = 1;
            // 
            // listBox_classes_studentsNotEnrolled
            // 
            this.listBox_classes_studentsNotEnrolled.FormattingEnabled = true;
            this.listBox_classes_studentsNotEnrolled.Location = new System.Drawing.Point(6, 6);
            this.listBox_classes_studentsNotEnrolled.Name = "listBox_classes_studentsNotEnrolled";
            this.listBox_classes_studentsNotEnrolled.Size = new System.Drawing.Size(257, 446);
            this.listBox_classes_studentsNotEnrolled.TabIndex = 0;
            // 
            // tab_classes_exercises
            // 
            this.tab_classes_exercises.Controls.Add(this.listBox_classes_exercisesIn);
            this.tab_classes_exercises.Controls.Add(this.listBox_classes_exercisesNotIn);
            this.tab_classes_exercises.Location = new System.Drawing.Point(4, 22);
            this.tab_classes_exercises.Name = "tab_classes_exercises";
            this.tab_classes_exercises.Padding = new System.Windows.Forms.Padding(3);
            this.tab_classes_exercises.Size = new System.Drawing.Size(638, 463);
            this.tab_classes_exercises.TabIndex = 2;
            this.tab_classes_exercises.Text = "Exercises";
            this.tab_classes_exercises.UseVisualStyleBackColor = true;
            // 
            // listBox_classes_exercisesIn
            // 
            this.listBox_classes_exercisesIn.FormattingEnabled = true;
            this.listBox_classes_exercisesIn.Location = new System.Drawing.Point(375, 6);
            this.listBox_classes_exercisesIn.Name = "listBox_classes_exercisesIn";
            this.listBox_classes_exercisesIn.Size = new System.Drawing.Size(257, 446);
            this.listBox_classes_exercisesIn.TabIndex = 3;
            // 
            // listBox_classes_exercisesNotIn
            // 
            this.listBox_classes_exercisesNotIn.FormattingEnabled = true;
            this.listBox_classes_exercisesNotIn.Location = new System.Drawing.Point(6, 6);
            this.listBox_classes_exercisesNotIn.Name = "listBox_classes_exercisesNotIn";
            this.listBox_classes_exercisesNotIn.Size = new System.Drawing.Size(257, 446);
            this.listBox_classes_exercisesNotIn.TabIndex = 2;
            // 
            // listBox_classes
            // 
            this.listBox_classes.FormattingEnabled = true;
            this.listBox_classes.Location = new System.Drawing.Point(3, 3);
            this.listBox_classes.Name = "listBox_classes";
            this.listBox_classes.Size = new System.Drawing.Size(120, 485);
            this.listBox_classes.TabIndex = 0;
            // 
            // panel_exercises
            // 
            this.panel_exercises.Controls.Add(this.button_exercises_save);
            this.panel_exercises.Controls.Add(this.button_exercises_delete);
            this.panel_exercises.Controls.Add(this.button_exercises_reset);
            this.panel_exercises.Controls.Add(this.button_exercises_new);
            this.panel_exercises.Controls.Add(this.textBox_exercises_text);
            this.panel_exercises.Controls.Add(this.textBox_exercises_name);
            this.panel_exercises.Controls.Add(this.label2);
            this.panel_exercises.Controls.Add(this.label1);
            this.panel_exercises.Controls.Add(this.listBox_exercises);
            this.panel_exercises.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_exercises.Location = new System.Drawing.Point(0, 0);
            this.panel_exercises.Name = "panel_exercises";
            this.panel_exercises.Size = new System.Drawing.Size(778, 495);
            this.panel_exercises.TabIndex = 2;
            this.panel_exercises.Visible = false;
            // 
            // button_exercises_save
            // 
            this.button_exercises_save.Location = new System.Drawing.Point(696, 465);
            this.button_exercises_save.Name = "button_exercises_save";
            this.button_exercises_save.Size = new System.Drawing.Size(75, 23);
            this.button_exercises_save.TabIndex = 8;
            this.button_exercises_save.Text = "Save";
            this.button_exercises_save.UseVisualStyleBackColor = true;
            // 
            // button_exercises_delete
            // 
            this.button_exercises_delete.Location = new System.Drawing.Point(615, 465);
            this.button_exercises_delete.Name = "button_exercises_delete";
            this.button_exercises_delete.Size = new System.Drawing.Size(75, 23);
            this.button_exercises_delete.TabIndex = 7;
            this.button_exercises_delete.Text = "Delete";
            this.button_exercises_delete.UseVisualStyleBackColor = true;
            // 
            // button_exercises_reset
            // 
            this.button_exercises_reset.Location = new System.Drawing.Point(534, 466);
            this.button_exercises_reset.Name = "button_exercises_reset";
            this.button_exercises_reset.Size = new System.Drawing.Size(75, 23);
            this.button_exercises_reset.TabIndex = 6;
            this.button_exercises_reset.Text = "Reset";
            this.button_exercises_reset.UseVisualStyleBackColor = true;
            // 
            // button_exercises_new
            // 
            this.button_exercises_new.Location = new System.Drawing.Point(184, 453);
            this.button_exercises_new.Name = "button_exercises_new";
            this.button_exercises_new.Size = new System.Drawing.Size(75, 23);
            this.button_exercises_new.TabIndex = 5;
            this.button_exercises_new.Text = "New";
            this.button_exercises_new.UseVisualStyleBackColor = true;
            // 
            // textBox_exercises_text
            // 
            this.textBox_exercises_text.Location = new System.Drawing.Point(326, 70);
            this.textBox_exercises_text.Multiline = true;
            this.textBox_exercises_text.Name = "textBox_exercises_text";
            this.textBox_exercises_text.Size = new System.Drawing.Size(308, 164);
            this.textBox_exercises_text.TabIndex = 4;
            // 
            // textBox_exercises_name
            // 
            this.textBox_exercises_name.Location = new System.Drawing.Point(326, 45);
            this.textBox_exercises_name.Name = "textBox_exercises_name";
            this.textBox_exercises_name.Size = new System.Drawing.Size(308, 20);
            this.textBox_exercises_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // listBox_exercises
            // 
            this.listBox_exercises.FormattingEnabled = true;
            this.listBox_exercises.Location = new System.Drawing.Point(3, 3);
            this.listBox_exercises.Name = "listBox_exercises";
            this.listBox_exercises.Size = new System.Drawing.Size(164, 485);
            this.listBox_exercises.TabIndex = 0;
            // 
            // panel_students
            // 
            this.panel_students.Controls.Add(this.button_students_save);
            this.panel_students.Controls.Add(this.button_students_delete);
            this.panel_students.Controls.Add(this.button_students_reset);
            this.panel_students.Controls.Add(this.button_students_new);
            this.panel_students.Controls.Add(this.label7);
            this.panel_students.Controls.Add(this.label6);
            this.panel_students.Controls.Add(this.label5);
            this.panel_students.Controls.Add(this.label4);
            this.panel_students.Controls.Add(this.label3);
            this.panel_students.Controls.Add(this.comboBox_students_classes);
            this.panel_students.Controls.Add(this.textBox4);
            this.panel_students.Controls.Add(this.textBox3);
            this.panel_students.Controls.Add(this.textBox2);
            this.panel_students.Controls.Add(this.textBox1);
            this.panel_students.Controls.Add(this.listBox_students);
            this.panel_students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_students.Location = new System.Drawing.Point(0, 0);
            this.panel_students.Name = "panel_students";
            this.panel_students.Size = new System.Drawing.Size(778, 495);
            this.panel_students.TabIndex = 9;
            this.panel_students.Visible = false;
            // 
            // button_students_save
            // 
            this.button_students_save.Location = new System.Drawing.Point(696, 466);
            this.button_students_save.Name = "button_students_save";
            this.button_students_save.Size = new System.Drawing.Size(75, 23);
            this.button_students_save.TabIndex = 14;
            this.button_students_save.Text = "Save";
            this.button_students_save.UseVisualStyleBackColor = true;
            // 
            // button_students_delete
            // 
            this.button_students_delete.Location = new System.Drawing.Point(615, 466);
            this.button_students_delete.Name = "button_students_delete";
            this.button_students_delete.Size = new System.Drawing.Size(75, 23);
            this.button_students_delete.TabIndex = 13;
            this.button_students_delete.Text = "Delete";
            this.button_students_delete.UseVisualStyleBackColor = true;
            // 
            // button_students_reset
            // 
            this.button_students_reset.Location = new System.Drawing.Point(534, 466);
            this.button_students_reset.Name = "button_students_reset";
            this.button_students_reset.Size = new System.Drawing.Size(75, 23);
            this.button_students_reset.TabIndex = 12;
            this.button_students_reset.Text = "Reset";
            this.button_students_reset.UseVisualStyleBackColor = true;
            // 
            // button_students_new
            // 
            this.button_students_new.Location = new System.Drawing.Point(326, 462);
            this.button_students_new.Name = "button_students_new";
            this.button_students_new.Size = new System.Drawing.Size(75, 23);
            this.button_students_new.TabIndex = 11;
            this.button_students_new.Text = "New";
            this.button_students_new.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Class:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name:";
            // 
            // comboBox_students_classes
            // 
            this.comboBox_students_classes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_students_classes.FormattingEnabled = true;
            this.comboBox_students_classes.Location = new System.Drawing.Point(480, 261);
            this.comboBox_students_classes.Name = "comboBox_students_classes";
            this.comboBox_students_classes.Size = new System.Drawing.Size(221, 21);
            this.comboBox_students_classes.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(480, 234);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(221, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(480, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(221, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(480, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(480, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listBox_students
            // 
            this.listBox_students.FormattingEnabled = true;
            this.listBox_students.Location = new System.Drawing.Point(4, 4);
            this.listBox_students.MultiColumn = true;
            this.listBox_students.Name = "listBox_students";
            this.listBox_students.Size = new System.Drawing.Size(316, 485);
            this.listBox_students.TabIndex = 0;
            // 
            // panel_account
            // 
            this.panel_account.Controls.Add(this.button2);
            this.panel_account.Controls.Add(this.button1);
            this.panel_account.Controls.Add(this.label11);
            this.panel_account.Controls.Add(this.label10);
            this.panel_account.Controls.Add(this.label9);
            this.panel_account.Controls.Add(this.label8);
            this.panel_account.Controls.Add(this.textBox8);
            this.panel_account.Controls.Add(this.textBox7);
            this.panel_account.Controls.Add(this.textBox6);
            this.panel_account.Controls.Add(this.textBox5);
            this.panel_account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_account.Location = new System.Drawing.Point(0, 0);
            this.panel_account.Name = "panel_account";
            this.panel_account.Size = new System.Drawing.Size(778, 495);
            this.panel_account.TabIndex = 4;
            this.panel_account.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(208, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Confirm Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(246, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "First Name:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(308, 211);
            this.textBox8.Name = "textBox8";
            this.textBox8.PasswordChar = '*';
            this.textBox8.Size = new System.Drawing.Size(166, 20);
            this.textBox8.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(308, 185);
            this.textBox7.Name = "textBox7";
            this.textBox7.PasswordChar = '*';
            this.textBox7.Size = new System.Drawing.Size(166, 20);
            this.textBox7.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(308, 159);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(166, 20);
            this.textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(308, 133);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(166, 20);
            this.textBox5.TabIndex = 0;
            // 
            // TeacherInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 519);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_menu);
            this.Name = "TeacherInterface";
            this.Text = "TeacherInterface";
            this.panel_menu.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel_classes.ResumeLayout(false);
            this.tabs_classes.ResumeLayout(false);
            this.tab_classes_students.ResumeLayout(false);
            this.tab_classes_enrollment.ResumeLayout(false);
            this.tab_classes_exercises.ResumeLayout(false);
            this.panel_exercises.ResumeLayout(false);
            this.panel_exercises.PerformLayout();
            this.panel_students.ResumeLayout(false);
            this.panel_students.PerformLayout();
            this.panel_account.ResumeLayout(false);
            this.panel_account.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button button_menu_logout;
        private System.Windows.Forms.Button button_menu_account;
        private System.Windows.Forms.Button button_menu_students;
        private System.Windows.Forms.Button button_menu_exercises;
        private System.Windows.Forms.Button button_menu_classes;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_exercises;
        private System.Windows.Forms.Panel panel_classes;
        private System.Windows.Forms.TabControl tabs_classes;
        private System.Windows.Forms.TabPage tab_classes_students;
        private System.Windows.Forms.ListBox listBox_classes_studentPerformance;
        private System.Windows.Forms.ListBox listBox_classes_students;
        private System.Windows.Forms.TabPage tab_classes_enrollment;
        private System.Windows.Forms.ListBox listBox_classes_studentsEnrolled;
        private System.Windows.Forms.ListBox listBox_classes_studentsNotEnrolled;
        private System.Windows.Forms.TabPage tab_classes_exercises;
        private System.Windows.Forms.ListBox listBox_classes_exercisesIn;
        private System.Windows.Forms.ListBox listBox_classes_exercisesNotIn;
        private System.Windows.Forms.ListBox listBox_classes;
        private System.Windows.Forms.Panel panel_account;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel panel_students;
        private System.Windows.Forms.Button button_students_save;
        private System.Windows.Forms.Button button_students_delete;
        private System.Windows.Forms.Button button_students_reset;
        private System.Windows.Forms.Button button_students_new;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_students_classes;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox_students;
        private System.Windows.Forms.Button button_exercises_save;
        private System.Windows.Forms.Button button_exercises_delete;
        private System.Windows.Forms.Button button_exercises_reset;
        private System.Windows.Forms.Button button_exercises_new;
        private System.Windows.Forms.TextBox textBox_exercises_text;
        private System.Windows.Forms.TextBox textBox_exercises_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_exercises;

    }
}