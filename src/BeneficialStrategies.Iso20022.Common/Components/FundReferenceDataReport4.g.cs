﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FundReferenceDataReport4.  ISO2002 ID# _XBCccc0SEeuAE-cYsQdwHQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fund reference data.
/// </summary>
public partial record FundReferenceDataReport4
{
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a report within a fund reference data report, as assigned by the issuer of the report.
    /// </summary>
    public IsoMax35Text? Identification { get; init; } 
    /// <summary>
    /// Version Number. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00001 and is the version of the template for which the EMT data is provided.
    /// </summary>
    public MarketPracticeVersion1? Version { get; init; } 
    /// <summary>
    /// Party that reports the data on behalf of the issuer and the entry point e-mail address for contact. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) references 00002, 00003 and 00004.
    /// </summary>
    public ContactAttributes6? AuthorisedProxy { get; init; } 
    /// <summary>
    /// Date to which the data refers. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00050. 
    /// </summary>
    public required IsoISODate GeneralReferenceDate { get; init; } 
    /// <summary>
    /// Indicates whether target market data is included in the report. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00006.
    /// </summary>
    public IsoYesNoIndicator? TargetMarketIndicator { get; init; } 
    /// <summary>
    /// Indicates whether ex ante costs and charges are included in the report. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00007.
    /// </summary>
    public IsoYesNoIndicator? ExAnteIndicator { get; init; } 
    /// <summary>
    /// Indicates whether ex post costs and charges are included in the report. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00008.
    /// </summary>
    public IsoYesNoIndicator? ExPostIndicator { get; init; } 
    /// <summary>
    /// Identification of the security.
    /// </summary>
    public required SecurityIdentification41 SecurityIdentification { get; init; } 
    /// <summary>
    /// Parties related to the investment fund.
    /// </summary>
    public FundParties1? FundParties { get; init; } 
    /// <summary>
    /// Principal entity appointed by the fund, to which orders should be submitted. Usually located in the country of domicile.
    /// </summary>
    public OrderDesk1? MainFundOrderDesk { get; init; } 
    /// <summary>
    /// Company that is responsible for the management and operation of the fund, for example, determines the investment strategy, appoints the service providers, and makes major decisions for the fund. It is usually responsible for the distribution and marketing of the fund. For self-managed funds, this will often be a separate promoter or sponsor of the fund.
    /// </summary>
    public ContactAttributes5? FundManagementCompany { get; init; } 
    /// <summary>
    /// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
    /// </summary>
    public FinancialInstrument96? FundDetails { get; init; } 
    /// <summary>
    /// Processing characteristics linked to the instrument, that is, not to the market.
    /// </summary>
    public ValuationDealingProcessingCharacteristics3? ValuationDealingCharacteristics { get; init; } 
    /// <summary>
    /// Investment restrictions linked to the trading of the investment fund or an alternative/hedge fund.
    /// </summary>
    public InvestmentRestrictions3? InvestmentRestrictions { get; init; } 
    /// <summary>
    /// Processing characteristics linked to a subscription to the investment fund or alternative/hedge fund.
    /// </summary>
    public ProcessingCharacteristics8? SubscriptionProcessingCharacteristics { get; init; } 
    /// <summary>
    /// Processing characteristics linked to a redemption from the investment fund or alternative/hedge fund.
    /// </summary>
    public ProcessingCharacteristics7? RedemptionProcessingCharacteristics { get; init; } 
    /// <summary>
    /// Processing characteristics linked to a switch of the investment fund or alternative/hedge fund.
    /// </summary>
    public ProcessingCharacteristics6? SwitchProcessingCharacteristics { get; init; } 
    /// <summary>
    /// Characteristics of the investment plan.
    /// </summary>
    public InvestmentPlanCharacteristics1? PlanCharacteristics { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies, for a specific type of transaction, how amounts are to be paid in or paid out.
    /// </summary>
    public PaymentInstrument16? PaymentInstrument { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Account to be used for cash settlement.
    /// </summary>
    public CashAccount205? CashSettlementDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Processing characteristics specific to a local fund order desk.
    /// </summary>
    public LocalMarketAnnex5? LocalMarketAnnex { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Target market criteria.
    /// </summary>
    public TargetMarket3? TargetMarket { get; init; } 
    /// <summary>
    /// Distribution strategy criteria.
    /// </summary>
    public DistributionStrategy1? DistributionStrategy { get; init; } 
    /// <summary>
    /// Costs and charges associated with the distribution of selling of the financial instrument. These may be one-off or recurring. These may be ex ante (intended) or post ante (actual).
    /// </summary>
    // public IReadOnlyCollection<CostsAndCharges2> CostsAndCharges { get; init; }
    /// <summary>
    /// Additional information required for distribution in the German market.
    /// </summary>
    public AdditionalProductInformation1? AdditionalProductInformationGermanMarket { get; init; } 
    /// <summary>
    /// Additional information required for distribution in the French market.
    /// </summary>
    public AdditionalProductInformation2? AdditionalProductInformationFrenchMarket { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public Extension1? Extension { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
