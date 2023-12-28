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
    /// Encoded/decoded by serializers as "ADVP".
    /// </summary>
    [EnumMember(Value = "ADVP")]
    [IsoId("_uQCDGfRYEeuLhpyIdtJzwg")]
    [Description(@"Party advising the undertaking.")]
    AdvisingParty,
    
    /// <summary>
    /// Any bank.
    /// Encoded/decoded by serializers as "ANYB".
    /// </summary>
    [EnumMember(Value = "ANYB")]
    [IsoId("_uQCDHPRYEeuLhpyIdtJzwg")]
    [Description(@"Any bank.")]
    AnyBank,
    
    /// <summary>
    /// Party named in the undertaking as the “applicant”. 
    /// Encoded/decoded by serializers as "APPL".
    /// </summary>
    [EnumMember(Value = "APPL")]
    [IsoId("_uQL0EPRYEeuLhpyIdtJzwg")]
    [Description(@"Party named in the undertaking as the “applicant”. ")]
    Applicant,
    
    /// <summary>
    /// Party in whose favour the undertaking (or counter-undertaking) is issued.
    /// Encoded/decoded by serializers as "BENE".
    /// </summary>
    [EnumMember(Value = "BENE")]
    [IsoId("_uQL0E_RYEeuLhpyIdtJzwg")]
    [Description(@"Party in whose favour the undertaking (or counter-undertaking) is issued.")]
    Beneficiary,
    
    /// <summary>
    /// Party that adds its undertaking to honour the undertaking.
    /// Encoded/decoded by serializers as "CONF".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_uQL0FvRYEeuLhpyIdtJzwg")]
    [Description(@"Party that adds its undertaking to honour the undertaking.")]
    ConfirmationParty,
    
    /// <summary>
    /// Beneficiary of the second counter-undertaking.
    /// Encoded/decoded by serializers as "CUB2".
    /// </summary>
    [EnumMember(Value = "CUB2")]
    [IsoId("_uQL0GfRYEeuLhpyIdtJzwg")]
    [Description(@"Beneficiary of the second counter-undertaking.")]
    SecondCounterUndertakingBeneficiary,
    
    /// <summary>
    /// Beneficiary of the third counter-undertaking.
    /// Encoded/decoded by serializers as "CUB3".
    /// </summary>
    [EnumMember(Value = "CUB3")]
    [IsoId("_uQL0HPRYEeuLhpyIdtJzwg")]
    [Description(@"Beneficiary of the third counter-undertaking.")]
    ThirdCounterUndertakingBeneficiary,
    
    /// <summary>
    /// Party that issues the undertaking (or counter-undertaking). 
    /// Encoded/decoded by serializers as "ISSU".
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_uQU-APRYEeuLhpyIdtJzwg")]
    [Description(@"Party that issues the undertaking (or counter-undertaking). ")]
    Issuer,
    
    /// <summary>
    /// Party obligated to reimburse the issuer. 
    /// Encoded/decoded by serializers as "OBLG".
    /// </summary>
    [EnumMember(Value = "OBLG")]
    [IsoId("_uQU-A_RYEeuLhpyIdtJzwg")]
    [Description(@"Party obligated to reimburse the issuer. ")]
    Obligor,
    
    /// <summary>
    /// Party requested to issue an undertaking on behalf of the applicant. Also known as the ordering institution or applicant's bank.
    /// Encoded/decoded by serializers as "ORDR".
    /// </summary>
    [EnumMember(Value = "ORDR")]
    [IsoId("_uQevAPRYEeuLhpyIdtJzwg")]
    [Description(@"Party requested to issue an undertaking on behalf of the applicant. Also known as the ordering institution or applicant's bank.")]
    OrderingParty,
    
    /// <summary>
    /// Party nominated to receive presentation. 
    /// Encoded/decoded by serializers as "PRES".
    /// </summary>
    [EnumMember(Value = "PRES")]
    [IsoId("_uQevA_RYEeuLhpyIdtJzwg")]
    [Description(@"Party nominated to receive presentation. ")]
    PresentingParty,
    
    /// <summary>
    /// Second advising party.
    /// Encoded/decoded by serializers as "SADV".
    /// </summary>
    [EnumMember(Value = "SADV")]
    [IsoId("_uQevBvRYEeuLhpyIdtJzwg")]
    [Description(@"Second advising party.")]
    SecondAdvisingParty,
    
    /// <summary>
    /// Party located at specified address.
    /// Encoded/decoded by serializers as "SPEC".
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_uQevCfRYEeuLhpyIdtJzwg")]
    [Description(@"Party located at specified address.")]
    SpecifiedAddress,
    
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


