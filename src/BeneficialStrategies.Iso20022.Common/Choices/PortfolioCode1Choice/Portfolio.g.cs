﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Portfolio.  ISO2002 ID# _KN8581fVEeqqKf65rDYWYw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PortfolioCode1Choice;

/// <summary>
/// Unique code determined by the reporting counterparty to identify the portfolio if collateral is reported on a portfolio basis.
/// </summary>
public partial record Portfolio : PortfolioCode1Choice_
     , IIsoXmlSerilizable<Portfolio>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 52 characters.
    /// </summary>
    public required IsoMax52Text Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Prtfl", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax52Text(Value)); // data type Max52Text System.String
        writer.WriteEndElement();
    }
    public static new Portfolio Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
