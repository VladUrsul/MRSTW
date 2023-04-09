using System;
namespace ElectronicsShop.BusinessLogic.Interfaces
{
	public interface BusinessLogic
	{
		public ISession GetSessionBL() {
			return newSessionBL();
		}
	}
	

		}

