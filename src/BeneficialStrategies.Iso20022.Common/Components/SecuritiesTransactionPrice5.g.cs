﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesTransactionPrice5.  ISO2002 ID# _U2lWUZjgEeqkLZLH6DK3UQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Price with notation.
/// </summary>
public partial record SecuritiesTransactionPrice5
     : IIsoXmlSerilizable<SecuritiesTransactionPrice5>
{
    #nullable enable
    
    /// <summary>
    /// Value of the price.
    /// </summary>
    public IsoLongFraction19DecimalNumber? Value { get; init; } 
    /// <summary>
    /// Notation of the price.
    /// </summary>
    public IsoMax35Text? Type { get; init; } 
    
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
        if (Value is IsoLongFraction19DecimalNumber ValueValue)
        {
            writer.WriteStartElement(null, "Val", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoLongFraction19DecimalNumber(ValueValue)); // data type LongFraction19DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        if (Type is IsoMax35Text TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static SecuritiesTransactionPrice5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
