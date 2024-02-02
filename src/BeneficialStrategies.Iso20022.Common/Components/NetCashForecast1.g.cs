﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NetCashForecast1.  ISO2002 ID# _VB5xptp-Ed-ak6NoX_4Aeg_906159660.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net cash movements to a fund as a result of investment funds transactions.
/// </summary>
[DataContract]
[XmlType]
public partial record NetCashForecast1
{
    #nullable enable
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [DataMember]
    public IsoISODate? SettlementDate { get; init; } 
    /// <summary>
    /// Net amount of the cash flow, expressed as an amount of money.
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; } 
    /// <summary>
    /// Net amount, expressed as a number of units.
    /// </summary>
    [DataMember]
    public FinancialInstrumentQuantity1? NetUnitsNumber { get; init; } 
    /// <summary>
    /// Specifies the direction of the cash flow from the perspective of the fund.
    /// </summary>
    [DataMember]
    public required FlowDirectionType1Code FlowDirection { get; init; } 
    
    #nullable disable
}
