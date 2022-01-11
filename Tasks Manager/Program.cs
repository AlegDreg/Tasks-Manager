namespace Tasks_Manager
{
    public static class Program
    {
        public static List<Queue> queues = new List<Queue>();

        public static void Main(string[] args)
        {
            SomeActions someActions = new SomeActions();

            queues.Add(new Queue() { DelayTime = 2 * 1000, Task = someActions.Action1 });
            queues.Add(new Queue() { DelayTime = 10 * 1000, Task = someActions.Action2 });
            queues.Add(new Queue() { DelayTime = 10 * 1000, Task = someActions.Action2 });

            QueueStarter.StartQueue(queues);

            Console.ReadKey();

            queues.Add(new Queue() { DelayTime = 10 * 1000, Task = someActions.Action2 });
        }
    }
}