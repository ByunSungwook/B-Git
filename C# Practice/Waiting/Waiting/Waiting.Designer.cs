namespace Waiting
{
    partial class Waiting
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
            this.Call = new System.Windows.Forms.Button();
            this.Waiting_num = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Call
            // 
            this.Call.Location = new System.Drawing.Point(84, 222);
            this.Call.Name = "Call";
            this.Call.Size = new System.Drawing.Size(115, 28);
            this.Call.TabIndex = 0;
            this.Call.Text = "호출하기";
            this.Call.UseVisualStyleBackColor = true;
            this.Call.Click += new System.EventHandler(this.button1_Click);
            // 
            // Waiting_num
            // 
            this.Waiting_num.AutoSize = true;
            this.Waiting_num.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold);
            this.Waiting_num.Location = new System.Drawing.Point(118, 88);
            this.Waiting_num.Name = "Waiting_num";
            this.Waiting_num.Size = new System.Drawing.Size(46, 54);
            this.Waiting_num.TabIndex = 5;
            this.Waiting_num.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "대기인원수";
            // 
            // Waiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Waiting_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Call);
            this.Name = "Waiting";
            this.Text = "Waiting";
            this.Load += new System.EventHandler(this.Waiting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Call;
        private System.Windows.Forms.Label Waiting_num;
        private System.Windows.Forms.Label label1;
    }
}