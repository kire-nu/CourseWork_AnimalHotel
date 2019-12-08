using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment1 {
    public partial class RecipeForm : Form {

        private Recipe recipe;

        public RecipeForm() {
            InitializeComponent();
            InitializeGUI();
            if (recipe == null) {
                recipe = new Recipe();
            }

        }

        public Recipe Recipe {
            get { return recipe; }
            set { recipe = value; }
        }

        private void InitializeGUI() {
            textBoxName.Text = string.Empty;
            listBoxIngredients.Items.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            recipe.Ingredients.Add(textBoxIngredient.Text);
            textBoxIngredient.Clear();
            listBoxIngredients.Items.Clear();
            listBoxIngredients.Items.AddRange(recipe.Ingredients.ToStringArray());
        }

        private void buttonChange_Click(object sender, EventArgs e) {
            int index = listBoxIngredients.SelectedIndex;
            recipe.Ingredients.ChangeAt(textBoxIngredient.Text, index);
            textBoxIngredient.Clear();
            listBoxIngredients.Items.Clear();
            listBoxIngredients.Items.AddRange(recipe.Ingredients.ToStringArray());
        }

        private void buttonDelete_Click(object sender, EventArgs e) {
            int index = listBoxIngredients.SelectedIndex;
            recipe.Ingredients.DeleteAt(index);
            textBoxIngredient.Clear();
            listBoxIngredients.Items.Clear();
            listBoxIngredients.Items.AddRange(recipe.Ingredients.ToStringArray());
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            if (textBoxName.Text != string.Empty) {
                if (recipe.Ingredients.Count > 0) {
                    recipe.Name = textBoxName.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                } else {
                    MessageBox.Show("Recipe must have at least one ingredient", "Error");
                }
            } else {
                MessageBox.Show("Name must be entered", "Error");
            }

        }

        private void listBoxIngredients_SelectedIndexChanged(object sender, EventArgs e) {
            int index = listBoxIngredients.SelectedIndex;
            textBoxIngredient.Text = recipe.Ingredients.GetAt(index);
        }
    }
}
