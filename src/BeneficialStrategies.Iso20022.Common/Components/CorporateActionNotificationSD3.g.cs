﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNotificationSD3.  ISO2002 ID# _1cnPoTL3EeKU9IrkkToqcw_-1946623556.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding notification general information details.
/// </summary>
public partial record CorporateActionNotificationSD3
     : IIsoXmlSerilizable<CorporateActionNotificationSD3>
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Date and time when DTCC (The Depository Trust and Clearing Corporation) created the announcement record.
    /// </summary>
    public required IsoISODateTime CreateDateAndTime { get; init; } 
    /// <summary>
    /// Date and time when DTCC (The Depository Trust and Clearing Corporation) last updated the announcement.
    /// </summary>
    public IsoISODateTime? UpdateDateAndTime { get; init; } 
    
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
        writer.WriteStartElement(null, "CretDtAndTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(CreateDateAndTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        if (UpdateDateAndTime is IsoISODateTime UpdateDateAndTimeValue)
        {
            writer.WriteStartElement(null, "UpdDtAndTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(UpdateDateAndTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
    }
    public static CorporateActionNotificationSD3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
