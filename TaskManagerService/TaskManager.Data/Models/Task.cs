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
    
    public partial class Task
    {
        public int Task_Id { get; set; }
        public Nullable<int> Parent_Id { get; set; }
        public string Task1 { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public Nullable<int> Priority { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual ParentTask ParentTask { get; set; }
    }
}