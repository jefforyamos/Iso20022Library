﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StaticDataReportV02.  ISO2002 ID# _Zy71kRnXEeKKXqHkeUjBbw.
//
namespace BeneficialStrategies.Iso20022.admi;

/// <summary>
/// The StaticDataReport message is sent by a central system to the participant to provide static data held in the system.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The StaticDataReport message is sent by a central system to the participant to provide static data held in the system.|")]
public partial record StaticDataReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StatcDataRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unique and unambiguous identifier for the message, as assigned by the sender.
    /// </summary>
    [IsoId("_y5aAVzp8EeKXK8qRvydwAw")]
    [Description(@"Unique and unambiguous identifier for the message, as assigned by the sender.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required IsoMax35Text MessageIdentification { get; init; }
    
    /// <summary>
    /// To indicate the requested CLS Settlement Session that the related trade is part of.
    /// </summary>
    [IsoId("_vSr6ox3bEeKXIbeXfdPzuw")]
    [Description(@"To indicate the requested CLS Settlement Session that the related trade is part of.")]
    [DataMember(Name="SttlmSsnIdr")]
    [XmlElement(ElementName="SttlmSsnIdr")]
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; }
    
    /// <summary>
    /// Report type and returned data.
    /// </summary>
    [IsoId("_Zy71lxnXEeKKXqHkeUjBbw")]
    [Description(@"Report type and returned data.")]
    [DataMember(Name="RptDtls")]
    [XmlElement(ElementName="RptDtls")]
    [Required]
    public required RequestDetails5 ReportDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Dw3hYy53EeKwTrPDLMbLxA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="StaticDataReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public StaticDataReportV02Document ToDocument()
    {
        return new StaticDataReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="StaticDataReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record StaticDataReportV02Document : IOuterDocument<StaticDataReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:admi.010.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="StaticDataReportV02"/> is required.
    /// </summary>
    public required StaticDataReportV02 Message { get; init; }
}
