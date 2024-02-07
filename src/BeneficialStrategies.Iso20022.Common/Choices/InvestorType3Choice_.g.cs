﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InvestorType3Choice.  ISO2002 ID# _czZDx-LxEeWOD7aAy2fAcA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for investor type.
/// </summary>
[KnownType(typeof(InvestorType3Choice.Code))]
[KnownType(typeof(InvestorType3Choice.Proprietary))]
public abstract partial record InvestorType3Choice_ : IIsoXmlSerilizable<InvestorType3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InvestorType3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => InvestorType3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => InvestorType3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InvestorType3Choice choice.")
        };
    }
}
