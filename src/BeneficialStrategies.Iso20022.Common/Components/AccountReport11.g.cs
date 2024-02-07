﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountReport11.  ISO2002 ID# _RpFbtNp-Ed-ak6NoX_4Aeg_-1975945805.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide details of the account report.
/// </summary>
public partial record AccountReport11
     : IIsoXmlSerilizable<AccountReport11>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account report.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Sequential number of the report, as assigned by the account servicer. |Usage: The sequential number is increased incrementally for each report sent electronically.
    /// </summary>
    public IsoNumber? ElectronicSequenceNumber { get; init; } 
    /// <summary>
    /// Legal sequential number of the report, as assigned by the account servicer. It is increased incrementally for each report sent.
    /// </summary>
    public IsoNumber? LegalSequenceNumber { get; init; } 
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Range of time between a start date and an end date for which the account report is issued.
    /// </summary>
    public DateTimePeriodDetails? FromToDate { get; init; } 
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
    public required CashAccount20 Account { get; init; } 
    /// <summary>
    /// Identifies the parent account of the account for which the report has been issued.
    /// </summary>
    public CashAccount16? RelatedAccount { get; init; } 
    /// <summary>
    /// Set of elements used to provide general interest information that applies to the account at a particular moment in time.
    /// </summary>
    public AccountInterest2? Interest { get; init; } 
    /// <summary>
    /// Set of elements used to define the balance as a numerical representation of the net increases and decreases in an account at a specific point in time.
    /// </summary>
    public CashBalance3? Balance { get; init; } 
    /// <summary>
    /// Set of elements used to provide summary information on entries.
    /// </summary>
    public TotalTransactions2? TransactionsSummary { get; init; } 
    /// <summary>
    /// Set of elements used to specify an entry in the report.|Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// </summary>
    public ReportEntry2? Entry { get; init; } 
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
        if (ElectronicSequenceNumber is IsoNumber ElectronicSequenceNumberValue)
        {
            writer.WriteStartElement(null, "ElctrncSeqNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(ElectronicSequenceNumberValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (LegalSequenceNumber is IsoNumber LegalSequenceNumberValue)
        {
            writer.WriteStartElement(null, "LglSeqNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(LegalSequenceNumberValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CreDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(CreationDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        if (FromToDate is DateTimePeriodDetails FromToDateValue)
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
        if (RelatedAccount is CashAccount16 RelatedAccountValue)
        {
            writer.WriteStartElement(null, "RltdAcct", xmlNamespace );
            RelatedAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Interest is AccountInterest2 InterestValue)
        {
            writer.WriteStartElement(null, "Intrst", xmlNamespace );
            InterestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Balance is CashBalance3 BalanceValue)
        {
            writer.WriteStartElement(null, "Bal", xmlNamespace );
            BalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionsSummary is TotalTransactions2 TransactionsSummaryValue)
        {
            writer.WriteStartElement(null, "TxsSummry", xmlNamespace );
            TransactionsSummaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Entry is ReportEntry2 EntryValue)
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
    public static AccountReport11 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
