namespace Module25.Practice
{
    public class User
    {
        #region Постоянные
        //public int Id { get; set; }
        //public string? Name { get; set; }
        //public string? Email { get; set; }
        //public string? Role { get; set; }
        #endregion
        #region Unit4 + Один ко многим
        //// Внешний ключ
        //public int CompanyId { get; set; }
        //// Навигационное свойство
        //public Company Company { get; set; }
        #endregion
        #region Unit4 Один к одному
        //// Навигационное свойство
        //public UserCredential UserCredential { get; set; }
        #endregion
        #region Unit4 Многие ко многим
        //// Навигационное свойство
        //public List<Topic> Topics { get; set; } = new List<Topic>();
        #endregion
        #region Unit5
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }

        // Внешний ключ
        public int CompanyId { get; set; }
        // Навигационное свойство
        public Company Company { get; set; }
        #endregion
    }
}
