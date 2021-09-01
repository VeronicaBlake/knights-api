namespace knightApi.Models
{
    public class Knights
    {
        public int Id {get; set;}
        [Required]
        public string Name { get; set; }
        public int quests { get; set; }
        private bool _hasGrail { get; set; }
        internal bool HasgrailWasSet {get; private set;}
        public bool hasGrail
        {
            get
            {
                return _hasGrail;
            }
            set
            {
                _hasGrail = value;
                HasgrailWasSet = true;
            }
        }

    }
}