namespace Generics
{
	public class StringList
	{
        private string[] stringArray;
        public StringList()
        {
            stringArray = Array.Empty<string>();
        }

        public void Add(string text)
        {
            Array.Resize(ref stringArray, stringArray.Length + 1);
            stringArray[stringArray.Length - 1] = text;
        }

        public string[] GetAll()
        {
            return stringArray;
        }
    }
}

