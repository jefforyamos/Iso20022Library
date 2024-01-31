﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionInitiatorCode.  ISO2002 ID# _jfoDtmzfEemD24gVaMSpeA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the transaction initiator.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jfoDtmzfEemD24gVaMSpeA")]
[Description(@"Identifies the transaction initiator.")]
[Derivations(typeof(TransactionInitiator1Code))]
public enum TransactionInitiatorCode
{
    /// <summary>
    /// Merchant initiated transaction.
    /// Encoded/decoded by serializers as "MERC".
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_jfoDt2zfEemD24gVaMSpeA")]
    [Description(@"Merchant initiated transaction.")]
    Merchant,
    
    /// <summary>
    /// Customer initiated transaction.
    /// Encoded/decoded by serializers as "CUST".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_jfoDuGzfEemD24gVaMSpeA")]
    [Description(@"Customer initiated transaction.")]
    Customer,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionInitiatorCodeMetadataExtensions
{
    private static readonly TransactionInitiatorCodeDropdownSource _dropdownSource = new TransactionInitiatorCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionInitiatorCodeDropdownRow GetMetadata(this TransactionInitiatorCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


