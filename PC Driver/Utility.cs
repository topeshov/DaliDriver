using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System;

namespace PC_Driver
{
    public class Utility
    {

        #region Fields
        
        public static bool[] _addresses = new bool[64];
        public static DeviceForm[] _deviceForm = new DeviceForm[64];
        public static Device[] _device = new Device[64];

        #endregion

        #region Public Methods

        public static Device InstantiateDevice(string Type)
        {
            ushort assignedAddress = ReturnAddress();

            if (assignedAddress == 999)
            {
                MessageBox.Show("Cannot add any more devices!");
                return null;
            }
                
            _device[assignedAddress] = new Device(assignedAddress, Type);
            _deviceForm[assignedAddress] = new DeviceForm(_device[assignedAddress]);
            _deviceForm[assignedAddress].Show();
            _deviceForm[assignedAddress].Name = _device[assignedAddress].Name.ToString();

            return _device[assignedAddress];
        }

        public static ushort ReturnAddress()
        {
            for (ushort i = 0; i < 64; i++)
            {
                if (_addresses[i] == false)
                {
                    _addresses[i] = true;
                    return i;
                }
            }

            return 999;
        }

        public static string IntToBinary(int number)
        {
            const int mask = 1;
            var binary = string.Empty;
            while (number > 0)
            {
                binary = (number & mask) + binary;
                number = number >> 1;
            }

            return binary.PadLeft(8, '0');
        }

        public static ushort GetAddressFromNode(TreeView Tree)
        {
            ushort Address;
            Address = ushort.Parse(Regex.Match(Tree.SelectedNode.Text, @"\d+").Value);

            return Address;
        }

        public static int GetFirstByte(int S, int Address, bool isGroup)
        {
            int firstByte = 0;
            int Y = 0;

            if (isGroup)
            {
                Y = 1;
                firstByte = (int)(Y << 7) + (int)(Address << 1) + S;
            }
            else
            {
                firstByte = (int)(Y << 7) + (int)(Address << 1) + S;
            }

            return firstByte;
        }

        public static void WriteByteData(int command, int data, SerialPort port)
        {
            byte[] dataByte = new byte[1];
            dataByte[0] = (byte)command;
            dataByte[1] = (byte)data;
            port.Write(dataByte, 0, dataByte.Length);
        }

        public static void ShowInTextbox(TextBox textBox, byte[] data)
        {
            textBox.Text += "Address: ";
            textBox.Text += Utility.IntToBinary(data[0]);
            textBox.Text += Environment.NewLine;
            textBox.Text += "Command: ";
            textBox.Text += Utility.IntToBinary(data[1]);
            textBox.Text += Environment.NewLine;
            textBox.Text += Environment.NewLine;
        }

        #endregion

    }
}
