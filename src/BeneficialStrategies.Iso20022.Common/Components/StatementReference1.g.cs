﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatementReference1.  ISO2002 ID# _VFEXo04jEeSGlfauTkCKIA.
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
/// Identifies the reference of the statment by a unique identifier and the date (and time).
/// </summary>
[IsoId("_VFEXo04jEeSGlfauTkCKIA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Statement Reference")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatementReference1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatementReference1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatementReference1( System.String reqStatementIdentification,DateAndDateTimeChoice_ reqStatementDateTime )
    {
        StatementIdentification = reqStatementIdentification;
        StatementDateTime = reqStatementDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference common to all pages of the statement for which the status advice is sent.
    /// </summary>
    [IsoId("_o3lf4k4jEeSGlfauTkCKIA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Statement Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text StatementIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String StatementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String StatementIdentification { get; init; } 
    #else
    public System.String StatementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time the statement was created.
    /// </summary>
    [IsoId("_o3lf404jEeSGlfauTkCKIA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Statement Date Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_ StatementDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Page number of the related message (within the statement) and continuation indicator to indicate that the statement is to continue or that the related message is the last page of the statement.
    /// </summary>
    [IsoId("_B1fu8U4kEeSGlfauTkCKIA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pagination")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination? Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination? Pagination { get; init; } 
    #else
    public Pagination? Pagination { get; set; } 
    #endif
    
    
    #nullable disable
    
}
