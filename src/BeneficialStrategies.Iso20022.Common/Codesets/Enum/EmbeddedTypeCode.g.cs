﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EmbeddedTypeCode.  ISO2002 ID# _w783gIcPEeu4rpsqTt37Pg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the list of codes applicable to embedded option types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_w783gIcPEeu4rpsqTt37Pg")]
[Description(@"Specifies the list of codes applicable to embedded option types.")]
[Derivations(typeof(EmbeddedType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum EmbeddedTypeCode
{
    /// <summary>
    /// Option must be early terminated.
    /// Encoded/decoded by serializers as "MDET".
    /// </summary>
    [EnumMember(Value = "MDET")]
    [IsoId("_2RrmEIcPEeu4rpsqTt37Pg")]
    [Description(@"Option must be early terminated.")]
    MandatoryEarlyTermination,
    
    /// <summary>
    /// Option can be early terminated.
    /// Encoded/decoded by serializers as "OPET".
    /// </summary>
    [EnumMember(Value = "OPET")]
    [IsoId("_5nedMIcPEeu4rpsqTt37Pg")]
    [Description(@"Option can be early terminated.")]
    OptionalEarlyTermination,
    
    /// <summary>
    /// Option can be cancelled.
    /// Encoded/decoded by serializers as "CANC".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_9zaSIIcPEeu4rpsqTt37Pg")]
    [Description(@"Option can be cancelled.")]
    Cancellable,
    
    /// <summary>
    /// Option can be extended.
    /// Encoded/decoded by serializers as "EXTD".
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("_BeLTsIcQEeu4rpsqTt37Pg")]
    [Description(@"Option can be extended.")]
    Extendible,
    
    /// <summary>
    /// Option type is other.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_DZqI8IcQEeu4rpsqTt37Pg")]
    [Description(@"Option type is other.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EmbeddedTypeCodeMetadataExtensions
{
    private static readonly EmbeddedTypeCodeDropdownSource _dropdownSource = new EmbeddedTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEmbeddedTypeCodeDropdownRow GetMetadata(this EmbeddedTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


