namespace EasyToFit
{
    partial class Title
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ETF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tall = new System.Windows.Forms.TextBox();
            this.rectrain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Calc = new System.Windows.Forms.Button();
            this.bmi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(559, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(437, 714);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(429, 688);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "운동방법";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(429, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "추천식단";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ETF
            // 
            this.ETF.AutoSize = true;
            this.ETF.Font = new System.Drawing.Font("한컴 쿨재즈 L", 40F);
            this.ETF.Location = new System.Drawing.Point(2, 2);
            this.ETF.Name = "ETF";
            this.ETF.Size = new System.Drawing.Size(244, 55);
            this.ETF.TabIndex = 1;
            this.ETF.Text = "Easy To Fit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "키(cm)";
            // 
            // Tall
            // 
            this.Tall.Location = new System.Drawing.Point(94, 80);
            this.Tall.Name = "Tall";
            this.Tall.Size = new System.Drawing.Size(115, 21);
            this.Tall.TabIndex = 3;
            // 
            // rectrain
            // 
            this.rectrain.Location = new System.Drawing.Point(186, 238);
            this.rectrain.Name = "rectrain";
            this.rectrain.Size = new System.Drawing.Size(115, 21);
            this.rectrain.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(9, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "일일권장운동량";
            // 
            // Calc
            // 
            this.Calc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Calc.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.Calc.Location = new System.Drawing.Point(186, 127);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(135, 36);
            this.Calc.TabIndex = 6;
            this.Calc.Text = "계산!";
            this.Calc.UseVisualStyleBackColor = false;
            this.Calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // bmi
            // 
            this.bmi.Location = new System.Drawing.Point(186, 208);
            this.bmi.Name = "bmi";
            this.bmi.Size = new System.Drawing.Size(115, 21);
            this.bmi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(40, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "BMI 지수";
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(383, 80);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(115, 21);
            this.Weight.TabIndex = 10;
            this.Weight.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(265, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "몸무게(kg)";
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bmi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.rectrain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ETF);
            this.Controls.Add(this.tabControl1);
            this.Name = "Title";
            this.Text = "EasyToFit";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label ETF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tall;
        private System.Windows.Forms.TextBox rectrain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.TextBox bmi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.Label label5;
    }
}

