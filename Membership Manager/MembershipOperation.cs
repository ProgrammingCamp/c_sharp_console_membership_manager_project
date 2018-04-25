using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership_Manager
{
    public static class MembershipOperation
    {
        public static void AddMember(string memberName, int indexCounter)
        {
            Program.members[indexCounter] = memberName;
            indexCounter = indexCounter + 1;
        }

        public static string GetMember(string[] members, int index)
        {
            try
            {
                return members[index];
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid index, please enter correct index in range between 0 and 4");
                return "";
            }

        }

        public static void Delete(string[] members, int index)
        {
            members[index] = "";
        }

        public static void GetAllMembers(string[] members)
        {
            //int counter = 0;

            //while(counter < 5)
            //{
            //    Console.WriteLine("Member name is: " + members[counter]);
            //    counter = counter + 1;
            //}


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Member name is: " + members[i]);
            }
        }

    }
}
