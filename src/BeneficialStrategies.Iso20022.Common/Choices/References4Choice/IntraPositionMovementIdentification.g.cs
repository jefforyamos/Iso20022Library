﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IntraPositionMovementIdentification.  ISO2002 ID# _UR6fL9p-Ed-ak6NoX_4Aeg_1430398311.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.References4Choice;

/// <summary>
/// Reference to the intra-position movement transaction requested to be cancelled as known by the account owner (or instructing party acting on its behalf).
/// </summary>
public partial record IntraPositionMovementIdentification : References4Choice_
     , IIsoXmlSerilizable<IntraPositionMovementIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    public required IsoMax35Text Value { get; init; } 
    
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
        writer.WriteStartElement(null, "IntraPosMvmntId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Value)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static new IntraPositionMovementIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
