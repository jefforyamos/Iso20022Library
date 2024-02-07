﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InterestRate6.  ISO2002 ID# _oLE7E8g6Eeu4ecZgAYuz5w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on interest rates related to the transaction.
/// </summary>
public partial record InterestRate6
     : IIsoXmlSerilizable<InterestRate6>
{
    #nullable enable
    
    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    public required AmountAndDirection53 Amount { get; init; } 
    /// <summary>
    /// Information on interest rates related to the transaction.
    /// </summary>
    public required InterestRate27Choice_ InterestRate { get; init; } 
    
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
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        Amount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IntrstRate", xmlNamespace );
        InterestRate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static InterestRate6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
