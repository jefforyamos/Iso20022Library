﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesAccountCreationRequestV01.  ISO2002 ID# _KAlNzZ2fEem_Be8NuxvF7Q.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// The SecuritiesAccountCreationRequest message message is sent by an instructing party to the executing party to instruct the creation of a new securities account with the required account attributes details.
/// |
/// Usage:|
/// Processing and confirmation of the securities account creation request message are provided via a SecuritiesAccountStatusAdvice message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SecuritiesAccountCreationRequest message message is sent by an instructing party to the executing party to instruct the creation of a new securities account with the required account attributes details.|||Usage:||Processing and confirmation of the securities account creation request message are provided via a SecuritiesAccountStatusAdvice message.")]
public partial record SecuritiesAccountCreationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesAcctCreReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_gl0bMJ5GEemQg7pJhFUUYg")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    public SomeMessageHeaderRecord? MessageHeader { get; init; }
    
    /// <summary>
    /// Securities account to be created in the executing party system.
    /// </summary>
    [IsoId("_KAu-l52fEem_Be8NuxvF7Q")]
    [Description(@"Securities account to be created in the executing party system.")]
    [DataMember(Name="SctiesAcct")]
    [XmlElement(ElementName="SctiesAcct")]
    [Required]
    public required SomeSecuritiesAccountRecord SecuritiesAccount { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KAu-mZ2fEem_Be8NuxvF7Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesAccountCreationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesAccountCreationRequestV01Document ToDocument()
    {
        return new SecuritiesAccountCreationRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesAccountCreationRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesAccountCreationRequestV01Document : IOuterDocument<SecuritiesAccountCreationRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.018.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesAccountCreationRequestV01"/> is required.
    /// </summary>
    public required SecuritiesAccountCreationRequestV01 Message { get; init; }
}