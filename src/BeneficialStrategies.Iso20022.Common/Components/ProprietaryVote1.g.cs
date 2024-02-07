﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProprietaryVote1.  ISO2002 ID# _v_P28K-XEemJ1NnLPsTFaw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Proprietary vote type and quantity voted.
/// </summary>
public partial record ProprietaryVote1
     : IIsoXmlSerilizable<ProprietaryVote1>
{
    #nullable enable
    
    /// <summary>
    /// Other type of vote expressed as a proprietary code.
    /// </summary>
    public required GenericIdentification30 Code { get; init; } 
    /// <summary>
    /// Quantity of securities voted.
    /// </summary>
    public required QuantityOrCode1Choice_ Quantity { get; init; } 
    
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
        writer.WriteStartElement(null, "Cd", xmlNamespace );
        Code.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Qty", xmlNamespace );
        Quantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static ProprietaryVote1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
