namespace MLPJ_SaveEditor
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdGameSave = new System.Windows.Forms.OpenFileDialog();
            this.chkInventory = new System.Windows.Forms.CheckBox();
            this.chkCoins = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.sfdGameSave = new System.Windows.Forms.SaveFileDialog();
            this.chkMMaxLevel = new System.Windows.Forms.CheckBox();
            this.chkPMMaxLevel = new System.Windows.Forms.CheckBox();
            this.chkLLevel = new System.Windows.Forms.CheckBox();
            this.tabCheats = new System.Windows.Forms.TabControl();
            this.tbpMario = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMRainbow = new System.Windows.Forms.ComboBox();
            this.cmbMExtra = new System.Windows.Forms.ComboBox();
            this.cmbMLeaf = new System.Windows.Forms.ComboBox();
            this.cmbMFlower = new System.Windows.Forms.ComboBox();
            this.cmbMStar = new System.Windows.Forms.ComboBox();
            this.cmbMBoomerang = new System.Windows.Forms.ComboBox();
            this.cmbMShell = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkMMaxStats = new System.Windows.Forms.CheckBox();
            this.tbpLuigi = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbLRainBow = new System.Windows.Forms.ComboBox();
            this.cmbLExtra = new System.Windows.Forms.ComboBox();
            this.cmbLLeaf = new System.Windows.Forms.ComboBox();
            this.cmbLFlower = new System.Windows.Forms.ComboBox();
            this.cmbLStar = new System.Windows.Forms.ComboBox();
            this.cmbLBoomerang = new System.Windows.Forms.ComboBox();
            this.cmbLShell = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.chkLMaxStats = new System.Windows.Forms.CheckBox();
            this.tbpPaperMario = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbPMRainbow = new System.Windows.Forms.ComboBox();
            this.cmbPMExtra = new System.Windows.Forms.ComboBox();
            this.cmbPMLeaf = new System.Windows.Forms.ComboBox();
            this.cmbPMFlower = new System.Windows.Forms.ComboBox();
            this.cmbPMStar = new System.Windows.Forms.ComboBox();
            this.cmbPMBoomerang = new System.Windows.Forms.ComboBox();
            this.cmbPMShell = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.chkPMMaxStats = new System.Windows.Forms.CheckBox();
            this.tbpMiscellaneous = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabCheats.SuspendLayout();
            this.tbpMario.SuspendLayout();
            this.tbpLuigi.SuspendLayout();
            this.tbpPaperMario.SuspendLayout();
            this.tbpMiscellaneous.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(379, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFileOpen,
            this.msFileSave,
            this.toolStripSeparator1,
            this.msFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // msFileOpen
            // 
            this.msFileOpen.Name = "msFileOpen";
            this.msFileOpen.Size = new System.Drawing.Size(103, 22);
            this.msFileOpen.Text = "Open";
            this.msFileOpen.Click += new System.EventHandler(this.msFileOpen_Click);
            // 
            // msFileSave
            // 
            this.msFileSave.Name = "msFileSave";
            this.msFileSave.Size = new System.Drawing.Size(103, 22);
            this.msFileSave.Text = "Save";
            this.msFileSave.Click += new System.EventHandler(this.msFileSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // msFileExit
            // 
            this.msFileExit.Name = "msFileExit";
            this.msFileExit.Size = new System.Drawing.Size(103, 22);
            this.msFileExit.Text = "Exit";
            this.msFileExit.Click += new System.EventHandler(this.msFileExit_Click);
            // 
            // ofdGameSave
            // 
            this.ofdGameSave.Filter = "SAV|*.sav";
            // 
            // chkInventory
            // 
            this.chkInventory.AutoSize = true;
            this.chkInventory.Location = new System.Drawing.Point(6, 6);
            this.chkInventory.Name = "chkInventory";
            this.chkInventory.Size = new System.Drawing.Size(93, 17);
            this.chkInventory.TabIndex = 9;
            this.chkInventory.Tag = "MaxInventory";
            this.chkInventory.Text = "Max Inventory";
            this.chkInventory.UseVisualStyleBackColor = true;
            // 
            // chkCoins
            // 
            this.chkCoins.AutoSize = true;
            this.chkCoins.Location = new System.Drawing.Point(6, 29);
            this.chkCoins.Name = "chkCoins";
            this.chkCoins.Size = new System.Drawing.Size(75, 17);
            this.chkCoins.TabIndex = 10;
            this.chkCoins.Tag = "MaxCoins";
            this.chkCoins.Text = "Max Coins";
            this.chkCoins.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(351, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // sfdGameSave
            // 
            this.sfdGameSave.Filter = "SAV|*.sav";
            // 
            // chkMMaxLevel
            // 
            this.chkMMaxLevel.AutoSize = true;
            this.chkMMaxLevel.Location = new System.Drawing.Point(6, 6);
            this.chkMMaxLevel.Name = "chkMMaxLevel";
            this.chkMMaxLevel.Size = new System.Drawing.Size(75, 17);
            this.chkMMaxLevel.TabIndex = 0;
            this.chkMMaxLevel.Tag = "MaxLevel";
            this.chkMMaxLevel.Text = "Max Level";
            this.chkMMaxLevel.UseVisualStyleBackColor = true;
            // 
            // chkPMMaxLevel
            // 
            this.chkPMMaxLevel.AutoSize = true;
            this.chkPMMaxLevel.Location = new System.Drawing.Point(6, 6);
            this.chkPMMaxLevel.Name = "chkPMMaxLevel";
            this.chkPMMaxLevel.Size = new System.Drawing.Size(75, 17);
            this.chkPMMaxLevel.TabIndex = 1;
            this.chkPMMaxLevel.Tag = "MaxLevel";
            this.chkPMMaxLevel.Text = "Max Level";
            this.chkPMMaxLevel.UseVisualStyleBackColor = true;
            // 
            // chkLLevel
            // 
            this.chkLLevel.AutoSize = true;
            this.chkLLevel.Location = new System.Drawing.Point(6, 6);
            this.chkLLevel.Name = "chkLLevel";
            this.chkLLevel.Size = new System.Drawing.Size(75, 17);
            this.chkLLevel.TabIndex = 2;
            this.chkLLevel.Tag = "MaxLevel";
            this.chkLLevel.Text = "Max Level";
            this.chkLLevel.UseVisualStyleBackColor = true;
            // 
            // tabCheats
            // 
            this.tabCheats.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCheats.Controls.Add(this.tbpMario);
            this.tabCheats.Controls.Add(this.tbpLuigi);
            this.tabCheats.Controls.Add(this.tbpPaperMario);
            this.tabCheats.Controls.Add(this.tbpMiscellaneous);
            this.tabCheats.Location = new System.Drawing.Point(12, 27);
            this.tabCheats.Name = "tabCheats";
            this.tabCheats.SelectedIndex = 0;
            this.tabCheats.Size = new System.Drawing.Size(355, 293);
            this.tabCheats.TabIndex = 12;
            // 
            // tbpMario
            // 
            this.tbpMario.Controls.Add(this.label7);
            this.tbpMario.Controls.Add(this.chkMMaxStats);
            this.tbpMario.Controls.Add(this.label1);
            this.tbpMario.Controls.Add(this.label6);
            this.tbpMario.Controls.Add(this.chkMMaxLevel);
            this.tbpMario.Controls.Add(this.label2);
            this.tbpMario.Controls.Add(this.cmbMLeaf);
            this.tbpMario.Controls.Add(this.label5);
            this.tbpMario.Controls.Add(this.cmbMExtra);
            this.tbpMario.Controls.Add(this.cmbMShell);
            this.tbpMario.Controls.Add(this.cmbMFlower);
            this.tbpMario.Controls.Add(this.label4);
            this.tbpMario.Controls.Add(this.cmbMRainbow);
            this.tbpMario.Controls.Add(this.cmbMBoomerang);
            this.tbpMario.Controls.Add(this.cmbMStar);
            this.tbpMario.Controls.Add(this.label3);
            this.tbpMario.Location = new System.Drawing.Point(4, 25);
            this.tbpMario.Name = "tbpMario";
            this.tbpMario.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMario.Size = new System.Drawing.Size(347, 264);
            this.tbpMario.TabIndex = 0;
            this.tbpMario.Text = "Mario";
            this.tbpMario.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Extra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Rainbow";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Star";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Leaf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Flower";
            // 
            // cmbMRainbow
            // 
            this.cmbMRainbow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMRainbow.FormattingEnabled = true;
            this.cmbMRainbow.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbMRainbow.Location = new System.Drawing.Point(99, 191);
            this.cmbMRainbow.Name = "cmbMRainbow";
            this.cmbMRainbow.Size = new System.Drawing.Size(121, 21);
            this.cmbMRainbow.TabIndex = 11;
            this.cmbMRainbow.Tag = "RAINBOWRANK";
            // 
            // cmbMExtra
            // 
            this.cmbMExtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMExtra.FormattingEnabled = true;
            this.cmbMExtra.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbMExtra.Location = new System.Drawing.Point(99, 218);
            this.cmbMExtra.Name = "cmbMExtra";
            this.cmbMExtra.Size = new System.Drawing.Size(121, 21);
            this.cmbMExtra.TabIndex = 10;
            this.cmbMExtra.Tag = "EXTRARANK";
            // 
            // cmbMLeaf
            // 
            this.cmbMLeaf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMLeaf.FormattingEnabled = true;
            this.cmbMLeaf.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbMLeaf.Location = new System.Drawing.Point(99, 137);
            this.cmbMLeaf.Name = "cmbMLeaf";
            this.cmbMLeaf.Size = new System.Drawing.Size(121, 21);
            this.cmbMLeaf.TabIndex = 9;
            this.cmbMLeaf.Tag = "LEAFRANK";
            // 
            // cmbMFlower
            // 
            this.cmbMFlower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMFlower.FormattingEnabled = true;
            this.cmbMFlower.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbMFlower.Location = new System.Drawing.Point(99, 110);
            this.cmbMFlower.Name = "cmbMFlower";
            this.cmbMFlower.Size = new System.Drawing.Size(121, 21);
            this.cmbMFlower.TabIndex = 8;
            this.cmbMFlower.Tag = "FLOWERRANK";
            // 
            // cmbMStar
            // 
            this.cmbMStar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMStar.FormattingEnabled = true;
            this.cmbMStar.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbMStar.Location = new System.Drawing.Point(99, 164);
            this.cmbMStar.Name = "cmbMStar";
            this.cmbMStar.Size = new System.Drawing.Size(121, 21);
            this.cmbMStar.TabIndex = 7;
            this.cmbMStar.Tag = "STARRANK";
            // 
            // cmbMBoomerang
            // 
            this.cmbMBoomerang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMBoomerang.FormattingEnabled = true;
            this.cmbMBoomerang.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbMBoomerang.Location = new System.Drawing.Point(99, 83);
            this.cmbMBoomerang.Name = "cmbMBoomerang";
            this.cmbMBoomerang.Size = new System.Drawing.Size(121, 21);
            this.cmbMBoomerang.TabIndex = 6;
            this.cmbMBoomerang.Tag = "BOOMERANGRANK";
            // 
            // cmbMShell
            // 
            this.cmbMShell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMShell.FormattingEnabled = true;
            this.cmbMShell.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbMShell.Location = new System.Drawing.Point(99, 56);
            this.cmbMShell.Name = "cmbMShell";
            this.cmbMShell.Size = new System.Drawing.Size(121, 21);
            this.cmbMShell.TabIndex = 5;
            this.cmbMShell.Tag = "SHELLRANK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Boomerang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shell";
            // 
            // chkMMaxStats
            // 
            this.chkMMaxStats.AutoSize = true;
            this.chkMMaxStats.Location = new System.Drawing.Point(6, 29);
            this.chkMMaxStats.Name = "chkMMaxStats";
            this.chkMMaxStats.Size = new System.Drawing.Size(107, 17);
            this.chkMMaxStats.TabIndex = 1;
            this.chkMMaxStats.Tag = "MaxAddedStats";
            this.chkMMaxStats.Text = "Max Added Stats";
            this.chkMMaxStats.UseVisualStyleBackColor = true;
            // 
            // tbpLuigi
            // 
            this.tbpLuigi.Controls.Add(this.label8);
            this.tbpLuigi.Controls.Add(this.label9);
            this.tbpLuigi.Controls.Add(this.label10);
            this.tbpLuigi.Controls.Add(this.label11);
            this.tbpLuigi.Controls.Add(this.label12);
            this.tbpLuigi.Controls.Add(this.cmbLRainBow);
            this.tbpLuigi.Controls.Add(this.cmbLExtra);
            this.tbpLuigi.Controls.Add(this.cmbLLeaf);
            this.tbpLuigi.Controls.Add(this.cmbLFlower);
            this.tbpLuigi.Controls.Add(this.cmbLStar);
            this.tbpLuigi.Controls.Add(this.cmbLBoomerang);
            this.tbpLuigi.Controls.Add(this.cmbLShell);
            this.tbpLuigi.Controls.Add(this.label13);
            this.tbpLuigi.Controls.Add(this.label14);
            this.tbpLuigi.Controls.Add(this.chkLMaxStats);
            this.tbpLuigi.Controls.Add(this.chkLLevel);
            this.tbpLuigi.Location = new System.Drawing.Point(4, 25);
            this.tbpLuigi.Name = "tbpLuigi";
            this.tbpLuigi.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLuigi.Size = new System.Drawing.Size(347, 264);
            this.tbpLuigi.TabIndex = 1;
            this.tbpLuigi.Text = "Luigi";
            this.tbpLuigi.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Extra";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Rainbow";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Star";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Leaf";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Flower";
            // 
            // cmbLRainBow
            // 
            this.cmbLRainBow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLRainBow.FormattingEnabled = true;
            this.cmbLRainBow.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbLRainBow.Location = new System.Drawing.Point(99, 191);
            this.cmbLRainBow.Name = "cmbLRainBow";
            this.cmbLRainBow.Size = new System.Drawing.Size(121, 21);
            this.cmbLRainBow.TabIndex = 25;
            this.cmbLRainBow.Tag = "RAINBOWRANK";
            // 
            // cmbLExtra
            // 
            this.cmbLExtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLExtra.FormattingEnabled = true;
            this.cmbLExtra.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbLExtra.Location = new System.Drawing.Point(99, 218);
            this.cmbLExtra.Name = "cmbLExtra";
            this.cmbLExtra.Size = new System.Drawing.Size(121, 21);
            this.cmbLExtra.TabIndex = 24;
            this.cmbLExtra.Tag = "EXTRARANK";
            // 
            // cmbLLeaf
            // 
            this.cmbLLeaf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLLeaf.FormattingEnabled = true;
            this.cmbLLeaf.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbLLeaf.Location = new System.Drawing.Point(99, 137);
            this.cmbLLeaf.Name = "cmbLLeaf";
            this.cmbLLeaf.Size = new System.Drawing.Size(121, 21);
            this.cmbLLeaf.TabIndex = 23;
            this.cmbLLeaf.Tag = "LEAFRANK";
            // 
            // cmbLFlower
            // 
            this.cmbLFlower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLFlower.FormattingEnabled = true;
            this.cmbLFlower.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbLFlower.Location = new System.Drawing.Point(99, 110);
            this.cmbLFlower.Name = "cmbLFlower";
            this.cmbLFlower.Size = new System.Drawing.Size(121, 21);
            this.cmbLFlower.TabIndex = 22;
            this.cmbLFlower.Tag = "FLOWERRANK";
            // 
            // cmbLStar
            // 
            this.cmbLStar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLStar.FormattingEnabled = true;
            this.cmbLStar.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbLStar.Location = new System.Drawing.Point(99, 164);
            this.cmbLStar.Name = "cmbLStar";
            this.cmbLStar.Size = new System.Drawing.Size(121, 21);
            this.cmbLStar.TabIndex = 21;
            this.cmbLStar.Tag = "STARRANK";
            // 
            // cmbLBoomerang
            // 
            this.cmbLBoomerang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLBoomerang.FormattingEnabled = true;
            this.cmbLBoomerang.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbLBoomerang.Location = new System.Drawing.Point(99, 83);
            this.cmbLBoomerang.Name = "cmbLBoomerang";
            this.cmbLBoomerang.Size = new System.Drawing.Size(121, 21);
            this.cmbLBoomerang.TabIndex = 20;
            this.cmbLBoomerang.Tag = "BOOMERANGRANK";
            // 
            // cmbLShell
            // 
            this.cmbLShell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLShell.FormattingEnabled = true;
            this.cmbLShell.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbLShell.Location = new System.Drawing.Point(99, 56);
            this.cmbLShell.Name = "cmbLShell";
            this.cmbLShell.Size = new System.Drawing.Size(121, 21);
            this.cmbLShell.TabIndex = 19;
            this.cmbLShell.Tag = "SHELLRANK";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Boomerang";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Shell";
            // 
            // chkLMaxStats
            // 
            this.chkLMaxStats.AutoSize = true;
            this.chkLMaxStats.Location = new System.Drawing.Point(6, 29);
            this.chkLMaxStats.Name = "chkLMaxStats";
            this.chkLMaxStats.Size = new System.Drawing.Size(107, 17);
            this.chkLMaxStats.TabIndex = 3;
            this.chkLMaxStats.Tag = "MaxAddedStats";
            this.chkLMaxStats.Text = "Max Added Stats";
            this.chkLMaxStats.UseVisualStyleBackColor = true;
            // 
            // tbpPaperMario
            // 
            this.tbpPaperMario.Controls.Add(this.label15);
            this.tbpPaperMario.Controls.Add(this.label16);
            this.tbpPaperMario.Controls.Add(this.label17);
            this.tbpPaperMario.Controls.Add(this.label18);
            this.tbpPaperMario.Controls.Add(this.label19);
            this.tbpPaperMario.Controls.Add(this.cmbPMRainbow);
            this.tbpPaperMario.Controls.Add(this.cmbPMExtra);
            this.tbpPaperMario.Controls.Add(this.cmbPMLeaf);
            this.tbpPaperMario.Controls.Add(this.cmbPMFlower);
            this.tbpPaperMario.Controls.Add(this.cmbPMStar);
            this.tbpPaperMario.Controls.Add(this.cmbPMBoomerang);
            this.tbpPaperMario.Controls.Add(this.cmbPMShell);
            this.tbpPaperMario.Controls.Add(this.label20);
            this.tbpPaperMario.Controls.Add(this.label21);
            this.tbpPaperMario.Controls.Add(this.chkPMMaxStats);
            this.tbpPaperMario.Controls.Add(this.chkPMMaxLevel);
            this.tbpPaperMario.Location = new System.Drawing.Point(4, 25);
            this.tbpPaperMario.Name = "tbpPaperMario";
            this.tbpPaperMario.Size = new System.Drawing.Size(347, 264);
            this.tbpPaperMario.TabIndex = 2;
            this.tbpPaperMario.Text = "Paper Mario";
            this.tbpPaperMario.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Extra";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Rainbow";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Star";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 140);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "Leaf";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 113);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Flower";
            // 
            // cmbPMRainbow
            // 
            this.cmbPMRainbow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPMRainbow.FormattingEnabled = true;
            this.cmbPMRainbow.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbPMRainbow.Location = new System.Drawing.Point(99, 191);
            this.cmbPMRainbow.Name = "cmbPMRainbow";
            this.cmbPMRainbow.Size = new System.Drawing.Size(121, 21);
            this.cmbPMRainbow.TabIndex = 39;
            this.cmbPMRainbow.Tag = "RAINBOWRANK";
            // 
            // cmbPMExtra
            // 
            this.cmbPMExtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPMExtra.FormattingEnabled = true;
            this.cmbPMExtra.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbPMExtra.Location = new System.Drawing.Point(99, 218);
            this.cmbPMExtra.Name = "cmbPMExtra";
            this.cmbPMExtra.Size = new System.Drawing.Size(121, 21);
            this.cmbPMExtra.TabIndex = 38;
            this.cmbPMExtra.Tag = "EXTRARANK";
            // 
            // cmbPMLeaf
            // 
            this.cmbPMLeaf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPMLeaf.FormattingEnabled = true;
            this.cmbPMLeaf.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbPMLeaf.Location = new System.Drawing.Point(99, 137);
            this.cmbPMLeaf.Name = "cmbPMLeaf";
            this.cmbPMLeaf.Size = new System.Drawing.Size(121, 21);
            this.cmbPMLeaf.TabIndex = 37;
            this.cmbPMLeaf.Tag = "LEAFRANK";
            // 
            // cmbPMFlower
            // 
            this.cmbPMFlower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPMFlower.FormattingEnabled = true;
            this.cmbPMFlower.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbPMFlower.Location = new System.Drawing.Point(99, 110);
            this.cmbPMFlower.Name = "cmbPMFlower";
            this.cmbPMFlower.Size = new System.Drawing.Size(121, 21);
            this.cmbPMFlower.TabIndex = 36;
            this.cmbPMFlower.Tag = "FLOWERRANK";
            // 
            // cmbPMStar
            // 
            this.cmbPMStar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPMStar.FormattingEnabled = true;
            this.cmbPMStar.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbPMStar.Location = new System.Drawing.Point(99, 164);
            this.cmbPMStar.Name = "cmbPMStar";
            this.cmbPMStar.Size = new System.Drawing.Size(121, 21);
            this.cmbPMStar.TabIndex = 35;
            this.cmbPMStar.Tag = "STARRANK";
            // 
            // cmbPMBoomerang
            // 
            this.cmbPMBoomerang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPMBoomerang.FormattingEnabled = true;
            this.cmbPMBoomerang.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbPMBoomerang.Location = new System.Drawing.Point(99, 83);
            this.cmbPMBoomerang.Name = "cmbPMBoomerang";
            this.cmbPMBoomerang.Size = new System.Drawing.Size(121, 21);
            this.cmbPMBoomerang.TabIndex = 34;
            this.cmbPMBoomerang.Tag = "BOOMERANGRANK";
            // 
            // cmbPMShell
            // 
            this.cmbPMShell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPMShell.FormattingEnabled = true;
            this.cmbPMShell.Items.AddRange(new object[] {
            "(None)",
            "Gear Slot +1",
            "Gear Slot +1",
            "Star Point Max +10",
            "HP Up+",
            "BP Up+",
            "POW Up+",
            "DEF Up+",
            "SPEED Up+",
            "STACHE Up+",
            "Quick Level",
            "Iron Body",
            "Jump Man",
            "Hammerhead",
            "Counterer",
            "Mushroom EXP",
            "Quick Item",
            "Quick Copy",
            "Copy Max +2",
            "Copy Max +2",
            "Big Lucky",
            "Casual Bros.",
            "Battle Card Discount",
            "Quick Healer"});
            this.cmbPMShell.Location = new System.Drawing.Point(99, 56);
            this.cmbPMShell.Name = "cmbPMShell";
            this.cmbPMShell.Size = new System.Drawing.Size(121, 21);
            this.cmbPMShell.TabIndex = 33;
            this.cmbPMShell.Tag = "SHELLRANK";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 86);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "Boomerang";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 59);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "Shell";
            // 
            // chkPMMaxStats
            // 
            this.chkPMMaxStats.AutoSize = true;
            this.chkPMMaxStats.Location = new System.Drawing.Point(6, 29);
            this.chkPMMaxStats.Name = "chkPMMaxStats";
            this.chkPMMaxStats.Size = new System.Drawing.Size(107, 17);
            this.chkPMMaxStats.TabIndex = 2;
            this.chkPMMaxStats.Tag = "MaxAddedLevel";
            this.chkPMMaxStats.Text = "Max Added Stats";
            this.chkPMMaxStats.UseVisualStyleBackColor = true;
            // 
            // tbpMiscellaneous
            // 
            this.tbpMiscellaneous.Controls.Add(this.chkInventory);
            this.tbpMiscellaneous.Controls.Add(this.chkCoins);
            this.tbpMiscellaneous.Location = new System.Drawing.Point(4, 25);
            this.tbpMiscellaneous.Name = "tbpMiscellaneous";
            this.tbpMiscellaneous.Size = new System.Drawing.Size(347, 264);
            this.tbpMiscellaneous.TabIndex = 3;
            this.tbpMiscellaneous.Text = "Miscellaneous";
            this.tbpMiscellaneous.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 360);
            this.Controls.Add(this.tabCheats);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Mario & Luigi: Paper Jam Save Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabCheats.ResumeLayout(false);
            this.tbpMario.ResumeLayout(false);
            this.tbpMario.PerformLayout();
            this.tbpLuigi.ResumeLayout(false);
            this.tbpLuigi.PerformLayout();
            this.tbpPaperMario.ResumeLayout(false);
            this.tbpPaperMario.PerformLayout();
            this.tbpMiscellaneous.ResumeLayout(false);
            this.tbpMiscellaneous.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem msFileExit;
        private System.Windows.Forms.OpenFileDialog ofdGameSave;
        private System.Windows.Forms.CheckBox chkInventory;
        private System.Windows.Forms.CheckBox chkCoins;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem msFileSave;
        private System.Windows.Forms.SaveFileDialog sfdGameSave;
        private System.Windows.Forms.CheckBox chkLLevel;
        private System.Windows.Forms.CheckBox chkPMMaxLevel;
        private System.Windows.Forms.CheckBox chkMMaxLevel;
        private System.Windows.Forms.TabControl tabCheats;
        private System.Windows.Forms.TabPage tbpMario;
        private System.Windows.Forms.TabPage tbpLuigi;
        private System.Windows.Forms.TabPage tbpPaperMario;
        private System.Windows.Forms.CheckBox chkMMaxStats;
        private System.Windows.Forms.TabPage tbpMiscellaneous;
        private System.Windows.Forms.CheckBox chkLMaxStats;
        private System.Windows.Forms.CheckBox chkPMMaxStats;
        private System.Windows.Forms.ComboBox cmbMRainbow;
        private System.Windows.Forms.ComboBox cmbMExtra;
        private System.Windows.Forms.ComboBox cmbMLeaf;
        private System.Windows.Forms.ComboBox cmbMFlower;
        private System.Windows.Forms.ComboBox cmbMStar;
        private System.Windows.Forms.ComboBox cmbMBoomerang;
        private System.Windows.Forms.ComboBox cmbMShell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbLRainBow;
        private System.Windows.Forms.ComboBox cmbLExtra;
        private System.Windows.Forms.ComboBox cmbLLeaf;
        private System.Windows.Forms.ComboBox cmbLFlower;
        private System.Windows.Forms.ComboBox cmbLStar;
        private System.Windows.Forms.ComboBox cmbLBoomerang;
        private System.Windows.Forms.ComboBox cmbLShell;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbPMRainbow;
        private System.Windows.Forms.ComboBox cmbPMExtra;
        private System.Windows.Forms.ComboBox cmbPMLeaf;
        private System.Windows.Forms.ComboBox cmbPMFlower;
        private System.Windows.Forms.ComboBox cmbPMStar;
        private System.Windows.Forms.ComboBox cmbPMBoomerang;
        private System.Windows.Forms.ComboBox cmbPMShell;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}

