
namespace XfinityMusic
{
    partial class musicPLayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musicPLayer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.queue = new System.Windows.Forms.ListBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.volBar = new System.Windows.Forms.TrackBar();
            this.lb_Volume = new System.Windows.Forms.Label();
            this.lb_CurVol = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_next = new System.Windows.Forms.PictureBox();
            this.btn_Prev = new System.Windows.Forms.PictureBox();
            this.btn_PlayPause = new System.Windows.Forms.PictureBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_CurPos = new System.Windows.Forms.Label();
            this.lb_EndTime = new System.Windows.Forms.Label();
            this.pb_AlbumArt = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volBar)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Prev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AlbumArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 76);
            this.panel1.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(673, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 76);
            this.panel12.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(674, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(166, 76);
            this.panel9.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.panel11.Controls.Add(this.btn_Minimize);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(82, 76);
            this.panel11.TabIndex = 1;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.Image")));
            this.btn_Minimize.Location = new System.Drawing.Point(20, 16);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(47, 43);
            this.btn_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minimize.TabIndex = 2;
            this.btn_Minimize.TabStop = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.panel10.Controls.Add(this.btn_close);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(85, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(81, 76);
            this.panel10.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(19, 23);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(36, 34);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 1;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(81, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "XfinityMusic";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 3);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Clear);
            this.panel3.Controls.Add(this.btn_Select);
            this.panel3.Controls.Add(this.queue);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 431);
            this.panel3.TabIndex = 2;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(68)))));
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.btn_Clear.Location = new System.Drawing.Point(28, 351);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(167, 35);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(68)))));
            this.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Select.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.btn_Select.Location = new System.Drawing.Point(28, 290);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(167, 38);
            this.btn_Select.TabIndex = 3;
            this.btn_Select.Text = "SELECT";
            this.btn_Select.UseVisualStyleBackColor = false;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // queue
            // 
            this.queue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(24)))), ((int)(((byte)(154)))));
            this.queue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queue.CausesValidation = false;
            this.queue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.queue.Dock = System.Windows.Forms.DockStyle.Top;
            this.queue.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(0)))), ((int)(((byte)(68)))));
            this.queue.FormattingEnabled = true;
            this.queue.ItemHeight = 23;
            this.queue.Location = new System.Drawing.Point(0, 54);
            this.queue.Name = "queue";
            this.queue.Size = new System.Drawing.Size(229, 207);
            this.queue.TabIndex = 2;
            this.queue.SelectedIndexChanged += new System.EventHandler(this.queue_SelectedIndexChanged);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 53);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(229, 1);
            this.panel8.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(229, 53);
            this.panel7.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(73, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Media";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(229, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 431);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.volBar);
            this.panel5.Controls.Add(this.lb_Volume);
            this.panel5.Controls.Add(this.lb_CurVol);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(728, 79);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(112, 431);
            this.panel5.TabIndex = 4;
            // 
            // volBar
            // 
            this.volBar.CausesValidation = false;
            this.volBar.Location = new System.Drawing.Point(31, 66);
            this.volBar.Maximum = 100;
            this.volBar.Name = "volBar";
            this.volBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volBar.Size = new System.Drawing.Size(56, 248);
            this.volBar.TabIndex = 12;
            this.volBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volBar.Value = 50;
            this.volBar.Scroll += new System.EventHandler(this.volBar_Scroll);
            // 
            // lb_Volume
            // 
            this.lb_Volume.AutoSize = true;
            this.lb_Volume.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(68)))));
            this.lb_Volume.Location = new System.Drawing.Point(21, 330);
            this.lb_Volume.Name = "lb_Volume";
            this.lb_Volume.Size = new System.Drawing.Size(79, 30);
            this.lb_Volume.TabIndex = 11;
            this.lb_Volume.Text = "Volume";
            // 
            // lb_CurVol
            // 
            this.lb_CurVol.AutoSize = true;
            this.lb_CurVol.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CurVol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(68)))));
            this.lb_CurVol.Location = new System.Drawing.Point(25, 33);
            this.lb_CurVol.Name = "lb_CurVol";
            this.lb_CurVol.Size = new System.Drawing.Size(48, 30);
            this.lb_CurVol.TabIndex = 10;
            this.lb_CurVol.Text = "50%";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_next);
            this.panel6.Controls.Add(this.btn_Prev);
            this.panel6.Controls.Add(this.btn_PlayPause);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(230, 410);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(497, 100);
            this.panel6.TabIndex = 5;
            // 
            // btn_next
            // 
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.Location = new System.Drawing.Point(314, 30);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(61, 45);
            this.btn_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_next.TabIndex = 2;
            this.btn_next.TabStop = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_Prev.Image")));
            this.btn_Prev.Location = new System.Drawing.Point(127, 30);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(57, 47);
            this.btn_Prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Prev.TabIndex = 1;
            this.btn_Prev.TabStop = false;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_PlayPause
            // 
            this.btn_PlayPause.Image = ((System.Drawing.Image)(resources.GetObject("btn_PlayPause.Image")));
            this.btn_PlayPause.Location = new System.Drawing.Point(216, 21);
            this.btn_PlayPause.Name = "btn_PlayPause";
            this.btn_PlayPause.Size = new System.Drawing.Size(69, 67);
            this.btn_PlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_PlayPause.TabIndex = 0;
            this.btn_PlayPause.TabStop = false;
            this.btn_PlayPause.Click += new System.EventHandler(this.btn_PlayPause_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(727, 79);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1, 431);
            this.panel13.TabIndex = 5;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(230, 409);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(497, 1);
            this.panel14.TabIndex = 6;
            // 
            // pBar
            // 
            this.pBar.BackColor = System.Drawing.Color.White;
            this.pBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(68)))));
            this.pBar.Location = new System.Drawing.Point(250, 392);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(459, 10);
            this.pBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar.TabIndex = 7;
            this.pBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBar_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_CurPos
            // 
            this.lb_CurPos.AutoSize = true;
            this.lb_CurPos.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CurPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(68)))));
            this.lb_CurPos.Location = new System.Drawing.Point(245, 359);
            this.lb_CurPos.Name = "lb_CurPos";
            this.lb_CurPos.Size = new System.Drawing.Size(61, 30);
            this.lb_CurPos.TabIndex = 8;
            this.lb_CurPos.Text = "00:00";
            // 
            // lb_EndTime
            // 
            this.lb_EndTime.AutoSize = true;
            this.lb_EndTime.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(68)))));
            this.lb_EndTime.Location = new System.Drawing.Point(648, 359);
            this.lb_EndTime.Name = "lb_EndTime";
            this.lb_EndTime.Size = new System.Drawing.Size(61, 30);
            this.lb_EndTime.TabIndex = 9;
            this.lb_EndTime.Text = "00:00";
            // 
            // pb_AlbumArt
            // 
            this.pb_AlbumArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_AlbumArt.Image = ((System.Drawing.Image)(resources.GetObject("pb_AlbumArt.Image")));
            this.pb_AlbumArt.Location = new System.Drawing.Point(329, 86);
            this.pb_AlbumArt.Name = "pb_AlbumArt";
            this.pb_AlbumArt.Size = new System.Drawing.Size(300, 301);
            this.pb_AlbumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_AlbumArt.TabIndex = 10;
            this.pb_AlbumArt.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(357, 212);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(44, 25);
            this.player.TabIndex = 11;
            // 
            // musicPLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(840, 510);
            this.Controls.Add(this.pb_AlbumArt);
            this.Controls.Add(this.lb_EndTime);
            this.Controls.Add(this.lb_CurPos);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "musicPLayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "musicPLayer";
            this.Load += new System.EventHandler(this.musicPLayer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volBar)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Prev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AlbumArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ListBox queue;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox btn_Minimize;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox btn_next;
        private System.Windows.Forms.PictureBox btn_Prev;
        private System.Windows.Forms.PictureBox btn_PlayPause;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_Volume;
        private System.Windows.Forms.Label lb_CurVol;
        private System.Windows.Forms.Label lb_CurPos;
        private System.Windows.Forms.Label lb_EndTime;
        private System.Windows.Forms.PictureBox pb_AlbumArt;
        private System.Windows.Forms.TrackBar volBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}

