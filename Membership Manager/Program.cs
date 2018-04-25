using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership_Manager
{
    class Program
    {
        public static string[] members = new string[5]; //simple array
        public static int indexCounter = 0;

        public static List<string> memberList = new List<string>(); //list

        static void Main(string[] args)
        {
            bool isReplay = true;
            do
            {
                Console.Clear();

                Console.WriteLine("Enter 1 to add new member");
                Console.WriteLine("Enter 2 to read member");
                Console.WriteLine("Enter 3 to delete member");
                Console.WriteLine("Enter 4 to update member");
                Console.WriteLine("Enter 5 to get all members");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    //call add new function
                    Console.Write("Please enter your name: ");
                    string name = Console.ReadLine();

                    MembershipOperationWithList.AddMember(name);
                }
                else if (choice == 2)
                {
                    //call read function
                    Console.Write("Please enter index of member: ");
                    int index = int.Parse(Console.ReadLine());

                     string name = MembershipOperation.GetMember(members, index);
                    Console.WriteLine("The selected member name is: " + name);
                }
                else if (choice == 3)
                {
                    //call delete function
                    Console.Write("Please enter index of member: ");
                    int index = int.Parse(Console.ReadLine());

                    MembershipOperation.Delete(members, index);
                }
                else if (choice == 4)
                {
                    //call update function
                }
                else if (choice == 5)
                {
                    //call get all function
                    MembershipOperation.GetAllMembers(members);
                }

                Console.Write("Do you want to replay? 1=yes 2=no");
                int answer = int.Parse(Console.ReadLine());

                if(answer == 1)
                {
                    isReplay = true;
                }
                else
                {
                    isReplay = false;
                }

            } while (isReplay == true);
        }

    }
}
