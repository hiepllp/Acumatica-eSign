﻿using PX.Data;
using PX.Objects.SO;

namespace AcumaticaESign
{
    public class SOOrderESExt : PXCacheExtension<SOOrder>
    {
        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXSelector(typeof(Search<SOBillingContact.contactID>))]
        public int? BillContactID { get; set; }
    }
}