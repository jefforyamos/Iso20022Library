﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SystemPartyModification2.  ISO2002 ID# _xtxKwYv-Eei289CGNqs21g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the kind of modification request for party reference data.
/// </summary>
public partial record SystemPartyModification2
     : IIsoXmlSerilizable<SystemPartyModification2>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of requested modification.
    /// </summary>
    public required DataModification1Code ScopeIndication { get; init; } 
    /// <summary>
    /// Specifies the set of elements to be modified for the party reference data.
    /// </summary>
    public required SystemPartyModification2Choice_ RequestedModification { get; init; } 
    
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
        writer.WriteStartElement(null, "ScpIndctn", xmlNamespace );
        writer.WriteValue(ScopeIndication.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ReqdMod", xmlNamespace );
        RequestedModification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static SystemPartyModification2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
