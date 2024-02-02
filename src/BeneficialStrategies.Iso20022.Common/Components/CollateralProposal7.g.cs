﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralProposal7.  ISO2002 ID# _7_-OXyqREeyR9JrVGfaMKw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the proposal for the variation margin and optionally the segregated independent amount.
/// </summary>
[DataContract]
[XmlType]
public partial record CollateralProposal7
{
    #nullable enable
    
    /// <summary>
    /// Provides details about the proposal for the variation margin.
    /// </summary>
    [DataMember]
    public required CollateralMovement12 VariationMargin { get; init; } 
    /// <summary>
    /// Provides details about the proposal for the segregated independent amount.
    /// </summary>
    [DataMember]
    public CollateralMovement12? SegregatedIndependentAmount { get; init; } 
    
    #nullable disable
}
