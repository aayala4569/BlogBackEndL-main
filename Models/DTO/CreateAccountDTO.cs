using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogBackEndL.Models.DTO
{
    public class CreateAccountDTO
    {
        public int Id { get; set;}
        public string? Username {get; set;}

        public string? Password { get; set;}


    }
}