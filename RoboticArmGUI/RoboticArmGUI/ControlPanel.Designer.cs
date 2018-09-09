namespace RoboticArmGUI
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.baseUp = new System.Windows.Forms.PictureBox();
            this.baseRight = new System.Windows.Forms.PictureBox();
            this.baseControls = new System.Windows.Forms.Panel();
            this.baseDown = new System.Windows.Forms.PictureBox();
            this.baseLeft = new System.Windows.Forms.PictureBox();
            this.topControls = new System.Windows.Forms.Panel();
            this.topDown = new System.Windows.Forms.PictureBox();
            this.topUp = new System.Windows.Forms.PictureBox();
            this.clawControls = new System.Windows.Forms.Panel();
            this.clawGrab = new System.Windows.Forms.Panel();
            this.clawOpen = new System.Windows.Forms.Button();
            this.clawClose = new System.Windows.Forms.Button();
            this.clawMovement = new System.Windows.Forms.Panel();
            this.clawLeft = new System.Windows.Forms.PictureBox();
            this.clawRight = new System.Windows.Forms.PictureBox();
            this.movementControls = new System.Windows.Forms.Panel();
            this.settings = new System.Windows.Forms.Panel();
            this.btnOff = new System.Windows.Forms.Button();
            this.topBar = new System.Windows.Forms.Panel();
            this.portSelection = new System.Windows.Forms.NumericUpDown();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baseUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseRight)).BeginInit();
            this.baseControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseLeft)).BeginInit();
            this.topControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topUp)).BeginInit();
            this.clawControls.SuspendLayout();
            this.clawGrab.SuspendLayout();
            this.clawMovement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clawLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clawRight)).BeginInit();
            this.movementControls.SuspendLayout();
            this.settings.SuspendLayout();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // baseUp
            // 
            this.baseUp.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.baseUp.BackColor = System.Drawing.Color.Teal;
            this.baseUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baseUp.Image = ((System.Drawing.Image)(resources.GetObject("baseUp.Image")));
            this.baseUp.Location = new System.Drawing.Point(250, 3);
            this.baseUp.Name = "baseUp";
            this.baseUp.Size = new System.Drawing.Size(98, 246);
            this.baseUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.baseUp.TabIndex = 0;
            this.baseUp.TabStop = false;
            this.baseUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.baseUp_MouseDown);
            this.baseUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.baseUp_MouseUp);
            // 
            // baseRight
            // 
            this.baseRight.BackColor = System.Drawing.Color.Teal;
            this.baseRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baseRight.Image = ((System.Drawing.Image)(resources.GetObject("baseRight.Image")));
            this.baseRight.Location = new System.Drawing.Point(350, 255);
            this.baseRight.Name = "baseRight";
            this.baseRight.Size = new System.Drawing.Size(246, 98);
            this.baseRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.baseRight.TabIndex = 3;
            this.baseRight.TabStop = false;
            this.baseRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.baseRight_MouseDown);
            this.baseRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.baseRight_MouseUp);
            // 
            // baseControls
            // 
            this.baseControls.Controls.Add(this.baseDown);
            this.baseControls.Controls.Add(this.baseLeft);
            this.baseControls.Controls.Add(this.baseRight);
            this.baseControls.Controls.Add(this.baseUp);
            this.baseControls.Location = new System.Drawing.Point(141, 10);
            this.baseControls.Name = "baseControls";
            this.baseControls.Size = new System.Drawing.Size(599, 611);
            this.baseControls.TabIndex = 4;
            // 
            // baseDown
            // 
            this.baseDown.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.baseDown.BackColor = System.Drawing.Color.Teal;
            this.baseDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baseDown.Image = ((System.Drawing.Image)(resources.GetObject("baseDown.Image")));
            this.baseDown.Location = new System.Drawing.Point(250, 360);
            this.baseDown.Name = "baseDown";
            this.baseDown.Size = new System.Drawing.Size(98, 246);
            this.baseDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.baseDown.TabIndex = 5;
            this.baseDown.TabStop = false;
            this.baseDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.baseDown_MouseDown);
            this.baseDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.baseDown_MouseUp);
            // 
            // baseLeft
            // 
            this.baseLeft.BackColor = System.Drawing.Color.Teal;
            this.baseLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baseLeft.Image = ((System.Drawing.Image)(resources.GetObject("baseLeft.Image")));
            this.baseLeft.Location = new System.Drawing.Point(3, 255);
            this.baseLeft.Name = "baseLeft";
            this.baseLeft.Size = new System.Drawing.Size(246, 98);
            this.baseLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.baseLeft.TabIndex = 4;
            this.baseLeft.TabStop = false;
            this.baseLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.baseLeft_MouseDown);
            this.baseLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.baseLeft_MouseUp);
            // 
            // topControls
            // 
            this.topControls.Controls.Add(this.topDown);
            this.topControls.Controls.Add(this.topUp);
            this.topControls.Location = new System.Drawing.Point(16, 10);
            this.topControls.Name = "topControls";
            this.topControls.Size = new System.Drawing.Size(103, 611);
            this.topControls.TabIndex = 5;
            // 
            // topDown
            // 
            this.topDown.BackColor = System.Drawing.Color.LightSeaGreen;
            this.topDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topDown.Image = ((System.Drawing.Image)(resources.GetObject("topDown.Image")));
            this.topDown.Location = new System.Drawing.Point(3, 321);
            this.topDown.Name = "topDown";
            this.topDown.Size = new System.Drawing.Size(98, 246);
            this.topDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.topDown.TabIndex = 2;
            this.topDown.TabStop = false;
            this.topDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topDown_MouseDown);
            this.topDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topDown_MouseUp);
            // 
            // topUp
            // 
            this.topUp.BackColor = System.Drawing.Color.LightSeaGreen;
            this.topUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topUp.Image = ((System.Drawing.Image)(resources.GetObject("topUp.Image")));
            this.topUp.Location = new System.Drawing.Point(3, 38);
            this.topUp.Name = "topUp";
            this.topUp.Size = new System.Drawing.Size(98, 246);
            this.topUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.topUp.TabIndex = 1;
            this.topUp.TabStop = false;
            this.topUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topUp_MouseDown);
            this.topUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topUp_MouseUp);
            // 
            // clawControls
            // 
            this.clawControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clawControls.Controls.Add(this.clawGrab);
            this.clawControls.Controls.Add(this.clawMovement);
            this.clawControls.Location = new System.Drawing.Point(19, 364);
            this.clawControls.Name = "clawControls";
            this.clawControls.Size = new System.Drawing.Size(546, 353);
            this.clawControls.TabIndex = 9;
            // 
            // clawGrab
            // 
            this.clawGrab.Controls.Add(this.clawOpen);
            this.clawGrab.Controls.Add(this.clawClose);
            this.clawGrab.Location = new System.Drawing.Point(3, 3);
            this.clawGrab.Name = "clawGrab";
            this.clawGrab.Size = new System.Drawing.Size(535, 235);
            this.clawGrab.TabIndex = 8;
            // 
            // clawOpen
            // 
            this.clawOpen.BackColor = System.Drawing.Color.SteelBlue;
            this.clawOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clawOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clawOpen.ForeColor = System.Drawing.Color.White;
            this.clawOpen.Location = new System.Drawing.Point(16, 117);
            this.clawOpen.Name = "clawOpen";
            this.clawOpen.Size = new System.Drawing.Size(499, 98);
            this.clawOpen.TabIndex = 13;
            this.clawOpen.Text = "Open Claw";
            this.clawOpen.UseVisualStyleBackColor = false;
            this.clawOpen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clawOpen_MouseDown);
            this.clawOpen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clawOpen_MouseUp);
            // 
            // clawClose
            // 
            this.clawClose.BackColor = System.Drawing.Color.IndianRed;
            this.clawClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clawClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clawClose.ForeColor = System.Drawing.Color.White;
            this.clawClose.Location = new System.Drawing.Point(16, 13);
            this.clawClose.Name = "clawClose";
            this.clawClose.Size = new System.Drawing.Size(499, 98);
            this.clawClose.TabIndex = 11;
            this.clawClose.Text = "Close Claw";
            this.clawClose.UseVisualStyleBackColor = false;
            this.clawClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clawClose_MouseDown);
            this.clawClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clawClose_MouseUp);
            // 
            // clawMovement
            // 
            this.clawMovement.Controls.Add(this.clawLeft);
            this.clawMovement.Controls.Add(this.clawRight);
            this.clawMovement.Location = new System.Drawing.Point(3, 244);
            this.clawMovement.Name = "clawMovement";
            this.clawMovement.Size = new System.Drawing.Size(535, 100);
            this.clawMovement.TabIndex = 7;
            // 
            // clawLeft
            // 
            this.clawLeft.BackColor = System.Drawing.Color.Firebrick;
            this.clawLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clawLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clawLeft.Image = ((System.Drawing.Image)(resources.GetObject("clawLeft.Image")));
            this.clawLeft.Location = new System.Drawing.Point(3, 3);
            this.clawLeft.Name = "clawLeft";
            this.clawLeft.Size = new System.Drawing.Size(246, 98);
            this.clawLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clawLeft.TabIndex = 4;
            this.clawLeft.TabStop = false;
            this.clawLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clawLeft_MouseDown);
            this.clawLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clawLeft_MouseUp);
            // 
            // clawRight
            // 
            this.clawRight.BackColor = System.Drawing.Color.Firebrick;
            this.clawRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clawRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clawRight.Image = ((System.Drawing.Image)(resources.GetObject("clawRight.Image")));
            this.clawRight.Location = new System.Drawing.Point(286, 0);
            this.clawRight.Name = "clawRight";
            this.clawRight.Size = new System.Drawing.Size(246, 98);
            this.clawRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clawRight.TabIndex = 3;
            this.clawRight.TabStop = false;
            this.clawRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clawRight_MouseDown);
            this.clawRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clawRight_MouseUp);
            // 
            // movementControls
            // 
            this.movementControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movementControls.Controls.Add(this.topControls);
            this.movementControls.Controls.Add(this.baseControls);
            this.movementControls.Location = new System.Drawing.Point(594, 96);
            this.movementControls.Name = "movementControls";
            this.movementControls.Size = new System.Drawing.Size(763, 621);
            this.movementControls.TabIndex = 6;
            // 
            // settings
            // 
            this.settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settings.Controls.Add(this.btnOff);
            this.settings.Location = new System.Drawing.Point(22, 96);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(543, 242);
            this.settings.TabIndex = 10;
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.Color.Firebrick;
            this.btnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.ForeColor = System.Drawing.Color.White;
            this.btnOff.Location = new System.Drawing.Point(16, 36);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(482, 150);
            this.btnOff.TabIndex = 0;
            this.btnOff.Text = "Power OFF";
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.LightSlateGray;
            this.topBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topBar.Controls.Add(this.portSelection);
            this.topBar.Controls.Add(this.title);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.MinimumSize = new System.Drawing.Size(500, 2);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(1376, 55);
            this.topBar.TabIndex = 11;
            // 
            // portSelection
            // 
            this.portSelection.BackColor = System.Drawing.Color.LightSlateGray;
            this.portSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portSelection.ForeColor = System.Drawing.SystemColors.Window;
            this.portSelection.Location = new System.Drawing.Point(1301, 12);
            this.portSelection.Name = "portSelection";
            this.portSelection.Size = new System.Drawing.Size(55, 29);
            this.portSelection.TabIndex = 2;
            this.portSelection.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.portSelection.ValueChanged += new System.EventHandler(this.portSelection_ValueChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(34, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(140, 24);
            this.title.TabIndex = 1;
            this.title.Text = "RoboticArmGUI";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1376, 735);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.clawControls);
            this.Controls.Add(this.movementControls);
            this.Name = "GUI";
            this.Text = "RoboticArmGUI";
            ((System.ComponentModel.ISupportInitialize)(this.baseUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseRight)).EndInit();
            this.baseControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseLeft)).EndInit();
            this.topControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topUp)).EndInit();
            this.clawControls.ResumeLayout(false);
            this.clawGrab.ResumeLayout(false);
            this.clawMovement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clawLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clawRight)).EndInit();
            this.movementControls.ResumeLayout(false);
            this.settings.ResumeLayout(false);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portSelection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox baseUp;
        private System.Windows.Forms.PictureBox baseRight;
        private System.Windows.Forms.Panel baseControls;
        private System.Windows.Forms.Panel topControls;
        private System.Windows.Forms.PictureBox topDown;
        private System.Windows.Forms.PictureBox topUp;
        private System.Windows.Forms.Panel movementControls;
        private System.Windows.Forms.Panel clawMovement;
        private System.Windows.Forms.PictureBox clawRight;
        private System.Windows.Forms.Panel clawGrab;
        private System.Windows.Forms.Panel clawControls;
        private System.Windows.Forms.Panel settings;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button clawOpen;
        private System.Windows.Forms.Button clawClose;
        private System.Windows.Forms.PictureBox baseDown;
        private System.Windows.Forms.PictureBox baseLeft;
        private System.Windows.Forms.PictureBox clawLeft;
        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.NumericUpDown portSelection;
    }
}

