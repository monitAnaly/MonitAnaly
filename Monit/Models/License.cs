using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Monit.Models
{
    public class License
    {
        public int Id { get; set; }

        public int AccountId { get; set; }

        public string Key { get; set; }

        public DateTime CreatedAt { get; set; }

        [ForeignKey(nameof(AccountId))]
        public Account Account { get; set; }
    }
}
