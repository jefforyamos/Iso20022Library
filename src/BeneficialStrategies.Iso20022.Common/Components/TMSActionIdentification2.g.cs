﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TMSActionIdentification2.  ISO2002 ID# _jjG3ASmtEeKIjpr--01h3Q.
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
/// Result of an individual terminal management action by the point of interaction.
/// </summary>
[IsoId("_jjG3ASmtEeKIjpr--01h3Q")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("TMS Action Identification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TMSActionIdentification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TMSActionIdentification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TMSActionIdentification2( TerminalManagementAction1Code reqActionType )
    {
        ActionType = reqActionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Types of terminal management action performed by a point of interaction.
    /// </summary>
    [IsoId("_jvcp4SmtEeKIjpr--01h3Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Action Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementAction1Code ActionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TerminalManagementAction1Code ActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementAction1Code ActionType { get; init; } 
    #else
    public TerminalManagementAction1Code ActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Data set on which the action has been performed.
    /// </summary>
    [IsoId("_jvcp5SmtEeKIjpr--01h3Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Data Set Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DataSetIdentification3? DataSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetIdentification3? DataSetIdentification { get; init; } 
    #else
    public DataSetIdentification3? DataSetIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
