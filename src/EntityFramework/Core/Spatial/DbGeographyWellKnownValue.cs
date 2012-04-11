﻿using System.Runtime.Serialization;
namespace System.Data.Entity.Core.Spatial
{
    /// <summary>
    /// A data contract serializable representation of a <see cref="DbGeography"/> value.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Db")]
    [DataContract]
    public sealed class DbGeographyWellKnownValue
    {
        public DbGeographyWellKnownValue()
        {
        }

        /// <summary>
        /// Gets or sets the coordinate system identifier (SRID) of this value.
        /// </summary>
        [DataMember(Order=1, IsRequired=false, EmitDefaultValue=false)]
        public int CoordinateSystemId { get; set; }

        /// <summary>
        /// Gets or sets the well known text representation of this value.
        /// </summary>
        [DataMember(Order=2, IsRequired=false, EmitDefaultValue=false)]
        public string WellKnownText { get; set; }

        /// <summary>
        /// Gets or sets the well known binary representation of this value.
        /// </summary>
        [DataMember(Order = 3, IsRequired = false, EmitDefaultValue = false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Required for this feature")]
        public byte[] WellKnownBinary { get; set; }      
    }
}