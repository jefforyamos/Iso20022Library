﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PositionSet17.  ISO2002 ID# _LndN8cKyEeuM4pgP8Vixbg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the values used to calculate positions.
/// </summary>
public partial record PositionSet17
     : IIsoXmlSerilizable<PositionSet17>
{
    #nullable enable
    
    /// <summary>
    /// Variables related to derivatives that are used to group derivatives together into positions.
    /// </summary>
    public required PositionSetDimensions14 Dimensions { get; init; } 
    /// <summary>
    /// Variables used to quantify the different calculations.
    /// </summary>
    public required PositionSetMetrics13 Metrics { get; init; } 
    
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
        writer.WriteStartElement(null, "Dmnsns", xmlNamespace );
        Dimensions.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Mtrcs", xmlNamespace );
        Metrics.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static PositionSet17 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
