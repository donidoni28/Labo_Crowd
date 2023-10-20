namespace DAL.Entity
{
    public class UserEntity
    {
        public int IdUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<ProjectEntity>? Projects { get; set; }
        public List<ParticipationEntity>? Participations { get; set; }
        public List<DonationEntity>? Donations { get; set; }

    }
}

