﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RegistrationReason1.  ISO2002 ID# _xoFroEAbEeC4mKrqv7wPJQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason of registration.
/// </summary>
public partial record RegistrationReason1
     : IIsoXmlSerilizable<RegistrationReason1>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reaoson of the holding status.
    /// </summary>
    public required Registration3Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalInformation { get; init; } 
    
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
        if (AdditionalInformation is IsoMax210Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax210Text(AdditionalInformationValue)); // data type Max210Text System.String
            writer.WriteEndElement();
        }
    }
    public static RegistrationReason1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
