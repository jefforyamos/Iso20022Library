﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GenericIdentification78.  ISO2002 ID# _Gb99wR78EeWW2ZT-VTzGvw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification expressed as a proprietary type and narrative description.
/// </summary>
public partial record GenericIdentification78
     : IIsoXmlSerilizable<GenericIdentification78>
{
    #nullable enable
    
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    public required GenericIdentification30 Type { get; init; } 
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
    /// </summary>
    public IsoMax35Text? Identification { get; init; } 
    
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
        if (Identification is IsoMax35Text IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(IdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static GenericIdentification78 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
