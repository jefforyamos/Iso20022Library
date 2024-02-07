﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SubscriptionBulkOrderV02.  ISO2002 ID# _zvolqNE7Ed-BzquC8wXy7w_-2097123010.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.setr.SubscriptionBulkOrderV02>;

namespace BeneficialStrategies.Iso20022.setr;


/// <summary>
/// This record is an implementation of the setr.007.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The SubscriptionBulkOrder message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.
/// This message is used to instruct the executing party to subscribe to a financial instrument, for two or more accounts.
/// Usage
/// The SubscriptionBulkOrder message is used to bulk several individual orders into one bulk order. The individual orders come from different instructing parties, ie, account owners, but are related to the same financial instrument. This message will be typically be used by a party collecting orders and bulking these individual orders into one bulk order before sending it to another party.
/// For a single subscription order, the SubscriptionMultipleOrder message, not the SubscriptionBulkOrder message, must be used.
/// If there are subscription orders for different financial instruments but for the same account, then the SubscriptionMultipleOrder must be used.
/// </summary>
[Serializable]
[Description(@"Scope|The SubscriptionBulkOrder message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.|This message is used to instruct the executing party to subscribe to a financial instrument, for two or more accounts.|Usage|The SubscriptionBulkOrder message is used to bulk several individual orders into one bulk order. The individual orders come from different instructing parties, ie, account owners, but are related to the same financial instrument. This message will be typically be used by a party collecting orders and bulking these individual orders into one bulk order before sending it to another party.|For a single subscription order, the SubscriptionMultipleOrder message, not the SubscriptionBulkOrder message, must be used.|If there are subscription orders for different financial instruments but for the same account, then the SubscriptionMultipleOrder must be used.")]
public partial record SubscriptionBulkOrderV02 : IOuterRecord<SubscriptionBulkOrderV02,SubscriptionBulkOrderV02Document>
    ,IIsoXmlSerilizable<SubscriptionBulkOrderV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.007.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.007.001.02";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SubscriptionBulkOrderV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_zvyWoNE7Ed-BzquC8wXy7w_142369537")]
    [Description(@"Reference assigned to a set of orders or trades in order to link them together.")]
    [DataMember(Name="MstrRef")]
    [XmlElement(ElementName="MstrRef")]
    public AdditionalReference3? MasterReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_zvyWodE7Ed-BzquC8wXy7w_140520340")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_zvyWotE7Ed-BzquC8wXy7w_152526577")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// General information related to the order.
    /// </summary>
    [IsoId("_zvyWo9E7Ed-BzquC8wXy7w_-1645520650")]
    [Description(@"General information related to the order.")]
    [DataMember(Name="BlkOrdrDtls")]
    [XmlElement(ElementName="BlkOrdrDtls")]
    [Required]
    public required SubscriptionBulkOrder2 BulkOrderDetails { get; init; }
    
    /// <summary>
    /// The information related to an intermediary.
    /// </summary>
    [IsoId("_zvyWpNE7Ed-BzquC8wXy7w_2102293267")]
    [Description(@"The information related to an intermediary.")]
    [DataMember(Name="IntrmyDtls")]
    [XmlElement(ElementName="IntrmyDtls")]
    public required ValueList<Intermediary4> IntermediaryDetails { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_zvyWpdE7Ed-BzquC8wXy7w_-1053648766")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation1? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_zvyWptE7Ed-BzquC8wXy7w_862111806")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SubscriptionBulkOrderV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SubscriptionBulkOrderV02Document ToDocument()
    {
        return new SubscriptionBulkOrderV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("setr.007.001.02");
    
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
        writer.WriteStartElement(null, "BlkOrdrDtls", xmlNamespace );
        BulkOrderDetails.Serialize(writer, xmlNamespace);
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
    public static SubscriptionBulkOrderV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SubscriptionBulkOrderV02"/>.
/// </summary>
[Serializable]
public partial record SubscriptionBulkOrderV02Document : IOuterDocument<SubscriptionBulkOrderV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.007.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SubscriptionBulkOrderV02"/> is required.
    /// </summary>
    [DataMember(Name=SubscriptionBulkOrderV02.XmlTag)]
    public required SubscriptionBulkOrderV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SubscriptionBulkOrderV02.XmlTag);
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
