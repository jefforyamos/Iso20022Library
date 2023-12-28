﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesBalanceType4Code.  ISO2002 ID# _ZB5cUtp-Ed-ak6NoX_4Aeg_-666523957.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the securities or investment fund balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZB5cUtp-Ed-ak6NoX_4Aeg_-666523957")]
[Description(@"Specifies the nature of the securities or investment fund balance.")]
[DerivedFrom(typeof(SecuritiesBalanceTypeCode))]
public enum SecuritiesBalanceType4Code
{
    /// <summary>
    /// Balance of tax-exempt securities.
    /// Encoded/decoded by serializers as "TaxExempt".
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_ZB5cU9p-Ed-ak6NoX_4Aeg_-1960973135")]
    [Description(@"Balance of tax-exempt securities.")]
    TaxExempt,
    
    /// <summary>
    /// Balance of taxable securities.
    /// Encoded/decoded by serializers as "NonTaxExempt".
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_ZB5cVNp-Ed-ak6NoX_4Aeg_-1960973134")]
    [Description(@"Balance of taxable securities.")]
    NonTaxExempt,
    
    /// <summary>
    /// Balance of securities that are registered (in the name of a nominee or of the beneficial owner).
    /// Encoded/decoded by serializers as "Registered".
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_ZB5cVdp-Ed-ak6NoX_4Aeg_-1960973105")]
    [Description(@"Balance of securities that are registered (in the name of a nominee or of the beneficial owner).")]
    Registered,
    
    /// <summary>
    /// Balance of securities that is unclassified, ie, is not identified with one of the existing sub-balance types.
    /// Encoded/decoded by serializers as "Unclassified".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZB5cVtp-Ed-ak6NoX_4Aeg_-1960973104")]
    [Description(@"Balance of securities that is unclassified, ie, is not identified with one of the existing sub-balance types.")]
    Unclassified,
    
    /// <summary>
    /// Balance of securities that remain registered in the name of the prior beneficial owner of securities.
    /// Encoded/decoded by serializers as "StreetPosition".
    /// </summary>
    [EnumMember(Value = "SPOS")]
    [IsoId("_ZB5cV9p-Ed-ak6NoX_4Aeg_-1960973074")]
    [Description(@"Balance of securities that remain registered in the name of the prior beneficial owner of securities.")]
    StreetPosition,
    
    /// <summary>
    /// Balance of securities that could not be registered due to foreign ownership limitation.
    /// Encoded/decoded by serializers as "Unregistered".
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_ZB5cWNp-Ed-ak6NoX_4Aeg_-1960973043")]
    [Description(@"Balance of securities that could not be registered due to foreign ownership limitation.")]
    Unregistered,
    
    /// <summary>
    /// Investment fund order contains a side pocket component.
    /// Encoded/decoded by serializers as "SidePocketComponent".
    /// </summary>
    [EnumMember(Value = "SPCM")]
    [IsoId("_ZB5cWdp-Ed-ak6NoX_4Aeg_-1956354582")]
    [Description(@"Investment fund order contains a side pocket component.")]
    SidePocketComponent,
    
    /// <summary>
    /// Investment fund order execution subject to redemption proceeds.
    /// Encoded/decoded by serializers as "Holdback".
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_ZCDNUNp-Ed-ak6NoX_4Aeg_-1313586291")]
    [Description(@"Investment fund order execution subject to redemption proceeds.")]
    Holdback,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesBalanceType4CodeMetadataExtensions
{
    private static readonly SecuritiesBalanceType4CodeDropdownSource _dropdownSource = new SecuritiesBalanceType4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesBalanceType4CodeDropdownRow GetMetadata(this SecuritiesBalanceType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


