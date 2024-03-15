﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MovementReport1.  ISO2002 ID# _jf2uIe5NEeCisYr99QEiWA_-2045963141.
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
/// Characteristics of the report.
/// </summary>
[IsoId("_jf2uIe5NEeCisYr99QEiWA_-2045963141")]
[DisplayName("Movement Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MovementReport1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MovementReport1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MovementReport1( MovementResponseType1Code reqQueryType,System.String reqActivityIndicator )
    {
        QueryType = reqQueryType;
        ActivityIndicator = reqActivityIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the Query message sent to request this statement.
    /// </summary>
    [IsoId("_jf2uIu5NEeCisYr99QEiWA_1138092736")]
    [DisplayName("Query Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryRef")]
    #endif
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
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
    [IsoId("_jf2uI-5NEeCisYr99QEiWA_2135165089")]
    [DisplayName("Report Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptId")]
    #endif
    [IsoXmlTag("RptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReportIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportIdentification { get; init; } 
    #else
    public System.String? ReportIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the type of query.
    /// </summary>
    [IsoId("_jf2uJO5NEeCisYr99QEiWA_141020383")]
    [DisplayName("Query Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryTp")]
    #endif
    [IsoXmlTag("QryTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MovementResponseType1Code QueryType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MovementResponseType1Code QueryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MovementResponseType1Code QueryType { get; init; } 
    #else
    public MovementResponseType1Code QueryType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_jgAfIO5NEeCisYr99QEiWA_-856051970")]
    [DisplayName("Activity Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActvtyInd")]
    #endif
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ActivityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ActivityIndicator { get; init; } 
    #else
    public System.String ActivityIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
