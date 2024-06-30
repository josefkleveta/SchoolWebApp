using System.Diagnostics.CodeAnalysis;

namespace SchoolProject.Models {
      public class Subject {
        public int Id { get; set; }
        [NotNull]
        public String Name { get; set; }
    }
}
