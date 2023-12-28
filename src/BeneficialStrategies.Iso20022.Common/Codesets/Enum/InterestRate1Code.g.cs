﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InterestRate1Code.  ISO2002 ID# _FENyMDErEemzCpWiCwK4aQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the list of interest rates.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FENyMDErEemzCpWiCwK4aQ")]
[Description(@"Contains the list of interest rates.")]
[DerivedFrom(typeof(InterestRateCode))]
public enum InterestRate1Code
{
    /// <summary>
    /// Gross interest rate of the instalment
    /// Encoded/decoded by serializers as "GrossRate".
    /// </summary>
    [EnumMember(Value = "GSRT")]
    [IsoId("_RBUdYTErEemzCpWiCwK4aQ")]
    [Description(@"Gross interest rate of the instalment")]
    GrossRate,
    
    /// <summary>
    /// Net interest rate of the instalment
    /// Encoded/decoded by serializers as "NetRate".
    /// </summary>
    [EnumMember(Value = "NTRT")]
    [IsoId("_RW7hATErEemzCpWiCwK4aQ")]
    [Description(@"Net interest rate of the instalment")]
    NetRate,
    
    /// <summary>
    /// Other interest rate of the instalment
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_RrpMwTErEemzCpWiCwK4aQ")]
    [Description(@"Other interest rate of the instalment")]
    OtherNational,
    
    /// <summary>
    /// Other interest rate of the instalment
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_R9-S4TErEemzCpWiCwK4aQ")]
    [Description(@"Other interest rate of the instalment")]
    OtherPrivate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InterestRate1CodeMetadataExtensions
{
    private static readonly InterestRate1CodeDropdownSource _dropdownSource = new InterestRate1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInterestRate1CodeDropdownRow GetMetadata(this InterestRate1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


