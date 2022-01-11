using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Manager
{
    internal class QueueStarter
    {
        public static void StartQueue(List<Queue> queues)
        {
            new Thread(() =>
             {
                 while (true)
                 {
                     if (queues.Count == 0)
                         Thread.Sleep(1000);
                     else
                     {
                         queues[0].Start();

                         Thread.Sleep(queues[0].DelayTime);

                         queues.RemoveAt(0);
                     }
                 }
             }).Start();
        }
    }
}
