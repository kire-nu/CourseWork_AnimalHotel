//Erik Olofsson, 31/01/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    public class Chameleon : Reptile {

        #region Fields

        private string colour = string.Empty;
        private EaterType eaterType = EaterType.Carnivore;
        private string[] feedingschedule = new string[] {"The chameleon eats 10% of its weight in insects every day" };

        #endregion

        #region Constructors
        public Chameleon(string name, int age, Gender gender, double length, string colour)
            : base(name, age, gender, length) {
            this.colour = colour;
        }
        public Chameleon() : base() { }

        #endregion

        #region Properties

        public string Colour {
            get { return colour; }
            set { colour = value; }
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
            return "Chameleon";
        }

        /// <summary>
        /// Convert values to string
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            string text = base.ToString() + string.Format("{0,-20}", string.Concat("Colour: ", colour));
            return text;
        }

        #endregion
    }
}
