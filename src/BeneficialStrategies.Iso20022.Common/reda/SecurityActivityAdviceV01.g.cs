﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecurityActivityAdviceV01.  ISO2002 ID# _jTtYqx62Eeu31YsWNiv_cw.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// The SecurityActivityReport message is sent by the executing party to an instructing party containing information about changes on securities reference data.||Scope and usage: |It aims at informing about the changes occurred during a business date for securities reference data.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SecurityActivityReport message is sent by the executing party to an instructing party containing information about changes on securities reference data.||Scope and usage: |It aims at informing about the changes occurred during a business date for securities reference data.")]
public partial record SecurityActivityAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctyActvtyAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_Bv1S0ZIxEeuAlLVx8pyt3w")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    public SomeMessageHeaderRecord? MessageHeader { get; init; }
    
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_jTtYux62Eeu31YsWNiv_cw")]
    [Description(@"Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required SomePaginationRecord Pagination { get; init; }
    
    /// <summary>
    /// Activity report of changes occurred for a financial instrument defined in the system.
    /// </summary>
    [IsoId("_jTtYwR62Eeu31YsWNiv_cw")]
    [Description(@"Activity report of changes occurred for a financial instrument defined in the system.")]
    [DataMember(Name="SctyActvty")]
    [XmlElement(ElementName="SctyActvty")]
    [Required]
    public required SomeSecurityActivityRecord SecurityActivity { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jTtYwx62Eeu31YsWNiv_cw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecurityActivityAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecurityActivityAdviceV01Document ToDocument()
    {
        return new SecurityActivityAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecurityActivityAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecurityActivityAdviceV01Document : IOuterDocument<SecurityActivityAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.009.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecurityActivityAdviceV01"/> is required.
    /// </summary>
    public required SecurityActivityAdviceV01 Message { get; init; }
}