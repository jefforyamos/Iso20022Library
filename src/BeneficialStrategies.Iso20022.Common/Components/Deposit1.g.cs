﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Deposit1.  ISO2002 ID# _-hi44LJUEeaYqc4G3TTwhA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money placed at a deposit taking institution.
/// </summary>
[DataContract]
[XmlType]
public partial record Deposit1
{
    #nullable enable
    
    /// <summary>
    /// Date on which the deposit matures.
    /// </summary>
    [DataMember]
    public required IsoISODate MaturityDate { get; init; } 
    /// <summary>
    /// Specifies the value of the deposit.
    /// </summary>
    [DataMember]
    public required IsoActiveCurrencyAndAmount Value { get; init; } 
    /// <summary>
    /// Identifies the legal entity that takes the deposit.
    /// </summary>
    [DataMember]
    public required IsoLEIIdentifier CounterpartyIdentification { get; init; } 
    
    #nullable disable
}
