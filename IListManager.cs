using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1 {
    public interface IListManager<T> {

        #region Methods

        bool Add(T aType);

        bool ChangeAt(T aType, int aIndex);

        bool CheckIndex(int aIndex);

        bool DeleteAll();

        bool DeleteAt(int aIndex);

        T GetAt(int aIndex);

        string[] ToStringArray();

        List<string> ToStringList();

        #endregion

    }
}
