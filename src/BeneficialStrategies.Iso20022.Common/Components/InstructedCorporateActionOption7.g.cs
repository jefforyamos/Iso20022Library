﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructedCorporateActionOption7.  ISO2002 ID# _cfsrwZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides corporate action option details about total instructed balance.
/// </summary>
[DataContract]
[XmlType]
public partial record InstructedCorporateActionOption7
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [DataMember]
    public IsoExact3NumericText? OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [DataMember]
    public required CorporateActionOption23Choice_ OptionType { get; init; } 
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [DataMember]
    public required BalanceFormat7Choice_ InstructedBalance { get; init; } 
    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    [DataMember]
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; } 
    /// <summary>
    /// Any deadline chosen by the account servicer (service level agreement).
    /// </summary>
    [DataMember]
    public required IsoISODateTime DeadlineDateTime { get; init; } 
    /// <summary>
    /// Specifies the type of deadline for instructing.
    /// </summary>
    [DataMember]
    public required DeadlineCode4Choice_ DeadlineType { get; init; } 
    
    #nullable disable
}
