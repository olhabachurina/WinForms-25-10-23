using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;

namespace WinForms_25_10_23
{

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Country { get; set; }

        public User(string name, int age, double weight, string country)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Country = country;
        }

        public override string ToString()
        {
            return $"{Name}, {Age} years old, {Weight} kg, from {Country}";
        }
    }
}
    