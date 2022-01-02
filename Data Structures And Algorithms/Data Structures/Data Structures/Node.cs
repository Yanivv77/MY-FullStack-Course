namespace Data_Structures
{
    internal class Node
    {
        public string _data { get; set; }
        public Node next { get;  set; }
        public Node prev { get; set; }

        public Node(string data)
        {
            _data = data;
            next = null;
            prev = null;
        }

        public void DisplayNode()
        {
            System.Console.Write("["+_data+"] ");
        }

        public override string ToString()
        {
            return "["+_data + "] " ;
        }
    }
}