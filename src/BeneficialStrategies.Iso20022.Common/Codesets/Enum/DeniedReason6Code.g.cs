﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DeniedReason6Code.  ISO2002 ID# _-_kAAFhdEeS8HfHHd4stCA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the denied reason.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-_kAAFhdEeS8HfHHd4stCA")]
[Description(@"Specifies the denied reason.")]
[DerivedFrom(typeof(SettlementDeniedReasonCode))]
public enum DeniedReason6Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_p17eYVheEeS8HfHHd4stCA")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ConditionalCurrency".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qVxcEVheEeS8HfHHd4stCA")]
    [Description(@"??")]
    ConditionalCurrency,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ConditionalRealignement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qrDIgVheEeS8HfHHd4stCA")]
    [Description(@"??")]
    ConditionalRealignement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeniedSinceCancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2nJuIVheEeS8HfHHd4stCA")]
    [Description(@"??")]
    DeniedSinceCancelled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeniedSinceSettled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3B7loVheEeS8HfHHd4stCA")]
    [Description(@"??")]
    DeniedSinceSettled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeniedSinceInProgress".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3iXZMVheEeS8HfHHd4stCA")]
    [Description(@"??")]
    DeniedSinceInProgress,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeniedSinceRepoEnded".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3_0xQVheEeS8HfHHd4stCA")]
    [Description(@"??")]
    DeniedSinceRepoEnded,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4Y-REVheEeS8HfHHd4stCA")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4mzRsVheEeS8HfHHd4stCA")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ConditionalRegistrar".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_AENlYV24EeS_LPIA7qJ58w")]
    [Description(@"??")]
    ConditionalRegistrar,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DeniedReason6CodeMetadataExtensions
{
    private static readonly DeniedReason6CodeDropdownSource _dropdownSource = new DeniedReason6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDeniedReason6CodeDropdownRow GetMetadata(this DeniedReason6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

