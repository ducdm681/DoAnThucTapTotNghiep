using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batdongsan.com.DTO.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MaleOrFemale { get; set; }
        public string address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string IdCard { get; set; }
        public byte[] image { get; set; }
    }
}
