﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ChequeDelivery2Code.  ISO2002 ID# _a-oOwNp-Ed-ak6NoX_4Aeg_94504006.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method to be used in delivering a cheque to a party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a-oOwNp-Ed-ak6NoX_4Aeg_94504006")]
[Description(@"Specifies the method to be used in delivering a cheque to a party.")]
[DerivedFrom(typeof(ChequeDeliveryCode))]
public enum ChequeDelivery2Code
{
    /// <summary>
    /// Cheque is to be sent through mail services to creditor agent.
    /// Encoded/decoded by serializers as "MLFA".
    /// </summary>
    [EnumMember(Value = "MLFA")]
    [IsoId("_a-oOwdp-Ed-ak6NoX_4Aeg_94504069")]
    [Description(@"Cheque is to be sent through mail services to creditor agent.")]
    MailToFinalAgent = ChequeDeliveryCode.MailToFinalAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cheque is to be sent through courier services to creditor agent.
    /// Encoded/decoded by serializers as "CRFA".
    /// </summary>
    [EnumMember(Value = "CRFA")]
    [IsoId("_a-oOwtp-Ed-ak6NoX_4Aeg_94504160")]
    [Description(@"Cheque is to be sent through courier services to creditor agent.")]
    CourierToFinalAgent = ChequeDeliveryCode.CourierToFinalAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cheque will be picked up by the creditor agent.
    /// Encoded/decoded by serializers as "PUFA".
    /// </summary>
    [EnumMember(Value = "PUFA")]
    [IsoId("_a-oOw9p-Ed-ak6NoX_4Aeg_94504439")]
    [Description(@"Cheque will be picked up by the creditor agent.")]
    PickUpByFinalAgent = ChequeDeliveryCode.PickUpByFinalAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cheque is to be sent through registered mail services to creditor agent.
    /// Encoded/decoded by serializers as "RGFA".
    /// </summary>
    [EnumMember(Value = "RGFA")]
    [IsoId("_a-oOxNp-Ed-ak6NoX_4Aeg_94504499")]
    [Description(@"Cheque is to be sent through registered mail services to creditor agent.")]
    RegisteredMailToFinalAgent = ChequeDeliveryCode.RegisteredMailToFinalAgent, // same ordinal as derivation source for type conversions
    
}
