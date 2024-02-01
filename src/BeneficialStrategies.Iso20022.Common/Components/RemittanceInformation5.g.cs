﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RemittanceInformation5.  ISO2002 ID# _QF2HWNp-Ed-ak6NoX_4Aeg_414888716.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts' receivable system.
/// </summary>
public partial record RemittanceInformation5
{
    #nullable enable
    
    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts' receivable system, in an unstructured form.
    /// </summary>
    public IsoMax140Text[] Unstructured { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts' receivable system, in a structured form.
    /// </summary>
    public StructuredRemittanceInformation7[] Structured { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
