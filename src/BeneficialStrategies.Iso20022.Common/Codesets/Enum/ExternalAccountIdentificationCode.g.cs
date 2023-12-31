﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalAccountIdentificationCode.  ISO2002 ID# _hmCfsIKFEeeCI5iKR7LsYQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external account identification scheme name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hmCfsIKFEeeCI5iKR7LsYQ")]
[Description(@"Specifies the external account identification scheme name code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalAccountIdentification1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ExternalAccountIdentificationCode
{
    /// <summary>
    /// Issuer Identification Number (IIN) - identifies a card issuing institution in an international interchange environment. Issued by ABA (American Bankers Association).
    /// Encoded/decoded by serializers as "AIIN".
    /// </summary>
    [EnumMember(Value = "AIIN")]
    [IsoId("_teaY4PRYEeuLhpyIdtJzwg")]
    [Description(@"Issuer Identification Number (IIN) - identifies a card issuing institution in an international interchange environment. Issued by ABA (American Bankers Association).")]
    IssuerIdentificationNumber,
    
    /// <summary>
    /// Basic Bank Account Number (BBAN) - identifier used nationally by financial institutions, ie, in individual countries, generally as part of a National Account Numbering Scheme(s), to uniquely identify the account of a customer.
    /// Encoded/decoded by serializers as "BBAN".
    /// </summary>
    [EnumMember(Value = "BBAN")]
    [IsoId("_teaY4_RYEeuLhpyIdtJzwg")]
    [Description(@"Basic Bank Account Number (BBAN) - identifier used nationally by financial institutions, ie, in individual countries, generally as part of a National Account Numbering Scheme(s), to uniquely identify the account of a customer.")]
    BBANIdentifier,
    
    /// <summary>
    /// (United States) Clearing House Interbank Payments System (CHIPS) Universal Identification (UID) - identifies entities that own accounts at CHIPS participating financial institutions, through which CHIPS payments are effected. The CHIPS UID is assigned by the New York Clearing House.
    /// Encoded/decoded by serializers as "CUID".
    /// </summary>
    [EnumMember(Value = "CUID")]
    [IsoId("_teaY5vRYEeuLhpyIdtJzwg")]
    [Description(@"(United States) Clearing House Interbank Payments System (CHIPS) Universal Identification (UID) - identifies entities that own accounts at CHIPS participating financial institutions, through which CHIPS payments are effected. The CHIPS UID is assigned by the New York Clearing House.")]
    CHIPSUniversalIdentifier,
    
    /// <summary>
    /// Universal Payment Identification Code (UPIC) - identifier used by the New York Clearing House to mask confidential data, such as bank accounts and bank routing numbers. UPIC numbers remain with business customers, regardless of banking relationship changes.
    /// Encoded/decoded by serializers as "UPIC".
    /// </summary>
    [EnumMember(Value = "UPIC")]
    [IsoId("_teji0PRYEeuLhpyIdtJzwg")]
    [Description(@"Universal Payment Identification Code (UPIC) - identifier used by the New York Clearing House to mask confidential data, such as bank accounts and bank routing numbers. UPIC numbers remain with business customers, regardless of banking relationship changes.")]
    UPICIdentifier,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalAccountIdentificationCodeMetadataExtensions
{
    private static readonly ExternalAccountIdentificationCodeDropdownSource _dropdownSource = new ExternalAccountIdentificationCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalAccountIdentificationCodeDropdownRow GetMetadata(this ExternalAccountIdentificationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


