//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;
//using System.Linq;
//using System.Reflection.Metadata.Ecma335;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPls2
//{
//    internal class Time
//    {
//        private int hours;
//        private int minutes;
//        private int seconds;


//        public Time(int hours,int minutes,int seconds)
//        {
//            Values(hours,minutes,seconds);
           
//        }


       
    
//    public int Hour
//        {
//            get { return hours; }
//            set { this.hours = value; }


//        }
//        public int Minute
//        {
//            get { return minutes; }
//            set { this.minutes = value; }


//        }
//        public int Second
//        {
//            get { return seconds; }
//            set { this.seconds = value; }
//        }
        
//        public void Values(int hours,int minutes,int second)
//        {
//            if (hours < 0 || hours > 24)
//            {
//                throw new Exception("Всего 24 часа");
//            }
//            else if (minutes < 0 || minutes > 60)
//            {
//                throw new Exception("Всего 60 минут");
//            }
//            else if (second < 0 || second > 60)
//             throw new Exception();                                      
//        }
//        public void newTimeHour(int hours)
//        {
//            int newHours = this.hours + hours;
//            if(newHours <0 || newHours >23)
//            {
//                throw new ArgumentException("Недопустимое значение");
//            }
//            this.hours = newHours;
//        }
//        public void newTimeMintes(int minutes)
//        {
//            int newMinutes = this.minutes + minutes;
//            if (newMinutes < 0 || newMinutes > 59)
//            {
//                throw new ArgumentException("Недопустимое значение");
                
//            }
//            this.minutes = newMinutes;
//        }
//        public void newTimeSecond(int seconds)
//        {
//            int newSecond = this.seconds + seconds;
//            if (newSecond < 0 || newSecond > 59) 
//            {
//                throw new ArgumentException("Недопустимое значение");
//            }
//            this.seconds = newSecond;
//        }
//        public override string ToString()
//        {
//            return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
//        }
//    }
//}

