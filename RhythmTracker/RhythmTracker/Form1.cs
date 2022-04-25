using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhythmTracker
{
    public partial class Form1 : Form
    {
        private bool recording = false;
        //private bool firstPress = true;
        private List<string> pressedKeys = new List<string>();
        private List<keyPress> keyList = new List<keyPress>();
        private long firstPress = 0;
        private DateTimeOffset now;
        private TextWriter txt;
        private long lastPressed = 0;

        private class keyPress
        {
            public string keyPressed = "";
            public long pressTime = 1;
            public long releaseTime = 1;

            public keyPress(string keyPressed, long pressTime, long releaseTime)
            {
                this.keyPressed = keyPressed;
                this.pressTime = pressTime;
                this.releaseTime = releaseTime;
            }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPressed(object sender, KeyEventArgs e)
        {
            if (recording)
            {
                if (!pressedKeys.Contains(e.KeyCode.ToString()))
                {
                    pressedKeys.Add(e.KeyCode.ToString());
                    if (firstPress == 0)
                    {
                        now = DateTimeOffset.UtcNow;
                        firstPress = now.ToUnixTimeMilliseconds();
                    }
                    //else
                    //{
                    //    firstPress = releaseTime;
                    //}
                    now = DateTimeOffset.UtcNow;
                    keyList.Add(new keyPress(e.KeyCode.ToString(), now.ToUnixTimeMilliseconds(), 0));
                    //pressTime = now.ToUnixTimeMilliseconds();
                    //keyPressed = e.KeyCode.ToString();
                }
            }
        }

        private void buttonLifted(object sender, KeyEventArgs e)
        {
            if (recording)
            {
                keyPress key = null;
                foreach (keyPress k in keyList){
                    if (k.keyPressed.Equals(e.KeyCode.ToString())){
                        key = k;
                        break;
                    }
                }
                keyList.Remove(key);
                now = DateTimeOffset.UtcNow;
                key.releaseTime = now.ToUnixTimeMilliseconds();
                trackTime(key);
                pressedKeys.Remove(e.KeyCode.ToString());
            }
        }

        private void trackTime(keyPress kp)
        {
            long waitTime = kp.pressTime - firstPress;
            long endtime = kp.releaseTime - firstPress;
            long keydownTime = kp.releaseTime - kp.pressTime;
            long pausesince = kp.pressTime - lastPressed;
            if(lastPressed == 0)
            {
                pausesince = 0;
            }
            txt.Write("Pressed from: " + waitTime + " to " + endtime + "\n");
            txt.Write("Pressed key '" + kp.keyPressed + "' for " + keydownTime + " milliseconds\n");
            txt.Write("Pause since previous note: " + pausesince  + "\n\n");
            lastPressed = kp.releaseTime;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!recording)
            {
                firstPress = 0;
                recording = true;
                string id;
                if (string.IsNullOrEmpty(idBox.Text))
                {
                    id = "noID";
                }
                else
                {
                    id = idBox.Text;
                }
                txt = new StreamWriter(".\\" + id + ".txt", true);
                recLabel.Text = "Recording";
                recLabel.ForeColor = Color.Green;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (recording)
            {
                recording = false;
                txt.Write("\n\n");
                txt.Close();
                recLabel.Text = "Not recording";
                recLabel.ForeColor = Color.Red;
            }
        }
    }
}
