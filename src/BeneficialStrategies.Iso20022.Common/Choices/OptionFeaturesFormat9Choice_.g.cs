﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OptionFeaturesFormat9Choice.  ISO2002 ID# _z-bBsfonEeCM181g5EbUXw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or a proprietary code to specify the features that may apply to a corporate action option.
/// </summary>
[KnownType(typeof(OptionFeaturesFormat9Choice.Code))]
[KnownType(typeof(OptionFeaturesFormat9Choice.Proprietary))]
public abstract partial record OptionFeaturesFormat9Choice_ : IIsoXmlSerilizable<OptionFeaturesFormat9Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static OptionFeaturesFormat9Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => OptionFeaturesFormat9Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => OptionFeaturesFormat9Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid OptionFeaturesFormat9Choice choice.")
        };
    }
}
