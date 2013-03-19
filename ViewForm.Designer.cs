namespace GamePadView
{
    partial class ViewForm
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
            this.stick = new System.Windows.Forms.PictureBox();
            this.btn_R = new System.Windows.Forms.PictureBox();
            this.btn_x = new System.Windows.Forms.PictureBox();
            this.btn_b = new System.Windows.Forms.PictureBox();
            this.btn_a = new System.Windows.Forms.PictureBox();
            this.btn_y = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.calibrationTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_Dleft = new System.Windows.Forms.PictureBox();
            this.btn_Dright = new System.Windows.Forms.PictureBox();
            this.btn_Ddown = new System.Windows.Forms.PictureBox();
            this.btn_Dup = new System.Windows.Forms.PictureBox();
            this.btn_L = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.calibrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stick2 = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.PictureBox();
            this.btnR_trig = new System.Windows.Forms.PictureBox();
            this.btnL_trig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Dleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Dright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Ddown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Dup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnR_trig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnL_trig)).BeginInit();
            this.SuspendLayout();
            // 
            // stick
            // 
            this.stick.BackColor = System.Drawing.Color.Transparent;
            this.stick.BackgroundImage = global::GamePadView.Properties.Resources.stick;
            this.stick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stick.Location = new System.Drawing.Point(53, 31);
            this.stick.Name = "stick";
            this.stick.Size = new System.Drawing.Size(34, 35);
            this.stick.TabIndex = 9;
            this.stick.TabStop = false;
            // 
            // btn_R
            // 
            this.btn_R.BackColor = System.Drawing.Color.Transparent;
            this.btn_R.BackgroundImage = global::GamePadView.Properties.Resources.circle;
            this.btn_R.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_R.Location = new System.Drawing.Point(213, 2);
            this.btn_R.Name = "btn_R";
            this.btn_R.Size = new System.Drawing.Size(30, 14);
            this.btn_R.TabIndex = 8;
            this.btn_R.TabStop = false;
            // 
            // btn_x
            // 
            this.btn_x.BackColor = System.Drawing.Color.Transparent;
            this.btn_x.BackgroundImage = global::GamePadView.Properties.Resources.circle;
            this.btn_x.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_x.Location = new System.Drawing.Point(199, 41);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(23, 23);
            this.btn_x.TabIndex = 6;
            this.btn_x.TabStop = false;
            // 
            // btn_b
            // 
            this.btn_b.BackColor = System.Drawing.Color.Transparent;
            this.btn_b.BackgroundImage = global::GamePadView.Properties.Resources.circle;
            this.btn_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_b.Location = new System.Drawing.Point(241, 41);
            this.btn_b.Name = "btn_b";
            this.btn_b.Size = new System.Drawing.Size(23, 23);
            this.btn_b.TabIndex = 5;
            this.btn_b.TabStop = false;
            // 
            // btn_a
            // 
            this.btn_a.BackColor = System.Drawing.Color.Transparent;
            this.btn_a.BackgroundImage = global::GamePadView.Properties.Resources.circle;
            this.btn_a.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_a.Location = new System.Drawing.Point(221, 61);
            this.btn_a.Name = "btn_a";
            this.btn_a.Size = new System.Drawing.Size(23, 23);
            this.btn_a.TabIndex = 4;
            this.btn_a.TabStop = false;
            // 
            // btn_y
            // 
            this.btn_y.BackColor = System.Drawing.Color.Transparent;
            this.btn_y.BackgroundImage = global::GamePadView.Properties.Resources.circle;
            this.btn_y.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_y.Location = new System.Drawing.Point(220, 22);
            this.btn_y.Name = "btn_y";
            this.btn_y.Size = new System.Drawing.Size(23, 23);
            this.btn_y.TabIndex = 3;
            this.btn_y.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Dleft
            // 
            this.btn_Dleft.BackColor = System.Drawing.Color.Transparent;
            this.btn_Dleft.BackgroundImage = global::GamePadView.Properties.Resources.circle;
            this.btn_Dleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Dleft.Location = new System.Drawing.Point(84, 89);
            this.btn_Dleft.Name = "btn_Dleft";
            this.btn_Dleft.Size = new System.Drawing.Size(16, 16);
            this.btn_Dleft.TabIndex = 15;
            this.btn_Dleft.TabStop = false;
            // 
            // btn_Dright
            // 
            this.btn_Dright.BackColor = System.Drawing.Color.Transparent;
            this.btn_Dright.BackgroundImage = global::GamePadView.Properties.Resources.circle;
            this.btn_Dright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Dright.Location = new System.Drawing.Point(117, 88);
            this.btn_Dright.Name = "btn_Dright";
            this.btn_Dright.Size = new System.Drawing.Size(16, 16);
            this.btn_Dright.TabIndex = 14;
            this.btn_Dright.TabStop = false;
            // 
            // btn_Ddown
            // 
            this.btn_Ddown.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ddown.BackgroundImage = global::GamePadView.Properties.Resources.circle;
            this.btn_Ddown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ddown.Location = new System.Drawing.Point(101, 105);
            this.btn_Ddown.Name = "btn_Ddown";
            this.btn_Ddown.Size = new System.Drawing.Size(16, 16);
            this.btn_Ddown.TabIndex = 13;
            this.btn_Ddown.TabStop = false;
            // 
            // btn_Dup
            // 
            this.btn_Dup.BackColor = System.Drawing.Color.Transparent;
            this.btn_Dup.BackgroundImage = global::GamePadView.Properties.Resources.circle;
            this.btn_Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Dup.Location = new System.Drawing.Point(101, 73);
            this.btn_Dup.Name = "btn_Dup";
            this.btn_Dup.Size = new System.Drawing.Size(16, 16);
            this.btn_Dup.TabIndex = 12;
            this.btn_Dup.TabStop = false;
            // 
            // btn_L
            // 
            this.btn_L.BackColor = System.Drawing.Color.Transparent;
            this.btn_L.BackgroundImage = global::GamePadView.Properties.Resources.circle;
            this.btn_L.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_L.Location = new System.Drawing.Point(61, 2);
            this.btn_L.Name = "btn_L";
            this.btn_L.Size = new System.Drawing.Size(30, 14);
            this.btn_L.TabIndex = 16;
            this.btn_L.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // calibrateToolStripMenuItem
            // 
            this.calibrateToolStripMenuItem.Name = "calibrateToolStripMenuItem";
            this.calibrateToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // stick2
            // 
            this.stick2.BackColor = System.Drawing.Color.Transparent;
            this.stick2.BackgroundImage = global::GamePadView.Properties.Resources.stick;
            this.stick2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stick2.Location = new System.Drawing.Point(174, 78);
            this.stick2.Name = "stick2";
            this.stick2.Size = new System.Drawing.Size(34, 35);
            this.stick2.TabIndex = 18;
            this.stick2.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = global::GamePadView.Properties.Resources.circle;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(108, 45);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(22, 16);
            this.btn_back.TabIndex = 19;
            this.btn_back.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.BackgroundImage = global::GamePadView.Properties.Resources.circle;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.Location = new System.Drawing.Point(172, 45);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(22, 16);
            this.btn_start.TabIndex = 20;
            this.btn_start.TabStop = false;
            // 
            // btnR_trig
            // 
            this.btnR_trig.BackColor = System.Drawing.Color.Transparent;
            this.btnR_trig.BackgroundImage = global::GamePadView.Properties.Resources.circle;
            this.btnR_trig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnR_trig.Location = new System.Drawing.Point(249, 12);
            this.btnR_trig.Name = "btnR_trig";
            this.btnR_trig.Size = new System.Drawing.Size(30, 14);
            this.btnR_trig.TabIndex = 21;
            this.btnR_trig.TabStop = false;
            // 
            // btnL_trig
            // 
            this.btnL_trig.BackColor = System.Drawing.Color.Transparent;
            this.btnL_trig.BackgroundImage = global::GamePadView.Properties.Resources.circle;
            this.btnL_trig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnL_trig.Location = new System.Drawing.Point(23, 12);
            this.btnL_trig.Name = "btnL_trig";
            this.btnL_trig.Size = new System.Drawing.Size(30, 14);
            this.btnL_trig.TabIndex = 22;
            this.btnL_trig.TabStop = false;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::GamePadView.Properties.Resources.pad1;
            this.ClientSize = new System.Drawing.Size(299, 221);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnL_trig);
            this.Controls.Add(this.btnR_trig);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.stick2);
            this.Controls.Add(this.btn_L);
            this.Controls.Add(this.btn_Dleft);
            this.Controls.Add(this.btn_Dright);
            this.Controls.Add(this.btn_Ddown);
            this.Controls.Add(this.btn_Dup);
            this.Controls.Add(this.stick);
            this.Controls.Add(this.btn_R);
            this.Controls.Add(this.btn_x);
            this.Controls.Add(this.btn_b);
            this.Controls.Add(this.btn_a);
            this.Controls.Add(this.btn_y);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewForm";
            this.Text = "XBOX 360 Pad Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.stick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Dleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Dright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Ddown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Dup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnR_trig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnL_trig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_y;
        private System.Windows.Forms.PictureBox btn_a;
        private System.Windows.Forms.PictureBox btn_b;
        private System.Windows.Forms.PictureBox btn_x;
        private System.Windows.Forms.PictureBox btn_R;
        private System.Windows.Forms.PictureBox stick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer calibrationTimer;
        private System.Windows.Forms.PictureBox btn_Dleft;
        private System.Windows.Forms.PictureBox btn_Dright;
        private System.Windows.Forms.PictureBox btn_Ddown;
        private System.Windows.Forms.PictureBox btn_Dup;
        private System.Windows.Forms.PictureBox btn_L;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calibrateToolStripMenuItem;
        private System.Windows.Forms.PictureBox stick2;
        private System.Windows.Forms.PictureBox btn_back;
        private System.Windows.Forms.PictureBox btn_start;
        private System.Windows.Forms.PictureBox btnR_trig;
        private System.Windows.Forms.PictureBox btnL_trig;
    }
}

