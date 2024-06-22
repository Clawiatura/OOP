//using OOPls8;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//Enrollee student = new Enrollee {FIO = "Maksimov Ivan"};
//Teacher teach = new Teacher { ExamNumber = 1,failed = false };
//Exam exam = new Exam { exam1 = 34, exam2 = 65, exam3 = 77 };


//namespace OOPls8
//{
//     class Enrollee
//    {
//        public string? FIO {  get; set; }
//    }



//    class Exam
//    {
//        public int exam1 { get; set; }
//        public int exam2 { get; set; }
//        public int exam3 { get; set; }

//    }
//    class Teacher
//    {
//        public int ExamNumber {  get; set; }
        
//        public bool? failed { get; set; }
//    }

//    class Faculty
//    {
//        public void Entered ()
//        {
//            Exam exam = new Exam();
//            int result = (exam.exam1 + exam.exam2 + exam.exam3) / 3;
//            if(result >=33) Console.WriteLine("Экзамен сдан, вы поступили");
//            else Console.WriteLine("Пересдача через 3 дня");

//        }
//    }
//}
