﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionFrequencyType3Code.  ISO2002 ID# _r1AnQCXeEeO4bIO_HtGo9Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Automatic Reinvestment of Cash distributed by accumulating funds.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_r1AnQCXeEeO4bIO_HtGo9Q")]
[Description(@"Automatic Reinvestment of Cash distributed by accumulating funds.")]
[DerivedFrom(typeof(CorporateActionFrequencyTypeV2Code))]
public enum CorporateActionFrequencyType3Code
{
    /// <summary>
    /// Payment of a dividend, less amounts already paid through interim dividends.
    /// Encoded/decoded by serializers as "Final".
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_FXLZ8SXfEeO4bIO_HtGo9Q")]
    [Description(@"Payment of a dividend, less amounts already paid through interim dividends.")]
    Final,
    
    /// <summary>
    /// Dividend declared and paid before annual earnings have been determined.
    /// Encoded/decoded by serializers as "Interim".
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_FeT8sSXfEeO4bIO_HtGo9Q")]
    [Description(@"Dividend declared and paid before annual earnings have been determined.")]
    Interim,
    
    /// <summary>
    /// Reinvestment of cash distributed.
    /// Encoded/decoded by serializers as "Reinvestment".
    /// </summary>
    [EnumMember(Value = "REIN")]
    [IsoId("_FmDjcSXfEeO4bIO_HtGo9Q")]
    [Description(@"Reinvestment of cash distributed.")]
    Reinvestment,
    
    /// <summary>
    /// Dividend paid at regular interval, for example, quarterly.
    /// Encoded/decoded by serializers as "Regular".
    /// </summary>
    [EnumMember(Value = "REGR")]
    [IsoId("_Fu-18SXfEeO4bIO_HtGo9Q")]
    [Description(@"Dividend paid at regular interval, for example, quarterly.")]
    Regular,
    
    /// <summary>
    /// Dividend in addition to the regular dividend being paid by the company.
    /// Encoded/decoded by serializers as "Special".
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_F2t1oSXfEeO4bIO_HtGo9Q")]
    [Description(@"Dividend in addition to the regular dividend being paid by the company.")]
    Special,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionFrequencyType3CodeMetadataExtensions
{
    private static readonly CorporateActionFrequencyType3CodeDropdownSource _dropdownSource = new CorporateActionFrequencyType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionFrequencyType3CodeDropdownRow GetMetadata(this CorporateActionFrequencyType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


