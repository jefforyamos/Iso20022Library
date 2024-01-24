﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesMessageCancellationAdvice002V05.  ISO2002 ID# _6EvMIZNLEeWGlc8L7oPDIg.
//
namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// Scope
/// An account servicer sends a SecuritiesMessageCancellationAdvice to an account owner to inform of the cancellation of a securities message previously sent by an account servicer. 
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or 
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// Usage
/// The previously sent message may be:
/// - a securities settlement transaction confirmation
/// - a report (transactions, pending transactions, allegements, accounting and custody securities balance)
/// - a allegement notification (when sent by mistake or because the counterparty cancelled its instruction)
/// - a portfolio transfer notification 
/// - an intra-position movement confirmation
/// - a transaction generation notification
/// The previously sent message cannot be a status advice message (any). If a status advice should not have been sent, a new status advice with the correct status should be sent, not a cancellation advice.
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer sends a SecuritiesMessageCancellationAdvice to an account owner to inform of the cancellation of a securities message previously sent by an account servicer. |The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The previously sent message may be:|- a securities settlement transaction confirmation|- a report (transactions, pending transactions, allegements, accounting and custody securities balance)|- a allegement notification (when sent by mistake or because the counterparty cancelled its instruction)|- a portfolio transfer notification |- an intra-position movement confirmation|- a transaction generation notification||The previously sent message cannot be a status advice message (any). If a status advice should not have been sent, a new status advice with the correct status should be sent, not a cancellation advice.|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
public partial record SecuritiesMessageCancellationAdvice002V05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesMsgCxlAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesMessageCancellationAdvice002V05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesMessageCancellationAdvice002V05Document ToDocument()
    {
        return new SecuritiesMessageCancellationAdvice002V05Document { Message = this };
    }
}

/// <summary>
/// Scope
/// An account servicer sends a SecuritiesMessageCancellationAdvice to an account owner to inform of the cancellation of a securities message previously sent by an account servicer. 
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or 
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// Usage
/// The previously sent message may be:
/// - a securities settlement transaction confirmation
/// - a report (transactions, pending transactions, allegements, accounting and custody securities balance)
/// - a allegement notification (when sent by mistake or because the counterparty cancelled its instruction)
/// - a portfolio transfer notification 
/// - an intra-position movement confirmation
/// - a transaction generation notification
/// The previously sent message cannot be a status advice message (any). If a status advice should not have been sent, a new status advice with the correct status should be sent, not a cancellation advice.
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// This is the outer document that contains <seealso cref="SecuritiesMessageCancellationAdvice002V05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesMessageCancellationAdvice002V05Document : IOuterDocument<SecuritiesMessageCancellationAdvice002V05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.020.002.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesMessageCancellationAdvice002V05"/> is required.
    /// </summary>
    public required SecuritiesMessageCancellationAdvice002V05 Message { get; init; }
}
