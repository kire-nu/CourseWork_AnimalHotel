//Erik Olofsson, 31/01/2019
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1 {
    public partial class MainForm : Form {

        #region Fields

        /// <summary>
        /// Set animal manager where the work takes places
        /// </summary>
        AnimalManager animalmanager = new AnimalManager();
        RecipeManager recipeManager = new RecipeManager();
        StaffManager staffManager = new StaffManager();

        #endregion

        #region Methods

        public MainForm() {

            InitializeComponent();
            InitializeGUI();
            //Add a list of animals to start with for testing
            Debug_AddInitialValues();

        }

        /// <summary>
        /// Add list of animals to start for testing
        /// </summary>
        private void Debug_AddInitialValues() {
            animalmanager.Add("Speedy", 150, Gender.Unknown, Species.Turtle, "0.75", "1.0");
            animalmanager.Add("Smiley", 15, Gender.Male, Species.Crocodile, "5", "2");
            animalmanager.Add("Greedy", 1, Gender.Female, Species.Chameleon, "0.05", "Orange");
            animalmanager.Add("Sleepy", 5, Gender.Male, Species.Cattle, "995", "1.2");
            animalmanager.Add("Happy", 1, Gender.Female, Species.Horse, "350", "Icelandic horse");
            listBoxAnimals.Items.Clear();
            listBoxAnimals.Items.AddRange(animalmanager.ToStringArray());
            Recipe recipe = new Recipe();
            recipe.Name = "Turtle Special";
            recipe.Ingredients.Add("25% krill");
            recipe.Ingredients.Add("25% gammarus");
            recipe.Ingredients.Add("50% shrimp");
            recipeManager.Add(recipe);
            UpdateListFoodStaff();
        }

        /// <summary>
        /// Set default GUI look
        /// </summary>
        private void InitializeGUI() {
            listBoxCategory.Items.Clear();
            listBoxCategory.Items.AddRange(Enum.GetNames(typeof(Category)));
            listBoxSpecies.Items.Clear();
            labelCatCommonSpec.Visible = false;
            textBoxCommonCatSpec.Visible = false;
            labelSpecificCatSpec.Visible = false;
            textBoxSpecificCatSpec.Visible = false;
            listBoxGender.Items.Clear();
            listBoxGender.Items.AddRange(Enum.GetNames(typeof(Gender)));
            listBoxAnimals.Items.Clear();
            UpdateListFoodStaff();
        }

        /// <summary>
        /// Read inputs and store it in a temporary animal class
        /// </summary>
        /// <param name="specie"></param>
        /// <returns></returns>
        private bool ReadInputs(out string name, out int age, out Gender gender, out Category category, out Species specie) {
            name = string.Empty;
            age = -1;
            gender = Gender.Unknown;
            specie = Species.Cattle;
            category = Category.Birds;
            if (!ReadName(out name)) {
                return false;
            }

            if (!ReadAge(out age)) {
                return false;
            }
            if (!ReadGender(out gender)) {
                return false;
            }
            if (!ValidateCommon(out category)) {
                return false;
            }
            if (!ValidateSpecific(out specie)) {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Validate name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private bool ReadName(out string name) {
            name = string.Empty;
            if (!string.IsNullOrEmpty(textBoxName.Text)) {
                if (textBoxName.Text.Trim().Length <= 22) {
                    name = textBoxName.Text.Trim();
                    return true;
                } else {
                    MessageBox.Show("Name too long", "Error");
                    return false;
                }
            } else {
                MessageBox.Show("Name must be entered", "Error");
                return false;
            }
        }

        /// <summary>
        /// Validate age
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        private bool ReadAge(out int age) {
            age = -1;
            if (!string.IsNullOrEmpty(textBoxAge.Text)) {
                if (int.TryParse(textBoxAge.Text, out age)) {
                    return true;
                } else {
                    MessageBox.Show("Age is not a number", "Error");
                    return false;
                }
            } else {
                MessageBox.Show("Age must be entered", "Error");
                return false;
            }
        }

        /// <summary>
        /// Validate gender
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        private bool ReadGender(out Gender gender) {
            gender = Gender.Unknown;
            if (listBoxGender.SelectedIndex > -1) {
                if (Gender.TryParse(listBoxGender.GetItemText(listBoxGender.SelectedItem), out gender)) {
                    return true;
                } else {
                    MessageBox.Show("Error processing gender", "Error");
                    return false;
                }
            } else {
                MessageBox.Show("Gender must be entered", "Error");
                return false;
            }
        }

        /// <summary>
        /// Validate the specific characteristic
        /// </summary>
        /// <returns></returns>
        private bool ValidateSpecific(out Species species) {
            string specific = textBoxSpecificCatSpec.Text;
            if (GetCategory(out Category category)) {
                if (GetSpecie(category, out species)) {
                    if (!string.IsNullOrEmpty(specific)) {
                        switch (species) {
                            case Species.Cattle:
                                // Must be a number, that could contain decimals
                                if (validateDouble(specific)) {
                                    return true;
                                } else {
                                    MessageBox.Show(string.Format("{0} This is not a valid number", labelSpecificCatSpec.Text), "Error");
                                    return false;
                                }
                            case Species.Horse:
                                // Is a string, no further checks required
                                return true;
                            case Species.Chameleon:
                                // Is a string, no further checks required
                                return true;
                            case Species.Crocodile:
                                // Must be a number, that could contain decimals
                                if (validateDouble(specific)) {
                                    return true;
                                } else {
                                    MessageBox.Show(string.Format("{0} This is not a valid number", labelSpecificCatSpec.Text), "Error");
                                    return false;
                                }
                            case Species.Turtle:
                                // Must be a number, that could contain decimals
                                if (validateDouble(specific)) {
                                    return true;
                                } else {
                                    MessageBox.Show(string.Format("{0} This is not a valid number", labelSpecificCatSpec.Text), "Error");
                                    return false;
                                }
                            default:
                                return false;
                        }
                    } else {
                        MessageBox.Show(string.Format("{0} Input missing", labelSpecificCatSpec.Text), "Error");
                        return false;
                    }
                } else {
                    MessageBox.Show("Animal specie not choosen", "Error");
                    return false;
                }
            } else {
                species = Species.Cattle;
                return false;
            }
        }

        /// <summary>
        /// Validate the common characteristic
        /// </summary>
        /// <returns></returns>
        private bool ValidateCommon(out Category category) {
            string common = textBoxCommonCatSpec.Text;
            if (GetCategory(out category)) {
                if (!string.IsNullOrEmpty(common)) {
                    switch (category) {
                        case Category.Mammals:
                            // Must be a number, that could contain decimals
                            if (validateDouble(common)) {
                                return true;
                            } else {
                                MessageBox.Show(string.Format("{0} This is not a valid number", labelCatCommonSpec.Text), "Error");
                                return false;
                            }
                        case Category.Reptiles:
                            // Must be a number, that could contain decimals
                            if (validateDouble(common)) {
                                return true;
                            } else {
                                MessageBox.Show(string.Format("{0} This is not a valid number", labelCatCommonSpec.Text), "Error");
                                return false;
                            }
                        default:
                            return false;
                    }
                } else {
                    MessageBox.Show(string.Format("{0} Input missing", labelCatCommonSpec.Text), "Error");
                    return false;
                }
            } else {
                MessageBox.Show("Animal category not choosen", "Error");
                return false;
            }
        }

        /// <summary>
        /// Get category from selection
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        private bool GetCategory(out Category category) {
            if (Category.TryParse(listBoxCategory.GetItemText(listBoxCategory.SelectedItem), out category)) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get animal from selection
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        private bool GetSpecie(Category category, out Species species) {
            string animal = listBoxSpecies.GetItemText(listBoxSpecies.SelectedItem);
            if (Species.TryParse(animal, out species)) {
                switch (category) {
                    case Category.Mammals:
                        if (Specie_Mammal.TryParse(animal, out Specie_Mammal mammal)) {
                            return true;
                        } else {
                            return false;
                        }
                    case Category.Reptiles:
                        if (Specie_Reptile.TryParse(animal, out Specie_Reptile reptile)) {
                            return true;
                        } else {
                            return false;
                        }
                    default:
                        return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Validate numbers
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private bool validateDouble(string text) {
            double number = double.NaN;
            if (double.TryParse(text, out number)) {
                if (number > 0.0) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

        /// <summary>
        /// Select category and update species list and common characteristics
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e) {
            if (GetCategory(out Category category)) {
                string[] species;
                string characteristics;
                characteristics = SelectCategory(category, out species);
                listBoxSpecies.Items.Clear();
                labelCatCommonSpec.Visible = false;
                textBoxCommonCatSpec.Visible = false;
                labelSpecificCatSpec.Visible = false;
                textBoxSpecificCatSpec.Visible = false;
                textBoxCommonCatSpec.Text = string.Empty;
                textBoxSpecificCatSpec.Text = string.Empty;
                if (!string.IsNullOrEmpty(characteristics)) {
                    listBoxSpecies.Items.AddRange(species);
                    labelCatCommonSpec.Text = characteristics + ": ";
                    labelCatCommonSpec.Visible = true;
                    textBoxCommonCatSpec.Visible = true;
                } else {
                    MessageBox.Show("Category not implemented", "Error");
                }
            }
        }

        /// <summary>
        /// Get list of animals per category and their special characteristics
        /// </summary>
        /// <param name="category"></param>
        /// <param name="species"></param>
        /// <returns></returns>
        private string SelectCategory(Category category, out string[] species) {
            switch (category) {
                case Category.Mammals:
                    species = Enum.GetNames(typeof(Specie_Mammal));
                    return "Weight (kg)";
                case Category.Reptiles:
                    species = Enum.GetNames(typeof(Specie_Reptile));
                    return "Length (m)";
                default:
                    species = new string[] { };
                    return string.Empty;
            }
        }

        /// <summary>
        /// Select specie and update specific characteristics
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxSpecies_SelectedIndexChanged(object sender, EventArgs e) {
            if (GetCategory(out Category category)) {
                if (GetSpecie(category, out Species species)) {
                    string characteristics = GetSpecificCharacteristicsString(species);
                    labelSpecificCatSpec.Visible = false;
                    textBoxSpecificCatSpec.Visible = false;
                    textBoxSpecificCatSpec.Text = string.Empty;
                    if (!string.IsNullOrEmpty(characteristics)) {
                        labelSpecificCatSpec.Text = characteristics + ": ";
                        labelSpecificCatSpec.Visible = true;
                        textBoxSpecificCatSpec.Visible = true;
                    } else {
                        MessageBox.Show("Animal not implemented", "Error");
                    }
                }
            }
        }

        /// <summary>
        /// Get specific charateristics for an animal
        /// </summary>
        /// <param name="specie"></param>
        /// <param name="characteristics"></param>
        private string GetSpecificCharacteristicsString(Species specie) {
            switch (specie) {
                case Species.Cattle:
                    return "Height (m)";
                case Species.Horse:
                    return "Breed";
                case Species.Chameleon:
                    return "Colour";
                case Species.Crocodile:
                    return "Tail length (m)";
                case Species.Turtle:
                    return "Speed (km/h)";
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Create Animal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddAnimal_Click(object sender, EventArgs e) {
            string selectedSpecie = listBoxSpecies.GetItemText(listBoxSpecies.SelectedItem);
            string name;
            int age;
            Gender gender;
            bool ok = ReadInputs(out name, out age, out gender, out Category category, out Species specie);
            if (ok) {
                animalmanager.Add(name, age, gender, specie, textBoxCommonCatSpec.Text, textBoxSpecificCatSpec.Text);
                listBoxAnimals.Items.Clear();
                listBoxAnimals.Items.AddRange(animalmanager.ToStringArray());
            }
        }

        /// <summary>
        /// Get selected animal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAnimals_SelectedIndexChanged(object sender, EventArgs e) {
            int index = listBoxAnimals.SelectedIndex;
            if (index >= 0) {
                Animal animal = animalmanager.GetAt(index);
                textBoxName.Text = animal.Name;
                textBoxAge.Text = animal.Age.ToString();
                listBoxGender.SelectedIndex = (int)animal.Gender;
                string common = string.Empty;
                string specific = string.Empty;
                int category = 0;
                int specie = 0;
                if (animal is Cattle) {
                    category = (int)Category.Mammals;
                    specie = (int)Specie_Mammal.Cattle;
                    common = ((Cattle)animal).Weight.ToString();
                    specific = ((Cattle)animal).Height.ToString();
                }
                if (animal is Horse) {
                    category = (int)Category.Mammals;
                    specie = (int)Specie_Mammal.Horse;
                    common = ((Horse)animal).Weight.ToString();
                    specific = ((Horse)animal).Breed.ToString();
                }
                if (animal is Chameleon) {
                    category = (int)Category.Reptiles;
                    specie = (int)Specie_Reptile.Chameleon;
                    common = ((Chameleon)animal).Length.ToString();
                    specific = ((Chameleon)animal).Colour.ToString();
                }
                if (animal is Crocodile) {
                    category = (int)Category.Reptiles;
                    specie = (int)Specie_Reptile.Crocodile;
                    common = ((Crocodile)animal).Length.ToString();
                    specific = ((Crocodile)animal).TailLength.ToString();
                }
                if (animal is Turtle) {
                    category = (int)Category.Reptiles;
                    specie = (int)Specie_Reptile.Turtle;
                    common = ((Turtle)animal).Length.ToString();
                    specific = ((Turtle)animal).Speed.ToString();
                }
                textBoxEaterType.Text = animal.GetEaterType().ToString();
                FoodSchedule foodSchedule = animal.GetFoodSchedule();
                textBoxFeedingSchedule.Text = foodSchedule.ToString();
                listBoxCategory.SelectedIndex = category;
                listBoxSpecies.SelectedIndex = specie;
                textBoxCommonCatSpec.Text = common;
                textBoxSpecificCatSpec.Text = specific;
            }
        }

        /// <summary>
        /// Change animal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e) {
            int index = listBoxAnimals.SelectedIndex;
            string selectedSpecie = listBoxSpecies.GetItemText(listBoxSpecies.SelectedItem);
            string name;
            int age;
            Gender gender;
            bool ok = ReadInputs(out name, out age, out gender, out Category category, out Species specie);
            if (ok) {
                animalmanager.ChangeAt(name, age, gender, specie, textBoxCommonCatSpec.Text, textBoxSpecificCatSpec.Text, index);
                listBoxAnimals.Items.Clear();
                listBoxAnimals.Items.AddRange(animalmanager.ToStringArray());
            }
        }

        /// <summary>
        /// Delete animal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e) {
            int index = listBoxAnimals.SelectedIndex;
            animalmanager.DeleteAt(index);
            listBoxAnimals.Items.Clear();
            listBoxAnimals.Items.AddRange(animalmanager.ToStringArray());
        }

        /// <summary>
        /// Add recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddFood_Click(object sender, EventArgs e) {
            RecipeForm recipeForm = new RecipeForm();
            if (recipeForm.ShowDialog() == DialogResult.OK) {
                recipeManager.Add(recipeForm.Recipe);
            }
            UpdateListFoodStaff();
        }

        /// <summary>
        /// Update reciepe and staff list
        /// </summary>
        private void UpdateListFoodStaff() {
            listBoxFoodStaff.Items.Clear();
            listBoxFoodStaff.Items.Add("Recipies:");
            listBoxFoodStaff.Items.AddRange(recipeManager.ToStringArray());
            listBoxFoodStaff.Items.Add("Staff:");
            listBoxFoodStaff.Items.AddRange(staffManager.ToStringArray());
        }

        /// <summary>
        /// Add staff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddStaff_Click(object sender, EventArgs e) {
            StaffForm staffForm = new StaffForm();
            if (staffForm.ShowDialog() == DialogResult.OK) {
                staffManager.Add(staffForm.Staff);
            }
            UpdateListFoodStaff();
        }

        #endregion

    }
}
