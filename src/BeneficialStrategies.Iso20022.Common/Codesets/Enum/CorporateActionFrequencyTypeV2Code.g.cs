﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionFrequencyTypeV2Code.  ISO2002 ID# _OR5utiXeEeO8J8_akw9vuw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Frequency of the cash distribution.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OR5utiXeEeO8J8_akw9vuw")]
[Description(@"Frequency of the cash distribution.")]
public enum CorporateActionFrequencyTypeV2Code
{
    /// <summary>
    /// Payment of a dividend, less amounts already paid through interim dividends.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_OR5uuCXeEeO8J8_akw9vuw")]
    [Description(@"Payment of a dividend, less amounts already paid through interim dividends.")]
    FINL,
    
    /// <summary>
    /// Dividend declared and paid before annual earnings have been determined.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_OR5utyXeEeO8J8_akw9vuw")]
    [Description(@"Dividend declared and paid before annual earnings have been determined.")]
    INTE,
    
    /// <summary>
    /// Dividend paid at regular interval, for example, quarterly.
    /// </summary>
    [EnumMember(Value = "REGR")]
    [IsoId("_OR5uuSXeEeO8J8_akw9vuw")]
    [Description(@"Dividend paid at regular interval, for example, quarterly.")]
    REGR,
    
    /// <summary>
    /// Dividend in addition to the regular dividend being paid by the company.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_OR5uuiXeEeO8J8_akw9vuw")]
    [Description(@"Dividend in addition to the regular dividend being paid by the company.")]
    SPEC,
    
    /// <summary>
    /// Reinvestment of cash distributed.
    /// </summary>
    [EnumMember(Value = "REIN")]
    [IsoId("_OR5uuyXeEeO8J8_akw9vuw")]
    [Description(@"Reinvestment of cash distributed.")]
    REIN,
    
    /// <summary>
    /// Special Dividend with reinvestment component.
    /// </summary>
    [EnumMember(Value = "SPRE")]
    [IsoId("_N5sKsaFUEeSK_vfd3NHBGg")]
    [Description(@"Special Dividend with reinvestment component.")]
    SPRE,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionFrequencyTypeV2CodeMetadataExtensions
{
    private static readonly CorporateActionFrequencyTypeV2CodeDropdownSource _dropdownSource = new CorporateActionFrequencyTypeV2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionFrequencyTypeV2CodeDropdownRow GetMetadata(this CorporateActionFrequencyTypeV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


