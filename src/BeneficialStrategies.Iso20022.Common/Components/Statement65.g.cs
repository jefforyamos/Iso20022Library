﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Statement65.  ISO2002 ID# _lZD-8bQVEeemgtANb5gbCw.
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
/// General characteristics related to a statement which reports information.
/// </summary>
[IsoId("_lZD-8bQVEeemgtANb5gbCw")]
[DisplayName("Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Statement65
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Statement65 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Statement65( CorporateActionStatementType1Code reqStatementType,CorporateActionStatementReportingType1Code reqReportingType,System.String reqStatementIdentification,DateAndDateTime2Choice_ reqStatementDateTime,Frequency25Choice_ reqFrequency,UpdateType15Choice_ reqUpdateType,System.String reqActivityIndicator )
    {
        StatementType = reqStatementType;
        ReportingType = reqReportingType;
        StatementIdentification = reqStatementIdentification;
        StatementDateTime = reqStatementDateTime;
        Frequency = reqFrequency;
        UpdateType = reqUpdateType;
        ActivityIndicator = reqActivityIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the statement contains missing instructions only or all instructions.
    /// </summary>
    [IsoId("_lq6j8bQVEeemgtANb5gbCw")]
    [DisplayName("Statement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtTp")]
    #endif
    [IsoXmlTag("StmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionStatementType1Code StatementType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionStatementType1Code StatementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionStatementType1Code StatementType { get; init; } 
    #else
    public CorporateActionStatementType1Code StatementType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the statement report on account holdings for corporate action events is for single account/multiple events or multiple accounts/single event.
    /// </summary>
    [IsoId("_lq6j87QVEeemgtANb5gbCw")]
    [DisplayName("Reporting Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgTp")]
    #endif
    [IsoXmlTag("RptgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionStatementReportingType1Code ReportingType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionStatementReportingType1Code ReportingType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionStatementReportingType1Code ReportingType { get; init; } 
    #else
    public CorporateActionStatementReportingType1Code ReportingType { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the statement.
    /// </summary>
    [IsoId("_lq6j9bQVEeemgtANb5gbCw")]
    [DisplayName("Statement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtId")]
    #endif
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text StatementIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String StatementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String StatementIdentification { get; init; } 
    #else
    public System.String StatementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_lq6j97QVEeemgtANb5gbCw")]
    [DisplayName("Report Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptNb")]
    #endif
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5NumericText? ReportNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportNumber { get; init; } 
    #else
    public System.String? ReportNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_lq6j_7QVEeemgtANb5gbCw")]
    [DisplayName("Statement Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtDtTm")]
    #endif
    [IsoXmlTag("StmtDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTime2Choice_ StatementDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTime2Choice_ StatementDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_ StatementDateTime { get; init; } 
    #else
    public DateAndDateTime2Choice_ StatementDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_lq6kB7QVEeemgtANb5gbCw")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Frequency25Choice_ Frequency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Frequency25Choice_ Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency25Choice_ Frequency { get; init; } 
    #else
    public Frequency25Choice_ Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_lq6kD7QVEeemgtANb5gbCw")]
    [DisplayName("Update Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdTp")]
    #endif
    [IsoXmlTag("UpdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UpdateType15Choice_ UpdateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UpdateType15Choice_ UpdateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdateType15Choice_ UpdateType { get; init; } 
    #else
    public UpdateType15Choice_ UpdateType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_lq6kF7QVEeemgtANb5gbCw")]
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
    
    /// <summary>
    /// Period during which identification deadline has been set.
    /// </summary>
    [IsoId("_lq6kH7QVEeemgtANb5gbCw")]
    [DisplayName("Notification Deadline Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnDdlnPrd")]
    #endif
    [IsoXmlTag("NtfctnDdlnPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateOrDateTimePeriod2Choice_? NotificationDeadlinePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateOrDateTimePeriod2Choice_? NotificationDeadlinePeriod { get; init; } 
    #else
    public DateOrDateTimePeriod2Choice_? NotificationDeadlinePeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
