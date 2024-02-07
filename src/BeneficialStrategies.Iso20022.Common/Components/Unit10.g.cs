﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Unit10.  ISO2002 ID# _BdzxQa5yEeeMy7TnJ3e__g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity expressed as a number and its details.
/// </summary>
public partial record Unit10
     : IIsoXmlSerilizable<Unit10>
{
    #nullable enable
    
    /// <summary>
    /// Quantity expressed as a number, for example, a number of shares.
    /// </summary>
    public required IsoDecimalNumber UnitsNumber { get; init; } 
    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    public required UKTaxGroupUnit1Code Group1Or2Units { get; init; } 
    
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
        writer.WriteStartElement(null, "UnitsNb", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoDecimalNumber(UnitsNumber)); // data type DecimalNumber System.UInt64
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Grp1Or2Units", xmlNamespace );
        writer.WriteValue(Group1Or2Units.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static Unit10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
