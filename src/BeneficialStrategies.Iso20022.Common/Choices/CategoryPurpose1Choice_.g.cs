﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CategoryPurpose1Choice.  ISO2002 ID# _THaa5Np-Ed-ak6NoX_4Aeg_1223014142.
//

using System.Xml;
using System.Xml.Linq;
namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the high level purpose of the instruction based on a set of pre-defined categories.|Usage: This is used by the initiating party to provide information concerning the processing of the payment. It is likely to trigger special processing by any of the agents involved in the payment chain.
/// </summary>
[KnownType(typeof(CategoryPurpose1Choice.Code))]
[KnownType(typeof(CategoryPurpose1Choice.Proprietary))]
[DataContract(Namespace = "")]
public abstract partial record CategoryPurpose1Choice_ : IIsoXmlSerilizable<CategoryPurpose1Choice_>
{
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    public static CategoryPurpose1Choice_ Deserialize(XElement element) { throw new NotImplementedException(); }
}
