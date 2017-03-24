using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Ports;

namespace MySerialPort
{
    class Program
    {
        static bool _continue;
        static SerialPort _myserialPort;

        static void Main(string[] args)
        {
            Thread readThread = new Thread(Read);
            _myserialPort = new SerialPort("COM3", 115200, 0, 8, StopBits.One);

            _myserialPort.ReadTimeout = 500;
            _myserialPort.WriteTimeout = 500;

            _myserialPort.Open();
            _continue = true;

            if (_myserialPort.IsOpen)
                Console.WriteLine("Connected.");

            readThread.Start();           

        }

        public static void Read()
        {
            while (_continue)
            {
                try
                {
                    string message = _myserialPort.ReadLine();
                    Console.WriteLine("Received data:{0}",message);
                    Console.WriteLine("OK\n");
                    for (int i = 0; i < 1000000; i++)
                    {

                    }
                }
                catch (TimeoutException) { }
            }
        }
    }
}
