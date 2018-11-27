using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class Clock
    {
        private int seconds;
        private int minutes;
        private int hours;
        private int milliseconds;

        public int Milliseconds
        {
            get { return milliseconds; }
            set { milliseconds = value; }
        }

        //1.1
        public void tick ()
        {
            seconds = seconds + 1;
            minutes = minutes + seconds / 60;
            hours = hours + minutes / 60;
            milliseconds = milliseconds + 1000;
            seconds = seconds % 60;
            minutes = minutes % 60;
            hours = hours % 60;
            milliseconds = milliseconds % 60; 
        }

        //1.2
        public string Show()
        {
            return $"{hours}:{minutes}:{seconds}:{milliseconds}";
        }

        //1.3
        public void SetMidNight()
        {
            hours = 00;
            minutes = 00;
            seconds = 00;
            milliseconds = 00;
        }


        public void SetMidDay()
        {
            hours = 12;
            minutes = 00;
            seconds = 00;
            milliseconds = 00;
        }
    }
}
