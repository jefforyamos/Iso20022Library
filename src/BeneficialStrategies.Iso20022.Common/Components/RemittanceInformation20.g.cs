﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RemittanceInformation20.  ISO2002 ID# _d5u5sdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts' receivable system.
/// </summary>
public partial record RemittanceInformation20
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, assigned by the originator, to unambiguously identify the remittance information within the message.
    /// </summary>
    public IsoMax35Text? RemittanceIdentification { get; init; } 
    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts' receivable system, in an unstructured form.
    /// </summary>
    public IsoMax140Text? Unstructured { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts' receivable system, in a structured form.
    /// </summary>
    public StructuredRemittanceInformation17? Structured { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of elements used to provide information on the original transactions, to which the remittance message refers.
    /// </summary>
    public required OriginalPaymentInformation9 OriginalPaymentInformation { get; init; } 
    
    #nullable disable
}
