﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RiskAssessment1.  ISO2002 ID# _3jBj0EbOEeeIjf8aP9KbJA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates to the card issuer the level of risk associated with the transaction.
/// </summary>
public partial record RiskAssessment1
{
    #nullable enable
    
    /// <summary>
    /// Entity providing an intermediate result of a risk assessment process.
    /// </summary>
    public PartyIdentification200? RiskAssessmentEntity { get; init; } 
    /// <summary>
    /// Type of risk assessment.
    /// </summary>
    public IsoMax35Text? RiskAssessmentType { get; init; } 
    /// <summary>
    /// Reason for indicating a certain level of risk for the transaction.
    /// </summary>
    public IsoMax35Text[] Reason { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Risk assessment result.
    /// </summary>
    public IsoMax35Text? Result { get; init; } 
    /// <summary>
    /// Additional risk data associated with the transaction.
    /// </summary>
    public AdditionalRiskData1[] AdditionalRiskData { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Recommended action based on risk assessment.
    /// </summary>
    public ActionType8Code[] RecommendedAction { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Other recommended action based on risk assessment defined at national or private level.
    /// </summary>
    public IsoMax35Text? OtherRecommendedAction { get; init; } 
    /// <summary>
    /// Additional details of recommended action or other recommended action. 
    /// </summary>
    public IsoMax256Text? RecommendedActionDetails { get; init; } 
    
    #nullable disable
}
