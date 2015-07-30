namespace Waiting
{
    partial class Waiting2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Waiting_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Call
            // 
            this.Call.Location = new System.Drawing.Point(78, 222);
            this.Call.Name = "Call";
            this.Call.Size = new System.Drawing.Size(116, 28);
            this.Call.TabIndex = 1;
            this.Call.Text = "호출하기";
            this.Call.UseVisualStyleBackColor = true;
            this.Call.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "대기인원수";
            // 
            // Waiting_num
            // 
            this.Waiting_num.AutoSize = true;
            this.Waiting_num.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold);
            this.Waiting_num.Location = new System.Drawing.Point(114, 88);
            this.Waiting_num.Name = "Waiting_num";
            this.Waiting_num.Size = new System.Drawing.Size(46, 54);
            this.Waiting_num.TabIndex = 3;
            this.Waiting_num.Text = "0";
            // 
            // Waiting2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Waiting_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Call);
            this.Name = "Waiting2";
            this.Text = "Waiting2";
            this.Load += new System.EventHandler(this.Waiting2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Call;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Waiting_num;
    }
}