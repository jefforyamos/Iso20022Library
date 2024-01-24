﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MandateInitiationRequestV07.  ISO2002 ID# _rUYN39cBEeq_l4BJLVUF2Q.
//
namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// Scope
/// The MandateInitiationRequest message is sent by the initiator of the request to his agent. The initiator can either be the debtor or the creditor.
/// The MandateInitiationRequest message is forwarded by the agent of the initiator to the agent of the counterparty.
/// The MandateInitiationRequest message is used to setup the instruction that allows the debtor agent to accept instructions from the creditor, through the creditor agent, to debit the account of the debtor.
/// Usage
/// The MandateInitiationRequest message can contain one or more request(s) to setup a specific mandate.
/// The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.
/// The MandateInitiationRequest message can be used in domestic and cross-border scenarios.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MandateInitiationRequest message is sent by the initiator of the request to his agent. The initiator can either be the debtor or the creditor.|The MandateInitiationRequest message is forwarded by the agent of the initiator to the agent of the counterparty.|The MandateInitiationRequest message is used to setup the instruction that allows the debtor agent to accept instructions from the creditor, through the creditor agent, to debit the account of the debtor.|Usage|The MandateInitiationRequest message can contain one or more request(s) to setup a specific mandate.|The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.|The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.|The MandateInitiationRequest message can be used in domestic and cross-border scenarios.")]
public partial record MandateInitiationRequestV07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MndtInitnReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MandateInitiationRequestV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MandateInitiationRequestV07Document ToDocument()
    {
        return new MandateInitiationRequestV07Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The MandateInitiationRequest message is sent by the initiator of the request to his agent. The initiator can either be the debtor or the creditor.
/// The MandateInitiationRequest message is forwarded by the agent of the initiator to the agent of the counterparty.
/// The MandateInitiationRequest message is used to setup the instruction that allows the debtor agent to accept instructions from the creditor, through the creditor agent, to debit the account of the debtor.
/// Usage
/// The MandateInitiationRequest message can contain one or more request(s) to setup a specific mandate.
/// The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.
/// The MandateInitiationRequest message can be used in domestic and cross-border scenarios.
/// This is the outer document that contains <seealso cref="MandateInitiationRequestV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MandateInitiationRequestV07Document : IOuterDocument<MandateInitiationRequestV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.009.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MandateInitiationRequestV07"/> is required.
    /// </summary>
    public required MandateInitiationRequestV07 Message { get; init; }
}
