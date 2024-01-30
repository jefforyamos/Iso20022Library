﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RecurrentQuery.  ISO2002 ID# _noAwE2E3Ee2S65ml6YCOtA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TradeReportQuery16Choice;

/// <summary>
/// Query criteria specifically applied to recurrent queries.
/// </summary>
public partial record RecurrentQuery : ITradeReportQuery16Choice
{
    #nullable enable
    /// <summary>
    /// Defines the type of recurrent query which is requested.
    /// </summary>
    public required IsoMax1000Text QueryType { get; init; } 
    /// <summary>
    /// Defines the requested frequency of the recurrent query.
    /// </summary>
    public required TradeQueryExecutionFrequency3 Frequency { get; init; } 
    /// <summary>
    /// Defines the date until which the query will be executed.
    /// </summary>
    public required IsoISODate ValidUntil { get; init; } 
    #nullable disable
}
