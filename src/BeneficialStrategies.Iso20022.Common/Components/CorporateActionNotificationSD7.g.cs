﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNotificationSD7.  ISO2002 ID# _1l_1IzL3EeKU9IrkkToqcw_1617998570.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action general information details.
/// </summary>
public partial record CorporateActionNotificationSD7
     : IIsoXmlSerilizable<CorporateActionNotificationSD7>
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// DTC processing domain/ category for event types.
    /// </summary>
    public EventGroup1Code? EventGroup { get; init; } 
    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action event type name. Used in place for the events that cannot be classified by ISO code and mapped to OTHR or when two or more distinct events (in DTCC model) use same ISO code and there are no additional data elements that distinguish those two or more events.
    /// </summary>
    public ExtendedEventType1Code? EventType { get; init; } 
    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action sub event type name further defines the event type.
    /// </summary>
    public DTCCSubEventType2Code? SubEventType { get; init; } 
    /// <summary>
    /// Specifies the nature of the event with regard to how it is being supported by DTC (The Depository Trust Corporation) the custodian: whether the event is mandatory, voluntary, or mandatory with options and eligible for DTC processing. This classification is necessary for the event types that have additional DTC only options. For an example: a MAND event, where the issuer declared only one option may be eligible for special DTC options (services like Dividend Reinvestment, Foreign Currency Payment, etc) in this case it will be announced as MAND by the issuer and CHOS by DTC.
    /// </summary>
    public CorporateActionMandatoryVoluntary1Code? DTCMandatoryVoluntaryEventType { get; init; } 
    /// <summary>
    /// Specifies the nature of the event as announced by the agent or issuer.
    /// </summary>
    public CorporateActionMandatoryVoluntary1Code? DeclaredMandatoryVoluntaryEventType { get; init; } 
    
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
        writer.WriteStartElement(null, "PlcAndNm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(PlaceAndName)); // data type Max350Text System.String
        writer.WriteEndElement();
        if (EventGroup is EventGroup1Code EventGroupValue)
        {
            writer.WriteStartElement(null, "EvtGrp", xmlNamespace );
            writer.WriteValue(EventGroupValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (EventType is ExtendedEventType1Code EventTypeValue)
        {
            writer.WriteStartElement(null, "EvtTp", xmlNamespace );
            writer.WriteValue(EventTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (SubEventType is DTCCSubEventType2Code SubEventTypeValue)
        {
            writer.WriteStartElement(null, "SubEvtTp", xmlNamespace );
            writer.WriteValue(SubEventTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DTCMandatoryVoluntaryEventType is CorporateActionMandatoryVoluntary1Code DTCMandatoryVoluntaryEventTypeValue)
        {
            writer.WriteStartElement(null, "DTCMndtryVlntryEvtTp", xmlNamespace );
            writer.WriteValue(DTCMandatoryVoluntaryEventTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DeclaredMandatoryVoluntaryEventType is CorporateActionMandatoryVoluntary1Code DeclaredMandatoryVoluntaryEventTypeValue)
        {
            writer.WriteStartElement(null, "DclrdMndtryVlntryEvtTp", xmlNamespace );
            writer.WriteValue(DeclaredMandatoryVoluntaryEventTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static CorporateActionNotificationSD7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
