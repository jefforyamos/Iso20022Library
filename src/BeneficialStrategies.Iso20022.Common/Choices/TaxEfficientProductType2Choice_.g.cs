﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TaxEfficientProductType2Choice.  ISO2002 ID# _Ugn1YZNNEemQB_8XA98K0Q.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for a type of tax efficient product.
/// </summary>
[KnownType(typeof(TaxEfficientProductType2Choice.Code))]
[KnownType(typeof(TaxEfficientProductType2Choice.Proprietary))]
public abstract partial record TaxEfficientProductType2Choice_ : IIsoXmlSerilizable<TaxEfficientProductType2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static TaxEfficientProductType2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => TaxEfficientProductType2Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => TaxEfficientProductType2Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid TaxEfficientProductType2Choice choice.")
        };
    }
}
