﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesFinancingStatusAdviceV06.  ISO2002 ID# _YSMW9QCTEeW_3KiG8SEjHA.
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


namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.034.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An securities financing transaction account servicer sends a SecuritiesFinancingStatusAdvice to an account owner to advise the status of a securities financing transaction previously instructed by the account owner.
/// The status advice may be sent as a response to the request of the account owner or not.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure managing securities financing transactions on behalf of their participants
/// - an agent (sub-custodian) managing securities financing transactions on behalf of their global custodian customer, or
/// - a custodian managing securities financing transactions on behalf of an investment management institution or a broker/dealer.
/// 
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(@"Scope|An securities financing transaction account servicer sends a SecuritiesFinancingStatusAdvice to an account owner to advise the status of a securities financing transaction previously instructed by the account owner.|The status advice may be sent as a response to the request of the account owner or not.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure managing securities financing transactions on behalf of their participants|- an agent (sub-custodian) managing securities financing transactions on behalf of their global custodian customer, or|- a custodian managing securities financing transactions on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
[IsoId("_YSMW9QCTEeW_3KiG8SEjHA")]
[DisplayName("Securities Financing Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesFinancingStatusAdviceV06 : IOuterRecord<SecuritiesFinancingStatusAdviceV06,SecuritiesFinancingStatusAdviceV06Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.034.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgStsAdvc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesFinancingStatusAdviceV06Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesFinancingStatusAdviceV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesFinancingStatusAdviceV06( TransactionIdentifications32 reqTransactionIdentification )
    {
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_YSMW_QCTEeW_3KiG8SEjHA")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifications32 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifications32 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifications32 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentifications32 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Processing status of the transaction.
    /// </summary>
    [IsoId("_YSMW_wCTEeW_3KiG8SEjHA")]
    [DisplayName("Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgSts")]
    #endif
    [IsoXmlTag("PrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingStatus51Choice_? ProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingStatus51Choice_? ProcessingStatus { get; init; } 
    #else
    public ProcessingStatus51Choice_? ProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_YSMXAQCTEeW_3KiG8SEjHA")]
    [DisplayName("Matching Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgSts")]
    #endif
    [IsoXmlTag("MtchgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MatchingStatus26Choice_? MatchingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingStatus26Choice_? MatchingStatus { get; init; } 
    #else
    public MatchingStatus26Choice_? MatchingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the matching status of an instruction as per the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).
    /// </summary>
    [IsoId("_YSMXAwCTEeW_3KiG8SEjHA")]
    [DisplayName("Inferred Matching Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IfrrdMtchgSts")]
    #endif
    [IsoXmlTag("IfrrdMtchgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MatchingStatus26Choice_? InferredMatchingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingStatus26Choice_? InferredMatchingStatus { get; init; } 
    #else
    public MatchingStatus26Choice_? InferredMatchingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_YSMXBQCTEeW_3KiG8SEjHA")]
    [DisplayName("Settlement Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSts")]
    #endif
    [IsoXmlTag("SttlmSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementStatus18Choice_? SettlementStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementStatus18Choice_? SettlementStatus { get; init; } 
    #else
    public SettlementStatus18Choice_? SettlementStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status of the repurchase agreement call request.
    /// </summary>
    [IsoId("_YSMXBwCTEeW_3KiG8SEjHA")]
    [DisplayName("Repo Call Request Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RepoCallReqSts")]
    #endif
    [IsoXmlTag("RepoCallReqSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RepoCallRequestStatus7Choice_? RepoCallRequestStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RepoCallRequestStatus7Choice_? RepoCallRequestStatus { get; init; } 
    #else
    public RepoCallRequestStatus7Choice_? RepoCallRequestStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("_YSMXCQCTEeW_3KiG8SEjHA")]
    [DisplayName("Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtls")]
    #endif
    [IsoXmlTag("TxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesFinancingTransactionDetails26? TransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesFinancingTransactionDetails26? TransactionDetails { get; init; } 
    #else
    public SecuritiesFinancingTransactionDetails26? TransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_YSMXCwCTEeW_3KiG8SEjHA")]
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
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;SecuritiesFinancingStatusAdviceV06Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesFinancingStatusAdviceV06Document ToDocument()
    {
        return new SecuritiesFinancingStatusAdviceV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;SecuritiesFinancingStatusAdviceV06&quot;/&gt;.
/// </summary>
[Serializable]
public partial record SecuritiesFinancingStatusAdviceV06Document : IOuterDocument<SecuritiesFinancingStatusAdviceV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.034.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;SecuritiesFinancingStatusAdviceV06&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesFinancingStatusAdviceV06 Message { get; init; }
    #else
    public SecuritiesFinancingStatusAdviceV06 Message { get; init; }
    #endif
}
