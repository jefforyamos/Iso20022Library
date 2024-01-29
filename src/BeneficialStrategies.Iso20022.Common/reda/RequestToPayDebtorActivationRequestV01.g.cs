﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestToPayDebtorActivationRequestV01.  ISO2002 ID# _rNNBzeHzEeqbls7Gk4-ckA.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// The RequestToPayDebtorActivationRequest message is sent by the debtor RTP (Request To Pay) provider to the creditor RTP provider and optionally from the debtor to its RTP provider and from the creditor RTP provider to the creditor to request the debtor activation of the RTP service with that specific creditor.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The RequestToPayDebtorActivationRequest message is sent by the debtor RTP (Request To Pay) provider to the creditor RTP provider and optionally from the debtor to its RTP provider and from the creditor RTP provider to the creditor to request the debtor activation of the RTP service with that specific creditor.")]
public partial record RequestToPayDebtorActivationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqToPayDbtrActvtnReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Header data for the creditor enrolment request.
    /// </summary>
    [IsoId("_rNNBz-HzEeqbls7Gk4-ckA")]
    [Description(@"Header data for the creditor enrolment request.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Specific attributes provided the debtor, as requested by the creditor, for the activation request.
    /// </summary>
    [IsoId("_rNNB0eHzEeqbls7Gk4-ckA")]
    [Description(@"Specific attributes provided the debtor, as requested by the creditor, for the activation request.")]
    [DataMember(Name="DbtrActvtn")]
    [XmlElement(ElementName="DbtrActvtn")]
    [Required]
    public required SomeDebtorActivationRecord DebtorActivation { get; init; }
    
    /// <summary>
    /// Further data related to the electronic invoice (e-invoice).
    /// </summary>
    [IsoId("_rNNB0-HzEeqbls7Gk4-ckA")]
    [Description(@"Further data related to the electronic invoice (e-invoice).")]
    [DataMember(Name="ElctrncInvcData")]
    [XmlElement(ElementName="ElctrncInvcData")]
    [Required]
    public required SomeElectronicInvoiceDataRecord ElectronicInvoiceData { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rNNB1eHzEeqbls7Gk4-ckA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RequestToPayDebtorActivationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestToPayDebtorActivationRequestV01Document ToDocument()
    {
        return new RequestToPayDebtorActivationRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RequestToPayDebtorActivationRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RequestToPayDebtorActivationRequestV01Document : IOuterDocument<RequestToPayDebtorActivationRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.070.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RequestToPayDebtorActivationRequestV01"/> is required.
    /// </summary>
    public required RequestToPayDebtorActivationRequestV01 Message { get; init; }
}