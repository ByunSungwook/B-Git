namespace form2
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.p1000 = new System.Windows.Forms.Button();
            this.p100 = new System.Windows.Forms.Button();
            this.returnch = new System.Windows.Forms.Button();
            this.sprite = new System.Windows.Forms.Button();
            this.p500 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pocari = new System.Windows.Forms.Button();
            this.tropi = new System.Windows.Forms.Button();
            this.coca = new System.Windows.Forms.Button();
            this.letsbe = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.RichTextBox();
            this.money = new System.Windows.Forms.Label();
            this.charge = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // p1000
            // 
            this.p1000.Location = new System.Drawing.Point(249, 360);
            this.p1000.Name = "p1000";
            this.p1000.Size = new System.Drawing.Size(100, 30);
            this.p1000.TabIndex = 7;
            this.p1000.Text = "1000";
            this.p1000.UseVisualStyleBackColor = true;
            this.p1000.Click += new System.EventHandler(this.p1000_Click);
            // 
            // p100
            // 
            this.p100.Location = new System.Drawing.Point(37, 360);
            this.p100.Name = "p100";
            this.p100.Size = new System.Drawing.Size(100, 30);
            this.p100.TabIndex = 5;
            this.p100.Text = "100";
            this.p100.UseVisualStyleBackColor = true;
            this.p100.Click += new System.EventHandler(this.p100_Click);
            // 
            // returnch
            // 
            this.returnch.Location = new System.Drawing.Point(461, 455);
            this.returnch.Name = "returnch";
            this.returnch.Size = new System.Drawing.Size(100, 30);
            this.returnch.TabIndex = 10;
            this.returnch.Text = "반환하기";
            this.returnch.UseVisualStyleBackColor = true;
            this.returnch.Click += new System.EventHandler(this.button3_Click);
            // 
            // sprite
            // 
            this.sprite.Enabled = false;
            this.sprite.Location = new System.Drawing.Point(37, 250);
            this.sprite.Name = "sprite";
            this.sprite.Size = new System.Drawing.Size(100, 30);
            this.sprite.TabIndex = 0;
            this.sprite.Text = "스프라이트";
            this.sprite.UseVisualStyleBackColor = true;
            this.sprite.Click += new System.EventHandler(this.sprite_Click);
            // 
            // p500
            // 
            this.p500.Location = new System.Drawing.Point(143, 360);
            this.p500.Name = "p500";
            this.p500.Size = new System.Drawing.Size(100, 30);
            this.p500.TabIndex = 6;
            this.p500.Text = "500";
            this.p500.UseVisualStyleBackColor = true;
            this.p500.Click += new System.EventHandler(this.p500_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label1.Location = new System.Drawing.Point(397, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "잔액 : ";
            // 
            // pocari
            // 
            this.pocari.Enabled = false;
            this.pocari.Location = new System.Drawing.Point(143, 250);
            this.pocari.Name = "pocari";
            this.pocari.Size = new System.Drawing.Size(100, 30);
            this.pocari.TabIndex = 1;
            this.pocari.Text = "포카리스웨트";
            this.pocari.UseVisualStyleBackColor = true;
            this.pocari.Click += new System.EventHandler(this.pocari_Click);
            // 
            // tropi
            // 
            this.tropi.Enabled = false;
            this.tropi.Location = new System.Drawing.Point(355, 250);
            this.tropi.Name = "tropi";
            this.tropi.Size = new System.Drawing.Size(100, 30);
            this.tropi.TabIndex = 3;
            this.tropi.Text = "트로피카나";
            this.tropi.UseVisualStyleBackColor = true;
            this.tropi.Click += new System.EventHandler(this.tropi_Click);
            // 
            // coca
            // 
            this.coca.Enabled = false;
            this.coca.Location = new System.Drawing.Point(249, 250);
            this.coca.Name = "coca";
            this.coca.Size = new System.Drawing.Size(100, 30);
            this.coca.TabIndex = 2;
            this.coca.Text = "코카콜라";
            this.coca.UseVisualStyleBackColor = true;
            this.coca.Click += new System.EventHandler(this.coca_Click);
            // 
            // letsbe
            // 
            this.letsbe.Enabled = false;
            this.letsbe.Location = new System.Drawing.Point(461, 250);
            this.letsbe.Name = "letsbe";
            this.letsbe.Size = new System.Drawing.Size(100, 30);
            this.letsbe.TabIndex = 4;
            this.letsbe.Text = "레쓰비";
            this.letsbe.UseVisualStyleBackColor = true;
            this.letsbe.Click += new System.EventHandler(this.letsbe_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(41, 411);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(308, 129);
            this.status.TabIndex = 8;
            this.status.Text = "";
            this.status.TextChanged += new System.EventHandler(this.status_TextChanged);
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.money.Location = new System.Drawing.Point(37, 336);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(58, 21);
            this.money.TabIndex = 11;
            this.money.Text = "돈넣기";
            // 
            // charge
            // 
            this.charge.AutoSize = true;
            this.charge.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.charge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.charge.Location = new System.Drawing.Point(457, 415);
            this.charge.Name = "charge";
            this.charge.Size = new System.Drawing.Size(19, 21);
            this.charge.TabIndex = 12;
            this.charge.Text = "0";
            this.charge.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(143, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 178);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(249, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 178);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(355, 54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(95, 178);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(461, 54);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(95, 178);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(461, 491);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 30);
            this.exit.TabIndex = 18;
            this.exit.Text = "나가기";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 552);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.charge);
            this.Controls.Add(this.money);
            this.Controls.Add(this.status);
            this.Controls.Add(this.letsbe);
            this.Controls.Add(this.coca);
            this.Controls.Add(this.tropi);
            this.Controls.Add(this.pocari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p500);
            this.Controls.Add(this.sprite);
            this.Controls.Add(this.returnch);
            this.Controls.Add(this.p100);
            this.Controls.Add(this.p1000);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button p1000;
        private System.Windows.Forms.Button p100;
        private System.Windows.Forms.Button returnch;
        private System.Windows.Forms.Button sprite;
        private System.Windows.Forms.Button p500;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pocari;
        private System.Windows.Forms.Button tropi;
        private System.Windows.Forms.Button coca;
        private System.Windows.Forms.Button letsbe;
        private System.Windows.Forms.RichTextBox status;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label charge;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button exit;
    }
}

