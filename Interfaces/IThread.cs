using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IThreadController
    {
        void CreateThread();
        void StartThread();
        void StopThread();
        void KillThread();
    }
}
