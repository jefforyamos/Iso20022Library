﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FundDetailedConfirmedCashForecastReportV03.  ISO2002 ID# _cUOjwtE-Ed-BzquC8wXy7w_151487021.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.camt.FundDetailedConfirmedCashForecastReportV03>;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// This record is an implementation of the camt.043.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report provider, such as a transfer agent, sends the FundDetailedConfirmedCashForecastReport message to the report user, such as an investment manager, to report the confirmed cash incomings and outgoings, sorted by country, institution name or other criteria defined by the user of one or more investment funds on one or more trade dates.
/// The cash movements may result from, for example, redemption, subscription, switch transactions or reinvestment of dividends.
/// Usage
/// The FundDetailedConfirmedCashForecastReport is used to provide definitive cash movements, i.e., it is sent after the cut-off time and/or the price valuation of the fund. If the price is not yet definitive, then the FundDetailedEstimatedCashForecastReport message must be used.
/// The FundDetailedConfirmedCashForecastReport message is used to report cash movements in or out of a fund, organised by party, such as fund management company, country, currency or by some other criteria defined by the report provider. If the report is used to given the cash-in and cash-out for a party, then additional criteria, such as currency and country, can be specified.
/// In addition, the underlying transaction type for the cash-in or cash-out movement can be specified, as well as information about the cash movement's underlying orders, such as commission and charges.
/// </summary>
[Serializable]
[Description(@"Scope|A report provider, such as a transfer agent, sends the FundDetailedConfirmedCashForecastReport message to the report user, such as an investment manager, to report the confirmed cash incomings and outgoings, sorted by country, institution name or other criteria defined by the user of one or more investment funds on one or more trade dates.|The cash movements may result from, for example, redemption, subscription, switch transactions or reinvestment of dividends.|Usage|The FundDetailedConfirmedCashForecastReport is used to provide definitive cash movements, i.e., it is sent after the cut-off time and/or the price valuation of the fund. If the price is not yet definitive, then the FundDetailedEstimatedCashForecastReport message must be used.|The FundDetailedConfirmedCashForecastReport message is used to report cash movements in or out of a fund, organised by party, such as fund management company, country, currency or by some other criteria defined by the report provider. If the report is used to given the cash-in and cash-out for a party, then additional criteria, such as currency and country, can be specified.|In addition, the underlying transaction type for the cash-in or cash-out movement can be specified, as well as information about the cash movement's underlying orders, such as commission and charges.")]
public partial record FundDetailedConfirmedCashForecastReportV03 : IOuterRecord<FundDetailedConfirmedCashForecastReportV03,FundDetailedConfirmedCashForecastReportV03Document>
    ,IIsoXmlSerilizable<FundDetailedConfirmedCashForecastReportV03>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.043.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FndDtldConfdCshFcstRptV03";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => FundDetailedConfirmedCashForecastReportV03Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_cUOjw9E-Ed-BzquC8wXy7w_187174877")]
    [Description(@"Identifies the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_cUOjxNE-Ed-BzquC8wXy7w_-1114330808")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_cUOjxdE-Ed-BzquC8wXy7w_-1112482945")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_cUOjxtE-Ed-BzquC8wXy7w_-1110634478")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_cUYUwNE-Ed-BzquC8wXy7w_396376411")]
    [Description(@"Pagination of the message.")]
    [DataMember(Name="MsgPgntn")]
    [XmlElement(ElementName="MsgPgntn")]
    [Required]
    public required Pagination MessagePagination { get; init; }
    
    /// <summary>
    /// Information related to the cash-in and cash-out flows for a specific trade date as a result of investment fund transactions, for example, subscriptions, redemptions or switches to/from a specified investment fund. The information provided is sorted by pre-defined criteria such as country, institution, currency or user defined criteria.
    /// </summary>
    [IsoId("_cUYUwdE-Ed-BzquC8wXy7w_-1299299787")]
    [Description(@"Information related to the cash-in and cash-out flows for a specific trade date as a result of investment fund transactions, for example, subscriptions, redemptions or switches to/from a specified investment fund. The information provided is sorted by pre-defined criteria such as country, institution, currency or user defined criteria.")]
    [DataMember(Name="FndCshFcstDtls")]
    [XmlElement(ElementName="FndCshFcstDtls")]
    [Required]
    public required FundCashForecast4 FundCashForecastDetails { get; init; }
    
    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows specified in the fund cash forecast details.
    /// </summary>
    [IsoId("_cUYUwtE-Ed-BzquC8wXy7w_1853440922")]
    [Description(@"Net cash as a result of the cash-in and cash-out flows specified in the fund cash forecast details.")]
    [DataMember(Name="CnsltdNetCshFcst")]
    [XmlElement(ElementName="CnsltdNetCshFcst")]
    public NetCashForecast3? ConsolidatedNetCashForecast { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_cUYUw9E-Ed-BzquC8wXy7w_-429341744")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FundDetailedConfirmedCashForecastReportV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FundDetailedConfirmedCashForecastReportV03Document ToDocument()
    {
        return new FundDetailedConfirmedCashForecastReportV03Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("FndDtldConfdCshFcstRptV03");
    
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
        writer.WriteStartElement(null, "FndCshFcstDtls", xmlNamespace );
        FundCashForecastDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ConsolidatedNetCashForecast is NetCashForecast3 ConsolidatedNetCashForecastValue)
        {
            writer.WriteStartElement(null, "CnsltdNetCshFcst", xmlNamespace );
            ConsolidatedNetCashForecastValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Extension is Extension1 ExtensionValue)
        {
            writer.WriteStartElement(null, "Xtnsn", xmlNamespace );
            ExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static FundDetailedConfirmedCashForecastReportV03 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FundDetailedConfirmedCashForecastReportV03"/>.
/// </summary>
[Serializable]
public partial record FundDetailedConfirmedCashForecastReportV03Document : IOuterDocument<FundDetailedConfirmedCashForecastReportV03>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.043.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FundDetailedConfirmedCashForecastReportV03"/> is required.
    /// </summary>
    [DataMember(Name=FundDetailedConfirmedCashForecastReportV03.XmlTag)]
    public required FundDetailedConfirmedCashForecastReportV03 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(FundDetailedConfirmedCashForecastReportV03.XmlTag);
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
