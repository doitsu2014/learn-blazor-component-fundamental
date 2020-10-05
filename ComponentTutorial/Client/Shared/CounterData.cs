using System;

namespace ComponentTutorial.Client.Shared
{
    public class CounterData
    {
        private int _count;

        public int Count
        {
            get => _count;
            set
            {
                _count = value;
                CountChanged?.Invoke(_count);
            }
        }
        
        public Action<int> CountChanged { get; set; }

    }
}