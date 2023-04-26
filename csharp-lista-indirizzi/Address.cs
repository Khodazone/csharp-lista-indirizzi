﻿public class Address
    {
        //Attributes
        public string Name { get; }
        public string Surname { get; }
        public string Street { get; }
        public string City { get; }
        public string Province { get; }
        public int Zip { get; }

        // Constructor
        public Address(string name, string surname, string street, string city, string province, int zip)
        {
            this.Name = name;
            this.Surname = surname;
            this.Street = street;
            this.City = city;
            this.Province = province;
            this.Zip = zip;
        }
        public override string ToString()
        {
            string riga = "";
            riga += "Name: " + this.Name + "\n";
            riga += "Surname: " + this.Surname + "\n";
            riga += "Street: " + this.Street + "\n";
            riga += "City: " + this.City + "\n";
            riga += "Province: " + this.Province + "\n";
            riga += "ZIP: " + this.Zip + "\n";
            riga += "---------------------------------------------------";

            return riga;
        }
    }