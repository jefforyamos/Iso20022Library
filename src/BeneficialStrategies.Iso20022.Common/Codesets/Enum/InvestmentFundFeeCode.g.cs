﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestmentFundFeeCode.  ISO2002 ID# _GX-V4DiAEeaH-93K5JKmzw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of service for which a fee is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GX-V4DiAEeaH-93K5JKmzw")]
[Description(@"Specifies the type of service for which a fee is asked or paid.")]
public enum InvestmentFundFeeCode
{
    /// <summary>
    /// Fee paid for accounting services rendered.
    /// Encoded/decoded by serializers as "ACCT".
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_SutpUziAEeaH-93K5JKmzw")]
    [Description(@"Fee paid for accounting services rendered.")]
    AccountingFee,
    
    /// <summary>
    /// Fee paid by the investor to the fund or fund management company when redeeming.
    /// Encoded/decoded by serializers as "BEND".
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_SutpVziAEeaH-93K5JKmzw")]
    [Description(@"Fee paid by the investor to the fund or fund management company when redeeming.")]
    BackEndLoad,
    
    /// <summary>
    /// Fee paid to a broker for services provided.
    /// Encoded/decoded by serializers as "BRKF".
    /// </summary>
    [EnumMember(Value = "BRKF")]
    [IsoId("_SutpWDiAEeaH-93K5JKmzw")]
    [Description(@"Fee paid to a broker for services provided.")]
    BrokerageFee,
    
    /// <summary>
    /// Deferred sales charge.
    /// Encoded/decoded by serializers as "CDSC".
    /// </summary>
    [EnumMember(Value = "CDSC")]
    [IsoId("_SutpXTiAEeaH-93K5JKmzw")]
    [Description(@"Deferred sales charge.")]
    ContingentDeferredSalesCharge,
    
    /// <summary>
    /// In investment funds, the charge of the correspondent bank for transferring money.
    /// Encoded/decoded by serializers as "CBCH".
    /// </summary>
    [EnumMember(Value = "CBCH")]
    [IsoId("_SutpXjiAEeaH-93K5JKmzw")]
    [Description(@"In investment funds, the charge of the correspondent bank for transferring money.")]
    CorrespondentBankCharge,
    
    /// <summary>
    /// Fee paid to a custodian in respect of custodial services.
    /// Encoded/decoded by serializers as "CUST".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_SutpXziAEeaH-93K5JKmzw")]
    [Description(@"Fee paid to a custodian in respect of custodial services.")]
    CustodyFee,
    
    /// <summary>
    /// In investment funds, a charge payable by the investor covering bid-offer spreads and dealing charges for the underlying investments. The dilution levy is paid to the fund for the benefit of other unit holders.
    /// Encoded/decoded by serializers as "DLEV".
    /// </summary>
    [EnumMember(Value = "DLEV")]
    [IsoId("_SutpYTiAEeaH-93K5JKmzw")]
    [Description(@"In investment funds, a charge payable by the investor covering bid-offer spreads and dealing charges for the underlying investments. The dilution levy is paid to the fund for the benefit of other unit holders.")]
    DilutionLevy,
    
    /// <summary>
    /// Charge that has been reduced by a fund.
    /// Encoded/decoded by serializers as "DISC".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_SutpYjiAEeaH-93K5JKmzw")]
    [Description(@"Charge that has been reduced by a fund.")]
    Discount,
    
    /// <summary>
    /// The part of an investor's subscription amount that is held by the fund in order to pay incentive or performance fees at the end of the fiscal year.
    /// Encoded/decoded by serializers as "EQUL".
    /// </summary>
    [EnumMember(Value = "EQUL")]
    [IsoId("_SutpYziAEeaH-93K5JKmzw")]
    [Description(@"The part of an investor's subscription amount that is held by the fund in order to pay incentive or performance fees at the end of the fiscal year.")]
    Equalisation,
    
    /// <summary>
    /// Fee paid by the investor to the fund or fund management company when subscribing.
    /// Encoded/decoded by serializers as "FEND".
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_SutpZDiAEeaH-93K5JKmzw")]
    [Description(@"Fee paid by the investor to the fund or fund management company when subscribing.")]
    FrontEndLoad,
    
    /// <summary>
    /// Charge paid at the time of the first subscription.
    /// Encoded/decoded by serializers as "INIT".
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_SutpZTiAEeaH-93K5JKmzw")]
    [Description(@"Charge paid at the time of the first subscription.")]
    InitialCharge,
    
    /// <summary>
    /// In investment funds, pre-arranged addition to the trade amount based on the published net asset value.
    /// Encoded/decoded by serializers as "PREM".
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_SutpeziAEeaH-93K5JKmzw")]
    [Description(@"In investment funds, pre-arranged addition to the trade amount based on the published net asset value.")]
    Premium,
    
