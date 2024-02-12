﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ActionMessage1.  ISO2002 ID# _TEzSkAEcEeCQm6a_G2yO_w_1379249384.
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
/// Message to be displayed to the cardholder or the cashier.
/// </summary>
[IsoId("_TEzSkAEcEeCQm6a_G2yO_w_1379249384")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Action Message")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ActionMessage1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ActionMessage1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ActionMessage1( UserInterface1Code reqMessageDestination,System.String reqMessageContent )
    {
        MessageDestination = reqMessageDestination;
        MessageContent = reqMessageContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Destination of the message to be displayed or printed.
    /// </summary>
    [IsoId("_TEzSkQEcEeCQm6a_G2yO_w_-1322905232")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Message Destination")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UserInterface1Code MessageDestination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public UserInterface1Code MessageDestination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UserInterface1Code MessageDestination { get; init; } 
    #else
    public UserInterface1Code MessageDestination { get; set; } 
    #endif
    
    /// <summary>
    /// Text or graphic data to be display or printed to the cardholder or the cashier.
    /// </summary>
    [IsoId("_TEzSkgEcEeCQm6a_G2yO_w_-1205034247")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Message Content")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax256Text MessageContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String MessageContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageContent { get; init; } 
    #else
    public System.String MessageContent { get; set; } 
    #endif
    
    /// <summary>
    /// Electronic signature of the message to display or print.
    /// </summary>
    [IsoId("_TEzSkwEcEeCQm6a_G2yO_w_795149401")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Message Content Signature")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? MessageContentSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MessageContentSignature { get; init; } 
    #else
    public System.String? MessageContentSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
}
