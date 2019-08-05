using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MGT_Exchange_Client.GraphQL.MVC
{
    public class department
    {
        [Key]
        public int departmentId { get; set; }

        [Required]
        public string name { get; set; }
        public string description { get; set; }
    }
}
