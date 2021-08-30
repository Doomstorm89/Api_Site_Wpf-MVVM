using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using WpfApp2_News_test.Commands;
using WpfApp2_News_test.Entities;
using WpfApp2_News_test.Extensions;

namespace WpfApp2_News_test.ViewModel
{
    public class NewsViewModel : INotifyPropertyChanged
    {
        private News _selectedNews;
        private NewsApi _newsApi;

        private string headingText;
        private string typeText;
        private string newsTextText;
        private string imagePathText;

        public ObservableCollection<News> News { get; }
        public ObservableCollection<string> GetNewsTypes { get; }

        public string HeadingText
        {
            get => headingText;
            set
            {
                headingText = value;
                OnPropertyChanged(nameof(HeadingText));
            }
        }
        public string TypeText 
        {
            get => typeText;
            set
            {
                typeText = value;
                OnPropertyChanged(nameof(TypeText));
            } 
        }
        public string NewsTextText 
        {
            get => newsTextText;
            set
            {
                newsTextText = value;
                OnPropertyChanged(nameof(NewsTextText));
            } 
        }
        public string ImagePathText 
        {
            get => imagePathText;
            set
            {
                imagePathText = value;
                OnPropertyChanged(nameof(ImagePathText));
            }
        }

        public News SelectedNews
        {
            get => _selectedNews;
            set
            {
                if (value == _selectedNews) return;
                _selectedNews = value;
                OnPropertyChanged(nameof(SelectedNews));
            }
        }

        public NewsViewModel()
        {
            _newsApi = new NewsApi();
            News = new ObservableCollection<News>();
            News = _newsApi.GetNews().ToObservableCollection();
            GetNewsTypes = new ObservableCollection<string>
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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        
        private NewsCommand addCommand;
        public NewsCommand AddCommand
        {
            get
            {
                return addCommand ??
                       (addCommand = new NewsCommand(obj =>
                       {
                           var news = new News
                           {
                               Heading = HeadingText,
                               Type = TypeText,
                               NewsText = NewsTextText,
                               ImagePath = ImagePathText
                           };
                           News.Add(news);
                           SelectedNews = news;
                           _newsApi.AddNews(news);
                       }));
            }
        }
    }
}