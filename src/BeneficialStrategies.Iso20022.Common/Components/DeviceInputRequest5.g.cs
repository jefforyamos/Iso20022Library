﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceInputRequest5.  ISO2002 ID# _OzUpUXGcEe2TbaNWBpRZpQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// Specifies the content of the input request message.
/// </summary>
[IsoId("_OzUpUXGcEe2TbaNWBpRZpQ")]
[DisplayName("Device Input Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceInputRequest5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeviceInputRequest5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeviceInputRequest5( InputData5 reqInputData )
    {
        InputData = reqInputData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information to display before input.
    /// </summary>
    [IsoId("_O5oFoXGcEe2TbaNWBpRZpQ")]
    [DisplayName("Display Output")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispOutpt")]
    #endif
    [IsoXmlTag("DispOutpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionMessage10? DisplayOutput { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage10? DisplayOutput { get; init; } 
    #else
    public ActionMessage10? DisplayOutput { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to an Input request.
    /// </summary>
    [IsoId("_O5oFo3GcEe2TbaNWBpRZpQ")]
    [DisplayName("Input Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InptData")]
    #endif
    [IsoXmlTag("InptData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InputData5 InputData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InputData5 InputData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InputData5 InputData { get; init; } 
    #else
    public InputData5 InputData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
