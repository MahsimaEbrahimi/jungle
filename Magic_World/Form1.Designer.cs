namespace Magic_World
{
    partial class main_jungle
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
            this.Rabit_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rabit_add
            // 
            this.Rabit_add.Location = new System.Drawing.Point(465, 57);
            this.Rabit_add.Name = "Rabit_add";
            this.Rabit_add.Size = new System.Drawing.Size(149, 53);
            this.Rabit_add.TabIndex = 0;
            this.Rabit_add.Text = "Rabit_add";
            this.Rabit_add.UseVisualStyleBackColor = true;
            // 
            // main_jungle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 458);
            this.Controls.Add(this.Rabit_add);
            this.Name = "main_jungle";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Rabit_add;
    }
}

