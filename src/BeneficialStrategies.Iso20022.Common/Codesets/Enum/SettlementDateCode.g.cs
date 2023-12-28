﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementDateCode.  ISO2002 ID# _ZLby19p-Ed-ak6NoX_4Aeg_336259131.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the date of settlement, in coded form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZLby19p-Ed-ak6NoX_4Aeg_336259131")]
[Description(@"Specifies the date of settlement, in coded form.")]
public enum SettlementDateCode
{
    /// <summary>
    /// Settlement takes place under the standard rules applicable to the market and instrument.
    /// Encoded/decoded by serializers as "REGU".
    /// </summary>
    [EnumMember(Value = "REGU")]
    [IsoId("_ZLlj0Np-Ed-ak6NoX_4Aeg_336259139")]
    [Description(@"Settlement takes place under the standard rules applicable to the market and instrument.")]
    Regular,
    
    /// <summary>
    /// Settlement takes place on the trade date.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZLlj0dp-Ed-ak6NoX_4Aeg_336259140")]
    [Description(@"Settlement takes place on the trade date.")]
    Cash,
    
    /// <summary>
    /// Settlement takes place on the day after trade date.
    /// Encoded/decoded by serializers as "NXTD".
    /// </summary>
    [EnumMember(Value = "NXTD")]
    [IsoId("_ZLlj0tp-Ed-ak6NoX_4Aeg_336259142")]
    [Description(@"Settlement takes place on the day after trade date.")]
    NextDay,
    
    /// <summary>
    /// Settlement takes place on the trade date plus one business day.
    /// Encoded/decoded by serializers as "TONE".
    /// </summary>
    [EnumMember(Value = "TONE")]
    [IsoId("_ZLlj09p-Ed-ak6NoX_4Aeg_336259143")]
    [Description(@"Settlement takes place on the trade date plus one business day.")]
    TPlusOne,
    
    /// <summary>
    /// Settlement takes place on the trade date plus two business days.
    /// Encoded/decoded by serializers as "TTWO".
    /// </summary>
    [EnumMember(Value = "TTWO")]
    [IsoId("_ZLlj1Np-Ed-ak6NoX_4Aeg_336259144")]
    [Description(@"Settlement takes place on the trade date plus two business days.")]
    TPlusTwo,
    
    /// <summary>
    /// Settlement takes place on the trade date plus three business days.
    /// Encoded/decoded by serializers as "TTRE".
    /// </summary>
    [EnumMember(Value = "TTRE")]
    [IsoId("_ZLlj1dp-Ed-ak6NoX_4Aeg_336259153")]
    [Description(@"Settlement takes place on the trade date plus three business days.")]
    TPlusThree,
    
    /// <summary>
    /// Settlement takes place on the trade date plus four business days.
    /// Encoded/decoded by serializers as "TFOR".
    /// </summary>
    [EnumMember(Value = "TFOR")]
    [IsoId("_ZLlj1tp-Ed-ak6NoX_4Aeg_336259154")]
    [Description(@"Settlement takes place on the trade date plus four business days.")]
    TPlusFour,
    
    /// <summary>
    /// Settlement takes place on the trade date plus five business days.
    /// Encoded/decoded by serializers as "TFIV".
    /// </summary>
    [EnumMember(Value = "TFIV")]
    [IsoId("_ZLlj19p-Ed-ak6NoX_4Aeg_336259155")]
    [Description(@"Settlement takes place on the trade date plus five business days.")]
    TPlusFive,
    
    /// <summary>
    /// Settlement takes place at the choice/option of the seller.
    /// Encoded/decoded by serializers as "SELL".
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_ZLlj2Np-Ed-ak6NoX_4Aeg_336259156")]
    [Description(@"Settlement takes place at the choice/option of the seller.")]
    SellersOption,
    
    /// <summary>
    /// Settlement takes place on the trade date plus six or more business days.
    /// Encoded/decoded by serializers as "FUTU".
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_ZLlj2dp-Ed-ak6NoX_4Aeg_336259157")]
    [Description(@"Settlement takes place on the trade date plus six or more business days.")]
    Future,
    
    /// <summary>
    /// Transfer is to be effected as soon as possible.
    /// Encoded/decoded by serializers as "ASAP".
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_ZLlj2tp-Ed-ak6NoX_4Aeg_581713024")]
    [Description(@"Transfer is to be effected as soon as possible.")]
    AsSoonAsPossible,
    
