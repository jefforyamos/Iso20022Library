﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CashClearingSystem1Code.  ISO2002 ID# _a3xY1tp-Ed-ak6NoX_4Aeg_1357735843.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is to be processed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a3xY1tp-Ed-ak6NoX_4Aeg_1357735843")]
[Description(@"Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is to be processed.")]
[DerivedFrom(typeof(CashClearingSystemCode))]
public enum CashClearingSystem1Code
{
    /// <summary>
    /// Scheme code for EBA Euro1/Step1.
    /// Encoded/decoded by serializers as "EBAEuro1Step1".
    /// </summary>
    [EnumMember(Value = "ABE")]
    [IsoId("_a3xY19p-Ed-ak6NoX_4Aeg_1357735860")]
    [Description(@"Scheme code for EBA Euro1/Step1.")]
    EBAEuro1Step1,
    
    /// <summary>
    /// Scheme code for AT (Austria) - Austrian RTGS (ARTIS).
    /// Encoded/decoded by serializers as "Austrian".
    /// </summary>
    [EnumMember(Value = "ART")]
    [IsoId("_a36iwNp-Ed-ak6NoX_4Aeg_1357735861")]
    [Description(@"Scheme code for AT (Austria) - Austrian RTGS (ARTIS).")]
    Austrian,
    
    /// <summary>
    /// Scheme code for NZ (New Zealand) - New Zealand Assured Value Payments.
    /// Encoded/decoded by serializers as "NewZealand".
    /// </summary>
    [EnumMember(Value = "AVP")]
    [IsoId("_a36iwdp-Ed-ak6NoX_4Aeg_1357736095")]
    [Description(@"Scheme code for NZ (New Zealand) - New Zealand Assured Value Payments.")]
    NewZealand,
    
    /// <summary>
    /// Scheme code for AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).
    /// Encoded/decoded by serializers as "Azerbaijan".
    /// </summary>
    [EnumMember(Value = "AZM")]
    [IsoId("_a36iwtp-Ed-ak6NoX_4Aeg_1357736112")]
    [Description(@"Scheme code for AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).")]
    Azerbaijan,
    
    /// <summary>
    /// Scheme code for BA (Bosnia and Herzegovina).
    /// Encoded/decoded by serializers as "BosniaHerzegovina".
    /// </summary>
    [EnumMember(Value = "BAP")]
    [IsoId("_a36iw9p-Ed-ak6NoX_4Aeg_1357736121")]
    [Description(@"Scheme code for BA (Bosnia and Herzegovina).")]
    BosniaHerzegovina,
    
    /// <summary>
    /// Scheme code for BE (Belgium) - Belgium RTGS (ELLIPS).
    /// Encoded/decoded by serializers as "Belgium".
    /// </summary>
    [EnumMember(Value = "BEL")]
    [IsoId("_a36ixNp-Ed-ak6NoX_4Aeg_1357736122")]
    [Description(@"Scheme code for BE (Belgium) - Belgium RTGS (ELLIPS).")]
    Belgium,
    
    /// <summary>
    /// Scheme code for FI (Finland) - RTGS (BOF).
    /// Encoded/decoded by serializers as "Finland".
    /// </summary>
    [EnumMember(Value = "BOF")]
    [IsoId("_a36ixdp-Ed-ak6NoX_4Aeg_1357736190")]
    [Description(@"Scheme code for FI (Finland) - RTGS (BOF).")]
    Finland,
    
    /// <summary>
    /// Scheme code for IT (Italy) - Italy RTGS (BIREL).
    /// Encoded/decoded by serializers as "Italy".
    /// </summary>
    [EnumMember(Value = "BRL")]
    [IsoId("_a36ixtp-Ed-ak6NoX_4Aeg_1357736191")]
    [Description(@"Scheme code for IT (Italy) - Italy RTGS (BIREL).")]
    Italy,
    
    /// <summary>
    /// Scheme code for CA (Canada) - Canadian Large Value Transfer System (LVTS).
    /// Encoded/decoded by serializers as "Canada".
    /// </summary>
    [EnumMember(Value = "CAD")]
    [IsoId("_a36ix9p-Ed-ak6NoX_4Aeg_1357736192")]
    [Description(@"Scheme code for CA (Canada) - Canadian Large Value Transfer System (LVTS).")]
    Canada,
    
    /// <summary>
    /// Scheme code for ES (Spain).
    /// Encoded/decoded by serializers as "SpainCAM".
    /// </summary>
    [EnumMember(Value = "CAM")]
    [IsoId("_a36iyNp-Ed-ak6NoX_4Aeg_1357736215")]
    [Description(@"Scheme code for ES (Spain).")]
    SpainCAM,
    
