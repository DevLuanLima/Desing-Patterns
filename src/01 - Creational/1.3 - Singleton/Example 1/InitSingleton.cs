﻿namespace DesignPatterns._01___Creational._1._3___Singleton.Example_1
{
    public class InitSingleton
    {
        public static void Executar()
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same Instance\n");
            }

            var balancer = LoadBalancer.GetLoadBalancer();

            for (var i = 0; i < 15; i++)
            {
                var serverName = balancer.NextServer.Name;
                Console.WriteLine("Triggering request for: " + serverName);
            }
        }
    }
}
