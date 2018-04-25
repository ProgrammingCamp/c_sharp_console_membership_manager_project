using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership_Manager
{
    public class MembershipOperationWithList
    {
        public static void AddMember(string memberName)
        {
            Program.memberList.Add(memberName);
        }

        public static string GetMember(int index)
        {
            try
            {
                return Program.memberList.ElementAt(index);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid index, please enter correct index in range between 0 and 4");
                return "";
            }

        }

        public static void Delete(string[] members, int index)
        {
            Program.memberList.RemoveAt(index);
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
                Console.WriteLine("Member name is: " + Program.memberList.ElementAt(i));
            }
        }
    }
}
