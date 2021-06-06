namespace RPG
{
    partial class Frm_CharCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CharCreator));
            this.Lbl_CharName = new System.Windows.Forms.Label();
            this.Txt_CharName = new System.Windows.Forms.TextBox();
            this.Rdo_GenderMale = new System.Windows.Forms.RadioButton();
            this.Gbox_Gender = new System.Windows.Forms.GroupBox();
            this.Rdo_GenderFemale = new System.Windows.Forms.RadioButton();
            this.Cbo_CharClass = new System.Windows.Forms.ComboBox();
            this.Lbl_CharClass = new System.Windows.Forms.Label();
            this.Btn_SaveChar = new System.Windows.Forms.Button();
            this.Txt_CharStats = new System.Windows.Forms.TextBox();
            this.Gbox_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_CharName
            // 
            this.Lbl_CharName.AutoSize = true;
            this.Lbl_CharName.Location = new System.Drawing.Point(12, 16);
            this.Lbl_CharName.Name = "Lbl_CharName";
            this.Lbl_CharName.Size = new System.Drawing.Size(55, 20);
            this.Lbl_CharName.TabIndex = 0;
            this.Lbl_CharName.Text = "Name:";
            this.Lbl_CharName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_CharName
            // 
            this.Txt_CharName.Location = new System.Drawing.Point(71, 13);
            this.Txt_CharName.Name = "Txt_CharName";
            this.Txt_CharName.Size = new System.Drawing.Size(276, 26);
            this.Txt_CharName.TabIndex = 1;
            // 
            // Rdo_GenderMale
            // 
            this.Rdo_GenderMale.AutoSize = true;
            this.Rdo_GenderMale.Checked = true;
            this.Rdo_GenderMale.Location = new System.Drawing.Point(6, 25);
            this.Rdo_GenderMale.Name = "Rdo_GenderMale";
            this.Rdo_GenderMale.Size = new System.Drawing.Size(68, 24);
            this.Rdo_GenderMale.TabIndex = 2;
            this.Rdo_GenderMale.TabStop = true;
            this.Rdo_GenderMale.Text = "Male";
            this.Rdo_GenderMale.UseVisualStyleBackColor = true;
            // 
            // Gbox_Gender
            // 
            this.Gbox_Gender.Controls.Add(this.Rdo_GenderFemale);
            this.Gbox_Gender.Controls.Add(this.Rdo_GenderMale);
            this.Gbox_Gender.Location = new System.Drawing.Point(71, 62);
            this.Gbox_Gender.Name = "Gbox_Gender";
            this.Gbox_Gender.Size = new System.Drawing.Size(263, 64);
            this.Gbox_Gender.TabIndex = 3;
            this.Gbox_Gender.TabStop = false;
            this.Gbox_Gender.Text = "Gender";
            // 
            // Rdo_GenderFemale
            // 
            this.Rdo_GenderFemale.AutoSize = true;
            this.Rdo_GenderFemale.Location = new System.Drawing.Point(80, 25);
            this.Rdo_GenderFemale.Name = "Rdo_GenderFemale";
            this.Rdo_GenderFemale.Size = new System.Drawing.Size(87, 24);
            this.Rdo_GenderFemale.TabIndex = 3;
            this.Rdo_GenderFemale.Text = "Female";
            this.Rdo_GenderFemale.UseVisualStyleBackColor = true;
            // 
            // Cbo_CharClass
            // 
            this.Cbo_CharClass.FormattingEnabled = true;
            this.Cbo_CharClass.Items.AddRange(new object[] {
            "Berserker",
            "Rogue",
            "Shaman",
            "Warrior",
            "Wizard"});
            this.Cbo_CharClass.Location = new System.Drawing.Point(71, 168);
            this.Cbo_CharClass.Name = "Cbo_CharClass";
            this.Cbo_CharClass.Size = new System.Drawing.Size(276, 28);
            this.Cbo_CharClass.Sorted = true;
            this.Cbo_CharClass.TabIndex = 4;
            this.Cbo_CharClass.SelectedIndexChanged += new System.EventHandler(this.Cbo_CharClass_SelectedIndexChanged);
            // 
            // Lbl_CharClass
            // 
            this.Lbl_CharClass.AutoSize = true;
            this.Lbl_CharClass.Location = new System.Drawing.Point(13, 171);
            this.Lbl_CharClass.Name = "Lbl_CharClass";
            this.Lbl_CharClass.Size = new System.Drawing.Size(52, 20);
            this.Lbl_CharClass.TabIndex = 5;
            this.Lbl_CharClass.Text = "Class:";
            // 
            // Btn_SaveChar
            // 
            this.Btn_SaveChar.Location = new System.Drawing.Point(71, 254);
            this.Btn_SaveChar.Name = "Btn_SaveChar";
            this.Btn_SaveChar.Size = new System.Drawing.Size(152, 65);
            this.Btn_SaveChar.TabIndex = 6;
            this.Btn_SaveChar.Text = "Save Character";
            this.Btn_SaveChar.UseVisualStyleBackColor = true;
            this.Btn_SaveChar.Click += new System.EventHandler(this.Btn_SaveChar_Click);
            // 
            // Txt_CharStats
            // 
            this.Txt_CharStats.Location = new System.Drawing.Point(353, 168);
            this.Txt_CharStats.Multiline = true;
            this.Txt_CharStats.Name = "Txt_CharStats";
            this.Txt_CharStats.ReadOnly = true;
            this.Txt_CharStats.Size = new System.Drawing.Size(166, 128);
            this.Txt_CharStats.TabIndex = 7;
            // 
            // Frm_CharCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.Txt_CharStats);
            this.Controls.Add(this.Btn_SaveChar);
            this.Controls.Add(this.Lbl_CharClass);
            this.Controls.Add(this.Cbo_CharClass);
            this.Controls.Add(this.Gbox_Gender);
            this.Controls.Add(this.Txt_CharName);
            this.Controls.Add(this.Lbl_CharName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CharCreator";
            this.Text = "New Character";
            this.Gbox_Gender.ResumeLayout(false);
            this.Gbox_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_CharName;
        private System.Windows.Forms.TextBox Txt_CharName;
        private System.Windows.Forms.RadioButton Rdo_GenderMale;
        private System.Windows.Forms.GroupBox Gbox_Gender;
        private System.Windows.Forms.RadioButton Rdo_GenderFemale;
        private System.Windows.Forms.ComboBox Cbo_CharClass;
        private System.Windows.Forms.Label Lbl_CharClass;
        private System.Windows.Forms.Button Btn_SaveChar;
        private System.Windows.Forms.TextBox Txt_CharStats;
    }
}