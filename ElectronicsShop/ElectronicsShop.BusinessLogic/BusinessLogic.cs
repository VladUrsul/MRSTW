using System;
using ElectronicsShop.BusinessLogic.Interfaces;

namespace ElectronicsShop.BusinessLogic
{
    public interface BusinessLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
    }


}

