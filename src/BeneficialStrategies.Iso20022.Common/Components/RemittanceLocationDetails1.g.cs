﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RemittanceLocationDetails1.  ISO2002 ID# _IcMu4aJxEeK9W_i6uXeloA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the remittance advice.
/// </summary>
public partial record RemittanceLocationDetails1
     : IIsoXmlSerilizable<RemittanceLocationDetails1>
{
    #nullable enable
    
    /// <summary>
    /// Method used to deliver the remittance advice information.
    /// </summary>
    public required RemittanceLocationMethod2Code Method { get; init; } 
    /// <summary>
    /// Electronic address to which an agent is to send the remittance information.
    /// </summary>
    public IsoMax2048Text? ElectronicAddress { get; init; } 
    /// <summary>
    /// Postal address to which an agent is to send the remittance information.
    /// </summary>
    public NameAndAddress10? PostalAddress { get; init; } 
    
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
        writer.WriteStartElement(null, "Mtd", xmlNamespace );
        writer.WriteValue(Method.ToString()); // Enum value
        writer.WriteEndElement();
        if (ElectronicAddress is IsoMax2048Text ElectronicAddressValue)
        {
            writer.WriteStartElement(null, "ElctrncAdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax2048Text(ElectronicAddressValue)); // data type Max2048Text System.String
            writer.WriteEndElement();
        }
        if (PostalAddress is NameAndAddress10 PostalAddressValue)
        {
            writer.WriteStartElement(null, "PstlAdr", xmlNamespace );
            PostalAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static RemittanceLocationDetails1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
