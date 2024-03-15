﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StandingSettlementInstructionV01.  ISO2002 ID# _UWnqsNQPEeKSSosHwGnjNw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.056.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party sends the StandingSettlementInstruction (SSI) message to the receiver to create or update a standing cash or securities settlement instruction. The message can also be used to notify a counterparty of an SSI.
/// 
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
[Description(@"Scope|An instructing party sends the StandingSettlementInstruction (SSI) message to the receiver to create or update a standing cash or securities settlement instruction. The message can also be used to notify a counterparty of an SSI.||Usage|The instructing party (initiator) is:|•	An account servicer, for example, a global custodian or prime broker|•	A counterparty in a transaction, for example:|-	an investment manager (executing broker),|-	a global custodian (executing broker, prime broker)|•	A vendor’s application communicating on behalf of an account servicer or counterparty|The receiver is:|•	An account owner, for example, an investment manager, hedge fund administrator or a party to which SSI operations have been outsourced|•	A counterparty, for example:|-	an investment manager (executing broker)|-	a global custodian (executing broker, prime broker)|•	A vendor’s application communicating on behalf of the account owner or counterparty.")]
[IsoId("_UWnqsNQPEeKSSosHwGnjNw")]
[DisplayName("Standing Settlement Instruction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StandingSettlementInstructionV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.056.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StgSttlmInstr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.056.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StandingSettlementInstructionV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StandingSettlementInstructionV01( System.String reqMessageReferenceIdentification,AccountIdentification26 reqAccountIdentification,MarketIdentificationOrCashPurpose1Choice_ reqMarketIdentification,SecuritiesOrCash1Choice_ reqSettlementDetails )
    {
        MessageReferenceIdentification = reqMessageReferenceIdentification;
        AccountIdentification = reqAccountIdentification;
        MarketIdentification = reqMarketIdentification;
        SettlementDetails = reqSettlementDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference of this message.
    /// </summary>
    [IsoId("_5JXSsewkEeWkJ9nstgT-Yw")]
    [DisplayName("Message Reference Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRefId")]
    #endif
    [IsoXmlTag("MsgRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MessageReferenceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageReferenceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageReferenceIdentification { get; init; } 
    #else
    public System.String MessageReferenceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the SSI is effective.
    /// </summary>
    [IsoId("_zNrOsNQgEeKvJeoOII0e7w")]
    [DisplayName("Effective Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvDtDtls")]
    #endif
    [IsoXmlTag("FctvDtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EffectiveDate1? EffectiveDateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EffectiveDate1? EffectiveDateDetails { get; init; } 
    #else
    public EffectiveDate1? EffectiveDateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous master identification known to the sender (or its authorised agent) and receiver (or its authorised agent), below which the SSI will be lodged. This may be an account number or reference to a fund.
    /// If no account or reference is available then “NONREF” must be specified.
    /// </summary>
    [IsoId("_8cPQANQgEeKvJeoOII0e7w")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification26 AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification26 AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification26 AccountIdentification { get; init; } 
    #else
    public AccountIdentification26 AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the market for the standing settlement instruction.
    /// </summary>
    [IsoId("_w0hJgNQhEeKvJeoOII0e7w")]
    [DisplayName("Market Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktId")]
    #endif
    [IsoXmlTag("MktId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarketIdentificationOrCashPurpose1Choice_ MarketIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarketIdentificationOrCashPurpose1Choice_ MarketIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentificationOrCashPurpose1Choice_ MarketIdentification { get; init; } 
    #else
    public MarketIdentificationOrCashPurpose1Choice_ MarketIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Currency for which the SSI is specified.
    /// </summary>
    [IsoId("_8WCE4NQhEeKvJeoOII0e7w")]
    [DisplayName("Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcy")]
    #endif
    [IsoXmlTag("SttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? SettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? SettlementCurrency { get; init; } 
    #else
    public string? SettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement chain parties, accounts and other details.
    /// </summary>
    [IsoId("_9kl1UDcfEeOA3chqL9a4Rw")]
    [DisplayName("Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDtls")]
    #endif
    [IsoXmlTag("SttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesOrCash1Choice_ SettlementDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesOrCash1Choice_ SettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesOrCash1Choice_ SettlementDetails { get; init; } 
    #else
    public SecuritiesOrCash1Choice_ SettlementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_0dGa4dT_EeKnWItMEK8CZg")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since StandingSettlementInstructionV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StandingSettlementInstructionV01.

