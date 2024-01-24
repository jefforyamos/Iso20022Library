﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesAccountReportV01.  ISO2002 ID# _KAu-1Z2fEem_Be8NuxvF7Q.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// The SecuritiesAccountReport message sent by the executing party to an instructing party to provide the details of the securities account details as requested in the query.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SecuritiesAccountReport message sent by the executing party to an instructing party to provide the details of the securities account details as requested in the query.")]
public partial record SecuritiesAccountReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesAcctRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Point to point reference elements, as assigned by the instructing party, to unambiguously identify the report message.
    /// </summary>
    [IsoId("_KAu-352fEem_Be8NuxvF7Q")]
    [Description(@"Point to point reference elements, as assigned by the instructing party, to unambiguously identify the report message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    public SomeMessageHeaderRecord? MessageHeader { get; init; }
    
    /// <summary>
    /// Provides details on the page number of the message.
    /// </summary>
    [IsoId("_KAu-4Z2fEem_Be8NuxvF7Q")]
    [Description(@"Provides details on the page number of the message.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required SomePaginationRecord Pagination { get; init; }
    
    /// <summary>
    /// Provides information on report or error resulting from the originating query message.
    /// </summary>
    [IsoId("_KAu-552fEem_Be8NuxvF7Q")]
    [Description(@"Provides information on report or error resulting from the originating query message.")]
    [DataMember(Name="RptOrErr")]
    [XmlElement(ElementName="RptOrErr")]
    [Required]
    public required SomeReportOrErrorRecord ReportOrError { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KAu-6Z2fEem_Be8NuxvF7Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesAccountReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesAccountReportV01Document ToDocument()
    {
        return new SecuritiesAccountReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesAccountReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesAccountReportV01Document : IOuterDocument<SecuritiesAccountReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.021.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesAccountReportV01"/> is required.
    /// </summary>
    public required SecuritiesAccountReportV01 Message { get; init; }
}
