namespace 抛体弓术
{
    partial class game
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trk_bar = new System.Windows.Forms.TrackBar();
            this.btn = new System.Windows.Forms.Button();
            this.trk_angle = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lab_angle = new System.Windows.Forms.Label();
            this.lab_force = new System.Windows.Forms.Label();
            this.lab_stat = new System.Windows.Forms.Label();
            this.btn_init = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_HP = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_HPMAX = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lab_grade = new System.Windows.Forms.Label();
            this.game_window = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trk_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_angle)).BeginInit();
            this.game_window.SuspendLayout();
            this.SuspendLayout();
            // 
            // trk_bar
            // 
            this.trk_bar.Location = new System.Drawing.Point(108, 463);
            this.trk_bar.Maximum = -25;
            this.trk_bar.Minimum = -50;
            this.trk_bar.Name = "trk_bar";
            this.trk_bar.Size = new System.Drawing.Size(240, 56);
            this.trk_bar.SmallChange = 2;
            this.trk_bar.TabIndex = 1;
            this.trk_bar.Value = -25;
            this.trk_bar.Scroll += new System.EventHandler(this.trk_bar_Scroll);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn.Font = new System.Drawing.Font("华文隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn.Location = new System.Drawing.Point(21, 463);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(66, 44);
            this.btn.TabIndex = 2;
            this.btn.Text = "发射";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // trk_angle
            // 
            this.trk_angle.LargeChange = 10;
            this.trk_angle.Location = new System.Drawing.Point(21, 158);
            this.trk_angle.Maximum = 80;
            this.trk_angle.Minimum = 10;
            this.trk_angle.Name = "trk_angle";
            this.trk_angle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trk_angle.Size = new System.Drawing.Size(56, 147);
            this.trk_angle.SmallChange = 10;
            this.trk_angle.TabIndex = 1;
            this.trk_angle.Value = 20;
            this.trk_angle.Scroll += new System.EventHandler(this.trk_angle_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lab_angle
            // 
            this.lab_angle.AutoSize = true;
            this.lab_angle.Location = new System.Drawing.Point(18, 110);
            this.lab_angle.Name = "lab_angle";
            this.lab_angle.Size = new System.Drawing.Size(15, 15);
            this.lab_angle.TabIndex = 3;
            this.lab_angle.Text = "-";
            // 
            // lab_force
            // 
            this.lab_force.AutoSize = true;
            this.lab_force.Location = new System.Drawing.Point(327, 428);
            this.lab_force.Name = "lab_force";
            this.lab_force.Size = new System.Drawing.Size(15, 15);
            this.lab_force.TabIndex = 3;
            this.lab_force.Text = "-";
            // 
            // lab_stat
            // 
            this.lab_stat.AutoSize = true;
            this.lab_stat.Location = new System.Drawing.Point(701, 453);
            this.lab_stat.Name = "lab_stat";
            this.lab_stat.Size = new System.Drawing.Size(15, 15);
            this.lab_stat.TabIndex = 4;
            this.lab_stat.Text = "-";
            // 
            // btn_init
            // 
            this.btn_init.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_init.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_init.Location = new System.Drawing.Point(493, 527);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(165, 35);
            this.btn_init.TabIndex = 6;
            this.btn_init.Text = "开始游戏";
            this.btn_init.UseVisualStyleBackColor = false;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("华文隶书", 14F);
            this.label6.Location = new System.Drawing.Point(104, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "箭";
            // 
            // lab_HP
            // 
            this.lab_HP.AutoSize = true;
            this.lab_HP.BackColor = System.Drawing.Color.Transparent;
            this.lab_HP.Font = new System.Drawing.Font("华文隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_HP.Location = new System.Drawing.Point(152, 552);
            this.lab_HP.Name = "lab_HP";
            this.lab_HP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lab_HP.Size = new System.Drawing.Size(26, 24);
            this.lab_HP.TabIndex = 7;
            this.lab_HP.Text = "--";
            this.lab_HP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("华文隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(184, 552);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "/";
            // 
            // lab_HPMAX
            // 
            this.lab_HPMAX.AutoSize = true;
            this.lab_HPMAX.BackColor = System.Drawing.Color.Transparent;
            this.lab_HPMAX.Font = new System.Drawing.Font("华文隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_HPMAX.Location = new System.Drawing.Point(221, 551);
            this.lab_HPMAX.Name = "lab_HPMAX";
            this.lab_HPMAX.Size = new System.Drawing.Size(26, 24);
            this.lab_HPMAX.TabIndex = 7;
            this.lab_HPMAX.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("华文隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(263, 552);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "只";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("华文隶书", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(508, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "得分";
            // 
            // lab_grade
            // 
            this.lab_grade.AutoSize = true;
            this.lab_grade.BackColor = System.Drawing.Color.Transparent;
            this.lab_grade.Font = new System.Drawing.Font("华文隶书", 16F, System.Drawing.FontStyle.Bold);
            this.lab_grade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lab_grade.Location = new System.Drawing.Point(619, 480);
            this.lab_grade.Name = "lab_grade";
            this.lab_grade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lab_grade.Size = new System.Drawing.Size(25, 27);
            this.lab_grade.TabIndex = 8;
            this.lab_grade.Text = "0";
            // 
            // game_window
            // 
            this.game_window.BackgroundImage = global::抛体弓术.Properties.Resources._1;
            this.game_window.Controls.Add(this.lab_stat);
            this.game_window.Controls.Add(this.btn_init);
            this.game_window.Controls.Add(this.label6);
            this.game_window.Controls.Add(this.lab_HP);
            this.game_window.Controls.Add(this.lab_force);
            this.game_window.Controls.Add(this.label8);
            this.game_window.Controls.Add(this.trk_bar);
            this.game_window.Controls.Add(this.lab_HPMAX);
            this.game_window.Controls.Add(this.lab_grade);
            this.game_window.Controls.Add(this.label9);
            this.game_window.Controls.Add(this.label7);
            this.game_window.Controls.Add(this.btn);
            this.game_window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.game_window.Location = new System.Drawing.Point(0, 0);
            this.game_window.Name = "game_window";
            this.game_window.Size = new System.Drawing.Size(791, 600);
            this.game_window.TabIndex = 9;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(791, 600);
            this.Controls.Add(this.lab_angle);
            this.Controls.Add(this.trk_angle);
            this.Controls.Add(this.game_window);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "game";
            this.Text = "GAME";
            ((System.ComponentModel.ISupportInitialize)(this.trk_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_angle)).EndInit();
            this.game_window.ResumeLayout(false);
            this.game_window.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trk_bar;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TrackBar trk_angle;
        private System.Windows.Forms.Label lab_angle;
        private System.Windows.Forms.Label lab_force;
        private System.Windows.Forms.Label lab_stat;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab_HP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_HPMAX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lab_grade;
        private System.Windows.Forms.Panel game_window;
        private System.Windows.Forms.Timer timer1;
    }
}

