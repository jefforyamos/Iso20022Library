﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalTypeOfParty1Code.  ISO2002 ID# _-MYPFG7iEeKo25nLKvGr8w_227763993.
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
[IsoId("_-MYPFG7iEeKo25nLKvGr8w_227763993")]
[Description(@"Specifies the external type of party code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalTypeOfPartyCode))]
public enum ExternalTypeOfParty1Code
{
    /// <summary>
    /// Party advising the undertaking.
    /// Encoded/decoded by serializers as "AdvisingParty".
    /// </summary>
    [EnumMember(Value = "ADVP")]
    [IsoId("_uQCDG_RYEeuLhpyIdtJzwg")]
    [Description(@"Party advising the undertaking.")]
    AdvisingParty,
    
    /// <summary>
    /// Any bank.
    /// Encoded/decoded by serializers as "AnyBank".
    /// </summary>
    [EnumMember(Value = "ANYB")]
    [IsoId("_uQCDHvRYEeuLhpyIdtJzwg")]
    [Description(@"Any bank.")]
    AnyBank,
    
    /// <summary>
    /// Party named in the undertaking as the “applicant”. 
    /// Encoded/decoded by serializers as "Applicant".
    /// </summary>
    [EnumMember(Value = "APPL")]
    [IsoId("_uQL0EvRYEeuLhpyIdtJzwg")]
    [Description(@"Party named in the undertaking as the “applicant”. ")]
    Applicant,
    
    /// <summary>
    /// Party in whose favour the undertaking (or counter-undertaking) is issued.
    /// Encoded/decoded by serializers as "Beneficiary".
    /// </summary>
    [EnumMember(Value = "BENE")]
    [IsoId("_uQL0FfRYEeuLhpyIdtJzwg")]
    [Description(@"Party in whose favour the undertaking (or counter-undertaking) is issued.")]
    Beneficiary,
    
    /// <summary>
    /// Party that adds its undertaking to honour the undertaking.
    /// Encoded/decoded by serializers as "ConfirmationParty".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_uQL0GPRYEeuLhpyIdtJzwg")]
    [Description(@"Party that adds its undertaking to honour the undertaking.")]
    ConfirmationParty,
    
    /// <summary>
    /// Beneficiary of the second counter-undertaking.
    /// Encoded/decoded by serializers as "SecondCounterUndertakingBeneficiary".
    /// </summary>
    [EnumMember(Value = "CUB2")]
    [IsoId("_uQL0G_RYEeuLhpyIdtJzwg")]
    [Description(@"Beneficiary of the second counter-undertaking.")]
    SecondCounterUndertakingBeneficiary,
    
    /// <summary>
    /// Beneficiary of the third counter-undertaking.
    /// Encoded/decoded by serializers as "ThirdCounterUndertakingBeneficiary".
    /// </summary>
    [EnumMember(Value = "CUB3")]
    [IsoId("_uQL0HvRYEeuLhpyIdtJzwg")]
    [Description(@"Beneficiary of the third counter-undertaking.")]
    ThirdCounterUndertakingBeneficiary,
    
    /// <summary>
    /// Party that issues the undertaking (or counter-undertaking). 
    /// Encoded/decoded by serializers as "Issuer".
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_uQU-AvRYEeuLhpyIdtJzwg")]
    [Description(@"Party that issues the undertaking (or counter-undertaking). ")]
    Issuer,
    
    /// <summary>
    /// Party obligated to reimburse the issuer. 
    /// Encoded/decoded by serializers as "Obligor".
    /// </summary>
    [EnumMember(Value = "OBLG")]
    [IsoId("_uQU-BfRYEeuLhpyIdtJzwg")]
    [Description(@"Party obligated to reimburse the issuer. ")]
    Obligor,
    
    /// <summary>
    /// Party requested to issue an undertaking on behalf of the applicant. Also known as the ordering institution or applicant's bank.
    /// Encoded/decoded by serializers as "OrderingParty".
    /// </summary>
    [EnumMember(Value = "ORDR")]
    [IsoId("_uQevAvRYEeuLhpyIdtJzwg")]
    [Description(@"Party requested to issue an undertaking on behalf of the applicant. Also known as the ordering institution or applicant's bank.")]
    OrderingParty,
    
    /// <summary>
    /// Party nominated to receive presentation. 
    /// Encoded/decoded by serializers as "PresentingParty".
    /// </summary>
    [EnumMember(Value = "PRES")]
    [IsoId("_uQevBfRYEeuLhpyIdtJzwg")]
    [Description(@"Party nominated to receive presentation. ")]
    PresentingParty,
    
    /// <summary>
    /// Second advising party.
    /// Encoded/decoded by serializers as "SecondAdvisingParty".
    /// </summary>
    [EnumMember(Value = "SADV")]
    [IsoId("_uQevCPRYEeuLhpyIdtJzwg")]
    [Description(@"Second advising party.")]
    SecondAdvisingParty,
    
    /// <summary>
    /// Party located at specified address.
    /// Encoded/decoded by serializers as "SpecifiedAddress".
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_uQevC_RYEeuLhpyIdtJzwg")]
    [Description(@"Party located at specified address.")]
    SpecifiedAddress,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalTypeOfParty1CodeMetadataExtensions
{
    private static readonly ExternalTypeOfParty1CodeDropdownSource _dropdownSource = new ExternalTypeOfParty1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalTypeOfParty1CodeDropdownRow GetMetadata(this ExternalTypeOfParty1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


