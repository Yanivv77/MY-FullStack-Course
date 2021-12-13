namespace LinkedList
{
    public class LinkedList
    {
        public Item head;


        public LinkedList()
        {
            head = null;
        }


        public void AddNewItem(string name, int price)
        {
            Item newItem = new Item(name, price);

            if (head == null)
            {
                head = newItem;
                return;
            }

            else
            {

                Item currentItem = head;

                while (currentItem.next != null)
                {

                    currentItem = currentItem.next;

                }

                newItem.prev = currentItem;
                currentItem.next = newItem;


            }

        }

        public void RemoveLast()
        {

            Item currentItem = head;

            while (currentItem.next.next != null)
            {
                currentItem = currentItem.next;
            }

            currentItem.next = null;
            System.Console.WriteLine();
            PrintList();

        }

        public void RemoveByName(string name)
        {

            Item currentItem = head;


            if (currentItem._name == name) // name is first
            {
                head = head.next;

                System.Console.WriteLine("");
                System.Console.WriteLine(name + " found and deleted ");
                PrintList();
                return;

            }

            while (currentItem.next != null && currentItem._name != name) //name is mid 
            {
                currentItem = currentItem.next;
            }

            if (currentItem._name == name) // Unlink currentItem
            {
                currentItem.prev.next = currentItem.next;
                currentItem.next.prev = currentItem.prev;
                System.Console.WriteLine("");
                System.Console.WriteLine(name + " found and deleted ");
            }

            if (currentItem.next == null) // not found 
            {
                System.Console.WriteLine("");
                System.Console.WriteLine(name + " not found");
            }
            PrintList();
        }


        public void PrintList()
        {
            System.Console.WriteLine();
            Item currentItem = head;

            while (currentItem != null)
            {
                System.Console.Write(currentItem.ToString() + " ----> ");
                currentItem = currentItem.next;
            }
        }



    }
}
