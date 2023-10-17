namespace DecisionsExample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBoxStudentName = new TextBox();
            txtBoxEnglish = new TextBox();
            txtBoxPython = new TextBox();
            txtBoxNetworking = new TextBox();
            btnCheck = new Button();
            lblAvgResult = new Label();
            lblGradeResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(275, 21);
            label1.Name = "label1";
            label1.Size = new Size(249, 25);
            label1.TabIndex = 0;
            label1.Text = "Student Grade Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 89);
            label2.Name = "label2";
            label2.Size = new Size(166, 25);
            label2.TabIndex = 1;
            label2.Text = "Student Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 155);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 2;
            label3.Text = "English";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(47, 209);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 3;
            label4.Text = "Python";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(47, 265);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 4;
            label5.Text = "Networking";
            // 
            // txtBoxStudentName
            // 
            txtBoxStudentName.Location = new Point(242, 91);
            txtBoxStudentName.Name = "txtBoxStudentName";
            txtBoxStudentName.Size = new Size(268, 23);
            txtBoxStudentName.TabIndex = 5;
            // 
            // txtBoxEnglish
            // 
            txtBoxEnglish.Location = new Point(242, 157);
            txtBoxEnglish.Name = "txtBoxEnglish";
            txtBoxEnglish.Size = new Size(268, 23);
            txtBoxEnglish.TabIndex = 6;
            // 
            // txtBoxPython
            // 
            txtBoxPython.Location = new Point(242, 214);
            txtBoxPython.Name = "txtBoxPython";
            txtBoxPython.Size = new Size(268, 23);
            txtBoxPython.TabIndex = 7;
            // 
            // txtBoxNetworking
            // 
            txtBoxNetworking.Location = new Point(242, 265);
            txtBoxNetworking.Name = "txtBoxNetworking";
            txtBoxNetworking.Size = new Size(268, 23);
            txtBoxNetworking.TabIndex = 8;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(256, 319);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(130, 50);
            btnCheck.TabIndex = 9;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblAvgResult
            // 
            lblAvgResult.AutoSize = true;
            lblAvgResult.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvgResult.Location = new Point(577, 89);
            lblAvgResult.Name = "lblAvgResult";
            lblAvgResult.Size = new Size(126, 25);
            lblAvgResult.TabIndex = 10;
            lblAvgResult.Text = "The aveage is";
            // 
            // lblGradeResult
            // 
            lblGradeResult.AutoSize = true;
            lblGradeResult.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGradeResult.Location = new Point(577, 177);
            lblGradeResult.Name = "lblGradeResult";
            lblGradeResult.Size = new Size(115, 25);
            lblGradeResult.TabIndex = 11;
            lblGradeResult.Text = "The grade is";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 391);
            Controls.Add(lblGradeResult);
            Controls.Add(lblAvgResult);
            Controls.Add(btnCheck);
            Controls.Add(txtBoxNetworking);
            Controls.Add(txtBoxPython);
            Controls.Add(txtBoxEnglish);
            Controls.Add(txtBoxStudentName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBoxStudentName;
        private TextBox txtBoxEnglish;
        private TextBox txtBoxPython;
        private TextBox txtBoxNetworking;
        private Button btnCheck;
        private Label lblAvgResult;
        private Label lblGradeResult;
    }
}