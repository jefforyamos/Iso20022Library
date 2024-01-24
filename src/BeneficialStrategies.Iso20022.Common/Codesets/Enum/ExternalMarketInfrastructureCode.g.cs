﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalMarketInfrastructureCode.  ISO2002 ID# _MwrsIJ05Eeet_4BCDEBLdQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the market infrastructure identification, as published in an external market infrastructure code list.
/// This is a synonym of the external cash clearing system code list, extended outside the pure cash domains.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MwrsIJ05Eeet_4BCDEBLdQ")]
[Description(@"Specifies the market infrastructure identification, as published in an external market infrastructure code list.|This is a synonym of the external cash clearing system code list, extended outside the pure cash domains.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalMarketInfrastructure1Code))]
public enum ExternalMarketInfrastructureCode
{
    /// <summary>
    /// EBA Euro1/Step1.
    /// Encoded/decoded by serializers as "ABE".
    /// </summary>
    [EnumMember(Value = "ABE")]
    [IsoId("_uiNYNvRYEeuLhpyIdtJzwg")]
    [Description(@"EBA Euro1/Step1.")]
    EBAEuro1Step1,
    
    /// <summary>
    /// Automated Clearing House. Payment system that clears cash transfers and settles the proceeds in a lump sum, usually on a multilateral netting basis.
    /// Encoded/decoded by serializers as "ACH".
    /// </summary>
    [EnumMember(Value = "ACH")]
    [IsoId("_uiXJMPRYEeuLhpyIdtJzwg")]
    [Description(@"Automated Clearing House. Payment system that clears cash transfers and settles the proceeds in a lump sum, usually on a multilateral netting basis.")]
    ACH,
    
    /// <summary>
    /// Canadian Dollar (CAD)  - Automated Clearing Settlement System (ACSS) 
    /// Encoded/decoded by serializers as "ACS".
    /// </summary>
    [EnumMember(Value = "ACS")]
    [IsoId("_uiXJM_RYEeuLhpyIdtJzwg")]
    [Description(@"Canadian Dollar (CAD)  - Automated Clearing Settlement System (ACSS) ")]
    CanadaACSS,
    
    /// <summary>
    /// AL (Albania) -  Albania Interbank Payment System.
    /// Encoded/decoded by serializers as "AIP".
    /// </summary>
    [EnumMember(Value = "AIP")]
    [IsoId("_uigTIPRYEeuLhpyIdtJzwg")]
    [Description(@"AL (Albania) -  Albania Interbank Payment System.")]
    Albania,
    
    /// <summary>
    /// AT (Austria) - Austrian RTGS (ARTIS).
    /// Encoded/decoded by serializers as "ART".
    /// </summary>
    [EnumMember(Value = "ART")]
    [IsoId("_uigTI_RYEeuLhpyIdtJzwg")]
    [Description(@"AT (Austria) - Austrian RTGS (ARTIS).")]
    Austrian,
    
    /// <summary>
    /// NZ (New Zealand) - New Zealand Assured Value Payments.
    /// Encoded/decoded by serializers as "AVP".
    /// </summary>
    [EnumMember(Value = "AVP")]
    [IsoId("_uigTJvRYEeuLhpyIdtJzwg")]
    [Description(@"NZ (New Zealand) - New Zealand Assured Value Payments.")]
    NewZealand,
    
    /// <summary>
    /// AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).
    /// Encoded/decoded by serializers as "AZM".
    /// </summary>
    [EnumMember(Value = "AZM")]
    [IsoId("_uigTKfRYEeuLhpyIdtJzwg")]
    [Description(@"AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).")]
    Azerbaijan,
    
    /// <summary>
    /// BA (Bosnia and Herzegovina).
    /// Encoded/decoded by serializers as "BAP".
    /// </summary>
    [EnumMember(Value = "BAP")]
    [IsoId("_uiqEIPRYEeuLhpyIdtJzwg")]
    [Description(@"BA (Bosnia and Herzegovina).")]
    BosniaHerzegovina,
    
    /// <summary>
    /// SE (Sweden) - Sweden BGC Clearing CUG.
    /// Encoded/decoded by serializers as "BCC".
    /// </summary>
    [EnumMember(Value = "BCC")]
    [IsoId("_uiqEI_RYEeuLhpyIdtJzwg")]
    [Description(@"SE (Sweden) - Sweden BGC Clearing CUG.")]
    SwedenBGC,
    
    /// <summary>
    /// EC (Ecuador) - Ecuadorian Central Payment System (Sistema Central de Pagos Ecuatoriano)
    /// Encoded/decoded by serializers as "BCE".
    /// </summary>
    [EnumMember(Value = "BCE")]
    [IsoId("_uiz1IPRYEeuLhpyIdtJzwg")]
    [Description(@"EC (Ecuador) - Ecuadorian Central Payment System (Sistema Central de Pagos Ecuatoriano)")]
    Ecuador,
    
    /// <summary>
    /// BB (Barbados) - Barbados RTGS (CBRTGS).
    /// Encoded/decoded by serializers as "BDS".
    /// </summary>
    [EnumMember(Value = "BDS")]
    [IsoId("_uiz1I_RYEeuLhpyIdtJzwg")]
    [Description(@"BB (Barbados) - Barbados RTGS (CBRTGS).")]
    Barbados,
    
    /// <summary>
    /// BE (Belgium) - Belgium RTGS (ELLIPS).
    /// Encoded/decoded by serializers as "BEL".
    /// </summary>
    [EnumMember(Value = "BEL")]
    [IsoId("_uiz1JvRYEeuLhpyIdtJzwg")]
    [Description(@"BE (Belgium) - Belgium RTGS (ELLIPS).")]
    Belgium,
    
    /// <summary>
    /// BG (Bulgaria) - Bulgaria RTGS.
    /// Encoded/decoded by serializers as "BGN".
    /// </summary>
    [EnumMember(Value = "BGN")]
    [IsoId("_ui8_EPRYEeuLhpyIdtJzwg")]
    [Description(@"BG (Bulgaria) - Bulgaria RTGS.")]
    Bulgaria,
    
    /// <summary>
    /// BS (Bahamas) - Bahamas RTGS.
    /// Encoded/decoded by serializers as "BHS".
    /// </summary>
    [EnumMember(Value = "BHS")]
    [IsoId("_ui8_E_RYEeuLhpyIdtJzwg")]
    [Description(@"BS (Bahamas) - Bahamas RTGS.")]
    Bahamas,
    
    /// <summary>
    /// BW (Botswana) - Botswana Interbank Settlement System.
    /// Encoded/decoded by serializers as "BIS".
    /// </summary>
    [EnumMember(Value = "BIS")]
    [IsoId("_ujGwEPRYEeuLhpyIdtJzwg")]
    [Description(@"BW (Botswana) - Botswana Interbank Settlement System.")]
    Botswana,
    
    /// <summary>
    /// FI (Finland) - RTGS (BOF).
    /// Encoded/decoded by serializers as "BOF".
    /// </summary>
    [EnumMember(Value = "BOF")]
    [IsoId("_ujGwE_RYEeuLhpyIdtJzwg")]
    [Description(@"FI (Finland) - RTGS (BOF).")]
    Finland,
    
    /// <summary>
    /// the Bank of Japan clearing system.
    /// Encoded/decoded by serializers as "BOJ".
    /// </summary>
    [EnumMember(Value = "BOJ")]
    [IsoId("_ujGwFvRYEeuLhpyIdtJzwg")]
    [Description(@"the Bank of Japan clearing system.")]
    BankOfJapanNet,
    
    /// <summary>
    /// IT (Italy) - Italy RTGS (BIREL).
    /// Encoded/decoded by serializers as "BRL".
    /// </summary>
    [EnumMember(Value = "BRL")]
    [IsoId("_ujGwGfRYEeuLhpyIdtJzwg")]
    [Description(@"IT (Italy) - Italy RTGS (BIREL).")]
    Italy,
    
    /// <summary>
    /// PH (Philippines) - Philippines Payment System.
    /// Encoded/decoded by serializers as "BSP".
    /// </summary>
    [EnumMember(Value = "BSP")]
    [IsoId("_ujP6APRYEeuLhpyIdtJzwg")]
    [Description(@"PH (Philippines) - Philippines Payment System.")]
    Philippines,
    
    /// <summary>
    /// CA (Canada) - Canadian Large Value Transfer System (LVTS)
    /// Encoded/decoded by serializers as "CAD".
    /// </summary>
    [EnumMember(Value = "CAD")]
    [IsoId("_ujP6A_RYEeuLhpyIdtJzwg")]
    [Description(@"CA (Canada) - Canadian Large Value Transfer System (LVTS)")]
    CanadaCAD,
    
    /// <summary>
    /// ES (Spain).
    /// Encoded/decoded by serializers as "CAM".
    /// </summary>
    [EnumMember(Value = "CAM")]
    [IsoId("_ujZrAPRYEeuLhpyIdtJzwg")]
    [Description(@"ES (Spain).")]
    SpainCAM,
    
    /// <summary>
    /// AW (Aruba) - Central Bank of Aruba CSM
    /// Encoded/decoded by serializers as "CBA".
    /// </summary>
    [EnumMember(Value = "CBA")]
    [IsoId("_ujZrA_RYEeuLhpyIdtJzwg")]
    [Description(@"AW (Aruba) - Central Bank of Aruba CSM")]
    CentralBankOfArubaCSM,
    
    /// <summary>
    /// IE (Ireland) - Irish RTGS (IRIS).
    /// Encoded/decoded by serializers as "CBJ".
    /// </summary>
    [EnumMember(Value = "CBJ")]
    [IsoId("_ujjcAPRYEeuLhpyIdtJzwg")]
    [Description(@"IE (Ireland) - Irish RTGS (IRIS).")]
    Ireland,
    
    /// <summary>
    /// US - The Clearing House CHIPS
    /// Encoded/decoded by serializers as "CHI".
    /// </summary>
    [EnumMember(Value = "CHI")]
    [IsoId("_ujjcA_RYEeuLhpyIdtJzwg")]
    [Description(@"US - The Clearing House CHIPS")]
    USTCHChips,
    
    /// <summary>
    /// GB (UK) - British Euro RTGS (CHAPS).
    /// Encoded/decoded by serializers as "CHP".
    /// </summary>
    [EnumMember(Value = "CHP")]
    [IsoId("_ujjcBvRYEeuLhpyIdtJzwg")]
    [Description(@"GB (UK) - British Euro RTGS (CHAPS).")]
    UnitedKingdom,
    
    /// <summary>
    /// Central Interoperability Service of the EACHA Clearing Cooperative, for exchanging SEPA payments between Automated Clearing Houses in the EEA.
    /// Encoded/decoded by serializers as "CIS".
    /// </summary>
    [EnumMember(Value = "CIS")]
    [IsoId("_ujjcCfRYEeuLhpyIdtJzwg")]
    [Description(@"Central Interoperability Service of the EACHA Clearing Cooperative, for exchanging SEPA payments between Automated Clearing Houses in the EEA.")]
    CentralInteroperabilityService,
    
    /// <summary>
    /// Payments and cash management system that settles individual payments and cash transfers in central bank money.
    /// Encoded/decoded by serializers as "CLM".
    /// </summary>
    [EnumMember(Value = "CLM")]
    [IsoId("_ujjcDPRYEeuLhpyIdtJzwg")]
    [Description(@"Payments and cash management system that settles individual payments and cash transfers in central bank money.")]
    CentralLiquidityManagement,
    
    /// <summary>
    /// CO (Columbia) - Colombian Electronic Cheque System named CEDEC (Compensación Electrónica De Cheques).
    /// Encoded/decoded by serializers as "COE".
    /// </summary>
    [EnumMember(Value = "COE")]
    [IsoId("_ujsl8PRYEeuLhpyIdtJzwg")]
    [Description(@"CO (Columbia) - Colombian Electronic Cheque System named CEDEC (Compensación Electrónica De Cheques).")]
    ColumbiaCEDEC,
    
    /// <summary>
    /// CO (Columbia) - Colombian Central Bank´s ACH named CENIT (Compensación Electrónica Nacional Interbancaria).
    /// Encoded/decoded by serializers as "COI".
    /// </summary>
    [EnumMember(Value = "COI")]
    [IsoId("_ujsl8_RYEeuLhpyIdtJzwg")]
    [Description(@"CO (Columbia) - Colombian Central Bank´s ACH named CENIT (Compensación Electrónica Nacional Interbancaria).")]
    ColumbiaCENIT,
    
    /// <summary>
    /// CO (Columbia) - Colombian RTGS System named CUD (Cuentas de Depósito).
    /// Encoded/decoded by serializers as "COU".
    /// </summary>
    [EnumMember(Value = "COU")]
    [IsoId("_uj2W8PRYEeuLhpyIdtJzwg")]
    [Description(@"CO (Columbia) - Colombian RTGS System named CUD (Cuentas de Depósito).")]
    ColumbiaRTGS,
    
    /// <summary>
    /// DK (Denmark) - Danish Krone RTGS (KRONOS)
    /// Encoded/decoded by serializers as "DDK".
    /// </summary>
    [EnumMember(Value = "DDK")]
    [IsoId("_uj2W8_RYEeuLhpyIdtJzwg")]
    [Description(@"DK (Denmark) - Danish Krone RTGS (KRONOS)")]
    DenmarkDDK,
    
    /// <summary>
    /// DK (Denmark) - Danish Euro RTGS (KRONOS)
    /// Encoded/decoded by serializers as "DKC".
    /// </summary>
    [EnumMember(Value = "DKC")]
    [IsoId("_ukAH8PRYEeuLhpyIdtJzwg")]
    [Description(@"DK (Denmark) - Danish Euro RTGS (KRONOS)")]
    Denmark,
    
    /// <summary>
    /// EBA Euro1.
    /// Encoded/decoded by serializers as "EBA".
    /// </summary>
    [EnumMember(Value = "EBA")]
    [IsoId("_ukAH8_RYEeuLhpyIdtJzwg")]
    [Description(@"EBA Euro1.")]
    EBAEuro1,
    
    /// <summary>
    /// DE (Germany).
    /// Encoded/decoded by serializers as "ELS".
    /// </summary>
    [EnumMember(Value = "ELS")]
    [IsoId("_ukAH9vRYEeuLhpyIdtJzwg")]
    [Description(@"DE (Germany).")]
    GermanyELS,
    
    /// <summary>
    /// Elektronischer Massenzahlungsverkehr (EMZ)
    /// Encoded/decoded by serializers as "EMZ".
    /// </summary>
    [EnumMember(Value = "EMZ")]
    [IsoId("_ukAH-fRYEeuLhpyIdtJzwg")]
    [Description(@"Elektronischer Massenzahlungsverkehr (EMZ)")]
    Germany,
    
    /// <summary>
    /// ECB (European Central Bank) - ECB Payment Mechanism.
    /// Encoded/decoded by serializers as "EPM".
    /// </summary>
    [EnumMember(Value = "EPM")]
    [IsoId("_ukAH_PRYEeuLhpyIdtJzwg")]
    [Description(@"ECB (European Central Bank) - ECB Payment Mechanism.")]
    ECB,
    
    /// <summary>
    /// US - The Clearing House EPN
    /// Encoded/decoded by serializers as "EPN".
    /// </summary>
    [EnumMember(Value = "EPN")]
    [IsoId("_ukJR4PRYEeuLhpyIdtJzwg")]
    [Description(@"US - The Clearing House EPN")]
    USTCHEPN,
    
    /// <summary>
    /// EBA step 1 (members).
    /// Encoded/decoded by serializers as "ERP".
    /// </summary>
    [EnumMember(Value = "ERP")]
    [IsoId("_ukJR4_RYEeuLhpyIdtJzwg")]
    [Description(@"EBA step 1 (members).")]
    EBAStep1,
    
    /// <summary>
    /// US (United States) - FED-ACH
    /// Encoded/decoded by serializers as "FDA".
    /// </summary>
    [EnumMember(Value = "FDA")]
    [IsoId("_ukTC4PRYEeuLhpyIdtJzwg")]
    [Description(@"US (United States) - FED-ACH")]
    USFedACH,
    
    /// <summary>
    /// FedNet is a link to a Federal Bank account via the internet.  FedNet enables checking of account balance, transactions, take print outs of account statement, transfer funds to third party accounts, E-shopping, BSNL Payments, Deposit opening, Deposit Renewal, Request for Demand Draft, Cheque Book etc.
    /// Encoded/decoded by serializers as "FDN".
    /// </summary>
    [EnumMember(Value = "FDN")]
    [IsoId("_ukTC4_RYEeuLhpyIdtJzwg")]
    [Description(@"FedNet is a link to a Federal Bank account via the internet.  FedNet enables checking of account balance, transactions, take print outs of account statement, transfer funds to third party accounts, E-shopping, BSNL Payments, Deposit opening, Deposit Renewal, Request for Demand Draft, Cheque Book etc.")]
    FedNet,
    
    /// <summary>
    /// US (United States) – FEDWIRE
    /// Encoded/decoded by serializers as "FDW".
    /// </summary>
    [EnumMember(Value = "FDW")]
    [IsoId("_ukTC5vRYEeuLhpyIdtJzwg")]
    [Description(@"US (United States) – FEDWIRE")]
    USFedwire,
    
    /// <summary>
    /// JP (Japan) the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank.
    /// Encoded/decoded by serializers as "FEY".
    /// </summary>
    [EnumMember(Value = "FEY")]
    [IsoId("_ukTC6fRYEeuLhpyIdtJzwg")]
    [Description(@"JP (Japan) the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank.")]
    ForeignExchangeYenClearing,
    
    /// <summary>
    /// GH (Ghana) - Ghana Interbank Settlement System (GISS).
    /// Encoded/decoded by serializers as "GIS".
    /// </summary>
    [EnumMember(Value = "GIS")]
    [IsoId("_ukTC7PRYEeuLhpyIdtJzwg")]
    [Description(@"GH (Ghana) - Ghana Interbank Settlement System (GISS).")]
    Ghana,
    
    /// <summary>
    /// HR (Croatia) - HSVP.
    /// Encoded/decoded by serializers as "HRK".
    /// </summary>
    [EnumMember(Value = "HRK")]
    [IsoId("_ukcz4PRYEeuLhpyIdtJzwg")]
    [Description(@"HR (Croatia) - HSVP.")]
    Croatia,
    
    /// <summary>
    /// GR (Greece) - Greek RTGS (HERMES).
    /// Encoded/decoded by serializers as "HRM".
    /// </summary>
    [EnumMember(Value = "HRM")]
    [IsoId("_ukcz4_RYEeuLhpyIdtJzwg")]
    [Description(@"GR (Greece) - Greek RTGS (HERMES).")]
    Greece,
    
    /// <summary>
    /// HU (Hungary) - VIBER.
    /// Encoded/decoded by serializers as "HUF".
    /// </summary>
    [EnumMember(Value = "HUF")]
    [IsoId("_ukcz5vRYEeuLhpyIdtJzwg")]
    [Description(@"HU (Hungary) - VIBER.")]
    Hungary,
    
    /// <summary>
    /// DE and NL - Equens 
    /// Encoded/decoded by serializers as "INC".
    /// </summary>
    [EnumMember(Value = "INC")]
    [IsoId("_ukcz6fRYEeuLhpyIdtJzwg")]
    [Description(@"DE and NL - Equens ")]
    DEandNLEquens,
    
    /// <summary>
    /// JO (Jordan) - Jordan RTGS.
    /// Encoded/decoded by serializers as "JOD".
    /// </summary>
    [EnumMember(Value = "JOD")]
    [IsoId("_ukcz7PRYEeuLhpyIdtJzwg")]
    [Description(@"JO (Jordan) - Jordan RTGS.")]
    Jordan,
    
    /// <summary>
    /// KE (Kenya) - Kenyan Electronic Payment Settlement System.
    /// Encoded/decoded by serializers as "KPS".
    /// </summary>
    [EnumMember(Value = "KPS")]
    [IsoId("_ukl90PRYEeuLhpyIdtJzwg")]
    [Description(@"KE (Kenya) - Kenyan Electronic Payment Settlement System.")]
    Kenya,
    
    /// <summary>
    /// LU (Luxemburg) - Luxembourg RTGS (LIPS).
    /// Encoded/decoded by serializers as "LGS".
    /// </summary>
    [EnumMember(Value = "LGS")]
    [IsoId("_ukl90_RYEeuLhpyIdtJzwg")]
    [Description(@"LU (Luxemburg) - Luxembourg RTGS (LIPS).")]
    Luxemburg,
    
    /// <summary>
    /// LK (Sri Lanka) - Sri Lanka (Lankasettle).
    /// Encoded/decoded by serializers as "LKB".
    /// </summary>
    [EnumMember(Value = "LKB")]
    [IsoId("_ukvu0PRYEeuLhpyIdtJzwg")]
    [Description(@"LK (Sri Lanka) - Sri Lanka (Lankasettle).")]
    SriLanka,
    
    /// <summary>
    /// LV (Latvia).
    /// Encoded/decoded by serializers as "LVL".
    /// </summary>
    [EnumMember(Value = "LVL")]
    [IsoId("_ukvu0_RYEeuLhpyIdtJzwg")]
    [Description(@"LV (Latvia).")]
    Latvia,
    
    /// <summary>
    /// CA (Canada) - Large Value Transfer System (LVTS).  Replaces CAD.
    /// Encoded/decoded by serializers as "LVT".
    /// </summary>
    [EnumMember(Value = "LVT")]
    [IsoId("_ukvu1vRYEeuLhpyIdtJzwg")]
    [Description(@"CA (Canada) - Large Value Transfer System (LVTS).  Replaces CAD.")]
    CanadaLVTS,
    
    /// <summary>
    /// SG (Singapore) - Singapore RTGS (MEPS+).
    /// Encoded/decoded by serializers as "MEP".
    /// </summary>
    [EnumMember(Value = "MEP")]
    [IsoId("_ukvu2fRYEeuLhpyIdtJzwg")]
    [Description(@"SG (Singapore) - Singapore RTGS (MEPS+).")]
    Singapore,
    
    /// <summary>
    /// ZA (South Africa) - South-African Multiple Option Settlement.
    /// Encoded/decoded by serializers as "MOS".
    /// </summary>
    [EnumMember(Value = "MOS")]
    [IsoId("_ukvu3PRYEeuLhpyIdtJzwg")]
    [Description(@"ZA (South Africa) - South-African Multiple Option Settlement.")]
    SouthAfrica,
    
    /// <summary>
    /// MT (Malta) - Malta Realtime Interbank Settlement System.
    /// Encoded/decoded by serializers as "MRS".
    /// </summary>
    [EnumMember(Value = "MRS")]
    [IsoId("_uk44wPRYEeuLhpyIdtJzwg")]
    [Description(@"MT (Malta) - Malta Realtime Interbank Settlement System.")]
    Malta,
    
    /// <summary>
    /// MU (Mauritius).
    /// Encoded/decoded by serializers as "MUP".
    /// </summary>
    [EnumMember(Value = "MUP")]
    [IsoId("_uk44w_RYEeuLhpyIdtJzwg")]
    [Description(@"MU (Mauritius).")]
    Mauritius,
    
    /// <summary>
    /// NA (Namibian) - Namibian Interbank Settlement System.
    /// Encoded/decoded by serializers as "NAM".
    /// </summary>
    [EnumMember(Value = "NAM")]
    [IsoId("_ulCpwPRYEeuLhpyIdtJzwg")]
    [Description(@"NA (Namibian) - Namibian Interbank Settlement System.")]
    Namibia,
    
    /// <summary>
    /// NO (Norway).
    /// Encoded/decoded by serializers as "NOC".
    /// </summary>
    [EnumMember(Value = "NOC")]
    [IsoId("_ulCpw_RYEeuLhpyIdtJzwg")]
    [Description(@"NO (Norway).")]
    Norway,
    
    /// <summary>
    /// AU (Australia) - New Payments Platform (NPP)
    /// Encoded/decoded by serializers as "NPP".
    /// </summary>
    [EnumMember(Value = "NPP")]
    [IsoId("_ulLzsPRYEeuLhpyIdtJzwg")]
    [Description(@"AU (Australia) - New Payments Platform (NPP)")]
    AustraliaNPP,
    
    /// <summary>
    /// CH (Switzerland).
    /// Encoded/decoded by serializers as "PCH".
    /// </summary>
    [EnumMember(Value = "PCH")]
    [IsoId("_ulLzs_RYEeuLhpyIdtJzwg")]
    [Description(@"CH (Switzerland).")]
    Switzerland,
    
    /// <summary>
    /// AU (Australia).
    /// Encoded/decoded by serializers as "PDS".
    /// </summary>
    [EnumMember(Value = "PDS")]
    [IsoId("_ulLztvRYEeuLhpyIdtJzwg")]
    [Description(@"AU (Australia).")]
    AustraliaPDS,
    
    /// <summary>
    /// EG (Egypt).
    /// Encoded/decoded by serializers as "PEG".
    /// </summary>
    [EnumMember(Value = "PEG")]
    [IsoId("_ulVksPRYEeuLhpyIdtJzwg")]
    [Description(@"EG (Egypt).")]
    Egypt,
    
    /// <summary>
    /// FR (France).
    /// Encoded/decoded by serializers as "PNS".
    /// </summary>
    [EnumMember(Value = "PNS")]
    [IsoId("_ulVks_RYEeuLhpyIdtJzwg")]
    [Description(@"FR (France).")]
    FrancePNS,
    
    /// <summary>
    /// AO (Angola) - Angola RTGS.
    /// Encoded/decoded by serializers as "PTR".
    /// </summary>
    [EnumMember(Value = "PTR")]
    [IsoId("_ulVktvRYEeuLhpyIdtJzwg")]
    [Description(@"AO (Angola) - Angola RTGS.")]
    Angola,
    
    /// <summary>
    /// Ve (Venezuela).
    /// Encoded/decoded by serializers as "PVE".
    /// </summary>
    [EnumMember(Value = "PVE")]
    [IsoId("_ulVkufRYEeuLhpyIdtJzwg")]
    [Description(@"Ve (Venezuela).")]
    Venezuela,
    
    /// <summary>
    /// RO (Romania) - Romanian Electronic Payment Operations RT.
    /// Encoded/decoded by serializers as "ROL".
    /// </summary>
    [EnumMember(Value = "ROL")]
    [IsoId("_ulfVsPRYEeuLhpyIdtJzwg")]
    [Description(@"RO (Romania) - Romanian Electronic Payment Operations RT.")]
    RomaniaEPO,
    
    /// <summary>
    /// RO (Romania) - Romanian GSRS.
    /// Encoded/decoded by serializers as "ROS".
    /// </summary>
    [EnumMember(Value = "ROS")]
    [IsoId("_ulfVs_RYEeuLhpyIdtJzwg")]
    [Description(@"RO (Romania) - Romanian GSRS.")]
    RomaniaGSRS,
    
    /// <summary>
    /// Real Time Gross Settlement System. Payment system that simultaneously clears individual transfers and settles them in central bank money.
    /// Encoded/decoded by serializers as "RTG".
    /// </summary>
    [EnumMember(Value = "RTG")]
    [IsoId("_ulfVtvRYEeuLhpyIdtJzwg")]
    [Description(@"Real Time Gross Settlement System. Payment system that simultaneously clears individual transfers and settles them in central bank money.")]
    RTGS,
    
    /// <summary>
    /// DE (Germany).
    /// Encoded/decoded by serializers as "RTP".
    /// </summary>
    [EnumMember(Value = "RTP")]
    [IsoId("_ulpGsPRYEeuLhpyIdtJzwg")]
    [Description(@"DE (Germany).")]
    GermanyRTGSPlus,
    
    /// <summary>
    /// DE – SEPA-Clearer of the Retail Payment System operated by Deutsche Bundesbank
    /// Encoded/decoded by serializers as "SCL".
    /// </summary>
    [EnumMember(Value = "SCL")]
    [IsoId("_ulpGs_RYEeuLhpyIdtJzwg")]
    [Description(@"DE – SEPA-Clearer of the Retail Payment System operated by Deutsche Bundesbank")]
    RPSAndSEPAClearer,
    
    /// <summary>
    /// CL (Chile) - Chilean Interbank Payment System.
    /// Encoded/decoded by serializers as "SCP".
    /// </summary>
    [EnumMember(Value = "SCP")]
    [IsoId("_ulpGtvRYEeuLhpyIdtJzwg")]
    [Description(@"CL (Chile) - Chilean Interbank Payment System.")]
    Chili,
    
    /// <summary>
    /// SE (Sweden) - Swedish Euro RTGS (SEC).
    /// Encoded/decoded by serializers as "SEC".
    /// </summary>
    [EnumMember(Value = "SEC")]
    [IsoId("_ulpGufRYEeuLhpyIdtJzwg")]
    [Description(@"SE (Sweden) - Swedish Euro RTGS (SEC).")]
    SwedenSEC,
    
    /// <summary>
    /// CH (Switzerland) – Swiss EUR RTGS named euroSIC.
    /// Encoded/decoded by serializers as "SEU".
    /// </summary>
    [EnumMember(Value = "SEU")]
    [IsoId("_ulyQoPRYEeuLhpyIdtJzwg")]
    [Description(@"CH (Switzerland) – Swiss EUR RTGS named euroSIC.")]
    euroSIC,
    
    /// <summary>
    /// CH (Switzerland) – Swiss CHF RTGS named SIC.
    /// Encoded/decoded by serializers as "SIC".
    /// </summary>
    [EnumMember(Value = "SIC")]
    [IsoId("_ulyQo_RYEeuLhpyIdtJzwg")]
    [Description(@"CH (Switzerland) – Swiss CHF RTGS named SIC.")]
    SIC,
    
    /// <summary>
    /// CH (Switzerland) – Swiss Instant Payment service in CHF operated by SIX Interbank Clearing.
    /// Encoded/decoded by serializers as "SIP".
    /// </summary>
    [EnumMember(Value = "SIP")]
    [IsoId("_ulyQpvRYEeuLhpyIdtJzwg")]
    [Description(@"CH (Switzerland) – Swiss Instant Payment service in CHF operated by SIX Interbank Clearing.")]
    SICIP,
    
    /// <summary>
    /// SI (Slovenia).
    /// Encoded/decoded by serializers as "SIT".
    /// </summary>
    [EnumMember(Value = "SIT")]
    [IsoId("_ulyQqfRYEeuLhpyIdtJzwg")]
    [Description(@"SI (Slovenia).")]
    Slovania,
    
    /// <summary>
    /// ES (Spain) - Spanish RTGS (SLBE).
    /// Encoded/decoded by serializers as "SLB".
    /// </summary>
    [EnumMember(Value = "SLB")]
    [IsoId("_ul8BoPRYEeuLhpyIdtJzwg")]
    [Description(@"ES (Spain) - Spanish RTGS (SLBE).")]
    SpainES,
    
    /// <summary>
    /// PT (Portugal) - Portuguese RTGS (SPGT).
    /// Encoded/decoded by serializers as "SPG".
    /// </summary>
    [EnumMember(Value = "SPG")]
    [IsoId("_ul8Bo_RYEeuLhpyIdtJzwg")]
    [Description(@"PT (Portugal) - Portuguese RTGS (SPGT).")]
    Portugal,
    
    /// <summary>
    /// SE (Sweden) - SEK RTGS (RIX).
    /// Encoded/decoded by serializers as "SSK".
    /// </summary>
    [EnumMember(Value = "SSK")]
    [IsoId("_ul8BpvRYEeuLhpyIdtJzwg")]
    [Description(@"SE (Sweden) - SEK RTGS (RIX).")]
    SwedenSSK,
    
    /// <summary>
    /// EBA Clearing STEP 2.
    /// Encoded/decoded by serializers as "ST2".
    /// </summary>
    [EnumMember(Value = "ST2")]
    [IsoId("_ul8BqfRYEeuLhpyIdtJzwg")]
    [Description(@"EBA Clearing STEP 2.")]
    EBAClearingStep2,
    
    /// <summary>
    /// UK (United Kingdom) - CHAPS Sterling RTGS.
    /// Encoded/decoded by serializers as "STG".
    /// </summary>
    [EnumMember(Value = "STG")]
    [IsoId("_ul8BrPRYEeuLhpyIdtJzwg")]
    [Description(@"UK (United Kingdom) - CHAPS Sterling RTGS.")]
    UnitedKingdomGBP,
    
    /// <summary>
    /// T2S.
    /// Encoded/decoded by serializers as "T2S".
    /// </summary>
    [EnumMember(Value = "T2S")]
    [IsoId("_ul8Br_RYEeuLhpyIdtJzwg")]
    [Description(@"T2S.")]
    T2S,
    
    /// <summary>
    /// FR (France) - French RTGS (TBF).
    /// Encoded/decoded by serializers as "TBF".
    /// </summary>
    [EnumMember(Value = "TBF")]
    [IsoId("_umFLkPRYEeuLhpyIdtJzwg")]
    [Description(@"FR (France) - French RTGS (TBF).")]
    FranceFR,
    
    /// <summary>
    /// US - The Clearing House Real-TimePayment System
    /// Encoded/decoded by serializers as "TCH".
    /// </summary>
    [EnumMember(Value = "TCH")]
    [IsoId("_umFLk_RYEeuLhpyIdtJzwg")]
    [Description(@"US - The Clearing House Real-TimePayment System")]
    USTCHRealTime,
    
    /// <summary>
    /// Target.
    /// Encoded/decoded by serializers as "TGT".
    /// </summary>
    [EnumMember(Value = "TGT")]
    [IsoId("_umO8kPRYEeuLhpyIdtJzwg")]
    [Description(@"Target.")]
    Target,
    
    /// <summary>
    /// TH (Thailand) - Thailand Payment System (BAHTNET).
    /// Encoded/decoded by serializers as "THB".
    /// </summary>
    [EnumMember(Value = "THB")]
    [IsoId("_umO8k_RYEeuLhpyIdtJzwg")]
    [Description(@"TH (Thailand) - Thailand Payment System (BAHTNET).")]
    Thailand,
    
    /// <summary>
    /// TH (Thailand) - National ITMX Payment System
    /// Encoded/decoded by serializers as "THN".
    /// </summary>
    [EnumMember(Value = "THN")]
    [IsoId("_umO8lvRYEeuLhpyIdtJzwg")]
    [Description(@"TH (Thailand) - National ITMX Payment System")]
    ThailandNITMX,
    
    /// <summary>
    /// TZ (Tanzania) - Tanzania Interbank Settlement System (TISS).
    /// Encoded/decoded by serializers as "TIS".
    /// </summary>
    [EnumMember(Value = "TIS")]
    [IsoId("_umO8mfRYEeuLhpyIdtJzwg")]
    [Description(@"TZ (Tanzania) - Tanzania Interbank Settlement System (TISS).")]
    Tanzania,
    
    /// <summary>
    /// NL (Netherlands) - Dutch RTGS (TOP) 
    /// Encoded/decoded by serializers as "TOP".
    /// </summary>
    [EnumMember(Value = "TOP")]
    [IsoId("_umO8nPRYEeuLhpyIdtJzwg")]
    [Description(@"NL (Netherlands) - Dutch RTGS (TOP) ")]
    Netherlands,
    
    /// <summary>
    /// TT (Trinidad and Tobago ) - Trinidad and Tobago SAFE-TT.
    /// Encoded/decoded by serializers as "TTD".
    /// </summary>
    [EnumMember(Value = "TTD")]
    [IsoId("_umYtkPRYEeuLhpyIdtJzwg")]
    [Description(@"TT (Trinidad and Tobago ) - Trinidad and Tobago SAFE-TT.")]
    TrinidadAndTobago,
    
    /// <summary>
    /// United States Dollar  (USD)
    /// Encoded/decoded by serializers as "UBE".
    /// </summary>
    [EnumMember(Value = "UBE")]
    [IsoId("_umYtk_RYEeuLhpyIdtJzwg")]
    [Description(@"United States Dollar  (USD)")]
    CanadaUSDUSBE,
    
    /// <summary>
    /// UG (Uganda) - Uganda National Interbank Settlement System.
    /// Encoded/decoded by serializers as "UIS".
    /// </summary>
    [EnumMember(Value = "UIS")]
    [IsoId("_umYtlvRYEeuLhpyIdtJzwg")]
    [Description(@"UG (Uganda) - Uganda National Interbank Settlement System.")]
    Uganda,
    
    /// <summary>
    /// VocaLink Clearing System
    /// Encoded/decoded by serializers as "VCS".
    /// </summary>
    [EnumMember(Value = "VCS")]
    [IsoId("_umYtmfRYEeuLhpyIdtJzwg")]
    [Description(@"VocaLink Clearing System")]
    VocaLink,
    
    /// <summary>
    /// EBA step 2.
    /// Encoded/decoded by serializers as "XCT".
    /// </summary>
    [EnumMember(Value = "XCT")]
    [IsoId("_umYtnPRYEeuLhpyIdtJzwg")]
    [Description(@"EBA step 2.")]
    EBAStep2XCT,
    
    /// <summary>
    /// JP (Japan) the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association.
    /// Encoded/decoded by serializers as "ZEN".
    /// </summary>
    [EnumMember(Value = "ZEN")]
    [IsoId("_umh3gPRYEeuLhpyIdtJzwg")]
    [Description(@"JP (Japan) the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association.")]
    Zengin,
    
    /// <summary>
    /// ZW (Zimbabwe) - Zimbabwe Electronic Transfer & Settlement System.
    /// Encoded/decoded by serializers as "ZET".
    /// </summary>
    [EnumMember(Value = "ZET")]
    [IsoId("_umh3g_RYEeuLhpyIdtJzwg")]
    [Description(@"ZW (Zimbabwe) - Zimbabwe Electronic Transfer & Settlement System.")]
    Zimbabwe,
    
    /// <summary>
    /// ZM (Zambia) - Zambian Interbank Payment &Settlement System.
    /// Encoded/decoded by serializers as "ZIS".
    /// </summary>
    [EnumMember(Value = "ZIS")]
    [IsoId("_umh3hvRYEeuLhpyIdtJzwg")]
    [Description(@"ZM (Zambia) - Zambian Interbank Payment &Settlement System.")]
    Zambia,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalMarketInfrastructureCodeMetadataExtensions
{
    private static readonly ExternalMarketInfrastructureCodeDropdownSource _dropdownSource = new ExternalMarketInfrastructureCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalMarketInfrastructureCodeDropdownRow GetMetadata(this ExternalMarketInfrastructureCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


