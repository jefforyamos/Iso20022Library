﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareTradeClearingObligation1.  ISO2002 ID# _X5DbMExWEeywvc16MwOPfw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a trade clearing obligation.
/// </summary>
public partial record CompareTradeClearingObligation1
     : IIsoXmlSerilizable<CompareTradeClearingObligation1>
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    public ClearingObligationType1Code? Value1 { get; init; } 
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    public ClearingObligationType1Code? Value2 { get; init; } 
    
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
        if (Value1 is ClearingObligationType1Code Value1Value)
        {
            writer.WriteStartElement(null, "Val1", xmlNamespace );
            writer.WriteValue(Value1Value.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Value2 is ClearingObligationType1Code Value2Value)
        {
            writer.WriteStartElement(null, "Val2", xmlNamespace );
            writer.WriteValue(Value2Value.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static CompareTradeClearingObligation1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
