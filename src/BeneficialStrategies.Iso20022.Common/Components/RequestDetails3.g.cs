﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RequestDetails3.  ISO2002 ID# _SuwKGQEcEeCQm6a_G2yO_w_49393758.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of data request.
/// </summary>
public partial record RequestDetails3
     : IIsoXmlSerilizable<RequestDetails3>
{
    #nullable enable
    
    /// <summary>
    /// Type of data being requested, for example, a sub-member BIC.
    /// </summary>
    public required IsoMax35Text Type { get; init; } 
    /// <summary>
    /// Specific report data requested, for example, a BIC.
    /// </summary>
    public IsoMax35Text? Key { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Type)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (Key is IsoMax35Text KeyValue)
        {
            writer.WriteStartElement(null, "Key", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(KeyValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static RequestDetails3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
