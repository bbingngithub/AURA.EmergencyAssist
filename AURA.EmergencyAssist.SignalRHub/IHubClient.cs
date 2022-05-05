using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.SignalRHub
{
    public interface IHubClient
    {
        Task InformClient(string message);
    }
}
