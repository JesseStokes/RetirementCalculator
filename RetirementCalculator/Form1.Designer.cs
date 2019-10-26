namespace RetirementCalculator
{
    partial class Form1
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
            this.lbYearsInvested = new System.Windows.Forms.Label();
            this.tbYearsInvested = new System.Windows.Forms.TextBox();
            this.lbAmountInvested = new System.Windows.Forms.Label();
            this.tbAmountInvested = new System.Windows.Forms.TextBox();
            this.lbRiskQuestionHeading = new System.Windows.Forms.Label();
            this.lbRiskQ1 = new System.Windows.Forms.Label();
            this.lbRiskQ2 = new System.Windows.Forms.Label();
            this.lbRiskQ3 = new System.Windows.Forms.Label();
            this.lbRiskQ4 = new System.Windows.Forms.Label();
            this.lbRiskQ5 = new System.Windows.Forms.Label();
            this.tbRiskQ1 = new System.Windows.Forms.TextBox();
            this.tbRiskQ2 = new System.Windows.Forms.TextBox();
            this.tbRiskQ3 = new System.Windows.Forms.TextBox();
            this.tbRiskQ4 = new System.Windows.Forms.TextBox();
            this.tbRiskQ5 = new System.Windows.Forms.TextBox();
            this.btCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbYearsInvested
            // 
            this.lbYearsInvested.AutoSize = true;
            this.lbYearsInvested.Location = new System.Drawing.Point(43, 35);
            this.lbYearsInvested.Name = "lbYearsInvested";
            this.lbYearsInvested.Size = new System.Drawing.Size(203, 32);
            this.lbYearsInvested.TabIndex = 0;
            this.lbYearsInvested.Text = "Years Invested";
            // 
            // tbYearsInvested
            // 
            this.tbYearsInvested.Location = new System.Drawing.Point(284, 35);
            this.tbYearsInvested.Name = "tbYearsInvested";
            this.tbYearsInvested.Size = new System.Drawing.Size(234, 38);
            this.tbYearsInvested.TabIndex = 1;
            // 
            // lbAmountInvested
            // 
            this.lbAmountInvested.AutoSize = true;
            this.lbAmountInvested.Location = new System.Drawing.Point(43, 81);
            this.lbAmountInvested.Name = "lbAmountInvested";
            this.lbAmountInvested.Size = new System.Drawing.Size(227, 32);
            this.lbAmountInvested.TabIndex = 2;
            this.lbAmountInvested.Text = "Amount Invested";
            // 
            // tbAmountInvested
            // 
            this.tbAmountInvested.Location = new System.Drawing.Point(284, 81);
            this.tbAmountInvested.Name = "tbAmountInvested";
            this.tbAmountInvested.Size = new System.Drawing.Size(234, 38);
            this.tbAmountInvested.TabIndex = 3;
            // 
            // lbRiskQuestionHeading
            // 
            this.lbRiskQuestionHeading.AutoSize = true;
            this.lbRiskQuestionHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRiskQuestionHeading.Location = new System.Drawing.Point(42, 170);
            this.lbRiskQuestionHeading.Name = "lbRiskQuestionHeading";
            this.lbRiskQuestionHeading.Size = new System.Drawing.Size(1182, 39);
            this.lbRiskQuestionHeading.TabIndex = 4;
            this.lbRiskQuestionHeading.Text = "Please answer the likelyhood of the following questions on a scale of 1-5";
            // 
            // lbRiskQ1
            // 
            this.lbRiskQ1.AutoSize = true;
            this.lbRiskQ1.Location = new System.Drawing.Point(49, 240);
            this.lbRiskQ1.Name = "lbRiskQ1";
            this.lbRiskQ1.Size = new System.Drawing.Size(984, 32);
            this.lbRiskQ1.TabIndex = 5;
            this.lbRiskQ1.Text = "I would stay fully invested after a market after a 30% reduction in my portfolio." +
    "";
            // 
            // lbRiskQ2
            // 
            this.lbRiskQ2.AutoSize = true;
            this.lbRiskQ2.Location = new System.Drawing.Point(49, 293);
            this.lbRiskQ2.Name = "lbRiskQ2";
            this.lbRiskQ2.Size = new System.Drawing.Size(634, 32);
            this.lbRiskQ2.TabIndex = 6;
            this.lbRiskQ2.Text = "I want the most growth possible from my portfolio.";
            // 
            // lbRiskQ3
            // 
            this.lbRiskQ3.AutoSize = true;
            this.lbRiskQ3.Location = new System.Drawing.Point(49, 346);
            this.lbRiskQ3.Name = "lbRiskQ3";
            this.lbRiskQ3.Size = new System.Drawing.Size(588, 32);
            this.lbRiskQ3.TabIndex = 7;
            this.lbRiskQ3.Text = "I am not concerned about market fluctuations.";
            // 
            // lbRiskQ4
            // 
            this.lbRiskQ4.AutoSize = true;
            this.lbRiskQ4.Location = new System.Drawing.Point(49, 399);
            this.lbRiskQ4.Name = "lbRiskQ4";
            this.lbRiskQ4.Size = new System.Drawing.Size(848, 32);
            this.lbRiskQ4.TabIndex = 8;
            this.lbRiskQ4.Text = "I am ok with short term losses if there is long term growth potential.";
            // 
            // lbRiskQ5
            // 
            this.lbRiskQ5.AutoSize = true;
            this.lbRiskQ5.Location = new System.Drawing.Point(49, 452);
            this.lbRiskQ5.Name = "lbRiskQ5";
            this.lbRiskQ5.Size = new System.Drawing.Size(493, 32);
            this.lbRiskQ5.TabIndex = 9;
            this.lbRiskQ5.Text = "I have a long term investment horizon.";
            // 
            // tbRiskQ1
            // 
            this.tbRiskQ1.Location = new System.Drawing.Point(1068, 234);
            this.tbRiskQ1.Name = "tbRiskQ1";
            this.tbRiskQ1.Size = new System.Drawing.Size(100, 38);
            this.tbRiskQ1.TabIndex = 10;
            // 
            // tbRiskQ2
            // 
            this.tbRiskQ2.Location = new System.Drawing.Point(1068, 287);
            this.tbRiskQ2.Name = "tbRiskQ2";
            this.tbRiskQ2.Size = new System.Drawing.Size(100, 38);
            this.tbRiskQ2.TabIndex = 11;
            // 
            // tbRiskQ3
            // 
            this.tbRiskQ3.Location = new System.Drawing.Point(1068, 340);
            this.tbRiskQ3.Name = "tbRiskQ3";
            this.tbRiskQ3.Size = new System.Drawing.Size(100, 38);
            this.tbRiskQ3.TabIndex = 12;
            // 
            // tbRiskQ4
            // 
            this.tbRiskQ4.Location = new System.Drawing.Point(1068, 393);
            this.tbRiskQ4.Name = "tbRiskQ4";
            this.tbRiskQ4.Size = new System.Drawing.Size(100, 38);
            this.tbRiskQ4.TabIndex = 13;
            // 
            // tbRiskQ5
            // 
            this.tbRiskQ5.Location = new System.Drawing.Point(1068, 446);
            this.tbRiskQ5.Name = "tbRiskQ5";
            this.tbRiskQ5.Size = new System.Drawing.Size(100, 38);
            this.tbRiskQ5.TabIndex = 14;
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(55, 527);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(225, 45);
            this.btCalculate.TabIndex = 15;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Years Invested";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(984, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "I would stay fully invested after a market after a 30% reduction in my portfolio." +
    "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(634, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "I want the most growth possible from my portfolio.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(588, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "I am not concerned about market fluctuations.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(848, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "I am ok with short term losses if there is long term growth potential.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(493, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "I have a long term investment horizon.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(332, 527);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(231, 45);
            this.btReset.TabIndex = 16;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(55, 601);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 32);
            this.lbResult.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1877, 970);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.tbRiskQ5);
            this.Controls.Add(this.tbRiskQ4);
            this.Controls.Add(this.tbRiskQ3);
            this.Controls.Add(this.tbRiskQ2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbRiskQ1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbRiskQ5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbRiskQ4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRiskQ3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRiskQ2);
            this.Controls.Add(this.lbRiskQ1);
            this.Controls.Add(this.lbRiskQuestionHeading);
            this.Controls.Add(this.tbAmountInvested);
            this.Controls.Add(this.lbAmountInvested);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbYearsInvested);
            this.Controls.Add(this.lbYearsInvested);
            this.Name = "Form1";
            this.Text = "Investment Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbYearsInvested;
        private System.Windows.Forms.TextBox tbYearsInvested;
        private System.Windows.Forms.Label lbAmountInvested;
        private System.Windows.Forms.TextBox tbAmountInvested;
        private System.Windows.Forms.Label lbRiskQuestionHeading;
        private System.Windows.Forms.Label lbRiskQ1;
        private System.Windows.Forms.Label lbRiskQ2;
        private System.Windows.Forms.Label lbRiskQ3;
        private System.Windows.Forms.Label lbRiskQ4;
        private System.Windows.Forms.Label lbRiskQ5;
        private System.Windows.Forms.TextBox tbRiskQ1;
        private System.Windows.Forms.TextBox tbRiskQ2;
        private System.Windows.Forms.TextBox tbRiskQ3;
        private System.Windows.Forms.TextBox tbRiskQ4;
        private System.Windows.Forms.TextBox tbRiskQ5;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label lbResult;
    }
}

