using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTest
{
    class myArray : IMyList
    {
        private string NAME = "ArrayList";
        public ArrayList array = new ArrayList();

        public myArray(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                array.Add(new Object());
            }
        }

        string IMyList.GetName()
        {
            return NAME;
        }

        void IMyList.AddEnd(int count)
        {
            for (int i = 0; i < count ;i++)
            {
                array.Add(new Object());
            }
        }

        void IMyList.AddBegin(int count)
        {
            for (int i = 0; i < count; i++)
            {
                array.Insert(0,new Object());
            }
        }

        void IMyList.AddMiddle(int count)
        {
            for (int i = 0; i < count; i++)
            {
                array.Insert(array.Count/2, new middleObject());
            }
        }

        void IMyList.DeleteBegin(int count)
        {
            for (int i = 0; i < count; i++)
            {
                array.Remove(0);
            }
        }

        void IMyList.DeleteEnd(int count)
        {
            for (int i = 0; i < count; i++)
            {
                array.Remove(array.Count);
            }
        }

        void IMyList.DeleteMiddle(int count)
        {
            for (int i = 0; i < count; i++)
            {
                array.Remove(array.Count/2);
            }
        }

        void IMyList.GetMiddleElem(int count, middleObject midObj)
        {
            for (int i = 0; i < count; i++)
            {
                var result = array.IndexOf(midObj);
            }
        }
    }
}
