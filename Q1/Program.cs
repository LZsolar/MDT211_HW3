class Program
{
    static void Main(string[] args)
    {
       CircularLinkedList<char> list = new CircularLinkedList<char>();
       while(true){
            bool canAdd = true;
            char n = char.Parse(Console.ReadLine());
            if(n!='J'&& n!='G' && n!='O' && n!='R'){break;}
           
            if(n=='J'||n=='O'||n=='G'){canAdd= list.checkRiftail(n);}
            if(n=='G'&&canAdd){
                canAdd = list.checkG();
            }
            else if(n=='R'){canAdd = list.checkRforinsert();}

            if(canAdd){list.Add(n);}
            else{Console.WriteLine("Invalid pattern.");}
       }list.printList();
    }
}