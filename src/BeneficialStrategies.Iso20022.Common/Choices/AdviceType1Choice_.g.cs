﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AdviceType1Choice.  ISO2002 ID# _u3TXw9omEembTrt_WixjyQ.
//

using System.Xml;
using System.Xml.Linq;
namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the type of advice requested for the transaction.
/// </summary>
[KnownType(typeof(AdviceType1Choice.Code))]
[KnownType(typeof(AdviceType1Choice.Proprietary))]
[DataContract(Namespace = "")]
public abstract partial record AdviceType1Choice_ : IIsoXmlSerilizable<AdviceType1Choice_>
{
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    public static AdviceType1Choice_ Deserialize(XElement element) { throw new NotImplementedException(); }
}
