using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Manager
{
    public class Queue
    {
        /// <summary>
        /// Delay in milliseconds
        /// </summary>
        public int DelayTime { get; set; }

        public delegate void Action();
        public Action Task;

        public void Start()
        {
            Task();
        }
    }
}
