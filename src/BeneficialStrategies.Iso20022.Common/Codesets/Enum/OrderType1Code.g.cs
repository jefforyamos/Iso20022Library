﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OrderType1Code.  ISO2002 ID# _aS0Rpdp-Ed-ak6NoX_4Aeg_-2117834119.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the type of instruction to a broker or dealer to buy or sell a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aS0Rpdp-Ed-ak6NoX_4Aeg_-2117834119")]
[Description(@"Indicates the type of instruction to a broker or dealer to buy or sell a financial instrument.")]
[DerivedFrom(typeof(OrderTypeCode))]
public enum OrderType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AllOrNone".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aS0Rptp-Ed-ak6NoX_4Aeg_-152464306")]
    [Description(@"??")]
    AllOrNone,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BuyContraShortExempt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aS0Rp9p-Ed-ak6NoX_4Aeg_135408026")]
    [Description(@"??")]
    BuyContraShortExempt,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BuyContraShort".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aS0RqNp-Ed-ak6NoX_4Aeg_159420439")]
    [Description(@"??")]
    BuyContraShort,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BuyMinus".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aS9bkNp-Ed-ak6NoX_4Aeg_173273332")]
    [Description(@"??")]
    BuyMinus,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Carefully".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aS9bkdp-Ed-ak6NoX_4Aeg_-109983318")]
    [Description(@"??")]
    Carefully,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Combination".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aS9bktp-Ed-ak6NoX_4Aeg_-1259109163")]
    [Description(@"??")]
    Combination,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Discretionary".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aS9bk9p-Ed-ak6NoX_4Aeg_1432954067")]
    [Description(@"??")]
    Discretionary,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Limit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aS9blNp-Ed-ak6NoX_4Aeg_-2085508947")]
    [Description(@"??")]
    Limit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LimitWith".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aS9bldp-Ed-ak6NoX_4Aeg_13651342")]
    [Description(@"??")]
    LimitWith,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LimitWithout".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aS9bltp-Ed-ak6NoX_4Aeg_645342047")]
    [Description(@"??")]
    LimitWithout,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Market".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aS9bl9p-Ed-ak6NoX_4Aeg_-2090127772")]
    [Description(@"??")]
    Market,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketNotHeld".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aS9bmNp-Ed-ak6NoX_4Aeg_1508619597")]
    [Description(@"??")]
    MarketNotHeld,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketTouched".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aS9bmdp-Ed-ak6NoX_4Aeg_1394103999")]
    [Description(@"??")]
    MarketTouched,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotHeld".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aS9bmtp-Ed-ak6NoX_4Aeg_1795836797")]
    [Description(@"??")]
    NotHeld,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OrderLie".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aTHMkNp-Ed-ak6NoX_4Aeg_1878030194")]
    [Description(@"??")]
    OrderLie,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OnBasisPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aTHMkdp-Ed-ak6NoX_4Aeg_1602766946")]
    [Description(@"??")]
    OnBasisPrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Stop".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aTHMktp-Ed-ak6NoX_4Aeg_-2074426913")]
    [Description(@"??")]
    Stop,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StopLimit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aTHMk9p-Ed-ak6NoX_4Aeg_-2060575959")]
    [Description(@"??")]
    StopLimit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StopLoss".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aTHMlNp-Ed-ak6NoX_4Aeg_530675618")]
    [Description(@"??")]
    StopLoss,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SellPlus".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aTHMldp-Ed-ak6NoX_4Aeg_557457295")]
    [Description(@"??")]
    SellPlus,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SellShort".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aTHMltp-Ed-ak6NoX_4Aeg_575928489")]
    [Description(@"??")]
    SellShort,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SellShortExempt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aTHMl9p-Ed-ak6NoX_4Aeg_563919866")]
    [Description(@"??")]
    SellShortExempt,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WithOrWithout".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aTHMmNp-Ed-ak6NoX_4Aeg_370947495")]
    [Description(@"??")]
    WithOrWithout,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreviouslyQuoted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aTHMmdp-Ed-ak6NoX_4Aeg_370947710")]
    [Description(@"??")]
    PreviouslyQuoted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreviouslyIndicated".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aTQ9kNp-Ed-ak6NoX_4Aeg_371868072")]
    [Description(@"??")]
    PreviouslyIndicated,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForexSwap".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aTQ9kdp-Ed-ak6NoX_4Aeg_371868227")]
    [Description(@"??")]
    ForexSwap,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Funari".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aTQ9ktp-Ed-ak6NoX_4Aeg_371868599")]
    [Description(@"??")]
    Funari,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketWithLeftover".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aTQ9k9p-Ed-ak6NoX_4Aeg_371870519")]
    [Description(@"??")]
    MarketWithLeftover,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Pegged".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aTQ9lNp-Ed-ak6NoX_4Aeg_371871605")]
    [Description(@"??")]
    Pegged,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CounterOrderSelection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aTQ9ldp-Ed-ak6NoX_4Aeg_-929676213")]
    [Description(@"??")]
    CounterOrderSelection,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OrderType1CodeMetadataExtensions
{
    private static readonly OrderType1CodeDropdownSource _dropdownSource = new OrderType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOrderType1CodeDropdownRow GetMetadata(this OrderType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

