using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Ports;
using System.IO;

namespace RoboticArmGUI
{
    class Communication
    {

        SerialPort port;
        int portNum = 8;

        public void setPort(int port) {
            portNum = port;
        }

        public String readPort() {
            port.Open();
            String command = port.ReadLine().ToString();
            port.Close();
            return command;
        }

        public bool send(String message) {

            try
            {
                port = new SerialPort("COM" + portNum, 9600);
                port.DataBits = 8;
                port.StopBits = StopBits.One;
                port.Handshake = Handshake.None;
                port.Parity = Parity.None;
                port.Open();
                port.Write(message);
                port.Close();

                return true;
            }
            catch (Exception e) {
                return false;
            }
        }
    }
}
