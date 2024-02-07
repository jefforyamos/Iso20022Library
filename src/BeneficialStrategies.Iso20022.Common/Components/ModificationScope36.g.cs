﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ModificationScope36.  ISO2002 ID# _sI1OgU_jEeaB8-OWTiMVrQ.
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
public partial record ModificationScope36
     : IIsoXmlSerilizable<ModificationScope36>
{
    #nullable enable
    
    /// <summary>
    /// Type of modification to be applied.
    /// </summary>
    public required DataModification2Code ModificationScopeIndication { get; init; } 
    /// <summary>
    /// Detailed information about the investment fund or security associated to the account.
    /// </summary>
    public required FinancialInstrument56 FinancialInstrumentDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "FinInstrmDtls", xmlNamespace );
        FinancialInstrumentDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static ModificationScope36 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
