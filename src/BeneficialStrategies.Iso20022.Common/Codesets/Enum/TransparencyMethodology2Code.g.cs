﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransparencyMethodology2Code.  ISO2002 ID# _EjDNwHvuEeanCNPcMT7sSg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the methodology used for a transparency operation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EjDNwHvuEeanCNPcMT7sSg")]
[Description(@"Specifies the methodology used for a transparency operation.")]
[DerivedFrom(typeof(TransparencyMethodologyCode))]
public enum TransparencyMethodology2Code
{
    /// <summary>
    /// Calculation based on yearly cycle.
    /// Encoded/decoded by serializers as "Year".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_IUk-oXvuEeanCNPcMT7sSg")]
    [Description(@"Calculation based on yearly cycle.")]
    Year,
    
    /// <summary>
    /// Results of calculations supporting Systematic Internaliser regime.
    /// Encoded/decoded by serializers as "SystematicInternaliser".
    /// </summary>
    [EnumMember(Value = "SINT")]
    [IsoId("_IYpmUXvuEeanCNPcMT7sSg")]
    [Description(@"Results of calculations supporting Systematic Internaliser regime.")]
    SystematicInternaliser,
    
    /// <summary>
    /// Calculation based on first Four Weeks of Trading for Equity Instruments.
    /// Encoded/decoded by serializers as "FirstFourWeeks".
    /// </summary>
    [EnumMember(Value = "FFWK")]
    [IsoId("_IcsY0XvuEeanCNPcMT7sSg")]
    [Description(@"Calculation based on first Four Weeks of Trading for Equity Instruments.")]
    FirstFourWeeks,
    
    /// <summary>
    /// Estimation for New Equity Instruments.
    /// Encoded/decoded by serializers as "Estimated".
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_IgesoXvuEeanCNPcMT7sSg")]
    [Description(@"Estimation for New Equity Instruments.")]
    Estimated,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransparencyMethodology2CodeMetadataExtensions
{
    private static readonly TransparencyMethodology2CodeDropdownSource _dropdownSource = new TransparencyMethodology2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransparencyMethodology2CodeDropdownRow GetMetadata(this TransparencyMethodology2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


