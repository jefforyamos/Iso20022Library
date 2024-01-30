﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AggregateBalanceInformation31.  ISO2002 ID# _IBpiiR5dEeWE3PufGMdJ3w.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Overall position, in a single security, held in a securities account at a specified place of safekeeping.
/// </summary>
public partial record AggregateBalanceInformation31
{
    #nullable enable
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    public FinancialInstrumentAttributes64? FinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    public FinancialInstrument21? InvestmentFundsFinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Details of the swap contract.
    /// </summary>
    public DerivativeBasicAttributes1? AdditionalDerivativeAttributes { get; init; } 
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    public required Balance6 AggregateBalance { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafeKeepingPlace1? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public CorporateActionOption5Code? CorporateActionOptionType { get; init; } 
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    public PriceInformation12? PriceDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    public ForeignExchangeTerms22? ForeignExchangeDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    public IsoNumber? DaysAccrued { get; init; } 
    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    public required BalanceAmounts1 AccountBaseCurrencyAmounts { get; init; } 
    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    public BalanceAmounts1? InstrumentCurrencyAmounts { get; init; } 
    /// <summary>
    /// Valuation amounts provided in another currency than the base currency of the account.
    /// </summary>
    public BalanceAmounts1? AlternateReportingCurrencyAmounts { get; init; } 
    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    public QuantityBreakdown28? QuantityBreakdown { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    public SubBalanceInformation14? BalanceBreakdown { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    public AdditionalBalanceInformation14? AdditionalBalanceBreakdown { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Breakdown of positions per place of safekeeping (and optionally per place of listing).
    /// </summary>
    public AggregateBalancePerSafekeepingPlace29? BalanceAtSafekeepingPlace { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    public IsoMax350Text? HoldingAdditionalDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
