namespace KOgame
{
    partial class Form1
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
            this.btn_attack = new System.Windows.Forms.Button();
            this.btn_hit = new System.Windows.Forms.Button();
            this.lab_myhp = new System.Windows.Forms.Label();
            this.lab_hp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.lab_stat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_attack
            // 
            this.btn_attack.Location = new System.Drawing.Point(45, 229);
            this.btn_attack.Name = "btn_attack";
            this.btn_attack.Size = new System.Drawing.Size(123, 41);
            this.btn_attack.TabIndex = 0;
            this.btn_attack.Text = "普攻";
            this.btn_attack.UseVisualStyleBackColor = true;
            this.btn_attack.Click += new System.EventHandler(this.btn_attack_Click);
            // 
            // btn_hit
            // 
            this.btn_hit.Location = new System.Drawing.Point(45, 276);
            this.btn_hit.Name = "btn_hit";
            this.btn_hit.Size = new System.Drawing.Size(123, 41);
            this.btn_hit.TabIndex = 0;
            this.btn_hit.Text = "技能";
            this.btn_hit.UseVisualStyleBackColor = true;
            // 
            // lab_myhp
            // 
            this.lab_myhp.AutoSize = true;
            this.lab_myhp.Font = new System.Drawing.Font("宋体", 20F);
            this.lab_myhp.Location = new System.Drawing.Point(97, 42);
            this.lab_myhp.Name = "lab_myhp";
            this.lab_myhp.Size = new System.Drawing.Size(26, 27);
            this.lab_myhp.TabIndex = 1;
            this.lab_myhp.Text = "-";
            // 
            // lab_hp
            // 
            this.lab_hp.AutoSize = true;
            this.lab_hp.Font = new System.Drawing.Font("宋体", 20F);
            this.lab_hp.Location = new System.Drawing.Point(374, 42);
            this.lab_hp.Name = "lab_hp";
            this.lab_hp.Size = new System.Drawing.Size(26, 27);
            this.lab_hp.TabIndex = 2;
            this.lab_hp.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "我的HP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(269, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "上泉的HP:";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(332, 229);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "开始游戏";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lab_stat
            // 
            this.lab_stat.AutoSize = true;
            this.lab_stat.Location = new System.Drawing.Point(332, 304);
            this.lab_stat.Name = "lab_stat";
            this.lab_stat.Size = new System.Drawing.Size(11, 12);
            this.lab_stat.TabIndex = 5;
            this.lab_stat.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 349);
            this.Controls.Add(this.lab_stat);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_hp);
            this.Controls.Add(this.lab_myhp);
            this.Controls.Add(this.btn_hit);
            this.Controls.Add(this.btn_attack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_attack;
        private System.Windows.Forms.Button btn_hit;
        private System.Windows.Forms.Label lab_myhp;
        private System.Windows.Forms.Label lab_hp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lab_stat;
    }
}

