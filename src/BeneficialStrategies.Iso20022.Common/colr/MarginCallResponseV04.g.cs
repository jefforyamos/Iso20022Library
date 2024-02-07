﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MarginCallResponseV04.  ISO2002 ID# _CRyfw4FsEeWtPe6Crjmeug.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.colr.MarginCallResponseV04>;

namespace BeneficialStrategies.Iso20022.colr;


/// <summary>
/// This record is an implementation of the colr.004.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MarginCallResponse message is sent by the collateral giver or its collateral manager to the collateral taker or its collateral manager or vice versa. This is a response to the MarginCallRequest message. The margin call can be accepted, fully disputed or partially disputed.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// When sent by the collateral giver the MarginCallResponse message is used to:
/// - fully accept the MarginCallRequest
/// - or partially accept the MarginCallRequest.
/// 
/// When sent by the collateral taker the MarginCallResponse message is used to:
/// - fully accept the recall of collateral
/// - or partially accept the recall of collateral.
/// </summary>
[Serializable]
[Description(@"Scope|The MarginCallResponse message is sent by the collateral giver or its collateral manager to the collateral taker or its collateral manager or vice versa. This is a response to the MarginCallRequest message. The margin call can be accepted, fully disputed or partially disputed.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|When sent by the collateral giver the MarginCallResponse message is used to:|- fully accept the MarginCallRequest|- or partially accept the MarginCallRequest.||When sent by the collateral taker the MarginCallResponse message is used to:|- fully accept the recall of collateral|- or partially accept the recall of collateral.")]
public partial record MarginCallResponseV04 : IOuterRecord<MarginCallResponseV04,MarginCallResponseV04Document>
    ,IIsoXmlSerilizable<MarginCallResponseV04>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.004.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MrgnCallRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MarginCallResponseV04Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_CRyfxYFsEeWtPe6Crjmeug")]
    [Description(@"Unambiguous identification of the transaction as know by the instructing party.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required IsoMax35Text TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_CRyfx4FsEeWtPe6Crjmeug")]
    [Description(@"Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.")]
    [DataMember(Name="Oblgtn")]
    [XmlElement(ElementName="Oblgtn")]
    [Required]
    public required Obligation4 Obligation { get; init; }
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_CRyfyYFsEeWtPe6Crjmeug")]
    [Description(@"Agreement details for the over the counter market.")]
    [DataMember(Name="Agrmt")]
    [XmlElement(ElementName="Agrmt")]
    public Agreement4? Agreement { get; init; }
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party A.
    /// </summary>
    [IsoId("_CRyfy4FsEeWtPe6Crjmeug")]
    [Description(@"Provides details about the margin calculation that would be due to party A.")]
    [DataMember(Name="MrgnDtlsDueToA")]
    [XmlElement(ElementName="MrgnDtlsDueToA")]
    public MarginCall1? MarginDetailsDueToA { get; init; }
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party B.
    /// </summary>
    [IsoId("_CRyfzYFsEeWtPe6Crjmeug")]
    [Description(@"Provides details about the margin calculation that would be due to party B.")]
    [DataMember(Name="MrgnDtlsDueToB")]
    [XmlElement(ElementName="MrgnDtlsDueToB")]
    public MarginCall1? MarginDetailsDueToB { get; init; }
    
    /// <summary>
    /// Provides details about the agreed amount that would be due to party A.
    /// </summary>
    [IsoId("_CRyfz4FsEeWtPe6Crjmeug")]
    [Description(@"Provides details about the agreed amount that would be due to party A.")]
    [DataMember(Name="AgrdAmtDueToA")]
    [XmlElement(ElementName="AgrdAmtDueToA")]
    public AgreedAmount1Choice_? AgreedAmountDueToA { get; init; }
    
    /// <summary>
    /// Provides details about the agreed amount that would be due to party B.
    /// </summary>
    [IsoId("_CRyf0YFsEeWtPe6Crjmeug")]
    [Description(@"Provides details about the agreed amount that would be due to party B.")]
    [DataMember(Name="AgrdAmtDueToB")]
    [XmlElement(ElementName="AgrdAmtDueToB")]
    public AgreedAmount1Choice_? AgreedAmountDueToB { get; init; }
    
    /// <summary>
    /// Provides response details about the margin call.
    /// </summary>
    [IsoId("_CRyf04FsEeWtPe6Crjmeug")]
    [Description(@"Provides response details about the margin call.")]
    [DataMember(Name="RspnDtls")]
    [XmlElement(ElementName="RspnDtls")]
    public Response1? ResponseDetails { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_CRyf1YFsEeWtPe6Crjmeug")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MarginCallResponseV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MarginCallResponseV04Document ToDocument()
    {
        return new MarginCallResponseV04Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("MrgnCallRspn");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(TransactionIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Oblgtn", xmlNamespace );
        Obligation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Agreement is Agreement4 AgreementValue)
        {
            writer.WriteStartElement(null, "Agrmt", xmlNamespace );
            AgreementValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarginDetailsDueToA is MarginCall1 MarginDetailsDueToAValue)
        {
            writer.WriteStartElement(null, "MrgnDtlsDueToA", xmlNamespace );
            MarginDetailsDueToAValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarginDetailsDueToB is MarginCall1 MarginDetailsDueToBValue)
        {
            writer.WriteStartElement(null, "MrgnDtlsDueToB", xmlNamespace );
            MarginDetailsDueToBValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AgreedAmountDueToA is AgreedAmount1Choice_ AgreedAmountDueToAValue)
        {
            writer.WriteStartElement(null, "AgrdAmtDueToA", xmlNamespace );
            AgreedAmountDueToAValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AgreedAmountDueToB is AgreedAmount1Choice_ AgreedAmountDueToBValue)
        {
            writer.WriteStartElement(null, "AgrdAmtDueToB", xmlNamespace );
            AgreedAmountDueToBValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ResponseDetails is Response1 ResponseDetailsValue)
        {
            writer.WriteStartElement(null, "RspnDtls", xmlNamespace );
            ResponseDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MarginCallResponseV04 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MarginCallResponseV04"/>.
/// </summary>
[Serializable]
public partial record MarginCallResponseV04Document : IOuterDocument<MarginCallResponseV04>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.004.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MarginCallResponseV04"/> is required.
    /// </summary>
    [DataMember(Name=MarginCallResponseV04.XmlTag)]
    public required MarginCallResponseV04 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(MarginCallResponseV04.XmlTag);
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
