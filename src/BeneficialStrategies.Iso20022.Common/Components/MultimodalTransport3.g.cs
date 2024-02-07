﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MultimodalTransport3.  ISO2002 ID# _StCMANp-Ed-ak6NoX_4Aeg_1369687043.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to multimodal transportation of goods.
/// </summary>
public partial record MultimodalTransport3
     : IIsoXmlSerilizable<MultimodalTransport3>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the location where the goods are take in charge for transportation.
    /// </summary>
    public required IsoMax35Text TakingInCharge { get; init; } 
    /// <summary>
    /// Identifies the location of the final destination of the goods.
    /// </summary>
    public required IsoMax35Text PlaceOfFinalDestination { get; init; } 
    
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
        writer.WriteStartElement(null, "TakngInChrg", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(TakingInCharge)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PlcOfFnlDstn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(PlaceOfFinalDestination)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static MultimodalTransport3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
