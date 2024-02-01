﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ByCommercialInvoice.  ISO2002 ID# _6n8NYBrYEeOVR9VN6fAMUg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BreakDown1Choice;

/// <summary>
/// The intention to pay is based on a commercial invoice.
/// </summary>
public partial record ByCommercialInvoice : BreakDown1Choice_
{
    #nullable enable
    /// <summary>
    /// Reference to the identification of the underlying commercial document.
    /// </summary>
    public required InvoiceIdentification1 CommercialDocumentReference { get; init; } 
    /// <summary>
    /// Specifies the adjustments applied to obtain the net amount.
    /// </summary>
    public Adjustment6? Adjustment { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Net amount, after adjustments, intended to be paid.
    /// </summary>
    public required IsoCurrencyAndAmount NetAmount { get; init; } 
    /// <summary>
    /// Specifies how the net amount to be paid is related to different purchase orders.
    /// </summary>
    public ReportLine7? BreakdownByPurchaseOrder { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
