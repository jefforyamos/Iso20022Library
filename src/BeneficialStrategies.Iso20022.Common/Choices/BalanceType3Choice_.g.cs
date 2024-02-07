﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BalanceType3Choice.  ISO2002 ID# _RcRuw9p-Ed-ak6NoX_4Aeg_-1428945866.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Set of elements defining the balance details.
/// </summary>
[KnownType(typeof(BalanceType3Choice.Code))]
[KnownType(typeof(BalanceType3Choice.Proprietary))]
public abstract partial record BalanceType3Choice_ : IIsoXmlSerilizable<BalanceType3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static BalanceType3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => BalanceType3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => BalanceType3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid BalanceType3Choice choice.")
        };
    }
}
