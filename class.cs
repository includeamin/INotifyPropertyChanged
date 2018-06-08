 public class DayPage :INotifyPropertyChanged
    {
        private string _totalCost;
        private int _totalBenefit;
        public int Id { get; set; }
        public List<Record> Records { get; set; }
        public string CreationDate { get; set; }

        public string TotalCost
        {
            get => _totalCost;
            set
            {
                _totalCost = value;
                OnPropertyChanged(nameof(TotalCost));
            }
        }

        public int TotalBenefit
        {
            get => _totalBenefit;
            set
            {
                _totalBenefit = value;
                OnPropertyChanged(nameof(TotalBenefit));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
