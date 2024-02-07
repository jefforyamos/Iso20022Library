﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestToModifyPayment.  ISO2002 ID# _TqYjoNE_Ed-BzquC8wXy7w_-1237266490.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.camt.RequestToModifyPayment>;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// This record is an implementation of the camt.007.002.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Request To Modify Payment message is sent by a case creator/case assigner to a case assignee.
/// This message is used to request the modification of characteristics of an original payment instruction.
/// Usage
/// The Request To Modify Payment message must be answered with a:
/// - Resolution Of Investigation message with a positive final outcome when the case assignee can perform the requested modification
/// - Resolution Of Investigation message with a negative final outcome when the case assignee may perform the requested modification but fails to do so (too late, irrevocable instruction, one requested element cannot be modified.)
/// - Reject Case Assignment message when the case assignee is unable or not authorised to perform the requested modification
/// - Notification Of Case Assignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.
/// The Request To Modify Payment message covers one and only one original instruction at a time. If several original payment instructions need to be modified, then multiple Request To Modify Payment messages must be sent.
/// The Request To Modify Payment message can be sent to request the modification of one or several elements of the original payment instruction. If many elements need to be modified, it is recommended to cancel the original payment instruction and initiate a new one.
/// The Request To Modify Payment must be processed on an all or nothing basis. If one of the elements to be modified cannot be altered, the assignment must be rejected in full by means of a negative Resolution Of Investigation message. (See section on Resolution Of Investigation for more details.)
/// The Request To Modify Payment message must never be sent to request the modification of the currency of the original payment instruction. If the currency is wrong, use Request To Cancel Payment message to cancel it and issue and a new payment instruction.
/// The Request To Modify Payment message may be forwarded to subsequent case assignee(s).
/// When a Request To Modify Payment message is used to decrease the amount of the original payment instruction, the modification will trigger a return of funds from the case assignee to the case creator. The assignee may indicate, within the Resolution Of Investigation message, the amount to be returned, the date it is or will be returned and the channel through which the return will be done.
/// The Request To Modify Payment message must never be sent to request the increase of the amount of the original payment instruction. To increase the amount in a payment, the debtor can do one of the following:
/// - Cancel the first payment using a Request To Cancel Payment message and make a new payment with a higher and correct amount.
/// - Simply send a second payment with the supplementary amount.
/// Depending on the requested modification(s) and the processing stage of the original payment instruction, the processing of a request to modify payment case may end with one of the following:
/// - an Additional Payment Information message sent to the creditor of the original payment instruction
/// - a Debit Authorisation Request message sent to the creditor of the original payment instruction
/// - a Request To Cancel Payment message sent to a subsequent case assignee
/// The Request To Modify Payment message can be sent to correct characteristics of an original payment instruction following receipt of an Unable To Apply message. In this scenario, the case identification will remain the same.
/// The RequestToModifyPayment message has the following main characteristics:
/// The case creator assigns a unique case identification. This information will be passed unchanged to all subsequent case assignee(s).
/// Lowering the amount of an original payment instruction for which cover is provided by a separate instruction will systematically mean the modification of the whole transaction, including the cover. The case assignee performing the amount modification must initiate the return of funds in excess to the case creator.
/// The modification of the agent's or agents' information on an original payment instruction for which cover is provided by a separate instruction will systematically mean the whole transaction is modified, i.e., the cover is executed through the agent(s) mentioned in the Request To Modify Payment message. The cover payment must not be modified separately.
/// The modification of a payment instruction can be initiated by either the debtor or any subsequent agent in the payment processing chain.
/// The case creator provides the information to be modified in line with agreements made with the case assignee. If the case assignee needs in turn to assign the case to a subsequent case assignee, the requested modification(s) must be in line with the agreement made with the next case assignee and a Notification Of Case Assignment message must be sent to the case assigner. Otherwise, the request to modify payment case must be rejected (by means of a negative Resolution Of Investigation message).
/// </summary>
[Serializable]
[Description(@"Scope|The Request To Modify Payment message is sent by a case creator/case assigner to a case assignee.|This message is used to request the modification of characteristics of an original payment instruction.|Usage|The Request To Modify Payment message must be answered with a:|- Resolution Of Investigation message with a positive final outcome when the case assignee can perform the requested modification|- Resolution Of Investigation message with a negative final outcome when the case assignee may perform the requested modification but fails to do so (too late, irrevocable instruction, one requested element cannot be modified.)|- Reject Case Assignment message when the case assignee is unable or not authorised to perform the requested modification|- Notification Of Case Assignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.|The Request To Modify Payment message covers one and only one original instruction at a time. If several original payment instructions need to be modified, then multiple Request To Modify Payment messages must be sent.|The Request To Modify Payment message can be sent to request the modification of one or several elements of the original payment instruction. If many elements need to be modified, it is recommended to cancel the original payment instruction and initiate a new one.|The Request To Modify Payment must be processed on an all or nothing basis. If one of the elements to be modified cannot be altered, the assignment must be rejected in full by means of a negative Resolution Of Investigation message. (See section on Resolution Of Investigation for more details.)|The Request To Modify Payment message must never be sent to request the modification of the currency of the original payment instruction. If the currency is wrong, use Request To Cancel Payment message to cancel it and issue and a new payment instruction.|The Request To Modify Payment message may be forwarded to subsequent case assignee(s).|When a Request To Modify Payment message is used to decrease the amount of the original payment instruction, the modification will trigger a return of funds from the case assignee to the case creator. The assignee may indicate, within the Resolution Of Investigation message, the amount to be returned, the date it is or will be returned and the channel through which the return will be done.|The Request To Modify Payment message must never be sent to request the increase of the amount of the original payment instruction. To increase the amount in a payment, the debtor can do one of the following:|- Cancel the first payment using a Request To Cancel Payment message and make a new payment with a higher and correct amount.|- Simply send a second payment with the supplementary amount.|Depending on the requested modification(s) and the processing stage of the original payment instruction, the processing of a request to modify payment case may end with one of the following:|- an Additional Payment Information message sent to the creditor of the original payment instruction|- a Debit Authorisation Request message sent to the creditor of the original payment instruction|- a Request To Cancel Payment message sent to a subsequent case assignee|The Request To Modify Payment message can be sent to correct characteristics of an original payment instruction following receipt of an Unable To Apply message. In this scenario, the case identification will remain the same.|The RequestToModifyPayment message has the following main characteristics:|The case creator assigns a unique case identification. This information will be passed unchanged to all subsequent case assignee(s).|Lowering the amount of an original payment instruction for which cover is provided by a separate instruction will systematically mean the modification of the whole transaction, including the cover. The case assignee performing the amount modification must initiate the return of funds in excess to the case creator.|The modification of the agent's or agents' information on an original payment instruction for which cover is provided by a separate instruction will systematically mean the whole transaction is modified, i.e., the cover is executed through the agent(s) mentioned in the Request To Modify Payment message. The cover payment must not be modified separately.|The modification of a payment instruction can be initiated by either the debtor or any subsequent agent in the payment processing chain.|The case creator provides the information to be modified in line with agreements made with the case assignee. If the case assignee needs in turn to assign the case to a subsequent case assignee, the requested modification(s) must be in line with the agreement made with the next case assignee and a Notification Of Case Assignment message must be sent to the case assigner. Otherwise, the request to modify payment case must be rejected (by means of a negative Resolution Of Investigation message).")]
public partial record RequestToModifyPayment : IOuterRecord<RequestToModifyPayment,RequestToModifyPaymentDocument>
    ,IIsoXmlSerilizable<RequestToModifyPayment>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.007.002.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "camt.007.002.01";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => RequestToModifyPaymentDocument.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identifies the assignment.
    /// </summary>
    [IsoId("_TqYjodE_Ed-BzquC8wXy7w_515281163")]
    [Description(@"Identifies the assignment.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required CaseAssignment Assignment { get; init; }
    
    /// <summary>
    /// Identifies the case.
    /// </summary>
    [IsoId("_TqYjotE_Ed-BzquC8wXy7w_528211388")]
    [Description(@"Identifies the case.")]
    [DataMember(Name="Case")]
    [XmlElement(ElementName="Case")]
    [Required]
    public required Case Case { get; init; }
    
    /// <summary>
    /// Identifies the Payment Transaction to modify.
    /// </summary>
    [IsoId("_TqYjo9E_Ed-BzquC8wXy7w_742468770")]
    [Description(@"Identifies the Payment Transaction to modify.")]
    [DataMember(Name="Undrlyg")]
    [XmlElement(ElementName="Undrlyg")]
    [Required]
    public required PaymentInstructionExtract Underlying { get; init; }
    
    /// <summary>
    /// </summary>
    [IsoId("_TqYjpNE_Ed-BzquC8wXy7w_800648039")]
    [Description(@"")]
    [DataMember(Name="Mod")]
    [XmlElement(ElementName="Mod")]
    [Required]
    public required RequestedModification Modification { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RequestToModifyPaymentDocument"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestToModifyPaymentDocument ToDocument()
    {
        return new RequestToModifyPaymentDocument { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("camt.007.002.01");
    
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
        writer.WriteStartElement(null, "Case", xmlNamespace );
        Case.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Undrlyg", xmlNamespace );
        Underlying.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Mod", xmlNamespace );
        Modification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static RequestToModifyPayment Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RequestToModifyPayment"/>.
/// </summary>
[Serializable]
public partial record RequestToModifyPaymentDocument : IOuterDocument<RequestToModifyPayment>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.007.002.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RequestToModifyPayment"/> is required.
    /// </summary>
    [DataMember(Name=RequestToModifyPayment.XmlTag)]
    public required RequestToModifyPayment Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(RequestToModifyPayment.XmlTag);
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
