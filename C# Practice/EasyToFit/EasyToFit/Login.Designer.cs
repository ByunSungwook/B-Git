namespace EasyToFit
{
    partial class Login
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.ID = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.ID_input = new System.Windows.Forms.TextBox();
            this.Pw_input = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Join = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.ID.Location = new System.Drawing.Point(26, 33);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(40, 32);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.Password.Location = new System.Drawing.Point(12, 85);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(54, 32);
            this.Password.TabIndex = 1;
            this.Password.Text = "PW";
            // 
            // ID_input
            // 
            this.ID_input.Location = new System.Drawing.Point(72, 42);
            this.ID_input.Name = "ID_input";
            this.ID_input.Size = new System.Drawing.Size(172, 21);
            this.ID_input.TabIndex = 1;
            // 
            // Pw_input
            // 
            this.Pw_input.Location = new System.Drawing.Point(72, 96);
            this.Pw_input.Name = "Pw_input";
            this.Pw_input.PasswordChar = '*';
            this.Pw_input.Size = new System.Drawing.Size(172, 21);
            this.Pw_input.TabIndex = 2;
            this.Pw_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pw_input_KeyPress);
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(268, 37);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(92, 28);
            this.Enter.TabIndex = 3;
            this.Enter.Text = "Log-in";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(268, 89);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(92, 28);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Cancel";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Join
            // 
            this.Join.AutoSize = true;
            this.Join.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.Join.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Join.Location = new System.Drawing.Point(295, 130);
            this.Join.Name = "Join";
            this.Join.Size = new System.Drawing.Size(65, 19);
            this.Join.TabIndex = 5;
            this.Join.TabStop = true;
            this.Join.Text = "회원가입";
            this.Join.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Join_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 167);
            this.Controls.Add(this.Join);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Pw_input);
            this.Controls.Add(this.ID_input);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ID);
            this.Name = "Login";
            this.Text = "Easy To Fit";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox ID_input;
        private System.Windows.Forms.TextBox Pw_input;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.LinkLabel Join;
    }
}

