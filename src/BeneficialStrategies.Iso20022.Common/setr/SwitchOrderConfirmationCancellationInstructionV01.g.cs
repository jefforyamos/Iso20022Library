﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SwitchOrderConfirmationCancellationInstructionV01.  ISO2002 ID# _64NK2NE7Ed-BzquC8wXy7w_1641853769.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.setr.SwitchOrderConfirmationCancellationInstructionV01>;

namespace BeneficialStrategies.Iso20022.setr;


/// <summary>
/// This record is an implementation of the setr.055.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the SwitchOrderConfirmationCancellationInstruction message to the instructing party, for example, an investment manager or its authorised representative to amend a previously sent SwitchOrderConfirmation message.
/// Usage
/// The SwitchOrderConfirmationCancellationInstruction message is used to cancel a previously sent SwitchOrderConfirmation.
/// The amendment indicator element is used to specify whether the switch order confirmation cancellation is to be followed by a switch order confirmation amendment.
/// There are two ways to specify the switch order confirmation cancellation. Either:
/// - the business references, for example, OrderReference, DealReference, of the switch order confirmation are quoted, or,
/// - all the details of the switch order confirmation (this includes the OrderReference and DealReference) are quoted, but this is not recommended.
/// The message identification of the SwitchOrderConfirmation message may also be quoted in PreviousReference.
/// It is also possible to instruct the cancellation of the confirmation message by quoting its message identification in PreviousReference, but this is not recommended.
/// </summary>
[Serializable]
[Description(@"Scope|An executing party, for example, a transfer agent, sends the SwitchOrderConfirmationCancellationInstruction message to the instructing party, for example, an investment manager or its authorised representative to amend a previously sent SwitchOrderConfirmation message.|Usage|The SwitchOrderConfirmationCancellationInstruction message is used to cancel a previously sent SwitchOrderConfirmation.|The amendment indicator element is used to specify whether the switch order confirmation cancellation is to be followed by a switch order confirmation amendment.|There are two ways to specify the switch order confirmation cancellation. Either:|- the business references, for example, OrderReference, DealReference, of the switch order confirmation are quoted, or,|- all the details of the switch order confirmation (this includes the OrderReference and DealReference) are quoted, but this is not recommended.|The message identification of the SwitchOrderConfirmation message may also be quoted in PreviousReference.|It is also possible to instruct the cancellation of the confirmation message by quoting its message identification in PreviousReference, but this is not recommended.")]
public partial record SwitchOrderConfirmationCancellationInstructionV01 : IOuterRecord<SwitchOrderConfirmationCancellationInstructionV01,SwitchOrderConfirmationCancellationInstructionV01Document>
    ,IIsoXmlSerilizable<SwitchOrderConfirmationCancellationInstructionV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.055.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SwtchOrdrConfCxlInstrV01";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SwitchOrderConfirmationCancellationInstructionV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_64NK2dE7Ed-BzquC8wXy7w_2085142778")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_64W70NE7Ed-BzquC8wXy7w_1790539569")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_64W70dE7Ed-BzquC8wXy7w_1790540438")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_64W70tE7Ed-BzquC8wXy7w_1790541008")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }
    
    /// <summary>
    /// References of the switch orders to be cancelled.
    /// </summary>
    [IsoId("_64W709E7Ed-BzquC8wXy7w_2085142734")]
    [Description(@"References of the switch orders to be cancelled.")]
    [DataMember(Name="CxlByRef")]
    [XmlElement(ElementName="CxlByRef")]
    public InvestmentFundOrderExecution1? CancellationByReference { get; init; }
    
    /// <summary>
    /// Common information related to all the switch orders confirmations to be cancelled.
    /// </summary>
    [IsoId("_64W71NE7Ed-BzquC8wXy7w_2077756022")]
    [Description(@"Common information related to all the switch orders confirmations to be cancelled.")]
    [DataMember(Name="CxlByOrdrConfDtls")]
    [XmlElement(ElementName="CxlByOrdrConfDtls")]
    public SwitchOrderConfirmation1? CancellationByOrderConfirmationDetails { get; init; }
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_64W71dE7Ed-BzquC8wXy7w_1791462023")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SwitchOrderConfirmationCancellationInstructionV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SwitchOrderConfirmationCancellationInstructionV01Document ToDocument()
    {
        return new SwitchOrderConfirmationCancellationInstructionV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("SwtchOrdrConfCxlInstrV01");
    
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
        if (CancellationByReference is InvestmentFundOrderExecution1 CancellationByReferenceValue)
        {
            writer.WriteStartElement(null, "CxlByRef", xmlNamespace );
            CancellationByReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CancellationByOrderConfirmationDetails is SwitchOrderConfirmation1 CancellationByOrderConfirmationDetailsValue)
        {
            writer.WriteStartElement(null, "CxlByOrdrConfDtls", xmlNamespace );
            CancellationByOrderConfirmationDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CopyDetails is CopyInformation2 CopyDetailsValue)
        {
            writer.WriteStartElement(null, "CpyDtls", xmlNamespace );
            CopyDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SwitchOrderConfirmationCancellationInstructionV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SwitchOrderConfirmationCancellationInstructionV01"/>.
/// </summary>
[Serializable]
public partial record SwitchOrderConfirmationCancellationInstructionV01Document : IOuterDocument<SwitchOrderConfirmationCancellationInstructionV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.055.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SwitchOrderConfirmationCancellationInstructionV01"/> is required.
    /// </summary>
    [DataMember(Name=SwitchOrderConfirmationCancellationInstructionV01.XmlTag)]
    public required SwitchOrderConfirmationCancellationInstructionV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SwitchOrderConfirmationCancellationInstructionV01.XmlTag);
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
