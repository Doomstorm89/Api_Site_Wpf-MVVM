using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace WpfApp2_News_test.Entities
{
    public class News : INotifyPropertyChanged
    {
        public static IEnumerable<string> GetNewsTypes()
        {
            return new List<string>()
            {
                "Politics",
                "Society",
                "Economics",
                "Worlds",
                "Accidents",
                "Sports",
                "Sciences",
                "Tourism"
            };
        }
        public enum NewsType
        {
            Politics,
            Society,
            Economics,
            Worlds,
            Accidents,
            Sports,
            Sciences,
            Tourism
        }

        private int _id;
        private string _imagePath;
        private string _heading;
        private string _newsText;
        private string _type;

        public int Id
        {
            get => _id;
            set
            {
                if(value == _id) return;
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string ImagePath
        {
            get => _imagePath;
            set
            {
                if(value == _imagePath) return;
                    _imagePath = value;
                OnPropertyChanged(nameof(ImagePath));
            }
        }
        
        public string Heading 
        {
            get => _heading;
            set
            {
                if(value == _heading) return;
                _heading = value;
                OnPropertyChanged(nameof(Heading));
            }
        }
        
        public string NewsText 
        {
            get => _newsText;
            set
            {
                if(value == _newsText) return;
                _newsText = value;
                OnPropertyChanged(nameof(NewsText));
            }
        }
        
        public string Type 
        {
            get => _type;
            set
            {
                if(value == _type) return;
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}