using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace PC_Driver
{
    public partial class Dali_Driver : Form
    {

        #region Fields

        List<Panel> _listPanel = new List<Panel>();

        private BackgroundWorker _hardWorker;
        private Thread _readThread = null;
        private SerialPort _myPort = new SerialPort();
        delegate void SetTextCallback(string text);

        private int CONNECT_CMD = 999;

        

        #endregion

        #region Initialization

        public Dali_Driver()
        {
            _hardWorker = new BackgroundWorker();
            InitializeComponent();
           // OnProgramLaunch();
            //DetectComPorts();
            PopulateBaudComboBox();
            PopulateGroups();

            _listPanel.Add(blankPanel);
            _listPanel.Add(monoPanel);
            _listPanel[0].BringToFront();
        }

        private void OnProgramLaunch()
        {
            monoBox.Enabled = false;
            rgbBox.Enabled = false;
        }

        private void DetectComPorts()
        {
            foreach (string port in SerialPort.GetPortNames())
            {
                comComboBox.Items.Add(port);
            }
            if (comComboBox.Items.Count > 0)
                comComboBox.SelectedIndex = comComboBox.Items.Count - 1;
            else
                comComboBox.SelectedIndex = 0;
        }

        private void PopulateBaudComboBox()
        {
            baudComboBox.Items.Add("2400");
            baudComboBox.Items.Add("4800");
            baudComboBox.Items.Add("9600");
            baudComboBox.Items.Add("14400");
            baudComboBox.Items.Add("19200");
            baudComboBox.Items.Add("28800");
            baudComboBox.Items.Add("38400");
            baudComboBox.Items.Add("57600");
            baudComboBox.Items.Add("115200");

            baudComboBox.SelectedIndex = 2;
        }

        private void PopulateGroups()
        {
            for (int i = 0; i < 16; i++)
            {
                devicesTree.Nodes[1].Nodes.Add("Group " + i.ToString());
                devicesTree.Nodes[1].Nodes[i].Tag = "group";
            }
        }

        #endregion

        #region Connection Handler

        private void Init()
        {
            try
            {
                _myPort.BaudRate = Int32.Parse(baudComboBox.SelectedItem.ToString());
                //myPort.PortName = comComboBox.SelectedItem.ToString();
                _myPort.WriteTimeout = 500;
                _myPort.ReadTimeout = 5000;
                _myPort.Open();

                _readThread = new Thread(new ThreadStart(Read));
                _readThread.Start();
                _hardWorker.RunWorkerAsync();
                //    myPort.WriteLine("connecting");
                //  myPort.WriteLine(CONNECT_CMD.ToString());
                //Utility.WriteByteData(255, 0, myPort);
                _myPort.Write(new byte[] { 255, 1 }, 0, 2);
            }
            
            catch (Exception)
            {
                MessageBox.Show("Cannot connect to the Arduino!");
            }
        }
    
        public void Read()
        {
            while (_myPort.IsOpen)
            {
                try
                {
                    if (_myPort.BytesToRead > 0)
                    {
                        string message = _myPort.ReadLine();
                        SetText(message);
                        if (message[0] == 'c')
                            OnConnectionEstablished();
                    }
                }
                catch (TimeoutException) { }
            }
        }

        private void SetText(string text)
        {
            if (receiveText.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { text });
            }
            else
            {
                receiveText.Text += "Log: ";
                receiveText.Text += text;
                receiveText.Text += Environment.NewLine;
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (connectButton.Text == "Connect")
                Init();
            else
            {
                _myPort.Write("c");
                _myPort.Close();
                OnConnectionClosed();
            }
        }

        private void OnConnectionEstablished()
        {
            this.InvokeIfRequired((value) => scanButton.Enabled = value, true);
            this.InvokeIfRequired((value) => connectButton.Text = value, "Disconnect");
            this.InvokeIfRequired((value) => baudComboBox.Enabled = value, false);
            this.InvokeIfRequired((value) => comComboBox.Enabled = value, false);
            this.InvokeIfRequired((value) => monoBox.Enabled = value, true);
            this.InvokeIfRequired((value) => rgbBox.Enabled = value, true);
        }

        private void OnConnectionClosed()
        {
            try
            {
                if (!(_readThread == null))
                    _readThread.Abort();
            }
            catch (NullReferenceException)
            {
            }

            try
            {
                _myPort.Close();
            }
            catch (NullReferenceException)
            {
            }

            connectButton.Text = "Connect";
            scanButton.Enabled = false;
            baudComboBox.Enabled = true;
            comComboBox.Enabled = true;
            monoBox.Enabled = false;
            rgbBox.Enabled = false;
        }

        #endregion

        #region Mono Handler
        
        private void MonoTrackBar_Scroll(object sender, EventArgs e)
        {
            int firstByte = Utility.GetFirstByte(0, Utility.GetAddressFromNode(devicesTree), false);
            byte[] monoBrightness = new byte[2];
            monoBrightness[0] = (byte)firstByte;
            monoBrightness[1] = (byte)monoTrackBar.Value;

            DeviceForm.SetLogInfo(monoBrightness);
            Utility.ShowInTextbox(receiveText, monoBrightness);
            //_myPort.Write(monoBrightness, 0, 1);
        }

        #endregion

        #region RGB Handler

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorButton.BackColor = colorDialog.Color;
            }
        }

        #endregion

        #region Master Log

        private void ReceiveText_TextChanged(object sender, EventArgs e)
        {
            receiveText.SelectionStart = receiveText.Text.Length;
            receiveText.ScrollToCaret();
        }

        #endregion

        #region Panel Management

        private void DevicesTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text.Contains("Mono LED"))
                _listPanel[1].BringToFront();
            else
                _listPanel[0].BringToFront();
        }

        #endregion

        #region Device Tree Management

        private void AddMonoButton_Click(object sender, EventArgs e)
        {
            Device device = Utility.InstantiateDevice("mono");

            if (device != null)
            {
                devicesTree.Nodes[0].Nodes.Add(device.Name.ToString());

                foreach (TreeNode node in devicesTree.Nodes[0].Nodes)
                    node.Tag = "device";
            }
        }

        private void AddRGBButton_Click(object sender, EventArgs e)
        {
            Device device = Utility.InstantiateDevice("RGB");

            if (device != null)
            {
                devicesTree.Nodes[0].Nodes.Add(device.Name.ToString());

                foreach (TreeNode node in devicesTree.Nodes[0].Nodes)
                    node.Tag = "device";
            }
        }

        private void DevicesTree_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            
            TreeNode node = devicesTree.GetNodeAt(e.X, e.Y);
            devicesTree.SelectedNode = node;
            
            if (node == null) return;

            if (node.Tag is "device")
                deviceContext.Show(devicesTree, new Point(e.X, e.Y));
            else if (node.Tag is "devices")
                devicesContext.Show(devicesTree, new Point(e.X, e.Y));
            else if (node.Tag is "group")
                groupContext.Show(devicesTree, new Point(e.X, e.Y));
            else if (node.Tag is "groupDevice")
                removeContext.Show(devicesTree, new Point(e.X, e.Y));
        }

        private void DeviceContext_Opened(object sender, EventArgs e)
        {
            for (int j = 0; j < availGroupsContext.Items.Count; j++)
                availGroupsContext.Items.RemoveAt(j);

            ushort address = ushort.Parse(Regex.Match(devicesTree.SelectedNode.Text, @"\d+").Value);

            for (int i = 0; i < 16; i++)
            {
                if (Utility._device[address]._assignedGroups[i] == false)
                    availGroupsContext.Items.Add("Group " + i.ToString());
            }
        }

        private void DeleteDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ushort address = ushort.Parse(Regex.Match(devicesTree.SelectedNode.Text, @"\d+").Value);
            Utility._device[address] = null;
            Utility._addresses[address] = false;

            Utility._deviceForm[address].Close();
            devicesTree.SelectedNode.Remove();
        }

        private void GroupContext_Opened(object sender, EventArgs e)
        {
            for (int i = 0; i < availDevicesContext.Items.Count; i++)
                availDevicesContext.Items.RemoveAt(i);

            ushort number = ushort.Parse(Regex.Match(devicesTree.SelectedNode.Text, @"\d+").Value);

            for (int i = 0; i < 64; i++)
            {
                if (Utility._device[i] != null)
                    if (Utility._device[i]._assignedGroups[number] == false)
                        availDevicesContext.Items.Add(Utility._device[i].Name);
            }
        }

        private void AvailDevicesContext_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ushort number = ushort.Parse(Regex.Match(devicesTree.SelectedNode.Text, @"\d+").Value);
            ushort address = ushort.Parse(Regex.Match(e.ClickedItem.Text, @"\d+").Value);

            Utility._device[address]._assignedGroups[number] = true;
            Utility._deviceForm[address].UpdateGroups(Utility._device[address]);
            devicesTree.SelectedNode.Nodes.Add(Utility._device[address].Name);
            devicesTree.SelectedNode.LastNode.Tag = "groupDevice";
        }

        private void AvailGroupsContext_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ushort address = ushort.Parse(Regex.Match(devicesTree.SelectedNode.Text, @"\d+").Value);
            ushort number = ushort.Parse(Regex.Match(e.ClickedItem.Text, @"\d+").Value);

            Utility._device[address]._assignedGroups[number] = true;
            Utility._deviceForm[address].UpdateGroups(Utility._device[address]);
            devicesTree.Nodes[1].Nodes[number].Nodes.Add(Utility._device[address].Name);
        }

        private void RemoveFromGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ushort address = ushort.Parse(Regex.Match(devicesTree.SelectedNode.Text, @"\d+").Value);
            ushort number = ushort.Parse(Regex.Match(devicesTree.SelectedNode.Parent.Text, @"\d+").Value);

            Utility._device[address]._assignedGroups[number] = false;
            Utility._deviceForm[address].UpdateGroups(Utility._device[address]);
            devicesTree.SelectedNode.Remove();
        }


        #endregion
    }
}


public static class ControlExtensions
{

    #region Public Methods

    public static void InvokeIfRequired(this Control control, Action action)
    {
        if (control.InvokeRequired)
            control.Invoke(action);
        else
            action();
    }
    public static void InvokeIfRequired<T>(this Control control, Action<T> action, T parameter)
    {
        if (control.InvokeRequired)
            control.Invoke(action, parameter);
        else
            action(parameter);
    }

    #endregion

}