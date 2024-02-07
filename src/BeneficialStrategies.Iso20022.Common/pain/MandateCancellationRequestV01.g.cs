﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MandateCancellationRequestV01.  ISO2002 ID# _GYEMStEvEd-BzquC8wXy7w_-879561385.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.pain.MandateCancellationRequestV01>;

namespace BeneficialStrategies.Iso20022.pain;


/// <summary>
/// This record is an implementation of the pain.011.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MandateCancellationRequest message is sent by the initiator of the request to his agent. The initiator can either be the debtor or the creditor.
/// The MandateCancellationRequest message is forwarded by the agent of the initiator to the agent of the counterparty.
/// A MandateCancellationRequest message is used to request the cancellation of an existing mandate. If accepted, this MandateCancellationRequest message together with the MandateAcceptanceReport message confirming the acceptance will be considered a valid cancellation of an existing mandate, agreed upon by all parties.
/// Usage
/// The MandateCancellationRequest message can contain only one request to cancel one specific mandate.
/// The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.
/// The MandateCancellationRequest message can be used in domestic and cross-border scenarios.
/// </summary>
[Serializable]
[Description(@"Scope|The MandateCancellationRequest message is sent by the initiator of the request to his agent. The initiator can either be the debtor or the creditor.|The MandateCancellationRequest message is forwarded by the agent of the initiator to the agent of the counterparty.|A MandateCancellationRequest message is used to request the cancellation of an existing mandate. If accepted, this MandateCancellationRequest message together with the MandateAcceptanceReport message confirming the acceptance will be considered a valid cancellation of an existing mandate, agreed upon by all parties.|Usage|The MandateCancellationRequest message can contain only one request to cancel one specific mandate.|The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.|The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.|The MandateCancellationRequest message can be used in domestic and cross-border scenarios.")]
public partial record MandateCancellationRequestV01 : IOuterRecord<MandateCancellationRequestV01,MandateCancellationRequestV01Document>
    ,IIsoXmlSerilizable<MandateCancellationRequestV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.011.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MndtCxlReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MandateCancellationRequestV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the cancellation of the mandate, but which are not part of the mandate.
    /// </summary>
    [IsoId("_GYEMS9EvEd-BzquC8wXy7w_-1953287668")]
    [Description(@"Set of characteristics to identify the message and parties playing a role in the cancellation of the mandate, but which are not part of the mandate.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader31 GroupHeader { get; init; }
    
    /// <summary>
    /// Set of elements used to provide details on the cancellation request.
    /// </summary>
    [IsoId("_GYEMTNEvEd-BzquC8wXy7w_-1941282874")]
    [Description(@"Set of elements used to provide details on the cancellation request.")]
    [DataMember(Name="UndrlygCxlDtls")]
    [XmlElement(ElementName="UndrlygCxlDtls")]
    [Required]
    public required MandateCancellation1 UnderlyingCancellationDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MandateCancellationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MandateCancellationRequestV01Document ToDocument()
    {
        return new MandateCancellationRequestV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("MndtCxlReq");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "GrpHdr", xmlNamespace );
        GroupHeader.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "UndrlygCxlDtls", xmlNamespace );
        UnderlyingCancellationDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static MandateCancellationRequestV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MandateCancellationRequestV01"/>.
/// </summary>
[Serializable]
public partial record MandateCancellationRequestV01Document : IOuterDocument<MandateCancellationRequestV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.011.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MandateCancellationRequestV01"/> is required.
    /// </summary>
    [DataMember(Name=MandateCancellationRequestV01.XmlTag)]
    public required MandateCancellationRequestV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(MandateCancellationRequestV01.XmlTag);
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
