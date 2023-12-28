﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionFeatures2Code.  ISO2002 ID# _aPiUJdp-Ed-ak6NoX_4Aeg_646365217.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the features that may apply to a corporate action option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aPiUJdp-Ed-ak6NoX_4Aeg_646365217")]
[Description(@"Specifies the features that may apply to a corporate action option.")]
[DerivedFrom(typeof(OptionFeaturesCode))]
public enum OptionFeatures2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OptionApplicability".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aPiUJtp-Ed-ak6NoX_4Aeg_760881963")]
    [Description(@"??")]
    OptionApplicability,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Conditional".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aPiUJ9p-Ed-ak6NoX_4Aeg_646365219")]
    [Description(@"??")]
    Conditional,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MaximumCash".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aPiUKNp-Ed-ak6NoX_4Aeg_646365234")]
    [Description(@"??")]
    MaximumCash,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MaximumSecurities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aPiUKdp-Ed-ak6NoX_4Aeg_646365235")]
    [Description(@"??")]
    MaximumSecurities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OddLotPreference".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aPsFINp-Ed-ak6NoX_4Aeg_646365252")]
    [Description(@"??")]
    OddLotPreference,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Proration".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aPsFIdp-Ed-ak6NoX_4Aeg_646365269")]
    [Description(@"??")]
    Proration,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OverAndAbove".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aPsFItp-Ed-ak6NoX_4Aeg_646365295")]
    [Description(@"??")]
    OverAndAbove,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QuantityToReceive".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aPsFI9p-Ed-ak6NoX_4Aeg_646365296")]
    [Description(@"??")]
    QuantityToReceive,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReducedWithholdingTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aPsFJNp-Ed-ak6NoX_4Aeg_646365313")]
    [Description(@"??")]
    ReducedWithholdingTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NoServiceOffered".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aPsFJdp-Ed-ak6NoX_4Aeg_539775341")]
    [Description(@"??")]
    NoServiceOffered,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OptionFeatures2CodeMetadataExtensions
{
    private static readonly OptionFeatures2CodeDropdownSource _dropdownSource = new OptionFeatures2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOptionFeatures2CodeDropdownRow GetMetadata(this OptionFeatures2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

