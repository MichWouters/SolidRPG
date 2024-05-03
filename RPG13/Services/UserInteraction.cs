using RPG13.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG13.Services
{
    public class UserInteraction : IUserInteraction
    {
        public string GetUserInput()
        {
            return Console.ReadLine();
        }
    }
}
