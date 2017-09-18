namespace eShopServiceLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class CatalogItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public string PictureFileName { get; set; }
        [DataMember]
        public int CatalogBrandId { get; set; }
        [DataMember]
        public int CatalogTypeId { get; set; }

        [IgnoreDataMember]
        public CatalogType CatalogType { get; set; }

        [IgnoreDataMember]
        public CatalogBrand CatalogBrand { get; set; }
    }
}
