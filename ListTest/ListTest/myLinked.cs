using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTest
{
    class myLinked : IMyList
    {
        LinkedList<Object> linked = new LinkedList<Object>();

        private string NAME = "LinkedList";

        public myLinked(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                linked.AddFirst(new Object());
            }
        }

        string IMyList.GetName()
        {
            return NAME;
        }

        void IMyList.AddEnd(int count)
        {
            for (int i = 0; i < count; i++)
            {
                linked.AddLast(new Object());
            }
        }

        void IMyList.AddBegin(int count)
        {
            for (int i = 0; i < count; i++)
            {
                linked.AddFirst(new Object());
            }
        }

        void IMyList.AddMiddle(int count)
        {
            for (var i = 0; i < count; i++)
            {
                var tempNode = linked.First;
                for (var k = 0; k < linked.Count / 2; k++)
                {
                    tempNode = tempNode.Next;
                }
                linked.AddAfter(tempNode, new middleObject()); 
            }


        }

        void IMyList.DeleteBegin(int count)
        {
            for (int i = 0; i < count; i++)
            {
                linked.RemoveFirst();
            }
        }

        void IMyList.DeleteEnd(int count)
        {
            for (int i = 0; i < count; i++)
            {
                linked.RemoveLast();
            }
        }

        void IMyList.DeleteMiddle(int count)
        {
            for (var i = 0; i < count; i++)
            {
                var tempNode = linked.First;
                for (var k = 0; k < linked.Count / 2; k++) 
                {
                    tempNode = tempNode.Next;
                }
                linked.Remove(tempNode);
            }
        }

        void IMyList.GetMiddleElem(int count, middleObject midObj)
        {
            for (int i = 0; i < count; i++)
            {
               var result =  linked.Find(midObj);
               
            }
        }
    }
}
