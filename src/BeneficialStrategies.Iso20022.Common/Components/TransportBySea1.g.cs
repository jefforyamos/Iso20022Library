﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransportBySea1.  ISO2002 ID# _U8POg9p-Ed-ak6NoX_4Aeg_1145381105.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related for the transportation of goods by sea.
/// </summary>
public partial record TransportBySea1
     : IIsoXmlSerilizable<TransportBySea1>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the port where the goods are loaded on board the ship.
    /// </summary>
    public IsoMax35Text? PortOfLoading { get; init; } 
    /// <summary>
    /// Identifies the port where the goods are discharged.
    /// </summary>
    public IsoMax35Text? PortOfDischarge { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _U8POhdp-Ed-ak6NoX_4Aeg_1699744817
    
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
        if (PortOfLoading is IsoMax35Text PortOfLoadingValue)
        {
            writer.WriteStartElement(null, "PortOfLoadng", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PortOfLoadingValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        // Not sure how to serialize PortOfDischarge, multiplicity Unknown
    }
    public static TransportBySea1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
