//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OctopusCodesMultiVendor.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MessageHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MessageHeader()
        {
            this.MessageDetails = new HashSet<MessageDetail>();
        }
    
        public System.Guid MsgId { get; set; }
        public string LastMessage { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public Nullable<int> VendorId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> AdminId { get; set; }
        public Nullable<int> SenderType { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Account Account1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MessageDetail> MessageDetails { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
