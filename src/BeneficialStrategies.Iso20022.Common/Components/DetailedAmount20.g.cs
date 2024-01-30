﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedAmount20.  ISO2002 ID# _1juMQUS7EeiTBYbU3rWV0A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of the transaction amount.
/// </summary>
public partial record DetailedAmount20
{
    #nullable enable
    
    /// <summary>
    /// Type or class of amount.
    /// </summary>
    public required DetailAmount2Code Type { get; init; } 
    /// <summary>
    /// Additional information to specify the type of amount.
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    /// <summary>
    /// Amount of one occurrence of the breakdown amount.
    /// </summary>
    public required Amount5 Amount { get; init; } 
    /// <summary>
    /// Short description of the detailed amount.
    /// </summary>
    public IsoMax70Text? Label { get; init; } 
    
    #nullable disable
}
