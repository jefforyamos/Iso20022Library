﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PointOfInteractionCapabilities8.  ISO2002 ID# _Z6U5gdkHEeiojJsa6FYyew.
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
/// Capabilities of the POI (Point Of Interaction) performing the transaction.
/// </summary>
[IsoId("_Z6U5gdkHEeiojJsa6FYyew")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Point Of Interaction Capabilities")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionCapabilities8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Card reading capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_aD4eIdkHEeiojJsa6FYyew")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card Reading Capabilities")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading6Code? CardReadingCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading6Code? CardReadingCapabilities { get; init; } 
    #else
    public CardDataReading6Code? CardReadingCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder verification capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_aD5FMdkHEeiojJsa6FYyew")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cardholder Verification Capabilities")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderVerificationCapability4Code? CardholderVerificationCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderVerificationCapability4Code? CardholderVerificationCapabilities { get; init; } 
    #else
    public CardholderVerificationCapability4Code? CardholderVerificationCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of digits the POI is able to accept when the cardholder enters its PIN.
    /// </summary>
    [IsoId("_aD5FM9kHEeiojJsa6FYyew")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("PIN Length Capabilities")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPositiveNumber? PINLengthCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PINLengthCapabilities { get; init; } 
    #else
    public System.UInt64? PINLengthCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of characters of the approval code the POI is able to manage.
    /// </summary>
    [IsoId("_aD5FNdkHEeiojJsa6FYyew")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Approval Code Length")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPositiveNumber? ApprovalCodeLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ApprovalCodeLength { get; init; } 
    #else
    public System.UInt64? ApprovalCodeLength { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum data length in bytes that a card issuer can return to the ICC at the terminal.
    /// </summary>
    [IsoId("_aD5FN9kHEeiojJsa6FYyew")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Max Script Length")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPositiveNumber? MaxScriptLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaxScriptLength { get; init; } 
    #else
    public System.UInt64? MaxScriptLength { get; set; } 
    #endif
    
    /// <summary>
    /// True if the POI is able to capture card.
    /// </summary>
    [IsoId("_aD5FOdkHEeiojJsa6FYyew")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card Capture Capable")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardCaptureCapable { get; init; } 
    #else
    public System.String? CardCaptureCapable { get; set; } 
    #endif
    
    /// <summary>
    /// On-line and off-line capabilities of the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_aD5FO9kHEeiojJsa6FYyew")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("On Line Capabilities")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OnLineCapability1Code? OnLineCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OnLineCapability1Code? OnLineCapabilities { get; init; } 
    #else
    public OnLineCapability1Code? OnLineCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Capabilities of the terminal to display or print message to the cardholder and the merchant.
    /// </summary>
    [IsoId("_aD5FPdkHEeiojJsa6FYyew")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Message Capabilities")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DisplayCapabilities4? MessageCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisplayCapabilities4? MessageCapabilities { get; init; } 
    #else
    public DisplayCapabilities4? MessageCapabilities { get; set; } 
    #endif
    
    
    #nullable disable
    
}
