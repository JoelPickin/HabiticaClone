using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace HabiticaClone.Models.Avatars
{
    public class AvatarModel : RealmObject
    {
        [PrimaryKey]
        public int Id { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public string UserName { get; set;}
        public byte AvatarImage { get; set;}
        public long Level { get; set;}
        public long CurrentHealth { get; set;}
        public long MaxHealth { get ; set;}
        public long CurrentExperience { get; set;}
        public long MaxExperience { get; set;}
        public double GoldOwned { get; set;}
        public long GemsOwned { get; set;}

    }
}
