﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ModificationScope23.  ISO2002 ID# _HqIgDQhDEeSUPbC7DbLJpQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of modification to be applied on a data set.
/// </summary>
public partial record ModificationScope23
     : IIsoXmlSerilizable<ModificationScope23>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    public required DataModification2Code ModificationScopeIndication { get; init; } 
    /// <summary>
    /// Alternative identification, for example, national registration identification number, passport number, or an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
    /// </summary>
    public required GenericIdentification55 OtherIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "ModScpIndctn", xmlNamespace );
        writer.WriteValue(ModificationScopeIndication.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OthrId", xmlNamespace );
        OtherIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static ModificationScope23 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
