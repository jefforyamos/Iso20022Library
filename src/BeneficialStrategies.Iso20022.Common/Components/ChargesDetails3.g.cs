﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ChargesDetails3.  ISO2002 ID# _fGU5MRrdEeOVR9VN6fAMUg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
public partial record ChargesDetails3
     : IIsoXmlSerilizable<ChargesDetails3>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of charges as a code or free text.
    /// </summary>
    public required ChargesType1Choice_ Type { get; init; } 
    /// <summary>
    /// Specifies if it is a fixed amount or a percentage.
    /// </summary>
    public required AmountOrPercentage2Choice_ AmountOrPercentage { get; init; } 
    
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
        Type.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AmtOrPctg", xmlNamespace );
        AmountOrPercentage.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static ChargesDetails3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
