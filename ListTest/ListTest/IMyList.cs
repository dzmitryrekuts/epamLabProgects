using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTest
{
    interface IMyList
    {
        string GetName();
        void AddEnd(int count);
        void AddMiddle(int count);
        void AddBegin(int count);
        void DeleteEnd(int count);
        void DeleteMiddle(int count);
        void DeleteBegin(int count);
        void GetMiddleElem(int count, middleObject midObj);

    }
}
