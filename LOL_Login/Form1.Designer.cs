namespace LOL_Login
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
            this.Button_ID = new System.Windows.Forms.Button();
            this.Button_Help = new System.Windows.Forms.Button();
            this.Button_Login = new System.Windows.Forms.Button();
            this.Button_TurnOn = new System.Windows.Forms.Button();
            this.RichTextBox_Status = new System.Windows.Forms.RichTextBox();
            this.ComboBox_Select_ID = new System.Windows.Forms.ComboBox();
            this.Button_Settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_ID
            // 
            this.Button_ID.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Button_ID.Location = new System.Drawing.Point(12, 52);
            this.Button_ID.Name = "Button_ID";
            this.Button_ID.Size = new System.Drawing.Size(162, 48);
            this.Button_ID.TabIndex = 2;
            this.Button_ID.Text = "아이디 입력";
            this.Button_ID.UseVisualStyleBackColor = true;
            this.Button_ID.Click += new System.EventHandler(this.Button_ID_Click);
            // 
            // Button_Help
            // 
            this.Button_Help.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Button_Help.Location = new System.Drawing.Point(12, 12);
            this.Button_Help.Name = "Button_Help";
            this.Button_Help.Size = new System.Drawing.Size(75, 34);
            this.Button_Help.TabIndex = 0;
            this.Button_Help.Text = "도움말";
            this.Button_Help.UseVisualStyleBackColor = true;
            this.Button_Help.Click += new System.EventHandler(this.Button_Help_Click);
            // 
            // Button_Login
            // 
            this.Button_Login.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Button_Login.Location = new System.Drawing.Point(12, 135);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(162, 48);
            this.Button_Login.TabIndex = 4;
            this.Button_Login.Text = "로그인";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Button_TurnOn
            // 
            this.Button_TurnOn.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Button_TurnOn.Location = new System.Drawing.Point(12, 189);
            this.Button_TurnOn.Name = "Button_TurnOn";
            this.Button_TurnOn.Size = new System.Drawing.Size(162, 48);
            this.Button_TurnOn.TabIndex = 5;
            this.Button_TurnOn.Text = "롤 켜기";
            this.Button_TurnOn.UseVisualStyleBackColor = true;
            this.Button_TurnOn.Click += new System.EventHandler(this.Button_TurnOn_Click);
            // 
            // RichTextBox_Status
            // 
            this.RichTextBox_Status.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.RichTextBox_Status.Location = new System.Drawing.Point(189, 12);
            this.RichTextBox_Status.Name = "RichTextBox_Status";
            this.RichTextBox_Status.ReadOnly = true;
            this.RichTextBox_Status.Size = new System.Drawing.Size(210, 225);
            this.RichTextBox_Status.TabIndex = 18;
            this.RichTextBox_Status.TabStop = false;
            this.RichTextBox_Status.Text = "";
            // 
            // ComboBox_Select_ID
            // 
            this.ComboBox_Select_ID.FormattingEnabled = true;
            this.ComboBox_Select_ID.Location = new System.Drawing.Point(12, 106);
            this.ComboBox_Select_ID.Name = "ComboBox_Select_ID";
            this.ComboBox_Select_ID.Size = new System.Drawing.Size(162, 23);
            this.ComboBox_Select_ID.TabIndex = 3;
            // 
            // Button_Settings
            // 
            this.Button_Settings.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Button_Settings.Location = new System.Drawing.Point(99, 12);
            this.Button_Settings.Name = "Button_Settings";
            this.Button_Settings.Size = new System.Drawing.Size(75, 34);
            this.Button_Settings.TabIndex = 1;
            this.Button_Settings.Text = "설정";
            this.Button_Settings.UseVisualStyleBackColor = true;
            this.Button_Settings.Click += new System.EventHandler(this.Button_Settings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(411, 249);
            this.Controls.Add(this.Button_Settings);
            this.Controls.Add(this.ComboBox_Select_ID);
            this.Controls.Add(this.RichTextBox_Status);
            this.Controls.Add(this.Button_TurnOn);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.Button_Help);
            this.Controls.Add(this.Button_ID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "롤 자동 로그인";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Button_ID;
        private System.Windows.Forms.Button Button_Help;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Button Button_TurnOn;
        public System.Windows.Forms.RichTextBox RichTextBox_Status;
        public System.Windows.Forms.ComboBox ComboBox_Select_ID;
        private System.Windows.Forms.Button Button_Settings;
    }
}

