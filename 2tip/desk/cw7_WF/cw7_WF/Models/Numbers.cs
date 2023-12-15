using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw7_WF.Models
{
    public class Numbers {
        private List<int> _numbers;
        public Numbers(int size) {
            _numbers = new List<int>();
            Fill(size);
        }

        private void Fill(int size) {
            Random rnd = new Random();
            for (int i = 0; i < size; i++) {
                _numbers.Add(rnd.Next(100));
            }
        }

        public List<int> GetNumbers {
            get {
                return _numbers;
            }
        }
    }
}
