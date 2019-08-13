/****************************************************************/
/*                                                              */
/*          Advanced Navigation Packet Protocol Library         */
/*          .NET C# Language Spatial SDK, Version 4.0           */
/*   Copyright 2014, Xavier Orr, Advanced Navigation Pty Ltd    */
/*                                                              */
/****************************************************************/
/*
 * Copyright (C) 2014 Advanced Navigation Pty Ltd
 *
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the "Software"),
 * to deal in the Software without restriction, including without limitation
 * the rights to use, copy, modify, merge, publish, distribute, sublicense,
 * and/or sell copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included
 * in all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
 * OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 * DEALINGS IN THE SOFTWARE.
 */
 
namespace ANPPExample
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboPort = new System.Windows.Forms.ComboBox();
            this.comboBaud = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxYaw = new System.Windows.Forms.TextBox();
            this.textBoxPitch = new System.Windows.Forms.TextBox();
            this.textBoxRoll = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboPort
            // 
            this.comboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPort.FormattingEnabled = true;
            this.comboPort.Location = new System.Drawing.Point(13, 13);
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(121, 21);
            this.comboPort.TabIndex = 0;
            // 
            // comboBaud
            // 
            this.comboBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBaud.FormattingEnabled = true;
            this.comboBaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "500000",
            "921600",
            "1000000"});
            this.comboBaud.Location = new System.Drawing.Point(141, 13);
            this.comboBaud.Name = "comboBaud";
            this.comboBaud.Size = new System.Drawing.Size(121, 21);
            this.comboBaud.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(269, 13);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox34);
            this.groupBox1.Controls.Add(this.textBox33);
            this.groupBox1.Controls.Add(this.textBox32);
            this.groupBox1.Controls.Add(this.textBox31);
            this.groupBox1.Controls.Add(this.textBox30);
            this.groupBox1.Controls.Add(this.textBox29);
            this.groupBox1.Controls.Add(this.textBox28);
            this.groupBox1.Controls.Add(this.textBox27);
            this.groupBox1.Controls.Add(this.textBox26);
            this.groupBox1.Controls.Add(this.textBox25);
            this.groupBox1.Controls.Add(this.textBox24);
            this.groupBox1.Controls.Add(this.textBox23);
            this.groupBox1.Controls.Add(this.textBox22);
            this.groupBox1.Controls.Add(this.textBox21);
            this.groupBox1.Controls.Add(this.textBox16);
            this.groupBox1.Controls.Add(this.textBox18);
            this.groupBox1.Controls.Add(this.textBox17);
            this.groupBox1.Controls.Add(this.textBox15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.textBox13);
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxYaw);
            this.groupBox1.Controls.Add(this.textBoxPitch);
            this.groupBox1.Controls.Add(this.textBoxRoll);
            this.groupBox1.Controls.Add(this.textBoxHeight);
            this.groupBox1.Controls.Add(this.textBoxLongitude);
            this.groupBox1.Controls.Add(this.textBoxLatitude);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 423);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // textBoxYaw
            // 
            this.textBoxYaw.Location = new System.Drawing.Point(226, 71);
            this.textBoxYaw.Name = "textBoxYaw";
            this.textBoxYaw.ReadOnly = true;
            this.textBoxYaw.Size = new System.Drawing.Size(100, 20);
            this.textBoxYaw.TabIndex = 11;
            // 
            // textBoxPitch
            // 
            this.textBoxPitch.Location = new System.Drawing.Point(226, 45);
            this.textBoxPitch.Name = "textBoxPitch";
            this.textBoxPitch.ReadOnly = true;
            this.textBoxPitch.Size = new System.Drawing.Size(100, 20);
            this.textBoxPitch.TabIndex = 10;
            // 
            // textBoxRoll
            // 
            this.textBoxRoll.Location = new System.Drawing.Point(226, 19);
            this.textBoxRoll.Name = "textBoxRoll";
            this.textBoxRoll.ReadOnly = true;
            this.textBoxRoll.Size = new System.Drawing.Size(100, 20);
            this.textBoxRoll.TabIndex = 9;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(69, 71);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.ReadOnly = true;
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 8;
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.Location = new System.Drawing.Point(69, 45);
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.ReadOnly = true;
            this.textBoxLongitude.Size = new System.Drawing.Size(100, 20);
            this.textBoxLongitude.TabIndex = 7;
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.Location = new System.Drawing.Point(69, 19);
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.ReadOnly = true;
            this.textBoxLatitude.Size = new System.Drawing.Size(100, 20);
            this.textBoxLatitude.TabIndex = 6;
            this.textBoxLatitude.TextChanged += new System.EventHandler(this.TextBoxLatitude_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yaw:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pitch:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Roll:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitude:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latitude:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 482);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(362, 89);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(605, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Acceleometer";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(605, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Gyroscope";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Location = new System.Drawing.Point(738, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.Location = new System.Drawing.Point(873, 110);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 16;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.Location = new System.Drawing.Point(738, 217);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 17;
            this.textBox5.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.Location = new System.Drawing.Point(873, 217);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Magnetometer";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.Location = new System.Drawing.Point(385, 339);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 20;
            this.textBox7.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.Location = new System.Drawing.Point(250, 339);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 21;
            this.textBox8.TextChanged += new System.EventHandler(this.TextBox8_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.Location = new System.Drawing.Point(117, 339);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 22;
            this.textBox9.TextChanged += new System.EventHandler(this.TextBox9_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(917, 525);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Pressure";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(784, 525);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "PressureTemp";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(920, 551);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 25;
            this.textBox10.TextChanged += new System.EventHandler(this.TextBox10_TextChanged);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(787, 551);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Velocity";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Control;
            this.textBox12.Location = new System.Drawing.Point(80, 217);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 28;
            this.textBox12.TextChanged += new System.EventHandler(this.TextBox12_TextChanged);
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Control;
            this.textBox13.Location = new System.Drawing.Point(213, 220);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 29;
            this.textBox13.TextChanged += new System.EventHandler(this.TextBox13_TextChanged);
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.Control;
            this.textBox14.Location = new System.Drawing.Point(348, 220);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 30;
            this.textBox14.TextChanged += new System.EventHandler(this.TextBox14_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Position";
            this.label13.Click += new System.EventHandler(this.Label13_Click);
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.Control;
            this.textBox15.Location = new System.Drawing.Point(80, 107);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 32;
            this.textBox15.TextChanged += new System.EventHandler(this.TextBox15_TextChanged);
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.SystemColors.Control;
            this.textBox17.Location = new System.Drawing.Point(213, 107);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 34;
            this.textBox17.TextChanged += new System.EventHandler(this.TextBox17_TextChanged);
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.SystemColors.Control;
            this.textBox18.Location = new System.Drawing.Point(348, 107);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 35;
            this.textBox18.TextChanged += new System.EventHandler(this.TextBox18_TextChanged);
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.Control;
            this.textBox16.Location = new System.Drawing.Point(117, 387);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 36;
            this.textBox16.TextChanged += new System.EventHandler(this.TextBox16_TextChanged);
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.SystemColors.Control;
            this.textBox19.Location = new System.Drawing.Point(920, 482);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 20);
            this.textBox19.TabIndex = 37;
            this.textBox19.TextChanged += new System.EventHandler(this.TextBox19_TextChanged);
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.SystemColors.Control;
            this.textBox20.Location = new System.Drawing.Point(787, 482);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 20);
            this.textBox20.TabIndex = 38;
            this.textBox20.TextChanged += new System.EventHandler(this.TextBox20_TextChanged);
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.SystemColors.Control;
            this.textBox21.Location = new System.Drawing.Point(873, 297);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(100, 20);
            this.textBox21.TabIndex = 39;
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.SystemColors.Control;
            this.textBox22.Location = new System.Drawing.Point(738, 297);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(100, 20);
            this.textBox22.TabIndex = 40;
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.SystemColors.Control;
            this.textBox23.Location = new System.Drawing.Point(873, 156);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(100, 20);
            this.textBox23.TabIndex = 41;
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.SystemColors.Control;
            this.textBox24.Location = new System.Drawing.Point(738, 156);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(100, 20);
            this.textBox24.TabIndex = 42;
            // 
            // textBox25
            // 
            this.textBox25.BackColor = System.Drawing.SystemColors.Control;
            this.textBox25.Location = new System.Drawing.Point(605, 297);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(100, 20);
            this.textBox25.TabIndex = 43;
            // 
            // textBox26
            // 
            this.textBox26.BackColor = System.Drawing.SystemColors.Control;
            this.textBox26.Location = new System.Drawing.Point(605, 156);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(100, 20);
            this.textBox26.TabIndex = 44;
            // 
            // textBox27
            // 
            this.textBox27.BackColor = System.Drawing.SystemColors.Control;
            this.textBox27.Location = new System.Drawing.Point(348, 273);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(100, 20);
            this.textBox27.TabIndex = 45;
            // 
            // textBox28
            // 
            this.textBox28.BackColor = System.Drawing.SystemColors.Control;
            this.textBox28.Location = new System.Drawing.Point(213, 273);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(100, 20);
            this.textBox28.TabIndex = 46;
            // 
            // textBox29
            // 
            this.textBox29.BackColor = System.Drawing.SystemColors.Control;
            this.textBox29.Location = new System.Drawing.Point(80, 273);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(100, 20);
            this.textBox29.TabIndex = 47;
            // 
            // textBox30
            // 
            this.textBox30.BackColor = System.Drawing.SystemColors.Control;
            this.textBox30.Location = new System.Drawing.Point(348, 156);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(100, 20);
            this.textBox30.TabIndex = 48;
            // 
            // textBox31
            // 
            this.textBox31.BackColor = System.Drawing.SystemColors.Control;
            this.textBox31.Location = new System.Drawing.Point(213, 156);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(100, 20);
            this.textBox31.TabIndex = 49;
            // 
            // textBox32
            // 
            this.textBox32.BackColor = System.Drawing.SystemColors.Control;
            this.textBox32.Location = new System.Drawing.Point(80, 156);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(100, 20);
            this.textBox32.TabIndex = 50;
            this.textBox32.TextChanged += new System.EventHandler(this.TextBox32_TextChanged);
            // 
            // textBox33
            // 
            this.textBox33.BackColor = System.Drawing.SystemColors.Control;
            this.textBox33.Location = new System.Drawing.Point(250, 387);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(100, 20);
            this.textBox33.TabIndex = 51;
            this.textBox33.TextChanged += new System.EventHandler(this.TextBox33_TextChanged);
            // 
            // textBox34
            // 
            this.textBox34.BackColor = System.Drawing.SystemColors.Control;
            this.textBox34.Location = new System.Drawing.Point(385, 387);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(100, 20);
            this.textBox34.TabIndex = 52;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 580);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBaud);
            this.Controls.Add(this.comboPort);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox19);
            this.Name = "Form1";
            this.Text = "ANPP Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboPort;
        private System.Windows.Forms.ComboBox comboBaud;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxYaw;
        private System.Windows.Forms.TextBox textBoxPitch;
        private System.Windows.Forms.TextBox textBoxRoll;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxLongitude;
        private System.Windows.Forms.TextBox textBoxLatitude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox textBox33;
    }
}

