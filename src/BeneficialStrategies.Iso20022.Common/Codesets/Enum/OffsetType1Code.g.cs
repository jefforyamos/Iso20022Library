﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OffsetType1Code.  ISO2002 ID# _aOfyV9p-Ed-ak6NoX_4Aeg_-1413993585.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of peg offset or type of discretion offset (e.g. price offset, tick offset etc).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aOfyV9p-Ed-ak6NoX_4Aeg_-1413993585")]
[Description(@"Type of peg offset or type of discretion offset (e.g. price offset, tick offset etc).")]
[DerivedFrom(typeof(OffsetTypeCode))]
public enum OffsetType1Code
{
    /// <summary>
    /// Indicates that range of peg order or discretion offset value is a price.
    /// Encoded/decoded by serializers as "Price".
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_aOo8QNp-Ed-ak6NoX_4Aeg_-1344728954")]
    [Description(@"Indicates that range of peg order or discretion offset value is a price.")]
    Price,
    
    /// <summary>
    /// The range of peg order or discretion offset value is measured in basis points.
    /// Encoded/decoded by serializers as "BasisPoint".
    /// </summary>
    [EnumMember(Value = "BAPO")]
    [IsoId("_aOo8Qdp-Ed-ak6NoX_4Aeg_-1344728894")]
    [Description(@"The range of peg order or discretion offset value is measured in basis points.")]
    BasisPoint,
    
    /// <summary>
    /// The range of peg order or discretion offset value is a tick.
    /// Encoded/decoded by serializers as "Tick".
    /// </summary>
    [EnumMember(Value = "TICK")]
    [IsoId("_aOo8Qtp-Ed-ak6NoX_4Aeg_-1344728859")]
    [Description(@"The range of peg order or discretion offset value is a tick.")]
    Tick,
    
    /// <summary>
    /// The range of peg order or discretion offset is a price level.
    /// Encoded/decoded by serializers as "PriceTierLevel".
    /// </summary>
    [EnumMember(Value = "PTLE")]
    [IsoId("_aOo8Q9p-Ed-ak6NoX_4Aeg_-1344728568")]
    [Description(@"The range of peg order or discretion offset is a price level.")]
    PriceTierLevel,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OffsetType1CodeMetadataExtensions
{
    private static readonly OffsetType1CodeDropdownSource _dropdownSource = new OffsetType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOffsetType1CodeDropdownRow GetMetadata(this OffsetType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


