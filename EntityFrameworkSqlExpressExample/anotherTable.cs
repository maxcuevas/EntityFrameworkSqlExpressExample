namespace EntityFrameworkSqlExpressExample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("anotherTable")]
    public partial class anotherTable
    {
        public int id { get; set; }

        [StringLength(10)]
        public string anotherage { get; set; }

        [StringLength(10)]
        public string anotherHeight { get; set; }
    }
}
