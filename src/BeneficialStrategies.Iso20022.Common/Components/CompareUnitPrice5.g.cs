﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareUnitPrice5.  ISO2002 ID# _Wopqka5mEeuo-IflVgGqiA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a unit price.
/// </summary>
public partial record CompareUnitPrice5
     : IIsoXmlSerilizable<CompareUnitPrice5>
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    public SecuritiesTransactionPrice17Choice_? Value1 { get; init; } 
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    public SecuritiesTransactionPrice17Choice_? Value2 { get; init; } 
    
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
        if (Value1 is SecuritiesTransactionPrice17Choice_ Value1Value)
        {
            writer.WriteStartElement(null, "Val1", xmlNamespace );
            Value1Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Value2 is SecuritiesTransactionPrice17Choice_ Value2Value)
        {
            writer.WriteStartElement(null, "Val2", xmlNamespace );
            Value2Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CompareUnitPrice5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
