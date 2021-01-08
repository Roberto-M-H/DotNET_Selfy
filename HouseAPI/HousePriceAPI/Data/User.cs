using System;

#nullable disable

namespace HousePriceAPI.Data
{
    public partial class User
    {
        public int UserId { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? DarkTheme { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Verified { get; set; }
    }
}
