namespace StructureOfWinFormsProj
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
            this.txtDummy = new System.Windows.Forms.TextBox();
            this.btnNoneModal = new System.Windows.Forms.Button();
            this.btnModal = new System.Windows.Forms.Button();
            this.btnModalWithUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDummy
            // 
            this.txtDummy.Location = new System.Drawing.Point(316, 176);
            this.txtDummy.Name = "txtDummy";
            this.txtDummy.Size = new System.Drawing.Size(100, 23);
            this.txtDummy.TabIndex = 0;
            this.txtDummy.Text = "Hello World!";
            // 
            // btnNoneModal
            // 
            this.btnNoneModal.Location = new System.Drawing.Point(289, 205);
            this.btnNoneModal.Name = "btnNoneModal";
            this.btnNoneModal.Size = new System.Drawing.Size(152, 23);
            this.btnNoneModal.TabIndex = 1;
            this.btnNoneModal.Text = "Open None Modal Form";
            this.btnNoneModal.UseVisualStyleBackColor = true;
            this.btnNoneModal.Click += new System.EventHandler(this.btnNoneModal_Click);
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(289, 234);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(152, 23);
            this.btnModal.TabIndex = 2;
            this.btnModal.Text = "Open Modal Form";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // btnModalWithUpdate
            // 
            this.btnModalWithUpdate.Location = new System.Drawing.Point(289, 263);
            this.btnModalWithUpdate.Name = "btnModalWithUpdate";
            this.btnModalWithUpdate.Size = new System.Drawing.Size(152, 44);
            this.btnModalWithUpdate.TabIndex = 3;
            this.btnModalWithUpdate.Text = "Open Modal Form With Textbox Update";
            this.btnModalWithUpdate.UseVisualStyleBackColor = true;
            this.btnModalWithUpdate.Click += new System.EventHandler(this.btnModalWithUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModalWithUpdate);
            this.Controls.Add(this.btnModal);
            this.Controls.Add(this.btnNoneModal);
            this.Controls.Add(this.txtDummy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDummy;
        private Button btnNoneModal;
        private Button btnModal;
        private Button btnModalWithUpdate;
    }
}