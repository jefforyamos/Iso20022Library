﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProxyAccountType1Choice.  ISO2002 ID# _dyock3h3EeidzqjNEfehPg.
//

using System.Xml;
using System.Xml.Linq;
namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the scheme used for the identification of an account alias.
/// </summary>
[KnownType(typeof(ProxyAccountType1Choice.Code))]
[KnownType(typeof(ProxyAccountType1Choice.Proprietary))]
[DataContract(Namespace = "")]
public abstract partial record ProxyAccountType1Choice_ : IIsoXmlSerilizable<ProxyAccountType1Choice_>
{
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    public static ProxyAccountType1Choice_ Deserialize(XElement element) { throw new NotImplementedException(); }
}
