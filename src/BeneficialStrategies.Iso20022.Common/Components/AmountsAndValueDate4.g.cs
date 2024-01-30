﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountsAndValueDate4.  ISO2002 ID# _TImtuNp-Ed-ak6NoX_4Aeg_993174808.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the value date and the amounts traded in a foreign exchange option trade.
/// </summary>
public partial record AmountsAndValueDate4
{
    #nullable enable
    
    /// <summary>
    /// Call amount and currency of a foreign exchange option trade.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount CallAmount { get; init; } 
    /// <summary>
    /// Put amount and currency of a foreign exchange option trade.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount PutAmount { get; init; } 
    /// <summary>
    /// The single settlement currency for the payment made by the seller to the buyer if the option is exercised in case of a Non Deliverable Option.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? OptionSettlementCurrency { get; init; } 
    /// <summary>
    /// Date on which the trade is settled, ie, the amounts are due.
    /// </summary>
    public required IsoISODate FinalSettlementDate { get; init; } 
    
    #nullable disable
}
