﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesTradeConfirmationResponseV02.  ISO2002 ID# _s7RRwQNmEe2P7e2qGFFOGg.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.setr;


/// <summary>
/// This record is an implementation of the setr.030.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
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
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.030.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTradConfRspn";
    
    #nullable enable
    /// <summary>
    /// Information that unambiguously identifies an SecuritiesTradeConfirmationResponse message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_s7RRxwNmEe2P7e2qGFFOGg")]
    [Description(@"Information that unambiguously identifies an SecuritiesTradeConfirmationResponse message as known by the account owner (or the instructing party acting on its behalf).")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required TransactiontIdentification4 Identification { get; init; }
    
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_s7RRyQNmEe2P7e2qGFFOGg")]
    [Description(@"Link to another transaction that must be processed after, before or at the same time.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    [Required]
    public required Linkages52 References { get; init; }
    
    /// <summary>
    /// Provides details on the processing status of the trade.
    /// </summary>
    [IsoId("_s7RRywNmEe2P7e2qGFFOGg")]
    [Description(@"Provides details on the processing status of the trade.")]
    [DataMember(Name="Sts")]
    [XmlElement(ElementName="Sts")]
    [Required]
    public required StatusAndReason46 Status { get; init; }
    
    /// <summary>
    /// Provides clearing member information.
    /// </summary>
    [IsoId("_s7RRzQNmEe2P7e2qGFFOGg")]
    [Description(@"Provides clearing member information.")]
    [DataMember(Name="ClrDtls")]
    [XmlElement(ElementName="ClrDtls")]
    public Clearing6? ClearingDetails { get; init; }
    
    /// <summary>
    /// Parties involved in the confirmation of the details of a trade.
    /// </summary>
    [IsoId("_s7RRzwNmEe2P7e2qGFFOGg")]
    [Description(@"Parties involved in the confirmation of the details of a trade.")]
    [DataMember(Name="ConfPties")]
    [XmlElement(ElementName="ConfPties")]
    public ConfirmationParties8? ConfirmationParties { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_s7RR0QNmEe2P7e2qGFFOGg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesTradeConfirmationResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesTradeConfirmationResponseV02Document ToDocument()
    {
        return new SecuritiesTradeConfirmationResponseV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesTradeConfirmationResponseV02"/>.
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
