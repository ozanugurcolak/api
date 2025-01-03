using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5,ErrorMessage ="Title Must Be Minimum 5 Characters")]
        [MaxLength(280,ErrorMessage ="Title Cannot Be Over 280 Characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5,ErrorMessage ="Content Must Be Minimum 5 Characters")]
        [MaxLength(280,ErrorMessage ="Content Cannot Be Over 280 Characters")]
        public string Content { get; set; } = string.Empty;
    }
}