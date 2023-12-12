namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
        }

        public class myClass<T> where T : struct
        {
            private List<T> list = new List<T>();

                public void AddList(T item)
            {
                list.Add(item);
            }
            public List<T> GetLi() 
            {
                list.ToList();
            }
            public List<T> SortList()
            {
                list.Sort().Tolist();
            }

        }

    }
}