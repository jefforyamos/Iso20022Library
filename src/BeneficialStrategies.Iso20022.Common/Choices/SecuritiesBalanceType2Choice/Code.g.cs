﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _QtL0I9p-Ed-ak6NoX_4Aeg_-1926533181.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesBalanceType2Choice;

/// <summary>
/// Sub-balance expressed as an ISO 20022 code.
/// </summary>
public partial record Code : SecuritiesBalanceType2Choice_
     , IIsoXmlSerilizable<Code>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the nature of the securities or investment fund balance.
    /// </summary>
    public required SecuritiesBalanceType13Code Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Cd", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Code Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
