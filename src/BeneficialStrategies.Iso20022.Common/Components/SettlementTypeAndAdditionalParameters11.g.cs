﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementTypeAndAdditionalParameters11.  ISO2002 ID# _nthO8TtAEeWRTLSN0i0tng.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides transaction type and identification information.
/// </summary>
[DataContract]
[XmlType]
public partial record SettlementTypeAndAdditionalParameters11
{
    #nullable enable
    
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [DataMember]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [DataMember]
    public required DeliveryReceiptType2Code Payment { get; init; } 
    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [DataMember]
    public IsoMax35Text? CommonIdentification { get; init; } 
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [DataMember]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Indicates whether the settlement transaction was already sent on the market and that it is only sent by an account owner to an account servicer for reconciliation purposes.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? ReconciliationIndicator { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ClientCollateralInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ClientCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the triparty agent's point of view.
    /// </summary>
    [DataMember]
    public IsoMax35Text? TripartyAgentCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the triparty agent.
    /// </summary>
    [DataMember]
    public IsoMax35Text? TripartyCollateralInstructionIdentification { get; init; } 
    
    #nullable disable
}
