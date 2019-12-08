namespace Assignment1 {
    partial class RecipeForm {
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxAddIngredient = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.listBoxIngredients = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxIngredient = new System.Windows.Forms.TextBox();
            this.labelIngredient = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxAddIngredient.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(131, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(158, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // groupBoxAddIngredient
            // 
            this.groupBoxAddIngredient.Controls.Add(this.buttonDelete);
            this.groupBoxAddIngredient.Controls.Add(this.buttonChange);
            this.groupBoxAddIngredient.Controls.Add(this.listBoxIngredients);
            this.groupBoxAddIngredient.Controls.Add(this.buttonAdd);
            this.groupBoxAddIngredient.Controls.Add(this.textBoxIngredient);
            this.groupBoxAddIngredient.Controls.Add(this.labelIngredient);
            this.groupBoxAddIngredient.Location = new System.Drawing.Point(12, 38);
            this.groupBoxAddIngredient.Name = "groupBoxAddIngredient";
            this.groupBoxAddIngredient.Size = new System.Drawing.Size(288, 151);
            this.groupBoxAddIngredient.TabIndex = 2;
            this.groupBoxAddIngredient.TabStop = false;
            this.groupBoxAddIngredient.Text = "Add Ingredient";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(9, 103);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(104, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(9, 74);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(104, 23);
            this.buttonChange.TabIndex = 8;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // listBoxIngredients
            // 
            this.listBoxIngredients.FormattingEnabled = true;
            this.listBoxIngredients.Location = new System.Drawing.Point(119, 45);
            this.listBoxIngredients.Name = "listBoxIngredients";
            this.listBoxIngredients.Size = new System.Drawing.Size(158, 95);
            this.listBoxIngredients.TabIndex = 0;
            this.listBoxIngredients.SelectedIndexChanged += new System.EventHandler(this.listBoxIngredients_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(9, 45);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxIngredient
            // 
            this.textBoxIngredient.Location = new System.Drawing.Point(119, 19);
            this.textBoxIngredient.Name = "textBoxIngredient";
            this.textBoxIngredient.Size = new System.Drawing.Size(158, 20);
            this.textBoxIngredient.TabIndex = 0;
            // 
            // labelIngredient
            // 
            this.labelIngredient.AutoSize = true;
            this.labelIngredient.Location = new System.Drawing.Point(6, 22);
            this.labelIngredient.Name = "labelIngredient";
            this.labelIngredient.Size = new System.Drawing.Size(54, 13);
            this.labelIngredient.TabIndex = 1;
            this.labelIngredient.Text = "Ingredient";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(94, 195);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(104, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 229);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxAddIngredient);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "RecipeForm";
            this.Text = "Recipe Creator";
            this.groupBoxAddIngredient.ResumeLayout(false);
            this.groupBoxAddIngredient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxAddIngredient;
        private System.Windows.Forms.ListBox listBoxIngredients;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxIngredient;
        private System.Windows.Forms.Label labelIngredient;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonOk;
    }
}