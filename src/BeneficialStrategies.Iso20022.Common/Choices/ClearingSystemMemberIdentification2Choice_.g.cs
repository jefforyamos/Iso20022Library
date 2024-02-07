﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ClearingSystemMemberIdentification2Choice.  ISO2002 ID# _TCzAqtp-Ed-ak6NoX_4Aeg_1989939445.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of identifiers for a clearing system member, as assigned by the clearing system. In some clearing systems, the accounts of the clearing system members are also assigned an identifier.
/// </summary>
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.CHIPSUniversalIdentification))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.NewZealandNCCIdentification))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.IrishNSCIdentification))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.UKDomesticSortCode))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.CHIPSParticipantIdentification))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.SwissBCIdentification))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.FedwireRoutingNumberIdentification))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.PortugueseNCCIdentification))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.RussianCentralBankIdentificationCode))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.ItalianDomesticIdentificationCode))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.AustrianBankleitzahlIdentification))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.CanadianPaymentsAssociationRoutingNumberIdentification))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.SwissSICIdentification))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.GermanBankleitzahlIdentification))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.SpanishDomesticInterbankingIdentification))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.SouthAfricanNCCIdentification))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.HongKongBankCode))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.AustralianExtensiveBranchNetworkIdentification))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.AustralianSmallNetworkIdentification))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.IndianFinancialSystemCode))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.HellenicBankIdentificationCode))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.PolishNationalClearingCode))]
[KnownType(typeof(ClearingSystemMemberIdentification2Choice.OtherClearingCodeIdentification))]
public abstract partial record ClearingSystemMemberIdentification2Choice_ : IIsoXmlSerilizable<ClearingSystemMemberIdentification2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ClearingSystemMemberIdentification2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "USCHU" => ClearingSystemMemberIdentification2Choice.CHIPSUniversalIdentification.Deserialize(elementWithPayload),
             "NZNCC" => ClearingSystemMemberIdentification2Choice.NewZealandNCCIdentification.Deserialize(elementWithPayload),
             "IENSC" => ClearingSystemMemberIdentification2Choice.IrishNSCIdentification.Deserialize(elementWithPayload),
             "GBSC" => ClearingSystemMemberIdentification2Choice.UKDomesticSortCode.Deserialize(elementWithPayload),
             "USCH" => ClearingSystemMemberIdentification2Choice.CHIPSParticipantIdentification.Deserialize(elementWithPayload),
             "CHBC" => ClearingSystemMemberIdentification2Choice.SwissBCIdentification.Deserialize(elementWithPayload),
             "USFW" => ClearingSystemMemberIdentification2Choice.FedwireRoutingNumberIdentification.Deserialize(elementWithPayload),
             "PTNCC" => ClearingSystemMemberIdentification2Choice.PortugueseNCCIdentification.Deserialize(elementWithPayload),
             "RUCB" => ClearingSystemMemberIdentification2Choice.RussianCentralBankIdentificationCode.Deserialize(elementWithPayload),
             "ITNCC" => ClearingSystemMemberIdentification2Choice.ItalianDomesticIdentificationCode.Deserialize(elementWithPayload),
             "ATBLZ" => ClearingSystemMemberIdentification2Choice.AustrianBankleitzahlIdentification.Deserialize(elementWithPayload),
             "CACPA" => ClearingSystemMemberIdentification2Choice.CanadianPaymentsAssociationRoutingNumberIdentification.Deserialize(elementWithPayload),
             "CHSIC" => ClearingSystemMemberIdentification2Choice.SwissSICIdentification.Deserialize(elementWithPayload),
             "DEBLZ" => ClearingSystemMemberIdentification2Choice.GermanBankleitzahlIdentification.Deserialize(elementWithPayload),
             "ESNCC" => ClearingSystemMemberIdentification2Choice.SpanishDomesticInterbankingIdentification.Deserialize(elementWithPayload),
             "ZANCC" => ClearingSystemMemberIdentification2Choice.SouthAfricanNCCIdentification.Deserialize(elementWithPayload),
             "HKNCC" => ClearingSystemMemberIdentification2Choice.HongKongBankCode.Deserialize(elementWithPayload),
             "AUBSBx" => ClearingSystemMemberIdentification2Choice.AustralianExtensiveBranchNetworkIdentification.Deserialize(elementWithPayload),
             "AUBSBs" => ClearingSystemMemberIdentification2Choice.AustralianSmallNetworkIdentification.Deserialize(elementWithPayload),
             "INIFSC" => ClearingSystemMemberIdentification2Choice.IndianFinancialSystemCode.Deserialize(elementWithPayload),
             "GRHEBIC" => ClearingSystemMemberIdentification2Choice.HellenicBankIdentificationCode.Deserialize(elementWithPayload),
             "PLKNR" => ClearingSystemMemberIdentification2Choice.PolishNationalClearingCode.Deserialize(elementWithPayload),
             "OthrClrCdId" => ClearingSystemMemberIdentification2Choice.OtherClearingCodeIdentification.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ClearingSystemMemberIdentification2Choice choice.")
        };
    }
}
