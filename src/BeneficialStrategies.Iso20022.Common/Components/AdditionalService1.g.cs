﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalService1.  ISO2002 ID# _tv_4oJ8NEei6TYPuA7AYQg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional functions or services to be performed in conjunction with the transaction.
/// </summary>
public partial record AdditionalService1
     : IIsoXmlSerilizable<AdditionalService1>
{
    #nullable enable
    
    /// <summary>
    /// Type of additional service applied to the transaction.
    /// </summary>
    public required AdditionalServiceType1Code Type { get; init; } 
    /// <summary>
    /// Other additional service applied to the transaction.
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    
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
    }
    public static AdditionalService1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
