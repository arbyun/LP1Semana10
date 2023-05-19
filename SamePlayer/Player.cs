﻿namespace SamePlayer
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

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Player otherPlayer = (Player)obj;
            return Type == otherPlayer.Type && Name == otherPlayer.Name;
        }
    }
}