class Queue {
    int front, rear, capacity;
    int[] queue;

   //Constructor to intialize the queue
    Queue(int c){
        front = 0;
        rear=-1;
        capacity = c;
        queue = new int[capacity];
    }
    void Enqueue(int data)
    {
        if(rear == capacity-1)
        {
            Console.WriteLine("Queue is full");
            return;
        }
        //insert element at queue
        queue[++rear] = data;

    }
    void Dequeue(){
        if(front > rear){
            Console.WriteLine("Queue is empty");
            return;
        }
        for(int i=0; i<rear; i++){
            queue[i] = queue[i+1];
        }
        rear--;
    }
    void Front(){
        if(rear == -1){
            Console.WriteLine("Queue is empty");
        }
        Console.WriteLine("Front element is "+ queue[front]);
    }

    public static void Main(string[] args){
        Queue q = new Queue();
        q.Enqueue(4);
        q.Dequeue();
        q.Front();
    }
}