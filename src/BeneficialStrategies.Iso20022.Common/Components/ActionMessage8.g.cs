﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ActionMessage8.  ISO2002 ID# _o3qxoS8jEeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information to display, print or store.
/// </summary>
[IsoId("_o3qxoS8jEeu125Ip9zFcsQ")]
[DisplayName("Action Message")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ActionMessage8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ActionMessage8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ActionMessage8( UserInterface4Code reqMessageDestination,System.String reqMessageContent )
    {
        MessageDestination = reqMessageDestination;
        MessageContent = reqMessageContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Destination of the message.
    /// </summary>
    [IsoId("_pEcpYS8jEeu125Ip9zFcsQ")]
    [DisplayName("Message Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgDstn")]
    #endif
    [IsoXmlTag("MsgDstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UserInterface4Code MessageDestination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UserInterface4Code MessageDestination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UserInterface4Code MessageDestination { get; init; } 
    #else
    public UserInterface4Code MessageDestination { get; set; } 
    #endif
    
    /// <summary>
    /// Qualification of the information to sent to an output logical device.
    /// </summary>
    [IsoId("_pEcpYy8jEeu125Ip9zFcsQ")]
    [DisplayName("Information Qualifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfQlfr")]
    #endif
    [IsoXmlTag("InfQlfr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InformationQualify1Code? InformationQualifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InformationQualify1Code? InformationQualifier { get; init; } 
    #else
    public InformationQualify1Code? InformationQualifier { get; set; } 
    #endif
    
    /// <summary>
    /// Message format.
    /// </summary>
    [IsoId("_pEcpZS8jEeu125Ip9zFcsQ")]
    [DisplayName("Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frmt")]
    #endif
    [IsoXmlTag("Frmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OutputFormat3Code? Format { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OutputFormat3Code? Format { get; init; } 
    #else
    public OutputFormat3Code? Format { get; set; } 
    #endif
    
    /// <summary>
    /// Content or reference of the message.
    /// </summary>
    [IsoId("_pEcpZy8jEeu125Ip9zFcsQ")]
    [DisplayName("Message Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgCntt")]
    #endif
    [IsoXmlTag("MsgCntt")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20000Text MessageContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageContent { get; init; } 
    #else
    public System.String MessageContent { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature of the message.
    /// </summary>
    [IsoId("_pEcpaS8jEeu125Ip9zFcsQ")]
    [DisplayName("Message Content Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgCnttSgntr")]
    #endif
    [IsoXmlTag("MsgCnttSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType25? MessageContentSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType25? MessageContentSignature { get; init; } 
    #else
    public ContentInformationType25? MessageContentSignature { get; set; } 
    #endif
    
    /// <summary>
    /// Content of message displayed or printed as Barcode.
    /// </summary>
    [IsoId("_pEcpay8jEeu125Ip9zFcsQ")]
    [DisplayName("Output Barcode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutptBrcd")]
    #endif
    [IsoXmlTag("OutptBrcd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OutputBarcode1? OutputBarcode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OutputBarcode1? OutputBarcode { get; init; } 
    #else
    public OutputBarcode1? OutputBarcode { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to request a message response.
    /// </summary>
    [IsoId("_pEcpbS8jEeu125Ip9zFcsQ")]
    [DisplayName("Response Required Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnReqrdFlg")]
    #endif
    [IsoXmlTag("RspnReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ResponseRequiredFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ResponseRequiredFlag { get; init; } 
    #else
    public System.String? ResponseRequiredFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Number of seconds the message has to be displayed.
    /// </summary>
    [IsoId("_pEcpby8jEeu125Ip9zFcsQ")]
    [DisplayName("Minimum Display Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinDispTm")]
    #endif
    [IsoXmlTag("MinDispTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MinimumDisplayTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MinimumDisplayTime { get; init; } 
    #else
    public System.UInt64? MinimumDisplayTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
