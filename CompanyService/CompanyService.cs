using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CompanyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CompanyService" in both code and config file together.
    public class CompanyService : ICompanyPublicService, ICompanyConfidentialService
    {

        public string GetPublicInfo()
        {
            return "this is public info via HTTP";
        }

        public string GetConfidentialInfo()
        {
            return "this is confidential info via TCP";
        }
    }
}
