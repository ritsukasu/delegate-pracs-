namespace Delegate_String
{
    partial class FormMessage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.TextBox txtBoxMsg;
        private System.Windows.Forms.Button button1;

        private void InitializeComponent()
        {
            this.txtBoxMsg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // txtBoxMsg
            //
            this.txtBoxMsg.Location = new System.Drawing.Point(50, 50);
            this.txtBoxMsg.Name = "txtBoxMsg";
            this.txtBoxMsg.Size = new System.Drawing.Size(200, 23);
            this.txtBoxMsg.TabIndex = 0;
            //
            // button1
            //
            this.button1.Location = new System.Drawing.Point(50, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // FormMessage
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxMsg);
            this.Controls.Add(this.button1);
            this.Name = "FormMessage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}