﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SettlementConditionModificationStatus.  ISO2002 ID# _UVMcoNp-Ed-ak6NoX_4Aeg_-135724603.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Status1Choice;

/// <summary>
/// Provides the status of a securities settlement condition modification request.
/// </summary>
public partial record SettlementConditionModificationStatus : Status1Choice_
     , IIsoXmlSerilizable<SettlementConditionModificationStatus>
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
    public static new SettlementConditionModificationStatus Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
