﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RedemptionMultipleOrderV02.  ISO2002 ID# _rxRn99E7Ed-BzquC8wXy7w_-865600091.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.setr.RedemptionMultipleOrderV02>;

namespace BeneficialStrategies.Iso20022.setr;


/// <summary>
/// This record is an implementation of the setr.004.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RedemptionMultipleOrder message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.
/// This message is used to instruct the executing party to redeem to one or more financial instruments, for the same account.
/// Usage
/// The RedemptionMultipleOrder message is used for multiple orders. It may also be used for single orders, ie, a message containing one order for one financial instrument and related to one investment account. For a single redemption order, the RedemptionMultipleOrder message, not the RedemptionBulkOrder message, must be used.
/// If there are redemption orders for the same financial instrument but for different accounts, then the RedemptionBulkOrder must be used.
/// </summary>
[Serializable]
[Description(@"Scope|The RedemptionMultipleOrder message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.|This message is used to instruct the executing party to redeem to one or more financial instruments, for the same account.|Usage|The RedemptionMultipleOrder message is used for multiple orders. It may also be used for single orders, ie, a message containing one order for one financial instrument and related to one investment account. For a single redemption order, the RedemptionMultipleOrder message, not the RedemptionBulkOrder message, must be used.|If there are redemption orders for the same financial instrument but for different accounts, then the RedemptionBulkOrder must be used.")]
public partial record RedemptionMultipleOrderV02 : IOuterRecord<RedemptionMultipleOrderV02,RedemptionMultipleOrderV02Document>
    ,IIsoXmlSerilizable<RedemptionMultipleOrderV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.004.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.004.001.02";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => RedemptionMultipleOrderV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_rxRn-NE7Ed-BzquC8wXy7w_772037014")]
    [Description(@"Reference assigned to a set of orders or trades in order to link them together.")]
    [DataMember(Name="MstrRef")]
    [XmlElement(ElementName="MstrRef")]
    public AdditionalReference3? MasterReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_rxRn-dE7Ed-BzquC8wXy7w_769267720")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_rxRn-tE7Ed-BzquC8wXy7w_760033651")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// General information related to the order.
    /// </summary>
    [IsoId("_rxax4NE7Ed-BzquC8wXy7w_-351199912")]
    [Description(@"General information related to the order.")]
    [DataMember(Name="MltplOrdrDtls")]
    [XmlElement(ElementName="MltplOrdrDtls")]
    [Required]
    public required RedemptionMultipleOrder2 MultipleOrderDetails { get; init; }
    
    /// <summary>
    /// The information related to an intermediary.
    /// </summary>
    [IsoId("_rxax4dE7Ed-BzquC8wXy7w_527770974")]
    [Description(@"The information related to an intermediary.")]
    [DataMember(Name="IntrmyDtls")]
    [XmlElement(ElementName="IntrmyDtls")]
    public required ValueList<Intermediary4> IntermediaryDetails { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_rxax4tE7Ed-BzquC8wXy7w_-1422132281")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation1? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rxax49E7Ed-BzquC8wXy7w_1076965137")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RedemptionMultipleOrderV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RedemptionMultipleOrderV02Document ToDocument()
    {
        return new RedemptionMultipleOrderV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("setr.004.001.02");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (MasterReference is AdditionalReference3 MasterReferenceValue)
        {
            writer.WriteStartElement(null, "MstrRef", xmlNamespace );
            MasterReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
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
        writer.WriteStartElement(null, "MltplOrdrDtls", xmlNamespace );
        MultipleOrderDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IntrmyDtls", xmlNamespace );
        IntermediaryDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CopyDetails is CopyInformation1 CopyDetailsValue)
        {
            writer.WriteStartElement(null, "CpyDtls", xmlNamespace );
            CopyDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Extension is Extension1 ExtensionValue)
        {
            writer.WriteStartElement(null, "Xtnsn", xmlNamespace );
            ExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static RedemptionMultipleOrderV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RedemptionMultipleOrderV02"/>.
/// </summary>
[Serializable]
public partial record RedemptionMultipleOrderV02Document : IOuterDocument<RedemptionMultipleOrderV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.004.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RedemptionMultipleOrderV02"/> is required.
    /// </summary>
    [DataMember(Name=RedemptionMultipleOrderV02.XmlTag)]
    public required RedemptionMultipleOrderV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(RedemptionMultipleOrderV02.XmlTag);
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
