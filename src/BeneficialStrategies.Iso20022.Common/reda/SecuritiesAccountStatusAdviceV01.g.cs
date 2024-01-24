﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesAccountStatusAdviceV01.  ISO2002 ID# _KAu-652fEem_Be8NuxvF7Q.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// The SecuritiesAccountStatusAdvice message is send by the the executing party to an instructing party to provide the status of the execution of an creation, modification or deletion of securities account reference data.
/// Usage: 
/// When processing information is negative – a failure occurred in applying the changes the message accordingly also delivers information about the reason why the creation or update could not be processed. 
/// When the processing is succesfully performed, the message includes the related securities account identification.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SecuritiesAccountStatusAdvice message is send by the the executing party to an instructing party to provide the status of the execution of an creation, modification or deletion of securities account reference data.||Usage: |When processing information is negative – a failure occurred in applying the changes the message accordingly also delivers information about the reason why the creation or update could not be processed. |When the processing is succesfully performed, the message includes the related securities account identification.")]
public partial record SecuritiesAccountStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesAcctStsAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_EqxEkJ5REemQg7pJhFUUYg")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    public SomeMessageHeaderRecord? MessageHeader { get; init; }
    
    /// <summary>
    /// Status of the securities account involved in the originating message.
    /// </summary>
    [IsoId("_KAu--52fEem_Be8NuxvF7Q")]
    [Description(@"Status of the securities account involved in the originating message.")]
    [DataMember(Name="SctiesAcctSts")]
    [XmlElement(ElementName="SctiesAcctSts")]
    [Required]
    public required SomeSecuritiesAccountStatusRecord SecuritiesAccountStatus { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KAu-_Z2fEem_Be8NuxvF7Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesAccountStatusAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesAccountStatusAdviceV01Document ToDocument()
    {
        return new SecuritiesAccountStatusAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesAccountStatusAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesAccountStatusAdviceV01Document : IOuterDocument<SecuritiesAccountStatusAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.020.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesAccountStatusAdviceV01"/> is required.
    /// </summary>
    public required SecuritiesAccountStatusAdviceV01 Message { get; init; }
}
