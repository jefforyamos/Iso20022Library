﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TMSActionIdentification8.  ISO2002 ID# _ZSf7YVEtEeyApZmLzm74zA.
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
[IsoId("_ZSf7YVEtEeyApZmLzm74zA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("TMS Action Identification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TMSActionIdentification8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TMSActionIdentification8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TMSActionIdentification8( TerminalManagementAction5Code reqActionType )
    {
        ActionType = reqActionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Types of terminal management action performed by a point of interaction.
    /// </summary>
    [IsoId("_ZYlVQVEtEeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Action Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementAction5Code ActionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TerminalManagementAction5Code ActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementAction5Code ActionType { get; init; } 
    #else
    public TerminalManagementAction5Code ActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Data set on which the action has been performed.
    /// </summary>
    [IsoId("_ZYlVQ1EtEeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Data Set Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DataSetIdentification9? DataSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetIdentification9? DataSetIdentification { get; init; } 
    #else
    public DataSetIdentification9? DataSetIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
