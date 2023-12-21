

using System.Globalization;

namespace Academy.Core.Metods
{
    public class student
    {
        private string _name;
        public string name { get => _name;
            set
            {
                while (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine ("please add valid name");
                    value = Console.ReadLine();
                }
                    _name = value;
                }

            } 
        }

                
        public string surname { get; set; }
        public string group { get; set; }
        public string education { get; set; }

        public student(string ad, string soyad, string qrup, string tehsil)
        {
            this.name = ad;
            this.surname = soyad;
            this.group = qrup;  
            this.education = tehsil;
        }
        public string getfullinfo()
        {
            return $"name:{name} surname:{surname}, group:{group}, education:{education}";
        }
        
    }
}
