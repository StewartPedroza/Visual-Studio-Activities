namespace Student_Information_Pedroza
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rButtonF = new System.Windows.Forms.RadioButton();
            this.rButtonM = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbWorkout = new System.Windows.Forms.CheckBox();
            this.cbGame = new System.Windows.Forms.CheckBox();
            this.cbMovie = new System.Windows.Forms.CheckBox();
            this.cbRead = new System.Windows.Forms.CheckBox();
            this.cbDance = new System.Windows.Forms.CheckBox();
            this.cbSing = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.browse = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 23);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rButtonF);
            this.groupBox1.Controls.Add(this.rButtonM);
            this.groupBox1.Location = new System.Drawing.Point(102, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rButtonF
            // 
            this.rButtonF.AutoSize = true;
            this.rButtonF.Location = new System.Drawing.Point(14, 51);
            this.rButtonF.Name = "rButtonF";
            this.rButtonF.Size = new System.Drawing.Size(63, 19);
            this.rButtonF.TabIndex = 1;
            this.rButtonF.TabStop = true;
            this.rButtonF.Text = "Female";
            this.rButtonF.UseVisualStyleBackColor = true;
            this.rButtonF.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rButtonM
            // 
            this.rButtonM.AutoSize = true;
            this.rButtonM.Location = new System.Drawing.Point(15, 22);
            this.rButtonM.Name = "rButtonM";
            this.rButtonM.Size = new System.Drawing.Size(51, 19);
            this.rButtonM.TabIndex = 0;
            this.rButtonM.TabStop = true;
            this.rButtonM.Text = "Male";
            this.rButtonM.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Birthdate";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbWorkout);
            this.groupBox2.Controls.Add(this.cbGame);
            this.groupBox2.Controls.Add(this.cbMovie);
            this.groupBox2.Controls.Add(this.cbRead);
            this.groupBox2.Controls.Add(this.cbDance);
            this.groupBox2.Controls.Add(this.cbSing);
            this.groupBox2.Location = new System.Drawing.Point(102, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 120);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // cbWorkout
            // 
            this.cbWorkout.AutoSize = true;
            this.cbWorkout.Location = new System.Drawing.Point(179, 84);
            this.cbWorkout.Name = "cbWorkout";
            this.cbWorkout.Size = new System.Drawing.Size(72, 19);
            this.cbWorkout.TabIndex = 5;
            this.cbWorkout.Text = "Workout";
            this.cbWorkout.UseVisualStyleBackColor = true;
            // 
            // cbGame
            // 
            this.cbGame.AutoSize = true;
            this.cbGame.Location = new System.Drawing.Point(179, 59);
            this.cbGame.Name = "cbGame";
            this.cbGame.Size = new System.Drawing.Size(68, 19);
            this.cbGame.TabIndex = 4;
            this.cbGame.Text = "Gaming";
            this.cbGame.UseVisualStyleBackColor = true;
            // 
            // cbMovie
            // 
            this.cbMovie.AutoSize = true;
            this.cbMovie.Location = new System.Drawing.Point(179, 34);
            this.cbMovie.Name = "cbMovie";
            this.cbMovie.Size = new System.Drawing.Size(118, 19);
            this.cbMovie.TabIndex = 3;
            this.cbMovie.Text = "Watching Movies";
            this.cbMovie.UseVisualStyleBackColor = true;
            // 
            // cbRead
            // 
            this.cbRead.AutoSize = true;
            this.cbRead.Location = new System.Drawing.Point(21, 84);
            this.cbRead.Name = "cbRead";
            this.cbRead.Size = new System.Drawing.Size(69, 19);
            this.cbRead.TabIndex = 2;
            this.cbRead.Text = "Reading";
            this.cbRead.UseVisualStyleBackColor = true;
            // 
            // cbDance
            // 
            this.cbDance.AutoSize = true;
            this.cbDance.Location = new System.Drawing.Point(21, 59);
            this.cbDance.Name = "cbDance";
            this.cbDance.Size = new System.Drawing.Size(70, 19);
            this.cbDance.TabIndex = 1;
            this.cbDance.Text = "Dancing";
            this.cbDance.UseVisualStyleBackColor = true;
            // 
            // cbSing
            // 
            this.cbSing.AutoSize = true;
            this.cbSing.Location = new System.Drawing.Point(21, 34);
            this.cbSing.Name = "cbSing";
            this.cbSing.Size = new System.Drawing.Size(66, 19);
            this.cbSing.TabIndex = 0;
            this.cbSing.Text = "Singing";
            this.cbSing.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hobbies";
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(528, 45);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(209, 250);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture.TabIndex = 9;
            this.picture.TabStop = false;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(531, 307);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 10;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(595, 363);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(107, 58);
            this.submit.TabIndex = 11;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private GroupBox groupBox1;
        private RadioButton rButtonF;
        private RadioButton rButtonM;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private CheckBox cbWorkout;
        private CheckBox cbGame;
        private CheckBox cbMovie;
        private CheckBox cbRead;
        private CheckBox cbDance;
        private CheckBox cbSing;
        private Label label5;
        private PictureBox picture;
        private Button browse;
        private Button submit;
    }
}