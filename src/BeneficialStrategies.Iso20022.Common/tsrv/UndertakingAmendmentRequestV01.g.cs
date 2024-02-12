﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for UndertakingAmendmentRequestV01.  ISO2002 ID# _9f3CdnltEeG7BsjMvd1mEw_-206674723.
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


namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// This record is an implementation of the tsrv.004.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingAmendmentRequest message is sent by the party that requested issuance of the undertaking (applicant or obligor) to the party that issued the undertaking to request issuance of a proposed amendment to the undertaking. The undertaking could be a demand guarantee, standby letter of credit, counter-undertaking (counter-guarantee or counter-standby), or suretyship undertaking. The message provides details on proposed changes to the undertaking, for example, to the expiry date, amount, and/or terms and conditions. It may also be used to request termination or cancellation of the undertaking.
/// </summary>
[Description(@"The UndertakingAmendmentRequest message is sent by the party that requested issuance of the undertaking (applicant or obligor) to the party that issued the undertaking to request issuance of a proposed amendment to the undertaking. The undertaking could be a demand guarantee, standby letter of credit, counter-undertaking (counter-guarantee or counter-standby), or suretyship undertaking. The message provides details on proposed changes to the undertaking, for example, to the expiry date, amount, and/or terms and conditions. It may also be used to request termination or cancellation of the undertaking.")]
[IsoId("_9f3CdnltEeG7BsjMvd1mEw_-206674723")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Undertaking Amendment Request V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingAmendmentRequestV01 : IOuterRecord<UndertakingAmendmentRequestV01,UndertakingAmendmentRequestV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.004.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgAmdmntReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => UndertakingAmendmentRequestV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UndertakingAmendmentRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingAmendmentRequestV01( Amendment3 reqUndertakingAmendmentRequestDetails )
    {
        UndertakingAmendmentRequestDetails = reqUndertakingAmendmentRequestDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details related to the request for an amendment of an undertaking.
    /// </summary>
    [IsoId("_9f3Cd3ltEeG7BsjMvd1mEw_-1387733041")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Undertaking Amendment Request Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amendment3 UndertakingAmendmentRequestDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Amendment3 UndertakingAmendmentRequestDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amendment3 UndertakingAmendmentRequestDetails { get; init; } 
    #else
    public Amendment3 UndertakingAmendmentRequestDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Instructions specific to the bank receiving the message.
    /// </summary>
    [IsoId("_MZwWVX_6EeGOn4dfTT_QdQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instructions To Bank")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(0)]
    [MaxLength(5)]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    #endif
    public SimpleValueList<System.String> InstructionsToBank { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Digital signature of the undertaking amendment request.
    /// </summary>
    [IsoId("_9f3CeHltEeG7BsjMvd1mEw_-2129123977")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Digital Signature")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #else
    public PartyAndSignature2? DigitalSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="UndertakingAmendmentRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public UndertakingAmendmentRequestV01Document ToDocument()
    {
        return new UndertakingAmendmentRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="UndertakingAmendmentRequestV01"/>.
/// </summary>
[Serializable]
public partial record UndertakingAmendmentRequestV01Document : IOuterDocument<UndertakingAmendmentRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.004.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="UndertakingAmendmentRequestV01"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingAmendmentRequestV01 Message { get; init; }
    #else
    public UndertakingAmendmentRequestV01 Message { get; init; }
    #endif
}
