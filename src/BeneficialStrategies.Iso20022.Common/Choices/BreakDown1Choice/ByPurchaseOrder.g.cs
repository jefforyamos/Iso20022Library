﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ByPurchaseOrder.  ISO2002 ID# _2goZwBrYEeOVR9VN6fAMUg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BreakDown1Choice;

/// <summary>
/// The intention to pay is based on a purchase order.
/// </summary>
public partial record ByPurchaseOrder : BreakDown1Choice_
{
    #nullable enable
    /// <summary>
    /// Unique identification of the purchase order, assigned by the buyer.
    /// </summary>
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    /// <summary>
    /// Specifies the adjustments applied to obtain the net amount.
    /// </summary>
    public Adjustment6? Adjustment { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Net amount, after adjustments, intended to be paid.
    /// </summary>
    public required IsoCurrencyAndAmount NetAmount { get; init; } 
    #nullable disable
}
