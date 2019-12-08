//Erik Olofsson, 31/01/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    public abstract class Animal : IAnimal {

        #region Fields

        private string name = string.Empty;
        private int age = -1;
        private Gender gender = Gender.Unknown;
        private string id = string.Empty;

        #endregion

        #region Constructors

        public Animal() {
        }
        public Animal(string name, int age, Gender gender) {
            this.name = name;
            if (age > 0) {
                this.age = age;
            }
            this.gender = gender;
        }

        #endregion

        #region Properties

        public string Name {
            get { return name; }
            set { name = value; }
        }
        public int Age {
            get { return age; }
            set { if (value>0) { age = value; } }
        }
        public Gender Gender {
            get { return gender; }
            set { gender = value; }
        }
        public string ID {
            get { return id; }
            set { id = value; }
        }
        
        #endregion

        #region Methods

        /// <summary>
        /// Copy main data from one animal to this
        /// </summary>
        /// <param name="characteristics"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public void CopyAnimal(Animal animal) {
            this.name = animal.Name;
            this.age = animal.Age;
            this.gender = animal.Gender;
        }

        public abstract EaterType GetEaterType();

        public abstract FoodSchedule GetFoodSchedule();

        public abstract string GetSpecies();

        public abstract string GetCategory();

        /// <summary>
        /// Convert values to string
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            string text = string.Format("{0,3} {1,-12} {2,-22} {3,4} {4,-10}", id.ToString(), GetSpecies(), name, age.ToString(), gender.ToString());
            return text;
        }

        #endregion
    }
}
