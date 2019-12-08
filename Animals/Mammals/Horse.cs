using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1 {
    public class Horse : Mammal {
        #region Fields

        private string breed = string.Empty;
        private EaterType eaterType = EaterType.Herbivore;
        private string[] feedingschedule = new string[] {"A horse requires one bale of hay every day.",
            "Additionally, it requires 50L of water for drinking per day, but this might increase during summer." };

        #endregion

        #region Constructors

        public Horse(string name, int age, Gender gender, double weight, string breed)
            : base(name, age, gender, weight) {
            this.breed = breed;
        }
        public Horse() : base() { }

        #endregion

        #region Properties

        public string Breed {
            get { return breed; }
            set { breed = value; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Return eater type
        /// </summary>
        /// <returns></returns>
        public override EaterType GetEaterType() {
            return this.eaterType;
        }

        /// <summary>
        /// Return feedingschedule
        /// </summary>
        /// <returns></returns>
        public override FoodSchedule GetFoodSchedule() {
            List<string> feedingschedule = new List<string>();
            foreach (string row in this.feedingschedule) {
                feedingschedule.Add(row);
            }
            FoodSchedule foodSchedule = new FoodSchedule(feedingschedule);
            return foodSchedule;
        }

        /// <summary>
        /// Get name of specie
        /// </summary>
        /// <returns></returns>
        public override string GetSpecies() {
            return "Horse";
        }

        /// <summary>
        /// Convert values to string
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            string text = base.ToString() + string.Format("{0,-20}", string.Concat("Breed: ", breed));
            return text;
        }

        #endregion
    }
}
