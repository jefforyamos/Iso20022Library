﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BeneficiaryType1Choice.  ISO2002 ID# _xDPgIFNgEeijdq8ilaxyOA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for a type of beneficiary.
/// </summary>
[KnownType(typeof(BeneficiaryType1Choice.Code))]
[KnownType(typeof(BeneficiaryType1Choice.Proprietary))]
public abstract partial record BeneficiaryType1Choice_ : IIsoXmlSerilizable<BeneficiaryType1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static BeneficiaryType1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => BeneficiaryType1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => BeneficiaryType1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid BeneficiaryType1Choice choice.")
        };
    }
}
