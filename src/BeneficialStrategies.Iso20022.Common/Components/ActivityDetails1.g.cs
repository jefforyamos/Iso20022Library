﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ActivityDetails1.  ISO2002 ID# _RJDQwNp-Ed-ak6NoX_4Aeg_2070733092.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the activities that took place during a certain period for one trade transaction.
/// </summary>
public partial record ActivityDetails1
     : IIsoXmlSerilizable<ActivityDetails1>
{
    #nullable enable
    
    /// <summary>
    /// Date and time when the activity occurred.
    /// </summary>
    public required IsoISODateTime DateTime { get; init; } 
    /// <summary>
    /// Description of the reported activities.
    /// </summary>
    public required Activity1 Activity { get; init; } 
    /// <summary>
    /// Financial institution which initiated the activity.
    /// </summary>
    public required BICIdentification1 Initiator { get; init; } 
    
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
        writer.WriteStartElement(null, "DtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(DateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Actvty", xmlNamespace );
        Activity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Initr", xmlNamespace );
        Initiator.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static ActivityDetails1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
