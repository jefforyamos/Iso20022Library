﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Statement36.  ISO2002 ID# _AcC2ULoSEeG42ruQI3Ffkw_-1601696264.
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
/// Characteristics of the report.
/// </summary>
[IsoId("_AcC2ULoSEeG42ruQI3Ffkw_-1601696264")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Statement")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Statement36
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Statement36 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Statement36( System.String reqHistoricData,System.String reqActivityIndicator,System.String reqSubAccountIndicator )
    {
        HistoricData = reqHistoricData;
        ActivityIndicator = reqActivityIndicator;
        SubAccountIndicator = reqSubAccountIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_AcC2UboSEeG42ruQI3Ffkw_1810037745")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Query Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? QueryReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QueryReference { get; init; } 
    #else
    public System.String? QueryReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference common to all pages of a report.
    /// </summary>
    [IsoId("_AcC2UroSEeG42ruQI3Ffkw_812965392")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Report Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReportIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportIdentification { get; init; } 
    #else
    public System.String? ReportIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the data is either historical (true) or current (false).
    /// </summary>
    [IsoId("_AcC2U7oSEeG42ruQI3Ffkw_-184106961")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Historic Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator HistoricData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String HistoricData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String HistoricData { get; init; } 
    #else
    public System.String HistoricData { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_AcC2VLoSEeG42ruQI3Ffkw_-1295018380")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Activity Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ActivityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ActivityIndicator { get; init; } 
    #else
    public System.String ActivityIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the statement reports holdings at subsafekeeping account level.
    /// </summary>
    [IsoId("_AcC2VboSEeG42ruQI3Ffkw_2002876563")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sub Account Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator SubAccountIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String SubAccountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SubAccountIndicator { get; init; } 
    #else
    public System.String SubAccountIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
