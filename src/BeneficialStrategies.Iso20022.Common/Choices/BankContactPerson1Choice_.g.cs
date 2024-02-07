﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BankContactPerson1Choice.  ISO2002 ID# _eCkSADAZEeOKib24wnHaFg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Contact person details in a bank.
/// </summary>
[KnownType(typeof(BankContactPerson1Choice.BuyerBankContactPerson))]
[KnownType(typeof(BankContactPerson1Choice.SellerBankContactPerson))]
public abstract partial record BankContactPerson1Choice_ : IIsoXmlSerilizable<BankContactPerson1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static BankContactPerson1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "BuyrBkCtctPrsn" => BankContactPerson1Choice.BuyerBankContactPerson.Deserialize(elementWithPayload),
             "SellrBkCtctPrsn" => BankContactPerson1Choice.SellerBankContactPerson.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid BankContactPerson1Choice choice.")
        };
    }
}
