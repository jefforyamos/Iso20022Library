﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Repo.  ISO2002 ID# _RZHzSaGGEeSpipW1FBSFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AdjustedBalanceTypeSD3Choice;

/// <summary>
/// Repurchase agreement (REPO) between a seller and a buyer whereby the seller agrees to repurchase the securities at an agreed upon price, and usually at a stated time.
/// </summary>
public partial record Repo : AdjustedBalanceTypeSD3Choice_
{
    #nullable enable
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    public required ShortLong1Code ShortLongPosition { get; init; } 
    /// <summary>
    /// Quantity of security.
    /// </summary>
    public required FinancialInstrumentQuantity15Choice_ Quantity { get; init; } 
    #nullable disable
}
