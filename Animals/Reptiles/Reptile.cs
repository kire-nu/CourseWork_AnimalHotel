//Erik Olofsson, 31/01/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1 {
    public abstract class Reptile : Animal {

        #region Fields

        private double length = double.NaN;

        #endregion

        #region Constructors

        public Reptile(string name, int age, Gender gender, double length)
            : base(name, age, gender) {
                this.length = length;
        }
        public Reptile()
            : base() {
        }

        #endregion

        #region Properties

        public double Length {
            get { return length; }
            set {
                if (value > 0.0) {
                    length = value;
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
            return "Reptile";
        }

        /// <summary>
        /// Convert values to string
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            string text = base.ToString() + string.Format("{0,-20}", string.Concat("Length: ", Math.Round(length, 3), " m."));
            return text;
        }

        #endregion
    }
}

