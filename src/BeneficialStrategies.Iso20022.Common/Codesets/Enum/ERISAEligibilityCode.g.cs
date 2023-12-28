﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ERISAEligibilityCode.  ISO2002 ID# _ah3aQNp-Ed-ak6NoX_4Aeg_-672768404.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies information about ERISA (Eligibility to federal Employee Retirement Income Security Act) eligibility.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ah3aQNp-Ed-ak6NoX_4Aeg_-672768404")]
[Description(@"Specifies information about ERISA (Eligibility to federal Employee Retirement Income Security Act) eligibility.")]
[Derivations(typeof(ERISAEligibility1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ERISAEligibilityCode
{
    /// <summary>
    /// Investor is subject to an ERISA declaration.
    /// Encoded/decoded by serializers as "ELIG".
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_ah3aQdp-Ed-ak6NoX_4Aeg_-672768064")]
    [Description(@"Investor is subject to an ERISA declaration.")]
    ERISAEligible,
    
    /// <summary>
    /// Investment is not subject to an ERISA declaration.
    /// Encoded/decoded by serializers as "NELI".
    /// </summary>
    [EnumMember(Value = "NELI")]
    [IsoId("_ah3aQtp-Ed-ak6NoX_4Aeg_-672768034")]
    [Description(@"Investment is not subject to an ERISA declaration.")]
    NotERISAEligible,
    
    /// <summary>
    /// Eligibility is unknown at the time the order is sent, and the instructing party will confirm later.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ah3aQ9p-Ed-ak6NoX_4Aeg_-672768003")]
    [Description(@"Eligibility is unknown at the time the order is sent, and the instructing party will confirm later.")]
    ERISAEligibilityUnknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ERISAEligibilityCodeMetadataExtensions
{
    private static readonly ERISAEligibilityCodeDropdownSource _dropdownSource = new ERISAEligibilityCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IERISAEligibilityCodeDropdownRow GetMetadata(this ERISAEligibilityCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


