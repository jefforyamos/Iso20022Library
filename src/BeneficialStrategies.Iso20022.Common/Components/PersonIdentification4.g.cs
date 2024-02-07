﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PersonIdentification4.  ISO2002 ID# _V60Wp9p-Ed-ak6NoX_4Aeg_2101696687.
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
public partial record PersonIdentification4
     : IIsoXmlSerilizable<PersonIdentification4>
{
    #nullable enable
    
    /// <summary>
    /// Identifier issued to a person for which no specific identifier has been defined.
    /// </summary>
    public required RestrictedIdentification2 OtherIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "OthrId", xmlNamespace );
        OtherIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static PersonIdentification4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
