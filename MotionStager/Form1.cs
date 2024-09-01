using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace MotionStager
{
    public partial class MotionForm : Form
    {
        public MotionForm()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            frames = new Dictionary<int, ArrayList>();
            CurrentPos = new ArrayList();
            CurrentPos.Add(0);
            CurrentPos.Add(0);
            CurrentPos.Add(0);
            MoveRate.SelectedIndex = 0;
            ZCurent.Text = "0";
            YCurrent.Text = "0";
            XCurent.Text = "0";
            currentFrame = -1;
            foreach (string porter in ports)
            {

                SerialDevices.Items.Add(porter);

            }
            SerialDevices.SelectedIndex = 0;
        }
        Dictionary<int, ArrayList> frames;
        ArrayList CurrentPos;
        private SerialPort MotionPort;
        int currentFrame;
        private SerialPort initialize_PORT(String port)
        {

            SerialPort COMPORT = new SerialPort();
            COMPORT.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            COMPORT.PortName = port;
            COMPORT.BaudRate = 115200;
            COMPORT.ReadTimeout = 500;
            COMPORT.WriteTimeout = 500;
            COMPORT.DtrEnable = true;
            //Thread.Sleep(100);
            COMPORT.Parity = Parity.None;
            COMPORT.DataBits = 8;
            COMPORT.StopBits = System.IO.Ports.StopBits.One;
            COMPORT.Handshake = Handshake.None;
            currentFrame = 0;
            return COMPORT;
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                String DispString;
                DispString = ((SerialPort)sender).ReadLine();
                if (DispString.Contains("Pos"))
                {

                }
                Messages.Items.Add("Recieved " + DispString);
            }
            catch (Exception ex)
            {
                Messages.Items.Add(ex.ToString());
            }
        }
        private void WriteToPort(SerialPort SerPort, String Data)
        {
            /*byte[] byData = System.Text.Encoding.ASCII.GetBytes(Data);
            foreach (byte BYT in byData)
            {
                SerPort.BaseStream.WriteByte(BYT);
            }*/
            try
            {
                SerPort.WriteLine(Data);
                Thread.Sleep(4);
                Messages.Items.Add("Sent " + Data);
            }
            catch (Exception Ex)
            {
                Messages.Items.Add(Ex.ToString());
            }

        }

        private void SerialConnect_Click(object sender, EventArgs e)
        {
            if (SerialDevices.Text.CompareTo("") != 0)
            {
                try
                {
                    MotionPort = initialize_PORT(SerialDevices.Text);
                    MotionPort.Open();
                    Messages.Items.Add("Connected");
                    WriteToPort(MotionPort, "\r\n\r\n");
                    WriteToPort(MotionPort, "G21");

                }
                catch (Exception Ex)
                {
                    Messages.Items.Add(Ex.ToString());
                }
            }
            else
            {
                Messages.Items.Add("Please Select port");
            }
        }

        private void MotionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                MotionPort.Close();
            }
            catch (Exception Ex)
            {

            }
        }

        private void Zup_Click(object sender, EventArgs e)
        {
            WriteToPort(MotionPort, "G91");
            WriteToPort(MotionPort, String.Format("G0 Z{0}", MoveRate.Text));
            CurrentPos[2] = Convert.ToDouble(CurrentPos[2]) + Convert.ToDouble(MoveRate.Text);
            updatePOS(Convert.ToDouble(CurrentPos[0]), Convert.ToDouble(CurrentPos[1]), Convert.ToDouble(CurrentPos[2]));
        }

        private void Zdown_Click(object sender, EventArgs e)
        {
            WriteToPort(MotionPort, "G91");
            WriteToPort(MotionPort, String.Format("G0 Z-{0}", MoveRate.Text));
            CurrentPos[2] = Convert.ToDouble(CurrentPos[2]) - Convert.ToDouble(MoveRate.Text);
            updatePOS(Convert.ToDouble(CurrentPos[0]), Convert.ToDouble(CurrentPos[1]), Convert.ToDouble(CurrentPos[2]));
        }

        private void Xdown_Click(object sender, EventArgs e)
        {
            WriteToPort(MotionPort, "G91");
            WriteToPort(MotionPort, String.Format("G0 X-{0}", MoveRate.Text));
            CurrentPos[0] = Convert.ToDouble(CurrentPos[0]) - Convert.ToDouble(MoveRate.Text);
            updatePOS(Convert.ToDouble(CurrentPos[0]), Convert.ToDouble(CurrentPos[1]), Convert.ToDouble(CurrentPos[2]));
            //G0 X
        }

        private void Yup_Click(object sender, EventArgs e)
        {
            WriteToPort(MotionPort, "G91");
            WriteToPort(MotionPort, String.Format("G0 Y{0}", MoveRate.Text));
            CurrentPos[1] = Convert.ToDouble(CurrentPos[1]) + Convert.ToDouble(MoveRate.Text);
            updatePOS(Convert.ToDouble(CurrentPos[0]), Convert.ToDouble(CurrentPos[1]), Convert.ToDouble(CurrentPos[2]));
        }

        private void StopMotion_Click(object sender, EventArgs e)
        {
            WriteToPort(MotionPort, "?");
        }

        private void Ydown_Click(object sender, EventArgs e)
        {
            WriteToPort(MotionPort, "G91");
            WriteToPort(MotionPort, String.Format("G0 Y-{0}", MoveRate.Text));
            CurrentPos[1] = Convert.ToDouble(CurrentPos[1]) - Convert.ToDouble(MoveRate.Text);
            updatePOS(Convert.ToDouble(CurrentPos[0]), Convert.ToDouble(CurrentPos[1]), Convert.ToDouble(CurrentPos[2]));
        }

        private void Xup_Click(object sender, EventArgs e)
        {
            WriteToPort(MotionPort, "G91");
            WriteToPort(MotionPort, String.Format("G0 X{0}", MoveRate.Text));
            CurrentPos[0] = Convert.ToDouble(CurrentPos[0]) + Convert.ToDouble(MoveRate.Text);
            updatePOS(Convert.ToDouble(CurrentPos[0]), Convert.ToDouble(CurrentPos[1]), Convert.ToDouble(CurrentPos[2]));
        }

        private void Set0_Click(object sender, EventArgs e)
        {
            try
            {
                MotionPort.Close();
            }
            catch (Exception Ex)
            {

            }
            if (SerialDevices.Text.CompareTo("") != 0)
            {
                try
                {
                    MotionPort = initialize_PORT(SerialDevices.Text);
                    MotionPort.Open();
                    Messages.Items.Add("Connected");
                    WriteToPort(MotionPort, "\r\n\r\n");
                    WriteToPort(MotionPort, "G21");

                }
                catch (Exception Ex)
                {
                    Messages.Items.Add(Ex.ToString());
                }
            }
            else
            {
                Messages.Items.Add("Please Select port");
            }
            CurrentPos[0] = Convert.ToDouble(0);
            CurrentPos[1] = Convert.ToDouble(0);
            CurrentPos[2] = Convert.ToDouble(0);
            updatePOS(Convert.ToDouble(CurrentPos[0]), Convert.ToDouble(CurrentPos[1]), Convert.ToDouble(CurrentPos[2]));
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            WriteToPort(MotionPort, "G30");
            CurrentPos[0] = Convert.ToDouble(0);
            CurrentPos[1] = Convert.ToDouble(0);
            CurrentPos[2] = Convert.ToDouble(0);
            updatePOS(Convert.ToDouble(CurrentPos[0]), Convert.ToDouble(CurrentPos[1]), Convert.ToDouble(CurrentPos[2]));
        }

        private void PrevFrame_Click(object sender, EventArgs e)
        {
            //CurrentPos=frames.
            if(currentFrame==-1)
            {
                WriteToPort(MotionPort, "G30");
            }
            else
            {
                currentFrame -= 1;
                if(currentFrame==-1)
                {
                    WriteToPort(MotionPort, "G30");
                    currentFrame = 0;
                }
                else
                {
                    if(frames.ContainsKey(currentFrame))
                    {

                        CurrentPos[0]= Convert.ToDouble(frames[currentFrame][0]);
                        CurrentPos[1] = Convert.ToDouble(frames[currentFrame][1]);
                        CurrentPos[2] = Convert.ToDouble(frames[currentFrame][2]);
                        WriteToPort(MotionPort, String.Format("G0 X{0} Y{1} Z{2}",CurrentPos[0], CurrentPos[1], CurrentPos[2]));
                        updatePOS(Convert.ToDouble(CurrentPos[0]), Convert.ToDouble(CurrentPos[1]), Convert.ToDouble(CurrentPos[2]));
                    }
                    else
                    {
                        WriteToPort(MotionPort, "G30");
                    }
                }
            }
        }

        private void AdvanceFrame_Click(object sender, EventArgs e)
        {
            if((currentFrame+1)>frames.Count)
            {
                Messages.Items.Add("At the End Already");
            }
            else
            {
                if(frames.ContainsKey(currentFrame+1))
                {
                    currentFrame += 1;

                    CurrentPos[0] = Convert.ToDouble(frames[currentFrame][0]);
                    CurrentPos[1] = Convert.ToDouble(frames[currentFrame][1]);
                    CurrentPos[2] = Convert.ToDouble(frames[currentFrame][2]);
                    WriteToPort(MotionPort, String.Format("G0 X{0} Y{1} Z{2}", CurrentPos[0], CurrentPos[1], CurrentPos[2]));
                    updatePOS(Convert.ToDouble(CurrentPos[0]), Convert.ToDouble(CurrentPos[1]), Convert.ToDouble(CurrentPos[2]));
                }
            }
        }

        private void adFrame_Click(object sender, EventArgs e)
        {
            frames.Add(frames.Count - 1, new ArrayList());
            frames[frames.Count - 2].Add(CurrentPos[0]);
            frames[frames.Count - 2].Add(CurrentPos[1]);
            frames[frames.Count - 2].Add(CurrentPos[2]);
            frames[frames.Count - 2].Add(Convert.ToInt32(FeedSeconds.Text)*60);
            frames[frames.Count - 2].Add(FrameName.Text);
            FrameList.Items.Add(FrameName.Text + " " + FeedSeconds.Text + " Sec k"+(frames.Count - 2).ToString());
        }

        private void DeleteCurrentFrame_Click(object sender, EventArgs e)
        {
            if (frames.ContainsKey(currentFrame))
            {
                if (currentFrame == -1)
                {
                    FrameList.Items.RemoveAt(0);
                    //currentFrame = 0;
                }
                else
                {
                    FrameList.Items.RemoveAt(currentFrame);
                }

                frames.Remove(currentFrame);
                currentFrame -= 1;
                if (currentFrame <-1)
                {
                    currentFrame = -1;
                }
            }
        }
        private void updatePOS(Double x,Double y, Double z)
        {
            XCurent.Text = x.ToString();
            YCurrent.Text = y.ToString();
            ZCurent.Text = z.ToString();
            this.Refresh();
        }
        private void Play_Click(object sender, EventArgs e)
        {
            //loop the dictionary
            WriteToPort(MotionPort, "G30");
            CurrentPos[0] = Convert.ToDouble(0);
            CurrentPos[1] = Convert.ToDouble(0);
            CurrentPos[2] = Convert.ToDouble(0);
            updatePOS(Convert.ToDouble(CurrentPos[0]), Convert.ToDouble(CurrentPos[1]), Convert.ToDouble(CurrentPos[2]));
            WriteToPort(MotionPort, "G90");
            foreach (KeyValuePair<int,ArrayList> Sequence in frames)
            {
                currentFrame = Sequence.Key;
                WriteToPort(MotionPort, String.Format("G1 X{0} Y{1} Z{2} f{3}",Sequence.Value[0], Sequence.Value[1], Sequence.Value[2], Sequence.Value[3]));
                CurrentPos[0] = Convert.ToDouble(Sequence.Value[0]);
                CurrentPos[1] = Convert.ToDouble(Sequence.Value[1]);
                CurrentPos[2] = Convert.ToDouble(Sequence.Value[2]);
                updatePOS(Convert.ToDouble(CurrentPos[0]), Convert.ToDouble(CurrentPos[1]), Convert.ToDouble(CurrentPos[2]));
                
            }
            currentFrame = 0;
            WriteToPort(MotionPort, "G30");
            CurrentPos[0] = Convert.ToDouble(0);
            CurrentPos[1] = Convert.ToDouble(0);
            CurrentPos[2] = Convert.ToDouble(0);
            updatePOS(Convert.ToDouble(CurrentPos[0]), Convert.ToDouble(CurrentPos[1]), Convert.ToDouble(CurrentPos[2]));
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            //Return to last Frame
            if (frames.ContainsKey(currentFrame))
            {
                currentFrame += 1;
                CurrentPos[0] = Convert.ToDouble(frames[currentFrame][0]);
                CurrentPos[1] = Convert.ToDouble(frames[currentFrame][1]);
                CurrentPos[2] = Convert.ToDouble(frames[currentFrame][2]);
                WriteToPort(MotionPort, String.Format("G0 X{0} Y{1} Z{2}", CurrentPos[0], CurrentPos[1], CurrentPos[2]));
                updatePOS(Convert.ToDouble(CurrentPos[0]), Convert.ToDouble(CurrentPos[1]), Convert.ToDouble(CurrentPos[2]));
            }
        }

        private void DeleteSelectedFeame_Click(object sender, EventArgs e)
        {
            if (frames.ContainsKey(FrameList.SelectedIndex-1))
            {
            
                    FrameList.Items.RemoveAt(FrameList.SelectedIndex);
                frames.Remove(FrameList.SelectedIndex - 1);

                currentFrame = -1;
               
            }
        }

        private void MoveToSelectedFrame_Click(object sender, EventArgs e)
        {
            if (frames.ContainsKey(FrameList.SelectedIndex - 1))
            {
                currentFrame=FrameList.SelectedIndex - 1;
                CurrentPos[0] = Convert.ToDouble(frames[currentFrame][0]);
                CurrentPos[1] = Convert.ToDouble(frames[currentFrame][1]);
                CurrentPos[2] = Convert.ToDouble(frames[currentFrame][2]);
                WriteToPort(MotionPort, String.Format("G0 X{0} Y{1} Z{2}", CurrentPos[0], CurrentPos[1], CurrentPos[2]));
                updatePOS(Convert.ToDouble(CurrentPos[0]), Convert.ToDouble(CurrentPos[1]), Convert.ToDouble(CurrentPos[2]));
            }
        }
    }
}
