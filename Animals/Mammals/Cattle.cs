using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    public class Cattle : Mammal {
        #region Fields

        private double height = double.NaN;
        private EaterType eaterType = EaterType.Herbivore;
        private string[] feedingschedule = new string[] {"A cattle requires one bale of hay every day.",
            "In summer, it is possible to have the cattle in a field with green grass, where it would require an area of 1000 sqm per animal",
            "Additionally, it requires 50L of water for drinking per day, but this might increase during summer." };

        #endregion

        #region Constructors

        public Cattle(string name, int age, Gender gender, double weight, double height)
            : base(name, age, gender, weight) {
            this.height = height;
        }
        public Cattle() : base() { }

        #endregion

        #region Properties

        public double Height {
            get { return height; }
            set {
                if (value > 0.0) {
                    height = value;
                }
            }
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
            return "Cattle";
        }

        /// <summary>
        /// Convert values to string
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            string text = base.ToString() + string.Format("{0,-20}", string.Concat("Height: ", height, " m"));
            return text;
        }

        #endregion
    }
}
