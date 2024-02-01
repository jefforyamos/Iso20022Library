﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StructuredRemittanceInformation12.  ISO2002 ID# _W8isJx77EeSxevWRRWxNAg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts' receivable system, in a structured form.
/// </summary>
public partial record StructuredRemittanceInformation12
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to identify the documents referred to in the remittance information.
    /// </summary>
    public ReferredDocumentInformation6[] ReferredDocumentInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides details on the amounts of the referred document.
    /// </summary>
    public RemittanceAmount2? ReferredDocumentAmount { get; init; } 
    /// <summary>
    /// Reference information provided by the creditor to allow the identification of the underlying documents.
    /// </summary>
    public CreditorReferenceInformation2? CreditorReferenceInformation { get; init; } 
    /// <summary>
    /// Identification of the organisation issuing the invoice, when it is different from the creditor or ultimate creditor.
    /// </summary>
    public PartyIdentification43? Invoicer { get; init; } 
    /// <summary>
    /// Identification of the party to whom an invoice is issued, when it is different from the debtor or ultimate debtor.
    /// </summary>
    public PartyIdentification43? Invoicee { get; init; } 
    /// <summary>
    /// Provides remittance information about a payment made for tax-related purposes.
    /// </summary>
    public TaxInformation4? TaxRemittance { get; init; } 
    /// <summary>
    /// Provides remittance information about a payment for garnishment-related purposes.
    /// </summary>
    public Garnishment1? GarnishmentRemittance { get; init; } 
    /// <summary>
    /// Additional information, in free text form, to complement the structured remittance information.
    /// </summary>
    public IsoMax140Text[] AdditionalRemittanceInformation { get; init; } = [];
    
    #nullable disable
}
