﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountParties13.  ISO2002 ID# _GY8mMSCBEeWhHbfCMWc1cw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a party's account.
/// </summary>
public partial record AccountParties13
{
    #nullable enable
    
    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    public required IAccountParties8Choice PrincipalAccountParty { get; init; } 
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    public InvestmentAccountOwnershipInformation12? SecondaryOwner { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    public InvestmentAccountOwnershipInformation12? Beneficiary { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    public InvestmentAccountOwnershipInformation12? PowerOfAttorney { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    public InvestmentAccountOwnershipInformation12? LegalGuardian { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    public InvestmentAccountOwnershipInformation12? CustodianForMinor { get; init; } 
    /// <summary>
    /// Deceased's estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    // public IReadOnlyCollection<InvestmentAccountOwnershipInformation12> SuccessorOnDeath { get; init; }
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    public InvestmentAccountOwnershipInformation12? Administrator { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Other type of party.
    /// </summary>
    public ExtendedParty9? OtherParty { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    // public IReadOnlyCollection<InvestmentAccountOwnershipInformation12> Granter { get; init; }
    /// <summary>
    /// Entity that creates a trust or contributes assets to the trust.
    /// </summary>
    // public IReadOnlyCollection<InvestmentAccountOwnershipInformation12> Settlor { get; init; }
    /// <summary>
    /// Party that registers its name with the issuer and the name used for the registration.
    /// </summary>
    public IRegisteredShareholderName1Choice? RegisteredShareholderName { get; init; } 
    
    #nullable disable
}
