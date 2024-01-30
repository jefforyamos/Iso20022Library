﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReceivingPartiesAndAccount1.  ISO2002 ID# _VP5xZ9p-Ed-ak6NoX_4Aeg_2096007708.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
public partial record ReceivingPartiesAndAccount1
{
    #nullable enable
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    public required InvestmentAccount11 ReceiverDetails { get; init; } 
    /// <summary>
    /// Party that acts on behalf of the buyer of securities when the buyer does not have a direct relationship with the receiving agent.
    /// </summary>
    public PartyIdentificationAndAccount2? ReceiversCustodianDetails { get; init; } 
    /// <summary>
    /// Party that the Receiver's custodian uses to effect the receipt of a security, when the Receiver's custodian does not have a direct relationship with the Receiver agent.
    /// </summary>
    public PartyIdentificationAndAccount2? ReceiversIntermediaryDetails { get; init; } 
    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, eg, securities central depository.
    /// </summary>
    public required PartyIdentificationAndAccount2 ReceivingAgentDetails { get; init; } 
    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    public IsoMax35Text? SecuritiesSettlementSystem { get; init; } 
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    public required PartyIdentificationAndAccount2 PlaceOfSettlementDetails { get; init; } 
    
    #nullable disable
}
