//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace englishProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class IrregularVerb
    {
        public int IrregularId { get; set; }
        public int levelId { get; set; }
        public string werbTurkish { get; set; }
        public string verbOne { get; set; }
        public string verbTwo { get; set; }
        public string verbThree { get; set; }
    
        public virtual Level Level { get; set; }
    }
}
