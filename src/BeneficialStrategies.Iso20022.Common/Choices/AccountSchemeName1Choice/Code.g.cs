﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _P_4pQdp-Ed-ak6NoX_4Aeg_191053818.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AccountSchemeName1Choice;

/// <summary>
/// Name of the identification scheme, in a coded form as published in an external list.
/// </summary>
[DataContract(Namespace = "")]
public partial record Code : AccountSchemeName1Choice_
     , IIsoXmlSerilizable<Code>
{
    [DataMember]
    public required ExternalAccountIdentification1Code Value { get; init; }
    
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
    }
    
    public static new Code Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
    
}
