﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InputResultData1.  ISO2002 ID# _MagU8N7GEeiwsev40qZGEQ.
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
/// Information related to an Input request.
/// </summary>
[IsoId("_MagU8N7GEeiwsev40qZGEQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Input Result Data")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InputResultData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InputResultData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InputResultData1( InputCommand1Code reqInputCommand )
    {
        InputCommand = reqInputCommand;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of processed input.
    /// </summary>
    [IsoId("_TFtosN7GEeiwsev40qZGEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Input Command")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InputCommand1Code InputCommand { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public InputCommand1Code InputCommand { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InputCommand1Code InputCommand { get; init; } 
    #else
    public InputCommand1Code InputCommand { get; set; } 
    #endif
    
    /// <summary>
    /// Flag of notification of card to be entered in the POI card reader.
    /// </summary>
    [IsoId("_V66UMN7GEeiwsev40qZGEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Confirmed Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ConfirmedFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConfirmedFlag { get; init; } 
    #else
    public System.String? ConfirmedFlag { get; set; } 
    #endif
    
    /// <summary>
    /// The number of the function key which is typed by the Customer on the POI system or the Cashier on the Sale System.
    /// </summary>
    [IsoId("_azkFMN7GEeiwsev40qZGEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Function Key")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? FunctionKey { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? FunctionKey { get; init; } 
    #else
    public System.UInt64? FunctionKey { get; set; } 
    #endif
    
    /// <summary>
    /// The input text and data given by the POI or the Sale System.
    /// </summary>
    [IsoId("_g6fnMN7GEeiwsev40qZGEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Input Message")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax20000Text? InputMessage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InputMessage { get; init; } 
    #else
    public System.String? InputMessage { get; set; } 
    #endif
    
    /// <summary>
    /// An enciphered password typed by the Customer on the POI system or the Cashier on the Sale system.
    /// </summary>
    [IsoId("_6VurcN7GEeiwsev40qZGEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Password")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType19? Password { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType19? Password { get; init; } 
    #else
    public ContentInformationType19? Password { get; set; } 
    #endif
    
    /// <summary>
    /// Numeric value of a handwritten signature.
    /// </summary>
    [IsoId("_PDzMce2uEei-V5h0ja04AA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Image Captured Signature")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CapturedSignature1? ImageCapturedSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CapturedSignature1? ImageCapturedSignature { get; init; } 
    #else
    public CapturedSignature1? ImageCapturedSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
}
