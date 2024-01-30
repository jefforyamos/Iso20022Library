﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccount63.  ISO2002 ID# _H4ah8UzZEea8fovz_9xSTQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a securities account and its characteristics.
/// </summary>
public partial record InvestmentAccount63
{
    #nullable enable
    
    /// <summary>
    /// Change of account status is instructed.
    /// </summary>
    public AccountStatusUpdateInstruction1? AccountStatusUpdateInstruction { get; init; } 
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    public IsoMax35Text? Designation { get; init; } 
    /// <summary>
    /// Type of account.
    /// </summary>
    public IAccountType2Choice? Type { get; init; } 
    /// <summary>
    /// Ownership status of the account, for example, joint owners.
    /// </summary>
    public IOwnershipType2Choice? OwnershipType { get; init; } 
    /// <summary>
    /// Tax advantage specific to the account.
    /// </summary>
    public ITaxExemptionReason2Choice? TaxExemption { get; init; } 
    /// <summary>
    /// Frequency at which a statement is issued.
    /// </summary>
    public IStatementFrequencyReason2Choice? StatementFrequency { get; init; } 
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
    public IncomePreference2Code? IncomePreference { get; init; } 
    /// <summary>
    /// Specifies, for income on the fund or security that is to be reinvested, parameters for the reinvestment. If the reinvestment percentage is less than one hundred percent, the remaining percentage will be invested according to the investor’s or account owner's subsequent instructions.
    /// </summary>
    public Reinvestment3? ReinvestmentDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Method by which the tax (withholding tax) is to be processed, that is, either withheld at source or tax information is reported to tax authorities or tax information is reported due to the provision of a tax certificate.
    /// </summary>
    public TaxWithholdingMethod3Code? TaxWithholdingMethod { get; init; } 
    /// <summary>
    /// Details for the reporting of tax, for example, the country of taxation.
    /// </summary>
    public TaxReporting2? TaxReporting { get; init;  } // Warning: Don't know multiplicity.
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
    /// Detailed information about the financial instrument associated to the account that is to be modified or deleted.
    /// </summary>
    public ModificationScope36? ModifiedFinancialInstrumentDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Parameters to be applied on deal amount for orders when the amount is a fractional number.
    /// </summary>
    public RoundingParameters1? RoundingDetails { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public IPartyIdentification70Choice? AccountServicer { get; init; } 
    /// <summary>
    /// Specifies the account is blocked and other factors for the blocked account.
    /// </summary>
    public IBlockedStatusReason2Choice? BlockedStatus { get; init; } 
    /// <summary>
    /// Specifies the type of usage of the account.
    /// </summary>
    public IAccountUsageType2Choice? AccountUsageType { get; init; } 
    /// <summary>
    /// Specifies if documentary evidence has been provided for the foreign resident.
    /// </summary>
    public Provided1Code? ForeignStatusCertification { get; init; } 
    /// <summary>
    /// Date the investor or account owner signs the open account form.
    /// </summary>
    public IDateAndDateTimeChoice? AccountSignatureDateTime { get; init; } 
    /// <summary>
    /// Means by which the investor or account owner submits the open account form.
    /// </summary>
    public ITransactionChannelType1Choice? TransactionChannelType { get; init; } 
    /// <summary>
    /// Specifies the category of the account.
    /// </summary>
    public IInvestmentAccountCategory1Choice? InvestmentAccountCategory { get; init; } 
    /// <summary>
    /// Specifies whether the holdings in the account are eligible for pledging.
    /// </summary>
    public Eligible1Code? Pledging { get; init; } 
    /// <summary>
    /// Specifies whether the holdings in the account are used as collateral.
    /// </summary>
    public Collateral1Code? Collateral { get; init; } 
    /// <summary>
    /// Details of third party rights.
    /// </summary>
    public ThirdPartyRights1? ThirdPartyRights { get; init; } 
    /// <summary>
    /// Functionality permitted to a third party in the actions that may be taken on an account on behalf of the investor.
    /// </summary>
    public ILevelOfControl1Choice? PowerOfAttorneyLevelOfControl { get; init; } 
    /// <summary>
    /// Specifies if the account is regarded as domestic or non-domestic for reporting purposes.
    /// </summary>
    public IAccountingStatus1Choice? AccountingStatus { get; init; } 
    /// <summary>
    /// Legal opening date for the account.
    /// </summary>
    public IDateAndDateTimeChoice? OpeningDate { get; init; } 
    /// <summary>
    /// Legal closing date for the account.
    /// </summary>
    public IDateAndDateTimeChoice? ClosingDate { get; init; } 
    /// <summary>
    /// Indicates whether the account can hold a negative position in a security.
    /// </summary>
    public IsoYesNoIndicator? NegativeIndicator { get; init; } 
    /// <summary>
    /// Order in which securities are moved from the account.
    /// </summary>
    public PositionEffect3Code? ProcessingOrder { get; init; } 
    /// <summary>
    /// Specifies whether the investor assumes responsibility for the liability.
    /// </summary>
    public ILiability1Choice? Liability { get; init; } 
    /// <summary>
    /// Information related to the investor profile to be inserted, updated or deleted.
    /// </summary>
    public ModificationScope32? ModifiedInvestorProfile { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Fiscal year, when not the same as the calendar year.
    /// </summary>
    public IFiscalYear1Choice? FiscalYear { get; init; } 
    
    #nullable disable
}
