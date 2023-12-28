﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionOperationType1Code.  ISO2002 ID# _8-aicJfpEeSfnc-VXAEapg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// ??
    /// Encoded/decoded by serializers as "Amendment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_MjJJsZfsEeSfnc-VXAEapg")]
    [Description(@"??")]
    Amendment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cancellation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Mn2DgZfsEeSfnc-VXAEapg")]
    [Description(@"??")]
    Cancellation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Correction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_MwUDAZfsEeSfnc-VXAEapg")]
    [Description(@"??")]
    Correction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NewTransaction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_M3ELQZfsEeSfnc-VXAEapg")]
    [Description(@"??")]
    NewTransaction,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionOperationType1CodeMetadataExtensions
{
    private static readonly TransactionOperationType1CodeDropdownSource _dropdownSource = new TransactionOperationType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionOperationType1CodeDropdownRow GetMetadata(this TransactionOperationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

