using Emse.Framework;
using Emse.KMSPortal.Data.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emse.KMSPortal.Data.Model
{
    public class Role : Entity<int>
    {
        [StringLength(50)]
        public string Name { get; set; }

        public State State { get; set; }

        //TODO: Cross tablo tarih ve işlem yapan bilgisi tutulacak
        public List<User> UserList { get; set; }
    }
}
