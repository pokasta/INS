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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace ANPPExample
{
    public partial class Form1 : Form
    {
        Boolean serialConnected = false;
        ANPacketDecoder anPacketDecoder;

        public Form1()
        {
            InitializeComponent();
            anPacketDecoder = new ANPacketDecoder();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBaud.SelectedIndex = 7;
            updatePorts();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updatePorts();
        }

        private void updatePorts()
        {
            if (!serialConnected)
            {
                string[] ports = System.IO.Ports.SerialPort.GetPortNames();
                Boolean portsChanged = ports.Length != comboPort.Items.Count;
                if (!portsChanged)
                {
                    for(int i=0; i < ports.Length; i++)
                    {
                        if(ports[i].CompareTo(comboPort.Items[i].ToString()) != 0)
                        {
                            portsChanged = true;
                            break;
                        }
                    }
                }
                if (portsChanged)
                {
                    comboPort.Items.Clear();
                    foreach (string portName in ports)
                    {
                        comboPort.Items.Add((object)portName);
                    }
                    if (ports.Length > 0)
                    {
                        comboPort.SelectedIndex = 0;
                    }
                }
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (serialConnected)
            {
                try
                {
                    serialPort1.Close();
                    buttonConnect.Text = "Connect";
                    serialConnected = false;
                }
                catch { }
            }
            else
            {
                try
                {
                    serialPort1.PortName = comboPort.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBaud.Text);
                    serialPort1.Open();
                    buttonConnect.Text = "Disconnect";
                    serialConnected = true;
                }
                catch { }
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                anPacketDecoder.bufferLength += serialPort1.Read(anPacketDecoder.buffer, anPacketDecoder.bufferLength, anPacketDecoder.buffer.Length - anPacketDecoder.bufferLength);
                ANPacket packet = null;
                while ((packet = anPacketDecoder.packetDecode()) != null)
                {
                    switch (packet.id)
                    {
                        /* case ANPacket.PACKET_ID_SYSTEM_STATE:
                             if (packet.length == 100)
                             {
                                 ANPacket20 anPacket20 = new ANPacket20(packet);
                                 this.Invoke((MethodInvoker)delegate
                                 {
                                     richTextBox1.AppendText("Received System State Packet\n");
                                     textBoxLatitude.Text = (anPacket20.position[0] * 180 / Math.PI).ToString();
                                     textBoxLongitude.Text = (anPacket20.position[1] * 180 / Math.PI).ToString();
                                     textBoxHeight.Text = anPacket20.position[2].ToString();
                                     textBoxRoll.Text = (anPacket20.orientation[0] * 180 / Math.PI).ToString();
                                     textBoxPitch.Text = (anPacket20.orientation[1] * 180 / Math.PI).ToString();
                                     textBoxYaw.Text = (anPacket20.orientation[2] * 180 / Math.PI).ToString();
                                 });
                             }
                             break;*/
                        case ANPacket.PACKET_ID_RAW_SENSORS:
                            if (packet.length == 48)
                            {


                                float sum = 0f;
                                ANPacket28 anPacket28 = new ANPacket28(packet);
                                float[] arr = new float[1000];
                                List<float> arr1 = new List<float>();
                                List<float> arr2 = new List<float>();
                                List<float> arr3 = new List<float>();
                                



                                this.Invoke((MethodInvoker)delegate
                                {
                                    

                                    richTextBox1.AppendText("Received Raw Sensors Packet\n");
                                    String mystring1 = anPacket28.accelerometers[0].ToString();
                                    String mystring2 = anPacket28.accelerometers[1].ToString();
                                    String mystring3 = anPacket28.accelerometers[2].ToString();

                                    textBox1.Text = (mystring1);
                                    textBox3.Text = (mystring2);
                                    textBox4.Text = (mystring3);

                                    String mystring4 = anPacket28.gyroscopes[0].ToString();
                                    String mystring5 = anPacket28.gyroscopes[1].ToString();
                                    String mystring6 = anPacket28.gyroscopes[2].ToString();
                                    textBox2.Text = (mystring4);
                                    textBox5.Text = (mystring5);
                                    textBox6.Text = (mystring6);
                                    String mystring7 = anPacket28.magnetometers[0].ToString();
                                    String mystring8 = anPacket28.magnetometers[1].ToString();
                                    String mystring9 = anPacket28.magnetometers[2].ToString();
                                    textBox9.Text = (mystring7);
                                    textBox8.Text = (mystring8);
                                    textBox7.Text = (mystring9);
                                    String mystring10 = anPacket28.pressure.ToString();
                                    textBox10.Text = (mystring10);
                                    String mystring11 = anPacket28.pressureTemperature.ToString();
                                    textBox11.Text = (mystring11);
                                    //Thread.Sleep(90);
                                    /* if (anPacket28.pressureTemperature == 0)
                                         Console.WriteLine("Come Out");
                                     else
                                     {


                                         Console.WriteLine("AVG =" + arr.Average());


                                     }*/
                                    //arr.Add(anPacket28.magnetometers[0]);
                                    /* for(int i=0;i<1000;i++)
                                      {
                                          arr[i] = anPacket28.magnetometers[0];
                                           sum =sum +arr[i];
                                      }
                                      float avg = sum / 1000;
                                     Console.WriteLine("Avg ="+(sum / 1000));

                                    Console.WriteLine("Count =" + arr[20]);*/

                                    for (int i = 0; i < 1000; i++)
                                          {
                                        arr1.Add(anPacket28.magnetometers[0]);
                                       
                                          sum = arr1.Sum();
                                        
                                       

                                            }

                                            float avg = (sum / arr1.Count);
                                            Console.WriteLine(arr1.Count);



                                            String mystr = avg.ToString();
                                            textBox16.Text = mystr;


                                    








                                    /*  float avg = (sum / 500);
                                      Console.WriteLine(arr1.Count);



                                     String mystr = avg.ToString();
                                     textBox16.Text = mystr;*/
                                });

                          
                            }







                            break;
                        case ANPacket.PACKET_ID_SYSTEM_STATE:
                            if (packet.length == 100)
                            {
                                ANPacket20 anPacket20 = new ANPacket20(packet);
                                this.Invoke((MethodInvoker)delegate
                                {
                                    richTextBox1.AppendText("Received System State Packet\n");
                                    textBoxLatitude.Text = (anPacket20.position[0] * 180 / Math.PI).ToString();
                                    textBoxLongitude.Text = (anPacket20.position[1] * 180 / Math.PI).ToString();
                                    textBoxHeight.Text = anPacket20.position[2].ToString();
                                    textBoxRoll.Text = (anPacket20.orientation[0] * 180 / Math.PI).ToString();
                                    textBoxPitch.Text = (anPacket20.orientation[1] * 180 / Math.PI).ToString();
                                    textBoxYaw.Text = (anPacket20.orientation[2] * 180 / Math.PI).ToString();
                                    String mystring1 = anPacket20.position[0].ToString();
                                    textBox15.Text = mystring1;
                                    String mystring2 = anPacket20.position[1].ToString();
                                    textBox17.Text = mystring2;
                                    String mystring3= anPacket20.position[2].ToString();
                                    textBox18.Text = mystring3;
                                    String mystring4 = anPacket20.velocity[0].ToString();
                                    String mystring5 = anPacket20.velocity[1].ToString();
                                    String mystring6 = anPacket20.velocity[2].ToString();
                                    textBox12.Text = mystring4;
                                    textBox13.Text = mystring5;
                                    textBox14.Text = mystring6;

                                   
                                });
                            }
                            break;
                    }
                }
            }

            catch { }
        }

        private void TextBoxLatitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void TextBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox33_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
