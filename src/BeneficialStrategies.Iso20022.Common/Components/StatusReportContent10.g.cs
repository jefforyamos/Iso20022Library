﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusReportContent10.  ISO2002 ID# _w2W44Si0Eeurkfo6MpvKDA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the status report.
/// </summary>
public partial record StatusReportContent10
     : IIsoXmlSerilizable<StatusReportContent10>
{
    #nullable enable
    
    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the status report.
    /// </summary>
    public PointOfInteractionCapabilities9? POICapabilities { get; init; } 
    /// <summary>
    /// Data related to a component of the POI (Point Of Interaction) performing the status report.
    /// </summary>
    public PointOfInteractionComponent11? POIComponent { get; init; } 
    /// <summary>
    /// Identifier assigned to a set of POI terminals performing some categories of transactions.
    /// </summary>
    public IsoMax35Text? POIGroupIdentification { get; init; } 
    /// <summary>
    /// Human attendance at the POI (Point Of Interaction) location during transactions.
    /// </summary>
    public AttendanceContext1Code? AttendanceContext { get; init; } 
    /// <summary>
    /// System date time of the point of interaction (POI) sending the status report.
    /// </summary>
    public required IsoISODateTime POIDateTime { get; init; } 
    /// <summary>
    /// Request the terminal management system to answer with the identified data set.
    /// </summary>
    public DataSetRequest2? DataSetRequired { get; init; } 
    /// <summary>
    /// Result of an individual terminal management action by the point of interaction.
    /// </summary>
    public TMSEvent8? Event { get; init; } 
    /// <summary>
    /// Error log of the point of interaction since the last status report.
    /// </summary>
    public IsoMax140Text? Errors { get; init; } 
    
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
        if (POICapabilities is PointOfInteractionCapabilities9 POICapabilitiesValue)
        {
            writer.WriteStartElement(null, "POICpblties", xmlNamespace );
            POICapabilitiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (POIComponent is PointOfInteractionComponent11 POIComponentValue)
        {
            writer.WriteStartElement(null, "POICmpnt", xmlNamespace );
            POIComponentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (POIGroupIdentification is IsoMax35Text POIGroupIdentificationValue)
        {
            writer.WriteStartElement(null, "POIGrpId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(POIGroupIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AttendanceContext is AttendanceContext1Code AttendanceContextValue)
        {
            writer.WriteStartElement(null, "AttndncCntxt", xmlNamespace );
            writer.WriteValue(AttendanceContextValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "POIDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(POIDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        if (DataSetRequired is DataSetRequest2 DataSetRequiredValue)
        {
            writer.WriteStartElement(null, "DataSetReqrd", xmlNamespace );
            DataSetRequiredValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Event is TMSEvent8 EventValue)
        {
            writer.WriteStartElement(null, "Evt", xmlNamespace );
            EventValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Errors is IsoMax140Text ErrorsValue)
        {
            writer.WriteStartElement(null, "Errs", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(ErrorsValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
    }
    public static StatusReportContent10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
