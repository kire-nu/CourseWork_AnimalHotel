//Erik Olofsson, 31/01/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    public abstract class Mammal : Animal {

        #region Fields

        private double weight = double.NaN;

        #endregion

        #region Constructors

        public Mammal(string name, int age, Gender gender, double weight)
            : base(name, age, gender) {
                this.weight = weight;
        }
        public Mammal() : base() { }

        #endregion

        #region Properties

        public double Weight {
            get { return weight; }
            set {
                if (value > 0.0) {
                    weight = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get animal Category
        /// </summary>
        /// <returns></returns>
        public override string GetCategory() {
            return "Mammal";
        }

        /// <summary>
        /// Convert values to string
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            string text = base.ToString() + string.Format("{0,-20}", string.Concat("Weight: ", Math.Round(weight, 3), " kg."));
            return text;
        }

        #endregion
    }
}
