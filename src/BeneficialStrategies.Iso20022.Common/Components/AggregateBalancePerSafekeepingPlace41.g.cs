﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AggregateBalancePerSafekeepingPlace41.  ISO2002 ID# _csbI-Ti8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding, in a single security, within the overall position held in a securities account at a specified place of safekeeping.
/// </summary>
public partial record AggregateBalancePerSafekeepingPlace41
{
    #nullable enable
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public required SafeKeepingPlace4 SafekeepingPlace { get; init; } 
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    public IMarketIdentification4Choice? PlaceOfListing { get; init; } 
    /// <summary>
    /// Entity to which the financial instruments are pledged.
    /// </summary>
    public Pledgee4? Pledgee { get; init; } 
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    public required Balance22 AggregateBalance { get; init; } 
    /// <summary>
    /// Total quantity of financial instruments of the balance that is available.
    /// </summary>
    public Balance25? AvailableBalance { get; init; } 
    /// <summary>
    /// Total quantity of financial instruments of the balance that is not available.
    /// </summary>
    public IBalanceQuantity17Choice? NotAvailableBalance { get; init; } 
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    public PriceInformation22? PriceDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    public ForeignExchangeTerms35? ForeignExchangeDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    public IsoNumber? DaysAccrued { get; init; } 
    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    public BalanceAmounts4? AccountBaseCurrencyAmounts { get; init; } 
    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    public BalanceAmounts4? InstrumentCurrencyAmounts { get; init; } 
    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    public QuantityBreakdown71? QuantityBreakdown { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    public IExposureType24Choice? ExposureType { get; init; } 
    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    public SubBalanceInformation24? BalanceBreakdown { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    public AdditionalBalanceInformation24? AdditionalBalanceBreakdown { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    public IsoRestrictedFINXMax350Text? HoldingAdditionalDetails { get; init; } 
    
    #nullable disable
}
