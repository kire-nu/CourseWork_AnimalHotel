//Erik Olofsson, 31/01/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1 {
    public class FoodSchedule {

        #region Fields

        List<string> foodDescriptionList;

        #endregion

        #region Constructors

        public FoodSchedule() {
            foodDescriptionList = new List<string>();
        }

        public FoodSchedule(List<string> foodList) {
            foodDescriptionList = foodList;
        }

        #endregion

        #region Properties

        public int Count {
            get { return foodDescriptionList.Count; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Add item to food schedule
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AddFoodScheduleItem(string item) {
            foodDescriptionList.Add(item);
            return true;
        }

        /// <summary>
        /// Change item in food schedule
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool ChangeFoodDescriptionItem(string item, int index) {
            if (ValidateIndex(index)) {
                foodDescriptionList[index] = item;
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// Delete item at index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteFoodDescriptionItem(int index) {
            if (ValidateIndex(index)) {
                foodDescriptionList.RemoveAt(index);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Text when no feeding is required
        /// </summary>
        /// <returns></returns>
        public string DescribeNoFeedingRequired() {
            return "No feeding Required";
        }

        /// <summary>
        /// Get schedule at index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetFoodSchedule(int index) {
            if (ValidateIndex(index)) {
                return foodDescriptionList[index];
            }
            return string.Empty;
        }

        /// <summary>
        /// Return list as a string
        /// </summary>
        /// <returns></returns>
        public string ToString() {
            string text = string.Empty;
            foreach (string line in foodDescriptionList) {
                text += line + "\r\n";
            }
            return text;
        }

        /// <summary>
        /// Make sure index is in valid range
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool ValidateIndex(int index) {
            if (index>=0 && index<=foodDescriptionList.Count) {
                return true;
            } else {
                return false;
            }
        }


        #endregion
    }
}
