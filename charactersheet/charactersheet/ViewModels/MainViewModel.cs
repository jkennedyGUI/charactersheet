using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace charactersheet
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            this.Items.Add(new ItemViewModel()
            {
                Name = "Aeofel",
                Description = "Level 11 Avenger",
                LineThree = "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"
            });
            this.Items.Add(new ItemViewModel()
            {
                Name = "Echo",
                Description = "Dictumst eleifend facilisi faucibus",
                LineThree = "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus"
            });
            this.Items.Add(new ItemViewModel()
            {
                Name = "Willow",
                Description = "Habitant inceptos interdum lobortis",
                LineThree = "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent"
            });
            this.Items.Add(new ItemViewModel()
            {
                Name = "Gloomy",
                Description = "Nascetur pharetra placerat pulvinar",
                LineThree = "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos"
            });
            this.Items.Add(new ItemViewModel()
            {
                Name = "Rhogar",
                Description = "Maecenas praesent accumsan bibendum",
                LineThree = "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur"
            });
            this.Items.Add(new ItemViewModel()
            {
                Name = "Aeolian",
                Description = "Dictumst eleifend facilisi faucibus",
                LineThree = "Pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent"
            });
            this.Items.Add(new ItemViewModel()
            {
                Name = "Teddy",
                Description = "Habitant inceptos interdum lobortis",
                LineThree = "Accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat"
            });
            this.Items.Add(new ItemViewModel()
            {
                Name = "Calypso",
                Description = "Nascetur pharetra placerat pulvinar",
                LineThree = "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum"
            });
            this.Items.Add(new ItemViewModel()
            {
                Name = "Vanguard Crackhammer",
                Description = "Level 3 Warrior",
                LineThree = "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"
            });

            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}