//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HK.PEIS.Domain.Models
{
    using HK.PEIS.Domain.BaseModel;
    using System;
    using System.Collections.Generic;

    public partial class TB_USERS : AggregateRoot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_USERS()
        {
            this.TB_USERROLE = new HashSet<TB_USERROLE>();
        }

        public int USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_PASSWORD { get; set; }
        public string FULLNAME { get; set; }
        public int DEPARTMENT_ID { get; set; }
        public int STATUS { get; set; }
        public System.DateTime CREATETIME { get; set; }
        public Nullable<System.DateTime> MODIFYTIME { get; set; }
        public string REMARK { get; set; }

        public virtual TB_DEPARTMENT TB_DEPARTMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_USERROLE> TB_USERROLE { get; set; }
    }
}
