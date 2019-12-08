using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1 {
    public class Staff {

        #region Fields

        private IListManager<string> qualifications;
        private string name = string.Empty;

        #endregion

        #region Constructors

        public Staff() {
            qualifications = new ListManager<string>();
        }

        #endregion

        #region Properties

        public IListManager<string> Qualifications {
            get { return qualifications; }
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
            string text = string.Concat(name, ": ", string.Join(", ", qualifications.ToStringArray()));
            return text;
        }

        #endregion
    }
}
