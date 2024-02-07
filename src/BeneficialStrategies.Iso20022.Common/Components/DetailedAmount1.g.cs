﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedAmount1.  ISO2002 ID# _TFZvigEcEeCQm6a_G2yO_w_265407285.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
public partial record DetailedAmount1
     : IIsoXmlSerilizable<DetailedAmount1>
{
    #nullable enable
    
    /// <summary>
    /// Type of amount.
    /// </summary>
    public required TypeOfAmount2Code Type { get; init; } 
    /// <summary>
    /// Amount value.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(Type.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Val", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(Value)); // data type ImpliedCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static DetailedAmount1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
