using System;

namespace LootSort
{
    public class Loot: IComparable<Loot>
    {
        public LootType Kind { get; }
        public string Description { get; }
        public float Value { get; }
        
        public Loot(LootType kind, string description, float value)
        {
            Kind = kind;
            Description = description;
            Value = value;
        }

        public override string ToString() =>
            $"[{Kind,15}]\t{Value:f2}\t{Description}";
        
        public override int GetHashCode() =>
            HashCode.Combine(Kind, Description, Value);
        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Loot other = (Loot)obj;
            return Kind == other.Kind && Description == other.Description && Value == other.Value;
        }
        
        public int CompareTo(Loot other)
        {
            int typeComparison = String.Compare(Kind.ToString(), other.Kind.ToString(), StringComparison.Ordinal);
            if (typeComparison != 0)
            {
                return typeComparison;
            }

            int valueComparison = -Value.CompareTo(other.Value);
            if (valueComparison != 0)
            {
                return valueComparison;
            }

            return String.Compare(Description, other.Description, StringComparison.Ordinal);
        }
    }
}