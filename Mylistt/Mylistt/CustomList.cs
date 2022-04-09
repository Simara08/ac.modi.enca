using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Mylistt
{
    class CustomList<T>where T:class
    {
        private static int _capacity;
        public int Capacity { get => _capacity; set=> value=_capacity; }
       
        public int Count  { get; set; }
        public T[] Lisst;
        public int Index = 0;
        public CustomList(int capacity)
        {
            Capacity = capacity;
            Lisst = new T[Capacity];
        }
        public void Add(T item)
        {
            Resize();
            Lisst[Count] = item;
            Count++;

        }
        private void Resize()
        {
            if (Capacity==0)
            {
                Array.Resize(ref Lisst, 1);
            }
            if (Count==Lisst.Length)
            {
                if (Capacity==0)
                {
                    Array.Resize(ref Lisst, Lisst.Length * 2);
                }
                else
                {
                    Array.Resize(ref Lisst, Lisst.Length * +Capacity);
                }
            }
        }
        public T this[int index] {
            get
            {
                if (index > Lisst.Length - 1)
                {
                    throw new OutOfCapasityException("This index is not exist");
                }
                else if (Lisst[index] == null)
                {
                    throw new EmptyBookException("This index is not set");
                }
                return Lisst[index];
            }
            set
            {
                if (index<=Lisst.Length-1 && Lisst[index] == null)
                {
                    Lisst[index] = value;
                }

            }
        }
        public bool Isex=false;
        public bool Contain(T member)
        {
            for (int i = 0; i < Lisst.Length; i++)
            {
                if (Lisst[i]==member)
                {
                    Isex = true;
                }
            }
            if (Isex==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Clear()
        {
            for (int i = 0; i < Lisst.Length; i++)
            {
                Lisst[i] = null;    
            }
        }
        public void Removve(int index)
        {
            int n = -1;
            for (int i = 0; i < Lisst.Length; i++)
            {
                if (i==index)
                {
                    Lisst[i] = Lisst[n];
                }
            }
        }
        public void Removve(T member)
        {
            for (int i = 0; i < Lisst.Length; i++)
            {
                if (Lisst[i]==member)
                {
                    Lisst[i] = null;
                    break;
                }
            }
        }

    }

   
}
