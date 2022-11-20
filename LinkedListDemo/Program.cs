namespace LinkedListDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(70);
            linkedList.DataAtParticularPosition(1, 30);
            linkedList.Display();
        }
    }
}