﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by UserDefinedSchemaGenerator for LaxProcessing.  ISO2002 ID# _jLSza-5NEeCisYr99QEiWA_-1693515579.
//

using BeneficialStrategies.Iso20022.Components;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.UserDefined;

/// <summary>
/// </summary>
public partial record LaxProcessing
     : IIsoXmlSerilizable<LaxProcessing>
{
    #nullable enable
    
    
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
    }
    public static LaxProcessing Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
