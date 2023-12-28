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
    /// ??
    /// Encoded/decoded by serializers as "Correction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ujf94RVlEeWXLoZC9OIRgg")]
    [Description(@"??")]
    Correction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EarlyTermination".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_u-bmYRVlEeWXLoZC9OIRgg")]
    [Description(@"??")]
    EarlyTermination,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Error".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vKyAURVlEeWXLoZC9OIRgg")]
    [Description(@"??")]
    Error,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NewTransaction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vXRkMRVlEeWXLoZC9OIRgg")]
    [Description(@"??")]
    NewTransaction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PositionComponent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_0sccoRVmEeWXLoZC9OIRgg")]
    [Description(@"??")]
    PositionComponent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ValuationUpdate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_08g48RVmEeWXLoZC9OIRgg")]
    [Description(@"??")]
    ValuationUpdate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Compression".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_1EZCkRVmEeWXLoZC9OIRgg")]
    [Description(@"??")]
    Compression,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Modification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_1MRzQRVmEeWXLoZC9OIRgg")]
    [Description(@"??")]
    Modification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_DrttMeleEeWv8d_RPCVG5g")]
    [Description(@"??")]
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

