namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkbutton = new System.Windows.Forms.Button();
            this.startstarlevel = new System.Windows.Forms.TextBox();
            this.wantstarlevel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.havememorypice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(410, 103);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(42, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "4성";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("-사파이어IIM", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "프리코네 재능개화 계산기";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(410, 81);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(42, 16);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "3성";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkbutton
            // 
            this.checkbutton.Location = new System.Drawing.Point(262, 96);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Size = new System.Drawing.Size(75, 23);
            this.checkbutton.TabIndex = 4;
            this.checkbutton.Text = "계산";
            this.checkbutton.UseVisualStyleBackColor = true;
            this.checkbutton.Click += new System.EventHandler(this.checkbutton_Click);
            // 
            // startstarlevel
            // 
            this.startstarlevel.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.startstarlevel.Location = new System.Drawing.Point(14, 96);
            this.startstarlevel.MaxLength = 1;
            this.startstarlevel.Name = "startstarlevel";
            this.startstarlevel.Size = new System.Drawing.Size(56, 21);
            this.startstarlevel.TabIndex = 5;
            this.startstarlevel.TextChanged += new System.EventHandler(this.startstarlevel_TextChanged);
            this.startstarlevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startstarlevel_KeyPress);
            // 
            // wantstarlevel
            // 
            this.wantstarlevel.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.wantstarlevel.Location = new System.Drawing.Point(92, 96);
            this.wantstarlevel.MaxLength = 1;
            this.wantstarlevel.Name = "wantstarlevel";
            this.wantstarlevel.Size = new System.Drawing.Size(56, 21);
            this.wantstarlevel.TabIndex = 6;
            this.wantstarlevel.TextChanged += new System.EventHandler(this.wantstarlevel_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "시작별";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "달성별";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.Location = new System.Drawing.Point(14, 187);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(189, 133);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // havememorypice
            // 
            this.havememorypice.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.havememorypice.Location = new System.Drawing.Point(176, 96);
            this.havememorypice.MaxLength = 3;
            this.havememorypice.Name = "havememorypice";
            this.havememorypice.Size = new System.Drawing.Size(56, 21);
            this.havememorypice.TabIndex = 11;
            this.havememorypice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "보유한\r\n메모리피스";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(231, 297);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 13;
            this.reset.Text = "초기화";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("한컴 소망 M", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(348, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 155);
            this.label5.TabIndex = 14;
            this.label5.Text = "0 ~ 20 = 1개\r\n21 ~ 30 = 2개\r\n31 ~ 40 = 3개\r\n41 ~ 50 = 4개\r\n51 ~ 60~ = 5개";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("문체부 제목 돋음체", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(376, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "구입수";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("문체부 제목 돋음체", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(463, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "여신의보석\r\n비용";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(552, 364);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.havememorypice);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wantstarlevel);
            this.Controls.Add(this.startstarlevel);
            this.Controls.Add(this.checkbutton);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "재능개화 계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button checkbutton;
        private System.Windows.Forms.TextBox startstarlevel;
        private System.Windows.Forms.TextBox wantstarlevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox havememorypice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

