using System;
using System.Net.WebSockets;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;

namespace Basic_CSharp
{
    // Observer Pattern
    class Program
    {
        static void OnInputTest()
        {
            Console.WriteLine("Input Received!");
        }
        static void Main(string[] args)
        {
            InputManager inputManager = new InputManager();

            inputManager.InputKey += OnInputTest;
            
            while (true)
            {
                inputManager.Update();
            }
        }
    }
}