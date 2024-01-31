﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionFrequencyType5Code.  ISO2002 ID# _1vys4WK-EeWR9ZSfjmHwUA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Automatic Reinvestment of Cash distributed by accumulating funds.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1vys4WK-EeWR9ZSfjmHwUA")]
[Description(@"Automatic Reinvestment of Cash distributed by accumulating funds.")]
[DerivedFrom(typeof(CorporateActionFrequencyTypeV2Code))]
public enum CorporateActionFrequencyType5Code
{
    /// <summary>
    /// Payment of a dividend, less amounts already paid through interim dividends.
    /// Encoded/decoded by serializers as "FINL".
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_2DlLkWK-EeWR9ZSfjmHwUA")]
    [Description(@"Payment of a dividend, less amounts already paid through interim dividends.")]
    Final = CorporateActionFrequencyTypeV2Code.Final, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dividend declared and paid before annual earnings have been determined.
    /// Encoded/decoded by serializers as "INTE".
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_2DlLk2K-EeWR9ZSfjmHwUA")]
    [Description(@"Dividend declared and paid before annual earnings have been determined.")]
    Interim = CorporateActionFrequencyTypeV2Code.Interim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reinvestment of cash distributed.
    /// Encoded/decoded by serializers as "REIN".
    /// </summary>
    [EnumMember(Value = "REIN")]
    [IsoId("_2DlLlWK-EeWR9ZSfjmHwUA")]
    [Description(@"Reinvestment of cash distributed.")]
    Reinvestment = CorporateActionFrequencyTypeV2Code.Reinvestment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dividend paid at regular interval, for example, quarterly.
    /// Encoded/decoded by serializers as "REGR".
    /// </summary>
    [EnumMember(Value = "REGR")]
    [IsoId("_2DlLl2K-EeWR9ZSfjmHwUA")]
    [Description(@"Dividend paid at regular interval, for example, quarterly.")]
    Regular = CorporateActionFrequencyTypeV2Code.Regular, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dividend in addition to the regular dividend being paid by the company.
    /// Encoded/decoded by serializers as "SPEC".
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_2DlLmWK-EeWR9ZSfjmHwUA")]
    [Description(@"Dividend in addition to the regular dividend being paid by the company.")]
    Special = CorporateActionFrequencyTypeV2Code.Special, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Special Dividend with reinvestment component.
    /// Encoded/decoded by serializers as "SPRE".
    /// </summary>
    [EnumMember(Value = "SPRE")]
    [IsoId("_5TuGoWK-EeWR9ZSfjmHwUA")]
    [Description(@"Special Dividend with reinvestment component.")]
    SpecialDividendWithReinvestment = CorporateActionFrequencyTypeV2Code.SpecialDividendWithReinvestment, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionFrequencyType5CodeMetadataExtensions
{
    private static readonly CorporateActionFrequencyType5CodeDropdownSource _dropdownSource = new CorporateActionFrequencyType5CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionFrequencyType5CodeDropdownRow GetMetadata(this CorporateActionFrequencyType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


