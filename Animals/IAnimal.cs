//Erik Olofsson, 24/02/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1 {
    interface IAnimal {

        #region Properties

        string Name {
            get; set;
        }
        int Age {
            get; set;
        }
        Gender Gender {
            get; set;
        }
        string ID {
            get;
        }

        #endregion

        #region Methods

        EaterType GetEaterType();

        FoodSchedule GetFoodSchedule();

        string GetSpecies();

        string GetCategory();

        #endregion
    }
}
