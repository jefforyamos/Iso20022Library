﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InterestRateCode.  ISO2002 ID# _QDfYd9uSEei2qvU6FBLZYA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the list of interest rates.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QDfYd9uSEei2qvU6FBLZYA")]
[Description(@"Contains the list of interest rates.")]
[Derivations(typeof(InterestRate1Code))]
public enum InterestRateCode
{
    /// <summary>
    /// Gross interest rate of the instalment
    /// Encoded/decoded by serializers as "GSRT".
    /// </summary>
    [EnumMember(Value = "GSRT")]
    [IsoId("_QDf_gduSEei2qvU6FBLZYA")]
    [Description(@"Gross interest rate of the instalment")]
    GrossRate,
    
    /// <summary>
    /// Net interest rate of the instalment
    /// Encoded/decoded by serializers as "NTRT".
    /// </summary>
    [EnumMember(Value = "NTRT")]
    [IsoId("_QDf_gNuSEei2qvU6FBLZYA")]
    [Description(@"Net interest rate of the instalment")]
    NetRate,
    
    /// <summary>
    /// Other interest rate of the instalment
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_QDf_gtuSEei2qvU6FBLZYA")]
    [Description(@"Other interest rate of the instalment")]
    OtherNational,
    
    /// <summary>
    /// Other interest rate of the instalment
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_QDf_hduSEei2qvU6FBLZYA")]
    [Description(@"Other interest rate of the instalment")]
    OtherPrivate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InterestRateCodeMetadataExtensions
{
    private static readonly InterestRateCodeDropdownSource _dropdownSource = new InterestRateCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInterestRateCodeDropdownRow GetMetadata(this InterestRateCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


