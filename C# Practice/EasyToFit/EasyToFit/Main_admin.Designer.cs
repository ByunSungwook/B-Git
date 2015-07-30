namespace EasyToFit
{
    partial class Main_admin
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
            this.Logout = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Picture_preview = new System.Windows.Forms.PictureBox();
            this.Upload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(657, 12);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(77, 25);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(12, 530);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(83, 23);
            this.Search_Button.TabIndex = 1;
            this.Search_Button.Text = "Search...";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Picture_preview
            // 
            this.Picture_preview.BackColor = System.Drawing.Color.Transparent;
            this.Picture_preview.Location = new System.Drawing.Point(12, 12);
            this.Picture_preview.Name = "Picture_preview";
            this.Picture_preview.Size = new System.Drawing.Size(400, 500);
            this.Picture_preview.TabIndex = 2;
            this.Picture_preview.TabStop = false;
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(337, 530);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(75, 23);
            this.Upload.TabIndex = 3;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // Main_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 565);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Picture_preview);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Logout);
            this.Name = "Main_admin";
            this.Text = "Main_admin";
            this.Load += new System.EventHandler(this.Main_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.PictureBox Picture_preview;
        private System.Windows.Forms.Button Upload;
    }
}