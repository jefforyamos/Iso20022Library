﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingCancellationReason5Code.  ISO2002 ID# _MImWcIluEeavwKddCbm3hg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the cancellation request has a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MImWcIluEeavwKddCbm3hg")]
[Description(@"Specifies the reason why the cancellation request has a pending status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum PendingCancellationReason5Code
{
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_amb5AYluEeavwKddCbm3hg")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_dkbUIYluEeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV3Code.QuantityRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid instructed cash amount.
    /// Encoded/decoded by serializers as "DQCS".
    /// </summary>
    [EnumMember(Value = "DQCS")]
    [IsoId("_jurP4YluEeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid instructed cash amount.")]
    AmountRejection = RejectionReasonV3Code.AmountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_lj66QYluEeavwKddCbm3hg")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_sLLiIYluEeavwKddCbm3hg")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PendingCancellationReason5CodeMetadataExtensions
{
    private static readonly PendingCancellationReason5CodeDropdownSource _dropdownSource = new PendingCancellationReason5CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPendingCancellationReason5CodeDropdownRow GetMetadata(this PendingCancellationReason5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


