﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ServiceStartEnd2.  ISO2002 ID# _QOD4UcW1EeuhguwJmlgagQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Start or end of service.
/// </summary>
public partial record ServiceStartEnd2
     : IIsoXmlSerilizable<ServiceStartEnd2>
{
    #nullable enable
    
    /// <summary>
    /// Location of service (for example, Paris CDG, Paris Gare du Nord, etc.). 
    /// </summary>
    public IsoMax35Text? Location { get; init; } 
    /// <summary>
    /// Location code assigned to an airport or to a service location (for example, CDG, YUL, etc.).
    /// </summary>
    public IsoMax35Text? LocationCode { get; init; } 
    /// <summary>
    /// Address of service.
    /// </summary>
    public Address2? Address { get; init; } 
    /// <summary>
    /// Contact details at location.
    /// </summary>
    public Contact2? Contact { get; init; } 
    /// <summary>
    /// Date and time of service.
    /// </summary>
    public IsoISODateTime? DateAndTime { get; init; } 
    /// <summary>
    /// Period of day pertaining to the service location.
    /// </summary>
    public TimeSegment1Code? TimeSegment { get; init; } 
    /// <summary>
    /// Journey information related to the vehicle rental.
    /// </summary>
    public JourneyInformation1? JourneyInformation { get; init; } 
    
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
        if (Location is IsoMax35Text LocationValue)
        {
            writer.WriteStartElement(null, "Lctn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(LocationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (LocationCode is IsoMax35Text LocationCodeValue)
        {
            writer.WriteStartElement(null, "LctnCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(LocationCodeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Address is Address2 AddressValue)
        {
            writer.WriteStartElement(null, "Adr", xmlNamespace );
            AddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Contact is Contact2 ContactValue)
        {
            writer.WriteStartElement(null, "Ctct", xmlNamespace );
            ContactValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DateAndTime is IsoISODateTime DateAndTimeValue)
        {
            writer.WriteStartElement(null, "DtAndTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(DateAndTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (TimeSegment is TimeSegment1Code TimeSegmentValue)
        {
            writer.WriteStartElement(null, "TmSgmt", xmlNamespace );
            writer.WriteValue(TimeSegmentValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (JourneyInformation is JourneyInformation1 JourneyInformationValue)
        {
            writer.WriteStartElement(null, "JrnyInf", xmlNamespace );
            JourneyInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ServiceStartEnd2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
