﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SupportingDocumentEntry2.  ISO2002 ID# _l1j-wbGJEeuSTr8k0UEM8A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency control document entry supporting the contract registration.
/// </summary>
[DataContract]
[XmlType]
public partial record SupportingDocumentEntry2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the supporting document entry.
    /// </summary>
    [DataMember]
    public required IsoMax35Text EntryIdentification { get; init; } 
    /// <summary>
    /// Identification of the original document for which the supporting documents are provided.
    /// </summary>
    [DataMember]
    public required DocumentIdentification22 OriginalDocument { get; init; } 
    /// <summary>
    /// Document type in a coded form.
    /// TBC: Data must support "_".
    /// </summary>
    [DataMember]
    public required IsoExact4AlphaNumericUnderscoreText DocumentType { get; init; } 
    /// <summary>
    /// Total amount of the supporting document entry.
    /// </summary>
    [DataMember]
    public IsoActiveCurrencyAndAmount? TotalAmount { get; init; } 
    /// <summary>
    /// Total amount after shipment of the supporting document entry.
    /// </summary>
    [DataMember]
    public IsoActiveCurrencyAndAmount? TotalAmountAfterShipment { get; init; } 
    /// <summary>
    /// Total amount of the supporting document entry in the currency of the contract.
    /// </summary>
    [DataMember]
    public IsoActiveCurrencyAndAmount? TotalAmountInContractCurrency { get; init; } 
    /// <summary>
    /// Total amount after shipment of the supporting document entry in the currency of the contract.
    /// </summary>
    [DataMember]
    public IsoActiveCurrencyAndAmount? TotalAmountAfterShipmentInContractCurrency { get; init; } 
    /// <summary>
    /// Conditions and attributes related to the shipment.
    /// </summary>
    [DataMember]
    public required ShipmentAttribute2 ShipmentAttributes { get; init; } 
    /// <summary>
    /// Identification of the document entry amendment.
    /// </summary>
    [DataMember]
    public DocumentEntryAmendment1? EntryAmendmentIdentification { get; init; } 
    /// <summary>
    /// Indication of contract obligations execution.
    /// </summary>
    [DataMember]
    public IsoMax35Text? MaturityData { get; init; } 
    /// <summary>
    /// Further details on the supporting document entry.
    /// </summary>
    [DataMember]
    public IsoMax500Text? AdditionalInformation { get; init; } 
    /// <summary>
    /// Documents provided as attachments to the supporting document entry.
    /// </summary>
    [DataMember]
    public ValueList<DocumentGeneralInformation5> Attachment { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
