namespace Activity_1
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
            this.Text = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.buttonGreet = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Location = new System.Drawing.Point(354, 76);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(84, 13);
            this.Text.TabIndex = 0;
            this.Text.Text = "Enter your name";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(357, 129);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(100, 20);
            this.textBoxname.TabIndex = 1;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBoxname_TextChanged);
            // 
            // buttonGreet
            // 
            this.buttonGreet.Location = new System.Drawing.Point(386, 172);
            this.buttonGreet.Name = "buttonGreet";
            this.buttonGreet.Size = new System.Drawing.Size(75, 23);
            this.buttonGreet.TabIndex = 2;
            this.buttonGreet.Text = "Greet Me";
            this.buttonGreet.UseVisualStyleBackColor = true;
            this.buttonGreet.Click += new System.EventHandler(this.buttonGreet_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(386, 243);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonGreet);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.Text);
            this.Name = "textBoxname";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Button buttonGreet;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label label1;
    }
}

