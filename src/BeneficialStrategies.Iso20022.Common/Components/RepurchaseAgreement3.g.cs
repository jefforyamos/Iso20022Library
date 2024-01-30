﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RepurchaseAgreement3.  ISO2002 ID# _aOU-QbcREeabfchHYoktpA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Agreement between two parties to sell a financial instrument or set of financial instruments and repurchase such instruments at an agreed future date.
/// </summary>
public partial record RepurchaseAgreement3
{
    #nullable enable
    
    /// <summary>
    /// Specifies attributes of a derivative based on Final ISDA Taxonomy v1.0 and Final ISDA Taxonomy v2.0.
    /// </summary>
    public required ProductClassification1 ProductClassification { get; init; } 
    /// <summary>
    /// Indicates whether the repo is a general collateral repo or specific repo.
    /// </summary>
    public required IRepurchaseAgreementType1Choice RepurchaseAgreementType { get; init; } 
    /// <summary>
    /// Identifier for triparty agent if applicable.
    /// </summary>
    public IsoLEIIdentifier? TripartyAgent { get; init; } 
    
    #nullable disable
}
