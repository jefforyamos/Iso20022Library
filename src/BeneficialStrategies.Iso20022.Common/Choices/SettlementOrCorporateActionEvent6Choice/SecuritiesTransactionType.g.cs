﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesTransactionType.  ISO2002 ID# _fw8YBfvmEeCBQp5TnX1XKQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SettlementOrCorporateActionEvent6Choice;

/// <summary>
/// Identifies the type of securities transaction.
/// </summary>
public partial record SecuritiesTransactionType : SettlementOrCorporateActionEvent6Choice_
     , IIsoXmlSerilizable<SecuritiesTransactionType>
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
    public static new SecuritiesTransactionType Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
