﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MeetingNotice5.  ISO2002 ID# _jhJgEa09EemDtrWpq90Ckg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a meeting, participation requirements and voting procedures.
/// </summary>
public partial record MeetingNotice5
     : IIsoXmlSerilizable<MeetingNotice5>
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to the general meeting by the party that provides the meeting notification. It must be unique to the party providing the notification
    /// </summary>
    public IsoMax35Text? MeetingIdentification { get; init; } 
    /// <summary>
    /// Identification assigned to the meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    public IsoMax35Text? IssuerMeetingIdentification { get; init; } 
    /// <summary>
    /// Type of security holders meeting.
    /// </summary>
    public required MeetingType4Code Type { get; init; } 
    /// <summary>
    /// Classification of the meeting.
    /// </summary>
    public MeetingTypeClassification2Choice_? Classification { get; init; } 
    /// <summary>
    /// Official meeting announcement date.
    /// </summary>
    public IsoISODate? AnnouncementDate { get; init; } 
    /// <summary>
    /// Method of voting participation to the general meeting and related voting deadline per method of participation.
    /// </summary>
    public ParticipationMethod1? Participation { get; init; } 
    /// <summary>
    /// Information and conditions for physical attendance at the general meeting.
    /// </summary>
    public Attendance1? Attendance { get; init; } 
    /// <summary>
    /// Address to use over the www (HTTP) service where additional information on the meeting may be found.
    /// </summary>
    public IsoMax2048Text? AdditionalDocumentationURLAddress { get; init; } 
    /// <summary>
    /// Additional procedural information about the general meeting, specifying the participation requirements and the voting procedures. Alternatively, this may indicate where such information may be obtained.
    /// </summary>
    public ValueList<AdditionalRights3> AdditionalProcedureDetails { get; init; } = [];
    /// <summary>
    /// Number of securities admitted to the vote, expressed as an amount and a currency.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? TotalNumberOfSecuritiesOutstanding { get; init; } 
    /// <summary>
    /// Number of rights admitted to the vote.
    /// </summary>
    public IsoNumber? TotalNumberOfVotingRights { get; init; } 
    /// <summary>
    /// Address where the information on the proxy should be sent.
    /// </summary>
    public PostalAddress1? ProxyAppointmentNotificationAddress { get; init; } 
    /// <summary>
    /// Specifies the proxy or whether a proxy is not allowed.
    /// </summary>
    public Proxy3Choice_? ProxyChoice { get; init; } 
    /// <summary>
    /// Contact person at the party organising the meeting, at the issuer or at an intermediary.
    /// </summary>
    public ValueList<MeetingContactPerson3> ContactPersonDetails { get; init; } = [];
    /// <summary>
    /// Date on which the company publishes the results of its meeting.
    /// </summary>
    public DateFormat3Choice_? ResultPublicationDate { get; init; } 
    /// <summary>
    /// Date by which the blocking period for the securities should end.
    /// </summary>
    public IsoISODateTime? SecuritiesBlockingPeriodEndDate { get; init; } 
    /// <summary>
    /// Date at which the positions are struck to record which parties will receive the entitlement, for example, record date, book close date.
    /// </summary>
    public DateFormat1? EntitlementFixingDate { get; init; } 
    /// <summary>
    /// Date by which the securities have to be registered. This deadline is specified by an intermediary.
    /// </summary>
    public DateFormat58Choice_? RegistrationSecuritiesDeadline { get; init; } 
    /// <summary>
    /// Date by which the securities have to be registered. This deadline is set by the issuer.
    /// </summary>
    public DateFormat58Choice_? RegistrationSecuritiesMarketDeadline { get; init; } 
    /// <summary>
    /// Date by which the holder needs to register its intention to participate in the meeting process in order to be allowed to participate in the meeting event. This deadline is specified by an intermediary.
    /// </summary>
    public DateFormat58Choice_? RegistrationParticipationDeadline { get; init; } 
    /// <summary>
    /// Date by which the holder needs to register its intention to participate in the meeting process in order to be allowed to participate in the meeting event. This deadline is set by the issuer.
    /// </summary>
    public DateFormat58Choice_? RegistrationParticipationMarketDeadline { get; init; } 
    
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
        if (MeetingIdentification is IsoMax35Text MeetingIdentificationValue)
        {
            writer.WriteStartElement(null, "MtgId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MeetingIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (IssuerMeetingIdentification is IsoMax35Text IssuerMeetingIdentificationValue)
        {
            writer.WriteStartElement(null, "IssrMtgId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(IssuerMeetingIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(Type.ToString()); // Enum value
        writer.WriteEndElement();
        if (Classification is MeetingTypeClassification2Choice_ ClassificationValue)
        {
            writer.WriteStartElement(null, "Clssfctn", xmlNamespace );
            ClassificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AnnouncementDate is IsoISODate AnnouncementDateValue)
        {
            writer.WriteStartElement(null, "AnncmntDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(AnnouncementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (Participation is ParticipationMethod1 ParticipationValue)
        {
            writer.WriteStartElement(null, "Prtcptn", xmlNamespace );
            ParticipationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Attendance is Attendance1 AttendanceValue)
        {
            writer.WriteStartElement(null, "Attndnc", xmlNamespace );
            AttendanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalDocumentationURLAddress is IsoMax2048Text AdditionalDocumentationURLAddressValue)
        {
            writer.WriteStartElement(null, "AddtlDcmnttnURLAdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax2048Text(AdditionalDocumentationURLAddressValue)); // data type Max2048Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AddtlPrcdrDtls", xmlNamespace );
        AdditionalProcedureDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TotalNumberOfSecuritiesOutstanding is FinancialInstrumentQuantity18Choice_ TotalNumberOfSecuritiesOutstandingValue)
        {
            writer.WriteStartElement(null, "TtlNbOfSctiesOutsdng", xmlNamespace );
            TotalNumberOfSecuritiesOutstandingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalNumberOfVotingRights is IsoNumber TotalNumberOfVotingRightsValue)
        {
            writer.WriteStartElement(null, "TtlNbOfVtngRghts", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(TotalNumberOfVotingRightsValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (ProxyAppointmentNotificationAddress is PostalAddress1 ProxyAppointmentNotificationAddressValue)
        {
            writer.WriteStartElement(null, "PrxyAppntmntNtfctnAdr", xmlNamespace );
            ProxyAppointmentNotificationAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProxyChoice is Proxy3Choice_ ProxyChoiceValue)
        {
            writer.WriteStartElement(null, "PrxyChc", xmlNamespace );
            ProxyChoiceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CtctPrsnDtls", xmlNamespace );
        ContactPersonDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ResultPublicationDate is DateFormat3Choice_ ResultPublicationDateValue)
        {
            writer.WriteStartElement(null, "RsltPblctnDt", xmlNamespace );
            ResultPublicationDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesBlockingPeriodEndDate is IsoISODateTime SecuritiesBlockingPeriodEndDateValue)
        {
            writer.WriteStartElement(null, "SctiesBlckgPrdEndDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(SecuritiesBlockingPeriodEndDateValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (EntitlementFixingDate is DateFormat1 EntitlementFixingDateValue)
        {
            writer.WriteStartElement(null, "EntitlmntFxgDt", xmlNamespace );
            EntitlementFixingDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RegistrationSecuritiesDeadline is DateFormat58Choice_ RegistrationSecuritiesDeadlineValue)
        {
            writer.WriteStartElement(null, "RegnSctiesDdln", xmlNamespace );
            RegistrationSecuritiesDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RegistrationSecuritiesMarketDeadline is DateFormat58Choice_ RegistrationSecuritiesMarketDeadlineValue)
        {
            writer.WriteStartElement(null, "RegnSctiesMktDdln", xmlNamespace );
            RegistrationSecuritiesMarketDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RegistrationParticipationDeadline is DateFormat58Choice_ RegistrationParticipationDeadlineValue)
        {
            writer.WriteStartElement(null, "RegnPrtcptnDdln", xmlNamespace );
            RegistrationParticipationDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RegistrationParticipationMarketDeadline is DateFormat58Choice_ RegistrationParticipationMarketDeadlineValue)
        {
            writer.WriteStartElement(null, "RegnPrtcptnMktDdln", xmlNamespace );
            RegistrationParticipationMarketDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MeetingNotice5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
