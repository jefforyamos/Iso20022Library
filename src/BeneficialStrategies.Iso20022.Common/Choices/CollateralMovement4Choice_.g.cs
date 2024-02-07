﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CollateralMovement4Choice.  ISO2002 ID# _yGZ5JYFvEeWtPe6Crjmeug.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Provides the collateral movement direction that is a delivery and optionaly a return, or a return only.
/// </summary>
[KnownType(typeof(CollateralMovement4Choice.CollateralMovementDirection))]
[KnownType(typeof(CollateralMovement4Choice.Return))]
public abstract partial record CollateralMovement4Choice_ : IIsoXmlSerilizable<CollateralMovement4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CollateralMovement4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "CollMvmntDrctn" => CollateralMovement4Choice.CollateralMovementDirection.Deserialize(elementWithPayload),
             "Rtr" => CollateralMovement4Choice.Return.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CollateralMovement4Choice choice.")
        };
    }
}
