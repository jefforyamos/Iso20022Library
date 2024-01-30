﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesAccountReport.  ISO2002 ID# _t8qdseGEEeWCAvUNsZ5u6g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountOrOperationalError2Choice;

/// <summary>
/// Report information about securities account reference data.
/// </summary>
public partial record SecuritiesAccountReport : ISecuritiesAccountOrOperationalError2Choice
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required SecuritiesAccount19 SecuritiesAccountIdentification { get; init; } 
    /// <summary>
    /// Identifies the returned securities account reference data or error information.
    /// </summary>
    public required ISecuritiesAccountOrBusinessError2Choice SecuritiesAccountOrError { get; init; } 
    #nullable disable
}
