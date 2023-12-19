using System;

namespace TeacherPayment
{
    public class Teacher
    {
        private string id;
        private string name;
        private string lastname;
        private int hour;
        private int payperhour;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        public int Payperhour
        {
            get { return payperhour; }
            set
            {
                if (value > 0)
                {
                    payperhour = value;
                }
            }
        }

        public Teacher() { }

        public Teacher(string Id, string Name, string Lastname, int Hour, int Payperhour)
        {
            id = Id;
            name = Name;
            lastname = Lastname;
            hour = Hour;
            payperhour = Payperhour;
        }

        public double Payment()
        {
            return hour * payperhour;
        }
    }

}
