﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QuantityToReceive.  ISO2002 ID# _UHL10Np-Ed-ak6NoX_4Aeg_-1856405188.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InstructedOrQuantityToReceive1Choice;

/// <summary>
/// Quantity of the benefits that the account owner wants to receive, for example, as a result of dividend reinvestment.
/// </summary>
public partial record QuantityToReceive : InstructedOrQuantityToReceive1Choice_
     , IIsoXmlSerilizable<QuantityToReceive>
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
    public static new QuantityToReceive Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
