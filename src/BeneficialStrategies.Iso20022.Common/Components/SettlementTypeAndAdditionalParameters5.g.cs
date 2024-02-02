﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementTypeAndAdditionalParameters5.  ISO2002 ID# _0cExIglIEeGATtfOBToyew_-1928302527.
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
public partial record SettlementTypeAndAdditionalParameters5
{
    #nullable enable
    
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [DataMember]
    public ReceiveDelivery1Code? SecuritiesMovementType { get; init; } 
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [DataMember]
    public DeliveryReceiptType2Code? Payment { get; init; } 
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
    
    #nullable disable
}
