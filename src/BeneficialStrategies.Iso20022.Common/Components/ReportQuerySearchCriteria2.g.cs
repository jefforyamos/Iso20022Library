﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportQuerySearchCriteria2.  ISO2002 ID# _3b6DFZb6Eee4htziCyV8eA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a report.
/// </summary>
public partial record ReportQuerySearchCriteria2
     : IIsoXmlSerilizable<ReportQuerySearchCriteria2>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public AccountIdentificationSearchCriteria2Choice_? AccountIdentification { get; init; } 
    /// <summary>
    /// Numerical representation of the net increases and decreases in an account at a specific point in time. A cash balance is calculated from a sum of cash credits minus a sum of cash debits.
    /// </summary>
    public CashBalance12? Balance { get; init; } 
    /// <summary>
    /// Values of possible reports.
    /// </summary>
    public IsoMax4AlphaNumericText? ReportName { get; init; } 
    /// <summary>
    /// Specifies the query message name identifier to which the message refers.
    /// </summary>
    public IsoMax35Text? MessageNameIdentification { get; init; } 
    /// <summary>
    /// Report owning party.
    /// </summary>
    public required PartyIdentification136 PartyIdentification { get; init; } 
    /// <summary>
    /// Responsible Party of the report owning party.
    /// </summary>
    public PartyIdentification136? ResponsiblePartyIdentification { get; init; } 
    /// <summary>
    /// Date and time when the report was created.
    /// </summary>
    public DatePeriodSearch1Choice_? DateSearch { get; init; } 
    /// <summary>
    /// Time when the (business) event, which triggered the report, was scheduled.
    /// </summary>
    public DateTimePeriod1Choice_? ScheduledTime { get; init; } 
    /// <summary>
    /// Execution type is executed based on an event driven trigger.
    /// </summary>
    public EventType1Choice_? Event { get; init; } 
    
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
        if (AccountIdentification is AccountIdentificationSearchCriteria2Choice_ AccountIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctId", xmlNamespace );
            AccountIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Balance is CashBalance12 BalanceValue)
        {
            writer.WriteStartElement(null, "Bal", xmlNamespace );
            BalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReportName is IsoMax4AlphaNumericText ReportNameValue)
        {
            writer.WriteStartElement(null, "RptNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax4AlphaNumericText(ReportNameValue)); // data type Max4AlphaNumericText System.String
            writer.WriteEndElement();
        }
        if (MessageNameIdentification is IsoMax35Text MessageNameIdentificationValue)
        {
            writer.WriteStartElement(null, "MsgNmId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MessageNameIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PtyId", xmlNamespace );
        PartyIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ResponsiblePartyIdentification is PartyIdentification136 ResponsiblePartyIdentificationValue)
        {
            writer.WriteStartElement(null, "RspnsblPtyId", xmlNamespace );
            ResponsiblePartyIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DateSearch is DatePeriodSearch1Choice_ DateSearchValue)
        {
            writer.WriteStartElement(null, "DtSch", xmlNamespace );
            DateSearchValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ScheduledTime is DateTimePeriod1Choice_ ScheduledTimeValue)
        {
            writer.WriteStartElement(null, "SchdldTm", xmlNamespace );
            ScheduledTimeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Event is EventType1Choice_ EventValue)
        {
            writer.WriteStartElement(null, "Evt", xmlNamespace );
            EventValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ReportQuerySearchCriteria2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
