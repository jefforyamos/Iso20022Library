﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionFrequencyType4Code.  ISO2002 ID# _Sm9LEKFUEeSK_vfd3NHBGg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the frequency type of a corporate action event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Sm9LEKFUEeSK_vfd3NHBGg")]
[Description(@"Specifies the frequency type of a corporate action event.")]
[DerivedFrom(typeof(CorporateActionFrequencyTypeV2Code))]
public enum CorporateActionFrequencyType4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SpecialDividendWithReinvestment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_udHZoaFUEeSK_vfd3NHBGg")]
    [Description(@"??")]
    SpecialDividendWithReinvestment,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionFrequencyType4CodeMetadataExtensions
{
    private static readonly CorporateActionFrequencyType4CodeDropdownSource _dropdownSource = new CorporateActionFrequencyType4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionFrequencyType4CodeDropdownRow GetMetadata(this CorporateActionFrequencyType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


