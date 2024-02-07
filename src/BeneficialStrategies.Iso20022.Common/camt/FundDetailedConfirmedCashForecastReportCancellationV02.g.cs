﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FundDetailedConfirmedCashForecastReportCancellationV02.  ISO2002 ID# _bVylm9E-Ed-BzquC8wXy7w_2091851889.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.camt.FundDetailedConfirmedCashForecastReportCancellationV02>;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// This record is an implementation of the camt.045.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report provider, such as a transfer agent, sends the FundDetailedConfirmedCashForecastReportCancellation messages to the report user, such as an investment manager, fund accountant or any other interested party, to cancel a previously sent FundDetailedConfirmedCashForecastReport.
/// Usage
/// The FundDetailedConfirmedCashForecastReportCancellation message is used to cancel an entire FundDetailedConfirmedCashForecastReport message that was previously sent. This message must contain the reference of the message to be cancelled.
/// This message may also contain details of the message to be cancelled, but this is not recommended.
/// </summary>
[Serializable]
[Description(@"Scope|A report provider, such as a transfer agent, sends the FundDetailedConfirmedCashForecastReportCancellation messages to the report user, such as an investment manager, fund accountant or any other interested party, to cancel a previously sent FundDetailedConfirmedCashForecastReport.|Usage|The FundDetailedConfirmedCashForecastReportCancellation message is used to cancel an entire FundDetailedConfirmedCashForecastReport message that was previously sent. This message must contain the reference of the message to be cancelled.|This message may also contain details of the message to be cancelled, but this is not recommended.")]
public partial record FundDetailedConfirmedCashForecastReportCancellationV02 : IOuterRecord<FundDetailedConfirmedCashForecastReportCancellationV02,FundDetailedConfirmedCashForecastReportCancellationV02Document>
    ,IIsoXmlSerilizable<FundDetailedConfirmedCashForecastReportCancellationV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.045.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FndDtldConfdCshFcstRptCxlV02";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => FundDetailedConfirmedCashForecastReportCancellationV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_bVylnNE-Ed-BzquC8wXy7w_822772585")]
    [Description(@"Identifies the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_bVylndE-Ed-BzquC8wXy7w_2091852045")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_bV8WkNE-Ed-BzquC8wXy7w_2091851967")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_bV8WkdE-Ed-BzquC8wXy7w_2091851925")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_bV8WktE-Ed-BzquC8wXy7w_728842936")]
    [Description(@"Pagination of the message.")]
    [DataMember(Name="MsgPgntn")]
    [XmlElement(ElementName="MsgPgntn")]
    [Required]
    public required Pagination MessagePagination { get; init; }
    
    /// <summary>
    /// The FundDetailedConfirmedCashForecastReport to be cancelled.
    /// </summary>
    [IsoId("_bV8Wk9E-Ed-BzquC8wXy7w_2091852010")]
    [Description(@"The FundDetailedConfirmedCashForecastReport to be cancelled.")]
    [DataMember(Name="CshFcstRptToBeCanc")]
    [XmlElement(ElementName="CshFcstRptToBeCanc")]
    public FundDetailedConfirmedCashForecastReport2? CashForecastReportToBeCancelled { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FundDetailedConfirmedCashForecastReportCancellationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FundDetailedConfirmedCashForecastReportCancellationV02Document ToDocument()
    {
        return new FundDetailedConfirmedCashForecastReportCancellationV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("FndDtldConfdCshFcstRptCxlV02");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "MsgId", xmlNamespace );
        MessageIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PoolReference is AdditionalReference3 PoolReferenceValue)
        {
            writer.WriteStartElement(null, "PoolRef", xmlNamespace );
            PoolReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousReference is AdditionalReference3 PreviousReferenceValue)
        {
            writer.WriteStartElement(null, "PrvsRef", xmlNamespace );
            PreviousReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RelatedReference is AdditionalReference3 RelatedReferenceValue)
        {
            writer.WriteStartElement(null, "RltdRef", xmlNamespace );
            RelatedReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "MsgPgntn", xmlNamespace );
        MessagePagination.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CashForecastReportToBeCancelled is FundDetailedConfirmedCashForecastReport2 CashForecastReportToBeCancelledValue)
        {
            writer.WriteStartElement(null, "CshFcstRptToBeCanc", xmlNamespace );
            CashForecastReportToBeCancelledValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static FundDetailedConfirmedCashForecastReportCancellationV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FundDetailedConfirmedCashForecastReportCancellationV02"/>.
/// </summary>
[Serializable]
public partial record FundDetailedConfirmedCashForecastReportCancellationV02Document : IOuterDocument<FundDetailedConfirmedCashForecastReportCancellationV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.045.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FundDetailedConfirmedCashForecastReportCancellationV02"/> is required.
    /// </summary>
    [DataMember(Name=FundDetailedConfirmedCashForecastReportCancellationV02.XmlTag)]
    public required FundDetailedConfirmedCashForecastReportCancellationV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(FundDetailedConfirmedCashForecastReportCancellationV02.XmlTag);
        Message.Serialize(writer, DocumentNamespace);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndDocument();
    }
    
    public void ReadXml(XmlReader reader)
    {
        throw new NotImplementedException();
    }
    
    public System.Xml.Schema.XmlSchema GetSchema() => null;
}
