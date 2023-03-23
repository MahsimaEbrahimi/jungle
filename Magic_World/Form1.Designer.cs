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
            this.txtAnimal_Age = new System.Windows.Forms.TextBox();
            this.txtAnimal_Amount_Hunger = new System.Windows.Forms.TextBox();
            this.txtAnimal_Number_Child = new System.Windows.Forms.TextBox();
            this.lblAnimal_Age = new System.Windows.Forms.Label();
            this.lblAnimal_Amount_Hunger = new System.Windows.Forms.Label();
            this.lblAnimal_Number_Child = new System.Windows.Forms.Label();
            this.lblAnimal_Hunger = new System.Windows.Forms.Label();
            this.combo_Animal_type = new System.Windows.Forms.ComboBox();
            this.lbl_Animal_type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_animal_state = new System.Windows.Forms.CheckBox();
            this.txtanimal_name = new System.Windows.Forms.TextBox();
            this.lblanimal_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rabit_add
            // 
            this.Rabit_add.Location = new System.Drawing.Point(472, 236);
            this.Rabit_add.Name = "Rabit_add";
            this.Rabit_add.Size = new System.Drawing.Size(149, 53);
            this.Rabit_add.TabIndex = 0;
            this.Rabit_add.Text = "add rabit";
            this.Rabit_add.UseVisualStyleBackColor = true;
            this.Rabit_add.Click += new System.EventHandler(this.Rabit_add_Click);
            // 
            // txtAnimal_Age
            // 
            this.txtAnimal_Age.Location = new System.Drawing.Point(472, 92);
            this.txtAnimal_Age.Multiline = true;
            this.txtAnimal_Age.Name = "txtAnimal_Age";
            this.txtAnimal_Age.Size = new System.Drawing.Size(161, 21);
            this.txtAnimal_Age.TabIndex = 1;
            this.txtAnimal_Age.TextChanged += new System.EventHandler(this.txtAnimal_Age_TextChanged);
            // 
            // txtAnimal_Amount_Hunger
            // 
            this.txtAnimal_Amount_Hunger.Location = new System.Drawing.Point(472, 119);
            this.txtAnimal_Amount_Hunger.Multiline = true;
            this.txtAnimal_Amount_Hunger.Name = "txtAnimal_Amount_Hunger";
            this.txtAnimal_Amount_Hunger.Size = new System.Drawing.Size(161, 22);
            this.txtAnimal_Amount_Hunger.TabIndex = 2;
            // 
            // txtAnimal_Number_Child
            // 
            this.txtAnimal_Number_Child.Location = new System.Drawing.Point(472, 147);
            this.txtAnimal_Number_Child.Multiline = true;
            this.txtAnimal_Number_Child.Name = "txtAnimal_Number_Child";
            this.txtAnimal_Number_Child.Size = new System.Drawing.Size(161, 22);
            this.txtAnimal_Number_Child.TabIndex = 3;
            // 
            // lblAnimal_Age
            // 
            this.lblAnimal_Age.AutoSize = true;
            this.lblAnimal_Age.Location = new System.Drawing.Point(663, 95);
            this.lblAnimal_Age.Name = "lblAnimal_Age";
            this.lblAnimal_Age.Size = new System.Drawing.Size(77, 17);
            this.lblAnimal_Age.TabIndex = 4;
            this.lblAnimal_Age.Text = "animal age";
            this.lblAnimal_Age.Click += new System.EventHandler(this.lblAnimal_Age_Click);
            // 
            // lblAnimal_Amount_Hunger
            // 
            this.lblAnimal_Amount_Hunger.AutoSize = true;
            this.lblAnimal_Amount_Hunger.Location = new System.Drawing.Point(663, 122);
            this.lblAnimal_Amount_Hunger.Name = "lblAnimal_Amount_Hunger";
            this.lblAnimal_Amount_Hunger.Size = new System.Drawing.Size(149, 17);
            this.lblAnimal_Amount_Hunger.TabIndex = 5;
            this.lblAnimal_Amount_Hunger.Text = "animal amount hunger";
            // 
            // lblAnimal_Number_Child
            // 
            this.lblAnimal_Number_Child.AutoSize = true;
            this.lblAnimal_Number_Child.Location = new System.Drawing.Point(663, 152);
            this.lblAnimal_Number_Child.Name = "lblAnimal_Number_Child";
            this.lblAnimal_Number_Child.Size = new System.Drawing.Size(139, 17);
            this.lblAnimal_Number_Child.TabIndex = 6;
            this.lblAnimal_Number_Child.Text = "Animal Number Child";
            // 
            // lblAnimal_Hunger
            // 
            this.lblAnimal_Hunger.AutoSize = true;
            this.lblAnimal_Hunger.Location = new System.Drawing.Point(663, 182);
            this.lblAnimal_Hunger.Name = "lblAnimal_Hunger";
            this.lblAnimal_Hunger.Size = new System.Drawing.Size(101, 17);
            this.lblAnimal_Hunger.TabIndex = 8;
            this.lblAnimal_Hunger.Text = "Animal Hunger";
            // 
            // combo_Animal_type
            // 
            this.combo_Animal_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Animal_type.FormattingEnabled = true;
            this.combo_Animal_type.Items.AddRange(new object[] {
            "rabit"});
            this.combo_Animal_type.Location = new System.Drawing.Point(472, 24);
            this.combo_Animal_type.Name = "combo_Animal_type";
            this.combo_Animal_type.Size = new System.Drawing.Size(121, 24);
            this.combo_Animal_type.TabIndex = 9;
            this.combo_Animal_type.SelectedIndexChanged += new System.EventHandler(this.combo_Animal_name_SelectedIndexChanged);
            // 
            // lbl_Animal_type
            // 
            this.lbl_Animal_type.AutoSize = true;
            this.lbl_Animal_type.Location = new System.Drawing.Point(663, 24);
            this.lbl_Animal_type.Name = "lbl_Animal_type";
            this.lbl_Animal_type.Size = new System.Drawing.Size(80, 17);
            this.lbl_Animal_type.TabIndex = 10;
            this.lbl_Animal_type.Text = "animal type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // chk_animal_state
            // 
            this.chk_animal_state.AutoSize = true;
            this.chk_animal_state.Location = new System.Drawing.Point(478, 181);
            this.chk_animal_state.Name = "chk_animal_state";
            this.chk_animal_state.Size = new System.Drawing.Size(161, 21);
            this.chk_animal_state.TabIndex = 12;
            this.chk_animal_state.Text = "check animal hunger";
            this.chk_animal_state.UseVisualStyleBackColor = true;
            // 
            // txtanimal_name
            // 
            this.txtanimal_name.Location = new System.Drawing.Point(472, 65);
            this.txtanimal_name.Multiline = true;
            this.txtanimal_name.Name = "txtanimal_name";
            this.txtanimal_name.Size = new System.Drawing.Size(161, 21);
            this.txtanimal_name.TabIndex = 13;
            // 
            // lblanimal_name
            // 
            this.lblanimal_name.AutoSize = true;
            this.lblanimal_name.Location = new System.Drawing.Point(663, 69);
            this.lblanimal_name.Name = "lblanimal_name";
            this.lblanimal_name.Size = new System.Drawing.Size(88, 17);
            this.lblanimal_name.TabIndex = 14;
            this.lblanimal_name.Text = "animal name";
            // 
            // main_jungle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 364);
            this.Controls.Add(this.lblanimal_name);
            this.Controls.Add(this.txtanimal_name);
            this.Controls.Add(this.chk_animal_state);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Animal_type);
            this.Controls.Add(this.combo_Animal_type);
            this.Controls.Add(this.lblAnimal_Hunger);
            this.Controls.Add(this.lblAnimal_Number_Child);
            this.Controls.Add(this.lblAnimal_Amount_Hunger);
            this.Controls.Add(this.lblAnimal_Age);
            this.Controls.Add(this.txtAnimal_Number_Child);
            this.Controls.Add(this.txtAnimal_Amount_Hunger);
            this.Controls.Add(this.txtAnimal_Age);
            this.Controls.Add(this.Rabit_add);
            this.Name = "main_jungle";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rabit_add;
        private System.Windows.Forms.TextBox txtAnimal_Age;
        private System.Windows.Forms.TextBox txtAnimal_Amount_Hunger;
        private System.Windows.Forms.TextBox txtAnimal_Number_Child;
        private System.Windows.Forms.Label lblAnimal_Age;
        private System.Windows.Forms.Label lblAnimal_Amount_Hunger;
        private System.Windows.Forms.Label lblAnimal_Number_Child;
        private System.Windows.Forms.Label lblAnimal_Hunger;
        private System.Windows.Forms.ComboBox combo_Animal_type;
        private System.Windows.Forms.Label lbl_Animal_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_animal_state;
        private System.Windows.Forms.TextBox txtanimal_name;
        private System.Windows.Forms.Label lblanimal_name;
    }
}

