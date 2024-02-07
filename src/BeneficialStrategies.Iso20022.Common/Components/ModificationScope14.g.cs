﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ModificationScope14.  ISO2002 ID# _fZu8wROGEeKjmvxNCObNeQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Scope of the modification to be applied on an identified set of information.
/// </summary>
public partial record ModificationScope14
     : IIsoXmlSerilizable<ModificationScope14>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    public required DataModification2Code ModificationScopeIndication { get; init; } 
    /// <summary>
    /// Detailed information about the party profile information.
    /// </summary>
    public required PartyProfileInformation2 InvestorProfileValidation { get; init; } 
    
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
        writer.WriteStartElement(null, "InvstrPrflVldtn", xmlNamespace );
        InvestorProfileValidation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static ModificationScope14 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
