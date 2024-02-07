﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PersonIdentification6.  ISO2002 ID# _QENImdp-Ed-ak6NoX_4Aeg_1939129475.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous way to identify a person.
/// </summary>
public partial record PersonIdentification6
     : IIsoXmlSerilizable<PersonIdentification6>
{
    #nullable enable
    
    /// <summary>
    /// Entity that assigns the identifier.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    /// <summary>
    /// Personal identification type.
    /// </summary>
    public required PersonIdentificationType1Choice_ PersonIdentificationType { get; init; } 
    
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
        if (Issuer is IsoMax35Text IssuerValue)
        {
            writer.WriteStartElement(null, "Issr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(IssuerValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PrsnIdTp", xmlNamespace );
        PersonIdentificationType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static PersonIdentification6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
