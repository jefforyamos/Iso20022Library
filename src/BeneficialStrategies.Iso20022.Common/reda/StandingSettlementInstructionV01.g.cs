﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StandingSettlementInstructionV01.  ISO2002 ID# _UWnqsNQPEeKSSosHwGnjNw.
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
/// Scope
/// An instructing party sends the StandingSettlementInstruction (SSI) message to the receiver to create or update a standing cash or securities settlement instruction. The message can also be used to notify a counterparty of an SSI.
/// Usage
/// The instructing party (initiator) is:
/// •	An account servicer, for example, a global custodian or prime broker
/// •	A counterparty in a transaction, for example:
/// -	an investment manager (executing broker),
/// -	a global custodian (executing broker, prime broker)
/// •	A vendor’s application communicating on behalf of an account servicer or counterparty
/// The receiver is:
/// •	An account owner, for example, an investment manager, hedge fund administrator or a party to which SSI operations have been outsourced
/// •	A counterparty, for example:
/// -	an investment manager (executing broker)
/// -	a global custodian (executing broker, prime broker)
/// •	A vendor’s application communicating on behalf of the account owner or counterparty.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An instructing party sends the StandingSettlementInstruction (SSI) message to the receiver to create or update a standing cash or securities settlement instruction. The message can also be used to notify a counterparty of an SSI.||Usage|The instructing party (initiator) is:|•	An account servicer, for example, a global custodian or prime broker|•	A counterparty in a transaction, for example:|-	an investment manager (executing broker),|-	a global custodian (executing broker, prime broker)|•	A vendor’s application communicating on behalf of an account servicer or counterparty|The receiver is:|•	An account owner, for example, an investment manager, hedge fund administrator or a party to which SSI operations have been outsourced|•	A counterparty, for example:|-	an investment manager (executing broker)|-	a global custodian (executing broker, prime broker)|•	A vendor’s application communicating on behalf of the account owner or counterparty.")]
public partial record StandingSettlementInstructionV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StgSttlmInstr";
    
    #nullable enable
    /// <summary>
    /// Reference of this message.
    /// </summary>
    [IsoId("_5JXSsewkEeWkJ9nstgT-Yw")]
    [Description(@"Reference of this message.")]
    [DataMember(Name="MsgRefId")]
    [XmlElement(ElementName="MsgRefId")]
    [Required]
    public required IsoMax35Text MessageReferenceIdentification { get; init; }
    
    /// <summary>
    /// Date on which the SSI is effective.
    /// </summary>
    [IsoId("_zNrOsNQgEeKvJeoOII0e7w")]
    [Description(@"Date on which the SSI is effective.")]
    [DataMember(Name="FctvDtDtls")]
    [XmlElement(ElementName="FctvDtDtls")]
    public EffectiveDate1? EffectiveDateDetails { get; init; }
    
    /// <summary>
    /// Unique and unambiguous master identification known to the sender (or its authorised agent) and receiver (or its authorised agent), below which the SSI will be lodged. This may be an account number or reference to a fund.
    /// If no account or reference is available then “NONREF” must be specified.
    /// </summary>
    [IsoId("_8cPQANQgEeKvJeoOII0e7w")]
    [Description(@"Unique and unambiguous master identification known to the sender (or its authorised agent) and receiver (or its authorised agent), below which the SSI will be lodged. This may be an account number or reference to a fund.|If no account or reference is available then “NONREF” must be specified.")]
    [DataMember(Name="AcctId")]
    [XmlElement(ElementName="AcctId")]
    [Required]
    public required AccountIdentification26 AccountIdentification { get; init; }
    
    /// <summary>
    /// Identifies the market for the standing settlement instruction.
    /// </summary>
    [IsoId("_w0hJgNQhEeKvJeoOII0e7w")]
    [Description(@"Identifies the market for the standing settlement instruction.")]
    [DataMember(Name="MktId")]
    [XmlElement(ElementName="MktId")]
    [Required]
    public required IMarketIdentificationOrCashPurpose1Choice MarketIdentification { get; init; }
    
    /// <summary>
    /// Currency for which the SSI is specified.
    /// </summary>
    [IsoId("_8WCE4NQhEeKvJeoOII0e7w")]
    [Description(@"Currency for which the SSI is specified.")]
    [DataMember(Name="SttlmCcy")]
    [XmlElement(ElementName="SttlmCcy")]
    public ActiveCurrencyCode? SettlementCurrency { get; init; }
    
    /// <summary>
    /// Settlement chain parties, accounts and other details.
    /// </summary>
    [IsoId("_9kl1UDcfEeOA3chqL9a4Rw")]
    [Description(@"Settlement chain parties, accounts and other details.")]
    [DataMember(Name="SttlmDtls")]
    [XmlElement(ElementName="SttlmDtls")]
    [Required]
    public required ISecuritiesOrCash1Choice SettlementDetails { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_0dGa4dT_EeKnWItMEK8CZg")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="StandingSettlementInstructionV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public StandingSettlementInstructionV01Document ToDocument()
    {
        return new StandingSettlementInstructionV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="StandingSettlementInstructionV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record StandingSettlementInstructionV01Document : IOuterDocument<StandingSettlementInstructionV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.056.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="StandingSettlementInstructionV01"/> is required.
    /// </summary>
    public required StandingSettlementInstructionV01 Message { get; init; }
}
