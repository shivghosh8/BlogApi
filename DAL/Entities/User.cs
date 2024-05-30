﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.DAL.Entities
{
    [Table("users")]
    public partial class User
    {
        public User()
        {
            Posts = new HashSet<Post>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [Column("password")]
        [StringLength(50)]
        public string Password { get; set; } = null!;
        [Column("is_active")]
        public bool? IsActive { get; set; }

        [InverseProperty("CreatedByNavigation")]
        public virtual ICollection<Post> Posts { get; set; }
    }
}
