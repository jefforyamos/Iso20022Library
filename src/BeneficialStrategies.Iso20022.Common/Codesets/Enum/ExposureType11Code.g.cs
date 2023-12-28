﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExposureType11Code.  ISO2002 ID# _pPoQtiW2EeyT3chuyX0PgA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying business area/type of trade causing the collateral movement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pPoQtiW2EeyT3chuyX0PgA")]
[Description(@"Specifies the underlying business area/type of trade causing the collateral movement.")]
[DerivedFrom(typeof(ExposureTypeV3Code))]
public enum ExposureType11Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BondForward".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOBCQSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    BondForward,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashSettlement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOBCQyW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    CashSettlement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CentralBankCreditOperations".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOBCRSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    CentralBankCreditOperations,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Commodities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOBCRyW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    Commodities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CreditDefaultSwap".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOBCSSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    CreditDefaultSwap,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CreditLine".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOBCSyW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    CreditLine,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CreditSupport".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOBCTSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    CreditSupport,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CrossCurrencyIRS".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOBCTyW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    CrossCurrencyIRS,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CrossProduct".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOBCUSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    CrossProduct,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EquityOption".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOBCUyW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    EquityOption,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EquitySwap".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMMSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    EquitySwap,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExchangeTradedDerivatives".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMMyW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    ExchangeTradedDerivatives,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExoticOption".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMNSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    ExoticOption,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FixedIncome".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMNyW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    FixedIncome,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForeignExchange".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMOSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    ForeignExchange,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForwardForeignExchange".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMOyW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    ForwardForeignExchange,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Futures".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMPSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    Futures,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FXOption".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMPyW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    FXOption,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Liquidity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMQSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    Liquidity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OTCDerivatives".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMQyW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    OTCDerivatives,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReverseRepurchaseAgreement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMRSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    ReverseRepurchaseAgreement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecuredLoan".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMRyW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    SecuredLoan,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecuritiesBuySellSellBuyBack".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMSSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    SecuritiesBuySellSellBuyBack,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecuritiesCrossProducts".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMSyW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    SecuritiesCrossProducts,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecuritiesLendingAndBorrowing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMTSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    SecuritiesLendingAndBorrowing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SingleCurrencyIRS".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMTyW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    SingleCurrencyIRS,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SingleCurrencyIRSExotic".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMUSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    SingleCurrencyIRSExotic,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Swaption".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMUyW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    Swaption,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ToBeAnnounced".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMVSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    ToBeAnnounced,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TreasuryCrossProduct".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMVyW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    TreasuryCrossProduct,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UnclearedDerivativeMarginSegregation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMWSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    UnclearedDerivativeMarginSegregation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CCPCollateral".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMWyW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    CCPCollateral,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Equity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMXSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    Equity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TreasuryBonds".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EOKMXyW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    TreasuryBonds,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RepurchaseAgreement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_F9e0wSW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    RepurchaseAgreement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ShortSell".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GbIaESW6Eey0ysS9q2PBJA")]
    [Description(@"??")]
    ShortSell,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExposureType11CodeMetadataExtensions
{
    private static readonly ExposureType11CodeDropdownSource _dropdownSource = new ExposureType11CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExposureType11CodeDropdownRow GetMetadata(this ExposureType11Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