    /// <summary>
    /// Fee paid by the investor to a distributor/intermediary or other service provider for the provision of financial services.
    /// Encoded/decoded by serializers as "CHAR".
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_SutpgjiAEeaH-93K5JKmzw")]
    [Description(@"Fee paid by the investor to a distributor/intermediary or other service provider for the provision of financial services.")]
    ServiceProvisionFee,
    
    /// <summary>
    /// In investment funds, charge related to a switch transaction.
    /// Encoded/decoded by serializers as "SWIT".
    /// </summary>
    [EnumMember(Value = "SWIT")]
    [IsoId("_Su3aFDiAEeaH-93K5JKmzw")]
    [Description(@"In investment funds, charge related to a switch transaction.")]
    Switch,
    
    /// <summary>
    /// In investment funds, a fee charged for the transfer of ownership of an investment fund.
    /// Encoded/decoded by serializers as "TRAN".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_Su3aFTiAEeaH-93K5JKmzw")]
    [Description(@"In investment funds, a fee charged for the transfer of ownership of an investment fund.")]
    TransferFee,
    
    /// <summary>
    /// Charges paid by the investor to the fund company for subscription and redemption orders.
    /// Encoded/decoded by serializers as "UCIC".
    /// </summary>
    [EnumMember(Value = "UCIC")]
    [IsoId("_Su3aFziAEeaH-93K5JKmzw")]
    [Description(@"Charges paid by the investor to the fund company for subscription and redemption orders.")]
    UCITSCommission,
    
    /// <summary>
    /// Amount paid out by the fund to a third party.
    /// Encoded/decoded by serializers as "COMM".
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_rJJXoTiAEeaH-93K5JKmzw")]
    [Description(@"Amount paid out by the fund to a third party.")]
    Commission,
    
    /// <summary>
    /// Charge for shipping, including the insurance of securities.
    /// Encoded/decoded by serializers as "SHIP".
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_hFpc9DiBEeaH-93K5JKmzw")]
    [Description(@"Charge for shipping, including the insurance of securities.")]
    ShippingCharge,
    
    /// <summary>
    /// Charge paid for the postage.
    /// Encoded/decoded by serializers as "POST".
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_kMSdxDiBEeaH-93K5JKmzw")]
    [Description(@"Charge paid for the postage.")]
    PostageCharge,
    
    /// <summary>
    /// Amount of cash due to an intermediary for selling a product, or services, to a third party.
    /// Encoded/decoded by serializers as "CDPL".
    /// </summary>
    [EnumMember(Value = "CDPL")]
    [IsoId("_sOW2wTiBEeaH-93K5JKmzw")]
    [Description(@"Amount of cash due to an intermediary for selling a product, or services, to a third party.")]
    CommissionDePlacement,
    
    /// <summary>
    /// Additional fee not covered by another fee type.
    /// Encoded/decoded by serializers as "ADDF".
    /// </summary>
    [EnumMember(Value = "ADDF")]
    [IsoId("_De2hwDiCEeaH-93K5JKmzw")]
    [Description(@"Additional fee not covered by another fee type.")]
    AdditionalFee,
    
    /// <summary>
    /// Fee charged by a regulatory authority, for example, securities and exchange fees.
    /// Encoded/decoded by serializers as "REGF".
    /// </summary>
    [EnumMember(Value = "REGF")]
    [IsoId("_8FyIlDkoEeapUO0vUIo9Xw")]
    [Description(@"Fee charged by a regulatory authority, for example, securities and exchange fees.")]
    RegulatoryFee,
    
    /// <summary>
    /// Fee charged to the investor for early redemption of the fund.
    /// Encoded/decoded by serializers as "PENA".
    /// </summary>
    [EnumMember(Value = "PENA")]
    [IsoId("_VnICoa2aEea0Qtj9EW8okQ")]
    [Description(@"Fee charged to the investor for early redemption of the fund.")]
    Penalty,
    
    /// <summary>
    /// Fees, drawdown, or other reduction from or in addition to the deal price.
    /// Encoded/decoded by serializers as "SPCN".
    /// </summary>
    [EnumMember(Value = "SPCN")]
    [IsoId("_nL7QlK27EeerDLLe8bZJCA")]
    [Description(@"Fees, drawdown, or other reduction from or in addition to the deal price.")]
    SpecialConcessions,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestmentFundFeeCodeMetadataExtensions
{
    private static readonly InvestmentFundFeeCodeDropdownSource _dropdownSource = new InvestmentFundFeeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestmentFundFeeCodeDropdownRow GetMetadata(this InvestmentFundFeeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

