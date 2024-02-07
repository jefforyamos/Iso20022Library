﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ManagementPlan9.  ISO2002 ID# _VscLoSi8Eeurkfo6MpvKDA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sequence of terminal management actions to be performed by a point of interaction (POI).
/// </summary>
public partial record ManagementPlan9
     : IIsoXmlSerilizable<ManagementPlan9>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the point of interaction (POI) for terminal management.
    /// </summary>
    public GenericIdentification176? POIIdentification { get; init; } 
    /// <summary>
    /// Identification of the terminal management system (TMS) sending the management plan.
    /// </summary>
    public required GenericIdentification176 TerminalManagerIdentification { get; init; } 
    /// <summary>
    /// Data set related to the sequence of actions to be performed by a point of interaction (POI).
    /// </summary>
    public required TerminalManagementDataSet30 DataSet { get; init; } 
    
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
        if (POIIdentification is GenericIdentification176 POIIdentificationValue)
        {
            writer.WriteStartElement(null, "POIId", xmlNamespace );
            POIIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TermnlMgrId", xmlNamespace );
        TerminalManagerIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DataSet", xmlNamespace );
        DataSet.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static ManagementPlan9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
