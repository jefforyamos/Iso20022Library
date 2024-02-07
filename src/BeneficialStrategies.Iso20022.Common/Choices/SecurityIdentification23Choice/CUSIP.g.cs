﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CUSIP.  ISO2002 ID# _CSq4NyGQEeW7gKYhAMEFCw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification23Choice;

/// <summary>
/// Committee on Uniform Securities and Identification Procedures (CUSIP). The standards body that created and maintains the securities classification system in the US. The CUSIP is composed of a 9-character number that uniquely identifies a particular security. Non-US securities have a similar number called the CINS number.
/// </summary>
public partial record CUSIP : SecurityIdentification23Choice_
     , IIsoXmlSerilizable<CUSIP>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Committee on Uniform Securities and Identification Procedures (CUSIP). The standards body that created and maintains the securities classification system in the US. Non-US securities have a similar number called the CINS number.
    /// </summary>
    public required IsoCUSIPIdentifier Value { get; init; } 
    
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
        writer.WriteStartElement(null, "CUSIP", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoCUSIPIdentifier(Value)); // data type CUSIPIdentifier System.String
        writer.WriteEndElement();
    }
    public static new CUSIP Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
