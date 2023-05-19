namespace SamePlayer
{
    public class Player
    {
        public PlayerType Type { get; set; }
        public string Name { get; set; }
        
        public override int GetHashCode()
        {
            // XOR (^) the hash codes of the Type and Name fields
            return Type.GetHashCode() ^ Name.GetHashCode();
        }
    }
}