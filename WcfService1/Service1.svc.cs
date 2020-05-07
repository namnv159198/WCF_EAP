using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1.Class;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Account GetAccount(int code, string pass)
        {
            Account ac = new Account()
            {
                Code = 00050553001,
                pass = "0123456789",
                Username = "Alex Ferguson",
                Blance = 350000000
            };
            if (code.Equals(ac.Code) & pass.Equals(ac.pass))
            {
                return ac;
            }
            else
            {
                return null;
            }
        }

        public string TransferMoney(int sCode, int rCode, decimal amount)
        {
            return null;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
