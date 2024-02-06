﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountIdentification4Choice.  ISO2002 ID# _Pdwzodp-Ed-ak6NoX_4Aeg_-1833658219.
//

using System.Xml;
using System.Xml.Linq;
namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the unique identification of an account as assigned by the account servicer.
/// </summary>
[KnownType(typeof(AccountIdentification4Choice.IBAN))]
[KnownType(typeof(AccountIdentification4Choice.Other))]
[DataContract(Namespace = "")]
public abstract partial record AccountIdentification4Choice_ : IIsoXmlSerilizable<AccountIdentification4Choice_>
{
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    public static AccountIdentification4Choice_ Deserialize(XElement element) { throw new NotImplementedException(); }
}
