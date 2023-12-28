﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalBalanceType1Code.  ISO2002 ID# _XihW8IakEeeUws0ZryHQ2w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the balance type, as published in an external balance type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XihW8IakEeeUws0ZryHQ2w")]
[Description(@"Specifies the balance type, as published in an external balance type code set. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalBalanceTypeCode))]
public enum ExternalBalanceType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClosingAvailable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ua6dZfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ClosingAvailable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClosingBooked".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ua6daPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ClosingBooked,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForwardAvailable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ua6da_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ForwardAvailable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Information".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ua6dbvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Information,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InterimAvailable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ubDnUvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    InterimAvailable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InterimBooked".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ubDnVfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    InterimBooked,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OpeningAvailable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ubDnWPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    OpeningAvailable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OpeningBooked".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ubDnW_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    OpeningBooked,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreviouslyClosedBooked".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ubNYUvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PreviouslyClosedBooked,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Expected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ubNYVfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Expected,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalBalanceType1CodeMetadataExtensions
{
    private static readonly ExternalBalanceType1CodeDropdownSource _dropdownSource = new ExternalBalanceType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalBalanceType1CodeDropdownRow GetMetadata(this ExternalBalanceType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

