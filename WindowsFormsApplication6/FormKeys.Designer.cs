namespace WindowsFormsApplication6
{
    partial class FormKeys
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonKeysInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 168);
            this.textBox1.TabIndex = 0;
            // 
            // buttonKeysInput
            // 
            this.buttonKeysInput.Location = new System.Drawing.Point(152, 218);
            this.buttonKeysInput.Name = "buttonKeysInput";
            this.buttonKeysInput.Size = new System.Drawing.Size(75, 23);
            this.buttonKeysInput.TabIndex = 1;
            this.buttonKeysInput.Text = "Input";
            this.buttonKeysInput.UseVisualStyleBackColor = true;
            this.buttonKeysInput.Click += new System.EventHandler(this.buttonKeysInput_Click);
            // 
            // FormKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 253);
            this.Controls.Add(this.buttonKeysInput);
            this.Controls.Add(this.textBox1);
            this.Name = "FormKeys";
            this.Text = "Keyboard Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonKeysInput;
        private System.Windows.Forms.TextBox textBox1;
    }
}