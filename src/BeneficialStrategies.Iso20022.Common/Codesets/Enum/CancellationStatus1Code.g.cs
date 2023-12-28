﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancellationStatus1Code.  ISO2002 ID# _Ve9hENp-Ed-ak6NoX_4Aeg_1602081773.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the cancellation status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ve9hENp-Ed-ak6NoX_4Aeg_1602081773")]
[Description(@"Specifies the cancellation status.")]
[DerivedFrom(typeof(CancellationStatusCode))]
public enum CancellationStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SentToNextParty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Ve9hEdp-Ed-ak6NoX_4Aeg_1711057455")]
    [Description(@"??")]
    SentToNextParty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Ve9hEtp-Ed-ak6NoX_4Aeg_1711057480")]
    [Description(@"??")]
    Accepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Ve9hE9p-Ed-ak6NoX_4Aeg_1711057497")]
    [Description(@"??")]
    Pending,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancellationStatus1CodeMetadataExtensions
{
    private static readonly CancellationStatus1CodeDropdownSource _dropdownSource = new CancellationStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancellationStatus1CodeDropdownRow GetMetadata(this CancellationStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

