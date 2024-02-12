﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InputData5.  ISO2002 ID# _iw6rEXGaEe2TbaNWBpRZpQ.
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
/// Information related to an input request.
/// </summary>
[IsoId("_iw6rEXGaEe2TbaNWBpRZpQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Input Data")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InputData5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InputData5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InputData5( SaleCapabilities2Code reqDeviceType,InformationQualify1Code reqInformationQualifier,InputCommand1Code reqInputCommand,System.String reqNotifyCardInputFlag )
    {
        DeviceType = reqDeviceType;
        InformationQualifier = reqInformationQualifier;
        InputCommand = reqInputCommand;
        NotifyCardInputFlag = reqNotifyCardInputFlag;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of logical device located on a Sale Terminal or a POI Terminal.
    /// </summary>
    [IsoId("_i3hpYXGaEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Device Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SaleCapabilities2Code DeviceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SaleCapabilities2Code DeviceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SaleCapabilities2Code DeviceType { get; init; } 
    #else
    public SaleCapabilities2Code DeviceType { get; set; } 
    #endif
    
    /// <summary>
    /// Qualification of the information to output to the logical device.
    /// </summary>
    [IsoId("_i3hpY3GaEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Information Qualifier")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InformationQualify1Code InformationQualifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public InformationQualify1Code InformationQualifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InformationQualify1Code InformationQualifier { get; init; } 
    #else
    public InformationQualify1Code InformationQualifier { get; set; } 
    #endif
    
    /// <summary>
    /// Type of requested input.
    /// </summary>
    [IsoId("_i3hpZXGaEe2TbaNWBpRZpQ")]
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
    [IsoId("_i3hpZ3GaEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Notify Card Input Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator NotifyCardInputFlag { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String NotifyCardInputFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NotifyCardInputFlag { get; init; } 
    #else
    public System.String NotifyCardInputFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum input time in seconds.
    /// </summary>
    [IsoId("_i3hpaXGaEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Maximum Input Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumInputTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumInputTime { get; init; } 
    #else
    public System.UInt64? MaximumInputTime { get; set; } 
    #endif
    
    /// <summary>
    /// Text value set for an input command.
    /// </summary>
    [IsoId("_i3hpa3GaEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Input Text")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionMessage10? InputText { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage10? InputText { get; init; } 
    #else
    public ActionMessage10? InputText { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to request Immediate response without waiting for the completion of the command.
    /// </summary>
    [IsoId("_i3hpbXGaEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Immediate Response Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ImmediateResponseFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ImmediateResponseFlag { get; init; } 
    #else
    public System.String? ImmediateResponseFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to confirm by the user the entered characters, when the maximum allowed length is reached.
    /// </summary>
    [IsoId("_i3hpb3GaEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Wait User Validation Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? WaitUserValidationFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WaitUserValidationFlag { get; init; } 
    #else
    public System.String? WaitUserValidationFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to indicate that when the user press a key, a beep has to be generated.
    /// </summary>
    [IsoId("_i3hpcXGaEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Beep Key Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? BeepKeyFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BeepKeyFlag { get; init; } 
    #else
    public System.String? BeepKeyFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to correct all characters (True) or just the last one (False).
    /// </summary>
    [IsoId("_i3hpc3GaEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Global Correction Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? GlobalCorrectionFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GlobalCorrectionFlag { get; init; } 
    #else
    public System.String? GlobalCorrectionFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to deactivate the "Cancel" function key.
    /// </summary>
    [IsoId("_i3hpdXGaEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Disable Cancel Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? DisableCancelFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DisableCancelFlag { get; init; } 
    #else
    public System.String? DisableCancelFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to deactivate the "Correct" function key.
    /// </summary>
    [IsoId("_i3hpd3GaEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Disable Correct Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? DisableCorrectFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DisableCorrectFlag { get; init; } 
    #else
    public System.String? DisableCorrectFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to disable the "Valid" function key.
    /// </summary>
    [IsoId("_i3hpeXGaEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Disable Valid Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? DisableValidFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DisableValidFlag { get; init; } 
    #else
    public System.String? DisableValidFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to enable the "Back" function key to go the upper level.
    /// </summary>
    [IsoId("_i3hpe3GaEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Menu Back Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? MenuBackFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MenuBackFlag { get; init; } 
    #else
    public System.String? MenuBackFlag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
