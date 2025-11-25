namespace vending_machine_attempt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cocacola = new Button();
            Water = new Button();
            Pepsi = new Button();
            Oreo = new Button();
            Snickers = new Button();
            Kitkat = new Button();
            Pringles = new Button();
            Skittles = new Button();
            Checkout = new Button();
            Cancel = new Button();
            ItemsAdded = new ListBox();
            FivePence = new Button();
            TenPence = new Button();
            FiftyPence = new Button();
            OnePound = new Button();
            TwoPound = new Button();
            Total = new Label();
            TotalAmount = new Label();
            PriceList = new ListBox();
            CoinSlot = new Button();
            Start = new Button();
            Bin = new Button();
            ColaLebel = new Label();
            WaterLabel = new Label();
            PepsiLebel = new Label();
            OreoLebel = new Label();
            SnickersLebel = new Label();
            KitKatLebel = new Label();
            PringlesLebel = new Label();
            SkittlesLebel = new Label();
            LblAct = new Label();
            twopoundlbl = new Label();
            onepoundlbl = new Label();
            fiftypencelbl = new Label();
            tenpencelbl = new Label();
            fivepencelbl = new Label();
            CoinSlotLbl = new Label();
            SuspendLayout();
            // 
            // cocacola
            // 
            cocacola.BackColor = SystemColors.ActiveCaptionText;
            cocacola.BackgroundImage = (Image)resources.GetObject("cocacola.BackgroundImage");
            cocacola.BackgroundImageLayout = ImageLayout.Zoom;
            cocacola.Location = new Point(102, 35);
            cocacola.Name = "cocacola";
            cocacola.Size = new Size(55, 60);
            cocacola.TabIndex = 0;
            cocacola.UseVisualStyleBackColor = false;
            cocacola.Click += cocacola_Click;
            // 
            // Water
            // 
            Water.BackColor = SystemColors.ActiveCaptionText;
            Water.BackgroundImage = (Image)resources.GetObject("Water.BackgroundImage");
            Water.BackgroundImageLayout = ImageLayout.Zoom;
            Water.Location = new Point(198, 35);
            Water.Name = "Water";
            Water.Size = new Size(55, 60);
            Water.TabIndex = 1;
            Water.UseVisualStyleBackColor = false;
            Water.Click += Water_Click;
            // 
            // Pepsi
            // 
            Pepsi.BackColor = SystemColors.ActiveCaptionText;
            Pepsi.BackgroundImage = (Image)resources.GetObject("Pepsi.BackgroundImage");
            Pepsi.BackgroundImageLayout = ImageLayout.Zoom;
            Pepsi.Location = new Point(291, 35);
            Pepsi.Name = "Pepsi";
            Pepsi.Size = new Size(55, 60);
            Pepsi.TabIndex = 2;
            Pepsi.UseVisualStyleBackColor = false;
            Pepsi.Click += Pepsi_Click;
            // 
            // Oreo
            // 
            Oreo.BackColor = SystemColors.ActiveCaptionText;
            Oreo.BackgroundImage = (Image)resources.GetObject("Oreo.BackgroundImage");
            Oreo.BackgroundImageLayout = ImageLayout.Zoom;
            Oreo.Location = new Point(384, 35);
            Oreo.Name = "Oreo";
            Oreo.Size = new Size(55, 60);
            Oreo.TabIndex = 3;
            Oreo.UseVisualStyleBackColor = false;
            Oreo.Click += Oreo_Click;
            // 
            // Snickers
            // 
            Snickers.BackColor = SystemColors.ActiveCaptionText;
            Snickers.BackgroundImage = (Image)resources.GetObject("Snickers.BackgroundImage");
            Snickers.BackgroundImageLayout = ImageLayout.Zoom;
            Snickers.Location = new Point(102, 116);
            Snickers.Name = "Snickers";
            Snickers.Size = new Size(55, 60);
            Snickers.TabIndex = 4;
            Snickers.UseVisualStyleBackColor = false;
            Snickers.Click += Snickers_Click;
            // 
            // Kitkat
            // 
            Kitkat.BackColor = SystemColors.ActiveCaptionText;
            Kitkat.BackgroundImage = (Image)resources.GetObject("Kitkat.BackgroundImage");
            Kitkat.BackgroundImageLayout = ImageLayout.Zoom;
            Kitkat.Location = new Point(198, 114);
            Kitkat.Name = "Kitkat";
            Kitkat.Size = new Size(55, 60);
            Kitkat.TabIndex = 5;
            Kitkat.UseVisualStyleBackColor = false;
            Kitkat.Click += Kitkat_Click;
            // 
            // Pringles
            // 
            Pringles.BackColor = SystemColors.ActiveCaptionText;
            Pringles.BackgroundImage = (Image)resources.GetObject("Pringles.BackgroundImage");
            Pringles.BackgroundImageLayout = ImageLayout.Zoom;
            Pringles.Location = new Point(291, 117);
            Pringles.Name = "Pringles";
            Pringles.Size = new Size(55, 60);
            Pringles.TabIndex = 6;
            Pringles.UseVisualStyleBackColor = false;
            Pringles.Click += Pringles_Click;
            // 
            // Skittles
            // 
            Skittles.BackColor = SystemColors.ActiveCaptionText;
            Skittles.BackgroundImage = (Image)resources.GetObject("Skittles.BackgroundImage");
            Skittles.BackgroundImageLayout = ImageLayout.Zoom;
            Skittles.Location = new Point(384, 117);
            Skittles.Name = "Skittles";
            Skittles.Size = new Size(55, 60);
            Skittles.TabIndex = 7;
            Skittles.UseVisualStyleBackColor = false;
            Skittles.Click += Skittles_Click;
            // 
            // Checkout
            // 
            Checkout.BackColor = SystemColors.ActiveCaption;
            Checkout.Font = new Font("Stencil", 14.25F, FontStyle.Bold);
            Checkout.Location = new Point(291, 232);
            Checkout.Name = "Checkout";
            Checkout.Size = new Size(139, 41);
            Checkout.TabIndex = 8;
            Checkout.Text = "Checkout";
            Checkout.UseVisualStyleBackColor = false;
            Checkout.Click += Checkout_Click;
            // 
            // Cancel
            // 
            Cancel.BackColor = SystemColors.ActiveCaption;
            Cancel.Font = new Font("Stencil", 14.25F, FontStyle.Bold);
            Cancel.Location = new Point(659, 406);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(139, 41);
            Cancel.TabIndex = 9;
            Cancel.Text = "CANCEL";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // ItemsAdded
            // 
            ItemsAdded.BackColor = SystemColors.Window;
            ItemsAdded.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemsAdded.FormattingEnabled = true;
            ItemsAdded.Location = new Point(505, 35);
            ItemsAdded.Name = "ItemsAdded";
            ItemsAdded.Size = new Size(84, 116);
            ItemsAdded.TabIndex = 10;
            ItemsAdded.MouseDown += ItemsAdded_MouseDown;
            // 
            // FivePence
            // 
            FivePence.BackColor = SystemColors.ControlLightLight;
            FivePence.BackgroundImage = (Image)resources.GetObject("FivePence.BackgroundImage");
            FivePence.BackgroundImageLayout = ImageLayout.Stretch;
            FivePence.ForeColor = SystemColors.ButtonHighlight;
            FivePence.Location = new Point(384, 332);
            FivePence.Name = "FivePence";
            FivePence.Size = new Size(87, 94);
            FivePence.TabIndex = 11;
            FivePence.UseVisualStyleBackColor = false;
            FivePence.MouseDown += FivePence_MouseDown;
            // 
            // TenPence
            // 
            TenPence.BackColor = SystemColors.ControlLightLight;
            TenPence.BackgroundImage = (Image)resources.GetObject("TenPence.BackgroundImage");
            TenPence.BackgroundImageLayout = ImageLayout.Stretch;
            TenPence.Location = new Point(291, 332);
            TenPence.Name = "TenPence";
            TenPence.Size = new Size(87, 94);
            TenPence.TabIndex = 12;
            TenPence.UseVisualStyleBackColor = false;
            TenPence.MouseDown += TenPence_MouseDown;
            // 
            // FiftyPence
            // 
            FiftyPence.BackColor = SystemColors.Control;
            FiftyPence.BackgroundImage = (Image)resources.GetObject("FiftyPence.BackgroundImage");
            FiftyPence.BackgroundImageLayout = ImageLayout.Stretch;
            FiftyPence.Location = new Point(198, 332);
            FiftyPence.Name = "FiftyPence";
            FiftyPence.Size = new Size(87, 94);
            FiftyPence.TabIndex = 13;
            FiftyPence.UseVisualStyleBackColor = false;
            FiftyPence.MouseDown += FiftyPence_MouseDown;
            // 
            // OnePound
            // 
            OnePound.BackColor = SystemColors.ControlText;
            OnePound.BackgroundImage = (Image)resources.GetObject("OnePound.BackgroundImage");
            OnePound.BackgroundImageLayout = ImageLayout.Stretch;
            OnePound.Location = new Point(102, 332);
            OnePound.Name = "OnePound";
            OnePound.Size = new Size(87, 94);
            OnePound.TabIndex = 14;
            OnePound.UseVisualStyleBackColor = false;
            OnePound.MouseDown += OnePound_MouseDown;
            // 
            // TwoPound
            // 
            TwoPound.BackgroundImage = (Image)resources.GetObject("TwoPound.BackgroundImage");
            TwoPound.BackgroundImageLayout = ImageLayout.Stretch;
            TwoPound.Location = new Point(12, 332);
            TwoPound.Name = "TwoPound";
            TwoPound.Size = new Size(87, 94);
            TwoPound.TabIndex = 15;
            TwoPound.TextImageRelation = TextImageRelation.ImageAboveText;
            TwoPound.UseVisualStyleBackColor = true;
            TwoPound.MouseDown += TwoPound_MouseDown;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(126, 188);
            Total.Name = "Total";
            Total.Size = new Size(0, 15);
            Total.TabIndex = 16;
            // 
            // TotalAmount
            // 
            TotalAmount.BackColor = SystemColors.ButtonShadow;
            TotalAmount.Font = new Font("Microsoft Sans Serif", 8.25F);
            TotalAmount.Location = new Point(505, 154);
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Size = new Size(127, 31);
            TotalAmount.TabIndex = 17;
            // 
            // PriceList
            // 
            PriceList.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceList.FormattingEnabled = true;
            PriceList.Location = new Point(586, 35);
            PriceList.Name = "PriceList";
            PriceList.Size = new Size(46, 116);
            PriceList.TabIndex = 19;
            // 
            // CoinSlot
            // 
            CoinSlot.AllowDrop = true;
            CoinSlot.BackColor = Color.LightSeaGreen;
            CoinSlot.Location = new Point(487, 332);
            CoinSlot.Name = "CoinSlot";
            CoinSlot.Size = new Size(87, 94);
            CoinSlot.TabIndex = 20;
            CoinSlot.UseVisualStyleBackColor = false;
            CoinSlot.DragDrop += CoinSlot_DragDrop;
            CoinSlot.DragEnter += CoinSlot_DragEnter;
            // 
            // Start
            // 
            Start.BackColor = SystemColors.ActiveCaption;
            Start.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Start.Location = new Point(0, 12);
            Start.Name = "Start";
            Start.Size = new Size(87, 34);
            Start.TabIndex = 21;
            Start.Text = "START";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // Bin
            // 
            Bin.AllowDrop = true;
            Bin.BackColor = Color.DarkSlateGray;
            Bin.BackgroundImage = (Image)resources.GetObject("Bin.BackgroundImage");
            Bin.BackgroundImageLayout = ImageLayout.Zoom;
            Bin.Location = new Point(12, 219);
            Bin.Name = "Bin";
            Bin.Size = new Size(145, 107);
            Bin.TabIndex = 22;
            Bin.TextImageRelation = TextImageRelation.TextBeforeImage;
            Bin.UseVisualStyleBackColor = false;
            Bin.DragDrop += Bin_DragDrop;
            Bin.DragEnter += Bin_DragEnter;
            // 
            // ColaLebel
            // 
            ColaLebel.AutoSize = true;
            ColaLebel.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Bold);
            ColaLebel.Location = new Point(103, 98);
            ColaLebel.Name = "ColaLebel";
            ColaLebel.Size = new Size(72, 16);
            ColaLebel.TabIndex = 23;
            ColaLebel.Text = "Cola - 4.00";
            // 
            // WaterLabel
            // 
            WaterLabel.AutoSize = true;
            WaterLabel.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Bold);
            WaterLabel.Location = new Point(198, 98);
            WaterLabel.Name = "WaterLabel";
            WaterLabel.Size = new Size(83, 16);
            WaterLabel.TabIndex = 24;
            WaterLabel.Text = "Water - 3.50";
            // 
            // PepsiLebel
            // 
            PepsiLebel.AutoSize = true;
            PepsiLebel.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PepsiLebel.Location = new Point(291, 98);
            PepsiLebel.Name = "PepsiLebel";
            PepsiLebel.Size = new Size(76, 16);
            PepsiLebel.TabIndex = 25;
            PepsiLebel.Text = "Pepsi - 4.00";
            // 
            // OreoLebel
            // 
            OreoLebel.AutoSize = true;
            OreoLebel.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Bold);
            OreoLebel.Location = new Point(384, 98);
            OreoLebel.Name = "OreoLebel";
            OreoLebel.Size = new Size(76, 16);
            OreoLebel.TabIndex = 26;
            OreoLebel.Text = "Oreo - 4.15";
            // 
            // SnickersLebel
            // 
            SnickersLebel.AutoSize = true;
            SnickersLebel.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Bold);
            SnickersLebel.Location = new Point(103, 177);
            SnickersLebel.Name = "SnickersLebel";
            SnickersLebel.Size = new Size(95, 16);
            SnickersLebel.TabIndex = 27;
            SnickersLebel.Text = "Snickers - 3.50";
            // 
            // KitKatLebel
            // 
            KitKatLebel.AutoSize = true;
            KitKatLebel.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Bold);
            KitKatLebel.Location = new Point(198, 177);
            KitKatLebel.Name = "KitKatLebel";
            KitKatLebel.Size = new Size(83, 16);
            KitKatLebel.TabIndex = 28;
            KitKatLebel.Text = "KitKat - 3.50";
            // 
            // PringlesLebel
            // 
            PringlesLebel.AutoSize = true;
            PringlesLebel.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Bold);
            PringlesLebel.Location = new Point(288, 177);
            PringlesLebel.Name = "PringlesLebel";
            PringlesLebel.Size = new Size(90, 16);
            PringlesLebel.TabIndex = 29;
            PringlesLebel.Text = "Pringles - 4.00";
            // 
            // SkittlesLebel
            // 
            SkittlesLebel.AutoSize = true;
            SkittlesLebel.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Bold);
            SkittlesLebel.ForeColor = SystemColors.ControlText;
            SkittlesLebel.Location = new Point(384, 177);
            SkittlesLebel.Name = "SkittlesLebel";
            SkittlesLebel.Size = new Size(91, 16);
            SkittlesLebel.TabIndex = 30;
            SkittlesLebel.Text = "Skittles - 3.50";
            // 
            // LblAct
            // 
            LblAct.AutoEllipsis = true;
            LblAct.BackColor = SystemColors.Control;
            LblAct.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAct.Location = new Point(126, 3);
            LblAct.Name = "LblAct";
            LblAct.Size = new Size(403, 29);
            LblAct.TabIndex = 31;
            LblAct.Text = "Click the \"START\" button to start your transaction";
            // 
            // twopoundlbl
            // 
            twopoundlbl.AutoSize = true;
            twopoundlbl.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            twopoundlbl.ForeColor = SystemColors.Desktop;
            twopoundlbl.Location = new Point(28, 428);
            twopoundlbl.Name = "twopoundlbl";
            twopoundlbl.Size = new Size(59, 19);
            twopoundlbl.TabIndex = 32;
            twopoundlbl.Text = "2 Pound";
            // 
            // onepoundlbl
            // 
            onepoundlbl.AutoSize = true;
            onepoundlbl.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            onepoundlbl.Location = new Point(116, 428);
            onepoundlbl.Name = "onepoundlbl";
            onepoundlbl.Size = new Size(59, 19);
            onepoundlbl.TabIndex = 33;
            onepoundlbl.Text = "1 Pound";
            // 
            // fiftypencelbl
            // 
            fiftypencelbl.AutoSize = true;
            fiftypencelbl.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            fiftypencelbl.Location = new Point(219, 428);
            fiftypencelbl.Name = "fiftypencelbl";
            fiftypencelbl.Size = new Size(66, 19);
            fiftypencelbl.TabIndex = 34;
            fiftypencelbl.Text = "50 Pence";
            // 
            // tenpencelbl
            // 
            tenpencelbl.AutoSize = true;
            tenpencelbl.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            tenpencelbl.Location = new Point(304, 429);
            tenpencelbl.Name = "tenpencelbl";
            tenpencelbl.Size = new Size(66, 19);
            tenpencelbl.TabIndex = 35;
            tenpencelbl.Text = "10 Pence";
            // 
            // fivepencelbl
            // 
            fivepencelbl.AutoSize = true;
            fivepencelbl.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            fivepencelbl.Location = new Point(402, 429);
            fivepencelbl.Name = "fivepencelbl";
            fivepencelbl.Size = new Size(58, 19);
            fivepencelbl.TabIndex = 36;
            fivepencelbl.Text = "5 Pence";
            // 
            // CoinSlotLbl
            // 
            CoinSlotLbl.AutoSize = true;
            CoinSlotLbl.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            CoinSlotLbl.Location = new Point(496, 428);
            CoinSlotLbl.Name = "CoinSlotLbl";
            CoinSlotLbl.Size = new Size(61, 19);
            CoinSlotLbl.TabIndex = 37;
            CoinSlotLbl.Text = "CoinSlot";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(CoinSlotLbl);
            Controls.Add(fivepencelbl);
            Controls.Add(tenpencelbl);
            Controls.Add(fiftypencelbl);
            Controls.Add(onepoundlbl);
            Controls.Add(twopoundlbl);
            Controls.Add(LblAct);
            Controls.Add(SkittlesLebel);
            Controls.Add(PringlesLebel);
            Controls.Add(KitKatLebel);
            Controls.Add(SnickersLebel);
            Controls.Add(OreoLebel);
            Controls.Add(PepsiLebel);
            Controls.Add(WaterLabel);
            Controls.Add(ColaLebel);
            Controls.Add(Bin);
            Controls.Add(Start);
            Controls.Add(CoinSlot);
            Controls.Add(PriceList);
            Controls.Add(TotalAmount);
            Controls.Add(Total);
            Controls.Add(TwoPound);
            Controls.Add(OnePound);
            Controls.Add(FiftyPence);
            Controls.Add(TenPence);
            Controls.Add(FivePence);
            Controls.Add(ItemsAdded);
            Controls.Add(Cancel);
            Controls.Add(Checkout);
            Controls.Add(Skittles);
            Controls.Add(Pringles);
            Controls.Add(Kitkat);
            Controls.Add(Snickers);
            Controls.Add(Oreo);
            Controls.Add(Pepsi);
            Controls.Add(Water);
            Controls.Add(cocacola);
            Name = "Form1";
            Text = "30135072";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cocacola;
        private Button Water;
        private Button Pepsi;
        private Button Oreo;
        private Button Snickers;
        private Button Kitkat;
        private Button Pringles;
        private Button Skittles;
        private Button Checkout;
        private Button Cancel;
        private ListBox ItemsAdded;
        private Button FivePence;
        private Button TenPence;
        private Button FiftyPence;
        private Button OnePound;
        private Button TwoPound;
        private Label Total;
        private Label TotalAmount;
        private ListBox PriceList;
        private Button CoinSlot;
        private Button Start;
        private Button Bin;
        private Label ColaLebel;
        private Label WaterLabel;
        private Label PepsiLebel;
        private Label OreoLebel;
        private Label SnickersLebel;
        private Label KitKatLebel;
        private Label PringlesLebel;
        private Label SkittlesLebel;
        private Label LblAct;
        private Label twopoundlbl;
        private Label onepoundlbl;
        private Label fiftypencelbl;
        private Label tenpencelbl;
        private Label fivepencelbl;
        private Label CoinSlotLbl;
    }
}
