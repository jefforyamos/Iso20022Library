﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountParties16.  ISO2002 ID# _GmcvUUzPEeafiMTDrtSnyw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a party's account.
/// </summary>
public partial record AccountParties16
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    public IAccountParties11Choice? PrincipalAccountParty { get; init; } 
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    public InvestmentAccountOwnershipInformation15? SecondaryOwner { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    public InvestmentAccountOwnershipInformation15? Beneficiary { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    public InvestmentAccountOwnershipInformation15? PowerOfAttorney { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    public InvestmentAccountOwnershipInformation15? LegalGuardian { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    public InvestmentAccountOwnershipInformation15? CustodianForMinor { get; init; } 
    /// <summary>
    /// Deceased's estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    // public IReadOnlyCollection<InvestmentAccountOwnershipInformation15> SuccessorOnDeath { get; init; }
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    public InvestmentAccountOwnershipInformation15? Administrator { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Other type of party.
    /// </summary>
    public ExtendedParty12? OtherParty { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    // public IReadOnlyCollection<InvestmentAccountOwnershipInformation15> Granter { get; init; }
    /// <summary>
    /// Entity that creates a trust or contributes assets to the trust.
    /// </summary>
    // public IReadOnlyCollection<InvestmentAccountOwnershipInformation15> Settlor { get; init; }
    /// <summary>
    /// Party that makes, or participates in the making of, decisions that affect the whole, or a substantial part, of the business of a customer of a reporting entity or that has the capacity to affect significantly the financial standing of a customer of a reporting entity. Typically, this is a controlling person of a corporate (ownership type CORP).
    /// </summary>
    public InvestmentAccountOwnershipInformation15? SeniorManagingOfficial { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Person appointed under the trust instrument to direct or restrain the trustees in relation to their administration of the trust. Typically, this is a controlling person of a trust (ownership type TRUS) or other non-individual organisation (ownership type ONIS).
    /// </summary>
    public InvestmentAccountOwnershipInformation15? Protector { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Party for which shares are to be registered.
    /// </summary>
    public IRegisteredShareholderName1Choice? RegisteredShareholderName { get; init; } 
    
    #nullable disable
}
