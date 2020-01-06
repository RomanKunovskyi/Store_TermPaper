using System;

namespace Dto
{
    public sealed class PurchaseHistoryDto
    {
        public string Name { get; set; }
        public double? Cost { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string UserNickname { get; set; }
        public DateTime Date { get; set; }
        public PurchaseHistoryDto(string name, double cost, string type, string brand,string nickname, DateTime date )
        {
           Date = date; Name = name; Cost = cost; Type = type; Brand = brand; UserNickname = nickname;
        }
        public override string ToString()
        {
            return "PurchaseHistory:\n"
                + "\t(Name = " + Name + ",\n"
                + "\tCost = " + Cost + "\n"
                + "\tType = " + Type + "\n"
                + "\tBrand = " + Brand + "\n"
                + "\tUserNickname = " + UserNickname + "\n"
                + "\tDate = " + Date + ")";
        }

    }
}
