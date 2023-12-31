﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RateType3Code.  ISO2002 ID# _ZZcZqNp-Ed-ak6NoX_4Aeg_-1424495957.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZZcZqNp-Ed-ak6NoX_4Aeg_-1424495957")]
[Description(@"Specifies the type of tax rate.")]
[DerivedFrom(typeof(RateTypeCode))]
public enum RateType3Code
{
    /// <summary>
    /// Imputed tax.
    /// Encoded/decoded by serializers as "Imputed".
    /// </summary>
    [EnumMember(Value = "IMPU")]
    [IsoId("_ZZcZqdp-Ed-ak6NoX_4Aeg_-1424495955")]
    [Description(@"Imputed tax.")]
    Imputed,
    
    /// <summary>
    /// Rate is a precompte.
    /// Encoded/decoded by serializers as "Precompte".
    /// </summary>
    [EnumMember(Value = "PREC")]
    [IsoId("_ZZmKoNp-Ed-ak6NoX_4Aeg_-1424495946")]
    [Description(@"Rate is a precompte.")]
    Precompte,
    
    /// <summary>
    /// Rate is a one tier tax.
    /// Encoded/decoded by serializers as "OneTierTax".
    /// </summary>
    [EnumMember(Value = "TIER")]
    [IsoId("_ZZmKodp-Ed-ak6NoX_4Aeg_-1424495927")]
    [Description(@"Rate is a one tier tax.")]
    OneTierTax,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RateType3CodeMetadataExtensions
{
    private static readonly RateType3CodeDropdownSource _dropdownSource = new RateType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRateType3CodeDropdownRow GetMetadata(this RateType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


