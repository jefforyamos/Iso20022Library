﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountParties14.  ISO2002 ID# _M3J_wSCBEeWhHbfCMWc1cw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a party's account.
/// </summary>
public partial record AccountParties14
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    public IAccountParties9Choice? PrincipalAccountParty { get; init; } 
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    public InvestmentAccountOwnershipInformation13? SecondaryOwner { get; init; } 
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    public InvestmentAccountOwnershipInformation13? Beneficiary { get; init; } 
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    public InvestmentAccountOwnershipInformation13? PowerOfAttorney { get; init; } 
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    public InvestmentAccountOwnershipInformation13? LegalGuardian { get; init; } 
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    public InvestmentAccountOwnershipInformation13? CustodianForMinor { get; init; } 
    /// <summary>
    /// Deceased's estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    public InvestmentAccountOwnershipInformation13? SuccessorOnDeath { get; init; } 
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    public InvestmentAccountOwnershipInformation13? Administrator { get; init; } 
    /// <summary>
    /// An other type of party.
    /// </summary>
    public ExtendedParty10? OtherParty { get; init; } 
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    public InvestmentAccountOwnershipInformation13? Granter { get; init; } 
    /// <summary>
    /// Entity that creates a trust or contributes assets to the trust.
    /// </summary>
    public InvestmentAccountOwnershipInformation13? Settlor { get; init; } 
    /// <summary>
    /// Party for which shares are to be registered.
    /// </summary>
    public IRegisteredShareholderName1Choice? RegisteredShareholderName { get; init; } 
    
    #nullable disable
}
