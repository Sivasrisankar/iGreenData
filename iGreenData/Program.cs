using System;
using System.Diagnostics;

namespace Test.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            ToyRobotSimulation simulation = new();
            simulation.ExecuteCommand("PLACE 0,0,NORTH");
            simulation.ExecuteCommand("MOVE");
            simulation.ExecuteCommand("REPORT");

            Console.WriteLine("Press any key to Exit...");
            Console.ReadLine();
        }
    }
}