﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TMSEvent7.  ISO2002 ID# _v5e-URBcEeqgJK7e3n_EXA.
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
/// Result of an individual terminal management action performed by the point of interaction.
/// </summary>
[IsoId("_v5e-URBcEeqgJK7e3n_EXA")]
[DisplayName("TMS Event")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TMSEvent7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TMSEvent7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TMSEvent7( System.DateTime reqTimeStamp,TerminalManagementActionResult4Code reqResult,TMSActionIdentification6 reqActionIdentification )
    {
        TimeStamp = reqTimeStamp;
        Result = reqResult;
        ActionIdentification = reqActionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date time of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_wEbqERBcEeqgJK7e3n_EXA")]
    [DisplayName("Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmStmp")]
    #endif
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TimeStamp { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime TimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TimeStamp { get; init; } 
    #else
    public System.DateTime TimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Final result of the processed terminal management action.
    /// </summary>
    [IsoId("_wEbqExBcEeqgJK7e3n_EXA")]
    [DisplayName("Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rslt")]
    #endif
    [IsoXmlTag("Rslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementActionResult4Code Result { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementActionResult4Code Result { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementActionResult4Code Result { get; init; } 
    #else
    public TerminalManagementActionResult4Code Result { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_wEbqFRBcEeqgJK7e3n_EXA")]
    [DisplayName("Action Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnId")]
    #endif
    [IsoXmlTag("ActnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TMSActionIdentification6 ActionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TMSActionIdentification6 ActionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TMSActionIdentification6 ActionIdentification { get; init; } 
    #else
    public TMSActionIdentification6 ActionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to a failure.
    /// </summary>
    [IsoId("_wEbqFxBcEeqgJK7e3n_EXA")]
    [DisplayName("Additional Error Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlErrInf")]
    #endif
    [IsoXmlTag("AddtlErrInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AdditionalErrorInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalErrorInformation { get; init; } 
    #else
    public System.String? AdditionalErrorInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the terminal management system (TMS) used with the action.
    /// </summary>
    [IsoId("_wEbqGRBcEeqgJK7e3n_EXA")]
    [DisplayName("Terminal Manager Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlMgrId")]
    #endif
    [IsoXmlTag("TermnlMgrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TerminalManagerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TerminalManagerIdentification { get; init; } 
    #else
    public System.String? TerminalManagerIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
