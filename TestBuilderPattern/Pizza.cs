using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBuilderPattern
{
    public class Pizza
    {
        private int _size;
        private Boolean _cheese;
        private Boolean _pepperoni;
        private Boolean _bacon;


        interface IBuilder
        {
            Boolean Cheese { get; set; }
            Boolean Pepperoni { get; set; }
            Boolean Bacon { get; set; }
            int Size { get; }

        }

        public class Builder : IBuilder
        {
            private readonly int _size;
            int IBuilder.Size
            {
                get { return _size; }
            }

            private Boolean _cheese = false;
            Boolean IBuilder.Cheese
            {
                get { return _cheese; }
                set { _cheese = value; }
            }


            private Boolean _pepperoni = false;
            Boolean IBuilder.Pepperoni
            {
                get { return _pepperoni; }
                set { _pepperoni = value; }
            }

            private Boolean _bacon = false;
            Boolean IBuilder.Bacon
            {
                get { return _bacon; }
                set { _bacon = value; }
            }


            public Builder(int size)
            {
                _size = size;
            }

            public Builder Cheese(Boolean value)
            {
                _cheese = value;
                return this;
            }

            public Builder Pepperoni(Boolean value)
            {
                _pepperoni = value;
                return this;
            }

            public Builder Bacon(Boolean value)
            {
                _bacon = value;
                return this;
            }

            public Pizza Build()
            {
                return new Pizza(this);
            }
        }

        private Pizza(IBuilder builder)
        {
            _size = builder.Size;
            _cheese = builder.Cheese;
            _pepperoni = builder.Pepperoni;
            _bacon = builder.Bacon;
        }

        public override string ToString()
        {
            var classinfo = string.Format("{0} - Size={1}, Cheese={2}, Pepperoni={3}, Bacon={4}",
                base.ToString(),
                _size.ToString(),
                _cheese.ToString(),
                _pepperoni.ToString(),
                _bacon.ToString());
            return classinfo;
        }
    }
}
