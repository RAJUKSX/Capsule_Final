//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskManager.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ParentTask
    {
        public ParentTask()
        {
            this.Tasks = new HashSet<Task>();
        }
    
        public int Parent_Id { get; set; }
        public string Parent_Task { get; set; }
    
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
