namespace LOL_Login
{
    partial class Form3
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
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RadioButton_QHD = new System.Windows.Forms.RadioButton();
            this.RadioButton_FHD = new System.Windows.Forms.RadioButton();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RadioButton_125 = new System.Windows.Forms.RadioButton();
            this.RadioButton_100 = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioButton_QHD
            // 
            this.RadioButton_QHD.AutoSize = true;
            this.RadioButton_QHD.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.RadioButton_QHD.Location = new System.Drawing.Point(6, 59);
            this.RadioButton_QHD.Name = "RadioButton_QHD";
            this.RadioButton_QHD.Size = new System.Drawing.Size(110, 24);
            this.RadioButton_QHD.TabIndex = 1;
            this.RadioButton_QHD.TabStop = true;
            this.RadioButton_QHD.Text = "2560 * 1440";
            this.RadioButton_QHD.UseVisualStyleBackColor = true;
            this.RadioButton_QHD.CheckedChanged += new System.EventHandler(this.RadioButton_QHD_CheckedChanged);
            // 
            // RadioButton_FHD
            // 
            this.RadioButton_FHD.AutoSize = true;
            this.RadioButton_FHD.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.RadioButton_FHD.Location = new System.Drawing.Point(6, 29);
            this.RadioButton_FHD.Name = "RadioButton_FHD";
            this.RadioButton_FHD.Size = new System.Drawing.Size(155, 24);
            this.RadioButton_FHD.TabIndex = 0;
            this.RadioButton_FHD.TabStop = true;
            this.RadioButton_FHD.Text = "1920 * 1080 (기본)";
            this.RadioButton_FHD.UseVisualStyleBackColor = true;
            this.RadioButton_FHD.CheckedChanged += new System.EventHandler(this.RadioButton_FHD_CheckedChanged);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Button_Exit.Location = new System.Drawing.Point(243, 107);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(107, 48);
            this.Button_Exit.TabIndex = 4;
            this.Button_Exit.Text = "저장 후 닫기";
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioButton_QHD);
            this.groupBox2.Controls.Add(this.RadioButton_FHD);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 89);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "해상도 설정";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RadioButton_125);
            this.groupBox3.Controls.Add(this.RadioButton_100);
            this.groupBox3.Location = new System.Drawing.Point(184, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 89);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "배율 설정";
            // 
            // RadioButton_125
            // 
            this.RadioButton_125.AutoSize = true;
            this.RadioButton_125.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.RadioButton_125.Location = new System.Drawing.Point(6, 59);
            this.RadioButton_125.Name = "RadioButton_125";
            this.RadioButton_125.Size = new System.Drawing.Size(67, 24);
            this.RadioButton_125.TabIndex = 3;
            this.RadioButton_125.TabStop = true;
            this.RadioButton_125.Text = "125%";
            this.RadioButton_125.UseVisualStyleBackColor = true;
            this.RadioButton_125.CheckedChanged += new System.EventHandler(this.RadioButton_125_CheckedChanged);
            // 
            // RadioButton_100
            // 
            this.RadioButton_100.AutoSize = true;
            this.RadioButton_100.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.RadioButton_100.Location = new System.Drawing.Point(6, 29);
            this.RadioButton_100.Name = "RadioButton_100";
            this.RadioButton_100.Size = new System.Drawing.Size(112, 24);
            this.RadioButton_100.TabIndex = 2;
            this.RadioButton_100.TabStop = true;
            this.RadioButton_100.Text = "100% (기본)";
            this.RadioButton_100.UseVisualStyleBackColor = true;
            this.RadioButton_100.CheckedChanged += new System.EventHandler(this.RadioButton_100_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(362, 167);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Button_Exit);
            this.Name = "Form3";
            this.Text = "설정";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioButton_QHD;
        private System.Windows.Forms.RadioButton RadioButton_FHD;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RadioButton_125;
        private System.Windows.Forms.RadioButton RadioButton_100;
    }
}