﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StoredValueRequest3.  ISO2002 ID# _7tZNMQxqEeqdx6buGpCCQw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request a Stored Value service (Prepaid card or account).
/// </summary>
public partial record StoredValueRequest3
     : IIsoXmlSerilizable<StoredValueRequest3>
{
    #nullable enable
    
    /// <summary>
    /// Data related to the stored value card.
    /// </summary>
    public StoredValueData3? Data { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _74xWwQxqEeqdx6buGpCCQw
    
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
        // Not sure how to serialize Data, multiplicity Unknown
    }
    public static StoredValueRequest3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
