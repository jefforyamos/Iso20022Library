﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalPaymentControlRequestType1Code.  ISO2002 ID# _EJVeUJIhEeect698_YsnIA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external request type code for a payment control command in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EJVeUJIhEeect698_YsnIA")]
[Description(@"Specifies the external request type code for a payment control command in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code set published separately.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalPaymentControlRequestTypeCode))]
public enum ExternalPaymentControlRequestType1Code
{
    /// <summary>
    /// Type is a request to release the pending transactions.
    /// Encoded/decoded by serializers as "RT01".
    /// </summary>
    [EnumMember(Value = "RT01")]
    [IsoId("_udl9-PRYEeuLhpyIdtJzwg")]
    [Description(@"Type is a request to release the pending transactions.")]
    ReleasePending = ExternalPaymentControlRequestTypeCode.ReleasePending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type is a request to hold normal transactions.
    /// Encoded/decoded by serializers as "RT02".
    /// </summary>
    [EnumMember(Value = "RT02")]
    [IsoId("_udl9-_RYEeuLhpyIdtJzwg")]
    [Description(@"Type is a request to hold normal transactions.")]
    HoldNormal = ExternalPaymentControlRequestTypeCode.HoldNormal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type is a request to cancel a transaction.
    /// Encoded/decoded by serializers as "RT03".
    /// </summary>
    [EnumMember(Value = "RT03")]
    [IsoId("_udl9_vRYEeuLhpyIdtJzwg")]
    [Description(@"Type is a request to cancel a transaction.")]
    Cancellation = ExternalPaymentControlRequestTypeCode.Cancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type is a request to change the sequence of the transactions.
    /// Encoded/decoded by serializers as "RT04".
    /// </summary>
    [EnumMember(Value = "RT04")]
    [IsoId("_udvH4vRYEeuLhpyIdtJzwg")]
    [Description(@"Type is a request to change the sequence of the transactions.")]
    ReSequence = ExternalPaymentControlRequestTypeCode.ReSequence, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type is a request to release the suspicious transactions.
    /// Encoded/decoded by serializers as "RT05".
    /// </summary>
    [EnumMember(Value = "RT05")]
    [IsoId("_udvH5fRYEeuLhpyIdtJzwg")]
    [Description(@"Type is a request to release the suspicious transactions.")]
    ReleaseSuspicious = ExternalPaymentControlRequestTypeCode.ReleaseSuspicious, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalPaymentControlRequestType1CodeMetadataExtensions
{
    private static readonly ExternalPaymentControlRequestType1CodeDropdownSource _dropdownSource = new ExternalPaymentControlRequestType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalPaymentControlRequestType1CodeDropdownRow GetMetadata(this ExternalPaymentControlRequestType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


