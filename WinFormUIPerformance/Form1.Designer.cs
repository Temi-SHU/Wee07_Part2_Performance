namespace WinFormUIPerformance
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
            btnStart1 = new Button();
            btnStart2 = new Button();
            button1 = new Button();
            txtCount = new TextBox();
            txtType = new TextBox();
            SuspendLayout();
            // 
            // btnStart1
            // 
            btnStart1.Location = new Point(35, 181);
            btnStart1.Margin = new Padding(3, 4, 3, 4);
            btnStart1.Name = "btnStart1";
            btnStart1.Size = new Size(658, 31);
            btnStart1.TabIndex = 1;
            btnStart1.Text = "Start a Long Running Task Synchronously";
            btnStart1.UseVisualStyleBackColor = true;
            btnStart1.Click += btnStart_Click1;
            // 
            // btnStart2
            // 
            btnStart2.Location = new Point(35, 220);
            btnStart2.Margin = new Padding(3, 4, 3, 4);
            btnStart2.Name = "btnStart2";
            btnStart2.Size = new Size(658, 31);
            btnStart2.TabIndex = 2;
            btnStart2.Text = "Start a Long Running Task Asynchronously using Threads";
            btnStart2.UseVisualStyleBackColor = true;
            btnStart2.Click += btnStart_Click2;
            // 
            // button1
            // 
            button1.Location = new Point(35, 259);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(658, 31);
            button1.TabIndex = 3;
            button1.Text = "Start a Long Running Task Asynchronously using Task asynchronous programming model";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnStart_Click3;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(35, 147);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(658, 27);
            txtCount.TabIndex = 4;
            // 
            // txtType
            // 
            txtType.Location = new Point(35, 12);
            txtType.Multiline = true;
            txtType.Name = "txtType";
            txtType.Size = new Size(658, 119);
            txtType.TabIndex = 5;
            txtType.Text = "Type in here";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 323);
            Controls.Add(txtType);
            Controls.Add(txtCount);
            Controls.Add(button1);
            Controls.Add(btnStart2);
            Controls.Add(btnStart1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(740, 370);
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Multi-Threading Example";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnStart1;
        private Button btnStart2;
        private Button button1;
        private TextBox txtCount;
        private TextBox txtType;
    }
}