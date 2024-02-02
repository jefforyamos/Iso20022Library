﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentDetails37.  ISO2002 ID# _s9lpdgVVEeqjd8n6wD9JVw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reporting per financial instrument.
/// </summary>
[DataContract]
[XmlType]
public partial record FinancialInstrumentDetails37
{
    #nullable enable
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [DataMember]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    [DataMember]
    public FinancialInstrument76? InvestmentFundsFinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Information regarding the price of the instrument.
    /// </summary>
    [DataMember]
    public PriceInformation24? PriceDetails { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [DataMember]
    public SafeKeepingPlace4? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    [DataMember]
    public OpeningBalance4? OpeningBalance { get; init; } 
    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    [DataMember]
    public ClosingBalance4? ClosingBalance { get; init; } 
    /// <summary>
    /// Transaction details.
    /// </summary>
    [DataMember]
    public ValueList<Transaction113> Transaction { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
