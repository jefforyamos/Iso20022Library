﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MeetingReference2.  ISO2002 ID# _TlqdItp-Ed-ak6NoX_4Aeg_-1779095008.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Elements which allow to identify a meeting.
/// </summary>
public partial record MeetingReference2
     : IIsoXmlSerilizable<MeetingReference2>
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to a general meeting by the party notifying the meeting. It must be unique for the party notifying the meeting.
    /// </summary>
    public required IsoMax35Text MeetingIdentification { get; init; } 
    /// <summary>
    /// Identification assigned to a meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    public IsoMax35Text? IssuerMeetingIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    public IsoISODateTime? MeetingDateAndTime { get; init; } 
    /// <summary>
    /// Specifies the type of meeting for which instructions are sent.
    /// </summary>
    public MeetingType2Code? Type { get; init; } 
    /// <summary>
    /// Classifies the type of meeting.
    /// </summary>
    public MeetingTypeClassification1Code? Classification { get; init; } 
    /// <summary>
    /// This code can be used in case another meeting classifications is required.
    /// </summary>
    public IsoExtended350Code? ExtendedClassification { get; init; } 
    /// <summary>
    /// Place of the company meeting for the scheduled meeting date.
    /// </summary>
    public ValueList<PostalAddress1> Location { get; init; } = [];
    
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
        if (MeetingDateAndTime is IsoISODateTime MeetingDateAndTimeValue)
        {
            writer.WriteStartElement(null, "MtgDtAndTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(MeetingDateAndTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (Type is MeetingType2Code TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            writer.WriteValue(TypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Classification is MeetingTypeClassification1Code ClassificationValue)
        {
            writer.WriteStartElement(null, "Clssfctn", xmlNamespace );
            writer.WriteValue(ClassificationValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ExtendedClassification is IsoExtended350Code ExtendedClassificationValue)
        {
            writer.WriteStartElement(null, "XtndedClssfctn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExtended350Code(ExtendedClassificationValue)); // data type Extended350Code System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Lctn", xmlNamespace );
        Location.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static MeetingReference2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
