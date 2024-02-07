﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for UnableToApplyV07.  ISO2002 ID# _eX_OLW2PEei3KuUgpx7Xcw.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.camt.UnableToApplyV07>;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// This record is an implementation of the camt.026.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The UnableToApply message is sent by a case creator or a case assigner to a case assignee. This message is used to initiate an investigation of a payment instruction that cannot be executed or reconciled.
/// Usage
/// The Unable To Apply case occurs in two situations:
/// - an agent cannot execute the payment instruction due to missing or incorrect information;
/// - a creditor cannot reconcile the payment entry as it is received unexpectedly, or missing or incorrect information prevents reconciliation.
/// The UnableToApply message:
/// - always follows the reverse route of the original payment instruction;
/// - must be forwarded to the preceding agents in the payment processing chain, where appropriate;
/// - covers one and only one payment instruction (or payment entry) at a time; if several payment instructions cannot be executed or several payment entries cannot be reconciled, then multiple UnableToApply messages must be sent.
/// Depending on what stage the payment is and what has been done to it, for example incorrect routing, errors/omissions when processing the instruction or even the absence of any error, the unable to apply case may lead to a:
/// - AdditionalPaymentInformation message, sent to the case creator/case assigner, if a truncation or omission in a payment instruction prevented reconciliation;
/// - CustomerPaymentCancellationRequest or FIToFIPaymentCancellationRequest message, sent to the subsequent agent in the payment processing chain, if the original payment instruction has been incorrectly routed through the chain of agents (this also entails a new corrected payment instruction being issued). Prior to sending the payment cancellation request, the agent should first send a resolution indicating that a cancellation will follow (CWFW);
/// - RequestToModifyPayment message, sent to the subsequent agent in the payment processing chain, if a truncation or omission has occurred during the processing of the original payment instruction. Prior to sending the modify payment request, the agent should first send a resolution indicating that a modification will follow (MWFW);
/// - DebitAuthorisationRequest message, sent to the case creator/case assigner, if the payment instruction has reached an incorrect creditor.
/// The UnableToApply message has the following main characteristics:
/// The case creator (the instructed party/creditor of a payment instruction) assigns a unique case identification and optionally the reason code for the UnableToApply message. This information will be passed unchanged to all subsequent case assignees.
/// The case creator specifies the identification of the underlying payment instruction. This identification needs to be updated by the subsequent case assigner(s) in order to match the one used with their case assignee(s).
/// The UnableToApply Justification element allows the assigner to indicate whether a specific element causes the unable to apply situation (incorrect element and/or mismatched element can be listed) or whether any supplementary information needs to be forwarded.
/// </summary>
[Serializable]
[Description(@"Scope|The UnableToApply message is sent by a case creator or a case assigner to a case assignee. This message is used to initiate an investigation of a payment instruction that cannot be executed or reconciled.|Usage|The Unable To Apply case occurs in two situations:|- an agent cannot execute the payment instruction due to missing or incorrect information;|- a creditor cannot reconcile the payment entry as it is received unexpectedly, or missing or incorrect information prevents reconciliation.|The UnableToApply message:|- always follows the reverse route of the original payment instruction;|- must be forwarded to the preceding agents in the payment processing chain, where appropriate;|- covers one and only one payment instruction (or payment entry) at a time; if several payment instructions cannot be executed or several payment entries cannot be reconciled, then multiple UnableToApply messages must be sent.|Depending on what stage the payment is and what has been done to it, for example incorrect routing, errors/omissions when processing the instruction or even the absence of any error, the unable to apply case may lead to a:|- AdditionalPaymentInformation message, sent to the case creator/case assigner, if a truncation or omission in a payment instruction prevented reconciliation;|- CustomerPaymentCancellationRequest or FIToFIPaymentCancellationRequest message, sent to the subsequent agent in the payment processing chain, if the original payment instruction has been incorrectly routed through the chain of agents (this also entails a new corrected payment instruction being issued). Prior to sending the payment cancellation request, the agent should first send a resolution indicating that a cancellation will follow (CWFW);|- RequestToModifyPayment message, sent to the subsequent agent in the payment processing chain, if a truncation or omission has occurred during the processing of the original payment instruction. Prior to sending the modify payment request, the agent should first send a resolution indicating that a modification will follow (MWFW);|- DebitAuthorisationRequest message, sent to the case creator/case assigner, if the payment instruction has reached an incorrect creditor.|The UnableToApply message has the following main characteristics:|The case creator (the instructed party/creditor of a payment instruction) assigns a unique case identification and optionally the reason code for the UnableToApply message. This information will be passed unchanged to all subsequent case assignees.|The case creator specifies the identification of the underlying payment instruction. This identification needs to be updated by the subsequent case assigner(s) in order to match the one used with their case assignee(s).|The UnableToApply Justification element allows the assigner to indicate whether a specific element causes the unable to apply situation (incorrect element and/or mismatched element can be listed) or whether any supplementary information needs to be forwarded.")]
public partial record UnableToApplyV07 : IOuterRecord<UnableToApplyV07,UnableToApplyV07Document>
    ,IIsoXmlSerilizable<UnableToApplyV07>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.026.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UblToApply";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => UnableToApplyV07Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.
    /// Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.
    /// </summary>
    [IsoId("_eX_OOW2PEei3KuUgpx7Xcw")]
    [Description(@"Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required CaseAssignment5 Assignment { get; init; }
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_eX_OO22PEei3KuUgpx7Xcw")]
    [Description(@"Identifies the investigation case.")]
    [DataMember(Name="Case")]
    [XmlElement(ElementName="Case")]
    public Case5? Case { get; init; }
    
    /// <summary>
    /// References the payment instruction or statement entry that a party is unable to execute or unable to reconcile.
    /// </summary>
    [IsoId("_eX_OPW2PEei3KuUgpx7Xcw")]
    [Description(@"References the payment instruction or statement entry that a party is unable to execute or unable to reconcile.")]
    [DataMember(Name="Undrlyg")]
    [XmlElement(ElementName="Undrlyg")]
    [Required]
    public required UnderlyingTransaction5Choice_ Underlying { get; init; }
    
    /// <summary>
    /// Explains the reason why the case creator is unable to apply the instruction.
    /// </summary>
    [IsoId("_eX_OP22PEei3KuUgpx7Xcw")]
    [Description(@"Explains the reason why the case creator is unable to apply the instruction.")]
    [DataMember(Name="Justfn")]
    [XmlElement(ElementName="Justfn")]
    [Required]
    public required UnableToApplyJustification3Choice_ Justification { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eX_OQW2PEei3KuUgpx7Xcw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="UnableToApplyV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public UnableToApplyV07Document ToDocument()
    {
        return new UnableToApplyV07Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("UblToApply");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Assgnmt", xmlNamespace );
        Assignment.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Case is Case5 CaseValue)
        {
            writer.WriteStartElement(null, "Case", xmlNamespace );
            CaseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Undrlyg", xmlNamespace );
        Underlying.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Justfn", xmlNamespace );
        Justification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static UnableToApplyV07 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="UnableToApplyV07"/>.
/// </summary>
[Serializable]
public partial record UnableToApplyV07Document : IOuterDocument<UnableToApplyV07>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="UnableToApplyV07"/> is required.
    /// </summary>
    [DataMember(Name=UnableToApplyV07.XmlTag)]
    public required UnableToApplyV07 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(UnableToApplyV07.XmlTag);
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
