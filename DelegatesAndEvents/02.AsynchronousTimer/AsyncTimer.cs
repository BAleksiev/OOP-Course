using System;
using System.Threading;

namespace AsynchronousTimer
{
    class AsyncTimer
    {
        private uint ticks;
        private uint interval;
        private Action<int> method;

        public AsyncTimer(Action<int> method, uint ticks, uint interval)
        {
            this.ticks = ticks;
            this.interval = interval;
            this.method = method;
        }

        public void Initialize()
        {
            while (this.ticks > 0)
            {
                Thread.Sleep((int)this.interval);
                if (this.method != null)
                {
                    this.method((int)this.ticks);
                }
                this.ticks--;
            }
        }

        public void Run()
        {
            Thread thread = new Thread(this.Initialize);
            thread.Start();
        }
    }
}
