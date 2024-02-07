﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PledgeeTypeAndText2.  ISO2002 ID# _Sg8bNW_nEeSNvKTulh2IuA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the entity to which the financial instruments are pledged expressed as a code and a narrative description.
/// </summary>
public partial record PledgeeTypeAndText2
     : IIsoXmlSerilizable<PledgeeTypeAndText2>
{
    #nullable enable
    
    /// <summary>
    /// Additional information about the entity to which the financial instruments are pledged.
    /// </summary>
    public IsoRestrictedFINMax30Text? Identification { get; init; } 
    /// <summary>
    /// Entity to which the financial instruments are pledged expressed as a code.
    /// </summary>
    public required PledgeeType1Code PledgeeType { get; init; } 
    
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
        if (Identification is IsoRestrictedFINMax30Text IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINMax30Text(IdentificationValue)); // data type RestrictedFINMax30Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PldgeeTp", xmlNamespace );
        writer.WriteValue(PledgeeType.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static PledgeeTypeAndText2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
