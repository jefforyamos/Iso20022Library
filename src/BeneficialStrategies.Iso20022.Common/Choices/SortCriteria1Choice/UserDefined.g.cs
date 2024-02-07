﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UserDefined.  ISO2002 ID# _U1-1htp-Ed-ak6NoX_4Aeg_1863721996.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SortCriteria1Choice;

/// <summary>
/// User-defined way of indicating how the information is broken down.
/// </summary>
public partial record UserDefined : SortCriteria1Choice_
     , IIsoXmlSerilizable<UserDefined>
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
    public static new UserDefined Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
