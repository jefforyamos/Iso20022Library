﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementParties120.  ISO2002 ID# _Box6QQN1Ee2-vqzwMUAewg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides a settlement party by a choice between a BIC or a name and address or a party identification.
/// </summary>
public partial record SettlementParties120
{
    #nullable enable
    
    /// <summary>
    /// Financial institution from which cash will be transferred.
    /// </summary>
    public PartyIdentification242Choice_? DeliveryAgent { get; init; } 
    /// <summary>
    /// Party, within the settlement chain, between the delivery and receiving agents.
    /// </summary>
    public PartyIdentification242Choice_? Intermediary { get; init; } 
    /// <summary>
    /// Financial institution where the payee will receive the funds.
    /// </summary>
    public required PartyIdentification242Choice_ ReceivingAgent { get; init; } 
    /// <summary>
    /// Ultimate institution that will receive the funds when different from the trading or counterparty side.
    /// </summary>
    public PartyIdentification242Choice_? BeneficiaryInstitution { get; init; } 
    
    #nullable disable
}
