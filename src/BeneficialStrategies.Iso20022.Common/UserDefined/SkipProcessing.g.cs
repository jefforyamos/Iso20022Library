﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by UserDefinedSchemaGenerator for SkipProcessing.  ISO2002 ID# _RreBWNp-Ed-ak6NoX_4Aeg_-72452402.
//

using BeneficialStrategies.Iso20022.Components;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.UserDefined;

/// <summary>
/// The Any element without further validation processing.
/// </summary>
public partial record SkipProcessing
     : IIsoXmlSerilizable<SkipProcessing>
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
    public static SkipProcessing Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
