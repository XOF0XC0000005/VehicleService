namespace VehicleServicesV2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_TypeWork
    {
        public int Id { get; set; }

        public int? EmployeeId { get; set; }

        public int TypeWorkId { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual TypeWork TypeWork { get; set; }
    }
}
