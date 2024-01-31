﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesTradeConfirmationStatusAdviceV02.  ISO2002 ID# _V_jSQTAjEeOUGqA1wUwNLA.
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
/// This record is an implementation of the setr.044.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent from Central Matching Utility (CMU) to an executing party or an instructing party to advise the status of the SecuritiesTradeConfirmation message previously sent by the party. The status may be a processing, pending processing, affirmed or disaffirmed, cancel or replacement by an instructing party, a custodian or an affirming party, internal matching, and/or matching status.
/// The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors. The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.
/// The ISO 20022 Business Application Header must be used
/// Usage
/// Initiator: In central matching the Initiator is the Central Matching Utility.
/// Respondent: no response is needed by the recipient of the message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|This message is sent from Central Matching Utility (CMU) to an executing party or an instructing party to advise the status of the SecuritiesTradeConfirmation message previously sent by the party. The status may be a processing, pending processing, affirmed or disaffirmed, cancel or replacement by an instructing party, a custodian or an affirming party, internal matching, and/or matching status.|The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors. The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.|The ISO 20022 Business Application Header must be used|Usage|Initiator: In central matching the Initiator is the Central Matching Utility.|Respondent: no response is needed by the recipient of the message.")]
public partial record SecuritiesTradeConfirmationStatusAdviceV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.044.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTradConfStsAdvc";
    
    #nullable enable
    /// <summary>
    /// Information that unambiguously identifies an SecuritiesTradeConfirmationStatusAdvice message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_V_jSRTAjEeOUGqA1wUwNLA")]
    [Description(@"Information that unambiguously identifies an SecuritiesTradeConfirmationStatusAdvice message as known by the account owner (or the instructing party acting on its behalf).")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required TransactiontIdentification4 Identification { get; init; }
    
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_V_jSRzAjEeOUGqA1wUwNLA")]
    [Description(@"Link to another transaction that must be processed after, before or at the same time.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    [Required]
    public required Linkages18 References { get; init; }
    
    /// <summary>
    /// Provides details on the affitrmation status of a trade.
    /// </summary>
    [IsoId("_V_jSSTAjEeOUGqA1wUwNLA")]
    [Description(@"Provides details on the affitrmation status of a trade.")]
    [DataMember(Name="AffirmSts")]
    [XmlElement(ElementName="AffirmSts")]
    public IAffirmationStatus6Choice? AffirmationStatus { get; init; }
    
    /// <summary>
    /// Provides the processing status of a trade.
    /// </summary>
    [IsoId("_V_jSSzAjEeOUGqA1wUwNLA")]
    [Description(@"Provides the processing status of a trade.")]
    [DataMember(Name="PrcgSts")]
    [XmlElement(ElementName="PrcgSts")]
    public IProcessingStatus17Choice? ProcessingStatus { get; init; }
    
    /// <summary>
    /// Provides details on the matching status of a trade.
    /// </summary>
    [IsoId("_V_jSTTAjEeOUGqA1wUwNLA")]
    [Description(@"Provides details on the matching status of a trade.")]
    [DataMember(Name="MtchgSts")]
    [XmlElement(ElementName="MtchgSts")]
    public IMatchingStatus23Choice? MatchingStatus { get; init; }
    
    /// <summary>
    /// Provides the replacement processing status of a trade.
    /// </summary>
    [IsoId("_V_jSTzAjEeOUGqA1wUwNLA")]
    [Description(@"Provides the replacement processing status of a trade.")]
    [DataMember(Name="RplcmntPrcgSts")]
    [XmlElement(ElementName="RplcmntPrcgSts")]
    public IReplacementProcessingStatus7Choice? ReplacementProcessingStatus { get; init; }
    
    /// <summary>
    /// Provides details on the cancellation status of a trade.
    /// </summary>
    [IsoId("_V_jSUTAjEeOUGqA1wUwNLA")]
    [Description(@"Provides details on the cancellation status of a trade.")]
    [DataMember(Name="CxlPrcgSts")]
    [XmlElement(ElementName="CxlPrcgSts")]
    public ICancellationProcessingStatus6Choice? CancellationProcessingStatus { get; init; }
    
    /// <summary>
    /// Details of the trading party.
    /// </summary>
    [IsoId("_V_jSUzAjEeOUGqA1wUwNLA")]
    [Description(@"Details of the trading party.")]
    [DataMember(Name="PtyTradgDtls")]
    [XmlElement(ElementName="PtyTradgDtls")]
    public Order18? PartyTradingDetails { get; init; }
    
    /// <summary>
    /// Details of the trading counterparty.
    /// </summary>
    [IsoId("_V_jSVTAjEeOUGqA1wUwNLA")]
    [Description(@"Details of the trading counterparty.")]
    [DataMember(Name="CtrPtyTradgDtls")]
    [XmlElement(ElementName="CtrPtyTradgDtls")]
    public Order18? CounterpartyTradingDetails { get; init; }
    
    /// <summary>
    /// Parties used for acting parties that applies either to the whole message or to individual sides.
    /// </summary>
    [IsoId("_V_jSVzAjEeOUGqA1wUwNLA")]
    [Description(@"Parties used for acting parties that applies either to the whole message or to individual sides.")]
    [DataMember(Name="ConfPties")]
    [XmlElement(ElementName="ConfPties")]
    public ConfirmationParties4? ConfirmationParties { get; init; }
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_V_jSWTAjEeOUGqA1wUwNLA")]
    [Description(@"Identifies the chain of delivering settlement parties.")]
    [DataMember(Name="DlvrgSttlmPties")]
    [XmlElement(ElementName="DlvrgSttlmPties")]
    public SettlementParties23? DeliveringSettlementParties { get; init; }
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_V_jSWzAjEeOUGqA1wUwNLA")]
    [Description(@"Identifies the chain of receiving settlement parties.")]
    [DataMember(Name="RcvgSttlmPties")]
    [XmlElement(ElementName="RcvgSttlmPties")]
    public SettlementParties23? ReceivingSettlementParties { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_V_jSXTAjEeOUGqA1wUwNLA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesTradeConfirmationStatusAdviceV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesTradeConfirmationStatusAdviceV02Document ToDocument()
    {
        return new SecuritiesTradeConfirmationStatusAdviceV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesTradeConfirmationStatusAdviceV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesTradeConfirmationStatusAdviceV02Document : IOuterDocument<SecuritiesTradeConfirmationStatusAdviceV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.044.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesTradeConfirmationStatusAdviceV02"/> is required.
    /// </summary>
    public required SecuritiesTradeConfirmationStatusAdviceV02 Message { get; init; }
}
