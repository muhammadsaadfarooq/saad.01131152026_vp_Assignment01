using System;

namespace student
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/StudentProfile.txt";
            int choice, choice2;

            string student_Name, university, Department, semester;
            string CGPA, roll;
            char enteries;
            string[] Key = { "nam:", "rol:", "sem:", "gpa:", "dep:", "uni:" };

            searcher search = new searcher();
            top_students top_obj= new top_students();
            attendence attend_obj = new attendence();
            file fetch_obj = new file();
            



            Console.WriteLine("*****Welcome to the Student Profile***** \n Press 1 for Add New Student \n Press 2 for Search Students \n Press 3 for Delete Student Record \n Press 4 for Top 3 CGpa \n Press 5 for Mark Attendence \n Press 6 for View Current Attendence");
            choice = Convert.ToInt16(Console.ReadLine());
            if (choice == 1)
            {

                do
                {
                    Console.Write("Enter the Student Name: ");
                    student_Name = Console.ReadLine();
                    Console.Write("Enter the Roll Number: ");
                    roll = Console.ReadLine();
                    Console.Write("Enter the CGPA: ");
                    CGPA = Console.ReadLine();
                    Console.Write("Enter the Semester: ");
                    semester = Console.ReadLine();
                    Console.Write("Enter the Department: ");
                    Department = Console.ReadLine();
                    Console.Write("Enter the University: ");
                    university = Console.ReadLine();


                    addStudent obj = new addStudent();
                    obj.write_rollNum(roll, path);
                    obj.write_studentName(student_Name, path);
                    obj.write_semester(semester, path);
                    obj.write_CGPA(CGPA, path);
                    obj.write_Department(Department, path);
                    obj.write_university(university, path);




                    Console.Write("\n\n\n\t\t\t*****Press Y for more enteries : Press N for exit = ");
                    enteries = Convert.ToChar(Console.ReadLine());
                    if (enteries == 'n' || enteries == 'N')
                    {
                        break;
                    }

                }
                while (enteries == 'Y' || enteries == 'y');


            }


            else if (choice == 2)
            {
                Console.Write("\n********Welcome to the Search panel***********\n\n Select Option\n\n");
                Console.Write("\n1- Search Student By Name \n2- Search Student by ID \n3- Search Student By Semester");
                Console.Write("\n\t\t\t Enter Option : ");
                choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    string search_name;
                    Console.Write("\n\nPlease Enter the Name for Search:");
                    search_name = Console.ReadLine();
                    Console.Write("\n********Search Student By Name***********\n\n");
                   
                    fetch_obj.fetch_rec(path);
                    search.searchline(Key[0], search_name, path);
                    fetch_obj.shoewrecord(search.line_number(), 2, 4);



                }
                else if (choice2 == 3)
                {
                    string search_semester;
                    Console.Write("\n\nPlease Enter the Semester for Search:");
                    search_semester = Console.ReadLine();
                    Console.Write("\n********Search Student By Semester***********\n\n");
                    fetch_obj.fetch_rec(path);
                    search.searchline(Key[2], search_semester, path);
                    fetch_obj.shoewrecord(search.line_number(), 3, 3);



                }
                else if (choice2 == 2)
                {
                    string search_id;
                    Console.Write("\n\nPlease Enter the Student Id for Search:");
                    search_id = Console.ReadLine();
                    Console.Write("\n********Search Student By ID***********\n\n");
                    fetch_obj.fetch_rec(path);
                    search.searchline(Key[1], search_id, path);
                    fetch_obj.shoewrecord(search.line_number(),0,3);

                }
            }
            else if (choice == 3)
            {
                Console.Write("\n********Welcome to the Delete Panel ***********\n\n Enter Student ID");
                string search_id;
                search_id = Console.ReadLine();
                Console.Write("\n********Record Deleted***********\n\n");
                delete_record dele_obj = new delete_record();
                dele_obj.RemoveLineFromTxtFile(search_id, path);






            }
            else if (choice == 4)
            {
                Console.Write("\n********Welcome to the Top3 GPA Panel ***********\n\n");
                top_obj.cgpa(Key[3], path);
                Console.Write("\n********3-Toppers***********\n\n");
            }
            else if (choice == 5)
            {

                string attend;
                string semstr;
                char mark;
                Console.Write("\n********Welcome to the Attendence Panel ***********\n\n\n Please Select For Which Semester you want to Mark Attendence  \n\n\n\t\t\t Mark P as Present : Mark A as Absent:Press S for Save & Exit");
                semstr = Console.ReadLine();
                attend_obj.attend(Key[0], path,semstr);
                do
                {
                    Console.Write("\n\n\t\t Press Button: ");
                    attend = Console.ReadLine();
                    if (attend == "Y" || attend == "y" || attend == "A" || attend == "a")
                    {
                        attend_obj.attend_conc(attend);
                    }
                    else if (attend == "s" || attend == "S")
                    {
                        Console.WriteLine("\n\nAttendence Saved\n\n\n\t\t\t*******Attendence Record Show*******\n\n");
                        attend_obj.attend_conc(attend);

                    }
                    Console.WriteLine("\n\n\nPress n to mark Attendence next Student || Press b to Stop ");
                    mark = Convert.ToChar(Console.ReadLine());
                    if (mark == 'b' || mark == 'B')
                    {
                        break;
                    }

                }
                while (mark == 'n' || mark == 'N');

            
            }
        }
    }
}
