﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for KnowYourCustomerCheckType1Code.  ISO2002 ID# _4-CwIBRxEeOKWo1NF21OVw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of Know Your Customer (KYC) or anti-money laundering due diligence to which the investor has been subjected.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4-CwIBRxEeOKWo1NF21OVw")]
[Description(@"Specifies the type of Know Your Customer (KYC) or anti-money laundering due diligence to which the investor has been subjected.")]
[DerivedFrom(typeof(KnowYourCustomerCheckTypeCode))]
public enum KnowYourCustomerCheckType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Enhanced".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_965EoRRxEeOKWo1NF21OVw")]
    [Description(@"??")]
    Enhanced,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Ordinary".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-CrHoRRxEeOKWo1NF21OVw")]
    [Description(@"??")]
    Ordinary,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Simple".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-KhcERRxEeOKWo1NF21OVw")]
    [Description(@"??")]
    Simple,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class KnowYourCustomerCheckType1CodeMetadataExtensions
{
    private static readonly KnowYourCustomerCheckType1CodeDropdownSource _dropdownSource = new KnowYourCustomerCheckType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IKnowYourCustomerCheckType1CodeDropdownRow GetMetadata(this KnowYourCustomerCheckType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


