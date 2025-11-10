using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14.Contracts
{
    public interface INotifier
    {
        void Send(string to, string message);
    }
}
