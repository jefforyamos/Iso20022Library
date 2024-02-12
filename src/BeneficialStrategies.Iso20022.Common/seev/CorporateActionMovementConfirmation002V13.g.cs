﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionMovementConfirmation002V13.  ISO2002 ID# _plKLMzi7Eeydid5dcNPKvg.
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


namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.036.002.13 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CorporateActionMovementConfirmation message is sent by an account servicer to an account owner or its designated agent to confirm the posting of securities or cash as a result of a corporate action event.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Description(@"Scope|The CorporateActionMovementConfirmation message is sent by an account servicer to an account owner or its designated agent to confirm the posting of securities or cash as a result of a corporate action event.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).")]
[IsoId("_plKLMzi7Eeydid5dcNPKvg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action Movement Confirmation 002 V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionMovementConfirmation002V13 : IOuterRecord<CorporateActionMovementConfirmation002V13,CorporateActionMovementConfirmation002V13Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.036.002.13";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntConf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CorporateActionMovementConfirmation002V13Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionMovementConfirmation002V13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionMovementConfirmation002V13( CorporateActionGeneralInformation167 reqCorporateActionGeneralInformation,AccountAndBalance52 reqAccountDetails,CorporateActionOption205 reqCorporateActionConfirmationDetails )
    {
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        AccountDetails = reqAccountDetails;
        CorporateActionConfirmationDetails = reqCorporateActionConfirmationDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part notification is to continue or that the message is the last page of the multi-part notification.
    /// </summary>
    [IsoId("_plKLSji7Eeydid5dcNPKvg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pagination")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination1? Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination1? Pagination { get; init; } 
    #else
    public Pagination1? Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a previously sent notification document.
    /// </summary>
    [IsoId("_plKLTDi7Eeydid5dcNPKvg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Notification Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification37? NotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification37? NotificationIdentification { get; init; } 
    #else
    public DocumentIdentification37? NotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_plKLTji7Eeydid5dcNPKvg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Movement Preliminary Advice Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification37? MovementPreliminaryAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification37? MovementPreliminaryAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification37? MovementPreliminaryAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_plKLUDi7Eeydid5dcNPKvg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instruction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification17? InstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification17? InstructionIdentification { get; init; } 
    #else
    public DocumentIdentification17? InstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_plKLUji7Eeydid5dcNPKvg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Other Document Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification38? OtherDocumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification38? OtherDocumentIdentification { get; init; } 
    #else
    public DocumentIdentification38? OtherDocumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of another corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_plKLVDi7Eeydid5dcNPKvg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Events Linkage")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventReference4? EventsLinkage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventReference4? EventsLinkage { get; init; } 
    #else
    public CorporateActionEventReference4? EventsLinkage { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction type and identification information.
    /// </summary>
    [IsoId("_plKLVji7Eeydid5dcNPKvg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentification1? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentification1? TransactionIdentification { get; init; } 
    #else
    public TransactionIdentification1? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_plKLWDi7Eeydid5dcNPKvg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Corporate Action General Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionGeneralInformation167 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CorporateActionGeneralInformation167 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformation167 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformation167 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_plKLWji7Eeydid5dcNPKvg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountAndBalance52 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AccountAndBalance52 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountAndBalance52 AccountDetails { get; init; } 
    #else
    public AccountAndBalance52 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_plKLXDi7Eeydid5dcNPKvg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Corporate Action Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateAction64? CorporateActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateAction64? CorporateActionDetails { get; init; } 
    #else
    public CorporateAction64? CorporateActionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_plKLXji7Eeydid5dcNPKvg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Corporate Action Confirmation Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption205 CorporateActionConfirmationDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CorporateActionOption205 CorporateActionConfirmationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption205 CorporateActionConfirmationDetails { get; init; } 
    #else
    public CorporateActionOption205 CorporateActionConfirmationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_plKLYDi7Eeydid5dcNPKvg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNarrative35? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNarrative35? AdditionalInformation { get; init; } 
    #else
    public CorporateActionNarrative35? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_plKLYji7Eeydid5dcNPKvg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Issuer Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification137Choice_? IssuerAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification137Choice_? IssuerAgent { get; init; } 
    #else
    public PartyIdentification137Choice_? IssuerAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_plKLZDi7Eeydid5dcNPKvg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Paying Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification137Choice_? PayingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification137Choice_? PayingAgent { get; init; } 
    #else
    public PartyIdentification137Choice_? PayingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_plKLZji7Eeydid5dcNPKvg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sub Paying Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification137Choice_? SubPayingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification137Choice_? SubPayingAgent { get; init; } 
    #else
    public PartyIdentification137Choice_? SubPayingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_plKLaDi7Eeydid5dcNPKvg")]
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
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionMovementConfirmation002V13Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionMovementConfirmation002V13Document ToDocument()
    {
        return new CorporateActionMovementConfirmation002V13Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionMovementConfirmation002V13"/>.
/// </summary>
[Serializable]
public partial record CorporateActionMovementConfirmation002V13Document : IOuterDocument<CorporateActionMovementConfirmation002V13>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.036.002.13";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionMovementConfirmation002V13"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionMovementConfirmation002V13 Message { get; init; }
    #else
    public CorporateActionMovementConfirmation002V13 Message { get; init; }
    #endif
}
