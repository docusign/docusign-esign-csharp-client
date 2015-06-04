using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuSign.Integrations.Client
{
    public class RadioGroupTab : Tab
    {
        public string conditionalParentLabel { get; set; }
        public string conditionalParentValue { get; set; }
        public string groupName { get; set; }
        public Radios[] radios { get; set; }
        public string requireInitialOnSharedChange { get; set; }
        public string shared { get; set; }
        public string templateLocked { get; set; }
        public string templateRequired { get; set; }
    }
}
