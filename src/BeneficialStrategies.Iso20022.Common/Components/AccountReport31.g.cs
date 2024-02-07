﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountReport31.  ISO2002 ID# _FfqScStvEeysar7zFstVmw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details of the account report.
/// </summary>
public partial record AccountReport31
     : IIsoXmlSerilizable<AccountReport31>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account report.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Provides details on the page number of the report.
    /// Usage: The pagination of the report is only allowed when agreed between the parties.
    /// </summary>
    public Pagination1? ReportPagination { get; init; } 
    /// <summary>
    /// Sequential number of the report, as assigned by the account servicer. |Usage: The sequential number is increased incrementally for each report sent electronically.
    /// </summary>
    public IsoNumber? ElectronicSequenceNumber { get; init; } 
    /// <summary>
    /// Specifies the range of identification sequence numbers, as provided in the request.
    /// </summary>
    public SequenceRange1Choice_? ReportingSequence { get; init; } 
    /// <summary>
    /// Legal sequential number of the report, as assigned by the account servicer. It is increased incrementally for each report sent.
    /// </summary>
    public IsoNumber? LegalSequenceNumber { get; init; } 
    /// <summary>
    /// Date and time at which the report was created.
    /// </summary>
    public IsoISODateTime? CreationDateTime { get; init; } 
    /// <summary>
    /// Range of time between a start date and an end date for which the account report is issued.
    /// </summary>
    public DateTimePeriod1? FromToDate { get; init; } 
    /// <summary>
    /// Indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; } 
    /// <summary>
    /// Specifies the application used to generate the reporting.
    /// </summary>
    public ReportingSource1Choice_? ReportingSource { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account to which credit and debit entries are made.
    /// </summary>
    public required CashAccount41 Account { get; init; } 
    /// <summary>
    /// Identifies the parent account of the account for which the report has been issued.
    /// </summary>
    public CashAccount40? RelatedAccount { get; init; } 
    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    public AccountInterest4? Interest { get; init; } 
    /// <summary>
    /// Set of elements used to define the balance as a numerical representation of the net increases and decreases in an account at a specific point in time.
    /// </summary>
    public CashBalance8? Balance { get; init; } 
    /// <summary>
    /// Provides summary information on entries.
    /// </summary>
    public TotalTransactions6? TransactionsSummary { get; init; } 
    /// <summary>
    /// Specifies an entry in the report.
    /// Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// Usage Rule: In case of a Payments R-transaction the creditor / debtor referenced of the original payment initiation messages is also used for reporting of the R-transaction. The original debtor/creditor in the reporting of R-Transactions is not inverted. 
    /// Following elements all defined in the TransactionDetails in RelatedParties or RelatedAgents are impacted by this usage rule:
    /// Creditor, UltimateCreditor, CreditorAccount, CreditorAgent, Debtor, UltimateDebtor, DebtorAccount and DebtorAgent.
    /// </summary>
    public ReportEntry12? Entry { get; init; } 
    /// <summary>
    /// Further details of the account report.
    /// </summary>
    public IsoMax500Text? AdditionalReportInformation { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Id", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (ReportPagination is Pagination1 ReportPaginationValue)
        {
            writer.WriteStartElement(null, "RptPgntn", xmlNamespace );
            ReportPaginationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ElectronicSequenceNumber is IsoNumber ElectronicSequenceNumberValue)
        {
            writer.WriteStartElement(null, "ElctrncSeqNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(ElectronicSequenceNumberValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (ReportingSequence is SequenceRange1Choice_ ReportingSequenceValue)
        {
            writer.WriteStartElement(null, "RptgSeq", xmlNamespace );
            ReportingSequenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LegalSequenceNumber is IsoNumber LegalSequenceNumberValue)
        {
            writer.WriteStartElement(null, "LglSeqNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(LegalSequenceNumberValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (CreationDateTime is IsoISODateTime CreationDateTimeValue)
        {
            writer.WriteStartElement(null, "CreDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(CreationDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (FromToDate is DateTimePeriod1 FromToDateValue)
        {
            writer.WriteStartElement(null, "FrToDt", xmlNamespace );
            FromToDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CopyDuplicateIndicator is CopyDuplicate1Code CopyDuplicateIndicatorValue)
        {
            writer.WriteStartElement(null, "CpyDplctInd", xmlNamespace );
            writer.WriteValue(CopyDuplicateIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ReportingSource is ReportingSource1Choice_ ReportingSourceValue)
        {
            writer.WriteStartElement(null, "RptgSrc", xmlNamespace );
            ReportingSourceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Acct", xmlNamespace );
        Account.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (RelatedAccount is CashAccount40 RelatedAccountValue)
        {
            writer.WriteStartElement(null, "RltdAcct", xmlNamespace );
            RelatedAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Interest is AccountInterest4 InterestValue)
        {
            writer.WriteStartElement(null, "Intrst", xmlNamespace );
            InterestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Balance is CashBalance8 BalanceValue)
        {
            writer.WriteStartElement(null, "Bal", xmlNamespace );
            BalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionsSummary is TotalTransactions6 TransactionsSummaryValue)
        {
            writer.WriteStartElement(null, "TxsSummry", xmlNamespace );
            TransactionsSummaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Entry is ReportEntry12 EntryValue)
        {
            writer.WriteStartElement(null, "Ntry", xmlNamespace );
            EntryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalReportInformation is IsoMax500Text AdditionalReportInformationValue)
        {
            writer.WriteStartElement(null, "AddtlRptInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax500Text(AdditionalReportInformationValue)); // data type Max500Text System.String
            writer.WriteEndElement();
        }
    }
    public static AccountReport31 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
