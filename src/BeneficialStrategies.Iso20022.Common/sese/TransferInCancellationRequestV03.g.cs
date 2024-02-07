﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransferInCancellationRequestV03.  ISO2002 ID# _5Eu2kfpbEeCPwaG9zjUPNQ.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.sese.TransferInCancellationRequestV03>;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.006.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, a transfer agent, sends the TransferInCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent TransferInInstruction.
/// Usage
/// The TransferInCancellationRequest message is used to request cancellation of a previously sent TransferInInstruction.
/// There are two ways to specify the transfer cancellation request. Either:
/// - the transfer reference of the original transfer is quoted, or,
/// - all the details of the original transfer (this includes TransferReference) are quoted but this is not recommended.
/// The message identification of the TransferInInstruction message in which the transfer was conveyed may also be quoted in PreviousReference. It is also possible to request the cancellation of a TransferInInstruction message by quoting its message identification in PreviousReference.
/// </summary>
[Serializable]
[Description(@"Scope|An instructing party, for example, a transfer agent, sends the TransferInCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent TransferInInstruction.|Usage|The TransferInCancellationRequest message is used to request cancellation of a previously sent TransferInInstruction.|There are two ways to specify the transfer cancellation request. Either:|- the transfer reference of the original transfer is quoted, or,|- all the details of the original transfer (this includes TransferReference) are quoted but this is not recommended.|The message identification of the TransferInInstruction message in which the transfer was conveyed may also be quoted in PreviousReference. It is also possible to request the cancellation of a TransferInInstruction message by quoting its message identification in PreviousReference.")]
public partial record TransferInCancellationRequestV03 : IOuterRecord<TransferInCancellationRequestV03,TransferInCancellationRequestV03Document>
    ,IIsoXmlSerilizable<TransferInCancellationRequestV03>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.006.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfInCxlReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => TransferInCancellationRequestV03Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_5Eu2nfpbEeCPwaG9zjUPNQ")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Reference to the transaction identifier issued by the counterparty. Building block may also be used to reference a previous transaction, or tie a set of messages together.
    /// </summary>
    [IsoId("_OLS9P_r3EeCJc7cZxzE2fg")]
    [Description(@"Reference to the transaction identifier issued by the counterparty. Building block may also be used to reference a previous transaction, or tie a set of messages together.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    [Required]
    public required References11 References { get; init; }
    
    /// <summary>
    /// Reference of the transfer to be cancelled.
    /// </summary>
    [IsoId("_5Eu2rfpbEeCPwaG9zjUPNQ")]
    [Description(@"Reference of the transfer to be cancelled.")]
    [DataMember(Name="CxlByRef")]
    [XmlElement(ElementName="CxlByRef")]
    public TransferReference1? CancellationByReference { get; init; }
    
    /// <summary>
    /// The transfer in request message to cancel.
    /// </summary>
    [IsoId("_5Eu2sfpbEeCPwaG9zjUPNQ")]
    [Description(@"The transfer in request message to cancel.")]
    [DataMember(Name="CxlByTrfInDtls")]
    [XmlElement(ElementName="CxlByTrfInDtls")]
    public TransferIn5? CancellationByTransferInDetails { get; init; }
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_5Eu2tfpbEeCPwaG9zjUPNQ")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransferInCancellationRequestV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransferInCancellationRequestV03Document ToDocument()
    {
        return new TransferInCancellationRequestV03Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("TrfInCxlReq");
    
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
        writer.WriteStartElement(null, "Refs", xmlNamespace );
        References.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CancellationByReference is TransferReference1 CancellationByReferenceValue)
        {
            writer.WriteStartElement(null, "CxlByRef", xmlNamespace );
            CancellationByReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CancellationByTransferInDetails is TransferIn5 CancellationByTransferInDetailsValue)
        {
            writer.WriteStartElement(null, "CxlByTrfInDtls", xmlNamespace );
            CancellationByTransferInDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CopyDetails is CopyInformation2 CopyDetailsValue)
        {
            writer.WriteStartElement(null, "CpyDtls", xmlNamespace );
            CopyDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TransferInCancellationRequestV03 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransferInCancellationRequestV03"/>.
/// </summary>
[Serializable]
public partial record TransferInCancellationRequestV03Document : IOuterDocument<TransferInCancellationRequestV03>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.006.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransferInCancellationRequestV03"/> is required.
    /// </summary>
    [DataMember(Name=TransferInCancellationRequestV03.XmlTag)]
    public required TransferInCancellationRequestV03 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(TransferInCancellationRequestV03.XmlTag);
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
