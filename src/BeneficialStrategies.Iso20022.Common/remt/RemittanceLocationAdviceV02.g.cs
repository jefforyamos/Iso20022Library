﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RemittanceLocationAdviceV02.  ISO2002 ID# _bf9SWW2PEei3KuUgpx7Xcw.
//
namespace BeneficialStrategies.Iso20022.remt;

/// <summary>
/// The RemittanceLocationAdvice message allows the originator of the message to identify where the remittance advice is located for a related payment.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The RemittanceLocationAdvice message allows the originator of the message to identify where the remittance advice is located for a related payment.")]
public partial record RemittanceLocationAdviceV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RmtLctnAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics shared by all remittance location information included in the message.
    /// </summary>
    [IsoId("_bf9SXW2PEei3KuUgpx7Xcw")]
    [Description(@"Set of characteristics shared by all remittance location information included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader79 GroupHeader { get; init; }
    
    /// <summary>
    /// Provides information related to location and/or delivery of the remittance information. This information is used to enable the matching of an entry with the items that the associated payment is intended to settle.
    /// </summary>
    [IsoId("_bf9SX22PEei3KuUgpx7Xcw")]
    [Description(@"Provides information related to location and/or delivery of the remittance information. This information is used to enable the matching of an entry with the items that the associated payment is intended to settle.")]
    [DataMember(Name="RmtLctn")]
    [XmlElement(ElementName="RmtLctn")]
    [Required]
    public required RemittanceLocation5 RemittanceLocation { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bf9SYW2PEei3KuUgpx7Xcw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RemittanceLocationAdviceV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RemittanceLocationAdviceV02Document ToDocument()
    {
        return new RemittanceLocationAdviceV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RemittanceLocationAdviceV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RemittanceLocationAdviceV02Document : IOuterDocument<RemittanceLocationAdviceV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:remt.002.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RemittanceLocationAdviceV02"/> is required.
    /// </summary>
    public required RemittanceLocationAdviceV02 Message { get; init; }
}
