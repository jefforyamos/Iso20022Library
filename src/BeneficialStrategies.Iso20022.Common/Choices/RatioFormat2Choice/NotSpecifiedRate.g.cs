﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedRate.  ISO2002 ID# _Rj3kiNp-Ed-ak6NoX_4Aeg_1125895713.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat2Choice;

/// <summary>
/// The value of the ratio is not specified.
/// </summary>
public partial record NotSpecifiedRate : RatioFormat2Choice_
     , IIsoXmlSerilizable<NotSpecifiedRate>
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
    public static new NotSpecifiedRate Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
