using System;
using System.Collections.Generic;
using System.Text;

namespace Overerving
{
    public class Boek
    {
        public string Isbn { get; set; }
        public string Titel { get; set; }
        public string Schrijver { get; set; }

        public Boek(string isbn, string titel, string schrijver)
        {
            Isbn = isbn;
            Titel = titel;
            Schrijver = schrijver;
        }

        // 1. ToString(): Zorgt voor een leesbare weergave als je het boek naar de console stuurt
        public override string ToString()
        {
            return $"Boek: '{Titel}' van {Schrijver} (ISBN: {Isbn})";
        }

        // 2. Equals(): Twee boeken zijn gelijk als hun ISBN-nummer identiek is
        public override bool Equals(object o)
        {
            if (o is null || GetType() != o.GetType()) { return false; }

            Boek anderBoek = (Boek)o;
            return this.Isbn == anderBoek.Isbn;
        }

        // 3. GetHashCode(): De vingerafdruk baseren op datzelfde unieke ISBN-nummer
        public override int GetHashCode()
        {
            return this.Isbn.GetHashCode();
        }
    }
}
