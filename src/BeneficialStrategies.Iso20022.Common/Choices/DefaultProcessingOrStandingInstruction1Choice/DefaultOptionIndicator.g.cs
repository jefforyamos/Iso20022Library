﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DefaultOptionIndicator.  ISO2002 ID# _Q0VlA9p-Ed-ak6NoX_4Aeg_-887513505.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.DefaultProcessingOrStandingInstruction1Choice;

/// <summary>
/// Indicates whether the option, for example, currency option, will be selected by default if no instruction is provided by the account owner.
/// </summary>
public partial record DefaultOptionIndicator : DefaultProcessingOrStandingInstruction1Choice_
     , IIsoXmlSerilizable<DefaultOptionIndicator>
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
        writer.WriteStartElement(null, "DfltOptnInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(Value)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
    }
    public static new DefaultOptionIndicator Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
