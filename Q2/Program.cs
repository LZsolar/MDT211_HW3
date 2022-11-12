class Program
{
    static void Main(string[] args)
    {
       Queue<int> q = new Queue<int>();
       while(true){
            char temp = char.Parse(Console.ReadLine());
            if(temp == 'L'){q.Push(1);}
            else if(temp == 'M'){q.Push(2);}
            else if(temp == 'S'){q.Push(3);}
            else{break;}
       }
       while(q.GetLength()!=0){
            int temp = q.Pop();
            Console.Write(temp);

            if(temp ==1){q.Push(2);q.Push(2);}
            else if(temp == 2){q.Push(3);q.Push(3);q.Push(3);}
       }
    }
}