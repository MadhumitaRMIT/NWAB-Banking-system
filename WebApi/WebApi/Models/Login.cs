﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Models;

namespace WebApi.Models
{
    public class Login
    {
        [Required, StringLength(8)]
        [Display(Name = "Login ID")]
        public string LoginID { get; set; }

        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        [Required, StringLength(64)]
        public string PasswordHash { get; set; }
    }
}
