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
    }
}