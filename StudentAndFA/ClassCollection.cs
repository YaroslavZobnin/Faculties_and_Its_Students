namespace StudentAndFA
{
    internal class ClassCollection<T> where T : class
    {
        private T[] array = Array.Empty<T>();
        public int CountElements => array.Length;
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else
                    throw new ArgumentOutOfRangeException("Индекс вышел за пределы массива объектов!");
            }
            set
            {
                if(index >= 0 && index <= array.Length)
                    array[index] = value;
            }
        }
        public void AddNewElementsInClassCollection(params T[] array)
        {
            T[] newArray = new T[this.array.Length + array.Length];
            for(int i = 0; i <this.array.Length; i++)
                newArray[i] = this.array[i];
            int j = 0;
            for(int i = 0; i < newArray.Length;i++)
                newArray[i] = array[j++];
            this.array = newArray;
        }
    }
}
