﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalIdentification1.  ISO2002 ID# _0eiKZPJVEeiJn9rM2Znz2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains additional identification details of additional card acceptor data. 
/// </summary>
public partial record AdditionalIdentification1
     : IIsoXmlSerilizable<AdditionalIdentification1>
{
    #nullable enable
    
    /// <summary>
    /// Type of additional identification.
    /// </summary>
    public required AdditionalIdentificationType1Code Type { get; init; } 
    /// <summary>
    /// Other Additional Identification applied to the transaction.
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    /// <summary>
    /// Additional identification value.
    /// </summary>
    public required IsoMax35Text Value { get; init; } 
    
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
        writer.WriteValue(Type.ToString()); // Enum value
        writer.WriteEndElement();
        if (OtherType is IsoMax35Text OtherTypeValue)
        {
            writer.WriteStartElement(null, "OthrTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Val", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Value)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static AdditionalIdentification1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
