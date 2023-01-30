namespace VehicleServicesV2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VehicleType_TypeWork
    {
        public int Id { get; set; }

        public int? VehicleTypeId { get; set; }

        public int? TypeWorkId { get; set; }

        public virtual TypeWork TypeWork { get; set; }

        public virtual VehicleType VehicleType { get; set; }
    }
}
