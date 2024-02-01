﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccount29.  ISO2002 ID# _RxbfZ9p-Ed-ak6NoX_4Aeg_-2016735960.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
public partial record InvestmentAccount29
{
    #nullable enable
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    public IsoMax35Text? Designation { get; init; } 
    /// <summary>
    /// Legal form of the fund, eg, UCITS, SICAV, OEIC, Unit Trust, and FCP.
    /// </summary>
    public IsoMax35Text? FundType { get; init; } 
    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    public IsoMax350Text? FundFamilyName { get; init; } 
    /// <summary>
    /// Detailed information about the investment fund associated to the account.
    /// </summary>
    public FinancialInstrument10? SecurityDetails { get; init; } 
    /// <summary>
    /// Identification of an individual person whom legally owns the account.
    /// </summary>
    public IndividualPersonIdentificationChoice_? IndividualOwnerIdentification { get; init; } 
    /// <summary>
    /// Identification of an organisation that legally owns the account.
    /// </summary>
    public PartyIdentification5Choice_? OrganisationOwnerIdentification { get; init; } 
    /// <summary>
    /// Party that provides services relating to financial products to investors, eg, advice on products and placement of orders for the investment fund.
    /// </summary>
    public Intermediary7[] Intermediary { get; init; } = [];
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public PartyIdentification2Choice_? AccountServicer { get; init; } 
    
    #nullable disable
}
