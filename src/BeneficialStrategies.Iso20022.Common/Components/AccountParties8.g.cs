﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountParties8.  ISO2002 ID# _Pa5soRRPEeOKWo1NF21OVw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party related to an investment account.
/// </summary>
public partial record AccountParties8
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    public IAccountParties3Choice? PrincipalAccountParty { get; init; } 
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    public InvestmentAccountOwnershipInformation8? SecondaryOwner { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    public InvestmentAccountOwnershipInformation8? Beneficiary { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    public InvestmentAccountOwnershipInformation8? PowerOfAttorney { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    public InvestmentAccountOwnershipInformation8? LegalGuardian { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Deceased's estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    public InvestmentAccountOwnershipInformation8? SuccessorOnDeath { get; init; } 
    /// <summary>
    /// Entity that has been appointed by a legal authorithy to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    public InvestmentAccountOwnershipInformation8? Administrator { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// An other type of party.
    /// </summary>
    public ExtendedParty5? OtherParty { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    public IReadOnlyCollection<InvestmentAccountOwnershipInformation8> Granter { get; init; } = [];
    /// <summary>
    /// Settler role in the hedge funds industry.
    /// </summary>
    public IReadOnlyCollection<InvestmentAccountOwnershipInformation8> Settler { get; init; } = [];
    
    #nullable disable
}
