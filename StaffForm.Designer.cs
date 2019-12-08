namespace Assignment1 {
    partial class StaffForm {
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
            this.groupBoxQualifications = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.listBoxQualifications = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxQualification = new System.Windows.Forms.TextBox();
            this.labelQualification = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxQualifications.SuspendLayout();
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
            // groupBoxQualifications
            // 
            this.groupBoxQualifications.Controls.Add(this.buttonDelete);
            this.groupBoxQualifications.Controls.Add(this.buttonChange);
            this.groupBoxQualifications.Controls.Add(this.listBoxQualifications);
            this.groupBoxQualifications.Controls.Add(this.buttonAdd);
            this.groupBoxQualifications.Controls.Add(this.textBoxQualification);
            this.groupBoxQualifications.Controls.Add(this.labelQualification);
            this.groupBoxQualifications.Location = new System.Drawing.Point(12, 38);
            this.groupBoxQualifications.Name = "groupBoxQualifications";
            this.groupBoxQualifications.Size = new System.Drawing.Size(288, 151);
            this.groupBoxQualifications.TabIndex = 2;
            this.groupBoxQualifications.TabStop = false;
            this.groupBoxQualifications.Text = "Qualifications";
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
            // listBoxQualifications
            // 
            this.listBoxQualifications.FormattingEnabled = true;
            this.listBoxQualifications.Location = new System.Drawing.Point(119, 45);
            this.listBoxQualifications.Name = "listBoxQualifications";
            this.listBoxQualifications.Size = new System.Drawing.Size(158, 95);
            this.listBoxQualifications.TabIndex = 0;
            this.listBoxQualifications.SelectedIndexChanged += new System.EventHandler(this.listBoxIngredients_SelectedIndexChanged);
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
            // textBoxQualification
            // 
            this.textBoxQualification.Location = new System.Drawing.Point(119, 19);
            this.textBoxQualification.Name = "textBoxQualification";
            this.textBoxQualification.Size = new System.Drawing.Size(158, 20);
            this.textBoxQualification.TabIndex = 0;
            // 
            // labelQualification
            // 
            this.labelQualification.AutoSize = true;
            this.labelQualification.Location = new System.Drawing.Point(6, 22);
            this.labelQualification.Name = "labelQualification";
            this.labelQualification.Size = new System.Drawing.Size(65, 13);
            this.labelQualification.TabIndex = 1;
            this.labelQualification.Text = "Qualification";
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
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 229);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxQualifications);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "StaffForm";
            this.Text = "Staff Planner";
            this.groupBoxQualifications.ResumeLayout(false);
            this.groupBoxQualifications.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxQualifications;
        private System.Windows.Forms.ListBox listBoxQualifications;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxQualification;
        private System.Windows.Forms.Label labelQualification;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonOk;
    }
}