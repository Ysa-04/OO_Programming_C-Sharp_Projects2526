using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Overerving
{
    public enum Genders
    {
        Male, Female
    }
    public abstract class Animal
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        private Genders gender;
        public Genders Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }
        public abstract ImmutableList<string> Allergies { get; }
        public abstract void ShowChip();

    }
}
