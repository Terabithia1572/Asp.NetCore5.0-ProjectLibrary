﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string Telephone { get; set; }
        public string Education { get; set; }


        //ilişkiler
        public List<BookSummary> BookSummaries { get; set; }
        public List<RewardPoint> RewardPoints { get; set; }
    }
}
