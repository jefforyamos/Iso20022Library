﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GovernanceIdentification1Code.  ISO2002 ID# _QbWgMHycEeGWJuGCfvwOsQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the identification of the rules and laws governing the undertaking.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QbWgMHycEeGWJuGCfvwOsQ")]
[Description(@"Specifies the identification of the rules and laws governing the undertaking.")]
[DerivedFrom(typeof(GovernanceIdentificationCode))]
public enum GovernanceIdentification1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InternationalStandbyPractices".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_buUCNnycEeGWJuGCfvwOsQ")]
    [Description(@"??")]
    InternationalStandbyPractices,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "None".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_djAS9nycEeGWJuGCfvwOsQ")]
    [Description(@"??")]
    None,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UniformCustomsAndPractice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dtcBVnycEeGWJuGCfvwOsQ")]
    [Description(@"??")]
    UniformCustomsAndPractice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UniformRulesForDemandGuarantees".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_d1VZFnycEeGWJuGCfvwOsQ")]
    [Description(@"??")]
    UniformRulesForDemandGuarantees,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GovernanceIdentification1CodeMetadataExtensions
{
    private static readonly GovernanceIdentification1CodeDropdownSource _dropdownSource = new GovernanceIdentification1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGovernanceIdentification1CodeDropdownRow GetMetadata(this GovernanceIdentification1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


