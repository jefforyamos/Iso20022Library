﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CashAccountIdentification1Choice.  ISO2002 ID# _PdwzpNp-Ed-ak6NoX_4Aeg_2060838761.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between formats for the identification of a cash account.
/// </summary>
[KnownType(typeof(CashAccountIdentification1Choice.IBAN))]
[KnownType(typeof(CashAccountIdentification1Choice.BBAN))]
[KnownType(typeof(CashAccountIdentification1Choice.UPIC))]
[KnownType(typeof(CashAccountIdentification1Choice.DomesticAccount))]
public abstract partial record CashAccountIdentification1Choice_ : IIsoXmlSerilizable<CashAccountIdentification1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CashAccountIdentification1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "IBAN" => CashAccountIdentification1Choice.IBAN.Deserialize(elementWithPayload),
             "BBAN" => CashAccountIdentification1Choice.BBAN.Deserialize(elementWithPayload),
             "UPIC" => CashAccountIdentification1Choice.UPIC.Deserialize(elementWithPayload),
             "DmstAcct" => CashAccountIdentification1Choice.DomesticAccount.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CashAccountIdentification1Choice choice.")
        };
    }
}
