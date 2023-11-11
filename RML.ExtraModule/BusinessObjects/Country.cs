using DevExpress.Persistent.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace RML.ExtraModule.BusinessObjects
{
    [DefaultClassOptions]
    [NavigationItem("Core")]
    [Table("Countries", Schema = "core")]
    [Microsoft.EntityFrameworkCore.Index(nameof(Code2), IsUnique = true)]
    [Microsoft.EntityFrameworkCore.Index(nameof(Code3), IsUnique = true)]
    public class Country
    {
        [Browsable(false)]
        public virtual int Id { get; set; }
        public virtual string Code2 { get; set; }
        public virtual string Code3 { get; set; }
        public virtual string Name { get; set; }
    }
}
