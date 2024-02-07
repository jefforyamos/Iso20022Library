﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MaturityRedemptionType3Choice.  ISO2002 ID# _d8mHheLxEeWOD7aAy2fAcA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for maturity redemption type.
/// </summary>
[KnownType(typeof(MaturityRedemptionType3Choice.Code))]
[KnownType(typeof(MaturityRedemptionType3Choice.Proprietary))]
public abstract partial record MaturityRedemptionType3Choice_ : IIsoXmlSerilizable<MaturityRedemptionType3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static MaturityRedemptionType3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => MaturityRedemptionType3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => MaturityRedemptionType3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid MaturityRedemptionType3Choice choice.")
        };
    }
}
