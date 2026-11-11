using System;

namespace Opgave5_2
{
    public class BlueBookPerson
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Occupation { get; set; }
        public string ImageUrl { get; set; }
        public string Quote { get; set; }
        public string FutureGoal { get; set; }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        public BlueBookPerson(string fullName, DateTime dateOfBirth, string occupation, string imageUrl, string quote, string futureGoal)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Occupation = occupation;
            ImageUrl = imageUrl;
            Quote = quote;
            FutureGoal = futureGoal;
        }

        public override string ToString()
        {
            return $"--- Den Blå Bog: {FullName} ---\n" +
                   $"Alder: {Age} år (Født: {DateOfBirth:dd/MM/yyyy})\n" +
                   $"Beskæftigelse: {Occupation}\n" +
                   $"Billede: {ImageUrl}\n" +
                   $"Citat: \"{Quote}\"\n" +
                   $"Fremtidsmål: {FutureGoal}\n";
        }
    }
}