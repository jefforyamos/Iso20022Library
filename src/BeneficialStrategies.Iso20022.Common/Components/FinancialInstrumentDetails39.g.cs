﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentDetails39.  ISO2002 ID# _2xktOyAeEeuyDZ-ukt4YRg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reporting per financial instrument.
/// </summary>
public partial record FinancialInstrumentDetails39
{
    #nullable enable
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    public FinancialInstrument76? InvestmentFundsFinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Information regarding the price of the instrument.
    /// </summary>
    public PriceInformation24? PriceDetails { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafeKeepingPlace4? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    public OpeningBalance4? OpeningBalance { get; init; } 
    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    public ClosingBalance4? ClosingBalance { get; init; } 
    /// <summary>
    /// Transaction details.
    /// </summary>
    public Transaction119? Transaction { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
