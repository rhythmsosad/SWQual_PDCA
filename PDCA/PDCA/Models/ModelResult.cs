using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDCA.Models
{
    public class ModelResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public bool DisplayMessage
        {
            get
            {
                return _displayMessage;
            }

            set
            {
                _displayMessage = value;
            }
        }

        private bool _displayMessage = false;
    }
}
