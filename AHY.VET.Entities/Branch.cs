namespace AHY.VET.Entities
{
    public class Branch
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}



// Biz bire çok ilişki kullandık. Bu ilişki sayesinde doktor tablosunu branşa bağladık.
// Fakat Reelde bir doktorun birden fazla branşı olabilir. Bunu çözmemiz lazım.. (Çoka Çok - Many To Many) 