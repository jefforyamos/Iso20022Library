﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RateType10Code.  ISO2002 ID# _uBQBEQCoEeGt2odvTAOpog.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uBQBEQCoEeGt2odvTAOpog")]
[Description(@"Specifies the type of rate.")]
[DerivedFrom(typeof(RateTypeCode))]
public enum RateType10Code
{
    /// <summary>
    /// Any and all rate is sought.
    /// Encoded/decoded by serializers as "ANYA".
    /// </summary>
    [EnumMember(Value = "ANYA")]
    [IsoId("_uBZyFQCoEeGt2odvTAOpog")]
    [Description(@"Any and all rate is sought.")]
    AnyAndAll = RateTypeCode.AnyAndAll, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_wN7UAgCoEeGt2odvTAOpog")]
    [Description(@"Rate is unknown by the sender or has not been established.")]
    Unknown = RateTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RateType10CodeMetadataExtensions
{
    private static readonly RateType10CodeDropdownSource _dropdownSource = new RateType10CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRateType10CodeDropdownRow GetMetadata(this RateType10Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


