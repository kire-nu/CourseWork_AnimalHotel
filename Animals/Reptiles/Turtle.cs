//Erik Olofsson, 31/01/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    public class Turtle : Reptile {

        #region Fields

        private double speed = double.NaN;
        private EaterType eaterType = EaterType.Omnivorous;
        private string[] feedingschedule = new string[] {"The dief of a turle varies by subspecie.",
            "Most turtles eat smaller sea creatures and thus requires at least 100g per day." };

        #endregion

        #region Constructors

        public Turtle(string name, int age, Gender gender, double length, double speed)
            : base(name, age, gender, length) {
            if (speed >= 0) {
                this.speed = speed;
            }
        }
        public Turtle() : base() { }

        #endregion

        #region Properties

        public double Speed {
            get { return speed; }
            set {
                if (value > 0.0) {
                    speed = value;
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
            return "Turtle";
        }

        /// <summary>
        /// Convert values to string
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            string text = base.ToString() + string.Format("{0,-20}", string.Concat("Speed: ", speed, " km/h"));
            return text;
        }

        #endregion
    }
}
