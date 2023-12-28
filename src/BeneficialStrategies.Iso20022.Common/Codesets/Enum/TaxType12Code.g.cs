﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxType12Code.  ISO2002 ID# _YkP3Atp-Ed-ak6NoX_4Aeg_-1091962237.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YkP3Atp-Ed-ak6NoX_4Aeg_-1091962237")]
[Description(@"Specifies the type of tax.")]
[DerivedFrom(typeof(TaxTypeCode))]
public enum TaxType12Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InterimProfitTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YkP3A9p-Ed-ak6NoX_4Aeg_-582177215")]
    [Description(@"??")]
    InterimProfitTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EUTaxRetention".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YkP3BNp-Ed-ak6NoX_4Aeg_-581256561")]
    [Description(@"??")]
    EUTaxRetention,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Aktiengewinn1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YkP3Bdp-Ed-ak6NoX_4Aeg_-581256518")]
    [Description(@"??")]
    Aktiengewinn1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Aktiengewinn2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YkP3Btp-Ed-ak6NoX_4Aeg_-581256501")]
    [Description(@"??")]
    Aktiengewinn2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Zwischengewinn".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YkP3B9p-Ed-ak6NoX_4Aeg_-581256483")]
    [Description(@"??")]
    Zwischengewinn,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Mietgewinn".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YkP3CNp-Ed-ak6NoX_4Aeg_-523997623")]
    [Description(@"??")]
    Mietgewinn,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxType12CodeMetadataExtensions
{
    private static readonly TaxType12CodeDropdownSource _dropdownSource = new TaxType12CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxType12CodeDropdownRow GetMetadata(this TaxType12Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


