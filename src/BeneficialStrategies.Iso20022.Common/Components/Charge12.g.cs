﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Charge12.  ISO2002 ID# _RtQxENp-Ed-ak6NoX_4Aeg_-1147593410.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the different types of freight charges associated with goods.
/// </summary>
public partial record Charge12
     : IIsoXmlSerilizable<Charge12>
{
    #nullable enable
    
    /// <summary>
    /// Identifies whether the freight charges associated with the goods are "prepaid" or "collect".
    /// </summary>
    public required FreightCharges1Code Type { get; init; } 
    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    public ChargesDetails1? Charges { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(Type.ToString()); // Enum value
        writer.WriteEndElement();
        if (Charges is ChargesDetails1 ChargesValue)
        {
            writer.WriteStartElement(null, "Chrgs", xmlNamespace );
            ChargesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Charge12 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
