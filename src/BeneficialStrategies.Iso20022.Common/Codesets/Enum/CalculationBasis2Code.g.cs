﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CalculationBasis2Code.  ISO2002 ID# _bVR0NNp-Ed-ak6NoX_4Aeg_-1828402497.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the calculation basis.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bVR0NNp-Ed-ak6NoX_4Aeg_-1828402497")]
[Description(@"Specifies the calculation basis.")]
[DerivedFrom(typeof(CalculationBasisCode))]
public enum CalculationBasis2Code
{
    /// <summary>
    /// Average basis.
    /// Encoded/decoded by serializers as "AVER".
    /// </summary>
    [EnumMember(Value = "AVER")]
    [IsoId("_bVR0Ndp-Ed-ak6NoX_4Aeg_-1779457837")]
    [Description(@"Average basis.")]
    Average = CalculationBasisCode.Average, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Daily basis.
    /// Encoded/decoded by serializers as "DAIL".
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_bVR0Ntp-Ed-ak6NoX_4Aeg_-1779457820")]
    [Description(@"Daily basis.")]
    Daily = CalculationBasisCode.Daily, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Monthly basis.
    /// Encoded/decoded by serializers as "MNTH".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_bVR0N9p-Ed-ak6NoX_4Aeg_1334046994")]
    [Description(@"Monthly basis.")]
    Monthly = CalculationBasisCode.Monthly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Yearly basis.
    /// Encoded/decoded by serializers as "YEAR".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_bVR0ONp-Ed-ak6NoX_4Aeg_1334047012")]
    [Description(@"Yearly basis.")]
    Annual = CalculationBasisCode.Annual, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CalculationBasis2CodeMetadataExtensions
{
    private static readonly CalculationBasis2CodeDropdownSource _dropdownSource = new CalculationBasis2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICalculationBasis2CodeDropdownRow GetMetadata(this CalculationBasis2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


