﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CentralSecuritiesDepositoryParticipant.  ISO2002 ID# _viBlUcg4Eeu4ecZgAYuz5w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SettlementParties34Choice;

/// <summary>
/// Identification of the central securities depository participant involved in the transaction.
/// </summary>
public partial record CentralSecuritiesDepositoryParticipant : SettlementParties34Choice_
     , IIsoXmlSerilizable<CentralSecuritiesDepositoryParticipant>
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
    public static new CentralSecuritiesDepositoryParticipant Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
