﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RetailerEvent2.  ISO2002 ID# _MWeUsQ0uEeqUVL7sB4m7NA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Retailer Event message.
/// </summary>
public partial record RetailerEvent2
     : IIsoXmlSerilizable<RetailerEvent2>
{
    #nullable enable
    
    /// <summary>
    /// Date and time of the event.
    /// </summary>
    public required IsoISODateTime EventTimeStamp { get; init; } 
    /// <summary>
    /// Event the POI notifies to the Sale System.
    /// </summary>
    public required EventToNotify2Code EventToNotify { get; init; } 
    /// <summary>
    /// Context of the Event message.
    /// </summary>
    public EventContext2? EventContext { get; init; } 
    /// <summary>
    /// Additional Information according to the event type.
    /// </summary>
    public IsoMax1025Text? AdditionalEventInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "EvtTmStmp", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(EventTimeStamp)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        writer.WriteStartElement(null, "EvtToNtfy", xmlNamespace );
        writer.WriteValue(EventToNotify.ToString()); // Enum value
        writer.WriteEndElement();
        if (EventContext is EventContext2 EventContextValue)
        {
            writer.WriteStartElement(null, "EvtCntxt", xmlNamespace );
            EventContextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalEventInformation is IsoMax1025Text AdditionalEventInformationValue)
        {
            writer.WriteStartElement(null, "AddtlEvtInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax1025Text(AdditionalEventInformationValue)); // data type Max1025Text System.String
            writer.WriteEndElement();
        }
    }
    public static RetailerEvent2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
