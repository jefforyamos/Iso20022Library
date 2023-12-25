﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalTaxAmountTypeCode.  ISO2002 ID# _4wFuwIMlEeeBDNMiErKunw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature, or use, of the amount in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4wFuwIMlEeeBDNMiErKunw")]
[Description(@"Specifies the nature, or use, of the amount in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalTaxAmountTypeCode
{
    /// <summary>
    /// Tax accessed by city jurisdications within a country.
    /// </summary>
    [EnumMember(Value = "CITY")]
    [IsoId("_uMAeufRYEeuLhpyIdtJzwg")]
    [Description(@"Tax accessed by city jurisdications within a country.")]
    CITY,
    
    /// <summary>
    /// Tax accessed by county jurisdications within a country.
    /// </summary>
    [EnumMember(Value = "CNTY")]
    [IsoId("_uMAevPRYEeuLhpyIdtJzwg")]
    [Description(@"Tax accessed by county jurisdications within a country.")]
    CNTY,
    
    /// <summary>
    /// Tax accessed by local jurisdications within a country.
    /// </summary>
    [EnumMember(Value = "LOCL")]
    [IsoId("_uMKPsPRYEeuLhpyIdtJzwg")]
    [Description(@"Tax accessed by local jurisdications within a country.")]
    LOCL,
    
    /// <summary>
    /// Tax accessed by province jurisdications within a country.
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_uMKPs_RYEeuLhpyIdtJzwg")]
    [Description(@"Tax accessed by province jurisdications within a country.")]
    PROV,
    
    /// <summary>
    /// Tax accessed by state jurisdications within a country.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_uMKPtvRYEeuLhpyIdtJzwg")]
    [Description(@"Tax accessed by state jurisdications within a country.")]
    STAT,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalTaxAmountTypeCodeMetadataExtensions
{
    private static readonly ExternalTaxAmountTypeCodeDropdownSource _dropdownSource = new ExternalTaxAmountTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalTaxAmountTypeCodeDropdownRow GetMetadata(this ExternalTaxAmountTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


