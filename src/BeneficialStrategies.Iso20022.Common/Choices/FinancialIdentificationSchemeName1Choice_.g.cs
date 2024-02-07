﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialIdentificationSchemeName1Choice.  ISO2002 ID# _QALkMNp-Ed-ak6NoX_4Aeg_-2021925461.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Sets of elements to identify a name of the organisation identification scheme.
/// </summary>
[KnownType(typeof(FinancialIdentificationSchemeName1Choice.Code))]
[KnownType(typeof(FinancialIdentificationSchemeName1Choice.Proprietary))]
public abstract partial record FinancialIdentificationSchemeName1Choice_ : IIsoXmlSerilizable<FinancialIdentificationSchemeName1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static FinancialIdentificationSchemeName1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => FinancialIdentificationSchemeName1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => FinancialIdentificationSchemeName1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid FinancialIdentificationSchemeName1Choice choice.")
        };
    }
}
