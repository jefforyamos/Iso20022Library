﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BeneficialOwnership3Choice.  ISO2002 ID# _AbDZwdokEeC60axPepSq7g_1929914426.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the beneficial ownership.
/// </summary>
[KnownType(typeof(BeneficialOwnership3Choice.Indicator))]
[KnownType(typeof(BeneficialOwnership3Choice.Proprietary))]
public abstract partial record BeneficialOwnership3Choice_ : IIsoXmlSerilizable<BeneficialOwnership3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static BeneficialOwnership3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Ind" => BeneficialOwnership3Choice.Indicator.Deserialize(elementWithPayload),
             "Prtry" => BeneficialOwnership3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid BeneficialOwnership3Choice choice.")
        };
    }
}
