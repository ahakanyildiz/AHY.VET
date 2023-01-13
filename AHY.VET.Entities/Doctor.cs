namespace AHY.VET.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int BranchId { get; set; } // 4
        public Branch Branch { get; set; } // Navigation Propery
    }
}
