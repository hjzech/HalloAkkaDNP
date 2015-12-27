using System;
using System.Threading;
using Akka.Actor;

namespace HalloAkkaDNP
{
    internal class PingPongActor : ReceiveActor
    {
        public PingPongActor()
        {
            Console.WriteLine("Actor: " + Thread.CurrentThread.ManagedThreadId);
            Receive<Nachricht>(n => Console.WriteLine("ping {0}", n.Txt));
        }
    }

}