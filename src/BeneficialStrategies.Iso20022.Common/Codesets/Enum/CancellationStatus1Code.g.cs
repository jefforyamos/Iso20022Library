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
    /// Cancellation instruction/request has been sent to the next party, that is, the next intermediary.
    /// Encoded/decoded by serializers as "SentToNextParty".
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_Ve9hEdp-Ed-ak6NoX_4Aeg_1711057455")]
    [Description(@"Cancellation instruction/request has been sent to the next party, that is, the next intermediary.")]
    SentToNextParty,
    
    /// <summary>
    /// Cancellation instruction / request has been received and has been acknowledged / accepted for further processing.
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_Ve9hEtp-Ed-ak6NoX_4Aeg_1711057480")]
    [Description(@"Cancellation instruction / request has been received and has been acknowledged / accepted for further processing.")]
    Accepted,
    
    /// <summary>
    /// Cancellation instruction / request is pending. It is not known at this time whether cancellation can be effected.
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_Ve9hE9p-Ed-ak6NoX_4Aeg_1711057497")]
    [Description(@"Cancellation instruction / request is pending. It is not known at this time whether cancellation can be effected.")]
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


