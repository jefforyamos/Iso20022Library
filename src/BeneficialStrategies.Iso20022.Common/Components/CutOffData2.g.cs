﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CutOffData2.  ISO2002 ID# _B5DK5wN1Ee2-vqzwMUAewg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the new, current and previous cut offs for a netting cut off held at the central system.
/// </summary>
public partial record CutOffData2
     : IIsoXmlSerilizable<CutOffData2>
{
    #nullable enable
    
    /// <summary>
    /// Describes the participant receiving the net report.
    /// </summary>
    public required PartyIdentification242Choice_ ParticipantIdentification { get; init; } 
    /// <summary>
    /// Specifies the information regarding the updated netting cut off.
    /// </summary>
    public NettingCutOff2? NettingCutOffDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _B-238wN1Ee2-vqzwMUAewg
    
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
        writer.WriteStartElement(null, "PtcptId", xmlNamespace );
        ParticipantIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        // Not sure how to serialize NettingCutOffDetails, multiplicity Unknown
    }
    public static CutOffData2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
