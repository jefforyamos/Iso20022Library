﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeliveringPartiesAndAccount9.  ISO2002 ID# _K_E78R6fEeOolf0-cMYhrw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
[DataContract]
[XmlType]
public partial record DeliveringPartiesAndAccount9
{
    #nullable enable
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [DataMember]
    public InvestmentAccount41? DelivererDetails { get; init; } 
    /// <summary>
    /// Party that acts on behalf of the seller of securities when the seller does not have a direct relationship with the delivering agent.
    /// </summary>
    [DataMember]
    public PartyIdentificationAndAccount5? DeliverersCustodianDetails { get; init; } 
    /// <summary>
    /// Party that the deliverer's custodian uses to effect the delivery of a security, when the deliverer's custodian does not have a direct relationship with the delivering agent.
    /// </summary>
    [DataMember]
    public PartyIdentificationAndAccount5? DeliverersIntermediaryDetails { get; init; } 
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, eg, central securities depository.
    /// </summary>
    [DataMember]
    public required PartyIdentificationAndAccount4 DeliveringAgentDetails { get; init; } 
    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    [DataMember]
    public IsoMax35Text? SecuritiesSettlementSystem { get; init; } 
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [DataMember]
    public PartyIdentification21? PlaceOfSettlementDetails { get; init; } 
    
    #nullable disable
}
