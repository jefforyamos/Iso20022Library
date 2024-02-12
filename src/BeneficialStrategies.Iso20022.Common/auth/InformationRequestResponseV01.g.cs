﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for InformationRequestResponseV01.  ISO2002 ID# _6iqtkDzdEeGl7N0Cd54dlw.
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


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.002.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This message is sent by the financial institution to the authorities (police, customs, tax authorities, enforcement authorities) to provide a part or all of the requested information.
/// The financial institution previously received a request for financial information in the scope of a financial investigation.
/// 
/// Depending on whether the response can be provided STP within the authorities financial investigations messages, the requested information may be 
/// •	provided in part or in full within the response message itself, or 
/// •	only referred to in the response message.
/// </summary>
[Description(@"This message is sent by the financial institution to the authorities (police, customs, tax authorities, enforcement authorities) to provide a part or all of the requested information.|The financial institution previously received a request for financial information in the scope of a financial investigation.||Depending on whether the response can be provided STP within the authorities financial investigations messages, the requested information may be |•	provided in part or in full within the response message itself, or |•	only referred to in the response message.")]
[IsoId("_6iqtkDzdEeGl7N0Cd54dlw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Information Request Response V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InformationRequestResponseV01 : IOuterRecord<InformationRequestResponseV01,InformationRequestResponseV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.002.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InfReqRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => InformationRequestResponseV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InformationRequestResponseV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InformationRequestResponseV01( System.String reqResponseIdentification,System.String reqInvestigationIdentification,StatusResponse1Code reqResponseStatus,SearchCriteria1Choice_ reqSearchCriteria,ReturnIndicator1 reqReturnIndicator )
    {
        ResponseIdentification = reqResponseIdentification;
        InvestigationIdentification = reqInvestigationIdentification;
        ResponseStatus = reqResponseStatus;
        SearchCriteria = reqSearchCriteria;
        ReturnIndicator = reqReturnIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification for the specific investigation as know by the responding party.
    /// </summary>
    [IsoId("_DSEUezzjEeGl7N0Cd54dlw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Response Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ResponseIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ResponseIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ResponseIdentification { get; init; } 
    #else
    public System.String ResponseIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification for the specific investigation as known by the requesting party.
    /// </summary>
    [IsoId("_gF8WOzzoEeGl7N0Cd54dlw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Investigation Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text InvestigationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String InvestigationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InvestigationIdentification { get; init; } 
    #else
    public System.String InvestigationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status of the response.
    /// </summary>
    [IsoId("_t0ETGzzoEeGl7N0Cd54dlw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Response Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatusResponse1Code ResponseStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public StatusResponse1Code ResponseStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusResponse1Code ResponseStatus { get; init; } 
    #else
    public StatusResponse1Code ResponseStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the the search criteria for the financial institution to perform the search on. The search criteria can be an account, a customer identification or a payment instrument type.
    /// </summary>
    [IsoId("_U4B7wV0zEeGwFY7pvwHH-g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Search Criteria")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SearchCriteria1Choice_ SearchCriteria { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SearchCriteria1Choice_ SearchCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SearchCriteria1Choice_ SearchCriteria { get; init; } 
    #else
    public SearchCriteria1Choice_ SearchCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the return indicators and the investigation result.
    /// </summary>
    [IsoId("_UbboITzuEeGl7N0Cd54dlw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Return Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReturnIndicator1 ReturnIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ReturnIndicator1 ReturnIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReturnIndicator1 ReturnIndicator { get; init; } 
    #else
    public ReturnIndicator1 ReturnIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_ICHsnzzvEeGl7N0Cd54dlw")]
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
    /// Using the state of this record, returns a populated <seealso cref="InformationRequestResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public InformationRequestResponseV01Document ToDocument()
    {
        return new InformationRequestResponseV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="InformationRequestResponseV01"/>.
/// </summary>
[Serializable]
public partial record InformationRequestResponseV01Document : IOuterDocument<InformationRequestResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.002.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="InformationRequestResponseV01"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InformationRequestResponseV01 Message { get; init; }
    #else
    public InformationRequestResponseV01 Message { get; init; }
    #endif
}
