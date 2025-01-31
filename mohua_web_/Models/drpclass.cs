namespace mohua_web_.Models
{
    public class drpclass
    {
            public int SelectedStateId { get; set; }
            public int SelectedDistrictId { get; set; }
            public IEnumerable<State> States { get; set; }
            public IEnumerable<District> Districts { get; set; }
        
    }
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
    }
}
