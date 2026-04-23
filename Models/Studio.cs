namespace StudioLoc
{
    public class Studio
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int VillageId { get; set; }
        public string VillageName { get; set; } 

        public int Capacity { get; set; }

        public decimal HighSeasonPrice { get; set; }

        public decimal LowSeasonPrice { get; set; }

        public Studio() { }

        public Studio(int id, string name, int villageId, int capacity, decimal highSeasonPrice, decimal lowSeasonPrice)
        {
            this.Id = id;
            this.Name = name;
            this.VillageId = villageId;
            this.Capacity = capacity;
            this.HighSeasonPrice = highSeasonPrice;
            this.LowSeasonPrice = lowSeasonPrice;
        }
    }
}