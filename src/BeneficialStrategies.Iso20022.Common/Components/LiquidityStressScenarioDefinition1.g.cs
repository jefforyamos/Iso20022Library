﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LiquidityStressScenarioDefinition1.  ISO2002 ID# _ERnlwLDDEeaSl6vJk5Bd8w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes and information that describe a scenario used to test whether a legal entity or other financial construct has sufficient liquid resources to meet its obligations as they arise.
/// </summary>
[DataContract]
[XmlType]
public partial record LiquidityStressScenarioDefinition1
{
    #nullable enable
    
    /// <summary>
    /// CCP’s internal unique identifier of the stress scenario that generates the reported liquidity need.
    /// </summary>
    [DataMember]
    public required GenericIdentification168 Identification { get; init; } 
    /// <summary>
    /// Details of the method and assumptions used for estimating operational outflows.
    /// </summary>
    [DataMember]
    public required IsoMax2000Text Description { get; init; } 
    /// <summary>
    /// CCP’s internal classification of stress scenario type.
    /// </summary>
    [DataMember]
    public IsoMax35Text? Type { get; init; } 
    /// <summary>
    /// Stress currency, or if aggregate, report ‘XLL’.
    /// </summary>
    [DataMember]
    public required ActiveCurrencyCode StressCurrency { get; init; } 
    
    #nullable disable
}
