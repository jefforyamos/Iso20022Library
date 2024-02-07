﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyTextInformation4.  ISO2002 ID# _Wh3IiNp-Ed-ak6NoX_4Aeg_51306419.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
/// </summary>
public partial record PartyTextInformation4
     : IIsoXmlSerilizable<PartyTextInformation4>
{
    #nullable enable
    
    /// <summary>
    /// Provides declaration details narrative relative to the party.
    /// </summary>
    public IsoRestrictedFINXMax350Text? DeclarationDetails { get; init; } 
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    public IsoRestrictedFINXMax140Text? PartyContactDetails { get; init; } 
    
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
        if (DeclarationDetails is IsoRestrictedFINXMax350Text DeclarationDetailsValue)
        {
            writer.WriteStartElement(null, "DclrtnDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax350Text(DeclarationDetailsValue)); // data type RestrictedFINXMax350Text System.String
            writer.WriteEndElement();
        }
        if (PartyContactDetails is IsoRestrictedFINXMax140Text PartyContactDetailsValue)
        {
            writer.WriteStartElement(null, "PtyCtctDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax140Text(PartyContactDetailsValue)); // data type RestrictedFINXMax140Text System.String
            writer.WriteEndElement();
        }
    }
    public static PartyTextInformation4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
