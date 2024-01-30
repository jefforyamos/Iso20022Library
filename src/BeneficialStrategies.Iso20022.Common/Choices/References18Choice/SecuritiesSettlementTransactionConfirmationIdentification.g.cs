﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesSettlementTransactionConfirmationIdentification.  ISO2002 ID# _9EijIz9mEeCuVfEpWlZb5g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References18Choice;

/// <summary>
/// Unambiguous identification of the confirmation to be cancelled.
/// </summary>
public partial record SecuritiesSettlementTransactionConfirmationIdentification : IReferences18Choice
{
    #nullable enable
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    public required IsoMax35Text TransactionIdentification { get; init; } 
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    public required DeliveryReceiptType2Code Payment { get; init; } 
    #nullable disable
}
