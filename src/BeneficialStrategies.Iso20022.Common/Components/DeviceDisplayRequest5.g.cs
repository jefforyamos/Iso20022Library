﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceDisplayRequest5.  ISO2002 ID# _4tgToXGZEe2TbaNWBpRZpQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the content of the display request message.
/// </summary>
public partial record DeviceDisplayRequest5
     : IIsoXmlSerilizable<DeviceDisplayRequest5>
{
    #nullable enable
    
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    public ActionMessage10? DisplayOutput { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _40P00XGZEe2TbaNWBpRZpQ
    
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
        // Not sure how to serialize DisplayOutput, multiplicity Unknown
    }
    public static DeviceDisplayRequest5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
