﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntentToPayReportV01.  ISO2002 ID# _quPoNdE8Ed-BzquC8wXy7w_-1126725598.
//
namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// Scope
/// The IntentToPayReport message is sent by the matching application to the two primary banks after receiving an IntentToPayNotification message.
/// This message is a report per transaction that were referenced in the IntentToPayNotice message. For each transaction, the matching application has accumulated the amounts present in all previous IntentToPayNotice messages and reports the total.
/// Usage
/// The IntentToPayReport message is a report that is automatically generated by the matching application following an IntentToPayNotice message. No response is expected.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The IntentToPayReport message is sent by the matching application to the two primary banks after receiving an IntentToPayNotification message.|This message is a report per transaction that were referenced in the IntentToPayNotice message. For each transaction, the matching application has accumulated the amounts present in all previous IntentToPayNotice messages and reports the total.|Usage|The IntentToPayReport message is a report that is automatically generated by the matching application following an IntentToPayNotice message. No response is expected.")]
public partial record IntentToPayReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InttToPayRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the report message.
    /// </summary>
    [IsoId("_quPoNtE8Ed-BzquC8wXy7w_-1126725320")]
    [Description(@"Identifies the report message.")]
    [DataMember(Name="RptId")]
    [XmlElement(ElementName="RptId")]
    [Required]
    public required SomeReportIdentificationRecord ReportIdentification { get; init; }
    
    /// <summary>
    /// Reports on the intention to pay per purchase order.
    /// </summary>
    [IsoId("_quPoN9E8Ed-BzquC8wXy7w_747097845")]
    [Description(@"Reports on the intention to pay per purchase order.")]
    [DataMember(Name="RptdItms")]
    [XmlElement(ElementName="RptdItms")]
    public SomeReportedItemsRecord? ReportedItems { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IntentToPayReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntentToPayReportV01Document ToDocument()
    {
        return new IntentToPayReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="IntentToPayReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record IntentToPayReportV01Document : IOuterDocument<IntentToPayReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.046.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IntentToPayReportV01"/> is required.
    /// </summary>
    public required IntentToPayReportV01 Message { get; init; }
}
