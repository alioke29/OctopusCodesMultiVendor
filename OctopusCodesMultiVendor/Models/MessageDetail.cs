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
    
    public partial class MessageDetail
    {
        public System.Guid Id { get; set; }
        public System.Guid MessageHeaderId { get; set; }
        public string Body { get; set; }
        public System.DateTime DateCreation { get; set; }
        public bool Status { get; set; }
        public int Sender { get; set; }
    
        public virtual MessageHeader MessageHeader { get; set; }
    }
}
