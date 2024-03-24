using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Work4_2
{
    public delegate void EventHandler(object sender, EventArgs e);
    public class EventArgs { 
        public int A { get; set; }
    }

    public class Clock
    {
        public event EventHandler Tick;
        public event EventHandler Alarm;
        private int times;

        public Clock(int a) 
        {
            times = a;
            EventArgs eventArgs = new EventArgs()
            {
                A = a
            };
        }

        public void Start() 
        {
            Console.WriteLine("闹钟开始运行");
            for (int i = 0; i < times; i++)
            {
                OnTick();
                Console.WriteLine($"第{i + 1}秒");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            OnAlarm();
        }

        public void OnTick()
        {
            EventArgs eventArgs = new EventArgs();
            if (Tick != null)
            {
                Tick(this, eventArgs);
            }
        }

        public void OnAlarm()
        {
            EventArgs eventArgs = new EventArgs();
            if(Alarm != null)
            {
                Alarm(this, eventArgs);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock clock=new Clock(12);
            clock.Tick += (sender, e) => Console.WriteLine("滴答滴答...");
            clock.Alarm += (sender, e) => Console.WriteLine("闹钟铃声响了...");
            clock.Start();
            //Console.ReadKey();
        }
    }
}
