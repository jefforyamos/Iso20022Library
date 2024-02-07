﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnderlyingSecurity1.  ISO2002 ID# _TyCFO9p-Ed-ak6NoX_4Aeg_-141135720.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Securitised right for entitlement, for example, equity or bond.
/// </summary>
public partial record UnderlyingSecurity1
     : IIsoXmlSerilizable<UnderlyingSecurity1>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    public required SecurityIdentification11 SecurityIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "SctyId", xmlNamespace );
        SecurityIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static UnderlyingSecurity1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
