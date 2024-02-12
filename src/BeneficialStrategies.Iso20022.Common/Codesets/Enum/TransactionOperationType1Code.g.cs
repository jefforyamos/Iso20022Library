﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionOperationType1Code.  ISO2002 ID# _8-aicJfpEeSfnc-VXAEapg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of process related to a specific transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8-aicJfpEeSfnc-VXAEapg")]
[Description(@"Specifies the type of process related to a specific transaction.")]
[DerivedFrom(typeof(TransactionOperationTypeCode))]
public enum TransactionOperationType1Code
{
    /// <summary>
    /// Transaction amends a previously sent transaction.
    /// Encoded/decoded by serializers as "AMND".
    /// </summary>
    [EnumMember(Value = "AMND")]
    [IsoId("_MjJJsZfsEeSfnc-VXAEapg")]
    [Description(@"Transaction amends a previously sent transaction.")]
    Amendment = TransactionOperationTypeCode.Amendment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction requests the deletion/cancellation of a previously sent transaction.
    /// Encoded/decoded by serializers as "CANC".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_Mn2DgZfsEeSfnc-VXAEapg")]
    [Description(@"Transaction requests the deletion/cancellation of a previously sent transaction.")]
    Cancellation = TransactionOperationTypeCode.Cancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction corrects errors in a previously sent transaction.
    /// Encoded/decoded by serializers as "CORR".
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_MwUDAZfsEeSfnc-VXAEapg")]
    [Description(@"Transaction corrects errors in a previously sent transaction.")]
    Correction = TransactionOperationTypeCode.Correction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a new transaction.
    /// Encoded/decoded by serializers as "NEWT".
    /// </summary>
    [EnumMember(Value = "NEWT")]
    [IsoId("_M3ELQZfsEeSfnc-VXAEapg")]
    [Description(@"Transaction is a new transaction.")]
    NewTransaction = TransactionOperationTypeCode.NewTransaction, // same ordinal as derivation source for type conversions
    
}
