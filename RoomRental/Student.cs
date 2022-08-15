namespace RoomRental {
    public class Student {
        public string Name { get; set; }
        public string EMail { get; set; }

        public Student(string name, string eMail) {
            Name = name;
            EMail = eMail;
        }

        public override string ToString() {
            return $"{Name}, {EMail}";
        }
    }
}
