using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateWindchillEnumeration
{
    internal class WindchillEnumerationRequest
    {
        public string InternalNameEnum { get;  set;}
        public string ContainerDomain { get; set; }
        public string OrganizerName { get; set; }
        public string ValueDisplayName { get; set; }
        public Boolean ValueSort { get; set; }

        public List<Dictionary<string, object>> TableRows { get; set; }

    }
}
