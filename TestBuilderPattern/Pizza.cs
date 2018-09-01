namespace TestBuilderPattern
{
    public class Pizza
    {
        private readonly bool _bacon;
        private readonly bool _cheese;
        private readonly bool _pepperoni;
        private readonly int _size;

        private Pizza(IBuilder builder)
        {
            _size = builder.Size;
            _cheese = builder.Cheese;
            _pepperoni = builder.Pepperoni;
            _bacon = builder.Bacon;
        }

        public override string ToString()
        {
            var classinfo =
                $"{base.ToString()} - Size={_size.ToString()}, Cheese={_cheese.ToString()}, Pepperoni={_pepperoni.ToString()}, Bacon={_bacon.ToString()}";
            return classinfo;
        }

        public static Builder Create(int size)
        {
            return new Builder(size);
        }


        private interface IBuilder
        {
            bool Cheese { get; set; }
            bool Pepperoni { get; set; }
            bool Bacon { get; set; }
            int Size { get; }
        }

        public class Builder : IBuilder
        {
            private readonly int _size;

            private bool _bacon;

            private bool _cheese;


            private bool _pepperoni;


            public Builder(int size)
            {
                _size = size;
            }

            int IBuilder.Size => _size;

            bool IBuilder.Cheese
            {
                get => _cheese;
                set => _cheese = value;
            }

            bool IBuilder.Pepperoni
            {
                get => _pepperoni;
                set => _pepperoni = value;
            }

            bool IBuilder.Bacon
            {
                get => _bacon;
                set => _bacon = value;
            }

            public Builder Cheese(bool value)
            {
                _cheese = value;
                return this;
            }

            public Builder Pepperoni(bool value)
            {
                _pepperoni = value;
                return this;
            }

            public Builder Bacon(bool value)
            {
                _bacon = value;
                return this;
            }

            public Pizza Build()
            {
                return new Pizza(this);
            }
        }
    }
}