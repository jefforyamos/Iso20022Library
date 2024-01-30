﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CreditorPaymentActivationRequestV10.  ISO2002 ID# _XXWvgQLFEe2X55dNQNVKfg.
//
namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// The CreditorPaymentActivationRequest message is sent by the Creditor sending party to the Debtor receiving party, directly or through agents. It is used by a Creditor to request movement of funds from the debtor account to a creditor.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CreditorPaymentActivationRequest message is sent by the Creditor sending party to the Debtor receiving party, directly or through agents. It is used by a Creditor to request movement of funds from the debtor account to a creditor.")]
public partial record CreditorPaymentActivationRequestV10 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CdtrPmtActvtnReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_XXWvkQLFEe2X55dNQNVKfg")]
    [Description(@"Set of characteristics shared by all individual transactions included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader105 GroupHeader { get; init; }
    
    /// <summary>
    /// Set of characteristics that applies to the debit side of the payment transactions included in the creditor payment initiation.
    /// </summary>
    [IsoId("_XXWvkwLFEe2X55dNQNVKfg")]
    [Description(@"Set of characteristics that applies to the debit side of the payment transactions included in the creditor payment initiation.")]
    [DataMember(Name="PmtInf")]
    [XmlElement(ElementName="PmtInf")]
    [Required]
    public required PaymentInstruction42 PaymentInformation { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_XXWvlQLFEe2X55dNQNVKfg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CreditorPaymentActivationRequestV10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CreditorPaymentActivationRequestV10Document ToDocument()
    {
        return new CreditorPaymentActivationRequestV10Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CreditorPaymentActivationRequestV10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CreditorPaymentActivationRequestV10Document : IOuterDocument<CreditorPaymentActivationRequestV10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.013.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CreditorPaymentActivationRequestV10"/> is required.
    /// </summary>
    public required CreditorPaymentActivationRequestV10 Message { get; init; }
}
