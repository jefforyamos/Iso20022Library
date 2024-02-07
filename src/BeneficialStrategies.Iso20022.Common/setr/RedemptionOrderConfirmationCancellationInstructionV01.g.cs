﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RedemptionOrderConfirmationCancellationInstructionV01.  ISO2002 ID# _t5eDiNE7Ed-BzquC8wXy7w_-947588011.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.setr.RedemptionOrderConfirmationCancellationInstructionV01>;

namespace BeneficialStrategies.Iso20022.setr;


/// <summary>
/// This record is an implementation of the setr.051.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the RedemptionOrderConfirmationCancellationInstruction message to the instructing party, for example, an investment manager or its authorised representative to cancel a previously sent RedemptionOrderConfirmation message.
/// Usage
/// The RedemptionOrderConfirmationCancellationInstruction message is used to cancel one or more previously sent redemption order confirmations. The amendment indicator element is used to specify whether the redemption order confirmation cancellation is to be followed by a RedemptionOrderConfirmationAmendment.
/// The RedemptionOrderConfirmationCancellationInstruction message is used to either:
/// - cancel an entire RedemptionOrderConfirmation messae, that is, all the individual order confirmations that it contained, or,
/// - request the cancellation of one or more individual confirmations.
/// There are two ways to use the message.
/// (1) When the RedemptionOrderConfirmationCancellationInstruction message is used to cancel an entire message, this can be done by either:
/// - quoting the business references, for example, OrderReference, Deal Reference, of all the individual order confirmations listed in the RedemptionOrderConfirmation message, or,
/// - quoting the details of all the individual order confirmations (this includes the OrderReference and DealReference) listed in RedemptionOrderConfirmation message but this is not recommended.
/// The message identification of the RedemptionOrderConfirmation message may also be quoted in PreviousReference.
/// It is also possible to instruct the cancellation of an entire confirmation message by quoting its message identification in PreviousReference, but this is not recommended.
/// (2) When the RedemptionOrderConfirmationCancellationInstruction message is used to cancel one or more individual order confirmations, this can be done by either:
/// - quoting the business references, for example, OrderReference, Deal Reference, of each individual order confirmation listed in the RedemptionOrderConfirmation message, or,
/// - quoting the details of each individual order execution (this includes the OrderReference and DealReference) listed in RedemptionOrderConfirmation message but this is not recommended.
/// The message identification of the RedemptionOrderConfirmation message in which the individual order confirmation was conveyed may also be quoted in PreviousReference.
/// The rejection or acceptance of a RedemptionOrderConfirmationCancellationInstruction is made using an OrderConfirmationStatusReport message.
/// </summary>
[Serializable]
[Description(@"Scope|An executing party, for example, a transfer agent, sends the RedemptionOrderConfirmationCancellationInstruction message to the instructing party, for example, an investment manager or its authorised representative to cancel a previously sent RedemptionOrderConfirmation message.|Usage|The RedemptionOrderConfirmationCancellationInstruction message is used to cancel one or more previously sent redemption order confirmations. The amendment indicator element is used to specify whether the redemption order confirmation cancellation is to be followed by a RedemptionOrderConfirmationAmendment.|The RedemptionOrderConfirmationCancellationInstruction message is used to either:|- cancel an entire RedemptionOrderConfirmation messae, that is, all the individual order confirmations that it contained, or,|- request the cancellation of one or more individual confirmations.|There are two ways to use the message.|(1) When the RedemptionOrderConfirmationCancellationInstruction message is used to cancel an entire message, this can be done by either:|- quoting the business references, for example, OrderReference, Deal Reference, of all the individual order confirmations listed in the RedemptionOrderConfirmation message, or,|- quoting the details of all the individual order confirmations (this includes the OrderReference and DealReference) listed in RedemptionOrderConfirmation message but this is not recommended.|The message identification of the RedemptionOrderConfirmation message may also be quoted in PreviousReference.|It is also possible to instruct the cancellation of an entire confirmation message by quoting its message identification in PreviousReference, but this is not recommended.|(2) When the RedemptionOrderConfirmationCancellationInstruction message is used to cancel one or more individual order confirmations, this can be done by either:|- quoting the business references, for example, OrderReference, Deal Reference, of each individual order confirmation listed in the RedemptionOrderConfirmation message, or,|- quoting the details of each individual order execution (this includes the OrderReference and DealReference) listed in RedemptionOrderConfirmation message but this is not recommended.|The message identification of the RedemptionOrderConfirmation message in which the individual order confirmation was conveyed may also be quoted in PreviousReference.|The rejection or acceptance of a RedemptionOrderConfirmationCancellationInstruction is made using an OrderConfirmationStatusReport message.")]
public partial record RedemptionOrderConfirmationCancellationInstructionV01 : IOuterRecord<RedemptionOrderConfirmationCancellationInstructionV01,RedemptionOrderConfirmationCancellationInstructionV01Document>
    ,IIsoXmlSerilizable<RedemptionOrderConfirmationCancellationInstructionV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.051.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RedOrdrConfCxlInstrV01";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => RedemptionOrderConfirmationCancellationInstructionV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_t5eDidE7Ed-BzquC8wXy7w_-2099190872")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_t5eDitE7Ed-BzquC8wXy7w_-2101963887")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_t5eDi9E7Ed-BzquC8wXy7w_-2101960811")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_t5eDjNE7Ed-BzquC8wXy7w_-2101038795")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }
    
    /// <summary>
    /// References of the orders confirmations to be cancelled.
    /// </summary>
    [IsoId("_t5n0gNE7Ed-BzquC8wXy7w_-2016074289")]
    [Description(@"References of the orders confirmations to be cancelled.")]
    [DataMember(Name="CxlByRef")]
    [XmlElement(ElementName="CxlByRef")]
    public InvestmentFundOrderExecution1? CancellationByReference { get; init; }
    
    /// <summary>
    /// Common information related to all the orders confirmations to be cancelled.
    /// </summary>
    [IsoId("_t5n0gdE7Ed-BzquC8wXy7w_-2017920422")]
    [Description(@"Common information related to all the orders confirmations to be cancelled.")]
    [DataMember(Name="CxlByOrdrConfDtls")]
    [XmlElement(ElementName="CxlByOrdrConfDtls")]
    public RedemptionOrderConfirmation1? CancellationByOrderConfirmationDetails { get; init; }
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_t5n0gtE7Ed-BzquC8wXy7w_-2100115835")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RedemptionOrderConfirmationCancellationInstructionV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RedemptionOrderConfirmationCancellationInstructionV01Document ToDocument()
    {
        return new RedemptionOrderConfirmationCancellationInstructionV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("RedOrdrConfCxlInstrV01");
    
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
        if (CancellationByOrderConfirmationDetails is RedemptionOrderConfirmation1 CancellationByOrderConfirmationDetailsValue)
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
    public static RedemptionOrderConfirmationCancellationInstructionV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RedemptionOrderConfirmationCancellationInstructionV01"/>.
/// </summary>
[Serializable]
public partial record RedemptionOrderConfirmationCancellationInstructionV01Document : IOuterDocument<RedemptionOrderConfirmationCancellationInstructionV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.051.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RedemptionOrderConfirmationCancellationInstructionV01"/> is required.
    /// </summary>
    [DataMember(Name=RedemptionOrderConfirmationCancellationInstructionV01.XmlTag)]
    public required RedemptionOrderConfirmationCancellationInstructionV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(RedemptionOrderConfirmationCancellationInstructionV01.XmlTag);
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
