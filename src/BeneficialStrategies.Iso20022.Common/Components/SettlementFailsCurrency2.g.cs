﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementFailsCurrency2.  ISO2002 ID# _antbaR2lEeqF2P5v-Rtejg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details on the settlement fails per currency.
/// </summary>
public partial record SettlementFailsCurrency2
{
    #nullable enable
    
    /// <summary>
    /// Currency of the cash counter value specified in a settlement instruction.
    /// Usage: this is the currency in which the aggregate values have to be reported for the settlement fails per currency.
    /// </summary>
    public required ActiveCurrencyCode Currency { get; init; } 
    /// <summary>
    /// Aggregated data of all settlement transactions per currency.
    /// </summary>
    public required SettlementTotalData1 Data { get; init; } 
    
    #nullable disable
}
