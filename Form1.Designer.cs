using System.Windows.Forms;

namespace servo_tracker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.DEGREE = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SEND = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CHECKER = new System.Windows.Forms.GroupBox();
            this.OFF = new System.Windows.Forms.Button();
            this.ON = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SEARCH = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bb = new System.Windows.Forms.Button();
            this.lll = new System.Windows.Forms.Button();
            this.rr = new System.Windows.Forms.Button();
            this.f = new System.Windows.Forms.Button();
            this.ss = new System.Windows.Forms.Button();
            this.CONTROLLER = new System.Windows.Forms.GroupBox();
            this.Line_Follower = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.CHECKER.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.CONTROLLER.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackBar1.Location = new System.Drawing.Point(26, 28);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(251, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // DEGREE
            // 
            this.DEGREE.AutoSize = true;
            this.DEGREE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DEGREE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEGREE.Location = new System.Drawing.Point(302, 28);
            this.DEGREE.Name = "DEGREE";
            this.DEGREE.Size = new System.Drawing.Size(72, 18);
            this.DEGREE.TabIndex = 4;
            this.DEGREE.Text = "DEGREE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "SPEED";
            // 
            // SEND
            // 
            this.SEND.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.SEND.Location = new System.Drawing.Point(109, 43);
            this.SEND.Name = "SEND";
            this.SEND.Size = new System.Drawing.Size(75, 23);
            this.SEND.TabIndex = 6;
            this.SEND.Text = "SEND";
            this.SEND.UseVisualStyleBackColor = true;
            this.SEND.Click += new System.EventHandler(this.SEND_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM6",
            "COM7"});
            this.comboBox1.Location = new System.Drawing.Point(109, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(20, 103);
            this.trackBar2.Maximum = 361;
            this.trackBar2.Minimum = 181;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(251, 45);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.Value = 200;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "CONNECT";
            // 
            // CHECKER
            // 
            this.CHECKER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CHECKER.Controls.Add(this.OFF);
            this.CHECKER.Controls.Add(this.ON);
            this.CHECKER.Location = new System.Drawing.Point(295, 185);
            this.CHECKER.Name = "CHECKER";
            this.CHECKER.Size = new System.Drawing.Size(138, 98);
            this.CHECKER.TabIndex = 15;
            this.CHECKER.TabStop = false;
            this.CHECKER.Text = "CHECKER";
            // 
            // OFF
            // 
            this.OFF.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.OFF.FlatAppearance.BorderSize = 4;
            this.OFF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.OFF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.OFF.Location = new System.Drawing.Point(78, 32);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(45, 43);
            this.OFF.TabIndex = 15;
            this.OFF.Text = "OFF";
            this.OFF.UseVisualStyleBackColor = true;
            this.OFF.Click += new System.EventHandler(this.OFF_Click);
            // 
            // ON
            // 
            this.ON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.ON.Location = new System.Drawing.Point(6, 32);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(53, 43);
            this.ON.TabIndex = 16;
            this.ON.Text = "ON";
            this.ON.UseVisualStyleBackColor = true;
            this.ON.Click += new System.EventHandler(this.ON_Click);
            this.ON.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ON_KeyDown);
            this.ON.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ON_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SEND);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 98);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONNECTION";
            this.groupBox1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.groupBox1_ControlAdded);
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "COM PORT";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.trackBar2);
            this.groupBox2.Controls.Add(this.DEGREE);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 167);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SERVO ANGLE";
            // 
            // SEARCH
            // 
            this.SEARCH.BackColor = System.Drawing.Color.DimGray;
            this.SEARCH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.SEARCH.Location = new System.Drawing.Point(17, 28);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(75, 23);
            this.SEARCH.TabIndex = 17;
            this.SEARCH.Text = "SEARCH";
            this.SEARCH.UseVisualStyleBackColor = false;
            this.SEARCH.Click += new System.EventHandler(this.SEARCH_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(17, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 21);
            this.textBox1.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.SEARCH);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(224, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 107);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SEARCH";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(448, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 665);
            this.panel1.TabIndex = 21;
            // 
            // bb
            // 
            this.bb.BackColor = System.Drawing.Color.Black;
            this.bb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bb.BackgroundImage")));
            this.bb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bb.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bb.FlatAppearance.BorderSize = 0;
            this.bb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.bb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bb.Location = new System.Drawing.Point(77, 114);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(50, 50);
            this.bb.TabIndex = 15;
            this.bb.UseVisualStyleBackColor = false;
            this.bb.Click += new System.EventHandler(this.bb_Click);
            // 
            // lll
            // 
            this.lll.BackColor = System.Drawing.Color.Black;
            this.lll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lll.BackgroundImage")));
            this.lll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.lll.FlatAppearance.BorderSize = 0;
            this.lll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.lll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lll.Location = new System.Drawing.Point(12, 66);
            this.lll.Name = "lll";
            this.lll.Size = new System.Drawing.Size(50, 50);
            this.lll.TabIndex = 16;
            this.lll.UseVisualStyleBackColor = false;
            this.lll.Click += new System.EventHandler(this.lll_Click);
            // 
            // rr
            // 
            this.rr.BackColor = System.Drawing.Color.Black;
            this.rr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rr.BackgroundImage")));
            this.rr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rr.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rr.FlatAppearance.BorderSize = 0;
            this.rr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.rr.ForeColor = System.Drawing.Color.Black;
            this.rr.Location = new System.Drawing.Point(139, 66);
            this.rr.Name = "rr";
            this.rr.Size = new System.Drawing.Size(50, 50);
            this.rr.TabIndex = 17;
            this.rr.UseVisualStyleBackColor = false;
            this.rr.Click += new System.EventHandler(this.rr_Click);
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.Black;
            this.f.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("f.BackgroundImage")));
            this.f.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.f.FlatAppearance.BorderSize = 0;
            this.f.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.f.ForeColor = System.Drawing.Color.Transparent;
            this.f.Location = new System.Drawing.Point(77, 19);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(50, 50);
            this.f.TabIndex = 18;
            this.f.UseVisualStyleBackColor = false;
            this.f.Click += new System.EventHandler(this.f_Click);
            // 
            // ss
            // 
            this.ss.BackColor = System.Drawing.Color.Black;
            this.ss.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ss.BackgroundImage")));
            this.ss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ss.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ss.FlatAppearance.BorderSize = 0;
            this.ss.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.ss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ss.Location = new System.Drawing.Point(86, 75);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(32, 24);
            this.ss.TabIndex = 22;
            this.ss.Text = "ss";
            this.ss.UseVisualStyleBackColor = false;
            this.ss.Click += new System.EventHandler(this.ss_Click);
            // 
            // CONTROLLER
            // 
            this.CONTROLLER.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CONTROLLER.Controls.Add(this.ss);
            this.CONTROLLER.Controls.Add(this.f);
            this.CONTROLLER.Controls.Add(this.bb);
            this.CONTROLLER.Controls.Add(this.lll);
            this.CONTROLLER.Controls.Add(this.rr);
            this.CONTROLLER.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CONTROLLER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONTROLLER.ForeColor = System.Drawing.Color.Red;
            this.CONTROLLER.Location = new System.Drawing.Point(12, 289);
            this.CONTROLLER.Name = "CONTROLLER";
            this.CONTROLLER.Size = new System.Drawing.Size(206, 180);
            this.CONTROLLER.TabIndex = 14;
            this.CONTROLLER.TabStop = false;
            this.CONTROLLER.Text = "CONTROLLER";
            // 
            // Line_Follower
            // 
            this.Line_Follower.BackColor = System.Drawing.Color.DimGray;
            this.Line_Follower.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Line_Follower.Location = new System.Drawing.Point(241, 421);
            this.Line_Follower.Name = "Line_Follower";
            this.Line_Follower.Size = new System.Drawing.Size(88, 48);
            this.Line_Follower.TabIndex = 20;
            this.Line_Follower.Text = "line Follower";
            this.Line_Follower.UseVisualStyleBackColor = true;
            this.Line_Follower.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1325, 592);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CHECKER);
            this.Controls.Add(this.CONTROLLER);
            this.Controls.Add(this.Line_Follower);
            this.Name = "Form1";
            this.Text = "BLUETOOTH CAR ";
            this.AutoSizeChanged += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.CHECKER.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.CONTROLLER.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DEGREE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SEND;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox CHECKER;
        private System.Windows.Forms.Button OFF;
        private System.Windows.Forms.Button ON;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SEARCH;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private KeyEventHandler S;
        private Panel panel1;
        private Button bb;
        private Button lll;
        private Button rr;
        private Button f;
        private Button ss;
        public System.IO.Ports.SerialPort serialPort1;
        private GroupBox CONTROLLER;
        public Button Line_Follower;
    }
}

