﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SupportingDocumentEntry1.  ISO2002 ID# _UZhbktM-EeSDLevdaFPXHw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency control document entry supporting the contract registration.
/// </summary>
public partial record SupportingDocumentEntry1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the supporting document entry.
    /// </summary>
    public required IsoMax35Text EntryIdentification { get; init; } 
    /// <summary>
    /// Identification of the original document for which the supporting documents are provided.
    /// </summary>
    public required DocumentIdentification22 OriginalDocument { get; init; } 
    /// <summary>
    /// Document type in a coded form.
    /// TBC: Data must support "_".
    /// </summary>
    public required IsoExact4AlphaNumericText DocumentType { get; init; } 
    /// <summary>
    /// Total amount of the supporting document entry.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalAmount { get; init; } 
    /// <summary>
    /// Total amount after shipment of the supporting document entry.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalAmountAfterShipment { get; init; } 
    /// <summary>
    /// Total amount of the supporting document entry in the currency of the contract.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalAmountInContractCurrency { get; init; } 
    /// <summary>
    /// Total amount after shipment of the supporting document entry in the currency of the contract.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalAmountAfterShipmentInContractCurrency { get; init; } 
    /// <summary>
    /// Conditions and attributes related to the shipment.
    /// </summary>
    public required ShipmentAttribute1 ShipmentAttributes { get; init; } 
    /// <summary>
    /// Further details on the supporting document entry.
    /// </summary>
    public IsoMax500Text? AdditionalInformation { get; init; } 
    /// <summary>
    /// Documents provided as attachments to the supporting document entry.
    /// </summary>
    public DocumentGeneralInformation3[] Attachment { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
