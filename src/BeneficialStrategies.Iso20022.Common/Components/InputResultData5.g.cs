﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InputResultData5.  ISO2002 ID# _RfXX0XGnEe2TbaNWBpRZpQ.
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
[IsoId("_RfXX0XGnEe2TbaNWBpRZpQ")]
[DisplayName("Input Result Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InputResultData5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InputResultData5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InputResultData5( InputCommand1Code reqInputCommand )
    {
        InputCommand = reqInputCommand;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of processed input.
    /// </summary>
    [IsoId("_RlwTsXGnEe2TbaNWBpRZpQ")]
    [DisplayName("Input Command")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InptCmd")]
    #endif
    [IsoXmlTag("InptCmd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InputCommand1Code InputCommand { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InputCommand1Code InputCommand { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InputCommand1Code InputCommand { get; init; } 
    #else
    public InputCommand1Code InputCommand { get; set; } 
    #endif
    
    /// <summary>
    /// Flag of notification of card to be entered in the POI card reader.
    /// </summary>
    [IsoId("_RlwTs3GnEe2TbaNWBpRZpQ")]
    [DisplayName("Confirmed Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfdFlg")]
    #endif
    [IsoXmlTag("ConfdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ConfirmedFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConfirmedFlag { get; init; } 
    #else
    public System.String? ConfirmedFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the number of the function key which is typed by the Customer on the POI system or the Cashier on the Sale System.
    /// </summary>
    [IsoId("_RlwTtXGnEe2TbaNWBpRZpQ")]
    [DisplayName("Function Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctnKey")]
    #endif
    [IsoXmlTag("FctnKey")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? FunctionKey { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? FunctionKey { get; init; } 
    #else
    public System.UInt64? FunctionKey { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the input text and data given by the POI or the Sale System.
    /// </summary>
    [IsoId("_RlwTt3GnEe2TbaNWBpRZpQ")]
    [DisplayName("Input Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InptMsg")]
    #endif
    [IsoXmlTag("InptMsg")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
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
    [IsoId("_RlwTuXGnEe2TbaNWBpRZpQ")]
    [DisplayName("Password")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pwd")]
    #endif
    [IsoXmlTag("Pwd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType34? Password { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType34? Password { get; init; } 
    #else
    public ContentInformationType34? Password { get; set; } 
    #endif
    
    /// <summary>
    /// Numeric value of a handwritten signature.
    /// </summary>
    [IsoId("_RlwTu3GnEe2TbaNWBpRZpQ")]
    [DisplayName("Image Captured Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ImgCaptrdSgntr")]
    #endif
    [IsoXmlTag("ImgCaptrdSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CapturedSignature1? ImageCapturedSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CapturedSignature1? ImageCapturedSignature { get; init; } 
    #else
    public CapturedSignature1? ImageCapturedSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
}
