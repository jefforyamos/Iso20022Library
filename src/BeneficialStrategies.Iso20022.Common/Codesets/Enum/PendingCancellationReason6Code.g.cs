﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingCancellationReason6Code.  ISO2002 ID# _vhob4bLOEemDyeh7tbvg1w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a reason why the cancellation request has a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vhob4bLOEemDyeh7tbvg1w")]
[Description(@"Specifies a reason why the cancellation request has a pending status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum PendingCancellationReason6Code
{
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "QuantityRejection".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_v3pvMbLOEemDyeh7tbvg1w")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection,
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_v3pvNbLOEemDyeh7tbvg1w")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_v3pvN7LOEemDyeh7tbvg1w")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_zDeK8bLOEemDyeh7tbvg1w")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PendingCancellationReason6CodeMetadataExtensions
{
    private static readonly PendingCancellationReason6CodeDropdownSource _dropdownSource = new PendingCancellationReason6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPendingCancellationReason6CodeDropdownRow GetMetadata(this PendingCancellationReason6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


