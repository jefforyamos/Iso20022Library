﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestmentFundRole5Code.  ISO2002 ID# _WOC0p9p-Ed-ak6NoX_4Aeg_-878907454.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role played by an actor in an investment fund transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WOC0p9p-Ed-ak6NoX_4Aeg_-878907454")]
[Description(@"Specifies the role played by an actor in an investment fund transaction.")]
[DerivedFrom(typeof(PartyRoleCode))]
public enum InvestmentFundRole5Code
{
    /// <summary>
    /// Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution.
    /// Encoded/decoded by serializers as "TransferAgent".
    /// </summary>
    [EnumMember(Value = "TRAG")]
    [IsoId("_WOMloNp-Ed-ak6NoX_4Aeg_-878907424")]
    [Description(@"Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution.")]
    TransferAgent,
    
    /// <summary>
    /// Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor.
    /// Encoded/decoded by serializers as "Intermediary".
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_WOMlodp-Ed-ak6NoX_4Aeg_-878907423")]
    [Description(@"Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor.")]
    Intermediary,
    
    /// <summary>
    /// Party that act as an wholesaler of funds.
    /// Encoded/decoded by serializers as "Distributor".
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_WOMlotp-Ed-ak6NoX_4Aeg_1633754476")]
    [Description(@"Party that act as an wholesaler of funds.")]
    Distributor,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestmentFundRole5CodeMetadataExtensions
{
    private static readonly InvestmentFundRole5CodeDropdownSource _dropdownSource = new InvestmentFundRole5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestmentFundRole5CodeDropdownRow GetMetadata(this InvestmentFundRole5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


