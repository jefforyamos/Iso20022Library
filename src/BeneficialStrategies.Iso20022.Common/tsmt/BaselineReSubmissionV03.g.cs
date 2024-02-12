﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BaselineReSubmissionV03.  ISO2002 ID# _mYyq4tE8Ed-BzquC8wXy7w_-2146835428.
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


namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.012.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The BaselineReSubmission message is sent by either the counterparty or the initiator of a transaction (baseline) to the matching application.
/// This message is used by the counterparty to respond on the registration of a push-through transaction in the matching application or by the initiator or counterparty to re-send earlier mis-matched baseline information.
/// Usage
/// The BaselineReSubmission message can be sent by the counterparty of a transaction to the matching application in response to a FullPushThroughReport message received from the matching application conveying the details of an InitialBaselineSubmission message. The objective of the BaselineReSubmission message sent in the outlined scenario is to achieve a successful match of two baseline initiation messages in order to establish a transaction in the matching application.
/// or
/// The BaselineReSubmission message can be sent by the initiator of a transaction to the matching application in response to a BaselineMatchReport message indicating mis-matches. The objective of the BaselineReSubmission message sent in the outlined scenario is to correct an InitialBaselineSubmission or BaselineReSubmission message submitted earlier in order to achieve the establishment of a transaction in the matching application.
/// or
/// The BaselineReSubmission message can be sent by the counterparty of a transaction to the matching application in response to a BaselineMatchReport message indicating mis-matches. The objective of the BaselineReSubmission message sent in the outlined scenario is to correct a BaselineReSubmission message submitted earlier in order to achieve the establishment of a transaction in the matching application.
/// </summary>
[Description(@"Scope|The BaselineReSubmission message is sent by either the counterparty or the initiator of a transaction (baseline) to the matching application.|This message is used by the counterparty to respond on the registration of a push-through transaction in the matching application or by the initiator or counterparty to re-send earlier mis-matched baseline information.|Usage|The BaselineReSubmission message can be sent by the counterparty of a transaction to the matching application in response to a FullPushThroughReport message received from the matching application conveying the details of an InitialBaselineSubmission message. The objective of the BaselineReSubmission message sent in the outlined scenario is to achieve a successful match of two baseline initiation messages in order to establish a transaction in the matching application.|or|The BaselineReSubmission message can be sent by the initiator of a transaction to the matching application in response to a BaselineMatchReport message indicating mis-matches. The objective of the BaselineReSubmission message sent in the outlined scenario is to correct an InitialBaselineSubmission or BaselineReSubmission message submitted earlier in order to achieve the establishment of a transaction in the matching application.|or|The BaselineReSubmission message can be sent by the counterparty of a transaction to the matching application in response to a BaselineMatchReport message indicating mis-matches. The objective of the BaselineReSubmission message sent in the outlined scenario is to correct a BaselineReSubmission message submitted earlier in order to achieve the establishment of a transaction in the matching application.")]
[IsoId("_mYyq4tE8Ed-BzquC8wXy7w_-2146835428")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Baseline Re Submission V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BaselineReSubmissionV03 : IOuterRecord<BaselineReSubmissionV03,BaselineReSubmissionV03Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.012.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BaselnReSubmissn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => BaselineReSubmissionV03Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BaselineReSubmissionV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BaselineReSubmissionV03( MessageIdentification1 reqSubmissionIdentification,SimpleIdentificationInformation reqTransactionIdentification,Baseline3 reqBaseline,ContactIdentification1 reqBuyerBankContactPerson,ContactIdentification1 reqSellerBankContactPerson )
    {
        SubmissionIdentification = reqSubmissionIdentification;
        TransactionIdentification = reqTransactionIdentification;
        Baseline = reqBaseline;
        BuyerBankContactPerson = reqBuyerBankContactPerson;
        SellerBankContactPerson = reqSellerBankContactPerson;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the submitted information.
    /// </summary>
    [IsoId("_mYyq49E8Ed-BzquC8wXy7w_-2146835384")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Submission Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 SubmissionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public MessageIdentification1 SubmissionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 SubmissionIdentification { get; init; } 
    #else
    public MessageIdentification1 SubmissionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_mYyq5NE8Ed-BzquC8wXy7w_-2146835402")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #else
    public SimpleIdentificationInformation TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_mYyq5dE8Ed-BzquC8wXy7w_-2146835349")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Submitter Transaction Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; } 
    #else
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the commercial details of the underlying transaction.
    /// </summary>
    [IsoId("_mYyq5tE8Ed-BzquC8wXy7w_-2146835307")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Baseline")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Baseline3 Baseline { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Baseline3 Baseline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Baseline3 Baseline { get; init; } 
    #else
    public Baseline3 Baseline { get; set; } 
    #endif
    
    /// <summary>
    /// Person to be contacted in the organisation of the buyer.
    /// </summary>
    [IsoId("_mYyq59E8Ed-BzquC8wXy7w_-2146835047")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Buyer Contact Person")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentification1? BuyerContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification1? BuyerContactPerson { get; init; } 
    #else
    public ContactIdentification1? BuyerContactPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Person to be contacted in the organisation of the seller.
    /// </summary>
    [IsoId("_mYyq6NE8Ed-BzquC8wXy7w_-2146834549")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Seller Contact Person")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentification1? SellerContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification1? SellerContactPerson { get; init; } 
    #else
    public ContactIdentification1? SellerContactPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Person to be contacted in the buyer's bank.
    /// </summary>
    [IsoId("_mYyq6dE8Ed-BzquC8wXy7w_-2146834627")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Buyer Bank Contact Person")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContactIdentification1 BuyerBankContactPerson { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ContactIdentification1 BuyerBankContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification1 BuyerBankContactPerson { get; init; } 
    #else
    public ContactIdentification1 BuyerBankContactPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Person to be contacted in the seller's bank.
    /// </summary>
    [IsoId("_mY700NE8Ed-BzquC8wXy7w_-2146834952")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Seller Bank Contact Person")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContactIdentification1 SellerBankContactPerson { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ContactIdentification1 SellerBankContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification1 SellerBankContactPerson { get; init; } 
    #else
    public ContactIdentification1 SellerBankContactPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Person to be contacted in another bank than the seller or buyer's bank.
    /// </summary>
    [IsoId("_mY700dE8Ed-BzquC8wXy7w_2007041364")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Other Bank Contact Person")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentification3? OtherBankContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification3? OtherBankContactPerson { get; init; } 
    #else
    public ContactIdentification3? OtherBankContactPerson { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BaselineReSubmissionV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BaselineReSubmissionV03Document ToDocument()
    {
        return new BaselineReSubmissionV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="BaselineReSubmissionV03"/>.
/// </summary>
[Serializable]
public partial record BaselineReSubmissionV03Document : IOuterDocument<BaselineReSubmissionV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BaselineReSubmissionV03"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BaselineReSubmissionV03 Message { get; init; }
    #else
    public BaselineReSubmissionV03 Message { get; init; }
    #endif
}
