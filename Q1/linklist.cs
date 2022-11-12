class CircularLinkedList<T> where T : struct
{
    private Node<T> head = null;    
    private int length = 0;
    private Node<T> beforetail = null;
    private Node<T> tail = null;

    public void Add(char value)
    {
        Node<T> node = new Node<T>(value);
        node.SetNext(this.head);
        if(this.head == null)
        {
            this.head = node;
            this.tail = node;
        }
        else
        {
            int index = this.length;
            Node<T> ptr = this.head;
            while(index > 1)
            {      
                ptr = ptr.Next();
                index--;
            }
            ptr.SetNext(node);
            this.beforetail = ptr;
            this.tail = node;
        }
        this.length++;
    }
    public void printList(){
        int index = this.length;
            Node<T> ptr = this.head;
            while(index > 0)
            {   
                Console.Write(ptr.GetValue());
                ptr = ptr.Next();
                index--;
            }
    }

    public bool checkG(){
        if(this.length >= 3){
            int index = this.length-3;
            if(index<0){index=0;}
            Node<T> ptr = this.head;
            while(index > 0)
            {
                ptr = ptr.Next();
                index--;
            }
            int countG=0;
            index = 6;          //ตรวจ 3 ตัวหลัง 3 ตัวหน้า
            while(index > 0)
            {
                if(ptr.GetValue()=='G'){countG++;}
                else{countG=0;}

                if(countG == 3){return false;}
                ptr = ptr.Next();
                index--;
            }
        }

        return true;
    }

    public bool checkRforinsert(){
        if(this.length<2){return false;}
        if(this.tail.GetValue()==this.head.GetValue()){return false;}

        return true;
    }
    public bool checkRiftail(char n){
        if(this.length<2){return true;}
        if(this.tail.GetValue()!='R'){return true;}
        if(this.beforetail.GetValue()==n){return false;}

        return true;
    }

}