namespace Project_2
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
            Div_Button = new Button();
            Mul_Button = new Button();
            Sub_Button = new Button();
            Add_Button = new Button();
            OperandBehind = new TextBox();
            The_Answer = new TextBox();
            OperandFront = new TextBox();
            SuspendLayout();
            // 
            // Div_Button
            // 
            Div_Button.Location = new Point(638, 217);
            Div_Button.Name = "Div_Button";
            Div_Button.Size = new Size(150, 46);
            Div_Button.TabIndex = 0;
            Div_Button.Text = "Div";
            Div_Button.UseVisualStyleBackColor = true;
            Div_Button.Click += Div_Button_Click;
            // 
            // Mul_Button
            // 
            Mul_Button.Location = new Point(442, 217);
            Mul_Button.Name = "Mul_Button";
            Mul_Button.Size = new Size(150, 46);
            Mul_Button.TabIndex = 1;
            Mul_Button.Text = "Mul";
            Mul_Button.UseVisualStyleBackColor = true;
            Mul_Button.Click += Mul_Button_Click;
            // 
            // Sub_Button
            // 
            Sub_Button.Location = new Point(246, 217);
            Sub_Button.Name = "Sub_Button";
            Sub_Button.Size = new Size(150, 46);
            Sub_Button.TabIndex = 2;
            Sub_Button.Text = "Sub";
            Sub_Button.UseVisualStyleBackColor = true;
            Sub_Button.Click += Sub_Button_Click;
            // 
            // Add_Button
            // 
            Add_Button.Location = new Point(47, 217);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(150, 46);
            Add_Button.TabIndex = 3;
            Add_Button.Text = "Add";
            Add_Button.UseVisualStyleBackColor = true;
            Add_Button.Click += Add_Button_Click;
            // 
            // OperandBehind
            // 
            OperandBehind.Location = new Point(442, 88);
            OperandBehind.Name = "OperandBehind";
            OperandBehind.Size = new Size(200, 38);
            OperandBehind.TabIndex = 4;
            // 
            // The_Answer
            // 
            The_Answer.Location = new Point(246, 351);
            The_Answer.Name = "The_Answer";
            The_Answer.Size = new Size(200, 38);
            The_Answer.TabIndex = 5;
            // 
            // OperandFront
            // 
            OperandFront.Location = new Point(47, 88);
            OperandFront.Name = "OperandFront";
            OperandFront.Size = new Size(200, 38);
            OperandFront.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1699, 940);
            Controls.Add(OperandFront);
            Controls.Add(The_Answer);
            Controls.Add(OperandBehind);
            Controls.Add(Add_Button);
            Controls.Add(Sub_Button);
            Controls.Add(Mul_Button);
            Controls.Add(Div_Button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Div_Button;
        private Button Mul_Button;
        private Button Sub_Button;
        private Button Add_Button;
        private TextBox OperandBehind;
        private TextBox The_Answer;
        private TextBox OperandFront;
    }
}