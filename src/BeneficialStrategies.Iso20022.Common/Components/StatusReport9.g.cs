﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusReport9.  ISO2002 ID# _8cfBURBbEeqgJK7e3n_EXA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of the acceptor system containing the identification of the POI (Point Of Interaction), its components and their installed versions.
/// </summary>
public partial record StatusReport9
     : IIsoXmlSerilizable<StatusReport9>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the point of interaction for terminal management.
    /// </summary>
    public required GenericIdentification176 POIIdentification { get; init; } 
    /// <summary>
    /// Identification of the requestor.
    /// </summary>
    public TriggerInformation2? InitiatingTrigger { get; init; } 
    /// <summary>
    /// Identification of the terminal management system (TMS) to contact for the maintenance.
    /// </summary>
    public required GenericIdentification176 TerminalManagerIdentification { get; init; } 
    /// <summary>
    /// Data related to a status report of a point of interaction (POI).
    /// </summary>
    public required StatusReportDataSetRequest1 DataSet { get; init; } 
    
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
        writer.WriteStartElement(null, "POIId", xmlNamespace );
        POIIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (InitiatingTrigger is TriggerInformation2 InitiatingTriggerValue)
        {
            writer.WriteStartElement(null, "InitgTrggr", xmlNamespace );
            InitiatingTriggerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TermnlMgrId", xmlNamespace );
        TerminalManagerIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DataSet", xmlNamespace );
        DataSet.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static StatusReport9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
