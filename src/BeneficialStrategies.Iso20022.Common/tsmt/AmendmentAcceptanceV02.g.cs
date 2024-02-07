﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AmendmentAcceptanceV02.  ISO2002 ID# _j0IVwtE8Ed-BzquC8wXy7w_1561210255.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.tsmt.AmendmentAcceptanceV02>;

namespace BeneficialStrategies.Iso20022.tsmt;


/// <summary>
/// This record is an implementation of the tsmt.005.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AmendmentAcceptance message is sent by the party requested to accept or reject an amendment to the matching application.
/// The message is used to accept an amendment request.
/// Usage
/// The AmendmentAcceptance message can be sent by the party requested to accept or reject an amendment to inform that it accepts the requested amendment.
/// The message can be sent in response to a FullPushThroughReport and DeltaReport message conveying the details of a BaselineAmendmentRequest message.
/// The rejection of an amendment request can be achieved by sending an AmendmentRejection message.
/// </summary>
[Serializable]
[Description(@"Scope|The AmendmentAcceptance message is sent by the party requested to accept or reject an amendment to the matching application.|The message is used to accept an amendment request.|Usage|The AmendmentAcceptance message can be sent by the party requested to accept or reject an amendment to inform that it accepts the requested amendment.|The message can be sent in response to a FullPushThroughReport and DeltaReport message conveying the details of a BaselineAmendmentRequest message.|The rejection of an amendment request can be achieved by sending an AmendmentRejection message.")]
public partial record AmendmentAcceptanceV02 : IOuterRecord<AmendmentAcceptanceV02,AmendmentAcceptanceV02Document>
    ,IIsoXmlSerilizable<AmendmentAcceptanceV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.005.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AmdmntAccptnc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AmendmentAcceptanceV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identifies the acceptance message.
    /// </summary>
    [IsoId("_j0IVw9E8Ed-BzquC8wXy7w_1561211944")]
    [Description(@"Identifies the acceptance message.")]
    [DataMember(Name="AccptncId")]
    [XmlElement(ElementName="AccptncId")]
    [Required]
    public required MessageIdentification1 AcceptanceIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_j0IVxNE8Ed-BzquC8wXy7w_1561211914")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }
    
    /// <summary>
    /// Reference to the identification of the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_j0IVxdE8Ed-BzquC8wXy7w_1561212005")]
    [Description(@"Reference to the identification of the transaction for the requesting financial institution.")]
    [DataMember(Name="SubmitrTxRef")]
    [XmlElement(ElementName="SubmitrTxRef")]
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; }
    
    /// <summary>
    /// Reference to the identification of the delta report that contained the amendment.
    /// </summary>
    [IsoId("_j0IVxtE8Ed-BzquC8wXy7w_1561211883")]
    [Description(@"Reference to the identification of the delta report that contained the amendment.")]
    [DataMember(Name="DltaRptRef")]
    [XmlElement(ElementName="DltaRptRef")]
    [Required]
    public required MessageIdentification1 DeltaReportReference { get; init; }
    
    /// <summary>
    /// Sequence number of the accepted baseline amendment.
    /// </summary>
    [IsoId("_j0IVx9E8Ed-BzquC8wXy7w_1561211975")]
    [Description(@"Sequence number of the accepted baseline amendment.")]
    [DataMember(Name="AccptdAmdmntNb")]
    [XmlElement(ElementName="AccptdAmdmntNb")]
    [Required]
    public required Count1 AcceptedAmendmentNumber { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AmendmentAcceptanceV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AmendmentAcceptanceV02Document ToDocument()
    {
        return new AmendmentAcceptanceV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("AmdmntAccptnc");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "AccptncId", xmlNamespace );
        AcceptanceIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        TransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SubmitterTransactionReference is SimpleIdentificationInformation SubmitterTransactionReferenceValue)
        {
            writer.WriteStartElement(null, "SubmitrTxRef", xmlNamespace );
            SubmitterTransactionReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "DltaRptRef", xmlNamespace );
        DeltaReportReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AccptdAmdmntNb", xmlNamespace );
        AcceptedAmendmentNumber.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static AmendmentAcceptanceV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AmendmentAcceptanceV02"/>.
/// </summary>
[Serializable]
public partial record AmendmentAcceptanceV02Document : IOuterDocument<AmendmentAcceptanceV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.005.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AmendmentAcceptanceV02"/> is required.
    /// </summary>
    [DataMember(Name=AmendmentAcceptanceV02.XmlTag)]
    public required AmendmentAcceptanceV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(AmendmentAcceptanceV02.XmlTag);
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
