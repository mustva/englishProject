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
    
    public partial class Word
    {
        public int wordId { get; set; }
        public int levelId { get; set; }
        public string wordTurkish { get; set; }
        public string wordTranslate { get; set; }
        public string picture { get; set; }
        public string info { get; set; }
        public string wordRemender { get; set; }
        public string wordRemenderInfo { get; set; }
        public string wordDefinition { get; set; }
        public string wordExample { get; set; }
    
        public virtual Level Level { get; set; }
    }
}
