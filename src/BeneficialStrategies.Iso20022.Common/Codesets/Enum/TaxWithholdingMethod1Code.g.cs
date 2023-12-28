﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxWithholdingMethod1Code.  ISO2002 ID# _YlcJ0Np-Ed-ak6NoX_4Aeg_1746600246.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specified the method by which the tax on the interests is to be processed i.e. either withheld at source or reported to tax authorities or a tax certificate has been provided by the beneficiary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YlcJ0Np-Ed-ak6NoX_4Aeg_1746600246")]
[Description(@"Specified the method by which the tax on the interests is to be processed i.e. either withheld at source or reported to tax authorities or a tax certificate has been provided by the beneficiary.")]
[DerivedFrom(typeof(TaxWithholdingMethodCode))]
public enum TaxWithholdingMethod1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WithholdTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YlcJ0dp-Ed-ak6NoX_4Aeg_403829980")]
    [Description(@"??")]
    WithholdTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReportTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YlcJ0tp-Ed-ak6NoX_4Aeg_403830040")]
    [Description(@"??")]
    ReportTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxCertificate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YlcJ09p-Ed-ak6NoX_4Aeg_403830075")]
    [Description(@"??")]
    TaxCertificate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WithholdTaxAndReport".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YlcJ1Np-Ed-ak6NoX_4Aeg_403830117")]
    [Description(@"??")]
    WithholdTaxAndReport,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxWithholdingMethod1CodeMetadataExtensions
{
    private static readonly TaxWithholdingMethod1CodeDropdownSource _dropdownSource = new TaxWithholdingMethod1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxWithholdingMethod1CodeDropdownRow GetMetadata(this TaxWithholdingMethod1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


