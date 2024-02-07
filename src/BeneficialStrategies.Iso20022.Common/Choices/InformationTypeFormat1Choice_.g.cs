﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InformationTypeFormat1Choice.  ISO2002 ID# __SFAwCXaEeOFIcNWlDEvdQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify the information type format required.
/// </summary>
[KnownType(typeof(InformationTypeFormat1Choice.Code))]
[KnownType(typeof(InformationTypeFormat1Choice.Proprietary))]
public abstract partial record InformationTypeFormat1Choice_ : IIsoXmlSerilizable<InformationTypeFormat1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InformationTypeFormat1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => InformationTypeFormat1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => InformationTypeFormat1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InformationTypeFormat1Choice choice.")
        };
    }
}
