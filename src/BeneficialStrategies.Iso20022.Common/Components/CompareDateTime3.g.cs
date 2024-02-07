﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareDateTime3.  ISO2002 ID# _vvGj4a5hEeuo-IflVgGqiA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a date and time.
/// </summary>
public partial record CompareDateTime3
     : IIsoXmlSerilizable<CompareDateTime3>
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    public IsoISODateTime? Value1 { get; init; } 
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    public IsoISODateTime? Value2 { get; init; } 
    
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
        if (Value1 is IsoISODateTime Value1Value)
        {
            writer.WriteStartElement(null, "Val1", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(Value1Value)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (Value2 is IsoISODateTime Value2Value)
        {
            writer.WriteStartElement(null, "Val2", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(Value2Value)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
    }
    public static CompareDateTime3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
