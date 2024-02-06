﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IBAN.  ISO2002 ID# _Pdwzotp-Ed-ak6NoX_4Aeg_-1833658189.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice;

/// <summary>
/// International Bank Account Number (IBAN) - identifier used internationally by financial institutions to uniquely identify the account of a customer. Further specifications of the format and content of the IBAN can be found in the standard ISO 13616 "Banking and related financial services - International Bank Account Number (IBAN)" version 1997-10-01, or later revisions.
/// </summary>
[DataContract(Namespace = "")]
public partial record IBAN : AccountIdentification4Choice_
     , IIsoXmlSerilizable<IBAN>
{
    [DataMember]
    public required IsoIBAN2007Identifier Value { get; init; }
    
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
    }
    
    public static new IBAN Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
    
}
