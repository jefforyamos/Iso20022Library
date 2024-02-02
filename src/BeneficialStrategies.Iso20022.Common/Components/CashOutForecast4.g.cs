﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashOutForecast4.  ISO2002 ID# _Ski-Ztp-Ed-ak6NoX_4Aeg_1757732027.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash movements out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
/// </summary>
[DataContract]
[XmlType]
public partial record CashOutForecast4
{
    #nullable enable
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [DataMember]
    public required IsoISODate CashSettlementDate { get; init; } 
    /// <summary>
    /// Sub-total amount of the cash flow out, expressed as an amount of money.
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAndAmount? SubTotalAmount { get; init; } 
    /// <summary>
    /// Sub-total amount of the cash flow out, expressed as a number of units.
    /// </summary>
    [DataMember]
    public FinancialInstrumentQuantity1? SubTotalUnitsNumber { get; init; } 
    /// <summary>
    /// Indicates whether the cash flow out is exceptional.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? ExceptionalCashFlowIndicator { get; init; } 
    
    #nullable disable
}