    /// <summary>
    /// Scheme code for IE (Ireland) - Irish RTGS (IRIS).
    /// Encoded/decoded by serializers as "Ireland".
    /// </summary>
    [EnumMember(Value = "CBJ")]
    [IsoId("_a36iydp-Ed-ak6NoX_4Aeg_1357736232")]
    [Description(@"Scheme code for IE (Ireland) - Irish RTGS (IRIS).")]
    Ireland,
    
    /// <summary>
    /// Scheme code for GB (UK) - British Euro RTGS (CHAPS).
    /// Encoded/decoded by serializers as "UnitedKingdom".
    /// </summary>
    [EnumMember(Value = "CHP")]
    [IsoId("_a4ETwNp-Ed-ak6NoX_4Aeg_1357736558")]
    [Description(@"Scheme code for GB (UK) - British Euro RTGS (CHAPS).")]
    UnitedKingdom,
    
    /// <summary>
    /// Scheme code for DK (Denmark) - Danish Euro RTGS (KRONOS).
    /// Encoded/decoded by serializers as "Denmark".
    /// </summary>
    [EnumMember(Value = "DKC")]
    [IsoId("_a4ETwdp-Ed-ak6NoX_4Aeg_1357736559")]
    [Description(@"Scheme code for DK (Denmark) - Danish Euro RTGS (KRONOS).")]
    Denmark,
    
    /// <summary>
    /// Scheme code for DE (Germany).
    /// Encoded/decoded by serializers as "GermanyRTGSPlus".
    /// </summary>
    [EnumMember(Value = "RTP")]
    [IsoId("_a4ETwtp-Ed-ak6NoX_4Aeg_1357736560")]
    [Description(@"Scheme code for DE (Germany).")]
    GermanyRTGSPlus,
    
    /// <summary>
    /// Scheme code for EBA Euro1.
    /// Encoded/decoded by serializers as "EBAEuro1".
    /// </summary>
    [EnumMember(Value = "EBA")]
    [IsoId("_a4ETw9p-Ed-ak6NoX_4Aeg_1357736593")]
    [Description(@"Scheme code for EBA Euro1.")]
    EBAEuro1,
    
    /// <summary>
    /// Scheme code for DE (Germany).
    /// Encoded/decoded by serializers as "GermanyELS".
    /// </summary>
    [EnumMember(Value = "ELS")]
    [IsoId("_a4ETxNp-Ed-ak6NoX_4Aeg_1357736618")]
    [Description(@"Scheme code for DE (Germany).")]
    GermanyELS,
    
    /// <summary>
    /// Scheme code for EBA step 1 (members).
    /// Encoded/decoded by serializers as "EBAStep1".
    /// </summary>
    [EnumMember(Value = "ERP")]
    [IsoId("_a4ETxdp-Ed-ak6NoX_4Aeg_1357736619")]
    [Description(@"Scheme code for EBA step 1 (members).")]
    EBAStep1,
    
    /// <summary>
    /// Scheme code for EBA step 2.
    /// Encoded/decoded by serializers as "EBAStep2".
    /// </summary>
    [EnumMember(Value = "XCT")]
    [IsoId("_a4ETxtp-Ed-ak6NoX_4Aeg_1357736620")]
    [Description(@"Scheme code for EBA step 2.")]
    EBAStep2,
    
    /// <summary>
    /// Scheme code for HR (Croatia) - HSVP.
    /// Encoded/decoded by serializers as "Croatia".
    /// </summary>
    [EnumMember(Value = "HRK")]
    [IsoId("_a4ETx9p-Ed-ak6NoX_4Aeg_1357736621")]
    [Description(@"Scheme code for HR (Croatia) - HSVP.")]
    Croatia,
    
    /// <summary>
    /// Scheme code for GR (Greece) - Greek RTGS (HERMES).
    /// Encoded/decoded by serializers as "Greece".
    /// </summary>
    [EnumMember(Value = "HRM")]
    [IsoId("_a4ETyNp-Ed-ak6NoX_4Aeg_1357736622")]
    [Description(@"Scheme code for GR (Greece) - Greek RTGS (HERMES).")]
    Greece,
    
    /// <summary>
    /// Scheme code for HU (Hungary) - VIBER.
    /// Encoded/decoded by serializers as "Hungary".
    /// </summary>
    [EnumMember(Value = "HUF")]
    [IsoId("_a4ETydp-Ed-ak6NoX_4Aeg_1357736623")]
    [Description(@"Scheme code for HU (Hungary) - VIBER.")]
    Hungary,
    
