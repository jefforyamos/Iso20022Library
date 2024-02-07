﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstrumentOrSubClassIdentification2Choice.  ISO2002 ID# _BRbDkaaUEeqZmriXpMtonA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Identification of a financial instrument or of a non-equity sub-class
/// </summary>
[KnownType(typeof(InstrumentOrSubClassIdentification2Choice.ISINAndSubClass))]
[KnownType(typeof(InstrumentOrSubClassIdentification2Choice.AssetClassAndSubClass))]
public abstract partial record InstrumentOrSubClassIdentification2Choice_ : IIsoXmlSerilizable<InstrumentOrSubClassIdentification2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InstrumentOrSubClassIdentification2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "ISINAndSubClss" => InstrumentOrSubClassIdentification2Choice.ISINAndSubClass.Deserialize(elementWithPayload),
             "AsstClssAndSubClss" => InstrumentOrSubClassIdentification2Choice.AssetClassAndSubClass.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InstrumentOrSubClassIdentification2Choice choice.")
        };
    }
}
