﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionTaxableIncomePerShareCalculatedCode.  ISO2002 ID# _bTVTdNp-Ed-ak6NoX_4Aeg_1953385002.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the fund calculates the taxable income per dividend/taxable income per share (TID/TIS).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bTVTdNp-Ed-ak6NoX_4Aeg_1953385002")]
[Description(@"Specifies whether the fund calculates the taxable income per dividend/taxable income per share (TID/TIS).")]
[Derivations(typeof(CorporateActionTaxableIncomePerShareCalculated1Code))]
public enum CorporateActionTaxableIncomePerShareCalculatedCode
{
    /// <summary>
    /// Fund is calculating the taxable income per dividend/taxable income per share.
    /// Encoded/decoded by serializers as "TDIY".
    /// </summary>
    [EnumMember(Value = "TDIY")]
    [IsoId("_bTVTddp-Ed-ak6NoX_4Aeg_1953385011")]
    [Description(@"Fund is calculating the taxable income per dividend/taxable income per share.")]
    Calculated,
    
    /// <summary>
    /// Fund is not calculating the taxable income per dividend/taxable income per share.
    /// Encoded/decoded by serializers as "TDIN".
    /// </summary>
    [EnumMember(Value = "TDIN")]
    [IsoId("_bTfEcNp-Ed-ak6NoX_4Aeg_1953385027")]
    [Description(@"Fund is not calculating the taxable income per dividend/taxable income per share.")]
    NotCalculated,
    
    /// <summary>
    /// Unknown whether the fund is calculating the taxable income per dividend/taxable income per share.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_bTfEcdp-Ed-ak6NoX_4Aeg_1953385028")]
    [Description(@"Unknown whether the fund is calculating the taxable income per dividend/taxable income per share.")]
    Unknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionTaxableIncomePerShareCalculatedCodeMetadataExtensions
{
    private static readonly CorporateActionTaxableIncomePerShareCalculatedCodeDropdownSource _dropdownSource = new CorporateActionTaxableIncomePerShareCalculatedCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionTaxableIncomePerShareCalculatedCodeDropdownRow GetMetadata(this CorporateActionTaxableIncomePerShareCalculatedCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


