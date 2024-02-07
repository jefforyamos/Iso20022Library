﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Pledgee3.  ISO2002 ID# _X818odLGEeiN28wlpBQScw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the entity to which the financial instruments are pledged.
/// </summary>
public partial record Pledgee3
     : IIsoXmlSerilizable<Pledgee3>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    public PledgeeFormat5Choice_? PledgeeTypeAndIdentification { get; init; } 
    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    
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
        if (PledgeeTypeAndIdentification is PledgeeFormat5Choice_ PledgeeTypeAndIdentificationValue)
        {
            writer.WriteStartElement(null, "PldgeeTpAndId", xmlNamespace );
            PledgeeTypeAndIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LEI is IsoLEIIdentifier LEIValue)
        {
            writer.WriteStartElement(null, "LEI", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoLEIIdentifier(LEIValue)); // data type LEIIdentifier System.String
            writer.WriteEndElement();
        }
    }
    public static Pledgee3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
