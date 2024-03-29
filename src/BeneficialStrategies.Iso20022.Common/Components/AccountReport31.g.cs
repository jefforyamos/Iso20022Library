﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountReport31.  ISO2002 ID# _FfqScStvEeysar7zFstVmw.
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
/// Provides further details of the account report.
/// </summary>
[IsoId("_FfqScStvEeysar7zFstVmw")]
[DisplayName("Account Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountReport31
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountReport31 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountReport31( System.String reqIdentification,CashAccount41 reqAccount )
    {
        Identification = reqIdentification;
        Account = reqAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account report.
    /// </summary>
    [IsoId("_F3DewStvEeysar7zFstVmw")]
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
    /// Provides details on the page number of the report.
    /// Usage: The pagination of the report is only allowed when agreed between the parties.
    /// </summary>
    [IsoId("_F3DewytvEeysar7zFstVmw")]
    [DisplayName("Report Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptPgntn")]
    #endif
    [IsoXmlTag("RptPgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination1? ReportPagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination1? ReportPagination { get; init; } 
    #else
    public Pagination1? ReportPagination { get; set; } 
    #endif
    
    /// <summary>
    /// Sequential number of the report, as assigned by the account servicer. |Usage: The sequential number is increased incrementally for each report sent electronically.
    /// </summary>
    [IsoId("_F3DexStvEeysar7zFstVmw")]
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
    /// Specifies the range of identification sequence numbers, as provided in the request.
    /// </summary>
    [IsoId("_F3DexytvEeysar7zFstVmw")]
    [DisplayName("Reporting Sequence")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgSeq")]
    #endif
    [IsoXmlTag("RptgSeq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SequenceRange1Choice_? ReportingSequence { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SequenceRange1Choice_? ReportingSequence { get; init; } 
    #else
    public SequenceRange1Choice_? ReportingSequence { get; set; } 
    #endif
    
    /// <summary>
    /// Legal sequential number of the report, as assigned by the account servicer. It is increased incrementally for each report sent.
    /// </summary>
    [IsoId("_F3DeyStvEeysar7zFstVmw")]
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
    /// Date and time at which the report was created.
    /// </summary>
    [IsoId("_F3DeyytvEeysar7zFstVmw")]
    [DisplayName("Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDtTm")]
    #endif
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? CreationDateTime { get; init; } 
    #else
    public System.DateTime? CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Range of time between a start date and an end date for which the account report is issued.
    /// </summary>
    [IsoId("_F3DezStvEeysar7zFstVmw")]
    [DisplayName("From To Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrToDt")]
    #endif
    [IsoXmlTag("FrToDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriod1? FromToDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1? FromToDate { get; init; } 
    #else
    public DateTimePeriod1? FromToDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("_F3DezytvEeysar7zFstVmw")]
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
    [IsoId("_F3De0StvEeysar7zFstVmw")]
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
    [IsoId("_F3De0ytvEeysar7zFstVmw")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount41 Account { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount41 Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount41 Account { get; init; } 
    #else
    public CashAccount41 Account { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the parent account of the account for which the report has been issued.
    /// </summary>
    [IsoId("_F3De1StvEeysar7zFstVmw")]
    [DisplayName("Related Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdAcct")]
    #endif
    [IsoXmlTag("RltdAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? RelatedAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? RelatedAccount { get; init; } 
    #else
    public CashAccount40? RelatedAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    [IsoId("_F3De1ytvEeysar7zFstVmw")]
    [DisplayName("Interest")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Intrst")]
    #endif
    [IsoXmlTag("Intrst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountInterest4? Interest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountInterest4? Interest { get; init; } 
    #else
    public AccountInterest4? Interest { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to define the balance as a numerical representation of the net increases and decreases in an account at a specific point in time.
    /// </summary>
    [IsoId("_F3De2StvEeysar7zFstVmw")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashBalance8? Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashBalance8? Balance { get; init; } 
    #else
    public CashBalance8? Balance { get; set; } 
    #endif
    
    /// <summary>
    /// Provides summary information on entries.
    /// </summary>
    [IsoId("_F3De2ytvEeysar7zFstVmw")]
    [DisplayName("Transactions Summary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxsSummry")]
    #endif
    [IsoXmlTag("TxsSummry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TotalTransactions6? TransactionsSummary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalTransactions6? TransactionsSummary { get; init; } 
    #else
    public TotalTransactions6? TransactionsSummary { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies an entry in the report.
    /// Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// Usage Rule: In case of a Payments R-transaction the creditor / debtor referenced of the original payment initiation messages is also used for reporting of the R-transaction. The original debtor/creditor in the reporting of R-Transactions is not inverted. 
    /// Following elements all defined in the TransactionDetails in RelatedParties or RelatedAgents are impacted by this usage rule:
    /// Creditor, UltimateCreditor, CreditorAccount, CreditorAgent, Debtor, UltimateDebtor, DebtorAccount and DebtorAgent.
    /// </summary>
    [IsoId("_F3De3StvEeysar7zFstVmw")]
    [DisplayName("Entry")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntry")]
    #endif
    [IsoXmlTag("Ntry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReportEntry12? Entry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportEntry12? Entry { get; init; } 
    #else
    public ReportEntry12? Entry { get; set; } 
    #endif
    
    /// <summary>
    /// Further details of the account report.
    /// </summary>
    [IsoId("_F3De3ytvEeysar7zFstVmw")]
    [DisplayName("Additional Report Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRptInf")]
    #endif
    [IsoXmlTag("AddtlRptInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? AdditionalReportInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalReportInformation { get; init; } 
    #else
    public System.String? AdditionalReportInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
