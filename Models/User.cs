using System.Diagnostics.CodeAnalysis;

namespace Models
{
    public class User
    {
        [NotNull]
        public string UserName { get; set; }
        [NotNull]
        public string Password { get; set; }
        
    }
}