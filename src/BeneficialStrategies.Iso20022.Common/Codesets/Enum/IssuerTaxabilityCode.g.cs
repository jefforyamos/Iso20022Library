﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for IssuerTaxabilityCode.  ISO2002 ID# _iSnDE_ouEeCfbIXrKCjG0g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the corporate action proceeds are taxable at issuer level.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iSnDE_ouEeCfbIXrKCjG0g")]
[Description(@"Specifies whether the corporate action proceeds are taxable at issuer level.")]
public enum IssuerTaxabilityCode
{
    /// <summary>
    /// The cash proceeds are taxable.
    /// Encoded/decoded by serializers as "TXBL".
    /// </summary>
    [EnumMember(Value = "TXBL")]
    [IsoId("_lj-tN_ouEeCfbIXrKCjG0g")]
    [Description(@"The cash proceeds are taxable.")]
    Taxable,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class IssuerTaxabilityCodeMetadataExtensions
{
    private static readonly IssuerTaxabilityCodeDropdownSource _dropdownSource = new IssuerTaxabilityCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IIssuerTaxabilityCodeDropdownRow GetMetadata(this IssuerTaxabilityCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


