namespace EntityFrameworkSqlExpressExample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class datum
    {
        public int id { get; set; }

        [StringLength(10)]
        public string name { get; set; }

        public int? age { get; set; }

        public int? height { get; set; }
    }
}