    /// <summary>
    /// Scheme code for LU (Luxemburg) - Luxembourg RTGS (LIPS).
    /// Encoded/decoded by serializers as "Luxemburg".
    /// </summary>
    [EnumMember(Value = "LGS")]
    [IsoId("_a4OEwNp-Ed-ak6NoX_4Aeg_1357736653")]
    [Description(@"Scheme code for LU (Luxemburg) - Luxembourg RTGS (LIPS).")]
    Luxemburg,
    
    /// <summary>
    /// Scheme code for LV (Latvia).
    /// Encoded/decoded by serializers as "Latvia".
    /// </summary>
    [EnumMember(Value = "LVL")]
    [IsoId("_a4OEwdp-Ed-ak6NoX_4Aeg_1357736654")]
    [Description(@"Scheme code for LV (Latvia).")]
    Latvia,
    
    /// <summary>
    /// Scheme code for ZA (South Africa) - South-African Multiple Option Settlement.
    /// Encoded/decoded by serializers as "SouthAfrica".
    /// </summary>
    [EnumMember(Value = "MOS")]
    [IsoId("_a4OEwtp-Ed-ak6NoX_4Aeg_1357736655")]
    [Description(@"Scheme code for ZA (South Africa) - South-African Multiple Option Settlement.")]
    SouthAfrica,
    
    /// <summary>
    /// Scheme code for MU (Mauritius).
    /// Encoded/decoded by serializers as "Mauritius".
    /// </summary>
    [EnumMember(Value = "MUP")]
    [IsoId("_a4OEw9p-Ed-ak6NoX_4Aeg_1357736656")]
    [Description(@"Scheme code for MU (Mauritius).")]
    Mauritius,
    
    /// <summary>
    /// Scheme code for NO (Norway).
    /// Encoded/decoded by serializers as "Norway".
    /// </summary>
    [EnumMember(Value = "NOC")]
    [IsoId("_a4OExNp-Ed-ak6NoX_4Aeg_1357736670")]
    [Description(@"Scheme code for NO (Norway).")]
    Norway,
    
    /// <summary>
    /// Scheme code for CH (Switzerland).
    /// Encoded/decoded by serializers as "Switzerland".
    /// </summary>
    [EnumMember(Value = "PCH")]
    [IsoId("_a4OExdp-Ed-ak6NoX_4Aeg_1357736688")]
    [Description(@"Scheme code for CH (Switzerland).")]
    Switzerland,
    
    /// <summary>
    /// Scheme code for AU (Australia).
    /// Encoded/decoded by serializers as "Australia".
    /// </summary>
    [EnumMember(Value = "PDS")]
    [IsoId("_a4OExtp-Ed-ak6NoX_4Aeg_1357736696")]
    [Description(@"Scheme code for AU (Australia).")]
    Australia,
    
    /// <summary>
    /// Scheme code for EG (Egypt).
    /// Encoded/decoded by serializers as "Egypt".
    /// </summary>
    [EnumMember(Value = "PEG")]
    [IsoId("_a4OEx9p-Ed-ak6NoX_4Aeg_1357736697")]
    [Description(@"Scheme code for EG (Egypt).")]
    Egypt,
    
    /// <summary>
    /// Scheme code for FR (France).
    /// Encoded/decoded by serializers as "FrancePNS".
    /// </summary>
    [EnumMember(Value = "PNS")]
    [IsoId("_a4OEyNp-Ed-ak6NoX_4Aeg_1357736730")]
    [Description(@"Scheme code for FR (France).")]
    FrancePNS,
    
    /// <summary>
    /// Scheme code for Ve (Venezuela).
    /// Encoded/decoded by serializers as "Venezuela".
    /// </summary>
    [EnumMember(Value = "PVE")]
    [IsoId("_a4OEydp-Ed-ak6NoX_4Aeg_1357737120")]
    [Description(@"Scheme code for Ve (Venezuela).")]
    Venezuela,
    
    /// <summary>
    /// Scheme code for SE (Sweden) - Swedish Euro RTGS (SEC).
    /// Encoded/decoded by serializers as "SwedenSEC".
    /// </summary>
    [EnumMember(Value = "SEC")]
    [IsoId("_a4XOsNp-Ed-ak6NoX_4Aeg_1357737121")]
    [Description(@"Scheme code for SE (Sweden) - Swedish Euro RTGS (SEC).")]
    SwedenSEC,
    
