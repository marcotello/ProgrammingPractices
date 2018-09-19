namespace Basic.Entities
{
    public class King
    {
        public King(string _name, int _number)
        {
            this.Name = _name;
            this.Number = _number;
        }

        public string Name { get; set; }
        public int Number { get; set; }
    }
}