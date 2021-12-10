using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SevenSegmentClock
{
    public partial class Form1 : Form
    {
        Color TimeColor1 = ColorTranslator.FromHtml("#00FFFF");
        Color TimeColor0 = Color.Transparent;

        Color DayColor1 = ColorTranslator.FromHtml("#0E1EFF");
        Color DayColor0 = Color.Transparent;

        Color DateColor1 = ColorTranslator.FromHtml("#FF00FF");
        Color DateColor2 = Color.Transparent;

        Color backgroundColor = Color.Transparent;

        int flag = 1;
        string hourFormat = "hh";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelMeridiemAM.BackColor = backgroundColor;
            labelMeridiemPM.BackColor = backgroundColor;

            foreach (Control x in Controls)
            {
                if (x.Tag == "dayBtn")
                {
                    x.BackColor = TimeColor0;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //for seconds
            string seconds = DateTime.Now.ToString("ss");

            int secondsOnes = Convert.ToInt32(seconds.Substring(1));
            int secondsTens = Convert.ToInt32(seconds.Remove(1, 1));

            //for minutes
            string minutes = DateTime.Now.ToString("mm");

            int minutesOnes = Convert.ToInt32(minutes.Substring(1));
            int minutesTens = Convert.ToInt32(minutes.Remove(1, 1));

            //for hours
            string hours = DateTime.Now.ToString(hourFormat);

            int hoursOnes = Convert.ToInt32(hours.Substring(1));
            int hoursTens = Convert.ToInt32(hours.Remove(1, 1));

            //AM or PM
            string meridiem = DateTime.Now.ToString("tt");

            //for day name
            string dayName = DateTime.Now.ToString("ddd");

            //for month name
            string monthName = DateTime.Now.ToString("MMM");

            //for the day of the month
            string dayDigits = DateTime.Now.ToString("dd");

            //Calling the functions
            sevenSegment(secondsOnes, "Seconds", "Ones");
            sevenSegment(secondsTens, "Seconds", "Tens");

            sevenSegment(minutesOnes, "Minutes", "Ones");
            sevenSegment(minutesTens, "Minutes", "Tens");

            sevenSegment(hoursOnes, "Hours", "Ones");
            sevenSegment(hoursTens, "Hours", "Tens");


            BlinkingDot();
            Meridiem(meridiem);
            DayNameController(dayName);
            MonthNameController(monthName);
            DayDigitsController(dayDigits);
        }

        private void sevenSegment(int num, string indicator, string placeValue)
        {
            switch (indicator)
            {
                case "Seconds":
                    switch (placeValue)
                    {
                        case "Ones":
                            switch (num)
                            {
                                case 0:
                                    btnSec1A.BackColor = TimeColor1;
                                    btnSec1B.BackColor = TimeColor1;
                                    btnSec1C.BackColor = TimeColor1;
                                    btnSec1D.BackColor = TimeColor1;
                                    btnSec1E.BackColor = TimeColor1;
                                    btnSec1F.BackColor = TimeColor1;
                                    btnSec1G.BackColor = TimeColor0;
                                    break;

                                case 1:
                                    btnSec1A.BackColor = TimeColor0;
                                    btnSec1B.BackColor = TimeColor1;
                                    btnSec1C.BackColor = TimeColor1;
                                    btnSec1D.BackColor = TimeColor0;
                                    btnSec1E.BackColor = TimeColor0;
                                    btnSec1F.BackColor = TimeColor0;
                                    btnSec1G.BackColor = TimeColor0;
                                    break;

                                case 2:
                                    btnSec1A.BackColor = TimeColor1;
                                    btnSec1B.BackColor = TimeColor1;
                                    btnSec1C.BackColor = TimeColor0;
                                    btnSec1D.BackColor = TimeColor1;
                                    btnSec1E.BackColor = TimeColor1;
                                    btnSec1F.BackColor = TimeColor0;
                                    btnSec1G.BackColor = TimeColor1;
                                    break;

                                case 3:
                                    btnSec1A.BackColor = TimeColor1;
                                    btnSec1B.BackColor = TimeColor1;
                                    btnSec1C.BackColor = TimeColor1;
                                    btnSec1D.BackColor = TimeColor1;
                                    btnSec1E.BackColor = TimeColor0;
                                    btnSec1F.BackColor = TimeColor0;
                                    btnSec1G.BackColor = TimeColor1;
                                    break;

                                case 4:
                                    btnSec1A.BackColor = TimeColor0;
                                    btnSec1B.BackColor = TimeColor1;
                                    btnSec1C.BackColor = TimeColor1;
                                    btnSec1D.BackColor = TimeColor0;
                                    btnSec1E.BackColor = TimeColor0;
                                    btnSec1F.BackColor = TimeColor1;
                                    btnSec1G.BackColor = TimeColor1;
                                    break;

                                case 5:
                                    btnSec1A.BackColor = TimeColor1;
                                    btnSec1B.BackColor = TimeColor0;
                                    btnSec1C.BackColor = TimeColor1;
                                    btnSec1D.BackColor = TimeColor1;
                                    btnSec1E.BackColor = TimeColor0;
                                    btnSec1F.BackColor = TimeColor1;
                                    btnSec1G.BackColor = TimeColor1;
                                    break;

                                case 6:
                                    btnSec1A.BackColor = TimeColor1;
                                    btnSec1B.BackColor = TimeColor0;
                                    btnSec1C.BackColor = TimeColor1;
                                    btnSec1D.BackColor = TimeColor1;
                                    btnSec1E.BackColor = TimeColor1;
                                    btnSec1F.BackColor = TimeColor1;
                                    btnSec1G.BackColor = TimeColor1;
                                    break;

                                case 7:
                                    btnSec1A.BackColor = TimeColor1;
                                    btnSec1B.BackColor = TimeColor1;
                                    btnSec1C.BackColor = TimeColor1;
                                    btnSec1D.BackColor = TimeColor0;
                                    btnSec1E.BackColor = TimeColor0;
                                    btnSec1F.BackColor = TimeColor0;
                                    btnSec1G.BackColor = TimeColor0;
                                    break;

                                case 8:
                                    btnSec1A.BackColor = TimeColor1;
                                    btnSec1B.BackColor = TimeColor1;
                                    btnSec1C.BackColor = TimeColor1;
                                    btnSec1D.BackColor = TimeColor1;
                                    btnSec1E.BackColor = TimeColor1;
                                    btnSec1F.BackColor = TimeColor1;
                                    btnSec1G.BackColor = TimeColor1;
                                    break;

                                case 9:
                                    btnSec1A.BackColor = TimeColor1;
                                    btnSec1B.BackColor = TimeColor1;
                                    btnSec1C.BackColor = TimeColor1;
                                    btnSec1D.BackColor = TimeColor1;
                                    btnSec1E.BackColor = TimeColor0;
                                    btnSec1F.BackColor = TimeColor1;
                                    btnSec1G.BackColor = TimeColor1;
                                    break;
                            }
                            break;

                        case "Tens":
                            switch (num)
                            {
                                case 0:
                                    btnSec2A.BackColor = TimeColor1;
                                    btnSec2B.BackColor = TimeColor1;
                                    btnSec2C.BackColor = TimeColor1;
                                    btnSec2D.BackColor = TimeColor1;
                                    btnSec2E.BackColor = TimeColor1;
                                    btnSec2F.BackColor = TimeColor1;
                                    btnSec2G.BackColor = TimeColor0;
                                    break;

                                case 1:
                                    btnSec2A.BackColor = TimeColor0;
                                    btnSec2B.BackColor = TimeColor1;
                                    btnSec2C.BackColor = TimeColor1;
                                    btnSec2D.BackColor = TimeColor0;
                                    btnSec2E.BackColor = TimeColor0;
                                    btnSec2F.BackColor = TimeColor0;
                                    btnSec2G.BackColor = TimeColor0;
                                    break;

                                case 2:
                                    btnSec2A.BackColor = TimeColor1;
                                    btnSec2B.BackColor = TimeColor1;
                                    btnSec2C.BackColor = TimeColor0;
                                    btnSec2D.BackColor = TimeColor1;
                                    btnSec2E.BackColor = TimeColor1;
                                    btnSec2F.BackColor = TimeColor0;
                                    btnSec2G.BackColor = TimeColor1;
                                    break;

                                case 3:
                                    btnSec2A.BackColor = TimeColor1;
                                    btnSec2B.BackColor = TimeColor1;
                                    btnSec2C.BackColor = TimeColor1;
                                    btnSec2D.BackColor = TimeColor1;
                                    btnSec2E.BackColor = TimeColor0;
                                    btnSec2F.BackColor = TimeColor0;
                                    btnSec2G.BackColor = TimeColor1;
                                    break;

                                case 4:
                                    btnSec2A.BackColor = TimeColor0;
                                    btnSec2B.BackColor = TimeColor1;
                                    btnSec2C.BackColor = TimeColor1;
                                    btnSec2D.BackColor = TimeColor0;
                                    btnSec2E.BackColor = TimeColor0;
                                    btnSec2F.BackColor = TimeColor1;
                                    btnSec2G.BackColor = TimeColor1;
                                    break;

                                case 5:
                                    btnSec2A.BackColor = TimeColor1;
                                    btnSec2B.BackColor = TimeColor0;
                                    btnSec2C.BackColor = TimeColor1;
                                    btnSec2D.BackColor = TimeColor1;
                                    btnSec2E.BackColor = TimeColor0;
                                    btnSec2F.BackColor = TimeColor1;
                                    btnSec2G.BackColor = TimeColor1;
                                    break;

                                case 6:
                                    btnSec2A.BackColor = TimeColor1;
                                    btnSec2B.BackColor = TimeColor0;
                                    btnSec2C.BackColor = TimeColor1;
                                    btnSec2D.BackColor = TimeColor1;
                                    btnSec2E.BackColor = TimeColor1;
                                    btnSec2F.BackColor = TimeColor1;
                                    btnSec2G.BackColor = TimeColor1;
                                    break;

                                case 7:
                                    btnSec2A.BackColor = TimeColor1;
                                    btnSec2B.BackColor = TimeColor1;
                                    btnSec2C.BackColor = TimeColor1;
                                    btnSec2D.BackColor = TimeColor0;
                                    btnSec2E.BackColor = TimeColor0;
                                    btnSec2F.BackColor = TimeColor0;
                                    btnSec2G.BackColor = TimeColor0;
                                    break;

                                case 8:
                                    btnSec2A.BackColor = TimeColor1;
                                    btnSec2B.BackColor = TimeColor1;
                                    btnSec2C.BackColor = TimeColor1;
                                    btnSec2D.BackColor = TimeColor1;
                                    btnSec2E.BackColor = TimeColor1;
                                    btnSec2F.BackColor = TimeColor1;
                                    btnSec2G.BackColor = TimeColor1;
                                    break;

                                case 9:
                                    btnSec2A.BackColor = TimeColor1;
                                    btnSec2B.BackColor = TimeColor1;
                                    btnSec2C.BackColor = TimeColor1;
                                    btnSec2D.BackColor = TimeColor1;
                                    btnSec2E.BackColor = TimeColor0;
                                    btnSec2F.BackColor = TimeColor1;
                                    btnSec2G.BackColor = TimeColor1;
                                    break;
                            }
                            break;
                    }
                    break;

                case "Minutes":
                    switch (placeValue)
                    {
                        case "Ones":
                            switch (num)
                            {
                                case 0:
                                    btnMin1A.BackColor = TimeColor1;
                                    btnMin1B.BackColor = TimeColor1;
                                    btnMin1C.BackColor = TimeColor1;
                                    btnMin1D.BackColor = TimeColor1;
                                    btnMin1E.BackColor = TimeColor1;
                                    btnMin1F.BackColor = TimeColor1;
                                    btnMin1G.BackColor = TimeColor0;
                                    break;

                                case 1:
                                    btnMin1A.BackColor = TimeColor0;
                                    btnMin1B.BackColor = TimeColor1;
                                    btnMin1C.BackColor = TimeColor1;
                                    btnMin1D.BackColor = TimeColor0;
                                    btnMin1E.BackColor = TimeColor0;
                                    btnMin1F.BackColor = TimeColor0;
                                    btnMin1G.BackColor = TimeColor0;
                                    break;

                                case 2:
                                    btnMin1A.BackColor = TimeColor1;
                                    btnMin1B.BackColor = TimeColor1;
                                    btnMin1C.BackColor = TimeColor0;
                                    btnMin1D.BackColor = TimeColor1;
                                    btnMin1E.BackColor = TimeColor1;
                                    btnMin1F.BackColor = TimeColor0;
                                    btnMin1G.BackColor = TimeColor1;
                                    break;

                                case 3:
                                    btnMin1A.BackColor = TimeColor1;
                                    btnMin1B.BackColor = TimeColor1;
                                    btnMin1C.BackColor = TimeColor1;
                                    btnMin1D.BackColor = TimeColor1;
                                    btnMin1E.BackColor = TimeColor0;
                                    btnMin1F.BackColor = TimeColor0;
                                    btnMin1G.BackColor = TimeColor1;
                                    break;

                                case 4:
                                    btnMin1A.BackColor = TimeColor0;
                                    btnMin1B.BackColor = TimeColor1;
                                    btnMin1C.BackColor = TimeColor1;
                                    btnMin1D.BackColor = TimeColor0;
                                    btnMin1E.BackColor = TimeColor0;
                                    btnMin1F.BackColor = TimeColor1;
                                    btnMin1G.BackColor = TimeColor1;
                                    break;

                                case 5:
                                    btnMin1A.BackColor = TimeColor1;
                                    btnMin1B.BackColor = TimeColor0;
                                    btnMin1C.BackColor = TimeColor1;
                                    btnMin1D.BackColor = TimeColor1;
                                    btnMin1E.BackColor = TimeColor0;
                                    btnMin1F.BackColor = TimeColor1;
                                    btnMin1G.BackColor = TimeColor1;
                                    break;

                                case 6:
                                    btnMin1A.BackColor = TimeColor1;
                                    btnMin1B.BackColor = TimeColor0;
                                    btnMin1C.BackColor = TimeColor1;
                                    btnMin1D.BackColor = TimeColor1;
                                    btnMin1E.BackColor = TimeColor1;
                                    btnMin1F.BackColor = TimeColor1;
                                    btnMin1G.BackColor = TimeColor1;
                                    break;

                                case 7:
                                    btnMin1A.BackColor = TimeColor1;
                                    btnMin1B.BackColor = TimeColor1;
                                    btnMin1C.BackColor = TimeColor1;
                                    btnMin1D.BackColor = TimeColor0;
                                    btnMin1E.BackColor = TimeColor0;
                                    btnMin1F.BackColor = TimeColor0;
                                    btnMin1G.BackColor = TimeColor0;
                                    break;

                                case 8:
                                    btnMin1A.BackColor = TimeColor1;
                                    btnMin1B.BackColor = TimeColor1;
                                    btnMin1C.BackColor = TimeColor1;
                                    btnMin1D.BackColor = TimeColor1;
                                    btnMin1E.BackColor = TimeColor1;
                                    btnMin1F.BackColor = TimeColor1;
                                    btnMin1G.BackColor = TimeColor1;
                                    break;

                                case 9:
                                    btnMin1A.BackColor = TimeColor1;
                                    btnMin1B.BackColor = TimeColor1;
                                    btnMin1C.BackColor = TimeColor1;
                                    btnMin1D.BackColor = TimeColor1;
                                    btnMin1E.BackColor = TimeColor0;
                                    btnMin1F.BackColor = TimeColor1;
                                    btnMin1G.BackColor = TimeColor1;
                                    break;
                            }
                            break;

                        case "Tens":
                            switch (num)
                            {
                                case 0:
                                    btnMin2A.BackColor = TimeColor1;
                                    btnMin2B.BackColor = TimeColor1;
                                    btnMin2C.BackColor = TimeColor1;
                                    btnMin2D.BackColor = TimeColor1;
                                    btnMin2E.BackColor = TimeColor1;
                                    btnMin2F.BackColor = TimeColor1;
                                    btnMin2G.BackColor = TimeColor0;
                                    break;

                                case 1:
                                    btnMin2A.BackColor = TimeColor0;
                                    btnMin2B.BackColor = TimeColor1;
                                    btnMin2C.BackColor = TimeColor1;
                                    btnMin2D.BackColor = TimeColor0;
                                    btnMin2E.BackColor = TimeColor0;
                                    btnMin2F.BackColor = TimeColor0;
                                    btnMin2G.BackColor = TimeColor0;
                                    break;

                                case 2:
                                    btnMin2A.BackColor = TimeColor1;
                                    btnMin2B.BackColor = TimeColor1;
                                    btnMin2C.BackColor = TimeColor0;
                                    btnMin2D.BackColor = TimeColor1;
                                    btnMin2E.BackColor = TimeColor1;
                                    btnMin2F.BackColor = TimeColor0;
                                    btnMin2G.BackColor = TimeColor1;
                                    break;

                                case 3:
                                    btnMin2A.BackColor = TimeColor1;
                                    btnMin2B.BackColor = TimeColor1;
                                    btnMin2C.BackColor = TimeColor1;
                                    btnMin2D.BackColor = TimeColor1;
                                    btnMin2E.BackColor = TimeColor0;
                                    btnMin2F.BackColor = TimeColor0;
                                    btnMin2G.BackColor = TimeColor1;
                                    break;

                                case 4:
                                    btnMin2A.BackColor = TimeColor0;
                                    btnMin2B.BackColor = TimeColor1;
                                    btnMin2C.BackColor = TimeColor1;
                                    btnMin2D.BackColor = TimeColor0;
                                    btnMin2E.BackColor = TimeColor0;
                                    btnMin2F.BackColor = TimeColor1;
                                    btnMin2G.BackColor = TimeColor1;
                                    break;

                                case 5:
                                    btnMin2A.BackColor = TimeColor1;
                                    btnMin2B.BackColor = TimeColor0;
                                    btnMin2C.BackColor = TimeColor1;
                                    btnMin2D.BackColor = TimeColor1;
                                    btnMin2E.BackColor = TimeColor0;
                                    btnMin2F.BackColor = TimeColor1;
                                    btnMin2G.BackColor = TimeColor1;
                                    break;

                                case 6:
                                    btnMin2A.BackColor = TimeColor1;
                                    btnMin2B.BackColor = TimeColor0;
                                    btnMin2C.BackColor = TimeColor1;
                                    btnMin2D.BackColor = TimeColor1;
                                    btnMin2E.BackColor = TimeColor1;
                                    btnMin2F.BackColor = TimeColor1;
                                    btnMin2G.BackColor = TimeColor1;
                                    break;

                                case 7:
                                    btnMin2A.BackColor = TimeColor1;
                                    btnMin2B.BackColor = TimeColor1;
                                    btnMin2C.BackColor = TimeColor1;
                                    btnMin2D.BackColor = TimeColor0;
                                    btnMin2E.BackColor = TimeColor0;
                                    btnMin2F.BackColor = TimeColor0;
                                    btnMin2G.BackColor = TimeColor0;
                                    break;

                                case 8:
                                    btnMin2A.BackColor = TimeColor1;
                                    btnMin2B.BackColor = TimeColor1;
                                    btnMin2C.BackColor = TimeColor1;
                                    btnMin2D.BackColor = TimeColor1;
                                    btnMin2E.BackColor = TimeColor1;
                                    btnMin2F.BackColor = TimeColor1;
                                    btnMin2G.BackColor = TimeColor1;
                                    break;

                                case 9:
                                    btnMin2A.BackColor = TimeColor1;
                                    btnMin2B.BackColor = TimeColor1;
                                    btnMin2C.BackColor = TimeColor1;
                                    btnMin2D.BackColor = TimeColor1;
                                    btnMin2E.BackColor = TimeColor0;
                                    btnMin2F.BackColor = TimeColor1;
                                    btnMin2G.BackColor = TimeColor1;
                                    break;
                            }
                            break;
                    }
                    break;

                case "Hours":
                    switch (placeValue)
                    {
                        case "Ones":
                            switch (num)
                            {
                                case 0:
                                    btnHrs1A.BackColor = TimeColor1;
                                    btnHrs1B.BackColor = TimeColor1;
                                    btnHrs1C.BackColor = TimeColor1;
                                    btnHrs1D.BackColor = TimeColor1;
                                    btnHrs1E.BackColor = TimeColor1;
                                    btnHrs1F.BackColor = TimeColor1;
                                    btnHrs1G.BackColor = TimeColor0;
                                    break;

                                case 1:
                                    btnHrs1A.BackColor = TimeColor0;
                                    btnHrs1B.BackColor = TimeColor1;
                                    btnHrs1C.BackColor = TimeColor1;
                                    btnHrs1D.BackColor = TimeColor0;
                                    btnHrs1E.BackColor = TimeColor0;
                                    btnHrs1F.BackColor = TimeColor0;
                                    btnHrs1G.BackColor = TimeColor0;
                                    break;

                                case 2:
                                    btnHrs1A.BackColor = TimeColor1;
                                    btnHrs1B.BackColor = TimeColor1;
                                    btnHrs1C.BackColor = TimeColor0;
                                    btnHrs1D.BackColor = TimeColor1;
                                    btnHrs1E.BackColor = TimeColor1;
                                    btnHrs1F.BackColor = TimeColor0;
                                    btnHrs1G.BackColor = TimeColor1;
                                    break;

                                case 3:
                                    btnHrs1A.BackColor = TimeColor1;
                                    btnHrs1B.BackColor = TimeColor1;
                                    btnHrs1C.BackColor = TimeColor1;
                                    btnHrs1D.BackColor = TimeColor1;
                                    btnHrs1E.BackColor = TimeColor0;
                                    btnHrs1F.BackColor = TimeColor0;
                                    btnHrs1G.BackColor = TimeColor1;
                                    break;

                                case 4:
                                    btnHrs1A.BackColor = TimeColor0;
                                    btnHrs1B.BackColor = TimeColor1;
                                    btnHrs1C.BackColor = TimeColor1;
                                    btnHrs1D.BackColor = TimeColor0;
                                    btnHrs1E.BackColor = TimeColor0;
                                    btnHrs1F.BackColor = TimeColor1;
                                    btnHrs1G.BackColor = TimeColor1;
                                    break;

                                case 5:
                                    btnHrs1A.BackColor = TimeColor1;
                                    btnHrs1B.BackColor = TimeColor0;
                                    btnHrs1C.BackColor = TimeColor1;
                                    btnHrs1D.BackColor = TimeColor1;
                                    btnHrs1E.BackColor = TimeColor0;
                                    btnHrs1F.BackColor = TimeColor1;
                                    btnHrs1G.BackColor = TimeColor1;
                                    break;

                                case 6:
                                    btnHrs1A.BackColor = TimeColor1;
                                    btnHrs1B.BackColor = TimeColor0;
                                    btnHrs1C.BackColor = TimeColor1;
                                    btnHrs1D.BackColor = TimeColor1;
                                    btnHrs1E.BackColor = TimeColor1;
                                    btnHrs1F.BackColor = TimeColor1;
                                    btnHrs1G.BackColor = TimeColor1;
                                    break;

                                case 7:
                                    btnHrs1A.BackColor = TimeColor1;
                                    btnHrs1B.BackColor = TimeColor1;
                                    btnHrs1C.BackColor = TimeColor1;
                                    btnHrs1D.BackColor = TimeColor0;
                                    btnHrs1E.BackColor = TimeColor0;
                                    btnHrs1F.BackColor = TimeColor0;
                                    btnHrs1G.BackColor = TimeColor0;
                                    break;

                                case 8:
                                    btnHrs1A.BackColor = TimeColor1;
                                    btnHrs1B.BackColor = TimeColor1;
                                    btnHrs1C.BackColor = TimeColor1;
                                    btnHrs1D.BackColor = TimeColor1;
                                    btnHrs1E.BackColor = TimeColor1;
                                    btnHrs1F.BackColor = TimeColor1;
                                    btnHrs1G.BackColor = TimeColor1;
                                    break;

                                case 9:
                                    btnHrs1A.BackColor = TimeColor1;
                                    btnHrs1B.BackColor = TimeColor1;
                                    btnHrs1C.BackColor = TimeColor1;
                                    btnHrs1D.BackColor = TimeColor1;
                                    btnHrs1E.BackColor = TimeColor0;
                                    btnHrs1F.BackColor = TimeColor1;
                                    btnHrs1G.BackColor = TimeColor1;
                                    break;
                            }
                            break;

                        case "Tens":
                            switch (num)
                            {
                                case 0:
                                    btnHrs2A.BackColor = TimeColor1;
                                    btnHrs2B.BackColor = TimeColor1;
                                    btnHrs2C.BackColor = TimeColor1;
                                    btnHrs2D.BackColor = TimeColor1;
                                    btnHrs2E.BackColor = TimeColor1;
                                    btnHrs2F.BackColor = TimeColor1;
                                    btnHrs2G.BackColor = TimeColor0;
                                    break;

                                case 1:
                                    btnHrs2A.BackColor = TimeColor0;
                                    btnHrs2B.BackColor = TimeColor1;
                                    btnHrs2C.BackColor = TimeColor1;
                                    btnHrs2D.BackColor = TimeColor0;
                                    btnHrs2E.BackColor = TimeColor0;
                                    btnHrs2F.BackColor = TimeColor0;
                                    btnHrs2G.BackColor = TimeColor0;
                                    break;

                                case 2:
                                    btnHrs2A.BackColor = TimeColor1;
                                    btnHrs2B.BackColor = TimeColor1;
                                    btnHrs2C.BackColor = TimeColor0;
                                    btnHrs2D.BackColor = TimeColor1;
                                    btnHrs2E.BackColor = TimeColor1;
                                    btnHrs2F.BackColor = TimeColor0;
                                    btnHrs2G.BackColor = TimeColor1;
                                    break;

                                case 3:
                                    btnHrs2A.BackColor = TimeColor1;
                                    btnHrs2B.BackColor = TimeColor1;
                                    btnHrs2C.BackColor = TimeColor1;
                                    btnHrs2D.BackColor = TimeColor1;
                                    btnHrs2E.BackColor = TimeColor0;
                                    btnHrs2F.BackColor = TimeColor0;
                                    btnHrs2G.BackColor = TimeColor1;
                                    break;

                                case 4:
                                    btnHrs2A.BackColor = TimeColor0;
                                    btnHrs2B.BackColor = TimeColor1;
                                    btnHrs2C.BackColor = TimeColor1;
                                    btnHrs2D.BackColor = TimeColor0;
                                    btnHrs2E.BackColor = TimeColor0;
                                    btnHrs2F.BackColor = TimeColor1;
                                    btnHrs2G.BackColor = TimeColor1;
                                    break;

                                case 5:
                                    btnHrs2A.BackColor = TimeColor1;
                                    btnHrs2B.BackColor = TimeColor0;
                                    btnHrs2C.BackColor = TimeColor1;
                                    btnHrs2D.BackColor = TimeColor1;
                                    btnHrs2E.BackColor = TimeColor0;
                                    btnHrs2F.BackColor = TimeColor1;
                                    btnHrs2G.BackColor = TimeColor1;
                                    break;

                                case 6:
                                    btnHrs2A.BackColor = TimeColor1;
                                    btnHrs2B.BackColor = TimeColor0;
                                    btnHrs2C.BackColor = TimeColor1;
                                    btnHrs2D.BackColor = TimeColor1;
                                    btnHrs2E.BackColor = TimeColor1;
                                    btnHrs2F.BackColor = TimeColor1;
                                    btnHrs2G.BackColor = TimeColor1;
                                    break;

                                case 7:
                                    btnHrs2A.BackColor = TimeColor1;
                                    btnHrs2B.BackColor = TimeColor1;
                                    btnHrs2C.BackColor = TimeColor1;
                                    btnHrs2D.BackColor = TimeColor0;
                                    btnHrs2E.BackColor = TimeColor0;
                                    btnHrs2F.BackColor = TimeColor0;
                                    btnHrs2G.BackColor = TimeColor0;
                                    break;

                                case 8:
                                    btnHrs2A.BackColor = TimeColor1;
                                    btnHrs2B.BackColor = TimeColor1;
                                    btnHrs2C.BackColor = TimeColor1;
                                    btnHrs2D.BackColor = TimeColor1;
                                    btnHrs2E.BackColor = TimeColor1;
                                    btnHrs2F.BackColor = TimeColor1;
                                    btnHrs2G.BackColor = TimeColor1;
                                    break;

                                case 9:
                                    btnHrs2A.BackColor = TimeColor1;
                                    btnHrs2B.BackColor = TimeColor1;
                                    btnHrs2C.BackColor = TimeColor1;
                                    btnHrs2D.BackColor = TimeColor1;
                                    btnHrs2E.BackColor = TimeColor0;
                                    btnHrs2F.BackColor = TimeColor1;
                                    btnHrs2G.BackColor = TimeColor1;
                                    break;
                            }
                            break;
                    }
                    break;

                default:
                    break;
            }
        }

        private void BlinkingDot()
        {
            if (flag == 1)
            {
                btnBlinker.BackColor = TimeColor0;
                flag *= -1;
            }
            else
            {
                btnBlinker.BackColor = TimeColor1;
                flag *= -1;
            }
        }

        private void Meridiem(string state)
        {
            if (state == "AM")
            {
                labelMeridiemAM.ForeColor = TimeColor1;
                labelMeridiemPM.ForeColor = Color.Black;
            }
            else if (state == "PM")
            {
                labelMeridiemAM.ForeColor = Color.Black;
                labelMeridiemPM.ForeColor = TimeColor1;
            }
        }

        private void btnHourFormat_Click(object sender, EventArgs e)
        {
            if (hourFormat == "HH")
            {
                hourFormat = "hh";
                btnHourFormat.Text = "To 24hr Format";
            }
            else if (hourFormat == "hh")
            {
                hourFormat = "HH";
                btnHourFormat.Text = "To 12hr Format";
            }
        }

        private void DayNameController(string day)
        {
            foreach (Control x in Controls)
            {
                if (x.Tag == "dayBtn")
                {
                    x.BackColor = DayColor0;
                }
            }

            List<Button> Monday = new List<Button>
            {
                btn1M, btn1N, btn1O, btn1P, btn1A, btn1B, btn1Q, btn1U, btn1D, btn1E, btn1F, btn1G, btn1H, btn1I,
                btn2B, btn2C, btn2D, btn2F, btn2G, btn2H, btn2J, btn2K, btn2L, btn2N, btn2O, btn2P,
                btn3B, btn3C, btn3D, btn3F, btn3G, btn3H, btn3I, btn3M, btn3N, btn3O, btn3P,
            };

            List<Button> Tuesday = new List<Button>
            {
                btn1A, btn1B, btn1C, btn1D, btn1E, btn1Q, btn1U, btn1S, btn1K,
                btn2A, btn2E, btn2F, btn2G, btn2H, btn2J, btn2K, btn2L, btn2N, btn2O, btn2P,
                btn3A, btn3B, btn3C, btn3D, btn3E, btn3I, btn3J, btn3K, btn3L, btn3M, btn3N, btn3O, btn3P, btn3T, btn3U,
            };

            List<Button> Wednesday = new List<Button>
            {
                btn1A, btn1E, btn1F, btn1G, btn1H, btn1J, btn1L, btn1N, btn1O, btn1P, btn1S, btn1U,
                btn2A, btn2B, btn2C, btn2D, btn2E, btn2I, btn2J, btn2K, btn2L, btn2M, btn2N, btn2O, btn2P, btn2T, btn2U,
                btn3A, btn3B, btn3C, btn3D, btn3F, btn3G, btn3H, btn3J, btn3K, btn3L, btn3M, btn3N, btn3O, btn3P,
            };

            List<Button> Thursday = new List<Button>
            {
                btn1A, btn1B, btn1C, btn1D, btn1E, btn1Q, btn1U, btn1S, btn1K,
                btn2A, btn2E, btn2I, btn2M, btn2N, btn2O, btn2P, btn2T, btn2U, btn2F, btn2G, btn2H, btn2R,
                btn3A, btn3E, btn3F, btn3G, btn3H, btn3J, btn3K, btn3L, btn3N, btn3O, btn3P
            };

            List<Button> Friday = new List<Button>
            {
                btn1A, btn1B, btn1C, btn1D, btn1E, btn1N, btn1O, btn1P, btn1T, btn1U, btn1M,
                btn2A, btn2B, btn2C, btn2D, btn2F, btn2H, btn2M, btn2N, btn2O, btn2P, btn2T, btn2U, btn2I, btn2R,
                btn3C, btn3Q, btn3U, btn3S, btn3K,
            };

            List<Button> Saturday = new List<Button>
            {
                btn1B, btn1C, btn1D, btn1R, btn1H, btn1J, btn1K, btn1L, btn1T, btn1P, btn1E, btn1M, btn1U,
                btn2G, btn2B, btn2C, btn2D, btn2F, btn2H, btn2M, btn2N, btn2O, btn2P, btn2T, btn2U, btn2I, btn2R,
                btn3C, btn3Q, btn3U, btn3S, btn3K, btn3A, btn3B, btn3D, btn3E
            };

            List<Button> Sunday = new List<Button>
            {
                btn1B, btn1C, btn1D, btn1R, btn1H, btn1J, btn1K, btn1L, btn1T, btn1P, btn1E, btn1M, btn1U,
                btn2A, btn2E, btn2F, btn2G, btn2H, btn2J, btn2K, btn2L, btn2N, btn2O, btn2P,
                btn3B, btn3C, btn3D, btn3F, btn3G, btn3H, btn3I, btn3M, btn3N, btn3O, btn3P,
            };

            switch (day)
            {
                case "Mon":
                    foreach (Button x in Monday)
                    {
                        x.BackColor = DayColor1;
                    }
                    break;

                case "Tue":
                    foreach (Button x in Tuesday)
                    {
                        x.BackColor = DayColor1;
                    }
                    break;

                case "Wed":
                    foreach (Button x in Wednesday)
                    {
                        x.BackColor = DayColor1;
                    }
                    break;

                case "Thu":
                    foreach (Button x in Thursday)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "Fri":
                    foreach (Button x in Friday)
                    {
                        x.BackColor = DayColor1;
                    }
                    break;

                case "Sat":
                    foreach (Button x in Saturday)
                    {
                        x.BackColor = DayColor1;
                    }
                    break;

                case "Sun":
                    foreach (Button x in Sunday)
                    {
                        x.BackColor = DayColor1;
                    }
                    break;

                default:
                    break;
            }
        }

        private void MonthNameController(string month)
        {
            foreach (Control x in Controls)
            {
                if (x.Tag == "monthBtn")
                {
                    x.BackColor = DateColor2;
                }
            }

            List<Button> January = new List<Button>
            {
                btnDate1E, btnDate1F, btnDate1G, btnDate1H, btnDate1J, btnDate1K, btnDate1L, btnDate1N,
                btnDate2G, btnDate2B, btnDate2C, btnDate2D, btnDate2F, btnDate2H, btnDate2M, btnDate2N, btnDate2O, btnDate2P, btnDate2T, btnDate2U, btnDate2I, btnDate2R,
                btnDate3B, btnDate3C, btnDate3D, btnDate3F, btnDate3G, btnDate3H, btnDate3I, btnDate3M, btnDate3N, btnDate3O, btnDate3P,
            };

            List<Button> February = new List<Button>
            {
                btnDate1A, btnDate1B, btnDate1C, btnDate1D, btnDate1E, btnDate1N, btnDate1O, btnDate1P, btnDate1T, btnDate1U, btnDate1M,
                btnDate2B, btnDate2C, btnDate2D, btnDate2A, btnDate2N, btnDate2J, btnDate2K, btnDate2L, btnDate2T, btnDate2P, btnDate2E, btnDate2M, btnDate2U, btnDate2I, btnDate2O,
                btnDate3B, btnDate3C, btnDate3D, btnDate3A, btnDate3N, btnDate3J, btnDate3K, btnDate3L, btnDate3T, btnDate3P, btnDate3F, btnDate3M, btnDate3U, btnDate3H, btnDate3O, btnDate3R
            };

            List<Button> March = new List<Button>
            {
                btnDate1M, btnDate1N, btnDate1O, btnDate1P, btnDate1A, btnDate1B, btnDate1Q, btnDate1U, btnDate1D, btnDate1E, btnDate1F, btnDate1G, btnDate1H, btnDate1I,
                btnDate2G, btnDate2B, btnDate2C, btnDate2D, btnDate2F, btnDate2H, btnDate2M, btnDate2N, btnDate2O, btnDate2P, btnDate2T, btnDate2U, btnDate2I, btnDate2R,
                btnDate3A, btnDate3B, btnDate3C, btnDate3D, btnDate3F, btnDate3H, btnDate3M, btnDate3N, btnDate3O, btnDate3P, btnDate3T, btnDate3U, btnDate3I, btnDate3R,
            };

            List<Button> April = new List<Button>
            {
                btnDate1G, btnDate1B, btnDate1C, btnDate1D, btnDate1F, btnDate1H, btnDate1M, btnDate1N, btnDate1O, btnDate1P, btnDate1T, btnDate1U, btnDate1I, btnDate1R,
                btnDate2A, btnDate2B, btnDate2C, btnDate2D, btnDate2F, btnDate2M, btnDate2N, btnDate2O, btnDate2P, btnDate2T, btnDate2U, btnDate2R,
                btnDate3A, btnDate3B, btnDate3C, btnDate3D, btnDate3F, btnDate3H, btnDate3M, btnDate3N, btnDate3O, btnDate3P, btnDate3T, btnDate3U, btnDate3I, btnDate3R,
            };

            List<Button> May = new List<Button>
            {
                btnDate1M, btnDate1N, btnDate1O, btnDate1P, btnDate1A, btnDate1B, btnDate1Q, btnDate1U, btnDate1D, btnDate1E, btnDate1F, btnDate1G, btnDate1H, btnDate1I,
                btnDate2G, btnDate2B, btnDate2C, btnDate2D, btnDate2F, btnDate2H, btnDate2M, btnDate2N, btnDate2O, btnDate2P, btnDate2T, btnDate2U, btnDate2I, btnDate2R,
                btnDate3A, btnDate3T, btnDate3U, btnDate3F, btnDate3G, btnDate3R, btnDate3S, btnDate3K, btnDate3E, btnDate3O, btnDate3P
            };

            List<Button> June = new List<Button>
            {
                btnDate1E, btnDate1F, btnDate1G, btnDate1H, btnDate1J, btnDate1K, btnDate1L, btnDate1N,
                btnDate2A, btnDate2E, btnDate2F, btnDate2G, btnDate2H, btnDate2J, btnDate2K, btnDate2L, btnDate2N, btnDate2O, btnDate2P,
                btnDate3B, btnDate3C, btnDate3D, btnDate3F, btnDate3G, btnDate3H, btnDate3I, btnDate3M, btnDate3N, btnDate3O, btnDate3P,
            };

            List<Button> July = new List<Button>
            {
                btnDate1E, btnDate1F, btnDate1G, btnDate1H, btnDate1J, btnDate1K, btnDate1L, btnDate1N,
                btnDate2A, btnDate2E, btnDate2F, btnDate2G, btnDate2H, btnDate2J, btnDate2K, btnDate2L, btnDate2N, btnDate2O, btnDate2P,
                btnDate3A, btnDate3M, btnDate3N, btnDate3O, btnDate3P, btnDate3I, btnDate3J, btnDate3K, btnDate3L,
            };

            List<Button> August = new List<Button>
            {
                btnDate1G, btnDate1B, btnDate1C, btnDate1D, btnDate1F, btnDate1H, btnDate1M, btnDate1N, btnDate1O, btnDate1P, btnDate1T, btnDate1U, btnDate1I, btnDate1R,
                btnDate2A, btnDate2E, btnDate2F, btnDate2G, btnDate2H, btnDate2J, btnDate2K, btnDate2L, btnDate2N, btnDate2O, btnDate2P,
                btnDate3C, btnDate3B, btnDate3N, btnDate3O, btnDate3P, btnDate3H, btnDate3J, btnDate3K, btnDate3L, btnDate3D, btnDate3R, btnDate3U
            };

            List<Button> September = new List<Button>
            {
                btnDate1B, btnDate1C, btnDate1D, btnDate1R, btnDate1H, btnDate1J, btnDate1K, btnDate1L, btnDate1T, btnDate1P, btnDate1E, btnDate1M, btnDate1U, btnDate1R,
                btnDate2B, btnDate2C, btnDate2D, btnDate2A, btnDate2N, btnDate2J, btnDate2K, btnDate2L, btnDate2T, btnDate2P, btnDate2E, btnDate2M, btnDate2U, btnDate2I, btnDate2O,
                btnDate3A, btnDate3B, btnDate3C, btnDate3D, btnDate3F, btnDate3M, btnDate3N, btnDate3O, btnDate3P, btnDate3T, btnDate3U, btnDate3R,
            };

            List<Button> October = new List<Button>
            {
                btnDate1B, btnDate1C, btnDate1D, btnDate1F, btnDate1G, btnDate1H, btnDate1J, btnDate1K, btnDate1L, btnDate1N, btnDate1O, btnDate1P,
                btnDate2B, btnDate2C, btnDate2D, btnDate2E, btnDate2I, btnDate2J, btnDate2K, btnDate2L, btnDate2N, btnDate2O, btnDate2P,
                btnDate3C, btnDate3Q, btnDate3U, btnDate3S, btnDate3K, btnDate3A, btnDate3B, btnDate3D, btnDate3E,
            };

            List<Button> November = new List<Button>
            {
                btnDate1B, btnDate1C, btnDate1D, btnDate1F, btnDate1G, btnDate1H, btnDate1I, btnDate1M, btnDate1N, btnDate1O, btnDate1P,
                btnDate2B, btnDate2C, btnDate2D, btnDate2F, btnDate2G, btnDate2H, btnDate2J, btnDate2K, btnDate2L, btnDate2N, btnDate2O, btnDate2P,
                btnDate3A, btnDate3P, btnDate3T, btnDate3S, btnDate3R, btnDate3E, btnDate3F,
            };

            List<Button> December = new List<Button>
            {
                btnDate1A, btnDate1B, btnDate1C, btnDate1D, btnDate1F, btnDate1G, btnDate1H, btnDate1J, btnDate1K, btnDate1L, btnDate1M, btnDate1N, btnDate1O, btnDate1P,
                btnDate2B, btnDate2C, btnDate2D, btnDate2A, btnDate2N, btnDate2J, btnDate2K, btnDate2L, btnDate2T, btnDate2P, btnDate2E, btnDate2M, btnDate2U, btnDate2I, btnDate2O,
                btnDate3B, btnDate3C, btnDate3D, btnDate3E, btnDate3I, btnDate3J, btnDate3K, btnDate3L, btnDate3N, btnDate3O, btnDate3P,
            };

            switch (month)
            {
                case "Jan":
                    foreach (Button x in January)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "Feb":
                    foreach (Button x in February)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "Mar":
                    foreach (Button x in March)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "Apr":
                    foreach (Button x in April)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "May":
                    foreach (Button x in May)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "Jun":
                    foreach (Button x in June)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "Jul":
                    foreach (Button x in July)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "Aug":
                    foreach (Button x in August)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "Sep":
                    foreach (Button x in September)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "Oct":
                    foreach (Button x in October)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "Nov":
                    foreach (Button x in November)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "Dec":
                    foreach (Button x in December)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                default:
                    break;
            }
        }

        private void DayDigitsController(string digits)
        {
            foreach (Control x in Controls)
            {
                if (x.Tag == "dayDigitBtn")
                {
                    x.BackColor = DateColor2;
                }
            }

            List<Button> Zero = new List<Button>
            {
                btnDateDay2A, btnDateDay2B, btnDateDay2C, btnDateDay2D, btnDateDay2E, btnDateDay2F
            };

            List<Button> OnesOne = new List<Button>
            {
                btnDateDay2B, btnDateDay2C
            };

            List<Button> OnesTwo = new List<Button>
            {
                btnDateDay2A, btnDateDay2B, btnDateDay2G, btnDateDay2E, btnDateDay2D
            };

            List<Button> OnesThree = new List<Button>
            {
                btnDateDay2A, btnDateDay2B, btnDateDay2G, btnDateDay2C, btnDateDay2D
            };

            List<Button> OnesFour = new List<Button>
            {
                btnDateDay2F, btnDateDay2G, btnDateDay2B, btnDateDay2C
            };

            List<Button> OnesFive = new List<Button>
            {
                btnDateDay2A, btnDateDay2F, btnDateDay2G, btnDateDay2C, btnDateDay2D
            };

            List<Button> OnesSix = new List<Button>
            {
                btnDateDay2A, btnDateDay2F, btnDateDay2G, btnDateDay2C, btnDateDay2D, btnDateDay2E
            };

            List<Button> OnesSeven = new List<Button>
            {
                btnDateDay2A, btnDateDay2B, btnDateDay2C
            };

            List<Button> OnesEight = new List<Button>
            {
                btnDateDay2A, btnDateDay2B, btnDateDay2C, btnDateDay2D, btnDateDay2E, btnDateDay2F, btnDateDay2G
            };

            List<Button> OnesNine = new List<Button>
            {
                btnDateDay2A, btnDateDay2B, btnDateDay2C, btnDateDay2D, btnDateDay2F, btnDateDay2G
            };

            ////////////////////

            List<Button> TwosOne = new List<Button>
            {
                btnDateDay1B, btnDateDay1C
            };

            List<Button> TwosTwo = new List<Button>
            {
                btnDateDay1A, btnDateDay1B, btnDateDay1G, btnDateDay1E, btnDateDay1D
            };

            List<Button> TwosThree = new List<Button>
            {
                btnDateDay1A, btnDateDay1B, btnDateDay1G, btnDateDay1C, btnDateDay1D
            };

            switch (digits)
            {
                case "01":
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "02":
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "03":
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "04":
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "05":
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "06":
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "07":
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "08":
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "09":
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "10":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in Zero)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "11":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "12":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "13":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "14":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "15":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "16":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "17":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "18":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "19":
                    foreach (Button x in TwosOne)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "20":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in Zero)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "21":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "22":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesTwo)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "23":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesThree)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "24":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesFour)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "25":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesFive)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "26":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesSix)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "27":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesSeven)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "28":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesEight)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "29":
                    foreach (Button x in TwosTwo)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesNine)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "30":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in Zero)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                case "31":
                    foreach (Button x in TwosThree)
                    {
                        x.BackColor = DateColor1;
                    }
                    foreach (Button x in OnesOne)
                    {
                        x.BackColor = DateColor1;
                    }
                    break;

                default:
                    break;
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelMeridiemPM_Click(object sender, EventArgs e)
        {

        }

        private void labelMeridiemAM_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (hourFormat == "HH")
            {
                hourFormat = "hh";
            }
            else if (hourFormat == "hh")
            {
                hourFormat = "HH";
            }
        }

        private void btn3P_Click(object sender, EventArgs e)
        {

        }
    }
}
