﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalTypeOfPartyCode.  ISO2002 ID# _-MYPFW7iEeKo25nLKvGr8w_-77531611.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external type of party code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MYPFW7iEeKo25nLKvGr8w_-77531611")]
[Description(@"Specifies the external type of party code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalTypeOfPartyCode
{
    /// <summary>
    /// Party advising the undertaking.
    /// </summary>
    [EnumMember(Value = "ADVP")]
    [IsoId("_uQCDGfRYEeuLhpyIdtJzwg")]
    [Description(@"Party advising the undertaking.")]
    ADVP,
    
    /// <summary>
    /// Any bank.
    /// </summary>
    [EnumMember(Value = "ANYB")]
    [IsoId("_uQCDHPRYEeuLhpyIdtJzwg")]
    [Description(@"Any bank.")]
    ANYB,
    
    /// <summary>
    /// Party named in the undertaking as the “applicant”. 
    /// </summary>
    [EnumMember(Value = "APPL")]
    [IsoId("_uQL0EPRYEeuLhpyIdtJzwg")]
    [Description(@"Party named in the undertaking as the “applicant”. ")]
    APPL,
    
    /// <summary>
    /// Party in whose favour the undertaking (or counter-undertaking) is issued.
    /// </summary>
    [EnumMember(Value = "BENE")]
    [IsoId("_uQL0E_RYEeuLhpyIdtJzwg")]
    [Description(@"Party in whose favour the undertaking (or counter-undertaking) is issued.")]
    BENE,
    
    /// <summary>
    /// Party that adds its undertaking to honour the undertaking.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_uQL0FvRYEeuLhpyIdtJzwg")]
    [Description(@"Party that adds its undertaking to honour the undertaking.")]
    CONF,
    
    /// <summary>
    /// Beneficiary of the second counter-undertaking.
    /// </summary>
    [EnumMember(Value = "CUB2")]
    [IsoId("_uQL0GfRYEeuLhpyIdtJzwg")]
    [Description(@"Beneficiary of the second counter-undertaking.")]
    CUB2,
    
    /// <summary>
    /// Beneficiary of the third counter-undertaking.
    /// </summary>
    [EnumMember(Value = "CUB3")]
    [IsoId("_uQL0HPRYEeuLhpyIdtJzwg")]
    [Description(@"Beneficiary of the third counter-undertaking.")]
    CUB3,
    
    /// <summary>
    /// Party that issues the undertaking (or counter-undertaking). 
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_uQU-APRYEeuLhpyIdtJzwg")]
    [Description(@"Party that issues the undertaking (or counter-undertaking). ")]
    ISSU,
    
    /// <summary>
    /// Party obligated to reimburse the issuer. 
    /// </summary>
    [EnumMember(Value = "OBLG")]
    [IsoId("_uQU-A_RYEeuLhpyIdtJzwg")]
    [Description(@"Party obligated to reimburse the issuer. ")]
    OBLG,
    
    /// <summary>
    /// Party requested to issue an undertaking on behalf of the applicant. Also known as the ordering institution or applicant's bank.
    /// </summary>
    [EnumMember(Value = "ORDR")]
    [IsoId("_uQevAPRYEeuLhpyIdtJzwg")]
    [Description(@"Party requested to issue an undertaking on behalf of the applicant. Also known as the ordering institution or applicant's bank.")]
    ORDR,
    
    /// <summary>
    /// Party nominated to receive presentation. 
    /// </summary>
    [EnumMember(Value = "PRES")]
    [IsoId("_uQevA_RYEeuLhpyIdtJzwg")]
    [Description(@"Party nominated to receive presentation. ")]
    PRES,
    
    /// <summary>
    /// Second advising party.
    /// </summary>
    [EnumMember(Value = "SADV")]
    [IsoId("_uQevBvRYEeuLhpyIdtJzwg")]
    [Description(@"Second advising party.")]
    SADV,
    
    /// <summary>
    /// Party located at specified address.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_uQevCfRYEeuLhpyIdtJzwg")]
    [Description(@"Party located at specified address.")]
    SPEC,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalTypeOfPartyCodeMetadataExtensions
{
    private static readonly ExternalTypeOfPartyCodeDropdownSource _dropdownSource = new ExternalTypeOfPartyCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalTypeOfPartyCodeDropdownRow GetMetadata(this ExternalTypeOfPartyCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


