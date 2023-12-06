using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace M15_Class03.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int _id;
        public int Id { get => _id;
                set{
                    _id = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
                }
            
            
        }
        public string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }


        }
        public decimal _price;
        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Price)));
            }


        }
        public string _picture;
        public string Picture
        {
            get => _picture;
            set
            {
                _picture = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Picture)));
            }


        }
        public string RemotePictureUrl { get; set; }
    }
}
