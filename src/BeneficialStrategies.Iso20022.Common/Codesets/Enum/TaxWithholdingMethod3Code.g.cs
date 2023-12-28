﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxWithholdingMethod3Code.  ISO2002 ID# _nyrU8L-IEeWfsa741pI6WA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the method by which the tax on the interests is to be processed i.e. either withheld at source or reported to tax authorities or a tax certificate has been provided by the beneficiary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nyrU8L-IEeWfsa741pI6WA")]
[Description(@"Specifies the method by which the tax on the interests is to be processed i.e. either withheld at source or reported to tax authorities or a tax certificate has been provided by the beneficiary.")]
[DerivedFrom(typeof(TaxWithholdingMethodCode))]
public enum TaxWithholdingMethod3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MinorityInterestTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rHlbQb-IEeWfsa741pI6WA")]
    [Description(@"??")]
    MinorityInterestTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvestmentCompany".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_sBdCgb-IEeWfsa741pI6WA")]
    [Description(@"??")]
    InvestmentCompany,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Accountant".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_shvsIb-IEeWfsa741pI6WA")]
    [Description(@"??")]
    Accountant,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Exempt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tfyBsb-IEeWfsa741pI6WA")]
    [Description(@"??")]
    Exempt,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReportTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_y3UHEb-IEeWfsa741pI6WA")]
    [Description(@"??")]
    ReportTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxCertificate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_y_WBsb-IEeWfsa741pI6WA")]
    [Description(@"??")]
    TaxCertificate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WithholdingCorporateTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zLZgsb-IEeWfsa741pI6WA")]
    [Description(@"??")]
    WithholdingCorporateTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WithholdTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zSr0cb-IEeWfsa741pI6WA")]
    [Description(@"??")]
    WithholdTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WithholdTaxAndReport".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zauWIL-IEeWfsa741pI6WA")]
    [Description(@"??")]
    WithholdTaxAndReport,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxWithholdingMethod3CodeMetadataExtensions
{
    private static readonly TaxWithholdingMethod3CodeDropdownSource _dropdownSource = new TaxWithholdingMethod3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxWithholdingMethod3CodeDropdownRow GetMetadata(this TaxWithholdingMethod3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

