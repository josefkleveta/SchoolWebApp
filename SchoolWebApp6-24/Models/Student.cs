using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace SchoolProject.Models {
    public class Student {
        public int Id { get; set; }
        [NotNull]
        public String? FirstName { get; set; }
        [NotNull]
        public string? LastName { get; set;}
        public DateTime DateOfBirth { get; set; }
        
        public String FullName => $"{LastName} {FirstName}";
    }
}
