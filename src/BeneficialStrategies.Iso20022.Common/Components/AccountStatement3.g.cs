﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountStatement3.  ISO2002 ID# _tqvhIlkyEeGeoaLUQk__nA_-1076556870.
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
/// Provides further details of the account statement.
/// </summary>
[IsoId("_tqvhIlkyEeGeoaLUQk__nA_-1076556870")]
[DisplayName("Account Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountStatement3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountStatement3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountStatement3( System.String reqIdentification,System.DateTime reqCreationDateTime,CashAccount25 reqAccount )
    {
        Identification = reqIdentification;
        CreationDateTime = reqCreationDateTime;
        Account = reqAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account statement.
    /// </summary>
    [IsoId("_tqvhI1kyEeGeoaLUQk__nA_-2073629223")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the page number of the statement.
    /// Usage: The pagination of the statement is only allowed when agreed between the parties.
    /// </summary>
    [IsoId("_tqvhJFkyEeGeoaLUQk__nA_95626296")]
    [DisplayName("Statement Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtPgntn")]
    #endif
    [IsoXmlTag("StmtPgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination? StatementPagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination? StatementPagination { get; init; } 
    #else
    public Pagination? StatementPagination { get; set; } 
    #endif
    
    /// <summary>
    /// Sequential number of the statement, as assigned by the account servicer.|Usage: The sequential number is increased incrementally for each statement sent electronically.
    /// </summary>
    [IsoId("_tq5SIFkyEeGeoaLUQk__nA_-112375598")]
    [DisplayName("Electronic Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctrncSeqNb")]
    #endif
    [IsoXmlTag("ElctrncSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? ElectronicSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ElectronicSequenceNumber { get; init; } 
    #else
    public System.UInt64? ElectronicSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Legal sequential number of the statement, as assigned by the account servicer. It is increased incrementally for each statement sent.||Usage: Where a paper statement is a legal requirement, it may have a number different from the electronic sequential number. Paper statements could for instance only be sent if movement on the account has taken place, whereas electronic statements could be sent at the end of each reporting period, regardless of whether movements have taken place or not.
    /// </summary>
    [IsoId("_tq5SIVkyEeGeoaLUQk__nA_-1992681238")]
    [DisplayName("Legal Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglSeqNb")]
    #endif
    [IsoXmlTag("LglSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? LegalSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? LegalSequenceNumber { get; init; } 
    #else
    public System.UInt64? LegalSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_tq5SIlkyEeGeoaLUQk__nA_1094614502")]
    [DisplayName("Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDtTm")]
    #endif
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateTime { get; init; } 
    #else
    public System.DateTime CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Range of time between a start date and an end date for which the account statement is issued.
    /// </summary>
    [IsoId("_tq5SI1kyEeGeoaLUQk__nA_-1077648876")]
    [DisplayName("From To Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrToDt")]
    #endif
    [IsoXmlTag("FrToDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriodDetails? FromToDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriodDetails? FromToDate { get; init; } 
    #else
    public DateTimePeriodDetails? FromToDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("_tq5SJFkyEeGeoaLUQk__nA_-2122332456")]
    [DisplayName("Copy Duplicate Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpyDplctInd")]
    #endif
    [IsoXmlTag("CpyDplctInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; } 
    #else
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the application used to generate the reporting.
    /// </summary>
    [IsoId("_trCcEFkyEeGeoaLUQk__nA_371462")]
    [DisplayName("Reporting Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgSrc")]
    #endif
    [IsoXmlTag("RptgSrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReportingSource1Choice_? ReportingSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportingSource1Choice_? ReportingSource { get; init; } 
    #else
    public ReportingSource1Choice_? ReportingSource { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account to which credit and debit entries are made.
    /// </summary>
    [IsoId("_trCcEVkyEeGeoaLUQk__nA_581428124")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount25 Account { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount25 Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount25 Account { get; init; } 
    #else
    public CashAccount25 Account { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the parent account of the account for which the statement has been issued.
    /// </summary>
    [IsoId("_trCcElkyEeGeoaLUQk__nA_-386083520")]
    [DisplayName("Related Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdAcct")]
    #endif
    [IsoXmlTag("RltdAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? RelatedAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? RelatedAccount { get; init; } 
    #else
    public CashAccount24? RelatedAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    [IsoId("_trCcE1kyEeGeoaLUQk__nA_374681633")]
    [DisplayName("Interest")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Intrst")]
    #endif
    [IsoXmlTag("Intrst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountInterest2? Interest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountInterest2? Interest { get; init; } 
    #else
    public AccountInterest2? Interest { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to define the balance as a numerical representation of the net increases and decreases in an account at a specific point in time.
    /// </summary>
    [IsoId("_trCcFFkyEeGeoaLUQk__nA_1709532480")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    public ValueList<CashBalance3> Balance { get; init; } = new ValueList<CashBalance3>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _trCcFFkyEeGeoaLUQk__nA_1709532480
    
    /// <summary>
    /// Provides summary information on entries.
    /// </summary>
    [IsoId("_trMNEFkyEeGeoaLUQk__nA_-1635275225")]
    [DisplayName("Transactions Summary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxsSummry")]
    #endif
    [IsoXmlTag("TxsSummry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TotalTransactions2? TransactionsSummary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalTransactions2? TransactionsSummary { get; init; } 
    #else
    public TotalTransactions2? TransactionsSummary { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to specify an entry in the statement.|Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// </summary>
    [IsoId("_trMNEVkyEeGeoaLUQk__nA_-217685922")]
    [DisplayName("Entry")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntry")]
    #endif
    [IsoXmlTag("Ntry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReportEntry3? Entry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportEntry3? Entry { get; init; } 
    #else
    public ReportEntry3? Entry { get; set; } 
    #endif
    
    /// <summary>
    /// Further details of the account statement.
    /// </summary>
    [IsoId("_trMNElkyEeGeoaLUQk__nA_1765360007")]
    [DisplayName("Additional Statement Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlStmtInf")]
    #endif
    [IsoXmlTag("AddtlStmtInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? AdditionalStatementInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalStatementInformation { get; init; } 
    #else
    public System.String? AdditionalStatementInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
