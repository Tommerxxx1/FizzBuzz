namespace YourFirstWindowsFormsApp
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
            this.btn_hello = new System.Windows.Forms.Button();
            this.lbl_helloeMessage = new System.Windows.Forms.Label();
            this.btn_changeColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_hello
            // 
            this.btn_hello.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_hello.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_hello.Location = new System.Drawing.Point(521, 72);
            this.btn_hello.Name = "btn_hello";
            this.btn_hello.Size = new System.Drawing.Size(272, 86);
            this.btn_hello.TabIndex = 0;
            this.btn_hello.Text = "Hello Click ME";
            this.btn_hello.UseVisualStyleBackColor = false;
            this.btn_hello.Click += new System.EventHandler(this.btn_hello_Click);
            // 
            // lbl_helloeMessage
            // 
            this.lbl_helloeMessage.AutoSize = true;
            this.lbl_helloeMessage.Location = new System.Drawing.Point(602, 195);
            this.lbl_helloeMessage.Name = "lbl_helloeMessage";
            this.lbl_helloeMessage.Size = new System.Drawing.Size(0, 25);
            this.lbl_helloeMessage.TabIndex = 1;
            // 
            // btn_changeColor
            // 
            this.btn_changeColor.Location = new System.Drawing.Point(928, 81);
            this.btn_changeColor.Name = "btn_changeColor";
            this.btn_changeColor.Size = new System.Drawing.Size(254, 92);
            this.btn_changeColor.TabIndex = 2;
            this.btn_changeColor.Text = "ChangeColor";
            this.btn_changeColor.UseVisualStyleBackColor = true;
            this.btn_changeColor.Click += new System.EventHandler(this.btn_changeColor_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1394, 455);
            this.Controls.Add(this.btn_changeColor);
            this.Controls.Add(this.lbl_helloeMessage);
            this.Controls.Add(this.btn_hello);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_hello;
        private Label lbl_helloeMessage;
        private Button btn_changeColor;
    }
}