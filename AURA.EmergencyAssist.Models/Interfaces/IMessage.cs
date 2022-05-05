using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.Models.Interfaces
{
    public interface IMessage
    {
        ResponseModel PushMessage(MessageModel messageModel);
        ResponseModel GetMesages();
    }
}
