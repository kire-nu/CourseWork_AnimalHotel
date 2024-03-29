﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1 {
    public class ListManager<T> : IListManager<T> {
        #region Fields

        private List<T> aList;

        #endregion

        #region Properties

        /// <summary>
        /// Get number of items in list
        /// </summary>
        public int Count {
            get { return aList.Count; }
        }

        #endregion

        #region Constructors
        public ListManager() {
            aList = new List<T>();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Add item to list
        /// </summary>
        /// <param name="aType"></param>
        /// <returns></returns>
        public bool Add(T aType) {
            aList.Add(aType);
            return true;
        }

        /// <summary>
        /// Change item at postion
        /// </summary>
        /// <param name="aType"></param>
        /// <param name="aIndex"></param>
        /// <returns></returns>
        public bool ChangeAt(T aType, int aIndex) {
            if (CheckIndex(aIndex)) {
                aList[aIndex] = aType;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Check that index is in range of list
        /// </summary>
        /// <param name="aIndex"></param>
        /// <returns></returns>
        public bool CheckIndex(int aIndex) {
            return (aIndex >= 0 && aIndex < Count);
        }

        /// <summary>
        /// Clear list
        /// </summary>
        /// <returns></returns>
        public bool DeleteAll() {
            aList = new List<T>();
            return true;
        }

        /// <summary>
        /// Delete Item at Location
        /// </summary>
        /// <param name="aIndex"></param>
        /// <returns></returns>
        public bool DeleteAt(int aIndex) {
            if (CheckIndex(aIndex)) {
                aList.RemoveAt(aIndex);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Return item at location
        /// </summary>
        /// <param name="aIndex"></param>
        /// <returns></returns>
        public T GetAt(int aIndex) {
            if (CheckIndex(aIndex)) {
                return aList[aIndex];
            }
            return default(T);
        }

        /// <summary>
        /// Get items in list as string list
        /// </summary>
        /// <returns></returns>
        public List<string> ToStringList() {
            List<string> textList = new List<string>();
            foreach (T aType in aList) {
                textList.Add(aType.ToString());
            }
            return textList;
        }

        /// <summary>
        /// Get items in list as string array
        /// </summary>
        /// <returns></returns>
        public string[] ToStringArray() {
            return ToStringList().ToArray();
        }


        #endregion

    }
}
