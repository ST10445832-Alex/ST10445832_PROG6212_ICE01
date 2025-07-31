using System.Collections.Generic;
using System.Security.Policy;

namespace CustomIndexer
{
    internal class NameList
    {
        private List<string> _names = new List<string>();

        public NameList()
        {
            _names.Add("Anna");
            _names.Add("Bob");
        }

        public string this[int index]
        {
            get => _names[index];
            set
            {
                if (index >= 0 && index < _names.Count)
                {
                    _names[index] = value;
                }
                else if (index == _names.Count)
                {
                    _names.Add(value);
                }
                else
                {
                    throw new System.IndexOutOfRangeException("Index out of bounds.");
                }
            }
        }
    }
}
