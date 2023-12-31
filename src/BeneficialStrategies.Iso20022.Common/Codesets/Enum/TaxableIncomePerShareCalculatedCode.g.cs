﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxableIncomePerShareCalculatedCode.  ISO2002 ID# _ZSSoyNp-Ed-ak6NoX_4Aeg_1980815659.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the fund calculates a taxable interest per share (TIS).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZSSoyNp-Ed-ak6NoX_4Aeg_1980815659")]
[Description(@"Specifies whether the fund calculates a taxable interest per share (TIS).")]
[Derivations(typeof(TaxableIncomePerShareCalculated1Code),typeof(TaxableIncomePerShareCalculated2Code))]
// External derivations that should be provided by the proper interface are: 
public enum TaxableIncomePerShareCalculatedCode
{
    /// <summary>
    /// Fund is calculating the taxable interest per share with the NAV.
    /// Encoded/decoded by serializers as "TSIY".
    /// </summary>
    [EnumMember(Value = "TSIY")]
    [IsoId("_ZScZwNp-Ed-ak6NoX_4Aeg_2020526873")]
    [Description(@"Fund is calculating the taxable interest per share with the NAV.")]
    FundCalculates,
    
    /// <summary>
    /// Fund is not calculating the taxable interest per share with the NAV.
    /// Encoded/decoded by serializers as "TSIN".
    /// </summary>
    [EnumMember(Value = "TSIN")]
    [IsoId("_ZScZwdp-Ed-ak6NoX_4Aeg_-2002003074")]
    [Description(@"Fund is not calculating the taxable interest per share with the NAV.")]
    FundDoesNotCalculate,
    
    /// <summary>
    /// Unknown whether the fund is calculating the taxable interest per share with the NAV.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ZScZwtp-Ed-ak6NoX_4Aeg_-1971525361")]
    [Description(@"Unknown whether the fund is calculating the taxable interest per share with the NAV.")]
    FundCalculatesUnknown,
    
    /// <summary>
    /// Another type of taxable income per share.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZScZw9p-Ed-ak6NoX_4Aeg_-779877625")]
    [Description(@"Another type of taxable income per share.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxableIncomePerShareCalculatedCodeMetadataExtensions
{
    private static readonly TaxableIncomePerShareCalculatedCodeDropdownSource _dropdownSource = new TaxableIncomePerShareCalculatedCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxableIncomePerShareCalculatedCodeDropdownRow GetMetadata(this TaxableIncomePerShareCalculatedCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


