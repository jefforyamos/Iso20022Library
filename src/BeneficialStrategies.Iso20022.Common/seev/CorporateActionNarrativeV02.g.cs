﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionNarrativeV02.  ISO2002 ID# _4Ozz0eZ9Ed-q8fx_Zl_34A.
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
/// This record is an implementation of the seev.038.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CorporateActionNarrative message is sent between an account servicer and an account owner or its designated agent to cater for tax reclaims, restrictions, documentation requirements. This message is bi-directional.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),
/// using the relevant elements in the business application header (BAH).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Description(@"Scope|The CorporateActionNarrative message is sent between an account servicer and an account owner or its designated agent to cater for tax reclaims, restrictions, documentation requirements. This message is bi-directional.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
[IsoId("_4Ozz0eZ9Ed-q8fx_Zl_34A")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action Narrative V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionNarrativeV02 : IOuterRecord<CorporateActionNarrativeV02,CorporateActionNarrativeV02Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.038.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnNrrtv";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CorporateActionNarrativeV02Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionNarrativeV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionNarrativeV02( CorporateActionGeneralInformation10 reqCorporateActionGeneralInformation,UpdatedAdditionalInformation2 reqAdditionalInformation )
    {
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        AdditionalInformation = reqAdditionalInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// General information about the safekeeping account and the account owner.
    /// </summary>
    [IsoId("_4Ozz1eZ9Ed-q8fx_Zl_34A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification14Choice_? AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification14Choice_? AccountDetails { get; init; } 
    #else
    public AccountIdentification14Choice_? AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the securitised right for entitlement.
    /// </summary>
    [IsoId("_4Ozz1-Z9Ed-q8fx_Zl_34A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Underlying Security")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnderlyingSecurity3? UnderlyingSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingSecurity3? UnderlyingSecurity { get; init; } 
    #else
    public UnderlyingSecurity3? UnderlyingSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_4Ozz2eZ9Ed-q8fx_Zl_34A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Corporate Action General Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionGeneralInformation10 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CorporateActionGeneralInformation10 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformation10 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformation10 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_4Ozz2-Z9Ed-q8fx_Zl_34A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UpdatedAdditionalInformation2 AdditionalInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public UpdatedAdditionalInformation2 AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation2 AdditionalInformation { get; init; } 
    #else
    public UpdatedAdditionalInformation2 AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_4Ozz4eZ9Ed-q8fx_Zl_34A")]
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
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionNarrativeV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionNarrativeV02Document ToDocument()
    {
        return new CorporateActionNarrativeV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionNarrativeV02"/>.
/// </summary>
[Serializable]
public partial record CorporateActionNarrativeV02Document : IOuterDocument<CorporateActionNarrativeV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.038.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionNarrativeV02"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionNarrativeV02 Message { get; init; }
    #else
    public CorporateActionNarrativeV02 Message { get; init; }
    #endif
}
