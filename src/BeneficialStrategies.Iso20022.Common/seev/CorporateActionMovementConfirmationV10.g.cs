﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionMovementConfirmationV10.  ISO2002 ID# _BBQdR7T-EeiTob_PrFFUxA.
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
/// This record is an implementation of the seev.036.001.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CorporateActionMovementConfirmation message is sent by an account servicer to an account owner or its designated agent to confirm posting of securities or cash as a result of a corporate action event.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Description(@"Scope|The CorporateActionMovementConfirmation message is sent by an account servicer to an account owner or its designated agent to confirm posting of securities or cash as a result of a corporate action event.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).")]
[IsoId("_BBQdR7T-EeiTob_PrFFUxA")]
[DisplayName("Corporate Action Movement Confirmation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionMovementConfirmationV10 : IOuterRecord<CorporateActionMovementConfirmationV10,CorporateActionMovementConfirmationV10Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.036.001.10";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntConf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CorporateActionMovementConfirmationV10Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionMovementConfirmationV10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionMovementConfirmationV10( CorporateActionGeneralInformation126 reqCorporateActionGeneralInformation,AccountAndBalance43 reqAccountDetails,CorporateActionOption154 reqCorporateActionConfirmationDetails )
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
    [IsoId("_BBQdV7T-EeiTob_PrFFUxA")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
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
    [IsoId("_BBQdWbT-EeiTob_PrFFUxA")]
    [DisplayName("Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnId")]
    #endif
    [IsoXmlTag("NtfctnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification31? NotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification31? NotificationIdentification { get; init; } 
    #else
    public DocumentIdentification31? NotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_BBQdW7T-EeiTob_PrFFUxA")]
    [DisplayName("Movement Preliminary Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntPrlimryAdvcId")]
    #endif
    [IsoXmlTag("MvmntPrlimryAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification31? MovementPreliminaryAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification31? MovementPreliminaryAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification31? MovementPreliminaryAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_BBQdXbT-EeiTob_PrFFUxA")]
    [DisplayName("Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrId")]
    #endif
    [IsoXmlTag("InstrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification9? InstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification9? InstructionIdentification { get; init; } 
    #else
    public DocumentIdentification9? InstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_BBQdX7T-EeiTob_PrFFUxA")]
    [DisplayName("Other Document Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrDocId")]
    #endif
    [IsoXmlTag("OthrDocId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification32? OtherDocumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification32? OtherDocumentIdentification { get; init; } 
    #else
    public DocumentIdentification32? OtherDocumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of another corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_BBQdYbT-EeiTob_PrFFUxA")]
    [DisplayName("Events Linkage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtsLkg")]
    #endif
    [IsoXmlTag("EvtsLkg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventReference3? EventsLinkage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventReference3? EventsLinkage { get; init; } 
    #else
    public CorporateActionEventReference3? EventsLinkage { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_BBQdY7T-EeiTob_PrFFUxA")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionGeneralInformation126 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionGeneralInformation126 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformation126 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformation126 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_BBQdZbT-EeiTob_PrFFUxA")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountAndBalance43 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountAndBalance43 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountAndBalance43 AccountDetails { get; init; } 
    #else
    public AccountAndBalance43 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_BBQdZ7T-EeiTob_PrFFUxA")]
    [DisplayName("Corporate Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtls")]
    #endif
    [IsoXmlTag("CorpActnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateAction44? CorporateActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateAction44? CorporateActionDetails { get; init; } 
    #else
    public CorporateAction44? CorporateActionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_BBQdabT-EeiTob_PrFFUxA")]
    [DisplayName("Corporate Action Confirmation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnConfDtls")]
    #endif
    [IsoXmlTag("CorpActnConfDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption154 CorporateActionConfirmationDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption154 CorporateActionConfirmationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption154 CorporateActionConfirmationDetails { get; init; } 
    #else
    public CorporateActionOption154 CorporateActionConfirmationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_BBQda7T-EeiTob_PrFFUxA")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNarrative31? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNarrative31? AdditionalInformation { get; init; } 
    #else
    public CorporateActionNarrative31? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_BBQdbbT-EeiTob_PrFFUxA")]
    [DisplayName("Issuer Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrAgt")]
    #endif
    [IsoXmlTag("IssrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification120Choice_? IssuerAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification120Choice_? IssuerAgent { get; init; } 
    #else
    public PartyIdentification120Choice_? IssuerAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_BBQdb7T-EeiTob_PrFFUxA")]
    [DisplayName("Paying Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PngAgt")]
    #endif
    [IsoXmlTag("PngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification120Choice_? PayingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification120Choice_? PayingAgent { get; init; } 
    #else
    public PartyIdentification120Choice_? PayingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_BBQdcbT-EeiTob_PrFFUxA")]
    [DisplayName("Sub Paying Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubPngAgt")]
    #endif
    [IsoXmlTag("SubPngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification120Choice_? SubPayingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification120Choice_? SubPayingAgent { get; init; } 
    #else
    public PartyIdentification120Choice_? SubPayingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_BBQdc7T-EeiTob_PrFFUxA")]
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
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;CorporateActionMovementConfirmationV10Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionMovementConfirmationV10Document ToDocument()
    {
        return new CorporateActionMovementConfirmationV10Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;CorporateActionMovementConfirmationV10&quot;/&gt;.
/// </summary>
[Serializable]
public partial record CorporateActionMovementConfirmationV10Document : IOuterDocument<CorporateActionMovementConfirmationV10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.036.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;CorporateActionMovementConfirmationV10&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionMovementConfirmationV10 Message { get; init; }
    #else
    public CorporateActionMovementConfirmationV10 Message { get; init; }
    #endif
}
