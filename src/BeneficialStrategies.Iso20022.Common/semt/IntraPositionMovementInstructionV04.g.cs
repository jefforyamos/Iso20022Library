﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntraPositionMovementInstructionV04.  ISO2002 ID# _XVkgRwCUEeW_3KiG8SEjHA.
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


namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.013.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner sends a IntraPositionMovementInstruction to an account servicer to instruct the movement of securities within its holding from one sub-balance to another, for example, blocking of securities.
/// The account owner/servicer relationship may be:
/// - a global custodian which has an account with its local agent (sub-custodian), or
/// - an investment management institution which manage a fund account opened at a custodian, or
/// - a broker which has an account with a custodian, or
/// - a central securities depository participant which has an account with a central securities depository, or
/// - a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information.
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(@"Scope|An account owner sends a IntraPositionMovementInstruction to an account servicer to instruct the movement of securities within its holding from one sub-balance to another, for example, blocking of securities.|The account owner/servicer relationship may be:|- a global custodian which has an account with its local agent (sub-custodian), or|- an investment management institution which manage a fund account opened at a custodian, or|- a broker which has an account with a custodian, or|- a central securities depository participant which has an account with a central securities depository, or|- a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure.|Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information.|using the relevant elements in the Business Application Header.")]
[IsoId("_XVkgRwCUEeW_3KiG8SEjHA")]
[DisplayName("Intra Position Movement Instruction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraPositionMovementInstructionV04 : IOuterRecord<IntraPositionMovementInstructionV04,IntraPositionMovementInstructionV04Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.013.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraPosMvmntInstr";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => IntraPositionMovementInstructionV04Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntraPositionMovementInstructionV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraPositionMovementInstructionV04( System.String reqTransactionIdentification,SecuritiesAccount24 reqSafekeepingAccount,SecurityIdentification19 reqFinancialInstrumentIdentification,IntraPositionDetails33 reqIntraPositionDetails )
    {
        TransactionIdentification = reqTransactionIdentification;
        SafekeepingAccount = reqSafekeepingAccount;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        IntraPositionDetails = reqIntraPositionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_XVkgTQCUEeW_3KiG8SEjHA")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_XVkgTwCUEeW_3KiG8SEjHA")]
    [DisplayName("Corporate Action Event Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnEvtId")]
    #endif
    [IsoXmlTag("CorpActnEvtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Identification14? CorporateActionEventIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Identification14? CorporateActionEventIdentification { get; init; } 
    #else
    public Identification14? CorporateActionEventIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Count of the number of transactions linked.
    /// </summary>
    [IsoId("_XVkgUQCUEeW_3KiG8SEjHA")]
    [DisplayName("Number Counts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbCounts")]
    #endif
    [IsoXmlTag("NbCounts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberCount1Choice_? NumberCounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberCount1Choice_? NumberCounts { get; init; } 
    #else
    public NumberCount1Choice_? NumberCounts { get; set; } 
    #endif
    
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_XVkgUwCUEeW_3KiG8SEjHA")]
    [DisplayName("Linkages")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lnkgs")]
    #endif
    [IsoXmlTag("Lnkgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Linkages36? Linkages { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Linkages36? Linkages { get; init; } 
    #else
    public Linkages36? Linkages { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_XVkgVQCUEeW_3KiG8SEjHA")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification92Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification92Choice_? AccountOwner { get; init; } 
    #else
    public PartyIdentification92Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_XVkgVwCUEeW_3KiG8SEjHA")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount24 SafekeepingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount24 SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount24 SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount24 SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_XVkgWQCUEeW_3KiG8SEjHA")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat10Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat10Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat10Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_XVkgWwCUEeW_3KiG8SEjHA")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_XVkgXQCUEeW_3KiG8SEjHA")]
    [DisplayName("Financial Instrument Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAttrbts")]
    #endif
    [IsoXmlTag("FinInstrmAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributes63? FinancialInstrumentAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributes63? FinancialInstrumentAttributes { get; init; } 
    #else
    public FinancialInstrumentAttributes63? FinancialInstrumentAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Intra-position movement transaction details.
    /// </summary>
    [IsoId("_XVkgXwCUEeW_3KiG8SEjHA")]
    [DisplayName("Intra Position Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntraPosDtls")]
    #endif
    [IsoXmlTag("IntraPosDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IntraPositionDetails33 IntraPositionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IntraPositionDetails33 IntraPositionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IntraPositionDetails33 IntraPositionDetails { get; init; } 
    #else
    public IntraPositionDetails33 IntraPositionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_XVkgYQCUEeW_3KiG8SEjHA")]
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
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;IntraPositionMovementInstructionV04Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntraPositionMovementInstructionV04Document ToDocument()
    {
        return new IntraPositionMovementInstructionV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;IntraPositionMovementInstructionV04&quot;/&gt;.
/// </summary>
[Serializable]
public partial record IntraPositionMovementInstructionV04Document : IOuterDocument<IntraPositionMovementInstructionV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.013.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;IntraPositionMovementInstructionV04&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IntraPositionMovementInstructionV04 Message { get; init; }
    #else
    public IntraPositionMovementInstructionV04 Message { get; init; }
    #endif
}
