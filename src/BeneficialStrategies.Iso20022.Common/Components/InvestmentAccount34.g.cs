﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccount34.  ISO2002 ID# _svFhIRHBEeKVqeHljBM1MQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
public partial record InvestmentAccount34
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public AccountIdentification1? Identification { get; init; } 
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    public IsoMax35Text? Designation { get; init; } 
    /// <summary>
    /// Purpose of the account/source fund type. This is typically linked to an investment product, for example, wrapper, ISA.
    /// </summary>
    public IAccountType1Choice? Type { get; init; } 
    /// <summary>
    /// Ownership status of the account, for example, joint owners.
    /// </summary>
    public required IOwnershipType1Choice OwnershipType { get; init; } 
    /// <summary>
    /// Tax advantage specific to the account.
    /// </summary>
    public ITaxExemptionReason1Choice? TaxExemption { get; init; } 
    /// <summary>
    /// Frequency at which a statement is issued.
    /// </summary>
    public IStatementFrequencyReason1Choice? StatementFrequency { get; init; } 
    /// <summary>
    /// Currency chosen for reporting purposes by the account owner in agreement with the account servicer.
    /// </summary>
    public ActiveCurrencyCode? ReferenceCurrency { get; init; } 
    /// <summary>
    /// Language for all communication concerning the account.
    /// </summary>
    public LanguageCode? Language { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference1Code? IncomePreference { get; init; } 
    /// <summary>
    /// Method by which the tax (withholding tax) is to be processed i.e. either withheld at source or tax information reported to tax authorities or tax information is reported due to the provision of a tax certificate.
    /// </summary>
    public TaxWithholdingMethod2Code? TaxWithholdingMethod { get; init; } 
    /// <summary>
    /// Details of the letter of intent.
    /// </summary>
    public LetterIntent1? LetterIntentDetails { get; init; } 
    /// <summary>
    /// Reference of an accumulation rights program, in which sales commissions are based on a customer's present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    public IsoMax35Text? AccumulationRightReference { get; init; } 
    /// <summary>
    /// Number of account owners or related parties required to authorise transactions on the account.
    /// </summary>
    public IsoNumber? RequiredSignatoriesNumber { get; init; } 
    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    public IsoMax350Text? FundFamilyName { get; init; } 
    /// <summary>
    /// Detailed information about the investment fund associated to the account.
    /// </summary>
    public FinancialInstrument29? FundDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Parameters to be applied on deal amount for orders when the amount is a fractional number.
    /// </summary>
    public RoundingParameters1? RoundingDetails { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public IPartyIdentification2Choice? AccountServicer { get; init; } 
    /// <summary>
    /// Specifies information about blocked accounts.
    /// </summary>
    public Blocked1? BlockedStatus { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the type of usage of the account.
    /// </summary>
    public IAccountUsageType1Choice? AccountUsageType { get; init; } 
    /// <summary>
    /// Specifies if documentary evidence has been provided for the foreign resident.
    /// </summary>
    public Provided1Code? ForeignStatusCertification { get; init; } 
    /// <summary>
    /// Date the investor signs the open account form.
    /// </summary>
    public IDateAndDateTimeChoice? AccountSignatureDateTime { get; init; } 
    
    #nullable disable
}
