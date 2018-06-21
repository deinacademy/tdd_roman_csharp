using System;
using System.Collections.Generic;

namespace Number
{
    public struct Symbol
    {
        public string one { get; private set; }
        public string five { get; private set; }
        public string ten { get; private set; }

        public Symbol(string one, string five, string ten) : this()
        {
            this.one = one;
            this.five = five;
            this.ten = ten;
        }
    }

    public class Roman
    {
        Dictionary<string, Symbol> _symbols { get; set; }

        public Roman()
        {
            _symbols = new Dictionary<string, Symbol>();
        }

        public void AddPlaceValue(string name, Symbol symbol)
        {
            _symbols.Add(name, symbol);
        }

        public Symbol GetSymbol(string name)
        {
            return _symbols[name];
        }
    }
}