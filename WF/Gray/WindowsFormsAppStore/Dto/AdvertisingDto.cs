namespace Dto
{
    public sealed class AdvertisingDto
    {
        public string Purchase { get; set; }
        public double? Cost { get; set; }
        public string Type { get; set; }
        public string Info { get; set; }
        public string Picture { get; set; }
        public AdvertisingDto(string purchase, double? cost, string type, string info, string picture)
        {
            Purchase = purchase; Cost = cost; Type = type; Info = info; Picture = picture;
        }
        public override string ToString()
        {
            return "Advertising:\n"
                + "\t(Purchase = " + Purchase + ",\n"
                + "\tCost = " + Cost + "\n"
                + "\tType = " + Type + "\n"
                + "\tInfo = " + Info + "\n"
                + "\tPicture = " + Picture + ")";
        }
    }
}
