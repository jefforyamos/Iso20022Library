﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionRequestType1Code.  ISO2002 ID# _QME_8GKDEeGByYwyG-c4ow.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of information request related to a transaction number.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QME_8GKDEeGByYwyG-c4ow")]
[Description(@"Specifies the type of information request related to a transaction number.")]
[DerivedFrom(typeof(TransactionRequestTypeCode))]
public enum TransactionRequestType1Code
{
    /// <summary>
    /// Request is the date and time related to the original transaction numlber.
    /// Encoded/decoded by serializers as "DateTimeTransaction".
    /// </summary>
    [EnumMember(Value = "DTTX")]
    [IsoId("_X0PrNmKDEeGByYwyG-c4ow")]
    [Description(@"Request is the date and time related to the original transaction numlber.")]
    DateTimeTransaction,
    
    /// <summary>
    /// Request is the original receipt.
    /// Encoded/decoded by serializers as "OriginalReceipt".
    /// </summary>
    [EnumMember(Value = "OREC")]
    [IsoId("_X43shmKDEeGByYwyG-c4ow")]
    [Description(@"Request is the original receipt.")]
    OriginalReceipt,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionRequestType1CodeMetadataExtensions
{
    private static readonly TransactionRequestType1CodeDropdownSource _dropdownSource = new TransactionRequestType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionRequestType1CodeDropdownRow GetMetadata(this TransactionRequestType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


