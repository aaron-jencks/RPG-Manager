using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Manager.Shared
{
    public class CompletionEventArgs : EventArgs
    {
        private object data;

        public object CompletedData { get => data; set => data = value; }

        public CompletionEventArgs(object data)
        {
            this.data = data;
        }
    }
}
