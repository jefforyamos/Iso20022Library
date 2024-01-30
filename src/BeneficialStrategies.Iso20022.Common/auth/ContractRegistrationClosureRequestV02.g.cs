﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ContractRegistrationClosureRequestV02.  ISO2002 ID# _bf9RxW2PEei3KuUgpx7Xcw.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The ContractRegistrationClosureRequest message is sent by the reporting party to the registration agent to close the registered contract subject to currency control.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ContractRegistrationClosureRequest message is sent by the reporting party to the registration agent to close the registered contract subject to currency control.")]
public partial record ContractRegistrationClosureRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CtrctRegnClsrReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Characteristics shared by all individual items included in the message.
    /// </summary>
    [IsoId("_bf9Rx22PEei3KuUgpx7Xcw")]
    [Description(@"Characteristics shared by all individual items included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required CurrencyControlHeader4 GroupHeader { get; init; }
    
    /// <summary>
    /// Details on the closure of the registered contract.
    /// </summary>
    [IsoId("_bf9RyW2PEei3KuUgpx7Xcw")]
    [Description(@"Details on the closure of the registered contract.")]
    [DataMember(Name="RegdCtrctClsr")]
    [XmlElement(ElementName="RegdCtrctClsr")]
    [Required]
    public required RegisteredContract6 RegisteredContractClosure { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bf9R0W2PEei3KuUgpx7Xcw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ContractRegistrationClosureRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ContractRegistrationClosureRequestV02Document ToDocument()
    {
        return new ContractRegistrationClosureRequestV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ContractRegistrationClosureRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ContractRegistrationClosureRequestV02Document : IOuterDocument<ContractRegistrationClosureRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.020.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ContractRegistrationClosureRequestV02"/> is required.
    /// </summary>
    public required ContractRegistrationClosureRequestV02 Message { get; init; }
}
