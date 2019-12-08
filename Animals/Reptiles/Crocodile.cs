using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1 {
    public class Crocodile : Reptile {

        #region Fields

        private double tailLength = double.NaN;
        private EaterType eaterType = EaterType.Carnivore;
        private string[] feedingschedule = new string[] {"A crododile eats infrequent.",
            "This means it requires about 50kg of meat twice a week." };
        
        #endregion

        #region Constructors

        public Crocodile(string name, int age, Gender gender, double length, double tailLength)
            : base(name, age, gender, length) {
            if (tailLength >= 0) {
                this.tailLength = tailLength;
            }
        }
        public Crocodile() : base() { }

        #endregion

        #region Properties

        public double TailLength {
            get { return tailLength; }
            set {
                if (value > 0.0) {
                    tailLength = value;
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
            return "Crocodile";
        }

        /// <summary>
        /// Convert values to string
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            string text = base.ToString() + string.Format("{0,-20}", string.Concat("Tail Length: ", Math.Round(tailLength,3), " m"));
            return text;
        }

        #endregion
    }
}
