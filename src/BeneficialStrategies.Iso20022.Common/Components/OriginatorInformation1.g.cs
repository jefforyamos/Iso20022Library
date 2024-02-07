﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginatorInformation1.  ISO2002 ID# __XpcEOCwEee83LAjB5Kqdw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the originator. It is present only if required by the key management algorithm.
/// </summary>
public partial record OriginatorInformation1
     : IIsoXmlSerilizable<OriginatorInformation1>
{
    #nullable enable
    
    /// <summary>
    /// It may contain originator certificates associated with several different key management algorithms.
    /// </summary>
    public IsoMax5000Binary? Certificate { get; init; } 
    
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
        if (Certificate is IsoMax5000Binary CertificateValue)
        {
            writer.WriteStartElement(null, "Cert", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax5000Binary(CertificateValue)); // data type Max5000Binary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static OriginatorInformation1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
