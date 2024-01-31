﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesTradeConfirmationCancellationV02.  ISO2002 ID# _q-sQUQNmEe2P7e2qGFFOGg.
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
/// This record is an implementation of the setr.029.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// Sent by an executing party to an instructing party directly or through Central Matching Utility (CMU) to cancel the referenced SecuritiesTradeConfirmation message that was previously sent.
/// The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.
/// The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.
/// It may also be used to cancel the trade confirmation previously sent from an executing party or an instructing party to a custodian or an affirming party directly or through CMU.
/// The ISO 20022 Business Application Header must be used
/// Usage
/// Initiator: Both in local and central matching, the Initiator may be either the Executing Party or Instructing Party.
/// Respondent: Instructing party, a custodian or an affirming party optionally responds with SecuritiesTradeConfirmationResponse (accept or reject) message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|Sent by an executing party to an instructing party directly or through Central Matching Utility (CMU) to cancel the referenced SecuritiesTradeConfirmation message that was previously sent.|The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.|The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.|It may also be used to cancel the trade confirmation previously sent from an executing party or an instructing party to a custodian or an affirming party directly or through CMU.|The ISO 20022 Business Application Header must be used|Usage|Initiator: Both in local and central matching, the Initiator may be either the Executing Party or Instructing Party.|Respondent: Instructing party, a custodian or an affirming party optionally responds with SecuritiesTradeConfirmationResponse (accept or reject) message.")]
public partial record SecuritiesTradeConfirmationCancellationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.029.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTradConfCxl";
    
    #nullable enable
    /// <summary>
    /// Information that unambiguously identifies an SecuritiesTradeConfirmationCancellation message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_q-sQVwNmEe2P7e2qGFFOGg")]
    [Description(@"Information that unambiguously identifies an SecuritiesTradeConfirmationCancellation message as known by the account owner (or the instructing party acting on its behalf).")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required TransactiontIdentification4 Identification { get; init; }
    
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_q-sQWQNmEe2P7e2qGFFOGg")]
    [Description(@"Link to another transaction that must be processed after, before or at the same time.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    public Linkages52? References { get; init; }
    
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
    /// </summary>
    [IsoId("_q-sQWwNmEe2P7e2qGFFOGg")]
    [Description(@"Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.")]
    [DataMember(Name="OthrBizPties")]
    [XmlElement(ElementName="OthrBizPties")]
    public OtherParties45? OtherBusinessParties { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_q-sQXQNmEe2P7e2qGFFOGg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesTradeConfirmationCancellationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesTradeConfirmationCancellationV02Document ToDocument()
    {
        return new SecuritiesTradeConfirmationCancellationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesTradeConfirmationCancellationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesTradeConfirmationCancellationV02Document : IOuterDocument<SecuritiesTradeConfirmationCancellationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.029.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesTradeConfirmationCancellationV02"/> is required.
    /// </summary>
    public required SecuritiesTradeConfirmationCancellationV02 Message { get; init; }
}
