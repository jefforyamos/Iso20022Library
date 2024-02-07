﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProductIdentifier2.  ISO2002 ID# _TRPsXdp-Ed-ak6NoX_4Aeg_-1876396278.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used to identify a product.
/// </summary>
public partial record ProductIdentifier2
     : IIsoXmlSerilizable<ProductIdentifier2>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of product identifier by means of a code.
    /// </summary>
    public required ProductIdentifier2Code Type { get; init; } 
    /// <summary>
    /// Specifies the product identifier.
    /// </summary>
    public required IsoMax35Text Identifier { get; init; } 
    
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
        writer.WriteStartElement(null, "Idr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identifier)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static ProductIdentifier2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
