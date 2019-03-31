using System;
using System.Windows.Forms;

namespace PC_Driver
{
    public partial class DeviceForm : Form
    {

        #region Fields

        Device _device;

        #endregion

        #region Public Methods

        public DeviceForm(Device Device)
        {
            _device = Device;
            InitializeComponent();
            OnWindowLaunch();
        }

        public void OnWindowLaunch()
        {
            nameLabel.Text = _device.Name;
            addressLabel.Text = _device.Address.ToString() + " - " + Convert.ToString(_device.Address, 2);
            typeLabel.Text = _device.Type;
        }

        public void UpdateGroups(Device Device)
        {
            Device._groups = "";
            for (int i = 0; i < 16; i++)
                Device._groups += (Device._assignedGroups[i] == true) ? i.ToString() + " " : "";
            groupsLabel.Text = Device._groups;
        }

        #endregion

    }

    public class Device
    {

        #region Fields

        private string _name;
        private ushort _address;
        private string _type;
        public bool[] _assignedGroups = new bool[16];
        public string _groups;

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return this._name;
            }
        }

        public int Address
        {
            get
            {
                return this._address;
            }
        }

        public string Type
        {
            get
            {
                return this._type;
            }
        }

        #endregion

        #region Public Methods

        public Device(ushort Address, string Type)
        {
            _name = (Type == "mono") ? "Mono" : "RGB";
            _name += " LED " + Address.ToString();
            _address = Address;
            _type = Type;

            for (int i = 0; i < 16; i++)
                _assignedGroups[i] = false;
        }

        #endregion

    }
} 
