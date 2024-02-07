﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardTransactionContext4.  ISO2002 ID# _lK_YgYO8EeSWSLYdc10LRg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the card transaction.
/// </summary>
public partial record CardTransactionContext4
     : IIsoXmlSerilizable<CardTransactionContext4>
{
    #nullable enable
    
    /// <summary>
    /// Data used to assign specific condition such as liability shift or preferential interchange fees.
    /// </summary>
    public CardTransactionCondition1? SpecialConditions { get; init; } 
    
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
        if (SpecialConditions is CardTransactionCondition1 SpecialConditionsValue)
        {
            writer.WriteStartElement(null, "SpclConds", xmlNamespace );
            SpecialConditionsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardTransactionContext4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
