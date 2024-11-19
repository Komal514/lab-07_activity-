namespace Activity_02
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
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.checkBoxCheese = new System.Windows.Forms.CheckBox();
            this.checkBoxPepperoni = new System.Windows.Forms.CheckBox();
            this.checkBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.radioButtonThinCrust = new System.Windows.Forms.RadioButton();
            this.radioButtonThickCrust = new System.Windows.Forms.RadioButton();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.labelOrdersummary = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "\"Small\"",
            "\"Medium\"",
            "\"Large\""});
            this.comboBoxSize.Location = new System.Drawing.Point(392, 46);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSize.TabIndex = 0;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // checkBoxCheese
            // 
            this.checkBoxCheese.AutoSize = true;
            this.checkBoxCheese.Location = new System.Drawing.Point(207, 129);
            this.checkBoxCheese.Name = "checkBoxCheese";
            this.checkBoxCheese.Size = new System.Drawing.Size(62, 17);
            this.checkBoxCheese.TabIndex = 1;
            this.checkBoxCheese.Text = "Cheese";
            this.checkBoxCheese.UseVisualStyleBackColor = true;
            // 
            // checkBoxPepperoni
            // 
            this.checkBoxPepperoni.AutoSize = true;
            this.checkBoxPepperoni.Location = new System.Drawing.Point(392, 129);
            this.checkBoxPepperoni.Name = "checkBoxPepperoni";
            this.checkBoxPepperoni.Size = new System.Drawing.Size(74, 17);
            this.checkBoxPepperoni.TabIndex = 2;
            this.checkBoxPepperoni.Text = "Pepperoni";
            this.checkBoxPepperoni.UseVisualStyleBackColor = true;
            // 
            // checkBoxMushrooms
            // 
            this.checkBoxMushrooms.AutoSize = true;
            this.checkBoxMushrooms.Location = new System.Drawing.Point(589, 129);
            this.checkBoxMushrooms.Name = "checkBoxMushrooms";
            this.checkBoxMushrooms.Size = new System.Drawing.Size(80, 17);
            this.checkBoxMushrooms.TabIndex = 3;
            this.checkBoxMushrooms.Text = "Mushrooms";
            this.checkBoxMushrooms.UseVisualStyleBackColor = true;
            // 
            // radioButtonThinCrust
            // 
            this.radioButtonThinCrust.AutoSize = true;
            this.radioButtonThinCrust.Location = new System.Drawing.Point(309, 188);
            this.radioButtonThinCrust.Name = "radioButtonThinCrust";
            this.radioButtonThinCrust.Size = new System.Drawing.Size(73, 17);
            this.radioButtonThinCrust.TabIndex = 4;
            this.radioButtonThinCrust.TabStop = true;
            this.radioButtonThinCrust.Text = "Thin Crust";
            this.radioButtonThinCrust.UseVisualStyleBackColor = true;
            // 
            // radioButtonThickCrust
            // 
            this.radioButtonThickCrust.AutoSize = true;
            this.radioButtonThickCrust.Location = new System.Drawing.Point(539, 188);
            this.radioButtonThickCrust.Name = "radioButtonThickCrust";
            this.radioButtonThickCrust.Size = new System.Drawing.Size(79, 17);
            this.radioButtonThickCrust.TabIndex = 5;
            this.radioButtonThickCrust.TabStop = true;
            this.radioButtonThickCrust.Text = "Thick Crust";
            this.radioButtonThickCrust.UseVisualStyleBackColor = true;
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.Location = new System.Drawing.Point(438, 228);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonPlaceOrder.TabIndex = 6;
            this.buttonPlaceOrder.Text = "Place Order";
            this.buttonPlaceOrder.UseVisualStyleBackColor = true;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // labelOrdersummary
            // 
            this.labelOrdersummary.AutoSize = true;
            this.labelOrdersummary.Location = new System.Drawing.Point(459, 269);
            this.labelOrdersummary.Name = "labelOrdersummary";
            this.labelOrdersummary.Size = new System.Drawing.Size(0, 13);
            this.labelOrdersummary.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOrdersummary);
            this.Controls.Add(this.buttonPlaceOrder);
            this.Controls.Add(this.radioButtonThickCrust);
            this.Controls.Add(this.radioButtonThinCrust);
            this.Controls.Add(this.checkBoxMushrooms);
            this.Controls.Add(this.checkBoxPepperoni);
            this.Controls.Add(this.checkBoxCheese);
            this.Controls.Add(this.comboBoxSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.CheckBox checkBoxCheese;
        private System.Windows.Forms.CheckBox checkBoxPepperoni;
        private System.Windows.Forms.CheckBox checkBoxMushrooms;
        private System.Windows.Forms.RadioButton radioButtonThinCrust;
        private System.Windows.Forms.RadioButton radioButtonThickCrust;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.Label labelOrdersummary;
        private System.Windows.Forms.Label label1;
    }
}

