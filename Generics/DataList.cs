namespace Generics
{
	public class DataList <T>
	{
        private T[] dataArray;
        public DataList()
        {
            dataArray = Array.Empty<T>();
        }

        public void Add(T datas)
        {
            Array.Resize(ref dataArray, dataArray.Length + 1);
            dataArray[dataArray.Length - 1] = datas;
        }

        public T[] GetAll()
        {
            return dataArray;
        }

        public void Delete(T data)
        { 
           var datas = GetAll();
           dataArray = datas.Where(m => !m.Equals(data)).ToArray();
        }
    }
}

