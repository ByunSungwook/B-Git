namespace Easy_To_Fit
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tall = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Bmi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Stdweight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tab = new System.Windows.Forms.TabControl();
            this.TrainM = new System.Windows.Forms.TabPage();
            this.Food = new System.Windows.Forms.TabPage();
            this.Trainplan = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Reset = new System.Windows.Forms.Button();
            this.Tab.SuspendLayout();
            this.Trainplan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("양재꽃게체M", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Easy To Fit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("양재꽃게체M", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(5, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "키(cm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("양재꽃게체M", 20F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(224, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "몸무게(kg)";
            // 
            // Tall
            // 
            this.Tall.Location = new System.Drawing.Point(100, 94);
            this.Tall.MaxLength = 3;
            this.Tall.Name = "Tall";
            this.Tall.Size = new System.Drawing.Size(80, 21);
            this.Tall.TabIndex = 1;
            this.Tall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tall_KeyPress);
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(369, 94);
            this.Weight.MaxLength = 3;
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(80, 21);
            this.Weight.TabIndex = 2;
            this.Weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Weight_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("양재꽃게체M", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(180, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "계산";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Calculate);
            // 
            // Bmi
            // 
            this.Bmi.Location = new System.Drawing.Point(180, 183);
            this.Bmi.Name = "Bmi";
            this.Bmi.ReadOnly = true;
            this.Bmi.Size = new System.Drawing.Size(123, 21);
            this.Bmi.TabIndex = 4;
            this.Bmi.TextChanged += new System.EventHandler(this.Bmi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("양재꽃게체M", 20F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bmi지수";
            // 
            // Stdweight
            // 
            this.Stdweight.Location = new System.Drawing.Point(180, 232);
            this.Stdweight.Name = "Stdweight";
            this.Stdweight.ReadOnly = true;
            this.Stdweight.Size = new System.Drawing.Size(123, 21);
            this.Stdweight.TabIndex = 5;
            this.Stdweight.TextChanged += new System.EventHandler(this.DailyT_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("양재꽃게체M", 20F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(5, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "표준체중(KG)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.TrainM);
            this.Tab.Controls.Add(this.Food);
            this.Tab.Controls.Add(this.Trainplan);
            this.Tab.Font = new System.Drawing.Font("양재꽃게체M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Tab.Location = new System.Drawing.Point(496, 7);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(500, 711);
            this.Tab.TabIndex = 6;
            // 
            // TrainM
            // 
            this.TrainM.Location = new System.Drawing.Point(4, 22);
            this.TrainM.Name = "TrainM";
            this.TrainM.Padding = new System.Windows.Forms.Padding(3);
            this.TrainM.Size = new System.Drawing.Size(492, 685);
            this.TrainM.TabIndex = 0;
            this.TrainM.Text = "추천운동";
            this.TrainM.UseVisualStyleBackColor = true;
            // 
            // Food
            // 
            this.Food.Location = new System.Drawing.Point(4, 22);
            this.Food.Name = "Food";
            this.Food.Padding = new System.Windows.Forms.Padding(3);
            this.Food.Size = new System.Drawing.Size(492, 685);
            this.Food.TabIndex = 1;
            this.Food.Text = "추천식단";
            this.Food.UseVisualStyleBackColor = true;
            // 
            // Trainplan
            // 
            this.Trainplan.Controls.Add(this.monthCalendar1);
            this.Trainplan.Location = new System.Drawing.Point(4, 22);
            this.Trainplan.Name = "Trainplan";
            this.Trainplan.Padding = new System.Windows.Forms.Padding(3);
            this.Trainplan.Size = new System.Drawing.Size(492, 685);
            this.Trainplan.TabIndex = 2;
            this.Trainplan.Text = "운동플래너";
            this.Trainplan.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.Window;
            this.Reset.Font = new System.Drawing.Font("양재꽃게체M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Reset.Location = new System.Drawing.Point(369, 232);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(80, 27);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.Stdweight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Bmi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Tall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Easy To Fit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tab.ResumeLayout(false);
            this.Trainplan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tall;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Bmi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Stdweight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage TrainM;
        private System.Windows.Forms.TabPage Food;
        private System.Windows.Forms.TabPage Trainplan;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

