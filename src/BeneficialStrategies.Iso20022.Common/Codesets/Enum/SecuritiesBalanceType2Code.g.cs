﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesBalanceType2Code.  ISO2002 ID# _ZBdXcdp-Ed-ak6NoX_4Aeg_1919950094.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the securities or investment fund balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZBdXcdp-Ed-ak6NoX_4Aeg_1919950094")]
[Description(@"Specifies the nature of the securities or investment fund balance.")]
[DerivedFrom(typeof(SecuritiesBalanceTypeCode))]
public enum SecuritiesBalanceType2Code
{
    /// <summary>
    /// Balance of tax-exempt securities.
    /// Encoded/decoded by serializers as "CLEN".
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_ZBdXctp-Ed-ak6NoX_4Aeg_-1506908875")]
    [Description(@"Balance of tax-exempt securities.")]
    TaxExempt = SecuritiesBalanceTypeCode.TaxExempt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of taxable securities.
    /// Encoded/decoded by serializers as "DIRT".
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_ZBdXc9p-Ed-ak6NoX_4Aeg_-1263096881")]
    [Description(@"Balance of taxable securities.")]
    NonTaxExempt = SecuritiesBalanceTypeCode.NonTaxExempt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities that are registered (in the name of a nominee or of the beneficial owner).
    /// Encoded/decoded by serializers as "NOMI".
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_ZBdXdNp-Ed-ak6NoX_4Aeg_-1164280659")]
    [Description(@"Balance of securities that are registered (in the name of a nominee or of the beneficial owner).")]
    Registered = SecuritiesBalanceTypeCode.Registered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities that is unclassified, ie, is not identified with one of the existing sub-balance types.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZBdXddp-Ed-ak6NoX_4Aeg_-829968446")]
    [Description(@"Balance of securities that is unclassified, ie, is not identified with one of the existing sub-balance types.")]
    Unclassified = SecuritiesBalanceTypeCode.Unclassified, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities that remain registered in the name of the prior beneficial owner of securities.
    /// Encoded/decoded by serializers as "SPOS".
    /// </summary>
    [EnumMember(Value = "SPOS")]
    [IsoId("_ZBdXdtp-Ed-ak6NoX_4Aeg_1361939833")]
    [Description(@"Balance of securities that remain registered in the name of the prior beneficial owner of securities.")]
    StreetPosition = SecuritiesBalanceTypeCode.StreetPosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities that could not be registered due to foreign ownership limitation.
    /// Encoded/decoded by serializers as "UNRG".
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_ZBdXd9p-Ed-ak6NoX_4Aeg_1680553649")]
    [Description(@"Balance of securities that could not be registered due to foreign ownership limitation.")]
    Unregistered = SecuritiesBalanceTypeCode.Unregistered, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesBalanceType2CodeMetadataExtensions
{
    private static readonly SecuritiesBalanceType2CodeDropdownSource _dropdownSource = new SecuritiesBalanceType2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesBalanceType2CodeDropdownRow GetMetadata(this SecuritiesBalanceType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


