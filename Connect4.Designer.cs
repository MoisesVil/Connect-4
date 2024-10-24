namespace TempName
{
    partial class Connect4
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
            this.GameTextLabel = new System.Windows.Forms.Label();
            this.SubTextLabel = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.button00 = new TempName.RoundButton();
            this.button10 = new TempName.RoundButton();
            this.button20 = new TempName.RoundButton();
            this.button30 = new TempName.RoundButton();
            this.button40 = new TempName.RoundButton();
            this.button50 = new TempName.RoundButton();
            this.button01 = new TempName.RoundButton();
            this.button11 = new TempName.RoundButton();
            this.button21 = new TempName.RoundButton();
            this.button31 = new TempName.RoundButton();
            this.button41 = new TempName.RoundButton();
            this.button51 = new TempName.RoundButton();
            this.button02 = new TempName.RoundButton();
            this.button12 = new TempName.RoundButton();
            this.button22 = new TempName.RoundButton();
            this.button32 = new TempName.RoundButton();
            this.button42 = new TempName.RoundButton();
            this.button52 = new TempName.RoundButton();
            this.button03 = new TempName.RoundButton();
            this.button13 = new TempName.RoundButton();
            this.button23 = new TempName.RoundButton();
            this.button33 = new TempName.RoundButton();
            this.button43 = new TempName.RoundButton();
            this.button53 = new TempName.RoundButton();
            this.button04 = new TempName.RoundButton();
            this.button14 = new TempName.RoundButton();
            this.button24 = new TempName.RoundButton();
            this.button34 = new TempName.RoundButton();
            this.button44 = new TempName.RoundButton();
            this.button54 = new TempName.RoundButton();
            this.button05 = new TempName.RoundButton();
            this.button15 = new TempName.RoundButton();
            this.button25 = new TempName.RoundButton();
            this.button35 = new TempName.RoundButton();
            this.button45 = new TempName.RoundButton();
            this.button55 = new TempName.RoundButton();
            this.button06 = new TempName.RoundButton();
            this.button16 = new TempName.RoundButton();
            this.button26 = new TempName.RoundButton();
            this.button36 = new TempName.RoundButton();
            this.button46 = new TempName.RoundButton();
            this.button56 = new TempName.RoundButton();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.ChangeNamesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameTextLabel
            // 
            this.GameTextLabel.AutoSize = true;
            this.GameTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTextLabel.Location = new System.Drawing.Point(177, 11);
            this.GameTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameTextLabel.Name = "GameTextLabel";
            this.GameTextLabel.Size = new System.Drawing.Size(244, 39);
            this.GameTextLabel.TabIndex = 42;
            this.GameTextLabel.Text = "Player 1\'s Turn";
            // 
            // SubTextLabel
            // 
            this.SubTextLabel.AutoSize = true;
            this.SubTextLabel.Location = new System.Drawing.Point(181, 62);
            this.SubTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubTextLabel.Name = "SubTextLabel";
            this.SubTextLabel.Size = new System.Drawing.Size(212, 16);
            this.SubTextLabel.TabIndex = 43;
            this.SubTextLabel.Text = "Can not place peice in that column!";
            this.SubTextLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(31, 515);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(4);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(119, 48);
            this.QuitButton.TabIndex = 44;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButtonOnClick);
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(446, 515);
            this.RestartButton.Margin = new System.Windows.Forms.Padding(4);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(119, 48);
            this.RestartButton.TabIndex = 45;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButtonOnClick);
            // 
            // button00
            // 
            this.button00.Location = new System.Drawing.Point(30, 412);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(70, 70);
            this.button00.TabIndex = 46;
            this.button00.UseVisualStyleBackColor = true;
            this.button00.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button00.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button00.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(30, 347);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(70, 70);
            this.button10.TabIndex = 47;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button10.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button10.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(31, 282);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(70, 70);
            this.button20.TabIndex = 48;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button20.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button20.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(30, 217);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(70, 70);
            this.button30.TabIndex = 49;
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button30.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button30.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(30, 152);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(70, 70);
            this.button40.TabIndex = 50;
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button40.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button40.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button50
            // 
            this.button50.Location = new System.Drawing.Point(31, 86);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(70, 70);
            this.button50.TabIndex = 51;
            this.button50.UseVisualStyleBackColor = true;
            this.button50.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button50.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button50.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button01
            // 
            this.button01.Location = new System.Drawing.Point(108, 412);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(70, 70);
            this.button01.TabIndex = 52;
            this.button01.UseVisualStyleBackColor = true;
            this.button01.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button01.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button01.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(108, 347);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(70, 70);
            this.button11.TabIndex = 53;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button11.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button11.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(108, 282);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(70, 70);
            this.button21.TabIndex = 54;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button21.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button21.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(108, 217);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(70, 70);
            this.button31.TabIndex = 55;
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button31.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button31.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button41
            // 
            this.button41.Location = new System.Drawing.Point(108, 152);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(70, 70);
            this.button41.TabIndex = 56;
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button41.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button41.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button51
            // 
            this.button51.Location = new System.Drawing.Point(108, 86);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(70, 70);
            this.button51.TabIndex = 57;
            this.button51.UseVisualStyleBackColor = true;
            this.button51.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button51.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button51.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button02
            // 
            this.button02.Location = new System.Drawing.Point(184, 412);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(70, 70);
            this.button02.TabIndex = 58;
            this.button02.UseVisualStyleBackColor = true;
            this.button02.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button02.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button02.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(184, 347);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(70, 70);
            this.button12.TabIndex = 59;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button12.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button12.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(184, 282);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(70, 70);
            this.button22.TabIndex = 60;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button22.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button22.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(184, 217);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(70, 70);
            this.button32.TabIndex = 61;
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button32.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button32.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button42
            // 
            this.button42.Location = new System.Drawing.Point(184, 152);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(70, 70);
            this.button42.TabIndex = 62;
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button42.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button42.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button52
            // 
            this.button52.Location = new System.Drawing.Point(184, 86);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(70, 70);
            this.button52.TabIndex = 63;
            this.button52.UseVisualStyleBackColor = true;
            this.button52.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button52.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button52.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button03
            // 
            this.button03.Location = new System.Drawing.Point(263, 412);
            this.button03.Name = "button03";
            this.button03.Size = new System.Drawing.Size(70, 70);
            this.button03.TabIndex = 64;
            this.button03.UseVisualStyleBackColor = true;
            this.button03.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button03.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button03.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(263, 347);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(70, 70);
            this.button13.TabIndex = 65;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button13.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button13.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(263, 282);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(70, 70);
            this.button23.TabIndex = 66;
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button23.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button23.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(263, 217);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(70, 70);
            this.button33.TabIndex = 67;
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button33.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button33.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button43
            // 
            this.button43.Location = new System.Drawing.Point(263, 152);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(70, 70);
            this.button43.TabIndex = 68;
            this.button43.UseVisualStyleBackColor = true;
            this.button43.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button43.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button43.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button53
            // 
            this.button53.Location = new System.Drawing.Point(263, 86);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(70, 70);
            this.button53.TabIndex = 69;
            this.button53.UseVisualStyleBackColor = true;
            this.button53.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button53.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button53.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button04
            // 
            this.button04.Location = new System.Drawing.Point(340, 412);
            this.button04.Name = "button04";
            this.button04.Size = new System.Drawing.Size(70, 70);
            this.button04.TabIndex = 70;
            this.button04.UseVisualStyleBackColor = true;
            this.button04.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button04.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button04.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(340, 347);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(70, 70);
            this.button14.TabIndex = 71;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button14.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button14.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(340, 282);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(70, 70);
            this.button24.TabIndex = 72;
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button24.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button24.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(340, 217);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(70, 70);
            this.button34.TabIndex = 73;
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button34.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button34.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button44
            // 
            this.button44.Location = new System.Drawing.Point(340, 152);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(70, 70);
            this.button44.TabIndex = 74;
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button44.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button44.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button54
            // 
            this.button54.Location = new System.Drawing.Point(340, 86);
            this.button54.Name = "button54";
            this.button54.Size = new System.Drawing.Size(70, 70);
            this.button54.TabIndex = 75;
            this.button54.UseVisualStyleBackColor = true;
            this.button54.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button54.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button54.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button05
            // 
            this.button05.Location = new System.Drawing.Point(417, 412);
            this.button05.Name = "button05";
            this.button05.Size = new System.Drawing.Size(70, 70);
            this.button05.TabIndex = 76;
            this.button05.UseVisualStyleBackColor = true;
            this.button05.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button05.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button05.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(417, 347);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(70, 70);
            this.button15.TabIndex = 77;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button15.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button15.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(417, 282);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(70, 70);
            this.button25.TabIndex = 78;
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button25.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button25.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(417, 217);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(70, 70);
            this.button35.TabIndex = 79;
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button35.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button35.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button45
            // 
            this.button45.Location = new System.Drawing.Point(417, 152);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(70, 70);
            this.button45.TabIndex = 80;
            this.button45.UseVisualStyleBackColor = true;
            this.button45.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button45.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button45.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button55
            // 
            this.button55.Location = new System.Drawing.Point(417, 86);
            this.button55.Name = "button55";
            this.button55.Size = new System.Drawing.Size(70, 70);
            this.button55.TabIndex = 81;
            this.button55.UseVisualStyleBackColor = true;
            this.button55.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button55.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button55.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button06
            // 
            this.button06.Location = new System.Drawing.Point(495, 412);
            this.button06.Name = "button06";
            this.button06.Size = new System.Drawing.Size(70, 70);
            this.button06.TabIndex = 82;
            this.button06.UseVisualStyleBackColor = true;
            this.button06.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button06.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button06.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(495, 347);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(70, 70);
            this.button16.TabIndex = 83;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button16.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button16.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(495, 282);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(70, 70);
            this.button26.TabIndex = 84;
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button26.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button26.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(495, 217);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(70, 70);
            this.button36.TabIndex = 85;
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button36.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button36.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button46
            // 
            this.button46.Location = new System.Drawing.Point(495, 152);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(70, 70);
            this.button46.TabIndex = 86;
            this.button46.UseVisualStyleBackColor = true;
            this.button46.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button46.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button46.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // button56
            // 
            this.button56.Location = new System.Drawing.Point(495, 86);
            this.button56.Name = "button56";
            this.button56.Size = new System.Drawing.Size(70, 70);
            this.button56.TabIndex = 87;
            this.button56.UseVisualStyleBackColor = true;
            this.button56.Click += new System.EventHandler(this.GameButtonOnClick);
            this.button56.MouseLeave += new System.EventHandler(this.GameButtonLeaveHover);
            this.button56.MouseHover += new System.EventHandler(this.GameButtonOnHover);
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Location = new System.Drawing.Point(21, 81);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(553, 413);
            this.BackgroundPanel.TabIndex = 88;
            // 
            // ChangeNamesButton
            // 
            this.ChangeNamesButton.Location = new System.Drawing.Point(243, 515);
            this.ChangeNamesButton.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeNamesButton.Name = "ChangeNamesButton";
            this.ChangeNamesButton.Size = new System.Drawing.Size(119, 48);
            this.ChangeNamesButton.TabIndex = 89;
            this.ChangeNamesButton.Text = "Change Names";
            this.ChangeNamesButton.UseVisualStyleBackColor = true;
            this.ChangeNamesButton.Click += new System.EventHandler(this.ChangeNamesButtonOnClick);
            // 
            // Connect4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 586);
            this.Controls.Add(this.ChangeNamesButton);
            this.Controls.Add(this.button56);
            this.Controls.Add(this.button46);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button06);
            this.Controls.Add(this.button55);
            this.Controls.Add(this.button45);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button05);
            this.Controls.Add(this.button54);
            this.Controls.Add(this.button44);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button04);
            this.Controls.Add(this.button53);
            this.Controls.Add(this.button43);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button03);
            this.Controls.Add(this.button52);
            this.Controls.Add(this.button42);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button02);
            this.Controls.Add(this.button51);
            this.Controls.Add(this.button41);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button01);
            this.Controls.Add(this.button50);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button00);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.SubTextLabel);
            this.Controls.Add(this.GameTextLabel);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Connect4";
            this.Text = "Connect 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GameTextLabel;
        private System.Windows.Forms.Label SubTextLabel;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button RestartButton;
        private RoundButton button00;
        private RoundButton button10;
        private RoundButton button20;
        private RoundButton button30;
        private RoundButton button40;
        private RoundButton button50;
        private RoundButton button01;
        private RoundButton button11;
        private RoundButton button21;
        private RoundButton button31;
        private RoundButton button41;
        private RoundButton button51;
        private RoundButton button02;
        private RoundButton button12;
        private RoundButton button22;
        private RoundButton button32;
        private RoundButton button42;
        private RoundButton button52;
        private RoundButton button03;
        private RoundButton button13;
        private RoundButton button23;
        private RoundButton button33;
        private RoundButton button43;
        private RoundButton button53;
        private RoundButton button04;
        private RoundButton button14;
        private RoundButton button24;
        private RoundButton button34;
        private RoundButton button44;
        private RoundButton button54;
        private RoundButton button05;
        private RoundButton button15;
        private RoundButton button25;
        private RoundButton button35;
        private RoundButton button45;
        private RoundButton button55;
        private RoundButton button06;
        private RoundButton button16;
        private RoundButton button26;
        private RoundButton button36;
        private RoundButton button46;
        private RoundButton button56;
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Button ChangeNamesButton;
    }
}

