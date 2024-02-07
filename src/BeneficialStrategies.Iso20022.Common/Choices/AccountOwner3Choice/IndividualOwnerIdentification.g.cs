﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndividualOwnerIdentification.  ISO2002 ID# _6hUREZTIEemqYPWMBuVawg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AccountOwner3Choice;

/// <summary>
/// Identification of the individual person that legally owns the account.
/// </summary>
public partial record IndividualOwnerIdentification : AccountOwner3Choice_
     , IIsoXmlSerilizable<IndividualOwnerIdentification>
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
    public static new IndividualOwnerIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
