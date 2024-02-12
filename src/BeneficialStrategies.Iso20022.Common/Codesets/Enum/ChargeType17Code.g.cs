﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ChargeType17Code.  ISO2002 ID# _TQuOswEcEeCQm6a_G2yO_w_-145871574.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of service for which a charge is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TQuOswEcEeCQm6a_G2yO_w_-145871574")]
[Description(@"Type of service for which a charge is asked or paid.")]
[DerivedFrom(typeof(ChargeTypeCode))]
public enum ChargeType17Code
{
    /// <summary>
    /// Charge paid for the postage.
    /// Encoded/decoded by serializers as "POST".
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_TQuOtAEcEeCQm6a_G2yO_w_-860308422")]
    [Description(@"Charge paid for the postage.")]
    PostageCharge = ChargeTypeCode.PostageCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee charged by a regulatory authority, eg, Securities and Exchange fees.
    /// Encoded/decoded by serializers as "REGF".
    /// </summary>
    [EnumMember(Value = "REGF")]
    [IsoId("_TQuOtQEcEeCQm6a_G2yO_w_-1566692032")]
    [Description(@"Fee charged by a regulatory authority, eg, Securities and Exchange fees.")]
    RegulatoryFee = ChargeTypeCode.RegulatoryFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge for shipping, including the insurance of securities.
    /// Encoded/decoded by serializers as "SHIP".
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_TQuOtgEcEeCQm6a_G2yO_w_-1577790809")]
    [Description(@"Charge for shipping, including the insurance of securities.")]
    ShippingCharge = ChargeTypeCode.ShippingCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee paid for the provision of financial services.
    /// Encoded/decoded by serializers as "CHAR".
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_TQuOtwEcEeCQm6a_G2yO_w_-110642046")]
    [Description(@"Fee paid for the provision of financial services.")]
    ServiceProvisionFee = ChargeTypeCode.ServiceProvisionFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Another type of charge.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_TQuOuAEcEeCQm6a_G2yO_w_981104540")]
    [Description(@"Another type of charge.")]
    Other = ChargeTypeCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In investment funds, pre-arranged addition to the trade amount based on the published net asset value.
    /// Encoded/decoded by serializers as "PREM".
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_TQuOuQEcEeCQm6a_G2yO_w_49770569")]
    [Description(@"In investment funds, pre-arranged addition to the trade amount based on the published net asset value.")]
    Premium = ChargeTypeCode.Premium, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is for packaging of goods.
    /// Encoded/decoded by serializers as "PACK".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_TQuOugEcEeCQm6a_G2yO_w_-756432644")]
    [Description(@"Charge is for packaging of goods.")]
    Packaging = ChargeTypeCode.Packaging, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is for pick-up of goods.
    /// Encoded/decoded by serializers as "PICK".
    /// </summary>
    [EnumMember(Value = "PICK")]
    [IsoId("_TQuOuwEcEeCQm6a_G2yO_w_710716119")]
    [Description(@"Charge is for pick-up of goods.")]
    PickUp = ChargeTypeCode.PickUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is for security.
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_TQuOvAEcEeCQm6a_G2yO_w_360968694")]
    [Description(@"Charge is for security.")]
    SecurityCharge = ChargeTypeCode.SecurityCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is a premium for insurance.
    /// Encoded/decoded by serializers as "INSU".
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_TQuOvQEcEeCQm6a_G2yO_w_1060959384")]
    [Description(@"Charge is a premium for insurance.")]
    InsurancePremium = ChargeTypeCode.InsurancePremium, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Miscellaneous fee.
    /// Encoded/decoded by serializers as "MISC".
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_TQuOvgEcEeCQm6a_G2yO_w_-970868659")]
    [Description(@"Miscellaneous fee.")]
    MiscellaneousFee = ChargeTypeCode.MiscellaneousFee, // same ordinal as derivation source for type conversions
    
}
