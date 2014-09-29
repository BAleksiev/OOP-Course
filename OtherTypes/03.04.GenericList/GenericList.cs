using System;
using System.Text;

namespace GenericList
{
    class GenericList<T>
    {
        const int DefaultCapacity = 64;

        private T[] elements;
        private int length = 0;

        public GenericList(int capacity = DefaultCapacity)
        {
            elements = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Capacity)
                {
                    throw new IndexOutOfRangeException();
                }
                return elements[index];
            }
        }

        public int Length
        {
            get { return this.length; }
        }

        public int Capacity
        {
            get { return this.elements.Length; }
        }

        public void Add(T element)
        {
            if (this.Length >= this.Capacity)
            {
                this.Expand();
            }

            this.elements[this.Length] = element;
            this.length++;
        }

        // change name
        //public T Access()
        //{

        //}

        //public void Remove()
        //{

        //}

        //public void Insert()
        //{

        //}

        //public void Clear()
        //{

        //}

        //public T Find()
        //{

        //}

        //public bool Contains()
        //{

        //}

        private void Expand()
        {

        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.Length; i++)
            {
                result.AppendLine(this.elements[i].ToString());
            }

            return result.ToString();
        }
    }
}
