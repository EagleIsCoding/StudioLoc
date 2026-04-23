namespace StudioLoc
{
    public class Village
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CommunityId { get; set; }

        public Village() { }

        public Village(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}