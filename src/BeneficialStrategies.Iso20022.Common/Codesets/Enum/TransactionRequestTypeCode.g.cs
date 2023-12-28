﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionRequestTypeCode.  ISO2002 ID# _0-HZ0GKCEeGByYwyG-c4ow.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of information request related to a transaction number.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0-HZ0GKCEeGByYwyG-c4ow")]
[Description(@"Specifies the type of information request related to a transaction number.")]
public enum TransactionRequestTypeCode
{
    /// <summary>
    /// Request is the original receipt.
    /// Encoded/decoded by serializers as "OREC".
    /// </summary>
    [EnumMember(Value = "OREC")]
    [IsoId("_890bXWKCEeGByYwyG-c4ow")]
    [Description(@"Request is the original receipt.")]
    OriginalReceipt,
    
    /// <summary>
    /// Request is the date and time related to the original transaction numlber.
    /// Encoded/decoded by serializers as "DTTX".
    /// </summary>
    [EnumMember(Value = "DTTX")]
    [IsoId("_GMETnWKDEeGByYwyG-c4ow")]
    [Description(@"Request is the date and time related to the original transaction numlber.")]
    DateTimeTransaction,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionRequestTypeCodeMetadataExtensions
{
    private static readonly TransactionRequestTypeCodeDropdownSource _dropdownSource = new TransactionRequestTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionRequestTypeCodeDropdownRow GetMetadata(this TransactionRequestTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

