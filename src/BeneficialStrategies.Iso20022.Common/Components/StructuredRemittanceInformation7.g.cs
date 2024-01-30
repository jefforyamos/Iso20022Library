﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StructuredRemittanceInformation7.  ISO2002 ID# _QF2HUdp-Ed-ak6NoX_4Aeg_542333263.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts' receivable system, in a structured form.
/// </summary>
public partial record StructuredRemittanceInformation7
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to identify the documents referred to in the remittance information.
    /// </summary>
    public ReferredDocumentInformation3? ReferredDocumentInformation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of elements used to provide details on the amounts of the referred document.
    /// </summary>
    public RemittanceAmount1? ReferredDocumentAmount { get; init; } 
    /// <summary>
    /// Reference information provided by the creditor to allow the identification of the underlying documents.
    /// </summary>
    public CreditorReferenceInformation2? CreditorReferenceInformation { get; init; } 
    /// <summary>
    /// Identification of the organisation issuing the invoice, when it is different from the creditor or ultimate creditor.
    /// </summary>
    public PartyIdentification32? Invoicer { get; init; } 
    /// <summary>
    /// Identification of the party to whom an invoice is issued, when it is different from the debtor or ultimate debtor.
    /// </summary>
    public PartyIdentification32? Invoicee { get; init; } 
    /// <summary>
    /// Additional information, in free text form, to complement the structured remittance information.
    /// </summary>
    // public IReadOnlyCollection<IsoMax140Text> AdditionalRemittanceInformation { get; init; }
    
    #nullable disable
}
