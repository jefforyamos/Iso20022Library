﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionInstructionStatusAdvice002V12.  ISO2002 ID# _9E_-Yx9QEeuFz_FaCzCLgQ.
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
/// This record is an implementation of the seev.034.002.12 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CorporateActionInstructionStatusAdvice message is sent by an account servicer to an account owner or its designated agent, to report the status of a received corporate action election instruction.|
/// This message is used to advise the status, or a change in status, of a corporate action-related transaction previously instructed by, or executed on behalf of, the account owner. This will include the acknowledgement/rejection of a corporate action instruction.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Description(@"Scope|The CorporateActionInstructionStatusAdvice message is sent by an account servicer to an account owner or its designated agent, to report the status of a received corporate action election instruction.||This message is used to advise the status, or a change in status, of a corporate action-related transaction previously instructed by, or executed on behalf of, the account owner. This will include the acknowledgement/rejection of a corporate action instruction.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).")]
[IsoId("_9E_-Yx9QEeuFz_FaCzCLgQ")]
[DisplayName("Corporate Action Instruction Status Advice 002 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionInstructionStatusAdvice002V12 : IOuterRecord<CorporateActionInstructionStatusAdvice002V12,CorporateActionInstructionStatusAdvice002V12Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.034.002.12";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnInstrStsAdvc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CorporateActionInstructionStatusAdvice002V12Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionInstructionStatusAdvice002V12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionInstructionStatusAdvice002V12( CorporateActionGeneralInformation158 reqCorporateActionGeneralInformation,InstructionProcessingStatus44Choice_ reqInstructionProcessingStatus )
    {
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        InstructionProcessingStatus = reqInstructionProcessingStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_9E_-bB9QEeuFz_FaCzCLgQ")]
    [DisplayName("Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrId")]
    #endif
    [IsoXmlTag("InstrId")]
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
    [IsoId("_9E_-bh9QEeuFz_FaCzCLgQ")]
    [DisplayName("Other Document Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrDocId")]
    #endif
    [IsoXmlTag("OthrDocId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification34? OtherDocumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification34? OtherDocumentIdentification { get; init; } 
    #else
    public DocumentIdentification34? OtherDocumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_9E_-cB9QEeuFz_FaCzCLgQ")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionGeneralInformation158 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionGeneralInformation158 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformation158 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformation158 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the processing status of the instruction.
    /// </summary>
    [IsoId("_9E_-ch9QEeuFz_FaCzCLgQ")]
    [DisplayName("Instruction Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrPrcgSts")]
    #endif
    [IsoXmlTag("InstrPrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstructionProcessingStatus44Choice_ InstructionProcessingStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InstructionProcessingStatus44Choice_ InstructionProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionProcessingStatus44Choice_ InstructionProcessingStatus { get; init; } 
    #else
    public InstructionProcessingStatus44Choice_ InstructionProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the corporate action instruction.
    /// </summary>
    [IsoId("_9E_-dB9QEeuFz_FaCzCLgQ")]
    [DisplayName("Corporate Action Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnInstr")]
    #endif
    [IsoXmlTag("CorpActnInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionOption187? CorporateActionInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption187? CorporateActionInstruction { get; init; } 
    #else
    public CorporateActionOption187? CorporateActionInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on protect and cover protect instructions.
    /// </summary>
    [IsoId("_9E_-dh9QEeuFz_FaCzCLgQ")]
    [DisplayName("Protect Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctInstr")]
    #endif
    [IsoXmlTag("PrtctInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProtectInstruction6? ProtectInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProtectInstruction6? ProtectInstruction { get; init; } 
    #else
    public ProtectInstruction6? ProtectInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_9E_-eB9QEeuFz_FaCzCLgQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNarrative19? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNarrative19? AdditionalInformation { get; init; } 
    #else
    public CorporateActionNarrative19? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_9E_-eh9QEeuFz_FaCzCLgQ")]
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
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;CorporateActionInstructionStatusAdvice002V12Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionInstructionStatusAdvice002V12Document ToDocument()
    {
        return new CorporateActionInstructionStatusAdvice002V12Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;CorporateActionInstructionStatusAdvice002V12&quot;/&gt;.
/// </summary>
[Serializable]
public partial record CorporateActionInstructionStatusAdvice002V12Document : IOuterDocument<CorporateActionInstructionStatusAdvice002V12>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.034.002.12";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;CorporateActionInstructionStatusAdvice002V12&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionInstructionStatusAdvice002V12 Message { get; init; }
    #else
    public CorporateActionInstructionStatusAdvice002V12 Message { get; init; }
    #endif
}
