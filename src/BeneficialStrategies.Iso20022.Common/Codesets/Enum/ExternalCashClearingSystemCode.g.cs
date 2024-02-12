﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalCashClearingSystemCode.  ISO2002 ID# _4fFI0JF_EeeBGrZP1w0opg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cash clearing system, as published in an external cash clearing system code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4fFI0JF_EeeBGrZP1w0opg")]
[Description(@"Specifies the cash clearing system, as published in an external cash clearing system code list.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalCashClearingSystem1Code))]
public enum ExternalCashClearingSystemCode
{
    /// <summary>
    /// EBA Euro1/Step1.
    /// Encoded/decoded by serializers as "ABE".
    /// </summary>
    [EnumMember(Value = "ABE")]
    [IsoId("_tfmrsPRYEeuLhpyIdtJzwg")]
    [Description(@"EBA Euro1/Step1.")]
    EBAEuro1Step1,
    
    /// <summary>
    /// Automated Clearing House. Payment system that clears cash transfers and settles the proceeds in a lump sum, usually on a multilateral netting basis.
    /// Encoded/decoded by serializers as "ACH".
    /// </summary>
    [EnumMember(Value = "ACH")]
    [IsoId("_tfmrs_RYEeuLhpyIdtJzwg")]
    [Description(@"Automated Clearing House. Payment system that clears cash transfers and settles the proceeds in a lump sum, usually on a multilateral netting basis.")]
    ACH,
    
    /// <summary>
    /// Canadian Dollar (CAD)  - Automated Clearing Settlement System (ACSS) 
    /// Encoded/decoded by serializers as "ACS".
    /// </summary>
    [EnumMember(Value = "ACS")]
    [IsoId("_tfmrtvRYEeuLhpyIdtJzwg")]
    [Description(@"Canadian Dollar (CAD)  - Automated Clearing Settlement System (ACSS) ")]
    CanadaACSS,
    
    /// <summary>
    /// AL (Albania) -  Albania Interbank Payment System.
    /// Encoded/decoded by serializers as "AIP".
    /// </summary>
    [EnumMember(Value = "AIP")]
    [IsoId("_tfv1oPRYEeuLhpyIdtJzwg")]
    [Description(@"AL (Albania) -  Albania Interbank Payment System.")]
    Albania,
    
    /// <summary>
    /// AT (Austria) - Austrian RTGS.
    /// Encoded/decoded by serializers as "ART".
    /// </summary>
    [EnumMember(Value = "ART")]
    [IsoId("_tfv1o_RYEeuLhpyIdtJzwg")]
    [Description(@"AT (Austria) - Austrian RTGS.")]
    Austrian,
    
    /// <summary>
    /// NZ (New Zealand) - New Zealand Assured Value Payments.
    /// Encoded/decoded by serializers as "AVP".
    /// </summary>
    [EnumMember(Value = "AVP")]
    [IsoId("_tfv1pvRYEeuLhpyIdtJzwg")]
    [Description(@"NZ (New Zealand) - New Zealand Assured Value Payments.")]
    NewZealand,
    
    /// <summary>
    /// AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).
    /// Encoded/decoded by serializers as "AZM".
    /// </summary>
    [EnumMember(Value = "AZM")]
    [IsoId("_tfv1qfRYEeuLhpyIdtJzwg")]
    [Description(@"AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).")]
    Azerbaijan,
    
    /// <summary>
    /// BA (Bosnia and Herzegovina).
    /// Encoded/decoded by serializers as "BAP".
    /// </summary>
    [EnumMember(Value = "BAP")]
    [IsoId("_tfv1rPRYEeuLhpyIdtJzwg")]
    [Description(@"BA (Bosnia and Herzegovina).")]
    BosniaHerzegovina,
    
    /// <summary>
    /// SE (Sweden) - Sweden BGC Clearing CUG.
    /// Encoded/decoded by serializers as "BCC".
    /// </summary>
    [EnumMember(Value = "BCC")]
    [IsoId("_tf5moPRYEeuLhpyIdtJzwg")]
    [Description(@"SE (Sweden) - Sweden BGC Clearing CUG.")]
    SwedenBGC,
    
    /// <summary>
    /// EC (Ecuador) - Ecuadorian Central Payment System (Sistema Central de Pagos Ecuatoriano)
    /// Encoded/decoded by serializers as "BCE".
    /// </summary>
    [EnumMember(Value = "BCE")]
    [IsoId("_tf5mo_RYEeuLhpyIdtJzwg")]
    [Description(@"EC (Ecuador) - Ecuadorian Central Payment System (Sistema Central de Pagos Ecuatoriano)")]
    Ecuador,
    
    /// <summary>
    /// BB (Barbados) - Barbados RTGS (CBRTGS).
    /// Encoded/decoded by serializers as "BDS".
    /// </summary>
    [EnumMember(Value = "BDS")]
    [IsoId("_tgDXoPRYEeuLhpyIdtJzwg")]
    [Description(@"BB (Barbados) - Barbados RTGS (CBRTGS).")]
    Barbados,
    
    /// <summary>
    /// BE (Belgium) - Belgium RTGS (ELLIPS).
    /// Encoded/decoded by serializers as "BEL".
    /// </summary>
    [EnumMember(Value = "BEL")]
    [IsoId("_tgDXo_RYEeuLhpyIdtJzwg")]
    [Description(@"BE (Belgium) - Belgium RTGS (ELLIPS).")]
    Belgium,
    
    /// <summary>
    /// BG (Bulgaria) - Bulgaria RTGS.
    /// Encoded/decoded by serializers as "BGN".
    /// </summary>
    [EnumMember(Value = "BGN")]
    [IsoId("_tgDXpvRYEeuLhpyIdtJzwg")]
    [Description(@"BG (Bulgaria) - Bulgaria RTGS.")]
    Bulgaria,
    
    /// <summary>
    /// BS (Bahamas) - Bahamas RTGS.
    /// Encoded/decoded by serializers as "BHS".
    /// </summary>
    [EnumMember(Value = "BHS")]
    [IsoId("_tgMhkPRYEeuLhpyIdtJzwg")]
    [Description(@"BS (Bahamas) - Bahamas RTGS.")]
    Bahamas,
    
    /// <summary>
    /// BW (Botswana) - Botswana Interbank Settlement System.
    /// Encoded/decoded by serializers as "BIS".
    /// </summary>
    [EnumMember(Value = "BIS")]
    [IsoId("_tgMhk_RYEeuLhpyIdtJzwg")]
    [Description(@"BW (Botswana) - Botswana Interbank Settlement System.")]
    Botswana,
    
    /// <summary>
    /// FI (Finland) - RTGS (BOF).
    /// Encoded/decoded by serializers as "BOF".
    /// </summary>
    [EnumMember(Value = "BOF")]
    [IsoId("_tgMhlvRYEeuLhpyIdtJzwg")]
    [Description(@"FI (Finland) - RTGS (BOF).")]
    Finland,
    
    /// <summary>
    /// the Bank of Japan clearing system.
    /// Encoded/decoded by serializers as "BOJ".
    /// </summary>
    [EnumMember(Value = "BOJ")]
    [IsoId("_tgWSkPRYEeuLhpyIdtJzwg")]
    [Description(@"the Bank of Japan clearing system.")]
    BankOfJapanNet,
    
    /// <summary>
    /// IT (Italy) - Italy RTGS (BIREL).
    /// Encoded/decoded by serializers as "BRL".
    /// </summary>
    [EnumMember(Value = "BRL")]
    [IsoId("_tgWSk_RYEeuLhpyIdtJzwg")]
    [Description(@"IT (Italy) - Italy RTGS (BIREL).")]
    Italy,
    
    /// <summary>
    /// PH (Philippines) - Philippines Payment System.
    /// Encoded/decoded by serializers as "BSP".
    /// </summary>
    [EnumMember(Value = "BSP")]
    [IsoId("_tgWSlvRYEeuLhpyIdtJzwg")]
    [Description(@"PH (Philippines) - Philippines Payment System.")]
    Philippines,
    
    /// <summary>
    /// CA (Canada) - Canadian Large Value Transfer System (LVTS)
    /// Encoded/decoded by serializers as "CAD".
    /// </summary>
    [EnumMember(Value = "CAD")]
    [IsoId("_tgfcgPRYEeuLhpyIdtJzwg")]
    [Description(@"CA (Canada) - Canadian Large Value Transfer System (LVTS)")]
    CanadaCAD,
    
    /// <summary>
    /// ES (Spain).
    /// Encoded/decoded by serializers as "CAM".
    /// </summary>
    [EnumMember(Value = "CAM")]
    [IsoId("_tgfcg_RYEeuLhpyIdtJzwg")]
    [Description(@"ES (Spain).")]
    SpainCAM,
    
    /// <summary>
    /// AW (Aruba) - Central Bank of Aruba CSM
    /// Encoded/decoded by serializers as "CBA".
    /// </summary>
    [EnumMember(Value = "CBA")]
    [IsoId("_tgpNgPRYEeuLhpyIdtJzwg")]
    [Description(@"AW (Aruba) - Central Bank of Aruba CSM")]
    CentralBankOfArubaCSM,
    
    /// <summary>
    /// CW (Curaçao), SX (Sint Maarten) Central Bank of Curaçao and Sint    Maarten CSM
    /// Encoded/decoded by serializers as "CBC".
    /// </summary>
    [EnumMember(Value = "CBC")]
    [IsoId("_tgpNg_RYEeuLhpyIdtJzwg")]
    [Description(@"CW (Curaçao), SX (Sint Maarten) Central Bank of Curaçao and Sint    Maarten CSM")]
    CentraleBankVanCuraçaoEnSintMaartenCSM,
    
    /// <summary>
    /// IE (Ireland) - Irish RTGS (IRIS).
    /// Encoded/decoded by serializers as "CBJ".
    /// </summary>
    [EnumMember(Value = "CBJ")]
    [IsoId("_tgpNhvRYEeuLhpyIdtJzwg")]
    [Description(@"IE (Ireland) - Irish RTGS (IRIS).")]
    Ireland,
    
    /// <summary>
    /// Real-Time Payment System Peru
    /// Encoded/decoded by serializers as "CCE".
    /// </summary>
    [EnumMember(Value = "CCE")]
    [IsoId("_tgpNifRYEeuLhpyIdtJzwg")]
    [Description(@"Real-Time Payment System Peru")]
    Peru,
    
    /// <summary>
    /// US - The Clearing House CHIPS
    /// Encoded/decoded by serializers as "CHI".
    /// </summary>
    [EnumMember(Value = "CHI")]
    [IsoId("_tgpNjPRYEeuLhpyIdtJzwg")]
    [Description(@"US - The Clearing House CHIPS")]
    USTCHChips,
    
    /// <summary>
    /// GB (UK) - British Euro RTGS (CHAPS).
    /// Encoded/decoded by serializers as "CHP".
    /// </summary>
    [EnumMember(Value = "CHP")]
    [IsoId("_tgy-gPRYEeuLhpyIdtJzwg")]
    [Description(@"GB (UK) - British Euro RTGS (CHAPS).")]
    UnitedKingdom,
    
    /// <summary>
    /// Cross-border Interbank Payment System (CIPS) 
    /// Encoded/decoded by serializers as "CIP".
    /// </summary>
    [EnumMember(Value = "CIP")]
    [IsoId("_tgy-g_RYEeuLhpyIdtJzwg")]
    [Description(@"Cross-border Interbank Payment System (CIPS) ")]
    China,
    
    /// <summary>
    /// Central Interoperability Service of the EACHA Clearing Cooperative, for exchanging SEPA payments between Automated Clearing Houses in the EEA.
    /// Encoded/decoded by serializers as "CIS".
    /// </summary>
    [EnumMember(Value = "CIS")]
    [IsoId("_tgy-hvRYEeuLhpyIdtJzwg")]
    [Description(@"Central Interoperability Service of the EACHA Clearing Cooperative, for exchanging SEPA payments between Automated Clearing Houses in the EEA.")]
    CentralInteroperabilityService,
    
    /// <summary>
    /// CO (Columbia) - Colombian Electronic Cheque System named CEDEC (Compensación Electrónica De Cheques).
    /// Encoded/decoded by serializers as "COE".
    /// </summary>
    [EnumMember(Value = "COE")]
    [IsoId("_tgy-ifRYEeuLhpyIdtJzwg")]
    [Description(@"CO (Columbia) - Colombian Electronic Cheque System named CEDEC (Compensación Electrónica De Cheques).")]
    ColumbiaCEDEC,
    
    /// <summary>
    /// CO (Columbia) - Colombian Central Bank´s ACH named CENIT (Compensación Electrónica Nacional Interbancaria).
    /// Encoded/decoded by serializers as "COI".
    /// </summary>
    [EnumMember(Value = "COI")]
    [IsoId("_tgy-jPRYEeuLhpyIdtJzwg")]
    [Description(@"CO (Columbia) - Colombian Central Bank´s ACH named CENIT (Compensación Electrónica Nacional Interbancaria).")]
    ColumbiaCENIT,
    
    /// <summary>
    /// CO (Columbia) - Colombian RTGS System named CUD (Cuentas de Depósito).
    /// Encoded/decoded by serializers as "COU".
    /// </summary>
    [EnumMember(Value = "COU")]
    [IsoId("_tg8IcPRYEeuLhpyIdtJzwg")]
    [Description(@"CO (Columbia) - Colombian RTGS System named CUD (Cuentas de Depósito).")]
    ColumbiaCUD,
    
    /// <summary>
    /// DK (Denmark) - Danish Krone RTGS (KRONOS)
    /// Encoded/decoded by serializers as "DDK".
    /// </summary>
    [EnumMember(Value = "DDK")]
    [IsoId("_tg8Ic_RYEeuLhpyIdtJzwg")]
    [Description(@"DK (Denmark) - Danish Krone RTGS (KRONOS)")]
    DenmarkDDK,
    
    /// <summary>
    /// DK (Denmark) - Danish Euro RTGS (KRONOS)
    /// Encoded/decoded by serializers as "DKC".
    /// </summary>
    [EnumMember(Value = "DKC")]
    [IsoId("_tg8IdvRYEeuLhpyIdtJzwg")]
    [Description(@"DK (Denmark) - Danish Euro RTGS (KRONOS)")]
    Denmark,
    
    /// <summary>
    /// EBA Euro1.
    /// Encoded/decoded by serializers as "EBA".
    /// </summary>
    [EnumMember(Value = "EBA")]
    [IsoId("_tg8IefRYEeuLhpyIdtJzwg")]
    [Description(@"EBA Euro1.")]
    EBAEuro1,
    
    /// <summary>
    /// DE (Germany).
    /// Encoded/decoded by serializers as "ELS".
    /// </summary>
    [EnumMember(Value = "ELS")]
    [IsoId("_tg8IfPRYEeuLhpyIdtJzwg")]
    [Description(@"DE (Germany).")]
    GermanyELS,
    
    /// <summary>
    /// Elektronischer Massenzahlungsverkehr (EMZ)|DE (Germany) – retail payment system operated by the Deutsche Bundesbank 
    /// Encoded/decoded by serializers as "EMZ".
    /// </summary>
    [EnumMember(Value = "EMZ")]
    [IsoId("_thF5cPRYEeuLhpyIdtJzwg")]
    [Description(@"Elektronischer Massenzahlungsverkehr (EMZ)|DE (Germany) – retail payment system operated by the Deutsche Bundesbank ")]
    Germany,
    
    /// <summary>
    /// ECB (European Central Bank) - ECB Payment Mechanism.
    /// Encoded/decoded by serializers as "EPM".
    /// </summary>
    [EnumMember(Value = "EPM")]
    [IsoId("_thF5c_RYEeuLhpyIdtJzwg")]
    [Description(@"ECB (European Central Bank) - ECB Payment Mechanism.")]
    ECB,
    
    /// <summary>
    /// US - The Clearing House EPN
    /// Encoded/decoded by serializers as "EPN".
    /// </summary>
    [EnumMember(Value = "EPN")]
    [IsoId("_thF5dvRYEeuLhpyIdtJzwg")]
    [Description(@"US - The Clearing House EPN")]
    USTCHEPN,
    
    /// <summary>
    /// EBA step 1 (members).
    /// Encoded/decoded by serializers as "ERP".
    /// </summary>
    [EnumMember(Value = "ERP")]
    [IsoId("_thPqcPRYEeuLhpyIdtJzwg")]
    [Description(@"EBA step 1 (members).")]
    EBAStep1,
    
    /// <summary>
    /// US (United States) - Federal Reserve Banks Automated Clearing House Service.
    /// Encoded/decoded by serializers as "FDA".
    /// </summary>
    [EnumMember(Value = "FDA")]
    [IsoId("_thPqc_RYEeuLhpyIdtJzwg")]
    [Description(@"US (United States) - Federal Reserve Banks Automated Clearing House Service.")]
    USFedACH,
    
    /// <summary>
    /// US (United States) - Federal Reserve Banks FedNow Service.
    /// Encoded/decoded by serializers as "FDN".
    /// </summary>
    [EnumMember(Value = "FDN")]
    [IsoId("_thPqdvRYEeuLhpyIdtJzwg")]
    [Description(@"US (United States) - Federal Reserve Banks FedNow Service.")]
    USFedNow,
    
    /// <summary>
    /// US (United States) - Federal Reserve Banks Fedwire Funds  Service.
    /// Encoded/decoded by serializers as "FDW".
    /// </summary>
    [EnumMember(Value = "FDW")]
    [IsoId("_thPqefRYEeuLhpyIdtJzwg")]
    [Description(@"US (United States) - Federal Reserve Banks Fedwire Funds  Service.")]
    USFedwireFunds,
    
    /// <summary>
    /// JP (Japan) the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank.
    /// Encoded/decoded by serializers as "FEY".
    /// </summary>
    [EnumMember(Value = "FEY")]
    [IsoId("_thPqfPRYEeuLhpyIdtJzwg")]
    [Description(@"JP (Japan) the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank.")]
    ForeignExchangeYenClearing,
    
    /// <summary>
    /// Faster Payments Service in UK.
    /// Encoded/decoded by serializers as "FPS".
    /// </summary>
    [EnumMember(Value = "FPS")]
    [IsoId("_thY0YPRYEeuLhpyIdtJzwg")]
    [Description(@"Faster Payments Service in UK.")]
    FasterPaymentsServices,
    
    /// <summary>
    /// GH (Ghana) - Ghana Interbank Settlement System (GISS).
    /// Encoded/decoded by serializers as "GIS".
    /// </summary>
    [EnumMember(Value = "GIS")]
    [IsoId("_thY0Y_RYEeuLhpyIdtJzwg")]
    [Description(@"GH (Ghana) - Ghana Interbank Settlement System (GISS).")]
    Ghana,
    
    /// <summary>
    /// Hong Kong Clearing House Automated Transfer System (CHATS).
    /// Encoded/decoded by serializers as "HKL".
    /// </summary>
    [EnumMember(Value = "HKL")]
    [IsoId("_thY0ZvRYEeuLhpyIdtJzwg")]
    [Description(@"Hong Kong Clearing House Automated Transfer System (CHATS).")]
    HongKongCHATS,
    
    /// <summary>
    /// Hong Kong Faster Payment System or FPS. A system owned and operated by the HKICL, to provide instant clearing and settlement payment services.
    /// Encoded/decoded by serializers as "HKS".
    /// </summary>
    [EnumMember(Value = "HKS")]
    [IsoId("_thY0afRYEeuLhpyIdtJzwg")]
    [Description(@"Hong Kong Faster Payment System or FPS. A system owned and operated by the HKICL, to provide instant clearing and settlement payment services.")]
    HongKongFPS,
    
    /// <summary>
    /// HR (Croatia) - HSVP.
    /// Encoded/decoded by serializers as "HRK".
    /// </summary>
    [EnumMember(Value = "HRK")]
    [IsoId("_thY0bPRYEeuLhpyIdtJzwg")]
    [Description(@"HR (Croatia) - HSVP.")]
    Croatia,
    
    /// <summary>
    /// GR (Greece) - Greek RTGS (HERMES).
    /// Encoded/decoded by serializers as "HRM".
    /// </summary>
    [EnumMember(Value = "HRM")]
    [IsoId("_thilYPRYEeuLhpyIdtJzwg")]
    [Description(@"GR (Greece) - Greek RTGS (HERMES).")]
    Greece,
    
    /// <summary>
    /// HU (Hungary) - VIBER.
    /// Encoded/decoded by serializers as "HUF".
    /// </summary>
    [EnumMember(Value = "HUF")]
    [IsoId("_thilY_RYEeuLhpyIdtJzwg")]
    [Description(@"HU (Hungary) - VIBER.")]
    Hungary,
    
    /// <summary>
    /// ES - Spain - Iberpay Instant Payments
    /// Encoded/decoded by serializers as "IBP".
    /// </summary>
    [EnumMember(Value = "IBP")]
    [IsoId("_thilZvRYEeuLhpyIdtJzwg")]
    [Description(@"ES - Spain - Iberpay Instant Payments")]
    SpainIberpayInstantPayments,
    
    /// <summary>
    /// DE and NL - Equens 
    /// Encoded/decoded by serializers as "INC".
    /// </summary>
    [EnumMember(Value = "INC")]
    [IsoId("_thrvUPRYEeuLhpyIdtJzwg")]
    [Description(@"DE and NL - Equens ")]
    DEandNLEquens,
    
    /// <summary>
    /// India Immediate Payment Service
    /// Encoded/decoded by serializers as "IMP".
    /// </summary>
    [EnumMember(Value = "IMP")]
    [IsoId("_thrvU_RYEeuLhpyIdtJzwg")]
    [Description(@"India Immediate Payment Service")]
    IndiaImmediatePaymentService,
    
    /// <summary>
    /// JO (Jordan) - Jordan RTGS.
    /// Encoded/decoded by serializers as "JOD".
    /// </summary>
    [EnumMember(Value = "JOD")]
    [IsoId("_thrvVvRYEeuLhpyIdtJzwg")]
    [Description(@"JO (Jordan) - Jordan RTGS.")]
    Jordan,
    
    /// <summary>
    /// KE (Kenya) - Kenyan Electronic Payment Settlement System.
    /// Encoded/decoded by serializers as "KPS".
    /// </summary>
    [EnumMember(Value = "KPS")]
    [IsoId("_thrvWfRYEeuLhpyIdtJzwg")]
    [Description(@"KE (Kenya) - Kenyan Electronic Payment Settlement System.")]
    Kenya,
    
    /// <summary>
    /// LU (Luxemburg) - Luxembourg RTGS (LIPS).
    /// Encoded/decoded by serializers as "LGS".
    /// </summary>
    [EnumMember(Value = "LGS")]
    [IsoId("_th1gUPRYEeuLhpyIdtJzwg")]
    [Description(@"LU (Luxemburg) - Luxembourg RTGS (LIPS).")]
    Luxemburg,
    
    /// <summary>
    /// LK (Sri Lanka) - Sri Lanka (Lankasettle).
    /// Encoded/decoded by serializers as "LKB".
    /// </summary>
    [EnumMember(Value = "LKB")]
    [IsoId("_th1gU_RYEeuLhpyIdtJzwg")]
    [Description(@"LK (Sri Lanka) - Sri Lanka (Lankasettle).")]
    SriLanka,
    
    /// <summary>
    /// LV (Latvia).
    /// Encoded/decoded by serializers as "LVL".
    /// </summary>
    [EnumMember(Value = "LVL")]
    [IsoId("_th1gVvRYEeuLhpyIdtJzwg")]
    [Description(@"LV (Latvia).")]
    Latvia,
    
    /// <summary>
    /// CA (Canada) - Large Value Transfer System (LVTS).
    /// Encoded/decoded by serializers as "LVT".
    /// </summary>
    [EnumMember(Value = "LVT")]
    [IsoId("_th_RUPRYEeuLhpyIdtJzwg")]
    [Description(@"CA (Canada) - Large Value Transfer System (LVTS).")]
    CanadaLVTS,
    
    /// <summary>
    /// CA (Canada) Lynx High Value Payment System.
    /// Encoded/decoded by serializers as "LYX".
    /// </summary>
    [EnumMember(Value = "LYX")]
    [IsoId("_th_RU_RYEeuLhpyIdtJzwg")]
    [Description(@"CA (Canada) Lynx High Value Payment System.")]
    LynxCanada,
    
    /// <summary>
    /// SG (Singapore) - Singapore RTGS (MEPS+).
    /// Encoded/decoded by serializers as "MEP".
    /// </summary>
    [EnumMember(Value = "MEP")]
    [IsoId("_th_RVvRYEeuLhpyIdtJzwg")]
    [Description(@"SG (Singapore) - Singapore RTGS (MEPS+).")]
    Singapore,
    
    /// <summary>
    /// ZA (South Africa) - South-African Multiple Option Settlement.
    /// Encoded/decoded by serializers as "MOS".
    /// </summary>
    [EnumMember(Value = "MOS")]
    [IsoId("_th_RWfRYEeuLhpyIdtJzwg")]
    [Description(@"ZA (South Africa) - South-African Multiple Option Settlement.")]
    SouthAfrica,
    
    /// <summary>
    /// Macao Real Time Gross Settlement System
    /// Encoded/decoded by serializers as "MQQ".
    /// </summary>
    [EnumMember(Value = "MQQ")]
    [IsoId("_th_RXPRYEeuLhpyIdtJzwg")]
    [Description(@"Macao Real Time Gross Settlement System")]
    MacaoRTGS,
    
    /// <summary>
    /// MT (Malta) - Malta Realtime Interbank Settlement System.
    /// Encoded/decoded by serializers as "MRS".
    /// </summary>
    [EnumMember(Value = "MRS")]
    [IsoId("_tiIbQPRYEeuLhpyIdtJzwg")]
    [Description(@"MT (Malta) - Malta Realtime Interbank Settlement System.")]
    Malta,
    
    /// <summary>
    /// MU (Mauritius).
    /// Encoded/decoded by serializers as "MUP".
    /// </summary>
    [EnumMember(Value = "MUP")]
    [IsoId("_tiIbQ_RYEeuLhpyIdtJzwg")]
    [Description(@"MU (Mauritius).")]
    Mauritius,
    
    /// <summary>
    /// NA (Namibian) - Namibian Interbank Settlement System.
    /// Encoded/decoded by serializers as "NAM".
    /// </summary>
    [EnumMember(Value = "NAM")]
    [IsoId("_tiIbRvRYEeuLhpyIdtJzwg")]
    [Description(@"NA (Namibian) - Namibian Interbank Settlement System.")]
    Namibia,
    
    /// <summary>
    /// NO (Norway).
    /// Encoded/decoded by serializers as "NOC".
    /// </summary>
    [EnumMember(Value = "NOC")]
    [IsoId("_tiIbSfRYEeuLhpyIdtJzwg")]
    [Description(@"NO (Norway).")]
    Norway,
    
    /// <summary>
    /// NICS Real (Norway)
    /// Encoded/decoded by serializers as "NOR".
    /// </summary>
    [EnumMember(Value = "NOR")]
    [IsoId("_tiIbTPRYEeuLhpyIdtJzwg")]
    [Description(@"NICS Real (Norway)")]
    NorwayNICSReal,
    
    /// <summary>
    /// AU (Australia) - New Payments Platform (NPP).
    /// Encoded/decoded by serializers as "NPP".
    /// </summary>
    [EnumMember(Value = "NPP")]
    [IsoId("_tiSMQPRYEeuLhpyIdtJzwg")]
    [Description(@"AU (Australia) - New Payments Platform (NPP).")]
    AustraliaNPP,
    
    /// <summary>
    /// US (United States) - Federal Reserve Banks National Settlement Service.
    /// Encoded/decoded by serializers as "NSS".
    /// </summary>
    [EnumMember(Value = "NSS")]
    [IsoId("_tiSMQ_RYEeuLhpyIdtJzwg")]
    [Description(@"US (United States) - Federal Reserve Banks National Settlement Service.")]
    USNSS,
    
    /// <summary>
    /// NZ (New Zealand) – New Zealand Dollar RTGS (ESAS)
    /// Encoded/decoded by serializers as "NZE".
    /// </summary>
    [EnumMember(Value = "NZE")]
    [IsoId("_tiSMRvRYEeuLhpyIdtJzwg")]
    [Description(@"NZ (New Zealand) – New Zealand Dollar RTGS (ESAS)")]
    NewZealandRTGS,
    
    /// <summary>
    /// CH (Switzerland).
    /// Encoded/decoded by serializers as "PCH".
    /// </summary>
    [EnumMember(Value = "PCH")]
    [IsoId("_tiSMSfRYEeuLhpyIdtJzwg")]
    [Description(@"CH (Switzerland).")]
    Switzerland,
    
    /// <summary>
    /// AU (Australia).
    /// Encoded/decoded by serializers as "PDS".
    /// </summary>
    [EnumMember(Value = "PDS")]
    [IsoId("_tiSMTPRYEeuLhpyIdtJzwg")]
    [Description(@"AU (Australia).")]
    AustraliaPDS,
    
    /// <summary>
    /// EG (Egypt).
    /// Encoded/decoded by serializers as "PEG".
    /// </summary>
    [EnumMember(Value = "PEG")]
    [IsoId("_tib9QPRYEeuLhpyIdtJzwg")]
    [Description(@"EG (Egypt).")]
    Egypt,
    
    /// <summary>
    /// FR (France).
    /// Encoded/decoded by serializers as "PNS".
    /// </summary>
    [EnumMember(Value = "PNS")]
    [IsoId("_tib9Q_RYEeuLhpyIdtJzwg")]
    [Description(@"FR (France).")]
    FrancePNS,
    
    /// <summary>
    /// AT (Austria) – Austrian CSM.
    /// Encoded/decoded by serializers as "PSA".
    /// </summary>
    [EnumMember(Value = "PSA")]
    [IsoId("_tib9RvRYEeuLhpyIdtJzwg")]
    [Description(@"AT (Austria) – Austrian CSM.")]
    AustrianCSM,
    
    /// <summary>
    /// AO (Angola) - Angola RTGS.
    /// Encoded/decoded by serializers as "PTR".
    /// </summary>
    [EnumMember(Value = "PTR")]
    [IsoId("_tib9SfRYEeuLhpyIdtJzwg")]
    [Description(@"AO (Angola) - Angola RTGS.")]
    Angola,
    
    /// <summary>
    /// Ve (Venezuela).
    /// Encoded/decoded by serializers as "PVE".
    /// </summary>
    [EnumMember(Value = "PVE")]
    [IsoId("_tib9TPRYEeuLhpyIdtJzwg")]
    [Description(@"Ve (Venezuela).")]
    Venezuela,
    
    /// <summary>
    /// RO (Romania) - Romanian Electronic Payment Operations RT.
    /// Encoded/decoded by serializers as "ROL".
    /// </summary>
    [EnumMember(Value = "ROL")]
    [IsoId("_tilHMPRYEeuLhpyIdtJzwg")]
    [Description(@"RO (Romania) - Romanian Electronic Payment Operations RT.")]
    RomaniaEPO,
    
    /// <summary>
    /// RO (Romania) - Romanian GSRS.
    /// Encoded/decoded by serializers as "ROS".
    /// </summary>
    [EnumMember(Value = "ROS")]
    [IsoId("_tilHM_RYEeuLhpyIdtJzwg")]
    [Description(@"RO (Romania) - Romanian GSRS.")]
    RomaniaGSRS,
    
    /// <summary>
    /// Real Time Gross Settlement System. Payment system that simultaneously clears individual transfers and settles them in central bank money.
    /// Encoded/decoded by serializers as "RTG".
    /// </summary>
    [EnumMember(Value = "RTG")]
    [IsoId("_tilHNvRYEeuLhpyIdtJzwg")]
    [Description(@"Real Time Gross Settlement System. Payment system that simultaneously clears individual transfers and settles them in central bank money.")]
    RTGS,
    
    /// <summary>
    /// DE (Germany).
    /// Encoded/decoded by serializers as "RTP".
    /// </summary>
    [EnumMember(Value = "RTP")]
    [IsoId("_tilHOfRYEeuLhpyIdtJzwg")]
    [Description(@"DE (Germany).")]
    GermanyRTGSPlus,
    
    /// <summary>
    /// CA (Canada) Real Time Rail Payment System.
    /// Encoded/decoded by serializers as "RTR".
    /// </summary>
    [EnumMember(Value = "RTR")]
    [IsoId("_tilHPPRYEeuLhpyIdtJzwg")]
    [Description(@"CA (Canada) Real Time Rail Payment System.")]
    RTRCanada,
    
    /// <summary>
    /// DE – SEPA-Clearer of the Retail Payment System operated by Deutsche Bundesbank
    /// Encoded/decoded by serializers as "SCL".
    /// </summary>
    [EnumMember(Value = "SCL")]
    [IsoId("_tiu4MPRYEeuLhpyIdtJzwg")]
    [Description(@"DE – SEPA-Clearer of the Retail Payment System operated by Deutsche Bundesbank")]
    RPSAndSEPAClearer,
    
    /// <summary>
    /// CL (Chile) - Chilean Interbank Payment System.
    /// Encoded/decoded by serializers as "SCP".
    /// </summary>
    [EnumMember(Value = "SCP")]
    [IsoId("_tiu4M_RYEeuLhpyIdtJzwg")]
    [Description(@"CL (Chile) - Chilean Interbank Payment System.")]
    Chili,
    
    /// <summary>
    /// SE (Sweden) - Swedish Euro RTGS (SEC).
    /// Encoded/decoded by serializers as "SEC".
    /// </summary>
    [EnumMember(Value = "SEC")]
    [IsoId("_tiu4NvRYEeuLhpyIdtJzwg")]
    [Description(@"SE (Sweden) - Swedish Euro RTGS (SEC).")]
    SwedenSEC,
    
    /// <summary>
    /// CH (Switzerland) – Swiss EUR RTGS named euroSIC.
    /// Encoded/decoded by serializers as "SEU".
    /// </summary>
    [EnumMember(Value = "SEU")]
    [IsoId("_tiu4OfRYEeuLhpyIdtJzwg")]
    [Description(@"CH (Switzerland) – Swiss EUR RTGS named euroSIC.")]
    euroSIC,
    
    /// <summary>
    /// CH (Switzerland) – Swiss CHF RTGS named SIC.
    /// Encoded/decoded by serializers as "SIC".
    /// </summary>
    [EnumMember(Value = "SIC")]
    [IsoId("_tiu4PPRYEeuLhpyIdtJzwg")]
    [Description(@"CH (Switzerland) – Swiss CHF RTGS named SIC.")]
    SIC,
    
    /// <summary>
    /// CH (Switzerland) – Swiss Instant Payment service in CHF operated by SIX Interbank Clearing.
    /// Encoded/decoded by serializers as "SIP".
    /// </summary>
    [EnumMember(Value = "SIP")]
    [IsoId("_ti4CIPRYEeuLhpyIdtJzwg")]
    [Description(@"CH (Switzerland) – Swiss Instant Payment service in CHF operated by SIX Interbank Clearing.")]
    SICIP,
    
    /// <summary>
    /// SI (Slovenia).
    /// Encoded/decoded by serializers as "SIT".
    /// </summary>
    [EnumMember(Value = "SIT")]
    [IsoId("_ti4CI_RYEeuLhpyIdtJzwg")]
    [Description(@"SI (Slovenia).")]
    Slovania,
    
    /// <summary>
    /// ES (Spain) - Spanish RTGS (SLBE).
    /// Encoded/decoded by serializers as "SLB".
    /// </summary>
    [EnumMember(Value = "SLB")]
    [IsoId("_tjBzIPRYEeuLhpyIdtJzwg")]
    [Description(@"ES (Spain) - Spanish RTGS (SLBE).")]
    SpainES,
    
    /// <summary>
    /// PT (Portugal) - Portuguese RTGS (SPGT).
    /// Encoded/decoded by serializers as "SPG".
    /// </summary>
    [EnumMember(Value = "SPG")]
    [IsoId("_tjBzI_RYEeuLhpyIdtJzwg")]
    [Description(@"PT (Portugal) - Portuguese RTGS (SPGT).")]
    Portugal,
    
    /// <summary>
    /// SE (Sweden) - SEK RTGS (RIX).
    /// Encoded/decoded by serializers as "SSK".
    /// </summary>
    [EnumMember(Value = "SSK")]
    [IsoId("_tjBzJvRYEeuLhpyIdtJzwg")]
    [Description(@"SE (Sweden) - SEK RTGS (RIX).")]
    SwedenSSK,
    
    /// <summary>
    /// EBA Clearing STEP 2.
    /// Encoded/decoded by serializers as "ST2".
    /// </summary>
    [EnumMember(Value = "ST2")]
    [IsoId("_tjBzKfRYEeuLhpyIdtJzwg")]
    [Description(@"EBA Clearing STEP 2.")]
    EBAClearingSTEP2,
    
    /// <summary>
    /// UK (United Kingdom) - CHAPS Sterling RTGS.
    /// Encoded/decoded by serializers as "STG".
    /// </summary>
    [EnumMember(Value = "STG")]
    [IsoId("_tjLkIPRYEeuLhpyIdtJzwg")]
    [Description(@"UK (United Kingdom) - CHAPS Sterling RTGS.")]
    UnitedKingdomGBP,
    
    /// <summary>
    /// FR (France) - French RTGS (TBF).
    /// Encoded/decoded by serializers as "TBF".
    /// </summary>
    [EnumMember(Value = "TBF")]
    [IsoId("_tjLkI_RYEeuLhpyIdtJzwg")]
    [Description(@"FR (France) - French RTGS (TBF).")]
    FranceFR,
    
    /// <summary>
    /// US - The Clearing House Real-TimePayment System
    /// Encoded/decoded by serializers as "TCH".
    /// </summary>
    [EnumMember(Value = "TCH")]
    [IsoId("_tjLkJvRYEeuLhpyIdtJzwg")]
    [Description(@"US - The Clearing House Real-TimePayment System")]
    USTCHRealTime,
    
    /// <summary>
    /// Target.
    /// Encoded/decoded by serializers as "TGT".
    /// </summary>
    [EnumMember(Value = "TGT")]
    [IsoId("_tjLkKfRYEeuLhpyIdtJzwg")]
    [Description(@"Target.")]
    Target,
    
    /// <summary>
    /// TH (Thailand) - Thailand Payment System (BAHTNET).
    /// Encoded/decoded by serializers as "THB".
    /// </summary>
    [EnumMember(Value = "THB")]
    [IsoId("_tjLkLPRYEeuLhpyIdtJzwg")]
    [Description(@"TH (Thailand) - Thailand Payment System (BAHTNET).")]
    Thailand,
    
    /// <summary>
    /// TH (Thailand) - National ITMX Payment System
    /// Encoded/decoded by serializers as "THN".
    /// </summary>
    [EnumMember(Value = "THN")]
    [IsoId("_tjUuEPRYEeuLhpyIdtJzwg")]
    [Description(@"TH (Thailand) - National ITMX Payment System")]
    Thailand_NITMX,
    
    /// <summary>
    /// TZ (Tanzania) - Tanzania Interbank Settlement System (TISS).
    /// Encoded/decoded by serializers as "TIS".
    /// </summary>
    [EnumMember(Value = "TIS")]
    [IsoId("_tjUuE_RYEeuLhpyIdtJzwg")]
    [Description(@"TZ (Tanzania) - Tanzania Interbank Settlement System (TISS).")]
    Tanzania,
    
    /// <summary>
    /// NL (Netherlands) - Dutch RTGS (TOP) 
    /// Encoded/decoded by serializers as "TOP".
    /// </summary>
    [EnumMember(Value = "TOP")]
    [IsoId("_tjUuFvRYEeuLhpyIdtJzwg")]
    [Description(@"NL (Netherlands) - Dutch RTGS (TOP) ")]
    Netherlands,
    
    /// <summary>
    /// TT (Trinidad and Tobago ) - Trinidad and Tobago SAFE-TT.
    /// Encoded/decoded by serializers as "TTD".
    /// </summary>
    [EnumMember(Value = "TTD")]
    [IsoId("_tjUuGfRYEeuLhpyIdtJzwg")]
    [Description(@"TT (Trinidad and Tobago ) - Trinidad and Tobago SAFE-TT.")]
    TrinidadAndTobago,
    
    /// <summary>
    /// United States Dollar  (USD) – US Bulk Exchange Clearing System (USBE)
    /// Encoded/decoded by serializers as "UBE".
    /// </summary>
    [EnumMember(Value = "UBE")]
    [IsoId("_tjUuHPRYEeuLhpyIdtJzwg")]
    [Description(@"United States Dollar  (USD) – US Bulk Exchange Clearing System (USBE)")]
    CanadaUSBE,
    
    /// <summary>
    /// UG (Uganda) - Uganda National Interbank Settlement System.
    /// Encoded/decoded by serializers as "UIS".
    /// </summary>
    [EnumMember(Value = "UIS")]
    [IsoId("_tjefEPRYEeuLhpyIdtJzwg")]
    [Description(@"UG (Uganda) - Uganda National Interbank Settlement System.")]
    Uganda,
    
    /// <summary>
    /// India Unified Payments Interface.
    /// Encoded/decoded by serializers as "UPI".
    /// </summary>
    [EnumMember(Value = "UPI")]
    [IsoId("_tjefE_RYEeuLhpyIdtJzwg")]
    [Description(@"India Unified Payments Interface.")]
    IndiaUnifiedPaymentsInterface,
    
    /// <summary>
    /// VocaLink Clearing System
    /// Encoded/decoded by serializers as "VCS".
    /// </summary>
    [EnumMember(Value = "VCS")]
    [IsoId("_tjefFvRYEeuLhpyIdtJzwg")]
    [Description(@"VocaLink Clearing System")]
    VocaLink,
    
    /// <summary>
    /// EBA step 2.
    /// Encoded/decoded by serializers as "XCT".
    /// </summary>
    [EnumMember(Value = "XCT")]
    [IsoId("_tjefGfRYEeuLhpyIdtJzwg")]
    [Description(@"EBA step 2.")]
    EBASTEP2XCT,
    
    /// <summary>
    /// JP (Japan) the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association.
    /// Encoded/decoded by serializers as "ZEN".
    /// </summary>
    [EnumMember(Value = "ZEN")]
    [IsoId("_tjoQEPRYEeuLhpyIdtJzwg")]
    [Description(@"JP (Japan) the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association.")]
    Zengin,
    
    /// <summary>
    /// ZW (Zimbabwe) - Zimbabwe Electronic Transfer & Settlement System.
    /// Encoded/decoded by serializers as "ZET".
    /// </summary>
    [EnumMember(Value = "ZET")]
    [IsoId("_tjoQE_RYEeuLhpyIdtJzwg")]
    [Description(@"ZW (Zimbabwe) - Zimbabwe Electronic Transfer & Settlement System.")]
    Zimbabwe,
    
    /// <summary>
    /// ZM (Zambia) - Zambian Interbank Payment &Settlement System.
    /// Encoded/decoded by serializers as "ZIS".
    /// </summary>
    [EnumMember(Value = "ZIS")]
    [IsoId("_tjoQFvRYEeuLhpyIdtJzwg")]
    [Description(@"ZM (Zambia) - Zambian Interbank Payment &Settlement System.")]
    Zambia,
    
    /// <summary>
    /// IS (Iceland) – Icelandic krona RTGS (MBK).
    /// Encoded/decoded by serializers as "ISG".
    /// </summary>
    [EnumMember(Value = "ISG")]
    [IsoId("_7cVQUAQyEey95qpfbNuEwg")]
    [Description(@"IS (Iceland) – Icelandic krona RTGS (MBK).")]
    Iceland,
    
    /// <summary>
    /// NO - Norway NOK RTGS Norges Bank
    /// Encoded/decoded by serializers as "NBO".
    /// </summary>
    [EnumMember(Value = "NBO")]
    [IsoId("_jkV_4ATUEey95qpfbNuEwg")]
    [Description(@"NO - Norway NOK RTGS Norges Bank")]
    NorwayRTGS,
    
    /// <summary>
    /// NG (Nigeria) - Interswitch.
    /// Encoded/decoded by serializers as "ISW".
    /// </summary>
    [EnumMember(Value = "ISW")]
    [IsoId("_VLBakFErEey6cYDbEubNXg")]
    [Description(@"NG (Nigeria) - Interswitch.")]
    NGInterswitch,
    
    /// <summary>
    /// P27 Clearing – Instant Payment Platform.
    /// Encoded/decoded by serializers as "I27".
    /// </summary>
    [EnumMember(Value = "I27")]
    [IsoId("_KuqoEI5CEeyANo-d7JlQ1A")]
    [Description(@"P27 Clearing – Instant Payment Platform.")]
    P27RealTime,
    
    /// <summary>
    /// P27 Clearing – Batch Payment Platform.
    /// Encoded/decoded by serializers as "B27".
    /// </summary>
    [EnumMember(Value = "B27")]
    [IsoId("_Tf_TwI5CEeyANo-d7JlQ1A")]
    [Description(@"P27 Clearing – Batch Payment Platform.")]
    P27,
    
    /// <summary>
    /// UK (United Kingdom) – Pay.UK Sterling Domestic.
    /// Encoded/decoded by serializers as "UKD".
    /// </summary>
    [EnumMember(Value = "UKD")]
    [IsoId("_ufb1YI5FEeyANo-d7JlQ1A")]
    [Description(@"UK (United Kingdom) – Pay.UK Sterling Domestic.")]
    UnitedKingdomUKD,
    
    /// <summary>
    /// SG (Singapore) - Singapore RTGS (SCRIPS).
    /// Encoded/decoded by serializers as "SCR".
    /// </summary>
    [EnumMember(Value = "SCR")]
    [IsoId("_RwTV8OAfEey0k8vo1GQhqQ")]
    [Description(@"SG (Singapore) - Singapore RTGS (SCRIPS).")]
    SingaporeSCRIPS,
    
    /// <summary>
    /// SE (Sweden) – SEK RTGS (RIX).
    /// Encoded/decoded by serializers as "RIX".
    /// </summary>
    [EnumMember(Value = "RIX")]
    [IsoId("_k3awwOAfEey0k8vo1GQhqQ")]
    [Description(@"SE (Sweden) – SEK RTGS (RIX).")]
    RIXRTGSSverigesRiksbank,
    
    /// <summary>
    /// Banco de Mocambique RTGS system.
    /// Encoded/decoded by serializers as "MOC".
    /// </summary>
    [EnumMember(Value = "MOC")]
    [IsoId("_z88_gGvXEe2F6NrIyOmXcA")]
    [Description(@"Banco de Mocambique RTGS system.")]
    BancoDeMocambiqueRTGS,
    
    /// <summary>
    /// KR (South Korea) – Korean Won RTGS (BOK-Wire+).
    /// Encoded/decoded by serializers as "BOK".
    /// </summary>
    [EnumMember(Value = "BOK")]
    [IsoId("_eNhwIP7LEe2ORYPQEd-Clg")]
    [Description(@"KR (South Korea) – Korean Won RTGS (BOK-Wire+).")]
    KoreaBOKWire,
    
}
