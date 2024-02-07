﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MeetingNotice8.  ISO2002 ID# _gmYNETUIEe2tRf29bleifQ.
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
public partial record MeetingNotice8
     : IIsoXmlSerilizable<MeetingNotice8>
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to the general meeting by the party that provides the meeting notification. It must be unique to the party providing the notification
    /// </summary>
    public required IsoMax35Text MeetingIdentification { get; init; } 
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
    public DateAndDateTime2Choice_? AnnouncementDate { get; init; } 
    /// <summary>
    /// Indicates whether the meeting vote is held under the "one-man-one-vote" principle, also known as "per capita vote" whereby the shareholder attending the meeting has one vote only, regardless of the holding positions.
    /// </summary>
    public IsoYesNoIndicator? OneManOneVoteIndicator { get; init; } 
    /// <summary>
    /// Method of voting participation to the general meeting and related voting deadline per method of participation.
    /// </summary>
    public ParticipationMethod2? Participation { get; init; } 
    /// <summary>
    /// Information and conditions for physical attendance at the general meeting.
    /// </summary>
    public Attendance2? Attendance { get; init; } 
    /// <summary>
    /// Address to use over the www (HTTP) service where additional information on the meeting may be found.
    /// </summary>
    public IsoMax2048Text? AdditionalDocumentationURLAddress { get; init; } 
    /// <summary>
    /// Provides web address of an account servicer (or of a service provider) that contains information solely intended for the immediate account holder to enable or facilitate event processing between parties.
    /// </summary>
    public IsoMax2048Text? EventProcessingWebSiteAddress { get; init; } 
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
    public Proxy5Choice_? ProxyChoice { get; init; } 
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
    public DateFormat60Choice_? SecuritiesBlockingPeriodEndDate { get; init; } 
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
        writer.WriteStartElement(null, "MtgId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(MeetingIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
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
        if (AnnouncementDate is DateAndDateTime2Choice_ AnnouncementDateValue)
        {
            writer.WriteStartElement(null, "AnncmntDt", xmlNamespace );
            AnnouncementDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OneManOneVoteIndicator is IsoYesNoIndicator OneManOneVoteIndicatorValue)
        {
            writer.WriteStartElement(null, "OneManOneVoteInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(OneManOneVoteIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (Participation is ParticipationMethod2 ParticipationValue)
        {
            writer.WriteStartElement(null, "Prtcptn", xmlNamespace );
            ParticipationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Attendance is Attendance2 AttendanceValue)
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
        if (EventProcessingWebSiteAddress is IsoMax2048Text EventProcessingWebSiteAddressValue)
        {
            writer.WriteStartElement(null, "EvtPrcgWebSiteAdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax2048Text(EventProcessingWebSiteAddressValue)); // data type Max2048Text System.String
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
        if (ProxyChoice is Proxy5Choice_ ProxyChoiceValue)
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
        if (SecuritiesBlockingPeriodEndDate is DateFormat60Choice_ SecuritiesBlockingPeriodEndDateValue)
        {
            writer.WriteStartElement(null, "SctiesBlckgPrdEndDt", xmlNamespace );
            SecuritiesBlockingPeriodEndDateValue.Serialize(writer, xmlNamespace);
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
    }
    public static MeetingNotice8 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
