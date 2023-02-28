namespace AnotherFirstWinFormsApp
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
            this.btn_Click1 = new System.Windows.Forms.Button();
            this.HelloTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Click1
            // 
            this.btn_Click1.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Click1.Location = new System.Drawing.Point(133, 117);
            this.btn_Click1.Name = "btn_Click1";
            this.btn_Click1.Size = new System.Drawing.Size(400, 106);
            this.btn_Click1.TabIndex = 0;
            this.btn_Click1.Text = "Say Hello";
            this.btn_Click1.UseVisualStyleBackColor = true;
            this.btn_Click1.Click += new System.EventHandler(this.HelloTextBox_Click);
            // 
            // HelloTextBox
            // 
            this.HelloTextBox.Location = new System.Drawing.Point(163, 43);
            this.HelloTextBox.Name = "HelloTextBox";
            this.HelloTextBox.Size = new System.Drawing.Size(171, 31);
            this.HelloTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HelloTextBox);
            this.Controls.Add(this.btn_Click1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Click1;
        private TextBox HelloTextBox;
    }
}