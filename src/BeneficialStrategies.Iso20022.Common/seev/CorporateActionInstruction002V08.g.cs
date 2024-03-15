﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionInstruction002V08.  ISO2002 ID# _VGk7s83vEee5nJBZsW8MFQ.
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


namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.033.002.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner sends the CorporateActionInstruction message to an account servicer to instruct election on a corporate action event.|
/// This message is used to provide the custodian with instructions on how the account owner wishes to proceed with a corporate action event. Instructions include investment decisions regarding the exercise of rights issues, the election of stock or cash when the option is available, and decisions on the conversion or tendering of securities.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),
/// using the relevant elements in the business application header (BAH).
/// </summary>
[Description(@"Scope|An account owner sends the CorporateActionInstruction message to an account servicer to instruct election on a corporate action event.||This message is used to provide the custodian with instructions on how the account owner wishes to proceed with a corporate action event. Instructions include investment decisions regarding the exercise of rights issues, the election of stock or cash when the option is available, and decisions on the conversion or tendering of securities.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).")]
[IsoId("_VGk7s83vEee5nJBZsW8MFQ")]
[DisplayName("Corporate Action Instruction 002 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionInstruction002V08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.033.002.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnInstr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.033.002.08";
    
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
    /// Constructs a CorporateActionInstruction002V08 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionInstruction002V08( CorporateActionGeneralInformation115 reqCorporateActionGeneralInformation,AccountAndBalance37 reqAccountDetails,CorporateActionOption146 reqCorporateActionInstruction )
    {
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        AccountDetails = reqAccountDetails;
        CorporateActionInstruction = reqCorporateActionInstruction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// When used in a corporate action instruction, indicates that the current instruction is replacing a previous one that was cancelled earlier. When used in a corporate action instruction cancellation request, indicates that cancelled instruction will be replaced by a new corporate action instruction to be sent later.
    /// </summary>
    [IsoId("_VGk7v83vEee5nJBZsW8MFQ")]
    [DisplayName("Change Instruction Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChngInstrInd")]
    #endif
    [IsoXmlTag("ChngInstrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ChangeInstructionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ChangeInstructionIndicator { get; init; } 
    #else
    public System.String? ChangeInstructionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a previously sent cancelled instruction document.
    /// </summary>
    [IsoId("_VGk7wc3vEee5nJBZsW8MFQ")]
    [DisplayName("Cancelled Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CancInstrId")]
    #endif
    [IsoXmlTag("CancInstrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification37? CancelledInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification37? CancelledInstructionIdentification { get; init; } 
    #else
    public DocumentIdentification37? CancelledInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a previously sent instruction cancellation request document.
    /// </summary>
    [IsoId("_VGk7w83vEee5nJBZsW8MFQ")]
    [DisplayName("Instruction Cancellation Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrCxlReqId")]
    #endif
    [IsoXmlTag("InstrCxlReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification37? InstructionCancellationRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification37? InstructionCancellationRequestIdentification { get; init; } 
    #else
    public DocumentIdentification37? InstructionCancellationRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_VGk7xc3vEee5nJBZsW8MFQ")]
    [DisplayName("Other Document Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrDocId")]
    #endif
    [IsoXmlTag("OthrDocId")]
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
    [IsoId("_VGk7x83vEee5nJBZsW8MFQ")]
    [DisplayName("Events Linkage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtsLkg")]
    #endif
    [IsoXmlTag("EvtsLkg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventReference4? EventsLinkage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventReference4? EventsLinkage { get; init; } 
    #else
    public CorporateActionEventReference4? EventsLinkage { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_VGk7yc3vEee5nJBZsW8MFQ")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionGeneralInformation115 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionGeneralInformation115 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformation115 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformation115 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_VGk7y83vEee5nJBZsW8MFQ")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountAndBalance37 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountAndBalance37 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountAndBalance37 AccountDetails { get; init; } 
    #else
    public AccountAndBalance37 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the beneficial owner of the securities.
    /// </summary>
    [IsoId("_VGk7zc3vEee5nJBZsW8MFQ")]
    [DisplayName("Beneficial Owner Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfclOwnrDtls")]
    #endif
    [IsoXmlTag("BnfclOwnrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification101? BeneficialOwnerDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification101? BeneficialOwnerDetails { get; init; } 
    #else
    public PartyIdentification101? BeneficialOwnerDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the corporate action instruction.
    /// </summary>
    [IsoId("_VGk7z83vEee5nJBZsW8MFQ")]
    [DisplayName("Corporate Action Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnInstr")]
    #endif
    [IsoXmlTag("CorpActnInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption146 CorporateActionInstruction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption146 CorporateActionInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption146 CorporateActionInstruction { get; init; } 
    #else
    public CorporateActionOption146 CorporateActionInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_VGliwc3vEee5nJBZsW8MFQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNarrative34? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNarrative34? AdditionalInformation { get; init; } 
    #else
    public CorporateActionNarrative34? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_VGliw83vEee5nJBZsW8MFQ")]
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


// Since CorporateActionInstruction002V08Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionInstruction002V08.

