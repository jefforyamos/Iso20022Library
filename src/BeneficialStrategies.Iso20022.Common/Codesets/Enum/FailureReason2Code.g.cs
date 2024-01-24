﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FailureReason2Code.  ISO2002 ID# _NisZYB2wEeKyZ4l838zwaQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// List of incidents happening at the acceptor during the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NisZYB2wEeKyZ4l838zwaQ")]
[Description(@"List of incidents happening at the acceptor during the transaction.")]
[DerivedFrom(typeof(FailureReasonCode))]
public enum FailureReason2Code
{
    /// <summary>
    /// Integrated circuit card declines the transaction before or after the authorisation.
    /// Encoded/decoded by serializers as "CDCL".
    /// </summary>
    [EnumMember(Value = "CDCL")]
    [IsoId("_PvbWsR2wEeKyZ4l838zwaQ")]
    [Description(@"Integrated circuit card declines the transaction before or after the authorisation.")]
    CardDeclined = FailureReasonCode.CardDeclined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer cancellation, for example removing the card before the end of the transaction.
    /// Encoded/decoded by serializers as "CUCL".
    /// </summary>
    [EnumMember(Value = "CUCL")]
    [IsoId("_P3KWYR2wEeKyZ4l838zwaQ")]
    [Description(@"Customer cancellation, for example removing the card before the end of the transaction.")]
    CustomerCancel = FailureReasonCode.CustomerCancel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Suspected malfunction.
    /// Encoded/decoded by serializers as "MALF".
    /// </summary>
    [EnumMember(Value = "MALF")]
    [IsoId("_P9avYx2wEeKyZ4l838zwaQ")]
    [Description(@"Suspected malfunction.")]
    Malfunction = FailureReasonCode.Malfunction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline authorisation declined the transaction.
    /// Encoded/decoded by serializers as "FDCL".
    /// </summary>
    [EnumMember(Value = "FDCL")]
    [IsoId("_QD9cQR2wEeKyZ4l838zwaQ")]
    [Description(@"Offline authorisation declined the transaction.")]
    OfflineDeclined = FailureReasonCode.OfflineDeclined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Online authorisation declined the transaction.
    /// Encoded/decoded by serializers as "NDCL".
    /// </summary>
    [EnumMember(Value = "NDCL")]
    [IsoId("_QKgJIR2wEeKyZ4l838zwaQ")]
    [Description(@"Online authorisation declined the transaction.")]
    OnLineDeclined = FailureReasonCode.OnLineDeclined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Completed partially.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_QW2jER2wEeKyZ4l838zwaQ")]
    [Description(@"Completed partially.")]
    Partial = FailureReasonCode.Partial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card payment transaction fails because the merchant suspect a fraud.
    /// Encoded/decoded by serializers as "SFRD".
    /// </summary>
    [EnumMember(Value = "SFRD")]
    [IsoId("_QiAqMR2wEeKyZ4l838zwaQ")]
    [Description(@"Card payment transaction fails because the merchant suspect a fraud.")]
    SuspectedFraud = FailureReasonCode.SuspectedFraud, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response).
    /// Encoded/decoded by serializers as "TIMO".
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_QoQcIR2wEeKyZ4l838zwaQ")]
    [Description(@"Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response).")]
    TimeOut = FailureReasonCode.TimeOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to the previous message was received too late.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_Qup_ER2wEeKyZ4l838zwaQ")]
    [Description(@"Response to the previous message was received too late.")]
    TooLateResponse = FailureReasonCode.TooLateResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unable to complete the transaction after the authorisation response.
    /// Encoded/decoded by serializers as "UCMP".
    /// </summary>
    [EnumMember(Value = "UCMP")]
    [IsoId("_Q2ivwR2wEeKyZ4l838zwaQ")]
    [Description(@"Unable to complete the transaction after the authorisation response.")]
    UnableToComplete = FailureReasonCode.UnableToComplete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unable to deliver the request message to the recipient party.
    /// Encoded/decoded by serializers as "USND".
    /// </summary>
    [EnumMember(Value = "USND")]
    [IsoId("_Q9FcoR2wEeKyZ4l838zwaQ")]
    [Description(@"Unable to deliver the request message to the recipient party.")]
    UnableToSend = FailureReasonCode.UnableToSend, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FailureReason2CodeMetadataExtensions
{
    private static readonly FailureReason2CodeDropdownSource _dropdownSource = new FailureReason2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFailureReason2CodeDropdownRow GetMetadata(this FailureReason2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