    /// <summary>
    /// Scheme code for SI (Slovenia).
    /// Encoded/decoded by serializers as "Slovania".
    /// </summary>
    [EnumMember(Value = "SIT")]
    [IsoId("_a4XOsdp-Ed-ak6NoX_4Aeg_1357737122")]
    [Description(@"Scheme code for SI (Slovenia).")]
    Slovania,
    
    /// <summary>
    /// Scheme code for ES (Spain) - Spanish RTGS (SLBE).
    /// Encoded/decoded by serializers as "SpainES".
    /// </summary>
    [EnumMember(Value = "SLB")]
    [IsoId("_a4XOstp-Ed-ak6NoX_4Aeg_1357737130")]
    [Description(@"Scheme code for ES (Spain) - Spanish RTGS (SLBE).")]
    SpainES,
    
    /// <summary>
    /// Scheme code for PT (Portugal) - Portuguese RTGS (SPGT).
    /// Encoded/decoded by serializers as "Portugal".
    /// </summary>
    [EnumMember(Value = "SPG")]
    [IsoId("_a4XOs9p-Ed-ak6NoX_4Aeg_1357737131")]
    [Description(@"Scheme code for PT (Portugal) - Portuguese RTGS (SPGT).")]
    Portugal,
    
    /// <summary>
    /// Scheme code for SE (Sweden) - SEK RTGS (RIX).
    /// Encoded/decoded by serializers as "SwedenSSK".
    /// </summary>
    [EnumMember(Value = "SSK")]
    [IsoId("_a4XOtNp-Ed-ak6NoX_4Aeg_1357737132")]
    [Description(@"Scheme code for SE (Sweden) - SEK RTGS (RIX).")]
    SwedenSSK,
    
    /// <summary>
    /// Scheme code for FR (France) - French RTGS (TBF).
    /// Encoded/decoded by serializers as "FranceFR".
    /// </summary>
    [EnumMember(Value = "TBF")]
    [IsoId("_a4XOtdp-Ed-ak6NoX_4Aeg_1357737133")]
    [Description(@"Scheme code for FR (France) - French RTGS (TBF).")]
    FranceFR,
    
    /// <summary>
    /// Scheme code for Target.
    /// Encoded/decoded by serializers as "Target".
    /// </summary>
    [EnumMember(Value = "TGT")]
    [IsoId("_a4XOttp-Ed-ak6NoX_4Aeg_1357737162")]
    [Description(@"Scheme code for Target.")]
    Target,
    
    /// <summary>
    /// Scheme code for NL (Netherlands) - Dutch RTGS (TOP).
    /// Encoded/decoded by serializers as "Netherlands".
    /// </summary>
    [EnumMember(Value = "TOP")]
    [IsoId("_a4XOt9p-Ed-ak6NoX_4Aeg_1357737163")]
    [Description(@"Scheme code for NL (Netherlands) - Dutch RTGS (TOP).")]
    Netherlands,
    
    /// <summary>
    /// Scheme code for the US national real time gross settlement system.
    /// Encoded/decoded by serializers as "Fedwire".
    /// </summary>
    [EnumMember(Value = "FDW")]
    [IsoId("_a4XOuNp-Ed-ak6NoX_4Aeg_1357737180")]
    [Description(@"Scheme code for the US national real time gross settlement system.")]
    Fedwire,
    
    /// <summary>
    /// Scheme code for the Bank of Japan clearing system.
    /// Encoded/decoded by serializers as "BankOfJapanNet".
    /// </summary>
    [EnumMember(Value = "BOJ")]
    [IsoId("_a4XOudp-Ed-ak6NoX_4Aeg_1357737181")]
    [Description(@"Scheme code for the Bank of Japan clearing system.")]
    BankOfJapanNet,
    
    /// <summary>
    /// Scheme code for the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank.
    /// Encoded/decoded by serializers as "ForeignExchangeYenClearing".
    /// </summary>
    [EnumMember(Value = "FEY")]
    [IsoId("_a4XOutp-Ed-ak6NoX_4Aeg_1357737182")]
    [Description(@"Scheme code for the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank.")]
    ForeignExchangeYenClearing,
    
    /// <summary>
    /// Scheme code for the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association.
    /// Encoded/decoded by serializers as "Zengin".
    /// </summary>
    [EnumMember(Value = "ZEN")]
    [IsoId("_a4g_sNp-Ed-ak6NoX_4Aeg_1357737183")]
    [Description(@"Scheme code for the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association.")]
    Zengin,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CashClearingSystem1CodeMetadataExtensions
{
    private static readonly CashClearingSystem1CodeDropdownSource _dropdownSource = new CashClearingSystem1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICashClearingSystem1CodeDropdownRow GetMetadata(this CashClearingSystem1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


