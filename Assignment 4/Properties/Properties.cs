
namespace Properties {
    class TimePeriod {
        private double _seconds;
        public double Hours {
            get { 
                return _seconds / 3600; 
            }
            set {
                if (value < 0 || value > 24)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be between 0 and 24."
                    );
                _seconds = value * 3600;
            }
        }
    }

    public class Person {
        private string _firstName;
        private string _lastName;

        public Person(string first, string last) {
            _firstName = first;
            _lastName = last;
        }

        public string Name => $"{_firstName} {_lastName}";
    }

    public class SaleItem {
        string _name;
        decimal _cost;
        public SaleItem(string name, decimal cost) {
            _name = name;
            _cost = cost;
        }
   
        public string Name {
            get => _name;
            set => _name = value;
        }

        public decimal Price {
            get => _cost;
            set => _cost = value;
        }
    }

    public class AutoImplementedSaleItem {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}