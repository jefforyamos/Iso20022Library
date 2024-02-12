﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionModificationRequestStatusAdviceV05.  ISO2002 ID# _XVDqYQyQEeuG8M5giQ2e0w.
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
/// This record is an implementation of the sese.039.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesSettlementTransactionModificationRequestStatusAdvice to an account owner to advise the status of a SecuritiesSettlementModificationRequest message previously sent by the account owner.
/// The account servicer may be:
/// - a central securities depository or another settlement market infrastructure managing securities settlement transactions on behalf of their participants
/// - an custodian acting as an accounting and/or settlement agent.
/// 
/// Usage
/// The message may also be used to:
/// - re-send a message sent by the account owner to the account servicer,
/// - provide a third party with a copy of a message being sent by the account owner for information,
/// - re-send to a third party a copy of a message being sent by the account owner for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(@"Scope|An account servicer sends a SecuritiesSettlementTransactionModificationRequestStatusAdvice to an account owner to advise the status of a SecuritiesSettlementModificationRequest message previously sent by the account owner.|The account servicer may be:|- a central securities depository or another settlement market infrastructure managing securities settlement transactions on behalf of their participants|- an custodian acting as an accounting and/or settlement agent.||Usage|The message may also be used to:|- re-send a message sent by the account owner to the account servicer,|- provide a third party with a copy of a message being sent by the account owner for information,|- re-send to a third party a copy of a message being sent by the account owner for information|using the relevant elements in the Business Application Header.")]
[IsoId("_XVDqYQyQEeuG8M5giQ2e0w")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Securities Settlement Transaction Modification Request Status Advice V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesSettlementTransactionModificationRequestStatusAdviceV05 : IOuterRecord<SecuritiesSettlementTransactionModificationRequestStatusAdviceV05,SecuritiesSettlementTransactionModificationRequestStatusAdviceV05Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.039.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxModReqStsAdvc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesSettlementTransactionModificationRequestStatusAdviceV05Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesSettlementTransactionModificationRequestStatusAdviceV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesSettlementTransactionModificationRequestStatusAdviceV05( Identification14 reqModificationRequestReference,SecuritiesAccount19 reqSafekeepingAccount,ModificationProcessingStatus7Choice_ reqModificationProcessingStatus )
    {
        ModificationRequestReference = reqModificationRequestReference;
        SafekeepingAccount = reqSafekeepingAccount;
        ModificationProcessingStatus = reqModificationProcessingStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the unambiguous identification of the cancellation request as per the account owner.
    /// </summary>
    [IsoId("_XVDqaQyQEeuG8M5giQ2e0w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Modification Request Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Identification14 ModificationRequestReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Identification14 ModificationRequestReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Identification14 ModificationRequestReference { get; init; } 
    #else
    public Identification14 ModificationRequestReference { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_XVDqawyQEeuG8M5giQ2e0w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Owner")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification144? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification144? AccountOwner { get; init; } 
    #else
    public PartyIdentification144? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_XVDqbQyQEeuG8M5giQ2e0w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Safekeeping Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount19 SafekeepingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecuritiesAccount19 SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19 SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount19 SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_XVDqbwyQEeuG8M5giQ2e0w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifications33? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifications33? TransactionIdentification { get; init; } 
    #else
    public TransactionIdentifications33? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the processing status of the request.
    /// </summary>
    [IsoId("_XVDqcQyQEeuG8M5giQ2e0w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Modification Processing Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ModificationProcessingStatus7Choice_ ModificationProcessingStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ModificationProcessingStatus7Choice_ ModificationProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModificationProcessingStatus7Choice_ ModificationProcessingStatus { get; init; } 
    #else
    public ModificationProcessingStatus7Choice_ ModificationProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("_XVDqcwyQEeuG8M5giQ2e0w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionDetails137? TransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionDetails137? TransactionDetails { get; init; } 
    #else
    public TransactionDetails137? TransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_XVDqdQyQEeuG8M5giQ2e0w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementTransactionModificationRequestStatusAdviceV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionModificationRequestStatusAdviceV05Document ToDocument()
    {
        return new SecuritiesSettlementTransactionModificationRequestStatusAdviceV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesSettlementTransactionModificationRequestStatusAdviceV05"/>.
/// </summary>
[Serializable]
public partial record SecuritiesSettlementTransactionModificationRequestStatusAdviceV05Document : IOuterDocument<SecuritiesSettlementTransactionModificationRequestStatusAdviceV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.039.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementTransactionModificationRequestStatusAdviceV05"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesSettlementTransactionModificationRequestStatusAdviceV05 Message { get; init; }
    #else
    public SecuritiesSettlementTransactionModificationRequestStatusAdviceV05 Message { get; init; }
    #endif
}
