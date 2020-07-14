using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Context
{
    [Table("Errors")]
    public class Error
    {
        [Key]
        public int Id { get; set; }
        public string Key { get; set; }
        public string StackTrace { get; set; }
        public string Source { get; set; }
        public string Path { get; set; }
    }
}