﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SwitchOrderConfirmationV04.  ISO2002 ID# _Aab7DTbLEead9bDRE_1DAQ.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.setr.SwitchOrderConfirmationV04>;

namespace BeneficialStrategies.Iso20022.setr;


/// <summary>
/// This record is an implementation of the setr.015.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The SwitchOrderConfirmation message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to confirm the details of the execution of a previously received SwitchOrder instruction.
/// Usage
/// The SwitchOrderConfirmation message is used to confirm that all the legs of the previously instructed switch order have been executed. The reference of the switch order confirmation is identified in DealReference.
/// The reference of the original switch order is specified in OrderReference. The message identification of the SwitchOrder message in which the switch order was conveyed may also be quoted in RelatedReference but this is not recommended.
/// When the message is used to convey a confirmation amendment/s, the AmendmentIndicator must be present with the value ‘true’ or ‘1’. When this is the case, the message must only contain a confirmation amendment/s and not contain both a confirmation amendment/s and a ‘new’ confirmation/s.
/// </summary>
[Serializable]
[Description(@"Scope|The SwitchOrderConfirmation message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to confirm the details of the execution of a previously received SwitchOrder instruction.|Usage|The SwitchOrderConfirmation message is used to confirm that all the legs of the previously instructed switch order have been executed. The reference of the switch order confirmation is identified in DealReference.|The reference of the original switch order is specified in OrderReference. The message identification of the SwitchOrder message in which the switch order was conveyed may also be quoted in RelatedReference but this is not recommended.|When the message is used to convey a confirmation amendment/s, the AmendmentIndicator must be present with the value ‘true’ or ‘1’. When this is the case, the message must only contain a confirmation amendment/s and not contain both a confirmation amendment/s and a ‘new’ confirmation/s.")]
public partial record SwitchOrderConfirmationV04 : IOuterRecord<SwitchOrderConfirmationV04,SwitchOrderConfirmationV04Document>
    ,IIsoXmlSerilizable<SwitchOrderConfirmationV04>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.015.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SwtchOrdrConf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SwitchOrderConfirmationV04Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_Aab7FzbLEead9bDRE_1DAQ")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Aab7GTbLEead9bDRE_1DAQ")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference9? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Aab7GzbLEead9bDRE_1DAQ")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference8? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_Aab7HTbLEead9bDRE_1DAQ")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference8? RelatedReference { get; init; }
    
    /// <summary>
    /// Information related to a switch execution.
    /// </summary>
    [IsoId("_Aab7HzbLEead9bDRE_1DAQ")]
    [Description(@"Information related to a switch execution.")]
    [DataMember(Name="SwtchExctnDtls")]
    [XmlElement(ElementName="SwtchExctnDtls")]
    [Required]
    public required SwitchExecution7 SwitchExecutionDetails { get; init; }
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_Aab7ITbLEead9bDRE_1DAQ")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation4? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Aab7IzbLEead9bDRE_1DAQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SwitchOrderConfirmationV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SwitchOrderConfirmationV04Document ToDocument()
    {
        return new SwitchOrderConfirmationV04Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("SwtchOrdrConf");
    
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
        if (PoolReference is AdditionalReference9 PoolReferenceValue)
        {
            writer.WriteStartElement(null, "PoolRef", xmlNamespace );
            PoolReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousReference is AdditionalReference8 PreviousReferenceValue)
        {
            writer.WriteStartElement(null, "PrvsRef", xmlNamespace );
            PreviousReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RelatedReference is AdditionalReference8 RelatedReferenceValue)
        {
            writer.WriteStartElement(null, "RltdRef", xmlNamespace );
            RelatedReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SwtchExctnDtls", xmlNamespace );
        SwitchExecutionDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CopyDetails is CopyInformation4 CopyDetailsValue)
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
    public static SwitchOrderConfirmationV04 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SwitchOrderConfirmationV04"/>.
/// </summary>
[Serializable]
public partial record SwitchOrderConfirmationV04Document : IOuterDocument<SwitchOrderConfirmationV04>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.015.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SwitchOrderConfirmationV04"/> is required.
    /// </summary>
    [DataMember(Name=SwitchOrderConfirmationV04.XmlTag)]
    public required SwitchOrderConfirmationV04 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SwitchOrderConfirmationV04.XmlTag);
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
