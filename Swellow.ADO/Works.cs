//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Swellow.ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Works
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Works()
        {
            this.Movies = new HashSet<Movies>();
            this.Seasons = new HashSet<Seasons>();
            this.WorkCasts = new HashSet<WorkCasts>();
            this.WorkCompanys = new HashSet<WorkCompanys>();
            this.Genres = new HashSet<Genres>();
            this.Tags = new HashSet<Tags>();
        }
    
        public int Id { get; set; }
        public int Type { get; set; }
        public Nullable<int> Runtime { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> EndYear { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<byte> Score { get; set; }
        public string Directory { get; set; }
        public string Poster { get; set; }
        public Nullable<int> SeriesId { get; set; }
        public Nullable<int> LibraryId { get; set; }
        public string Display { get; set; }
        public string Name { get; set; }
        public string Outline { get; set; }
        public string Region { get; set; }
        public string DoubanId { get; set; }
        public string TmdbId { get; set; }
        public string ImdbId { get; set; }
    
        public virtual Librarys Librarys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movies> Movies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seasons> Seasons { get; set; }
        public virtual Serieses Serieses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkCasts> WorkCasts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkCompanys> WorkCompanys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Genres> Genres { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tags> Tags { get; set; }
    }
}
