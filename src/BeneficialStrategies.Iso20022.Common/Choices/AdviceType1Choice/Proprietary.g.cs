﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _u3TXxdomEembTrt_WixjyQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AdviceType1Choice;

/// <summary>
/// Advice type, in a proprietary form.
/// </summary>
[DataContract(Namespace = "")]
public partial record Proprietary : AdviceType1Choice_
     , IIsoXmlSerilizable<Proprietary>
{
    [DataMember]
    public required IsoMax35Text Value { get; init; }
    
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
    }
    
    public static new Proprietary Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
    
}
