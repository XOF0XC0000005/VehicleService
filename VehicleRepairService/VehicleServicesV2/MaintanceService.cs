namespace VehicleServicesV2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintanceService")]
    public partial class MaintanceService
    {
        public int Id { get; set; }

        public int? VehicleId { get; set; }

        public int? EmployeeId { get; set; }

        public int? WorkTypeId { get; set; }

        public DateTime? Date { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}
