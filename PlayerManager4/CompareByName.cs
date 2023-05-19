using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private readonly bool _ascending;

        public CompareByName(bool ascending)
        {
            this._ascending = ascending;
        }
        
        public int Compare(Player x, Player y)
        {
            return _ascending ? string.Compare(x.Name, y.Name, StringComparison.Ordinal) : 
                string.Compare(y.Name, x.Name, StringComparison.Ordinal);
        }
    }
}