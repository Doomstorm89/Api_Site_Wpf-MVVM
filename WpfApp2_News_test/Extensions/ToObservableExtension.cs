using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfApp2_News_test.Entities;

namespace WpfApp2_News_test.Extensions
{
    public static class ToObservableExtension
    {
        public static ObservableCollection<News> ToObservableCollection(this  IEnumerable<News> e)
        {
            var t = new ObservableCollection<News>();
            foreach (var item in e)
            {
                t.Add(item);
            }
            return t;
        }
    }
}