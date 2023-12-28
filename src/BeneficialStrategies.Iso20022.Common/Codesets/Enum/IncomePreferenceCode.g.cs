﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for IncomePreferenceCode.  ISO2002 ID# _aWGPIdp-Ed-ak6NoX_4Aeg_-1985616336.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the options for distribution of dividend income.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aWGPIdp-Ed-ak6NoX_4Aeg_-1985616336")]
[Description(@"Specifies the options for distribution of dividend income.")]
[Derivations(typeof(IncomePreference1Code),typeof(IncomePreference2Code))]
// External derivations that should be provided by the proper interface are: 
public enum IncomePreferenceCode
{
    /// <summary>
    /// Distribution in cash.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_aWGPItp-Ed-ak6NoX_4Aeg_-238756116")]
    [Description(@"Distribution in cash.")]
    Cash,
    
    /// <summary>
    /// Reinvestment of proceeds into securities.
    /// Encoded/decoded by serializers as "DRIP".
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_aWGPI9p-Ed-ak6NoX_4Aeg_-226750448")]
    [Description(@"Reinvestment of proceeds into securities.")]
    DividendReinvestment,
    
    /// <summary>
    /// Distribution in securities.
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_fJyswCFJEeWgV9SQSyaAog")]
    [Description(@"Distribution in securities.")]
    Securities,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class IncomePreferenceCodeMetadataExtensions
{
    private static readonly IncomePreferenceCodeDropdownSource _dropdownSource = new IncomePreferenceCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IIncomePreferenceCodeDropdownRow GetMetadata(this IncomePreferenceCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


