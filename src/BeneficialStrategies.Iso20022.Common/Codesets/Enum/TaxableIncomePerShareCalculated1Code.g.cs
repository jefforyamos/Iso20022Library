﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxableIncomePerShareCalculated1Code.  ISO2002 ID# _VlEJE9p-Ed-ak6NoX_4Aeg_1966959880.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the fund calculates a taxable interest per share (TIS).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VlEJE9p-Ed-ak6NoX_4Aeg_1966959880")]
[Description(@"Specifies whether the fund calculates a taxable interest per share (TIS).")]
[DerivedFrom(typeof(TaxableIncomePerShareCalculatedCode))]
public enum TaxableIncomePerShareCalculated1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FundCalculates".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VlEJFNp-Ed-ak6NoX_4Aeg_-1901338896")]
    [Description(@"??")]
    FundCalculates,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FundDoesNotCalculate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VlEJFdp-Ed-ak6NoX_4Aeg_-1901338871")]
    [Description(@"??")]
    FundDoesNotCalculate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FundCalculatesUnknown".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VlEJFtp-Ed-ak6NoX_4Aeg_-1901338854")]
    [Description(@"??")]
    FundCalculatesUnknown,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VlEJF9p-Ed-ak6NoX_4Aeg_-721697044")]
    [Description(@"??")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxableIncomePerShareCalculated1CodeMetadataExtensions
{
    private static readonly TaxableIncomePerShareCalculated1CodeDropdownSource _dropdownSource = new TaxableIncomePerShareCalculated1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxableIncomePerShareCalculated1CodeDropdownRow GetMetadata(this TaxableIncomePerShareCalculated1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