    /// <summary>
    /// Transfer is to be effected at the end of the contract.
    /// Encoded/decoded by serializers as "ENDC".
    /// </summary>
    [EnumMember(Value = "ENDC")]
    [IsoId("_ZLvU0Np-Ed-ak6NoX_4Aeg_581713025")]
    [Description(@"Transfer is to be effected at the end of the contract.")]
    AtEndOfContract,
    
    /// <summary>
    /// Settlement takes place when the financial instrument is issued by the issuer.
    /// Encoded/decoded by serializers as "WHIF".
    /// </summary>
    [EnumMember(Value = "WHIF")]
    [IsoId("_ZLvU0dp-Ed-ak6NoX_4Aeg_321193071")]
    [Description(@"Settlement takes place when the financial instrument is issued by the issuer.")]
    WhenAndIfIssued,
    
    /// <summary>
    /// Settlement takes place when the financial instrument is distributed.
    /// Encoded/decoded by serializers as "WDIS".
    /// </summary>
    [EnumMember(Value = "WDIS")]
    [IsoId("_ZLvU0tp-Ed-ak6NoX_4Aeg_321193349")]
    [Description(@"Settlement takes place when the financial instrument is distributed.")]
    WhenDistributed,
    
    /// <summary>
    /// Settlement takes place when the financial instrument is issued or distributed.
    /// Encoded/decoded by serializers as "WHID".
    /// </summary>
    [EnumMember(Value = "WHID")]
    [IsoId("_ZLvU09p-Ed-ak6NoX_4Aeg_321193391")]
    [Description(@"Settlement takes place when the financial instrument is issued or distributed.")]
    WhenIssuedOrDistributed,
    
    /// <summary>
    /// Settlement takes place as a result of a "to be announced" trade.
    /// Encoded/decoded by serializers as "TBAT".
    /// </summary>
    [EnumMember(Value = "TBAT")]
    [IsoId("_ZLvU1Np-Ed-ak6NoX_4Aeg_321193444")]
    [Description(@"Settlement takes place as a result of a ""to be announced"" trade.")]
    ToBeAnnouncedTrade,
    
    /// <summary>
    /// Settlement takes place at the end of the month.
    /// Encoded/decoded by serializers as "MONT".
    /// </summary>
    [EnumMember(Value = "MONT")]
    [IsoId("_ZLvU1dp-Ed-ak6NoX_4Aeg_321193504")]
    [Description(@"Settlement takes place at the end of the month.")]
    EndOfMonth,
    
    /// <summary>
    /// Cash settlement takes place before trade date.
    /// Encoded/decoded by serializers as "CLEA".
    /// </summary>
    [EnumMember(Value = "CLEA")]
    [IsoId("_ZLvU1tp-Ed-ak6NoX_4Aeg_392642567")]
    [Description(@"Cash settlement takes place before trade date.")]
    Cleared,
    
    /// <summary>
    /// Money is withdrawn automatically from the savings plan.
    /// Encoded/decoded by serializers as "SAVE".
    /// </summary>
    [EnumMember(Value = "SAVE")]
    [IsoId("_ZLvU19p-Ed-ak6NoX_4Aeg_392642584")]
    [Description(@"Money is withdrawn automatically from the savings plan.")]
    SavingsPlan,
    
    /// <summary>
    /// Settlement is to be done when the security is issued.
    /// Encoded/decoded by serializers as "WISS".
    /// </summary>
    [EnumMember(Value = "WISS")]
    [IsoId("_ZLvU2Np-Ed-ak6NoX_4Aeg_-1554460647")]
    [Description(@"Settlement is to be done when the security is issued.")]
    WhenIssued,
    
    /// <summary>
    /// Event occurs on the same day or at time T.
    /// Encoded/decoded by serializers as "SAMD".
    /// </summary>
    [EnumMember(Value = "SAMD")]
    [IsoId("_glq90LbwEeaqL_M7XFD7PQ")]
    [Description(@"Event occurs on the same day or at time T.")]
    SameDay,
    
    /// <summary>
    /// Event occurs on the previous day.
    /// Encoded/decoded by serializers as "PRVD".
    /// </summary>
    [EnumMember(Value = "PRVD")]
    [IsoId("_dnAzIOobEeadseq5W5YLvQ")]
    [Description(@"Event occurs on the previous day.")]
    PreviousDay,
    
    /// <summary>
    /// Any other settlement date.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_I5zl8CkjEemdy87C5UYJ0g")]
    [Description(@"Any other settlement date.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettlementDateCodeMetadataExtensions
{
    private static readonly SettlementDateCodeDropdownSource _dropdownSource = new SettlementDateCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettlementDateCodeDropdownRow GetMetadata(this SettlementDateCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


