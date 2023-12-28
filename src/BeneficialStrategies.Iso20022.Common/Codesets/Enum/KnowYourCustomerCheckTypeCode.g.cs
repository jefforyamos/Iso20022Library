﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for KnowYourCustomerCheckTypeCode.  ISO2002 ID# _WNjzwRRxEeOKWo1NF21OVw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of Know Your Customer (KYC) or anti-money laundering due diligence to which the investor has been subjected.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WNjzwRRxEeOKWo1NF21OVw")]
[Description(@"Specifies the type of Know Your Customer (KYC) or anti-money laundering due diligence to which the investor has been subjected.")]
public enum KnowYourCustomerCheckTypeCode
{
    /// <summary>
    /// Ordinary check, typically carried out on standard accounts.
    /// Encoded/decoded by serializers as "ORDN".
    /// </summary>
    [EnumMember(Value = "ORDN")]
    [IsoId("_pgZWYBRxEeOKWo1NF21OVw")]
    [Description(@"Ordinary check, typically carried out on standard accounts.")]
    Ordinary,
    
    /// <summary>
    /// Simple check, typically carried out on accounts that have a low risk of anti-money laundering, such as an account owned by a financial institution.
    /// Encoded/decoded by serializers as "SIMP".
    /// </summary>
    [EnumMember(Value = "SIMP")]
    [IsoId("_pkaTsBRxEeOKWo1NF21OVw")]
    [Description(@"Simple check, typically carried out on accounts that have a low risk of anti-money laundering, such as an account owned by a financial institution.")]
    Simple,
    
    /// <summary>
    /// Enhanced check, typically carried out on accounts that are considered high risk.
    /// Encoded/decoded by serializers as "ENHA".
    /// </summary>
    [EnumMember(Value = "ENHA")]
    [IsoId("_po388BRxEeOKWo1NF21OVw")]
    [Description(@"Enhanced check, typically carried out on accounts that are considered high risk.")]
    Enhanced,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class KnowYourCustomerCheckTypeCodeMetadataExtensions
{
    private static readonly KnowYourCustomerCheckTypeCodeDropdownSource _dropdownSource = new KnowYourCustomerCheckTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IKnowYourCustomerCheckTypeCodeDropdownRow GetMetadata(this KnowYourCustomerCheckTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

