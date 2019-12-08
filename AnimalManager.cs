//Erik Olofsson, 31/01/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    class AnimalManager : ListManager<Animal> {
        #region Fields

        private int animalIdCounter = 0;

        #endregion

        #region Constructors
        public AnimalManager() : base() { }
        #endregion

        #region Properties

        #endregion

        #region Methods

        /// <summary>
        /// Create animal
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="species"></param>
        /// <param name="commonCharacteristics"></param>
        /// <param name="specificCharacteristics"></param>
        /// <param name="animal"></param>
        private bool CreateAnimal(string name, int age, Gender gender, Species species, string commonCharacteristics, string specificCharacteristics, out Animal animal) {
            double common;
            double specific;
            switch (species) {
                case Species.Cattle:
                    double.TryParse(commonCharacteristics, out common);
                    double.TryParse(specificCharacteristics, out specific);
                    animal = new Cattle(name, age, gender, common, specific);
                    return true;
                case Species.Horse:
                    double.TryParse(commonCharacteristics, out common);
                    animal = new Horse(name, age, gender, common, specificCharacteristics);
                    return true;
                case Species.Chameleon:
                    double.TryParse(commonCharacteristics, out common);
                    animal = new Chameleon(name, age, gender, common, specificCharacteristics);
                    return true;
                case Species.Crocodile:
                    double.TryParse(commonCharacteristics, out common);
                    double.TryParse(specificCharacteristics, out specific);
                    animal = new Crocodile(name, age, gender, common, specific);
                    return true;
                case Species.Turtle:
                    double.TryParse(commonCharacteristics, out common);
                    double.TryParse(specificCharacteristics, out specific);
                    animal = new Turtle(name, age, gender, common, specific);
                    return true;
                default:
                    animal = null;
                    return false;
            }
        }


        /// <summary>
        /// Add Animal
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="species"></param>
        /// <param name="commonCharacteristics"></param>
        /// <param name="specificCharacteristics"></param>
        /// <returns></returns>
        public bool Add(string name, int age, Gender gender, Species species, string commonCharacteristics, string specificCharacteristics) {
            Animal animal;

            if (CreateAnimal(name, age, gender, species, commonCharacteristics, specificCharacteristics, out animal)) {
                animalIdCounter++;
                animal.ID = animalIdCounter.ToString();
                if (base.Add(animal)) {
                    return true;
                }
            }
            return false;
        }

        public bool ChangeAt(string name, int age, Gender gender, Species species, string commonCharacteristics, string specificCharacteristics, int index) {
            Animal animal;

            if (CreateAnimal(name, age, gender, species, commonCharacteristics, specificCharacteristics, out animal)) {
                if (CheckIndex(index)) {
                    Animal oldAnmial = GetAt(index);
                    animal.ID = oldAnmial.ID;
                    if (base.ChangeAt(animal,index)) {
                        return true;
                    }
                }
            }
            return false;
        }

            #endregion

    }
}
