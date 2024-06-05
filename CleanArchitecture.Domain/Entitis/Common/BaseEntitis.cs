using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace CleanArchitecture.Domain.Entitis.Common;


public class BaseEntity
{
    public int Id { get; set; }
    public Guid Guid { get; set; } = new Guid();
    public DateTime Createdate { get; set; } = DateTime.Now;
    public int CreateBy { get; set; }
    public int? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public bool IsDeleted { get; set; }
}
