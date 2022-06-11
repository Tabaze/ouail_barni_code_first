using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ouail_barni_code_first
{
    public partial class grade
        {​​​​
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public grade()
            {​​​​
                 Customers = new HashSet<Customer>();
            }​​​​

            public int IdGrade {​​​​ get; set; }​​​​[Required]

            public string NomGrade {​​​​ get; set; }​​​​[Required]

            [StringLength(30)]
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")] public virtual ICollection<Customer> Customers {​​​​ get; set; }​​​​
        }​​​​
}