﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SettlementStatus.  ISO2002 ID# _4BGdIP8dEeCrw_OT0uBMXQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Status9Choice;

/// <summary>
/// Provides the status of settlement of a transaction.
/// </summary>
public partial record SettlementStatus : Status9Choice_
     , IIsoXmlSerilizable<SettlementStatus>
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
    public static new SettlementStatus Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
