﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BICOrBEI.  ISO2002 ID# _Q7pG4Np-Ed-ak6NoX_4Aeg_1657637865.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification8Choice;

/// <summary>
/// Identification of a party by a BIC and an Alternative Identifier.
/// </summary>
public partial record BICOrBEI : PartyIdentification8Choice_
     , IIsoXmlSerilizable<BICOrBEI>
{
    #nullable enable
    
    public required IsoAnyBICIdentifier Value { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    public SimpleValueList<IsoMax35Text> AlternativeIdentifier { get; init; } = [];
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "BICOrBEI", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoAnyBICIdentifier(Value)); // data type AnyBICIdentifier System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AltrntvIdr", xmlNamespace );
        AlternativeIdentifier.Serialize(writer, xmlNamespace, "Max35Text", SerializationFormatter.IsoMax35Text );
        writer.WriteEndElement();
    }
    public static new BICOrBEI Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
