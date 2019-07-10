using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JWTNet.Models.CV
{
    /// <summary>
    /// Clase que contiene informacion de categoria.
    /// </summary>
    public class Category
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string Image { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }

        /// <summary>
        /// Constructor de category
        /// </summary>
        public Category()
        {
            Skills = new HashSet<Skill>();
        }
    }
}
