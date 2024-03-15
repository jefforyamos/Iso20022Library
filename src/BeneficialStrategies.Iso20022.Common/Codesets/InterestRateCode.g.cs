﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InterestRateCode.  ISO2002 ID# _QDfYd9uSEei2qvU6FBLZYA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    /// Encoded/decoded by serializers as &quot;GSRT&quot;.
    /// </summary>
    [EnumMember(Value = "GSRT")]
    [IsoId("_QDf_gduSEei2qvU6FBLZYA")]
    [Description(@"Gross interest rate of the instalment")]
    GrossRate,
    
    /// <summary>
    /// Net interest rate of the instalment
    /// Encoded/decoded by serializers as &quot;NTRT&quot;.
    /// </summary>
    [EnumMember(Value = "NTRT")]
    [IsoId("_QDf_gNuSEei2qvU6FBLZYA")]
    [Description(@"Net interest rate of the instalment")]
    NetRate,
    
    /// <summary>
    /// Other interest rate of the instalment
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_QDf_gtuSEei2qvU6FBLZYA")]
    [Description(@"Other interest rate of the instalment")]
    OtherNational,
    
    /// <summary>
    /// Other interest rate of the instalment
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_QDf_hduSEei2qvU6FBLZYA")]
    [Description(@"Other interest rate of the instalment")]
    OtherPrivate,
    
}
