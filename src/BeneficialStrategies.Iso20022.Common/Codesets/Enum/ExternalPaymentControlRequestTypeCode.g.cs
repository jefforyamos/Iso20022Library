﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalPaymentControlRequestTypeCode.  ISO2002 ID# _hQU4EZIgEeect698_YsnIA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external request type code for a payment control command in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hQU4EZIgEeect698_YsnIA")]
[Description(@"Specifies the external request type code for a payment control command in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code set published separately. External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalPaymentControlRequestType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ExternalPaymentControlRequestTypeCode
{
    /// <summary>
    /// Type is a request to release the pending transactions.
    /// Encoded/decoded by serializers as "RT01".
    /// </summary>
    [EnumMember(Value = "RT01")]
    [IsoId("_udl99vRYEeuLhpyIdtJzwg")]
    [Description(@"Type is a request to release the pending transactions.")]
    ReleasePending,
    
    /// <summary>
    /// Type is a request to hold normal transactions.
    /// Encoded/decoded by serializers as "RT02".
    /// </summary>
    [EnumMember(Value = "RT02")]
    [IsoId("_udl9-fRYEeuLhpyIdtJzwg")]
    [Description(@"Type is a request to hold normal transactions.")]
    HoldNormal,
    
    /// <summary>
    /// Type is a request to cancel a transaction.
    /// Encoded/decoded by serializers as "RT03".
    /// </summary>
    [EnumMember(Value = "RT03")]
    [IsoId("_udl9_PRYEeuLhpyIdtJzwg")]
    [Description(@"Type is a request to cancel a transaction.")]
    Cancellation,
    
    /// <summary>
    /// Type is a request to change the sequence of the transactions.
    /// Encoded/decoded by serializers as "RT04".
    /// </summary>
    [EnumMember(Value = "RT04")]
    [IsoId("_udvH4PRYEeuLhpyIdtJzwg")]
    [Description(@"Type is a request to change the sequence of the transactions.")]
    ReSequence,
    
    /// <summary>
    /// Type is a request to release the suspicious transactions.
    /// Encoded/decoded by serializers as "RT05".
    /// </summary>
    [EnumMember(Value = "RT05")]
    [IsoId("_udvH4_RYEeuLhpyIdtJzwg")]
    [Description(@"Type is a request to release the suspicious transactions.")]
    ReleaseSuspicious,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalPaymentControlRequestTypeCodeMetadataExtensions
{
    private static readonly ExternalPaymentControlRequestTypeCodeDropdownSource _dropdownSource = new ExternalPaymentControlRequestTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalPaymentControlRequestTypeCodeDropdownRow GetMetadata(this ExternalPaymentControlRequestTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


