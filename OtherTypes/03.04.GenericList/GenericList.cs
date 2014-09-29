using System;
using System.Text;

namespace GenericList
{
    [Version(2, 5)]
    public class GenericList<T> where T : IComparable<T>
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

        public T FindAt(int index)
        {
            if (index < 0 || index >= this.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return this.elements[index];
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= this.Length)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < this.Length - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.length--;
            this.elements[this.Length] = default(T);
        }

        public void Insert(int index, T element)
        {
            if (index < 0 || index >= this.Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (this.Length >= this.Capacity)
            {
                this.Expand();
            }

            for (int i = this.Length; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.length++;
            this.elements[index] = element;
        }

        public void Clear()
        {
            this.elements = new T[this.Capacity];
            this.length = 0;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this.Length; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T element)
        {
            if (this.IndexOf(element) != -1)
            {
                return true;
            }

            return false;
        }

        public T Min()
        {
            if (this.Length < 1)
            {
                throw new InvalidOperationException("Empty list!");
            }

            T min = this.elements[0];

            for (int i = 0; i < this.Length; i++)
            {
                if (this.elements[i].CompareTo(min) < 0)
                {
                    min = this.elements[i];
                }
            }

            return min;
        }

        public T Max()
        {
            if (this.Length < 1)
            {
                throw new InvalidOperationException("Empty list!");
            }

            T max = this.elements[0];

            for (int i = 0; i < this.Length; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }
            }

            return max;
        }

        private void Expand()
        {
            T[] newArr = new T[this.Capacity * 2];
            Array.Copy(this.elements, newArr, this.Capacity);
            this.elements = newArr;
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
