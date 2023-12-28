﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingReason7Code.  ISO2002 ID# _aDBiJ9p-Ed-ak6NoX_4Aeg_1672936619.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why a cancellation request sent for the related instruction is pending.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aDBiJ9p-Ed-ak6NoX_4Aeg_1672936619")]
[Description(@"Specifies the reason why a cancellation request sent for the related instruction is pending.")]
[DerivedFrom(typeof(PendingFailingReasonCode))]
public enum PendingReason7Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aDBiKNp-Ed-ak6NoX_4Aeg_-976763242")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AwaitingConfirmation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aDKsENp-Ed-ak6NoX_4Aeg_675864266")]
    [Description(@"??")]
    AwaitingConfirmation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aDKsEdp-Ed-ak6NoX_4Aeg_383906528")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QuantityDisagreement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aDKsEtp-Ed-ak6NoX_4Aeg_-382017129")]
    [Description(@"??")]
    QuantityDisagreement,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PendingReason7CodeMetadataExtensions
{
    private static readonly PendingReason7CodeDropdownSource _dropdownSource = new PendingReason7CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPendingReason7CodeDropdownRow GetMetadata(this PendingReason7Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

