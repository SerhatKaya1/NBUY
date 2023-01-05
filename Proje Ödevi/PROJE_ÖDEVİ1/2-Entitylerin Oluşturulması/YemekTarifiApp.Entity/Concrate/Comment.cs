using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekTarifiApp.Entity.Concrate
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; } //Yorum yazan kişinin maili
        public DateTime DateAdded { get; set; } //Mesajın yazılma tarihi
        public string Confirmation { get; set; } //Yorum onay

    }
}
