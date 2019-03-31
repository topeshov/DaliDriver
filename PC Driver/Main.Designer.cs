namespace PC_Driver
{
    partial class Dali_Driver
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Devices");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Groups");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Broadcast");
            this.connectionBox = new System.Windows.Forms.GroupBox();
            this.receiveText = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.comLabel = new System.Windows.Forms.Label();
            this.comComboBox = new System.Windows.Forms.ComboBox();
            this.baudLabel = new System.Windows.Forms.Label();
            this.baudComboBox = new System.Windows.Forms.ComboBox();
            this.monoBox = new System.Windows.Forms.GroupBox();
            this.monoTestButton3 = new System.Windows.Forms.Button();
            this.monoTestButton2 = new System.Windows.Forms.Button();
            this.monoTestButton1 = new System.Windows.Forms.Button();
            this.monoTestLabel3 = new System.Windows.Forms.Label();
            this.monoTestLabel2 = new System.Windows.Forms.Label();
            this.monoTestLabel1 = new System.Windows.Forms.Label();
            this.monoBrightnessLabel = new System.Windows.Forms.Label();
            this.monoTrackBar = new System.Windows.Forms.TrackBar();
            this.rgbBox = new System.Windows.Forms.GroupBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.rgbTestButton3 = new System.Windows.Forms.Button();
            this.rgbTestButton2 = new System.Windows.Forms.Button();
            this.rgbTestButton1 = new System.Windows.Forms.Button();
            this.rgbTestLabel3 = new System.Windows.Forms.Label();
            this.rgbTestLabel2 = new System.Windows.Forms.Label();
            this.rgbTestLabel1 = new System.Windows.Forms.Label();
            this.rgbApplyButton = new System.Windows.Forms.Button();
            this.rbgBrightnessLabel = new System.Windows.Forms.Label();
            this.rgbTrackBar = new System.Windows.Forms.TrackBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addMonoButton = new System.Windows.Forms.Button();
            this.addRGBButton = new System.Windows.Forms.Button();
            this.monoPanel = new System.Windows.Forms.Panel();
            this.blankPanel = new System.Windows.Forms.Panel();
            this.devicesTree = new System.Windows.Forms.TreeView();
            this.scanButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deviceContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeviceToGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availGroupsContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addDevicesToGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availDevicesContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.devicesContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monoDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFromGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionBox.SuspendLayout();
            this.monoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monoTrackBar)).BeginInit();
            this.rgbBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbTrackBar)).BeginInit();
            this.mainTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.monoPanel.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.deviceContext.SuspendLayout();
            this.groupContext.SuspendLayout();
            this.devicesContext.SuspendLayout();
            this.removeContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionBox
            // 
            this.connectionBox.Controls.Add(this.receiveText);
            this.connectionBox.Controls.Add(this.connectButton);
            this.connectionBox.Controls.Add(this.comLabel);
            this.connectionBox.Controls.Add(this.comComboBox);
            this.connectionBox.Controls.Add(this.baudLabel);
            this.connectionBox.Controls.Add(this.baudComboBox);
            this.connectionBox.Location = new System.Drawing.Point(45, 60);
            this.connectionBox.Name = "connectionBox";
            this.connectionBox.Size = new System.Drawing.Size(692, 178);
            this.connectionBox.TabIndex = 2;
            this.connectionBox.TabStop = false;
            this.connectionBox.Text = "Connection";
            // 
            // receiveText
            // 
            this.receiveText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receiveText.Location = new System.Drawing.Point(467, 44);
            this.receiveText.Multiline = true;
            this.receiveText.Name = "receiveText";
            this.receiveText.ReadOnly = true;
            this.receiveText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receiveText.Size = new System.Drawing.Size(198, 106);
            this.receiveText.TabIndex = 7;
            this.receiveText.TextChanged += new System.EventHandler(this.ReceiveText_TextChanged);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(288, 63);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(144, 60);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // comLabel
            // 
            this.comLabel.AutoSize = true;
            this.comLabel.Location = new System.Drawing.Point(32, 98);
            this.comLabel.Name = "comLabel";
            this.comLabel.Size = new System.Drawing.Size(66, 17);
            this.comLabel.TabIndex = 5;
            this.comLabel.Text = "Com Port";
            // 
            // comComboBox
            // 
            this.comComboBox.FormattingEnabled = true;
            this.comComboBox.Location = new System.Drawing.Point(106, 95);
            this.comComboBox.Name = "comComboBox";
            this.comComboBox.Size = new System.Drawing.Size(121, 24);
            this.comComboBox.TabIndex = 4;
            // 
            // baudLabel
            // 
            this.baudLabel.AutoSize = true;
            this.baudLabel.Location = new System.Drawing.Point(32, 50);
            this.baudLabel.Name = "baudLabel";
            this.baudLabel.Size = new System.Drawing.Size(58, 17);
            this.baudLabel.TabIndex = 3;
            this.baudLabel.Text = "Bit Rate";
            // 
            // baudComboBox
            // 
            this.baudComboBox.FormattingEnabled = true;
            this.baudComboBox.Location = new System.Drawing.Point(106, 47);
            this.baudComboBox.Name = "baudComboBox";
            this.baudComboBox.Size = new System.Drawing.Size(121, 24);
            this.baudComboBox.TabIndex = 2;
            // 
            // monoBox
            // 
            this.monoBox.Controls.Add(this.monoTestButton3);
            this.monoBox.Controls.Add(this.monoTestButton2);
            this.monoBox.Controls.Add(this.monoTestButton1);
            this.monoBox.Controls.Add(this.monoTestLabel3);
            this.monoBox.Controls.Add(this.monoTestLabel2);
            this.monoBox.Controls.Add(this.monoTestLabel1);
            this.monoBox.Controls.Add(this.monoBrightnessLabel);
            this.monoBox.Controls.Add(this.monoTrackBar);
            this.monoBox.Location = new System.Drawing.Point(22, 24);
            this.monoBox.Name = "monoBox";
            this.monoBox.Size = new System.Drawing.Size(317, 305);
            this.monoBox.TabIndex = 3;
            this.monoBox.TabStop = false;
            this.monoBox.Text = " Mono";
            // 
            // monoTestButton3
            // 
            this.monoTestButton3.Location = new System.Drawing.Point(142, 253);
            this.monoTestButton3.Name = "monoTestButton3";
            this.monoTestButton3.Size = new System.Drawing.Size(75, 23);
            this.monoTestButton3.TabIndex = 8;
            this.monoTestButton3.Text = "Play";
            this.monoTestButton3.UseVisualStyleBackColor = true;
            // 
            // monoTestButton2
            // 
            this.monoTestButton2.Location = new System.Drawing.Point(142, 224);
            this.monoTestButton2.Name = "monoTestButton2";
            this.monoTestButton2.Size = new System.Drawing.Size(75, 23);
            this.monoTestButton2.TabIndex = 7;
            this.monoTestButton2.Text = "Play";
            this.monoTestButton2.UseVisualStyleBackColor = true;
            // 
            // monoTestButton1
            // 
            this.monoTestButton1.Location = new System.Drawing.Point(142, 193);
            this.monoTestButton1.Name = "monoTestButton1";
            this.monoTestButton1.Size = new System.Drawing.Size(75, 23);
            this.monoTestButton1.TabIndex = 6;
            this.monoTestButton1.Text = "Play";
            this.monoTestButton1.UseVisualStyleBackColor = true;
            // 
            // monoTestLabel3
            // 
            this.monoTestLabel3.AutoSize = true;
            this.monoTestLabel3.Location = new System.Drawing.Point(16, 256);
            this.monoTestLabel3.Name = "monoTestLabel3";
            this.monoTestLabel3.Size = new System.Drawing.Size(74, 17);
            this.monoTestLabel3.TabIndex = 5;
            this.monoTestLabel3.Text = "Play test 3";
            // 
            // monoTestLabel2
            // 
            this.monoTestLabel2.AutoSize = true;
            this.monoTestLabel2.Location = new System.Drawing.Point(16, 227);
            this.monoTestLabel2.Name = "monoTestLabel2";
            this.monoTestLabel2.Size = new System.Drawing.Size(74, 17);
            this.monoTestLabel2.TabIndex = 4;
            this.monoTestLabel2.Text = "Play test 2";
            // 
            // monoTestLabel1
            // 
            this.monoTestLabel1.AutoSize = true;
            this.monoTestLabel1.Location = new System.Drawing.Point(16, 196);
            this.monoTestLabel1.Name = "monoTestLabel1";
            this.monoTestLabel1.Size = new System.Drawing.Size(74, 17);
            this.monoTestLabel1.TabIndex = 3;
            this.monoTestLabel1.Text = "Play test 1";
            // 
            // monoBrightnessLabel
            // 
            this.monoBrightnessLabel.AutoSize = true;
            this.monoBrightnessLabel.Location = new System.Drawing.Point(15, 48);
            this.monoBrightnessLabel.Name = "monoBrightnessLabel";
            this.monoBrightnessLabel.Size = new System.Drawing.Size(75, 17);
            this.monoBrightnessLabel.TabIndex = 1;
            this.monoBrightnessLabel.Text = "Brightness";
            // 
            // monoTrackBar
            // 
            this.monoTrackBar.Location = new System.Drawing.Point(106, 48);
            this.monoTrackBar.Maximum = 255;
            this.monoTrackBar.Name = "monoTrackBar";
            this.monoTrackBar.Size = new System.Drawing.Size(164, 56);
            this.monoTrackBar.TabIndex = 0;
            this.monoTrackBar.Scroll += new System.EventHandler(this.MonoTrackBar_Scroll);
            // 
            // rgbBox
            // 
            this.rgbBox.Controls.Add(this.colorButton);
            this.rgbBox.Controls.Add(this.colorLabel);
            this.rgbBox.Controls.Add(this.rgbTestButton3);
            this.rgbBox.Controls.Add(this.rgbTestButton2);
            this.rgbBox.Controls.Add(this.rgbTestButton1);
            this.rgbBox.Controls.Add(this.rgbTestLabel3);
            this.rgbBox.Controls.Add(this.rgbTestLabel2);
            this.rgbBox.Controls.Add(this.rgbTestLabel1);
            this.rgbBox.Controls.Add(this.rgbApplyButton);
            this.rgbBox.Controls.Add(this.rbgBrightnessLabel);
            this.rgbBox.Controls.Add(this.rgbTrackBar);
            this.rgbBox.Location = new System.Drawing.Point(452, 55);
            this.rgbBox.Name = "rgbBox";
            this.rgbBox.Size = new System.Drawing.Size(325, 304);
            this.rgbBox.TabIndex = 4;
            this.rgbBox.TabStop = false;
            this.rgbBox.Text = "RGB";
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(139, 86);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(101, 28);
            this.colorButton.TabIndex = 16;
            this.colorButton.Text = "Pick Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(41, 86);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(41, 17);
            this.colorLabel.TabIndex = 15;
            this.colorLabel.Text = "Color";
            // 
            // rgbTestButton3
            // 
            this.rgbTestButton3.Location = new System.Drawing.Point(165, 253);
            this.rgbTestButton3.Name = "rgbTestButton3";
            this.rgbTestButton3.Size = new System.Drawing.Size(75, 23);
            this.rgbTestButton3.TabIndex = 14;
            this.rgbTestButton3.Text = "Play";
            this.rgbTestButton3.UseVisualStyleBackColor = true;
            // 
            // rgbTestButton2
            // 
            this.rgbTestButton2.Location = new System.Drawing.Point(165, 224);
            this.rgbTestButton2.Name = "rgbTestButton2";
            this.rgbTestButton2.Size = new System.Drawing.Size(75, 23);
            this.rgbTestButton2.TabIndex = 13;
            this.rgbTestButton2.Text = "Play";
            this.rgbTestButton2.UseVisualStyleBackColor = true;
            // 
            // rgbTestButton1
            // 
            this.rgbTestButton1.Location = new System.Drawing.Point(165, 193);
            this.rgbTestButton1.Name = "rgbTestButton1";
            this.rgbTestButton1.Size = new System.Drawing.Size(75, 23);
            this.rgbTestButton1.TabIndex = 12;
            this.rgbTestButton1.Text = "Play";
            this.rgbTestButton1.UseVisualStyleBackColor = true;
            // 
            // rgbTestLabel3
            // 
            this.rgbTestLabel3.AutoSize = true;
            this.rgbTestLabel3.Location = new System.Drawing.Point(39, 256);
            this.rgbTestLabel3.Name = "rgbTestLabel3";
            this.rgbTestLabel3.Size = new System.Drawing.Size(74, 17);
            this.rgbTestLabel3.TabIndex = 11;
            this.rgbTestLabel3.Text = "Play test 3";
            // 
            // rgbTestLabel2
            // 
            this.rgbTestLabel2.AutoSize = true;
            this.rgbTestLabel2.Location = new System.Drawing.Point(39, 227);
            this.rgbTestLabel2.Name = "rgbTestLabel2";
            this.rgbTestLabel2.Size = new System.Drawing.Size(74, 17);
            this.rgbTestLabel2.TabIndex = 10;
            this.rgbTestLabel2.Text = "Play test 2";
            // 
            // rgbTestLabel1
            // 
            this.rgbTestLabel1.AutoSize = true;
            this.rgbTestLabel1.Location = new System.Drawing.Point(39, 196);
            this.rgbTestLabel1.Name = "rgbTestLabel1";
            this.rgbTestLabel1.Size = new System.Drawing.Size(74, 17);
            this.rgbTestLabel1.TabIndex = 9;
            this.rgbTestLabel1.Text = "Play test 1";
            // 
            // rgbApplyButton
            // 
            this.rgbApplyButton.Location = new System.Drawing.Point(130, 139);
            this.rgbApplyButton.Name = "rgbApplyButton";
            this.rgbApplyButton.Size = new System.Drawing.Size(75, 23);
            this.rgbApplyButton.TabIndex = 2;
            this.rgbApplyButton.Text = "Apply";
            this.rgbApplyButton.UseVisualStyleBackColor = true;
            // 
            // rbgBrightnessLabel
            // 
            this.rbgBrightnessLabel.AutoSize = true;
            this.rbgBrightnessLabel.Location = new System.Drawing.Point(38, 48);
            this.rbgBrightnessLabel.Name = "rbgBrightnessLabel";
            this.rbgBrightnessLabel.Size = new System.Drawing.Size(75, 17);
            this.rbgBrightnessLabel.TabIndex = 1;
            this.rbgBrightnessLabel.Text = "Brightness";
            // 
            // rgbTrackBar
            // 
            this.rgbTrackBar.Location = new System.Drawing.Point(130, 48);
            this.rgbTrackBar.Name = "rgbTrackBar";
            this.rgbTrackBar.Size = new System.Drawing.Size(169, 56);
            this.rgbTrackBar.TabIndex = 0;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.tabPage1);
            this.mainTab.Controls.Add(this.tabPage2);
            this.mainTab.Controls.Add(this.tabPage3);
            this.mainTab.Location = new System.Drawing.Point(0, 2);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(854, 509);
            this.mainTab.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.connectionBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.addMonoButton);
            this.tabPage2.Controls.Add(this.addRGBButton);
            this.tabPage2.Controls.Add(this.monoPanel);
            this.tabPage2.Controls.Add(this.blankPanel);
            this.tabPage2.Controls.Add(this.devicesTree);
            this.tabPage2.Controls.Add(this.scanButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(846, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Devices Management";
            // 
            // addMonoButton
            // 
            this.addMonoButton.Location = new System.Drawing.Point(8, 337);
            this.addMonoButton.Name = "addMonoButton";
            this.addMonoButton.Size = new System.Drawing.Size(247, 41);
            this.addMonoButton.TabIndex = 10;
            this.addMonoButton.Text = "Add Mono Device Simulation";
            this.addMonoButton.UseVisualStyleBackColor = true;
            this.addMonoButton.Click += new System.EventHandler(this.AddMonoButton_Click);
            // 
            // addRGBButton
            // 
            this.addRGBButton.Location = new System.Drawing.Point(8, 384);
            this.addRGBButton.Name = "addRGBButton";
            this.addRGBButton.Size = new System.Drawing.Size(247, 41);
            this.addRGBButton.TabIndex = 9;
            this.addRGBButton.Text = "Add RGB Device Simulation";
            this.addRGBButton.UseVisualStyleBackColor = true;
            this.addRGBButton.Click += new System.EventHandler(this.AddRGBButton_Click);
            // 
            // monoPanel
            // 
            this.monoPanel.Controls.Add(this.monoBox);
            this.monoPanel.Location = new System.Drawing.Point(261, 6);
            this.monoPanel.Name = "monoPanel";
            this.monoPanel.Size = new System.Drawing.Size(579, 419);
            this.monoPanel.TabIndex = 8;
            // 
            // blankPanel
            // 
            this.blankPanel.Location = new System.Drawing.Point(261, 6);
            this.blankPanel.Name = "blankPanel";
            this.blankPanel.Size = new System.Drawing.Size(579, 419);
            this.blankPanel.TabIndex = 7;
            // 
            // devicesTree
            // 
            this.devicesTree.Location = new System.Drawing.Point(8, 6);
            this.devicesTree.Name = "devicesTree";
            treeNode4.Name = "devices";
            treeNode4.Tag = "devices";
            treeNode4.Text = "Devices";
            treeNode5.Name = "groups";
            treeNode5.Tag = "groups";
            treeNode5.Text = "Groups";
            treeNode6.Name = "broadcast";
            treeNode6.Text = "Broadcast";
            this.devicesTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            this.devicesTree.Size = new System.Drawing.Size(247, 278);
            this.devicesTree.TabIndex = 5;
            this.devicesTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.DevicesTree_NodeMouseClick);
            this.devicesTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DevicesTree_MouseDown);
            // 
            // scanButton
            // 
            this.scanButton.Enabled = false;
            this.scanButton.Location = new System.Drawing.Point(8, 290);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(247, 41);
            this.scanButton.TabIndex = 6;
            this.scanButton.Text = "Scan Devices";
            this.scanButton.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rgbBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(846, 480);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // deviceContext
            // 
            this.deviceContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.deviceContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.addDeviceToGroupsToolStripMenuItem});
            this.deviceContext.Name = "devicesContext";
            this.deviceContext.Size = new System.Drawing.Size(225, 52);
            this.deviceContext.Opened += new System.EventHandler(this.DeviceContext_Opened);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.deleteToolStripMenuItem.Text = "Delete Device";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteDeviceToolStripMenuItem_Click);
            // 
            // addDeviceToGroupsToolStripMenuItem
            // 
            this.addDeviceToGroupsToolStripMenuItem.DropDown = this.availGroupsContext;
            this.addDeviceToGroupsToolStripMenuItem.Name = "addDeviceToGroupsToolStripMenuItem";
            this.addDeviceToGroupsToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.addDeviceToGroupsToolStripMenuItem.Text = "Add Device to Groups";
            // 
            // availGroupsContext
            // 
            this.availGroupsContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.availGroupsContext.Name = "availGroupsContext";
            this.availGroupsContext.OwnerItem = this.addDeviceToGroupsToolStripMenuItem;
            this.availGroupsContext.Size = new System.Drawing.Size(61, 4);
            this.availGroupsContext.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.AvailGroupsContext_ItemClicked);
            // 
            // groupContext
            // 
            this.groupContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.groupContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDevicesToGroupToolStripMenuItem});
            this.groupContext.Name = "groupContext";
            this.groupContext.Size = new System.Drawing.Size(225, 28);
            this.groupContext.Opened += new System.EventHandler(this.GroupContext_Opened);
            // 
            // addDevicesToGroupToolStripMenuItem
            // 
            this.addDevicesToGroupToolStripMenuItem.DropDown = this.availDevicesContext;
            this.addDevicesToGroupToolStripMenuItem.Name = "addDevicesToGroupToolStripMenuItem";
            this.addDevicesToGroupToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.addDevicesToGroupToolStripMenuItem.Text = "Add Devices to Group";
            // 
            // availDevicesContext
            // 
            this.availDevicesContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.availDevicesContext.Name = "availDevicesContext";
            this.availDevicesContext.OwnerItem = this.addDevicesToGroupToolStripMenuItem;
            this.availDevicesContext.Size = new System.Drawing.Size(61, 4);
            this.availDevicesContext.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.AvailDevicesContext_ItemClicked);
            // 
            // devicesContext
            // 
            this.devicesContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.devicesContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSimulationToolStripMenuItem});
            this.devicesContext.Name = "devicesContext";
            this.devicesContext.Size = new System.Drawing.Size(182, 28);
            // 
            // addSimulationToolStripMenuItem
            // 
            this.addSimulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monoDeviceToolStripMenuItem,
            this.rGBDeviceToolStripMenuItem});
            this.addSimulationToolStripMenuItem.Name = "addSimulationToolStripMenuItem";
            this.addSimulationToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.addSimulationToolStripMenuItem.Text = "Add Simulation";
            // 
            // monoDeviceToolStripMenuItem
            // 
            this.monoDeviceToolStripMenuItem.Name = "monoDeviceToolStripMenuItem";
            this.monoDeviceToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.monoDeviceToolStripMenuItem.Text = "Mono Device";
            this.monoDeviceToolStripMenuItem.Click += new System.EventHandler(this.AddMonoButton_Click);
            // 
            // rGBDeviceToolStripMenuItem
            // 
            this.rGBDeviceToolStripMenuItem.Name = "rGBDeviceToolStripMenuItem";
            this.rGBDeviceToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.rGBDeviceToolStripMenuItem.Text = "RGB Device";
            this.rGBDeviceToolStripMenuItem.Click += new System.EventHandler(this.AddRGBButton_Click);
            // 
            // removeContext
            // 
            this.removeContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.removeContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFromGroupToolStripMenuItem});
            this.removeContext.Name = "removeContext";
            this.removeContext.Size = new System.Drawing.Size(216, 28);
            // 
            // removeFromGroupToolStripMenuItem
            // 
            this.removeFromGroupToolStripMenuItem.Name = "removeFromGroupToolStripMenuItem";
            this.removeFromGroupToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.removeFromGroupToolStripMenuItem.Text = "Remove From Group";
            this.removeFromGroupToolStripMenuItem.Click += new System.EventHandler(this.RemoveFromGroupToolStripMenuItem_Click);
            // 
            // Dali_Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 609);
            this.Controls.Add(this.mainTab);
            this.Name = "Dali_Driver";
            this.Text = "DALI Driver";
            this.connectionBox.ResumeLayout(false);
            this.connectionBox.PerformLayout();
            this.monoBox.ResumeLayout(false);
            this.monoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monoTrackBar)).EndInit();
            this.rgbBox.ResumeLayout(false);
            this.rgbBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbTrackBar)).EndInit();
            this.mainTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.monoPanel.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.deviceContext.ResumeLayout(false);
            this.groupContext.ResumeLayout(false);
            this.devicesContext.ResumeLayout(false);
            this.removeContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox connectionBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label comLabel;
        private System.Windows.Forms.ComboBox comComboBox;
        private System.Windows.Forms.Label baudLabel;
        private System.Windows.Forms.ComboBox baudComboBox;
        private System.Windows.Forms.GroupBox monoBox;
        private System.Windows.Forms.Label monoBrightnessLabel;
        private System.Windows.Forms.TrackBar monoTrackBar;
        private System.Windows.Forms.GroupBox rgbBox;
        private System.Windows.Forms.TrackBar rgbTrackBar;
        private System.Windows.Forms.Label monoTestLabel3;
        private System.Windows.Forms.Label monoTestLabel2;
        private System.Windows.Forms.Label monoTestLabel1;
        private System.Windows.Forms.Button rgbApplyButton;
        private System.Windows.Forms.Label rbgBrightnessLabel;
        private System.Windows.Forms.Button monoTestButton3;
        private System.Windows.Forms.Button monoTestButton2;
        private System.Windows.Forms.Button monoTestButton1;
        private System.Windows.Forms.Button rgbTestButton3;
        private System.Windows.Forms.Button rgbTestButton2;
        private System.Windows.Forms.Button rgbTestButton1;
        private System.Windows.Forms.Label rgbTestLabel3;
        private System.Windows.Forms.Label rgbTestLabel2;
        private System.Windows.Forms.Label rgbTestLabel1;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox receiveText;
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.TreeView devicesTree;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel blankPanel;
        private System.Windows.Forms.Panel monoPanel;
        private System.Windows.Forms.Button addMonoButton;
        private System.Windows.Forms.Button addRGBButton;
        private System.Windows.Forms.ContextMenuStrip deviceContext;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip groupContext;
        private System.Windows.Forms.ContextMenuStrip devicesContext;
        private System.Windows.Forms.ToolStripMenuItem addSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monoDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeviceToGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDevicesToGroupToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip availGroupsContext;
        private System.Windows.Forms.ContextMenuStrip availDevicesContext;
        private System.Windows.Forms.ContextMenuStrip removeContext;
        private System.Windows.Forms.ToolStripMenuItem removeFromGroupToolStripMenuItem;
    }
}

