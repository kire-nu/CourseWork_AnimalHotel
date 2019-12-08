namespace Assignment1 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBoxAnimalSpec = new System.Windows.Forms.GroupBox();
            this.buttonAddAnimal = new System.Windows.Forms.Button();
            this.groupBoxSpecies = new System.Windows.Forms.GroupBox();
            this.listBoxSpecies = new System.Windows.Forms.ListBox();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.listBoxGender = new System.Windows.Forms.ListBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxCategorySpec = new System.Windows.Forms.GroupBox();
            this.textBoxSpecificCatSpec = new System.Windows.Forms.TextBox();
            this.textBoxCommonCatSpec = new System.Windows.Forms.TextBox();
            this.labelSpecificCatSpec = new System.Windows.Forms.Label();
            this.labelCatCommonSpec = new System.Windows.Forms.Label();
            this.groupBoxAnimalList = new System.Windows.Forms.GroupBox();
            this.labelListSpecies = new System.Windows.Forms.Label();
            this.labelListChar = new System.Windows.Forms.Label();
            this.labelListGender = new System.Windows.Forms.Label();
            this.labelListAge = new System.Windows.Forms.Label();
            this.labelListName = new System.Windows.Forms.Label();
            this.labelListID = new System.Windows.Forms.Label();
            this.listBoxAnimals = new System.Windows.Forms.ListBox();
            this.groupBoxFeedingSchedule = new System.Windows.Forms.GroupBox();
            this.textBoxFeedingSchedule = new System.Windows.Forms.TextBox();
            this.textBoxEaterType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddFood = new System.Windows.Forms.Button();
            this.groupBoxFoodStaff = new System.Windows.Forms.GroupBox();
            this.listBoxFoodStaff = new System.Windows.Forms.ListBox();
            this.buttonAddStaff = new System.Windows.Forms.Button();
            this.groupBoxAnimalSpec.SuspendLayout();
            this.groupBoxSpecies.SuspendLayout();
            this.groupBoxCategory.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxCategorySpec.SuspendLayout();
            this.groupBoxAnimalList.SuspendLayout();
            this.groupBoxFeedingSchedule.SuspendLayout();
            this.groupBoxFoodStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAnimalSpec
            // 
            this.groupBoxAnimalSpec.Controls.Add(this.buttonAddAnimal);
            this.groupBoxAnimalSpec.Controls.Add(this.groupBoxSpecies);
            this.groupBoxAnimalSpec.Controls.Add(this.groupBoxCategory);
            this.groupBoxAnimalSpec.Controls.Add(this.groupBoxGender);
            this.groupBoxAnimalSpec.Controls.Add(this.textBoxAge);
            this.groupBoxAnimalSpec.Controls.Add(this.labelAge);
            this.groupBoxAnimalSpec.Controls.Add(this.textBoxName);
            this.groupBoxAnimalSpec.Controls.Add(this.labelName);
            this.groupBoxAnimalSpec.Controls.Add(this.groupBoxCategorySpec);
            this.groupBoxAnimalSpec.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAnimalSpec.Name = "groupBoxAnimalSpec";
            this.groupBoxAnimalSpec.Size = new System.Drawing.Size(490, 227);
            this.groupBoxAnimalSpec.TabIndex = 0;
            this.groupBoxAnimalSpec.TabStop = false;
            this.groupBoxAnimalSpec.Text = "Animal Specifications";
            // 
            // buttonAddAnimal
            // 
            this.buttonAddAnimal.Location = new System.Drawing.Point(338, 191);
            this.buttonAddAnimal.Name = "buttonAddAnimal";
            this.buttonAddAnimal.Size = new System.Drawing.Size(141, 23);
            this.buttonAddAnimal.TabIndex = 7;
            this.buttonAddAnimal.Text = "Add This Animal";
            this.buttonAddAnimal.UseVisualStyleBackColor = true;
            this.buttonAddAnimal.Click += new System.EventHandler(this.buttonAddAnimal_Click);
            // 
            // groupBoxSpecies
            // 
            this.groupBoxSpecies.Controls.Add(this.listBoxSpecies);
            this.groupBoxSpecies.Location = new System.Drawing.Point(338, 19);
            this.groupBoxSpecies.Name = "groupBoxSpecies";
            this.groupBoxSpecies.Size = new System.Drawing.Size(141, 166);
            this.groupBoxSpecies.TabIndex = 5;
            this.groupBoxSpecies.TabStop = false;
            this.groupBoxSpecies.Text = "Specicies";
            // 
            // listBoxSpecies
            // 
            this.listBoxSpecies.FormattingEnabled = true;
            this.listBoxSpecies.Location = new System.Drawing.Point(6, 19);
            this.listBoxSpecies.Name = "listBoxSpecies";
            this.listBoxSpecies.Size = new System.Drawing.Size(125, 134);
            this.listBoxSpecies.TabIndex = 0;
            this.listBoxSpecies.SelectedIndexChanged += new System.EventHandler(this.listBoxSpecies_SelectedIndexChanged);
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.listBoxCategory);
            this.groupBoxCategory.Location = new System.Drawing.Point(185, 19);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(147, 121);
            this.groupBoxCategory.TabIndex = 4;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Category";
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Location = new System.Drawing.Point(6, 19);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(131, 95);
            this.listBoxCategory.TabIndex = 0;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.listBoxCategory_SelectedIndexChanged);
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.listBoxGender);
            this.groupBoxGender.Location = new System.Drawing.Point(9, 71);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(170, 69);
            this.groupBoxGender.TabIndex = 3;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // listBoxGender
            // 
            this.listBoxGender.FormattingEnabled = true;
            this.listBoxGender.Location = new System.Drawing.Point(6, 19);
            this.listBoxGender.Name = "listBoxGender";
            this.listBoxGender.Size = new System.Drawing.Size(158, 43);
            this.listBoxGender.TabIndex = 0;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(126, 45);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(53, 20);
            this.textBoxAge.TabIndex = 1;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(6, 48);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Age";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(47, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(132, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // groupBoxCategorySpec
            // 
            this.groupBoxCategorySpec.Controls.Add(this.textBoxSpecificCatSpec);
            this.groupBoxCategorySpec.Controls.Add(this.textBoxCommonCatSpec);
            this.groupBoxCategorySpec.Controls.Add(this.labelSpecificCatSpec);
            this.groupBoxCategorySpec.Controls.Add(this.labelCatCommonSpec);
            this.groupBoxCategorySpec.Location = new System.Drawing.Point(9, 146);
            this.groupBoxCategorySpec.Name = "groupBoxCategorySpec";
            this.groupBoxCategorySpec.Size = new System.Drawing.Size(323, 75);
            this.groupBoxCategorySpec.TabIndex = 6;
            this.groupBoxCategorySpec.TabStop = false;
            this.groupBoxCategorySpec.Text = "Animal Category Specifications";
            // 
            // textBoxSpecificCatSpec
            // 
            this.textBoxSpecificCatSpec.Location = new System.Drawing.Point(126, 45);
            this.textBoxSpecificCatSpec.Name = "textBoxSpecificCatSpec";
            this.textBoxSpecificCatSpec.Size = new System.Drawing.Size(53, 20);
            this.textBoxSpecificCatSpec.TabIndex = 1;
            // 
            // textBoxCommonCatSpec
            // 
            this.textBoxCommonCatSpec.Location = new System.Drawing.Point(126, 19);
            this.textBoxCommonCatSpec.Name = "textBoxCommonCatSpec";
            this.textBoxCommonCatSpec.Size = new System.Drawing.Size(53, 20);
            this.textBoxCommonCatSpec.TabIndex = 0;
            // 
            // labelSpecificCatSpec
            // 
            this.labelSpecificCatSpec.AutoSize = true;
            this.labelSpecificCatSpec.Location = new System.Drawing.Point(6, 48);
            this.labelSpecificCatSpec.Name = "labelSpecificCatSpec";
            this.labelSpecificCatSpec.Size = new System.Drawing.Size(45, 13);
            this.labelSpecificCatSpec.TabIndex = 9;
            this.labelSpecificCatSpec.Text = "Specific";
            // 
            // labelCatCommonSpec
            // 
            this.labelCatCommonSpec.AutoSize = true;
            this.labelCatCommonSpec.Location = new System.Drawing.Point(6, 22);
            this.labelCatCommonSpec.Name = "labelCatCommonSpec";
            this.labelCatCommonSpec.Size = new System.Drawing.Size(48, 13);
            this.labelCatCommonSpec.TabIndex = 7;
            this.labelCatCommonSpec.Text = "Common";
            // 
            // groupBoxAnimalList
            // 
            this.groupBoxAnimalList.Controls.Add(this.labelListSpecies);
            this.groupBoxAnimalList.Controls.Add(this.labelListChar);
            this.groupBoxAnimalList.Controls.Add(this.labelListGender);
            this.groupBoxAnimalList.Controls.Add(this.labelListAge);
            this.groupBoxAnimalList.Controls.Add(this.labelListName);
            this.groupBoxAnimalList.Controls.Add(this.labelListID);
            this.groupBoxAnimalList.Controls.Add(this.listBoxAnimals);
            this.groupBoxAnimalList.Location = new System.Drawing.Point(12, 245);
            this.groupBoxAnimalList.Name = "groupBoxAnimalList";
            this.groupBoxAnimalList.Size = new System.Drawing.Size(656, 193);
            this.groupBoxAnimalList.TabIndex = 8;
            this.groupBoxAnimalList.TabStop = false;
            this.groupBoxAnimalList.Text = "List of Animals in the Motel";
            // 
            // labelListSpecies
            // 
            this.labelListSpecies.AutoSize = true;
            this.labelListSpecies.Location = new System.Drawing.Point(30, 22);
            this.labelListSpecies.Name = "labelListSpecies";
            this.labelListSpecies.Size = new System.Drawing.Size(45, 13);
            this.labelListSpecies.TabIndex = 14;
            this.labelListSpecies.Text = "Species";
            // 
            // labelListChar
            // 
            this.labelListChar.AutoSize = true;
            this.labelListChar.Location = new System.Drawing.Point(337, 22);
            this.labelListChar.Name = "labelListChar";
            this.labelListChar.Size = new System.Drawing.Size(114, 13);
            this.labelListChar.TabIndex = 13;
            this.labelListChar.Text = "Special Characteristics";
            // 
            // labelListGender
            // 
            this.labelListGender.AutoSize = true;
            this.labelListGender.Location = new System.Drawing.Point(280, 22);
            this.labelListGender.Name = "labelListGender";
            this.labelListGender.Size = new System.Drawing.Size(42, 13);
            this.labelListGender.TabIndex = 12;
            this.labelListGender.Text = "Gender";
            // 
            // labelListAge
            // 
            this.labelListAge.AutoSize = true;
            this.labelListAge.Location = new System.Drawing.Point(248, 22);
            this.labelListAge.Name = "labelListAge";
            this.labelListAge.Size = new System.Drawing.Size(26, 13);
            this.labelListAge.TabIndex = 11;
            this.labelListAge.Text = "Age";
            // 
            // labelListName
            // 
            this.labelListName.AutoSize = true;
            this.labelListName.Location = new System.Drawing.Point(111, 22);
            this.labelListName.Name = "labelListName";
            this.labelListName.Size = new System.Drawing.Size(35, 13);
            this.labelListName.TabIndex = 10;
            this.labelListName.Text = "Name";
            // 
            // labelListID
            // 
            this.labelListID.AutoSize = true;
            this.labelListID.Location = new System.Drawing.Point(6, 22);
            this.labelListID.Name = "labelListID";
            this.labelListID.Size = new System.Drawing.Size(18, 13);
            this.labelListID.TabIndex = 9;
            this.labelListID.Text = "ID";
            // 
            // listBoxAnimals
            // 
            this.listBoxAnimals.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAnimals.FormattingEnabled = true;
            this.listBoxAnimals.Location = new System.Drawing.Point(6, 38);
            this.listBoxAnimals.Name = "listBoxAnimals";
            this.listBoxAnimals.Size = new System.Drawing.Size(643, 147);
            this.listBoxAnimals.TabIndex = 0;
            this.listBoxAnimals.SelectedIndexChanged += new System.EventHandler(this.listBoxAnimals_SelectedIndexChanged);
            // 
            // groupBoxFeedingSchedule
            // 
            this.groupBoxFeedingSchedule.Controls.Add(this.textBoxFeedingSchedule);
            this.groupBoxFeedingSchedule.Controls.Add(this.textBoxEaterType);
            this.groupBoxFeedingSchedule.Controls.Add(this.label1);
            this.groupBoxFeedingSchedule.Location = new System.Drawing.Point(674, 245);
            this.groupBoxFeedingSchedule.Name = "groupBoxFeedingSchedule";
            this.groupBoxFeedingSchedule.Size = new System.Drawing.Size(248, 193);
            this.groupBoxFeedingSchedule.TabIndex = 9;
            this.groupBoxFeedingSchedule.TabStop = false;
            this.groupBoxFeedingSchedule.Text = "Feeding Schedule";
            // 
            // textBoxFeedingSchedule
            // 
            this.textBoxFeedingSchedule.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFeedingSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFeedingSchedule.Enabled = false;
            this.textBoxFeedingSchedule.Location = new System.Drawing.Point(6, 45);
            this.textBoxFeedingSchedule.Multiline = true;
            this.textBoxFeedingSchedule.Name = "textBoxFeedingSchedule";
            this.textBoxFeedingSchedule.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxFeedingSchedule.Size = new System.Drawing.Size(233, 140);
            this.textBoxFeedingSchedule.TabIndex = 4;
            // 
            // textBoxEaterType
            // 
            this.textBoxEaterType.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxEaterType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEaterType.Enabled = false;
            this.textBoxEaterType.Location = new System.Drawing.Point(71, 19);
            this.textBoxEaterType.Name = "textBoxEaterType";
            this.textBoxEaterType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxEaterType.Size = new System.Drawing.Size(168, 20);
            this.textBoxEaterType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eater Type";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(18, 444);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(91, 23);
            this.buttonChange.TabIndex = 8;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(115, 444);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(89, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddFood
            // 
            this.buttonAddFood.Location = new System.Drawing.Point(6, 39);
            this.buttonAddFood.Name = "buttonAddFood";
            this.buttonAddFood.Size = new System.Drawing.Size(71, 23);
            this.buttonAddFood.TabIndex = 11;
            this.buttonAddFood.Text = "Add Food";
            this.buttonAddFood.UseVisualStyleBackColor = true;
            this.buttonAddFood.Click += new System.EventHandler(this.buttonAddFood_Click);
            // 
            // groupBoxFoodStaff
            // 
            this.groupBoxFoodStaff.Controls.Add(this.buttonAddStaff);
            this.groupBoxFoodStaff.Controls.Add(this.listBoxFoodStaff);
            this.groupBoxFoodStaff.Controls.Add(this.buttonAddFood);
            this.groupBoxFoodStaff.Location = new System.Drawing.Point(508, 18);
            this.groupBoxFoodStaff.Name = "groupBoxFoodStaff";
            this.groupBoxFoodStaff.Size = new System.Drawing.Size(414, 221);
            this.groupBoxFoodStaff.TabIndex = 6;
            this.groupBoxFoodStaff.TabStop = false;
            this.groupBoxFoodStaff.Text = "Food and Staff Details";
            // 
            // listBoxFoodStaff
            // 
            this.listBoxFoodStaff.FormattingEnabled = true;
            this.listBoxFoodStaff.Location = new System.Drawing.Point(83, 16);
            this.listBoxFoodStaff.Name = "listBoxFoodStaff";
            this.listBoxFoodStaff.Size = new System.Drawing.Size(322, 186);
            this.listBoxFoodStaff.TabIndex = 0;
            // 
            // buttonAddStaff
            // 
            this.buttonAddStaff.Location = new System.Drawing.Point(6, 84);
            this.buttonAddStaff.Name = "buttonAddStaff";
            this.buttonAddStaff.Size = new System.Drawing.Size(71, 23);
            this.buttonAddStaff.TabIndex = 12;
            this.buttonAddStaff.Text = "Add Staff";
            this.buttonAddStaff.UseVisualStyleBackColor = true;
            this.buttonAddStaff.Click += new System.EventHandler(this.buttonAddStaff_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 475);
            this.Controls.Add(this.groupBoxFoodStaff);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.groupBoxFeedingSchedule);
            this.Controls.Add(this.groupBoxAnimalList);
            this.Controls.Add(this.groupBoxAnimalSpec);
            this.Name = "MainForm";
            this.Text = "Animal Hotel";
            this.groupBoxAnimalSpec.ResumeLayout(false);
            this.groupBoxAnimalSpec.PerformLayout();
            this.groupBoxSpecies.ResumeLayout(false);
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxCategorySpec.ResumeLayout(false);
            this.groupBoxCategorySpec.PerformLayout();
            this.groupBoxAnimalList.ResumeLayout(false);
            this.groupBoxAnimalList.PerformLayout();
            this.groupBoxFeedingSchedule.ResumeLayout(false);
            this.groupBoxFeedingSchedule.PerformLayout();
            this.groupBoxFoodStaff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAnimalSpec;
        private System.Windows.Forms.Button buttonAddAnimal;
        private System.Windows.Forms.GroupBox groupBoxSpecies;
        private System.Windows.Forms.ListBox listBoxSpecies;
        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.ListBox listBoxGender;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxCategorySpec;
        private System.Windows.Forms.TextBox textBoxSpecificCatSpec;
        private System.Windows.Forms.TextBox textBoxCommonCatSpec;
        private System.Windows.Forms.Label labelSpecificCatSpec;
        private System.Windows.Forms.Label labelCatCommonSpec;
        private System.Windows.Forms.GroupBox groupBoxAnimalList;
        private System.Windows.Forms.ListBox listBoxAnimals;
        private System.Windows.Forms.Label labelListChar;
        private System.Windows.Forms.Label labelListGender;
        private System.Windows.Forms.Label labelListAge;
        private System.Windows.Forms.Label labelListName;
        private System.Windows.Forms.Label labelListID;
        private System.Windows.Forms.GroupBox groupBoxFeedingSchedule;
        private System.Windows.Forms.TextBox textBoxEaterType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFeedingSchedule;
        private System.Windows.Forms.Label labelListSpecies;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddFood;
        private System.Windows.Forms.GroupBox groupBoxFoodStaff;
        private System.Windows.Forms.ListBox listBoxFoodStaff;
        private System.Windows.Forms.Button buttonAddStaff;
    }
}

