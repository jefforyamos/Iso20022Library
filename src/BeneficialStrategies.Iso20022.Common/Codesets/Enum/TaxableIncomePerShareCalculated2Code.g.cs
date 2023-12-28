﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxableIncomePerShareCalculated2Code.  ISO2002 ID# _ZSSoxNp-Ed-ak6NoX_4Aeg_162652014.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the fund calculates a taxable interest per share (TIS).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZSSoxNp-Ed-ak6NoX_4Aeg_162652014")]
[Description(@"Specifies whether the fund calculates a taxable interest per share (TIS).")]
[DerivedFrom(typeof(TaxableIncomePerShareCalculatedCode))]
public enum TaxableIncomePerShareCalculated2Code
{
    /// <summary>
    /// Fund is calculating the taxable interest per share with the NAV.
    /// Encoded/decoded by serializers as "FundCalculates".
    /// </summary>
    [EnumMember(Value = "TSIY")]
    [IsoId("_ZSSoxdp-Ed-ak6NoX_4Aeg_206054111")]
    [Description(@"Fund is calculating the taxable interest per share with the NAV.")]
    FundCalculates,
    
    /// <summary>
    /// Fund is not calculating the taxable interest per share with the NAV.
    /// Encoded/decoded by serializers as "FundDoesNotCalculate".
    /// </summary>
    [EnumMember(Value = "TSIN")]
    [IsoId("_ZSSoxtp-Ed-ak6NoX_4Aeg_206055154")]
    [Description(@"Fund is not calculating the taxable interest per share with the NAV.")]
    FundDoesNotCalculate,
    
    /// <summary>
    /// Unknown whether the fund is calculating the taxable interest per share with the NAV.
    /// Encoded/decoded by serializers as "FundCalculatesUnknown".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ZSSox9p-Ed-ak6NoX_4Aeg_206055214")]
    [Description(@"Unknown whether the fund is calculating the taxable interest per share with the NAV.")]
    FundCalculatesUnknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxableIncomePerShareCalculated2CodeMetadataExtensions
{
    private static readonly TaxableIncomePerShareCalculated2CodeDropdownSource _dropdownSource = new TaxableIncomePerShareCalculated2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxableIncomePerShareCalculated2CodeDropdownRow GetMetadata(this TaxableIncomePerShareCalculated2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


