﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CorporateActionEventType.  ISO2002 ID# _sanT_ffZEeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SettlementOrCorporateActionEvent29Choice;

/// <summary>
/// Specifies the type of corporate event.
/// </summary>
public partial record CorporateActionEventType : SettlementOrCorporateActionEvent29Choice_
     , IIsoXmlSerilizable<CorporateActionEventType>
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
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
    }
    public static new CorporateActionEventType Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
