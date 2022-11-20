namespace Module25.Practice
{
    public class Company
    {
        #region Unit4
        //public int Id { get; set; }
        //public string? Name { get; set; }
        ////public List<User> Users { get; set; }

        ////public List<User> Users { get; set; } = new List<User>(); //Unit4 Один ко многим
        #endregion
        #region Unit5
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? Type { get; set; }

        // Навигационное свойство
        public List<User> Users { get; set; } = new List<User>();
        #endregion
    }
}
