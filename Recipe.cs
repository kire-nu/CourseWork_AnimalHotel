using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1 {
    public class Recipe {

        #region Fields

        private ListManager<string> ingredients;
        private string name = string.Empty;

        #endregion

        #region Constructors

        public Recipe() {
            ingredients = new ListManager<string>();
        }

        #endregion

        #region Properties

        public ListManager<string> Ingredients {
            get { return ingredients; }
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Convert values to string
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            string text = string.Concat(name, ": ", string.Join(", ", ingredients.ToStringArray()));
            return text;
        }

        #endregion
    }
}
