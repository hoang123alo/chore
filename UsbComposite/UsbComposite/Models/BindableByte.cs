using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UsbComposite.Models
{
    public class BindableByte : INotifyPropertyChanged
    {
        private string _value = "00";
        private static readonly Regex _hexRegex = new Regex("^[0-9A-Fa-f]{1,2}$");

        public string Value
        {
            get => _value;
            set
            {
                var trimmed = (value ?? "").Trim().ToUpper();

                // Kiểm tra nếu là hex hợp lệ
                if (!_hexRegex.IsMatch(trimmed))
                {
                    // Nếu không hợp lệ → giữ nguyên
                    return;
                }

                if (_value != trimmed)
                {
                    _value = trimmed;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
                }
            }
        }

        public override string ToString() => Value;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
