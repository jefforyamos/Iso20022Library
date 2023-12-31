﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionOperationType3Code.  ISO2002 ID# _IyMY0A3mEeWc7_0KPiuk6w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transaction operation action type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IyMY0A3mEeWc7_0KPiuk6w")]
[Description(@"Specifies the transaction operation action type.")]
[DerivedFrom(typeof(TransactionOperationTypeCode))]
public enum TransactionOperationType3Code
{
    /// <summary>
    /// Transaction corrects errors in a previously sent transaction.
    /// Encoded/decoded by serializers as "Correction".
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_ujf94RVlEeWXLoZC9OIRgg")]
    [Description(@"Transaction corrects errors in a previously sent transaction.")]
    Correction,
    
    /// <summary>
    /// Transaction is an early termination.
    /// Encoded/decoded by serializers as "EarlyTermination".
    /// </summary>
    [EnumMember(Value = "ETRM")]
    [IsoId("_u-bmYRVlEeWXLoZC9OIRgg")]
    [Description(@"Transaction is an early termination.")]
    EarlyTermination,
    
    /// <summary>
    /// Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake, in which case, it will be identified as ‘error’.
    /// Encoded/decoded by serializers as "Error".
    /// </summary>
    [EnumMember(Value = "EROR")]
    [IsoId("_vKyAURVlEeWXLoZC9OIRgg")]
    [Description(@"Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake, in which case, it will be identified as ‘error’.")]
    Error,
    
    /// <summary>
    /// Transaction is a new transaction.
    /// Encoded/decoded by serializers as "NewTransaction".
    /// </summary>
    [EnumMember(Value = "NEWT")]
    [IsoId("_vXRkMRVlEeWXLoZC9OIRgg")]
    [Description(@"Transaction is a new transaction.")]
    NewTransaction,
    
    /// <summary>
    /// Contract to be reported as a new trade and included in a separate position report on the same day.
    /// Encoded/decoded by serializers as "PositionComponent".
    /// </summary>
    [EnumMember(Value = "POSC")]
    [IsoId("_0sccoRVmEeWXLoZC9OIRgg")]
    [Description(@"Contract to be reported as a new trade and included in a separate position report on the same day.")]
    PositionComponent,
    
    /// <summary>
    /// Update of a contract valuation or collateral.
    /// Encoded/decoded by serializers as "ValuationUpdate".
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("_08g48RVmEeWXLoZC9OIRgg")]
    [Description(@"Update of a contract valuation or collateral.")]
    ValuationUpdate,
    
    /// <summary>
    /// Transaction is a compression.
    /// Encoded/decoded by serializers as "Compression".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_1EZCkRVmEeWXLoZC9OIRgg")]
    [Description(@"Transaction is a compression.")]
    Compression,
    
    /// <summary>
    /// Transaction modifies in a previously sent transaction.
    /// Encoded/decoded by serializers as "Modification".
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_1MRzQRVmEeWXLoZC9OIRgg")]
    [Description(@"Transaction modifies in a previously sent transaction.")]
    Modification,
    
    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_DrttMeleEeWv8d_RPCVG5g")]
    [Description(@"Other.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionOperationType3CodeMetadataExtensions
{
    private static readonly TransactionOperationType3CodeDropdownSource _dropdownSource = new TransactionOperationType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionOperationType3CodeDropdownRow GetMetadata(this TransactionOperationType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


