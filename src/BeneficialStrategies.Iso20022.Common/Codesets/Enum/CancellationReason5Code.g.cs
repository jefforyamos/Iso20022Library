﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancellationReason5Code.  ISO2002 ID# _t9XiMVkyEeGeoaLUQk__nA_-362261816.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for requesting the cancellation of a payment instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t9XiMVkyEeGeoaLUQk__nA_-362261816")]
[Description(@"Specifies the reason for requesting the cancellation of a payment instruction.")]
[DerivedFrom(typeof(CancellationReasonCode))]
public enum CancellationReason5Code
{
    /// <summary>
    /// Payment is a duplicate of another payment.
    /// Encoded/decoded by serializers as "DuplicatePayment".
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_t9XiMlkyEeGeoaLUQk__nA_866989928")]
    [Description(@"Payment is a duplicate of another payment.")]
    DuplicatePayment,
    
    /// <summary>
    /// Agent in the payment workflow is incorrect.
    /// Encoded/decoded by serializers as "IncorrectAgent".
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_t9XiM1kyEeGeoaLUQk__nA_1747536954")]
    [Description(@"Agent in the payment workflow is incorrect.")]
    IncorrectAgent,
    
    /// <summary>
    /// Currency of the payment is incorrect.
    /// Encoded/decoded by serializers as "IncorrectCurrency".
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_t9hTMFkyEeGeoaLUQk__nA_437357561")]
    [Description(@"Currency of the payment is incorrect.")]
    IncorrectCurrency,
    
    /// <summary>
    /// Cancellation requested by the Debtor.
    /// Encoded/decoded by serializers as "RequestedByCustomer".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_t9hTMVkyEeGeoaLUQk__nA_323518495")]
    [Description(@"Cancellation requested by the Debtor.")]
    RequestedByCustomer,
    
    /// <summary>
    /// Payment is not justified.
    /// Encoded/decoded by serializers as "UnduePayment".
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_t9hTMlkyEeGeoaLUQk__nA_-197674285")]
    [Description(@"Payment is not justified.")]
    UnduePayment,
    
    /// <summary>
    /// Cancellation requested because an investigation request has been received and no remediation is possible.
    /// Encoded/decoded by serializers as "CancelUponUnableToApply".
    /// </summary>
    [EnumMember(Value = "CUTA")]
    [IsoId("_t9hTM1kyEeGeoaLUQk__nA_-1129610805")]
    [Description(@"Cancellation requested because an investigation request has been received and no remediation is possible.")]
    CancelUponUnableToApply,
    
    /// <summary>
    /// Cancellation requested following technical problems resulting in an erroneous transaction.
    /// Encoded/decoded by serializers as "TechnicalProblem".
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_t9hTNFkyEeGeoaLUQk__nA_228200151")]
    [Description(@"Cancellation requested following technical problems resulting in an erroneous transaction.")]
    TechnicalProblem,
    
    /// <summary>
    /// Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.
    /// Encoded/decoded by serializers as "FraudulentOrigin".
    /// </summary>
    [EnumMember(Value = "FRAD")]
    [IsoId("_t9hTNVkyEeGeoaLUQk__nA_-1922346722")]
    [Description(@"Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.")]
    FraudulentOrigin,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancellationReason5CodeMetadataExtensions
{
    private static readonly CancellationReason5CodeDropdownSource _dropdownSource = new CancellationReason5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancellationReason5CodeDropdownRow GetMetadata(this CancellationReason5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


