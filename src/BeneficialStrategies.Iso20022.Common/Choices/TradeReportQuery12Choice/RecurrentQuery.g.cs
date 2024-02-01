﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RecurrentQuery.  ISO2002 ID# _QG7io65pEeuo-IflVgGqiA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReportQuery12Choice;

/// <summary>
/// Query criteria specifically applied to recurrent queries.
/// </summary>
public partial record RecurrentQuery : TradeReportQuery12Choice_
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
