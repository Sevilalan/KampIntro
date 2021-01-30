using InterfaceAbstractDemo.Entities;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : Abstract.ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return  client.TCKimlikNoDogrula(Convert.ToInt32(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateofBirt.Year).ConfigureAwait(false);
        }
    }
}
