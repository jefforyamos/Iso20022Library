﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ChargeType11Code.  ISO2002 ID# _a8YzGNp-Ed-ak6NoX_4Aeg_2072866116.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of service for which a charge is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a8YzGNp-Ed-ak6NoX_4Aeg_2072866116")]
[Description(@"Specifies the type of service for which a charge is asked or paid.")]
[DerivedFrom(typeof(ChargeTypeCode))]
public enum ChargeType11Code
{
    /// <summary>
    /// Sales charge paid by the investor when redeeming an investment such as an investment fund.
    /// Encoded/decoded by serializers as "BEND".
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_a8ikENp-Ed-ak6NoX_4Aeg_2072866134")]
    [Description(@"Sales charge paid by the investor when redeeming an investment such as an investment fund.")]
    BackEndLoad = ChargeTypeCode.BackEndLoad, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund.
    /// Encoded/decoded by serializers as "FEND".
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_a8ikEdp-Ed-ak6NoX_4Aeg_2072866135")]
    [Description(@"Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund.")]
    FrontEndLoad = ChargeTypeCode.FrontEndLoad, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In investment funds, charge related to a switch transaction.
    /// Encoded/decoded by serializers as "SWIT".
    /// </summary>
    [EnumMember(Value = "SWIT")]
    [IsoId("_a8ikEtp-Ed-ak6NoX_4Aeg_2072866151")]
    [Description(@"In investment funds, charge related to a switch transaction.")]
    Switch = ChargeTypeCode.Switch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In investment funds, a charge payable by the investor covering bid-offer spreads and dealing charges for the underlying investments. The dilution levy is paid to the fund for the benefit of other unit holders.
    /// Encoded/decoded by serializers as "DLEV".
    /// </summary>
    [EnumMember(Value = "DLEV")]
    [IsoId("_a8ikE9p-Ed-ak6NoX_4Aeg_2072866169")]
    [Description(@"In investment funds, a charge payable by the investor covering bid-offer spreads and dealing charges for the underlying investments. The dilution levy is paid to the fund for the benefit of other unit holders.")]
    DilutionLevy = ChargeTypeCode.DilutionLevy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge that has been reduced from the standard initial charge levied by a fund, eg, during a launch period or as negotiated by a funds supermarket / discount broker.
    /// Encoded/decoded by serializers as "DISC".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_a8ikFNp-Ed-ak6NoX_4Aeg_2072866170")]
    [Description(@"Charge that has been reduced from the standard initial charge levied by a fund, eg, during a launch period or as negotiated by a funds supermarket / discount broker.")]
    Discount = ChargeTypeCode.Discount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee charged to the investor for early redemption of the fund.
    /// Encoded/decoded by serializers as "PENA".
    /// </summary>
    [EnumMember(Value = "PENA")]
    [IsoId("_a8ikFdp-Ed-ak6NoX_4Aeg_2072866194")]
    [Description(@"Fee charged to the investor for early redemption of the fund.")]
    Penalty = ChargeTypeCode.Penalty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge paid for the postage.
    /// Encoded/decoded by serializers as "POST".
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_a8ikFtp-Ed-ak6NoX_4Aeg_2072866211")]
    [Description(@"Charge paid for the postage.")]
    PostageCharge = ChargeTypeCode.PostageCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee charged by a regulatory authority, eg, Securities and Exchange fees.
    /// Encoded/decoded by serializers as "REGF".
    /// </summary>
    [EnumMember(Value = "REGF")]
    [IsoId("_a8ikF9p-Ed-ak6NoX_4Aeg_2072866229")]
    [Description(@"Fee charged by a regulatory authority, eg, Securities and Exchange fees.")]
    RegulatoryFee = ChargeTypeCode.RegulatoryFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge for shipping, including the insurance of securities.
    /// Encoded/decoded by serializers as "SHIP".
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_a8ikGNp-Ed-ak6NoX_4Aeg_2072866230")]
    [Description(@"Charge for shipping, including the insurance of securities.")]
    ShippingCharge = ChargeTypeCode.ShippingCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee paid for the provision of financial services.
    /// Encoded/decoded by serializers as "CHAR".
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_a8ikGdp-Ed-ak6NoX_4Aeg_2072866254")]
    [Description(@"Fee paid for the provision of financial services.")]
    ServiceProvisionFee = ChargeTypeCode.ServiceProvisionFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deferred sales charge.
    /// Encoded/decoded by serializers as "CDSC".
    /// </summary>
    [EnumMember(Value = "CDSC")]
    [IsoId("_a8ruANp-Ed-ak6NoX_4Aeg_2072866271")]
    [Description(@"Deferred sales charge.")]
    ContingencyDeferredSalesCharge = ChargeTypeCode.ContingencyDeferredSalesCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In investment funds, the charge of the correspondent bank for transferring money.
    /// Encoded/decoded by serializers as "CBCH".
    /// </summary>
    [EnumMember(Value = "CBCH")]
    [IsoId("_a8ruAdp-Ed-ak6NoX_4Aeg_2072866289")]
    [Description(@"In investment funds, the charge of the correspondent bank for transferring money.")]
    CorrespondentBankCharge = ChargeTypeCode.CorrespondentBankCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In investment funds, pre-arranged addition to the trade amount based on the published net asset value.
    /// Encoded/decoded by serializers as "PREM".
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_a8ruAtp-Ed-ak6NoX_4Aeg_2072866306")]
    [Description(@"In investment funds, pre-arranged addition to the trade amount based on the published net asset value.")]
    Premium = ChargeTypeCode.Premium, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge paid at the time of the first subscription.
    /// Encoded/decoded by serializers as "INIT".
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_a8ruA9p-Ed-ak6NoX_4Aeg_2072866324")]
    [Description(@"Charge paid at the time of the first subscription.")]
    Initial = ChargeTypeCode.Initial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee paid to a broker for services provided.
    /// Encoded/decoded by serializers as "BRKF".
    /// </summary>
    [EnumMember(Value = "BRKF")]
    [IsoId("_a8ruBNp-Ed-ak6NoX_4Aeg_520427293")]
    [Description(@"Fee paid to a broker for services provided.")]
    BrokerageFee = ChargeTypeCode.BrokerageFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charges paid by the investor to the Fund Company for subscription and redemption orders.
    /// Encoded/decoded by serializers as "UCIC".
    /// </summary>
    [EnumMember(Value = "UCIC")]
    [IsoId("_a8ruBdp-Ed-ak6NoX_4Aeg_989573292")]
    [Description(@"Charges paid by the investor to the Fund Company for subscription and redemption orders.")]
    UCITSCommission = ChargeTypeCode.UCITSCommission, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ChargeType11CodeMetadataExtensions
{
    private static readonly ChargeType11CodeDropdownSource _dropdownSource = new ChargeType11CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IChargeType11CodeDropdownRow GetMetadata(this ChargeType11Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


