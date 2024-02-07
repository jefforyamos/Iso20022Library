﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AffirmationStatus.  ISO2002 ID# _UU5htNp-Ed-ak6NoX_4Aeg_1993451566.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Status1Choice;

/// <summary>
/// Status of affirmation of a trade.
/// </summary>
public partial record AffirmationStatus : Status1Choice_
     , IIsoXmlSerilizable<AffirmationStatus>
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
    public static new AffirmationStatus Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
