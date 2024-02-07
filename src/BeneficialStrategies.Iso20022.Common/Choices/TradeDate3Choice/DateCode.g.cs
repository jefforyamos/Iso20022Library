﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DateCode.  ISO2002 ID# _-a7YkaMOEeCojJW5vEuTEQ_233612286.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TradeDate3Choice;

/// <summary>
/// Date expressed as a code.
/// </summary>
public partial record DateCode : TradeDate3Choice_
     , IIsoXmlSerilizable<DateCode>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies when date is unknown.
    /// </summary>
    public required DateType1Code Value { get; init; } 
    
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
        writer.WriteStartElement(null, "DtCd", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new DateCode Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
