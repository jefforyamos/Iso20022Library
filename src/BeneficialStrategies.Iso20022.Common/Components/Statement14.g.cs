﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Statement14.  ISO2002 ID# _Qq8_gNp-Ed-ak6NoX_4Aeg_-2134324614.
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
/// Characteristics of the statement.
/// </summary>
[IsoId("_Qq8_gNp-Ed-ak6NoX_4Aeg_-2134324614")]
[DisplayName("Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Statement14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Statement14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Statement14( DateAndDateTimeChoice_ reqStatementDateTime,StatementStructure1Code reqStatementStructure,System.String reqActivityIndicator )
    {
        StatementDateTime = reqStatementDateTime;
        StatementStructure = reqStatementStructure;
        ActivityIndicator = reqActivityIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_Qq8_gdp-Ed-ak6NoX_4Aeg_-2133403455")]
    [DisplayName("Report Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptNb")]
    #endif
    [IsoXmlTag("RptNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Number3Choice_? ReportNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Number3Choice_? ReportNumber { get; init; } 
    #else
    public Number3Choice_? ReportNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_Qq8_gtp-Ed-ak6NoX_4Aeg_305927624")]
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
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_Qq8_g9p-Ed-ak6NoX_4Aeg_-2134324091")]
    [DisplayName("Statement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtId")]
    #endif
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? StatementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StatementIdentification { get; init; } 
    #else
    public System.String? StatementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    [IsoId("_Qq8_hNp-Ed-ak6NoX_4Aeg_-2133403575")]
    [DisplayName("Statement Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtDtTm")]
    #endif
    [IsoXmlTag("StmtDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_ StatementDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_Qq8_hdp-Ed-ak6NoX_4Aeg_-2133403540")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency4Choice_? Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency4Choice_? Frequency { get; init; } 
    #else
    public Frequency4Choice_? Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_Qq8_htp-Ed-ak6NoX_4Aeg_-2133403515")]
    [DisplayName("Update Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdTp")]
    #endif
    [IsoXmlTag("UpdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdateType2Choice_? UpdateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdateType2Choice_? UpdateType { get; init; } 
    #else
    public UpdateType2Choice_? UpdateType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the statement is sorted by status or transaction.
    /// </summary>
    [IsoId("_Qq8_h9p-Ed-ak6NoX_4Aeg_-2133403480")]
    [DisplayName("Statement Structure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtStr")]
    #endif
    [IsoXmlTag("StmtStr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatementStructure1Code StatementStructure { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatementStructure1Code StatementStructure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementStructure1Code StatementStructure { get; init; } 
    #else
    public StatementStructure1Code StatementStructure { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_Qq8_iNp-Ed-ak6NoX_4Aeg_-2133403498")]
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
