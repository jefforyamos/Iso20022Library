﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesTradeConfirmationResponseV02.  ISO2002 ID# _s7RRwQNmEe2P7e2qGFFOGg.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// Sent by an instructing party, a custodian or an affirming party to an executing party (local matching) or to Central Matching Utility (CMU) to affirm (accept) or disaffirm (reject) (central matching) the SecuritiesTradeConfirmation message. If accepting the SecuritiesTradeConfirmation message, then the trade is ready for settlement processing. If rejecting the SecuritiesTradeConfirmation message, then the trade is not ready for settlement.
/// The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.
/// The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.
/// The custodian or an affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.
/// The ISO 20022 Business Application Header must be used
/// Usage
/// Initiator: Both in local and central matching, the Initiator may be the Instructing Party, Custodian or Affirming party.
/// Respondent: Executing party does not need to respond if an affirmation. Executing party may respond with modification or cancellation of the rejected SecuritiesTradeConfirmation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|Sent by an instructing party, a custodian or an affirming party to an executing party (local matching) or to Central Matching Utility (CMU) to affirm (accept) or disaffirm (reject) (central matching) the SecuritiesTradeConfirmation message. If accepting the SecuritiesTradeConfirmation message, then the trade is ready for settlement processing. If rejecting the SecuritiesTradeConfirmation message, then the trade is not ready for settlement.|The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.|The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.|The custodian or an affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.|The ISO 20022 Business Application Header must be used|Usage|Initiator: Both in local and central matching, the Initiator may be the Instructing Party, Custodian or Affirming party.|Respondent: Executing party does not need to respond if an affirmation. Executing party may respond with modification or cancellation of the rejected SecuritiesTradeConfirmation message.")]
public partial record SecuritiesTradeConfirmationResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTradConfRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesTradeConfirmationResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesTradeConfirmationResponseV02Document ToDocument()
    {
        return new SecuritiesTradeConfirmationResponseV02Document { Message = this };
    }
}

/// <summary>
/// Scope
/// Sent by an instructing party, a custodian or an affirming party to an executing party (local matching) or to Central Matching Utility (CMU) to affirm (accept) or disaffirm (reject) (central matching) the SecuritiesTradeConfirmation message. If accepting the SecuritiesTradeConfirmation message, then the trade is ready for settlement processing. If rejecting the SecuritiesTradeConfirmation message, then the trade is not ready for settlement.
/// The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.
/// The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.
/// The custodian or an affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.
/// The ISO 20022 Business Application Header must be used
/// Usage
/// Initiator: Both in local and central matching, the Initiator may be the Instructing Party, Custodian or Affirming party.
/// Respondent: Executing party does not need to respond if an affirmation. Executing party may respond with modification or cancellation of the rejected SecuritiesTradeConfirmation message.
/// This is the outer document that contains <seealso cref="SecuritiesTradeConfirmationResponseV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesTradeConfirmationResponseV02Document : IOuterDocument<SecuritiesTradeConfirmationResponseV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.030.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesTradeConfirmationResponseV02"/> is required.
    /// </summary>
    public required SecuritiesTradeConfirmationResponseV02 Message { get; init; }
}
