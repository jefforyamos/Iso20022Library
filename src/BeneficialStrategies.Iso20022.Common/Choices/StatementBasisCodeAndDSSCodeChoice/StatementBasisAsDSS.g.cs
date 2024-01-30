﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for StatementBasisAsDSS.  ISO2002 ID# _Q7Cp8tp-Ed-ak6NoX_4Aeg_-1630736025.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.StatementBasisCodeAndDSSCodeChoice;

/// <summary>
/// Statement basis expressed as a data source scheme and a code used within the data source scheme.
/// </summary>
public partial record StatementBasisAsDSS : IStatementBasisCodeAndDSSCodeChoice
{
    #nullable enable
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public required IsoMax8Text Issuer { get; init; } 
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    public required IsoMax35Text Information { get; init; } 
    #nullable disable
}
