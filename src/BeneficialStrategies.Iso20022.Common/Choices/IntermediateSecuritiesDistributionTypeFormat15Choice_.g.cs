﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for IntermediateSecuritiesDistributionTypeFormat15Choice.  ISO2002 ID# _J6Gb4UEGEeWVgfuHGaKtRQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify the type of intermediate securities distribution.
/// </summary>
[KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat15Choice.Code))]
[KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat15Choice.Proprietary))]
public abstract partial record IntermediateSecuritiesDistributionTypeFormat15Choice_ : IIsoXmlSerilizable<IntermediateSecuritiesDistributionTypeFormat15Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static IntermediateSecuritiesDistributionTypeFormat15Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => IntermediateSecuritiesDistributionTypeFormat15Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => IntermediateSecuritiesDistributionTypeFormat15Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid IntermediateSecuritiesDistributionTypeFormat15Choice choice.")
        };
    }
}
