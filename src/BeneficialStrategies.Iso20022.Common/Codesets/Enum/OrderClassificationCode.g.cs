﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OrderClassificationCode.  ISO2002 ID# _aQk199p-Ed-ak6NoX_4Aeg_336257331.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the classification and thus the restrictions associated with an order (for regulatory purposes).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aQk199p-Ed-ak6NoX_4Aeg_336257331")]
[Description(@"Identifies the classification and thus the restrictions associated with an order (for regulatory purposes).")]
[Derivations(typeof(OrderRestrictions1Code))]
public enum OrderClassificationCode
{
    /// <summary>
    /// Purchase or sale of a large number of stocks. Originally called program trading when index funds and other institutional|investors began to embark on large-scale buying and selling campaigns or programs to replicate a target stock index. The|term includes computer aided stock market buying or selling programs, portfolio insurance and index arbitrage.
    /// Encoded/decoded by serializers as "PROG".
    /// </summary>
    [EnumMember(Value = "PROG")]
    [IsoId("_aQum8Np-Ed-ak6NoX_4Aeg_336257332")]
    [Description(@"Purchase or sale of a large number of stocks. Originally called program trading when index funds and other institutional|investors began to embark on large-scale buying and selling campaigns or programs to replicate a target stock index. The|term includes computer aided stock market buying or selling programs, portfolio insurance and index arbitrage.")]
    ProgramTrade,
    
    /// <summary>
    /// Program trade on a stock index. Simultaneous purchase and sale of an index future and the index underlying securities to|profit from intermarket spreads between the future and the index itself.
    /// Encoded/decoded by serializers as "ARBT".
    /// </summary>
    [EnumMember(Value = "ARBT")]
    [IsoId("_aQum8dp-Ed-ak6NoX_4Aeg_336257333")]
    [Description(@"Program trade on a stock index. Simultaneous purchase and sale of an index future and the index underlying securities to|profit from intermarket spreads between the future and the index itself.")]
    IndexArbitrage,
    
    /// <summary>
    /// Simultaneous purchase and sale of a large number of securities to profit from intermarket spreads between financial|instruments that do not include stock indexes.
    /// Encoded/decoded by serializers as "NARB".
    /// </summary>
    [EnumMember(Value = "NARB")]
    [IsoId("_aQum8tp-Ed-ak6NoX_4Aeg_336257341")]
    [Description(@"Simultaneous purchase and sale of a large number of securities to profit from intermarket spreads between financial|instruments that do not include stock indexes.")]
    NonIndexArbitrage,
    
    /// <summary>
    /// Specialist or market maker registered as such on a registered stock exchange, or a market maker bidding and offering over-the-counter.
    /// Encoded/decoded by serializers as "CMAR".
    /// </summary>
    [EnumMember(Value = "CMAR")]
    [IsoId("_aQum89p-Ed-ak6NoX_4Aeg_336257342")]
    [Description(@"Specialist or market maker registered as such on a registered stock exchange, or a market maker bidding and offering over-the-counter.")]
    CompetingMarketMaker,
    
    /// <summary>
    /// Specialist or market maker registered as such on a registered stock exchange, or a market maker acting based on a set of|rules applicable to a defined security.
    /// Encoded/decoded by serializers as "SSPE".
    /// </summary>
    [EnumMember(Value = "SSPE")]
    [IsoId("_aQum9Np-Ed-ak6NoX_4Aeg_336257343")]
    [Description(@"Specialist or market maker registered as such on a registered stock exchange, or a market maker acting based on a set of|rules applicable to a defined security.")]
    SpecialistInSecurity,
    
    /// <summary>
    /// Specialist or market maker registered as such on a registered stock exchange, or a market maker acting based on a set of|rules applicable to a defined underlying security of a derivative product.
    /// Encoded/decoded by serializers as "USPE".
    /// </summary>
    [EnumMember(Value = "USPE")]
    [IsoId("_aQum9dp-Ed-ak6NoX_4Aeg_336257344")]
    [Description(@"Specialist or market maker registered as such on a registered stock exchange, or a market maker acting based on a set of|rules applicable to a defined underlying security of a derivative product.")]
    SpecialistInUnderlyingSecurity,
    
    /// <summary>
    /// Non domestic business entity, foreign government or regulatory jurisdiction.
    /// Encoded/decoded by serializers as "FORE".
    /// </summary>
    [EnumMember(Value = "FORE")]
    [IsoId("_aQum9tp-Ed-ak6NoX_4Aeg_336257345")]
    [Description(@"Non domestic business entity, foreign government or regulatory jurisdiction.")]
    ForeignEntity,
    
    /// <summary>
    /// Participating entity not registered on an exchange.
    /// Encoded/decoded by serializers as "EXMA".
    /// </summary>
    [EnumMember(Value = "EXMA")]
    [IsoId("_aQum99p-Ed-ak6NoX_4Aeg_336257346")]
    [Description(@"Participating entity not registered on an exchange.")]
    ExternalMarketParticipant,
    
    /// <summary>
    /// Participating entity linked but not registered on an exchange.
    /// Encoded/decoded by serializers as "MALI".
    /// </summary>
    [EnumMember(Value = "MALI")]
    [IsoId("_aQum-Np-Ed-ak6NoX_4Aeg_336257572")]
    [Description(@"Participating entity linked but not registered on an exchange.")]
    ExternalInterConnectedMarketLinkage,
    
    /// <summary>
    /// Risk-free transaction consisting of purchasing an asset at one price and simultaneously selling that same asset at a higher|price, generating a profit on the difference.
    /// Encoded/decoded by serializers as "RARB".
    /// </summary>
    [EnumMember(Value = "RARB")]
    [IsoId("_aQum-dp-Ed-ak6NoX_4Aeg_336257573")]
    [Description(@"Risk-free transaction consisting of purchasing an asset at one price and simultaneously selling that same asset at a higher|price, generating a profit on the difference.")]
    RisklessArbitrage,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OrderClassificationCodeMetadataExtensions
{
    private static readonly OrderClassificationCodeDropdownSource _dropdownSource = new OrderClassificationCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOrderClassificationCodeDropdownRow GetMetadata(this OrderClassificationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


