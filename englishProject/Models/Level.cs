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
    
    public partial class Level
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Level()
        {
            this.IrregularVerb = new HashSet<IrregularVerb>();
            this.Word = new HashSet<Word>();
        }
    
        public int levelId { get; set; }
        public int levelNumber { get; set; }
        public string levelName { get; set; }
        public int boxId { get; set; }
        public string levelPicture { get; set; }
        public int levelPuan { get; set; }
        public int levelModul { get; set; }
        public int levelSubLevel { get; set; }
        public bool levelRememderCard { get; set; }
    
        public virtual Box Box { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IrregularVerb> IrregularVerb { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Word> Word { get; set; }
    }
}
