using System;

namespace Gamos.Demo
{
    public class BoyGroup
    {
        public string BoyGroupName { get; set; }
        public string BoyGroupNationality { get; set; }
        public int BoyGroupMembers { get; set; }

        private string Company { get; set; }
        private int Age { get; set; }
        private bool IsInMilitary { get; set; }

        public BoyGroup(string groupName, string groupNationality, int groupMembers, string company, int age, bool inMilitary)
        {
            BoyGroupName = groupName;
            BoyGroupNationality = groupNationality;
            BoyGroupMembers = groupMembers;
            Company = company;
            Age = age;
            IsInMilitary = inMilitary;
        }

        public BoyGroup(string groupName, string groupNationality, int groupMembers, string company, int age)
        {
            BoyGroupName = groupName;
            BoyGroupNationality = groupNationality;
            BoyGroupMembers = groupMembers;
            Company = company;
            Age = age;
            IsInMilitary = true;
        }

        public BoyGroup(string groupName, string groupNationality, int groupMembers, string company)
        {
            BoyGroupName = groupName;
            BoyGroupNationality = groupNationality;
            BoyGroupMembers = groupMembers;
            Company = company;
            Age = 0;
            IsInMilitary = true;
        }

        public void DisplayBoyGroupInformation()
        {
            Console.WriteLine($"Boygroup Name: {BoyGroupName}");
            Console.WriteLine($"Boygroup Nationality: {BoyGroupNationality}");
            Console.WriteLine($"Number of members: {BoyGroupMembers}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Company: {Company}");
            Console.WriteLine($"Are they in military? {(IsInMilitary ? "Yes" : "No")}");
        }

        public void UpdatedAge(int newAge)
        {
            Age = newAge;
            Console.WriteLine($"New age of {BoyGroupName} is updated to {Age}");
        }

        public bool IsHavingComeback()
        {
            if (!IsInMilitary)
            {
                Console.WriteLine($"Aww, {BoyGroupName} is currently in military.");
                return false;
            }

            int companyBudget = GetCompanyBudget();
            return BoyGroupMembers <= companyBudget;
        }

        private int GetCompanyBudget()
        {
            return 5000000; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BoyGroup BTS = new BoyGroup("BTS", "Korean", 7, "BigHit", 30, true);
            BoyGroup ASTRO = new BoyGroup("ASTRO", "Korean", 6, "Fantagio", 25);
            BoyGroup SB19 = new BoyGroup("SB19", "Filipino", 5, "1Z Entertainment");

            Console.WriteLine("Boygroup Information:");
            BTS.DisplayBoyGroupInformation();
            Console.WriteLine("\nBoygroup Information:");
            ASTRO.DisplayBoyGroupInformation();
            Console.WriteLine("\nBoygroup Information:");
            SB19.DisplayBoyGroupInformation();

            SB19.UpdatedAge(31);
            ASTRO.UpdatedAge(29);

            Console.WriteLine($"\nWill BTS be having a comeback? {(BTS.IsHavingComeback() ? "Yes" : "No")}");
            Console.WriteLine($"\nWill ASTRO be having a comeback? {(ASTRO.IsHavingComeback() ? "Yes" : "No")}");
        }
    }
}
