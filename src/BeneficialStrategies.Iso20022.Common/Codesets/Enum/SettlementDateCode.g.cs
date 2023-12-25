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
    /// </summary>
    [EnumMember(Value = "REGU")]
    [IsoId("_ZLlj0Np-Ed-ak6NoX_4Aeg_336259139")]
    [Description(@"Settlement takes place under the standard rules applicable to the market and instrument.")]
    REGU,
    
    /// <summary>
    /// Settlement takes place on the trade date.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZLlj0dp-Ed-ak6NoX_4Aeg_336259140")]
    [Description(@"Settlement takes place on the trade date.")]
    CASH,
    
    /// <summary>
    /// Settlement takes place on the day after trade date.
    /// </summary>
    [EnumMember(Value = "NXTD")]
    [IsoId("_ZLlj0tp-Ed-ak6NoX_4Aeg_336259142")]
    [Description(@"Settlement takes place on the day after trade date.")]
    NXTD,
    
    /// <summary>
    /// Settlement takes place on the trade date plus one business day.
    /// </summary>
    [EnumMember(Value = "TONE")]
    [IsoId("_ZLlj09p-Ed-ak6NoX_4Aeg_336259143")]
    [Description(@"Settlement takes place on the trade date plus one business day.")]
    TONE,
    
    /// <summary>
    /// Settlement takes place on the trade date plus two business days.
    /// </summary>
    [EnumMember(Value = "TTWO")]
    [IsoId("_ZLlj1Np-Ed-ak6NoX_4Aeg_336259144")]
    [Description(@"Settlement takes place on the trade date plus two business days.")]
    TTWO,
    
    /// <summary>
    /// Settlement takes place on the trade date plus three business days.
    /// </summary>
    [EnumMember(Value = "TTRE")]
    [IsoId("_ZLlj1dp-Ed-ak6NoX_4Aeg_336259153")]
    [Description(@"Settlement takes place on the trade date plus three business days.")]
    TTRE,
    
    /// <summary>
    /// Settlement takes place on the trade date plus four business days.
    /// </summary>
    [EnumMember(Value = "TFOR")]
    [IsoId("_ZLlj1tp-Ed-ak6NoX_4Aeg_336259154")]
    [Description(@"Settlement takes place on the trade date plus four business days.")]
    TFOR,
    
    /// <summary>
    /// Settlement takes place on the trade date plus five business days.
    /// </summary>
    [EnumMember(Value = "TFIV")]
    [IsoId("_ZLlj19p-Ed-ak6NoX_4Aeg_336259155")]
    [Description(@"Settlement takes place on the trade date plus five business days.")]
    TFIV,
    
    /// <summary>
    /// Settlement takes place at the choice/option of the seller.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_ZLlj2Np-Ed-ak6NoX_4Aeg_336259156")]
    [Description(@"Settlement takes place at the choice/option of the seller.")]
    SELL,
    
    /// <summary>
    /// Settlement takes place on the trade date plus six or more business days.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_ZLlj2dp-Ed-ak6NoX_4Aeg_336259157")]
    [Description(@"Settlement takes place on the trade date plus six or more business days.")]
    FUTU,
    
    /// <summary>
    /// Transfer is to be effected as soon as possible.
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_ZLlj2tp-Ed-ak6NoX_4Aeg_581713024")]
    [Description(@"Transfer is to be effected as soon as possible.")]
    ASAP,
    
    /// <summary>
    /// Transfer is to be effected at the end of the contract.
    /// </summary>
    [EnumMember(Value = "ENDC")]
    [IsoId("_ZLvU0Np-Ed-ak6NoX_4Aeg_581713025")]
    [Description(@"Transfer is to be effected at the end of the contract.")]
    ENDC,
    
    /// <summary>
    /// Settlement takes place when the financial instrument is issued by the issuer.
    /// </summary>
    [EnumMember(Value = "WHIF")]
    [IsoId("_ZLvU0dp-Ed-ak6NoX_4Aeg_321193071")]
    [Description(@"Settlement takes place when the financial instrument is issued by the issuer.")]
    WHIF,
    
    /// <summary>
    /// Settlement takes place when the financial instrument is distributed.
    /// </summary>
    [EnumMember(Value = "WDIS")]
    [IsoId("_ZLvU0tp-Ed-ak6NoX_4Aeg_321193349")]
    [Description(@"Settlement takes place when the financial instrument is distributed.")]
    WDIS,
    
    /// <summary>
    /// Settlement takes place when the financial instrument is issued or distributed.
    /// </summary>
    [EnumMember(Value = "WHID")]
    [IsoId("_ZLvU09p-Ed-ak6NoX_4Aeg_321193391")]
    [Description(@"Settlement takes place when the financial instrument is issued or distributed.")]
    WHID,
    
    /// <summary>
    /// Settlement takes place as a result of a "to be announced" trade.
    /// </summary>
    [EnumMember(Value = "TBAT")]
    [IsoId("_ZLvU1Np-Ed-ak6NoX_4Aeg_321193444")]
    [Description(@"Settlement takes place as a result of a ""to be announced"" trade.")]
    TBAT,
    
    /// <summary>
    /// Settlement takes place at the end of the month.
    /// </summary>
    [EnumMember(Value = "MONT")]
    [IsoId("_ZLvU1dp-Ed-ak6NoX_4Aeg_321193504")]
    [Description(@"Settlement takes place at the end of the month.")]
    MONT,
    
    /// <summary>
    /// Cash settlement takes place before trade date.
    /// </summary>
    [EnumMember(Value = "CLEA")]
    [IsoId("_ZLvU1tp-Ed-ak6NoX_4Aeg_392642567")]
    [Description(@"Cash settlement takes place before trade date.")]
    CLEA,
    
    /// <summary>
    /// Money is withdrawn automatically from the savings plan.
    /// </summary>
    [EnumMember(Value = "SAVE")]
    [IsoId("_ZLvU19p-Ed-ak6NoX_4Aeg_392642584")]
    [Description(@"Money is withdrawn automatically from the savings plan.")]
    SAVE,
    
    /// <summary>
    /// Settlement is to be done when the security is issued.
    /// </summary>
    [EnumMember(Value = "WISS")]
    [IsoId("_ZLvU2Np-Ed-ak6NoX_4Aeg_-1554460647")]
    [Description(@"Settlement is to be done when the security is issued.")]
    WISS,
    
    /// <summary>
    /// Event occurs on the same day or at time T.
    /// </summary>
    [EnumMember(Value = "SAMD")]
    [IsoId("_glq90LbwEeaqL_M7XFD7PQ")]
    [Description(@"Event occurs on the same day or at time T.")]
    SAMD,
    
    /// <summary>
    /// Event occurs on the previous day.
    /// </summary>
    [EnumMember(Value = "PRVD")]
    [IsoId("_dnAzIOobEeadseq5W5YLvQ")]
    [Description(@"Event occurs on the previous day.")]
    PRVD,
    
    /// <summary>
    /// Any other settlement date.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_I5zl8CkjEemdy87C5UYJ0g")]
    [Description(@"Any other settlement date.")]
    OTHR,
    
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


