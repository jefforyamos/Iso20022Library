﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StandingSettlementInstructionDeletionV01.  ISO2002 ID# _n9oL6tQiEeKvJeoOII0e7w.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.reda;


/// <summary>
/// This record is an implementation of the reda.057.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party sends the StandingSettlementInstructionDeletion message to the receiver to delete a previously sent StandingSettlementInstruction message. The message can also be used to notify a counterparty of the deletion of a standing settlement information.
/// 
/// Usage
/// The instructing party (initiator) is:
/// • An account servicer, for example, a global custodian or prime broker
/// • A counterparty in a transaction, for example:
/// 	- an investment manager (executing broker),
/// 	- a global custodian (executing broker, prime broker)
/// • A vendor's application communicating on behalf of an account servicer or counterparty
/// The receiver is:
/// • An account owner, for example, an investment manager, hedge fund administrator or a party to which SSI operations have been outsourced
/// • A counterparty, for example:
/// 	- an investment manager (executing broker)
/// 	- a global custodian (executing broker, prime broker)
/// • A vendor's application communicating on behalf of the account owner or counterparty.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An instructing party sends the StandingSettlementInstructionDeletion message to the receiver to delete a previously sent StandingSettlementInstruction message. The message can also be used to notify a counterparty of the deletion of a standing settlement information.||Usage|The instructing party (initiator) is:|• An account servicer, for example, a global custodian or prime broker|• A counterparty in a transaction, for example:|	- an investment manager (executing broker),|	- a global custodian (executing broker, prime broker)|• A vendor's application communicating on behalf of an account servicer or counterparty|The receiver is:|• An account owner, for example, an investment manager, hedge fund administrator or a party to which SSI operations have been outsourced|• A counterparty, for example:|	- an investment manager (executing broker)|	- a global custodian (executing broker, prime broker)|• A vendor's application communicating on behalf of the account owner or counterparty.")]
public partial record StandingSettlementInstructionDeletionV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.057.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StgSttlmInstrDeltn";
    
    #nullable enable
    /// <summary>
    /// Reference of this message.
    /// </summary>
    [IsoId("_MwZHMewmEeWkJ9nstgT-Yw")]
    [Description(@"Reference of this message.")]
    [DataMember(Name="MsgRefId")]
    [XmlElement(ElementName="MsgRefId")]
    [Required]
    public required IsoMax35Text MessageReferenceIdentification { get; init; }
    
    /// <summary>
    /// Date on which the SSI is effective.
    /// </summary>
    [IsoId("_n9oL89QiEeKvJeoOII0e7w")]
    [Description(@"Date on which the SSI is effective.")]
    [DataMember(Name="FctvDtDtls")]
    [XmlElement(ElementName="FctvDtDtls")]
    public EffectiveDate1? EffectiveDateDetails { get; init; }
    
    /// <summary>
    /// Unique and unambiguous master identification known to the sender (or its authorised agent) and receiver (or its authorised agent), below which the SSI will be lodged. This may be an account number or reference to a fund.
    /// If no account or reference is available then “NONREF” must be specified.
    /// </summary>
    [IsoId("_n9oL7dQiEeKvJeoOII0e7w")]
    [Description(@"Unique and unambiguous master identification known to the sender (or its authorised agent) and receiver (or its authorised agent), below which the SSI will be lodged. This may be an account number or reference to a fund.|If no account or reference is available then “NONREF” must be specified.")]
    [DataMember(Name="AcctId")]
    [XmlElement(ElementName="AcctId")]
    [Required]
    public required AccountIdentification26 AccountIdentification { get; init; }
    
    /// <summary>
    /// Identifies the market for the standing settlement instruction.
    /// </summary>
    [IsoId("_hviQYVKyEeOsJr32EK1NAQ")]
    [Description(@"Identifies the market for the standing settlement instruction.")]
    [DataMember(Name="MktId")]
    [XmlElement(ElementName="MktId")]
    [Required]
    public required IMarketIdentificationOrCashPurpose1Choice MarketIdentification { get; init; }
    
    /// <summary>
    /// Settlement information that helps to identify the standing settlement instruction for which the deletion is sent.
    /// </summary>
    [IsoId("_EMun4VK0EeOsJr32EK1NAQ")]
    [Description(@"Settlement information that helps to identify the standing settlement instruction for which the deletion is sent.")]
    [DataMember(Name="SttlmDtls")]
    [XmlElement(ElementName="SttlmDtls")]
    [Required]
    public required IPartyOrCurrency1Choice SettlementDetails { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_1CltkdT_EeKnWItMEK8CZg")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="StandingSettlementInstructionDeletionV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public StandingSettlementInstructionDeletionV01Document ToDocument()
    {
        return new StandingSettlementInstructionDeletionV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="StandingSettlementInstructionDeletionV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record StandingSettlementInstructionDeletionV01Document : IOuterDocument<StandingSettlementInstructionDeletionV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.057.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="StandingSettlementInstructionDeletionV01"/> is required.
    /// </summary>
    public required StandingSettlementInstructionDeletionV01 Message { get; init; }
}
