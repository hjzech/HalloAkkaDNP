using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Akka.Actor;

namespace HalloAkkaDNP
{
    class Program
    {
        static void Main(string[] args)
        {
            var system = ActorSystem.Create("DotNetProActorSystem");
            var pingPongActor = system.ActorOf<PingPongActor>("pingpong");
            pingPongActor.Tell(new Nachricht("Pong"));
            Console.WriteLine("Server: " + Thread.CurrentThread.ManagedThreadId);
            Console.ReadLine();
        }
    }
}
