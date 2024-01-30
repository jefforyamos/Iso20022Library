﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccount56.  ISO2002 ID# _BSzRMSSyEeWEdM0tuoNJdg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
public partial record InvestmentAccount56
{
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public IPartyIdentification70Choice? OwnerIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required IsoMax35Text AccountIdentification { get; init; } 
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    public IsoMax35Text? AccountName { get; init; } 
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    public IsoMax35Text? AccountDesignation { get; init; } 
    /// <summary>
    /// Party that provides services relating to financial products to investors, for example, advice on products and placement of orders for the investment fund.
    /// </summary>
    public Intermediary34? IntermediaryInformation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Form, that is, ownership, of the security, that is, registered or bearer.
    /// </summary>
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    /// <summary>
    /// Indicates whether a security exists only as an electronic record, that is, there is no physical document representing the security.
    /// </summary>
    public IsoYesNoIndicator? DematerialisedIndicator { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference2Code? IncomePreference { get; init; } 
    /// <summary>
    /// Beneficial owner or its designated agent certifies that it complies with any holding or investment restrictions or requirements of the fund.
    /// </summary>
    public BeneficiaryCertificationCompletion1Code? BeneficiaryCertificationCompletion { get; init; } 
    /// <summary>
    /// Place requested as the place of safekeeping.
    /// </summary>
    public ISafekeepingPlaceFormat8Choice? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    public IPartyIdentification70Choice? AccountServicer { get; init; } 
    /// <summary>
    /// Sub-accounts that are grouped in a master or omnibus account.
    /// </summary>
    public SubAccount5? SubAccountDetails { get; init; } 
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    public ReceivingPartiesAndAccount14? SettlementPartiesDetails { get; init; } 
    
    #nullable disable
}
