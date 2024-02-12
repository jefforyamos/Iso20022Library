﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementDate2Code.  ISO2002 ID# _ZLI34dp-Ed-ak6NoX_4Aeg_1141279698.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the date of settlement in coded form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZLI34dp-Ed-ak6NoX_4Aeg_1141279698")]
[Description(@"Indicates the date of settlement in coded form.")]
[DerivedFrom(typeof(SettlementDateCode))]
public enum SettlementDate2Code
{
    /// <summary>
    /// Settlement takes place under the standard rules applicable to the market and instrument.
    /// Encoded/decoded by serializers as "REGU".
    /// </summary>
    [EnumMember(Value = "REGU")]
    [IsoId("_ZLI34tp-Ed-ak6NoX_4Aeg_1279807839")]
    [Description(@"Settlement takes place under the standard rules applicable to the market and instrument.")]
    Regular = SettlementDateCode.Regular, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the trade date.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZLI349p-Ed-ak6NoX_4Aeg_1309359964")]
    [Description(@"Settlement takes place on the trade date.")]
    Cash = SettlementDateCode.Cash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the day after trade date.
    /// Encoded/decoded by serializers as "NXTD".
    /// </summary>
    [EnumMember(Value = "NXTD")]
    [IsoId("_ZLI35Np-Ed-ak6NoX_4Aeg_1313055335")]
    [Description(@"Settlement takes place on the day after trade date.")]
    NextDay = SettlementDateCode.NextDay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the trade date plus one business day.
    /// Encoded/decoded by serializers as "TONE".
    /// </summary>
    [EnumMember(Value = "TONE")]
    [IsoId("_ZLI35dp-Ed-ak6NoX_4Aeg_1322291660")]
    [Description(@"Settlement takes place on the trade date plus one business day.")]
    TPlusOne = SettlementDateCode.TPlusOne, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the trade date plus two business days.
    /// Encoded/decoded by serializers as "TTWO".
    /// </summary>
    [EnumMember(Value = "TTWO")]
    [IsoId("_ZLI35tp-Ed-ak6NoX_4Aeg_1371237173")]
    [Description(@"Settlement takes place on the trade date plus two business days.")]
    TPlusTwo = SettlementDateCode.TPlusTwo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the trade date plus three business days.
    /// Encoded/decoded by serializers as "TTRE".
    /// </summary>
    [EnumMember(Value = "TTRE")]
    [IsoId("_ZLI359p-Ed-ak6NoX_4Aeg_1384166063")]
    [Description(@"Settlement takes place on the trade date plus three business days.")]
    TPlusThree = SettlementDateCode.TPlusThree, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the trade date plus four business days.
    /// Encoded/decoded by serializers as "TFOR".
    /// </summary>
    [EnumMember(Value = "TFOR")]
    [IsoId("_ZLI36Np-Ed-ak6NoX_4Aeg_1597497895")]
    [Description(@"Settlement takes place on the trade date plus four business days.")]
    TPlusFour = SettlementDateCode.TPlusFour, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the trade date plus five business days.
    /// Encoded/decoded by serializers as "TFIV".
    /// </summary>
    [EnumMember(Value = "TFIV")]
    [IsoId("_ZLI36dp-Ed-ak6NoX_4Aeg_1609504771")]
    [Description(@"Settlement takes place on the trade date plus five business days.")]
    TPlusFive = SettlementDateCode.TPlusFive, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place at the choice/option of the seller.
    /// Encoded/decoded by serializers as "SELL".
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_ZLSo4Np-Ed-ak6NoX_4Aeg_1625207043")]
    [Description(@"Settlement takes place at the choice/option of the seller.")]
    SellersOption = SettlementDateCode.SellersOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the trade date plus six or more business days.
    /// Encoded/decoded by serializers as "FUTU".
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_ZLSo4dp-Ed-ak6NoX_4Aeg_1638134322")]
    [Description(@"Settlement takes place on the trade date plus six or more business days.")]
    Future = SettlementDateCode.Future, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer is to be effected as soon as possible.
    /// Encoded/decoded by serializers as "ASAP".
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_ZLSo4tp-Ed-ak6NoX_4Aeg_1651989075")]
    [Description(@"Transfer is to be effected as soon as possible.")]
    AsSoonAsPossible = SettlementDateCode.AsSoonAsPossible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer is to be effected at the end of the contract.
    /// Encoded/decoded by serializers as "ENDC".
    /// </summary>
    [EnumMember(Value = "ENDC")]
    [IsoId("_ZLSo49p-Ed-ak6NoX_4Aeg_1666763553")]
    [Description(@"Transfer is to be effected at the end of the contract.")]
    AtEndOfContract = SettlementDateCode.AtEndOfContract, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place when the financial instrument is issued by the issuer.
    /// Encoded/decoded by serializers as "WHIF".
    /// </summary>
    [EnumMember(Value = "WHIF")]
    [IsoId("_ZLSo5Np-Ed-ak6NoX_4Aeg_1681541811")]
    [Description(@"Settlement takes place when the financial instrument is issued by the issuer.")]
    WhenAndIfIssued = SettlementDateCode.WhenAndIfIssued, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place when the financial instrument is distributed.
    /// Encoded/decoded by serializers as "WDIS".
    /// </summary>
    [EnumMember(Value = "WDIS")]
    [IsoId("_ZLSo5dp-Ed-ak6NoX_4Aeg_1694470501")]
    [Description(@"Settlement takes place when the financial instrument is distributed.")]
    WhenDistributed = SettlementDateCode.WhenDistributed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place when the financial instrument is issued or distributed.
    /// Encoded/decoded by serializers as "WHID".
    /// </summary>
    [EnumMember(Value = "WHID")]
    [IsoId("_ZLSo5tp-Ed-ak6NoX_4Aeg_1712016132")]
    [Description(@"Settlement takes place when the financial instrument is issued or distributed.")]
    WhenIssuedOrDistributed = SettlementDateCode.WhenIssuedOrDistributed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place as a result of a "to be announced" trade.
    /// Encoded/decoded by serializers as "TBAT".
    /// </summary>
    [EnumMember(Value = "TBAT")]
    [IsoId("_ZLSo59p-Ed-ak6NoX_4Aeg_1727715906")]
    [Description(@"Settlement takes place as a result of a ""to be announced"" trade.")]
    ToBeAnnouncedTrade = SettlementDateCode.ToBeAnnouncedTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place at the end of the month.
    /// Encoded/decoded by serializers as "MONT".
    /// </summary>
    [EnumMember(Value = "MONT")]
    [IsoId("_ZLSo6Np-Ed-ak6NoX_4Aeg_1751726432")]
    [Description(@"Settlement takes place at the end of the month.")]
    EndOfMonth = SettlementDateCode.EndOfMonth, // same ordinal as derivation source for type conversions
    
}
