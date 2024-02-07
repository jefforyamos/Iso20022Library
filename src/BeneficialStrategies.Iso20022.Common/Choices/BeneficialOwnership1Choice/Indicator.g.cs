﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Indicator.  ISO2002 ID# _QwBFstp-Ed-ak6NoX_4Aeg_-1770498081.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.BeneficialOwnership1Choice;

/// <summary>
/// Specifies whether there is change of beneficial ownership.
/// </summary>
public partial record Indicator : BeneficialOwnership1Choice_
     , IIsoXmlSerilizable<Indicator>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Indicates a "Yes" or "No" type of answer for an element.
    /// </summary>
    public required IsoYesNoIndicator Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Ind", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(Value)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
    }
    public static new Indicator Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
