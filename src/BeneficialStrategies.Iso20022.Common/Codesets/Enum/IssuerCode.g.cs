﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for IssuerCode.  ISO2002 ID# _VsEwBdp-Ed-ak6NoX_4Aeg_335333174.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the institution issuing a proprietary code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VsEwBdp-Ed-ak6NoX_4Aeg_335333174")]
[Description(@"Identifies the institution issuing a proprietary code.")]
[Derivations(typeof(PartyIssuerCode))]
public enum IssuerCode
{
    /// <summary>
    /// Based in Luxembourg, the holding, clearing and settlement agency for certain international securities, especially Eurobonds.
    /// Encoded/decoded by serializers as "CEDE".
    /// </summary>
    [EnumMember(Value = "CEDE")]
    [IsoId("_VsEwBtp-Ed-ak6NoX_4Aeg_335333183")]
    [Description(@"Based in Luxembourg, the holding, clearing and settlement agency for certain international securities, especially Eurobonds.")]
    ClearstreamBankLuxemburg,
    
    /// <summary>
    /// Caja de Valores S.A.
    /// Encoded/decoded by serializers as "CAVL".
    /// </summary>
    [EnumMember(Value = "CAVL")]
    [IsoId("_VsEwB9p-Ed-ak6NoX_4Aeg_335333184")]
    [Description(@"Caja de Valores S.A.")]
    CajaDeValores,
    
    /// <summary>
    /// Austraclear Limited.
    /// Encoded/decoded by serializers as "ACLR".
    /// </summary>
    [EnumMember(Value = "ACLR")]
    [IsoId("_VsEwCNp-Ed-ak6NoX_4Aeg_335333185")]
    [Description(@"Austraclear Limited.")]
    AustraclearLtd,
    
    /// <summary>
    /// Australian Bank State Branch Code.
    /// Encoded/decoded by serializers as "AUAU".
    /// </summary>
    [EnumMember(Value = "AUAU")]
    [IsoId("_VsN58Np-Ed-ak6NoX_4Aeg_335333186")]
    [Description(@"Australian Bank State Branch Code.")]
    AustralianBankStateBranch,
    
    /// <summary>
    /// Clearing House Electronic Settlements Systems.
    /// Encoded/decoded by serializers as "CHES".
    /// </summary>
    [EnumMember(Value = "CHES")]
    [IsoId("_VsN58dp-Ed-ak6NoX_4Aeg_335333187")]
    [Description(@"Clearing House Electronic Settlements Systems.")]
    ClearingHouseElectronicSettlementSystems,
    
    /// <summary>
    /// Austrian Bankleitzahl.
    /// Encoded/decoded by serializers as "ATAT".
    /// </summary>
    [EnumMember(Value = "ATAT")]
    [IsoId("_VsN58tp-Ed-ak6NoX_4Aeg_335333188")]
    [Description(@"Austrian Bankleitzahl.")]
    AustrianBankLeitzahl,
    
    /// <summary>
    /// OKB - Oesterreichische Kontrollbank AG.
    /// Encoded/decoded by serializers as "OEKO".
    /// </summary>
    [EnumMember(Value = "OEKO")]
    [IsoId("_VsN589p-Ed-ak6NoX_4Aeg_335333189")]
    [Description(@"OKB - Oesterreichische Kontrollbank AG.")]
    OesterreichischeKontrollbank,
    
    /// <summary>
    /// CIK - Caisse Interprofessionelle de Depots et de Virements de Titres S.A.
    /// Encoded/decoded by serializers as "CIKB".
    /// </summary>
    [EnumMember(Value = "CIKB")]
    [IsoId("_VsN59Np-Ed-ak6NoX_4Aeg_335333190")]
    [Description(@"CIK - Caisse Interprofessionelle de Depots et de Virements de Titres S.A.")]
    CaisseInterprofessionelleDepotsVirementsTitres,
    
    /// <summary>
    /// Euroclear.
    /// Encoded/decoded by serializers as "EOCC".
    /// </summary>
    [EnumMember(Value = "EOCC")]
    [IsoId("_VsN59dp-Ed-ak6NoX_4Aeg_335333191")]
    [Description(@"Euroclear.")]
    Euroclear,
    
    /// <summary>
    /// Banque Nationale de Belgique.
    /// Encoded/decoded by serializers as "NBBE".
    /// </summary>
    [EnumMember(Value = "NBBE")]
    [IsoId("_VsN59tp-Ed-ak6NoX_4Aeg_335333192")]
    [Description(@"Banque Nationale de Belgique.")]
    BanqueNationaleDeBelgique,
    
    /// <summary>
    /// CLC - Camara de Liquidacao e Custodia S.A. (Brazil).
    /// Encoded/decoded by serializers as "CLCB".
    /// </summary>
    [EnumMember(Value = "CLCB")]
    [IsoId("_VsN599p-Ed-ak6NoX_4Aeg_335333200")]
    [Description(@"CLC - Camara de Liquidacao e Custodia S.A. (Brazil).")]
    CamaraLiquidacaoCustodia,
    
    /// <summary>
    /// CDS - Canadian Depository for Securities Limited.
    /// Encoded/decoded by serializers as "CDSL".
    /// </summary>
    [EnumMember(Value = "CDSL")]
    [IsoId("_VsN5-Np-Ed-ak6NoX_4Aeg_335333201")]
    [Description(@"CDS - Canadian Depository for Securities Limited.")]
    CanadianDepositorySecuritiesLtd,
    
    /// <summary>
    /// Canadian Payments Association Payment Routing Number.
    /// Encoded/decoded by serializers as "CACC".
    /// </summary>
    [EnumMember(Value = "CACC")]
    [IsoId("_VsN5-dp-Ed-ak6NoX_4Aeg_335333202")]
    [Description(@"Canadian Payments Association Payment Routing Number.")]
    CanadianPaymentsAssociation,
    
    /// <summary>
    /// Chile Central Securities Depository Deposito Central de Valores.
    /// Encoded/decoded by serializers as "CSDD".
    /// </summary>
    [EnumMember(Value = "CSDD")]
    [IsoId("_VsN5-tp-Ed-ak6NoX_4Aeg_335333203")]
    [Description(@"Chile Central Securities Depository Deposito Central de Valores.")]
    CentralSecuritiesDepositoryDepositoCentralValores,
    
    /// <summary>
    /// Shanghai Securities Central Clearing & Registration Company.
    /// Encoded/decoded by serializers as "SCRC".
    /// </summary>
    [EnumMember(Value = "SCRC")]
    [IsoId("_VsXq8Np-Ed-ak6NoX_4Aeg_335333204")]
    [Description(@"Shanghai Securities Central Clearing & Registration Company.")]
    ShanghaiSecuritiesCentralClearingRegistrationCompany,
    
    /// <summary>
    /// Shenzhen Securities Clearing Company.
    /// Encoded/decoded by serializers as "SSCC".
    /// </summary>
    [EnumMember(Value = "SSCC")]
    [IsoId("_VsXq8dp-Ed-ak6NoX_4Aeg_335333205")]
    [Description(@"Shenzhen Securities Clearing Company.")]
    ShenzhenSecuritiesClearingCompany,
    
    /// <summary>
    /// Colombia Central Depository System.
    /// Encoded/decoded by serializers as "CDSY".
    /// </summary>
    [EnumMember(Value = "CDSY")]
    [IsoId("_VsXq8tp-Ed-ak6NoX_4Aeg_335333214")]
    [Description(@"Colombia Central Depository System.")]
    ColombiaCentralDepositorySystem,
    
    /// <summary>
    /// Denmark Vaerdipapircentralen.
    /// Encoded/decoded by serializers as "VPDK".
    /// </summary>
    [EnumMember(Value = "VPDK")]
    [IsoId("_VsXq89p-Ed-ak6NoX_4Aeg_335333215")]
    [Description(@"Denmark Vaerdipapircentralen.")]
    DenmarkVaerdipapircentralen,
    
    /// <summary>
    /// Finnish Central Securities Depository Limited.
    /// Encoded/decoded by serializers as "APKE".
    /// </summary>
    [EnumMember(Value = "APKE")]
    [IsoId("_VsXq9Np-Ed-ak6NoX_4Aeg_335333216")]
    [Description(@"Finnish Central Securities Depository Limited.")]
    FinnishCentralSecuritiesDepositoryLtd,
    
    /// <summary>
    /// French R.I.B.
    /// Encoded/decoded by serializers as "FRRI".
    /// </summary>
    [EnumMember(Value = "FRRI")]
    [IsoId("_VsXq9dp-Ed-ak6NoX_4Aeg_335333217")]
    [Description(@"French R.I.B.")]
    FranceRIB,
    
    /// <summary>
    /// Societe Interprofessional Pour La Compensation des Valeurs Mobiliers in France.
    /// Encoded/decoded by serializers as "SICV".
    /// </summary>
    [EnumMember(Value = "SICV")]
    [IsoId("_VsXq9tp-Ed-ak6NoX_4Aeg_335333218")]
    [Description(@"Societe Interprofessional Pour La Compensation des Valeurs Mobiliers in France.")]
    SICOVAM,
    
    /// <summary>
    /// The Prague Stock Exchange.
    /// Encoded/decoded by serializers as "XPRA".
    /// </summary>
    [EnumMember(Value = "XPRA")]
    [IsoId("_VsXq99p-Ed-ak6NoX_4Aeg_335333219")]
    [Description(@"The Prague Stock Exchange.")]
    PragueStockExchange,
    
    /// <summary>
    /// Bundesausichtsamt fur den Wertpapierhandel.
    /// Encoded/decoded by serializers as "BUWE".
    /// </summary>
    [EnumMember(Value = "BUWE")]
    [IsoId("_Vsg04Np-Ed-ak6NoX_4Aeg_335333220")]
    [Description(@"Bundesausichtsamt fur den Wertpapierhandel.")]
    BundesausichtsamtWertpapierhandel,
    
    /// <summary>
    /// Deutsche Boerse AG: Deutsche Terminborse.
    /// Encoded/decoded by serializers as "XDTB".
    /// </summary>
    [EnumMember(Value = "XDTB")]
    [IsoId("_Vsg04dp-Ed-ak6NoX_4Aeg_335333221")]
    [Description(@"Deutsche Boerse AG: Deutsche Terminborse.")]
    DeutscheBoerseAGDeutscheTerminborse,
    
    /// <summary>
    /// Deutsche Boerse AG: Frankfurter Wertpapierborse.
    /// Encoded/decoded by serializers as "XFRA".
    /// </summary>
    [EnumMember(Value = "XFRA")]
    [IsoId("_Vsg04tp-Ed-ak6NoX_4Aeg_335333222")]
    [Description(@"Deutsche Boerse AG: Frankfurter Wertpapierborse.")]
    DeutscheBoerseAGFrankfurterWertpapierborse,
    
    /// <summary>
    /// Deutsche Boerse AG: XETRA (exchange electronic trading).
    /// Encoded/decoded by serializers as "XETR".
    /// </summary>
    [EnumMember(Value = "XETR")]
    [IsoId("_Vsg049p-Ed-ak6NoX_4Aeg_335333223")]
    [Description(@"Deutsche Boerse AG: XETRA (exchange electronic trading).")]
    DeutscheBoerseAGXETRA,
    
    /// <summary>
    /// Deutsche Borse Clearing AG.
    /// Encoded/decoded by serializers as "DAKV".
    /// </summary>
    [EnumMember(Value = "DAKV")]
    [IsoId("_Vsg05Np-Ed-ak6NoX_4Aeg_335333231")]
    [Description(@"Deutsche Borse Clearing AG.")]
    DeutscheBorseClearingAG,
    
    /// <summary>
    /// Deutsche Bundesbank.
    /// Encoded/decoded by serializers as "MARK".
    /// </summary>
    [EnumMember(Value = "MARK")]
    [IsoId("_Vsg05dp-Ed-ak6NoX_4Aeg_335333232")]
    [Description(@"Deutsche Bundesbank.")]
    DeutscheBundesbank,
    
    /// <summary>
    /// German Bankleitzahl.
    /// Encoded/decoded by serializers as "DEBL".
    /// </summary>
    [EnumMember(Value = "DEBL")]
    [IsoId("_Vsg05tp-Ed-ak6NoX_4Aeg_335333233")]
    [Description(@"German Bankleitzahl.")]
    GermanBankleitzahl,
    
    /// <summary>
    /// Zentraler Kreditausschuss.
    /// Encoded/decoded by serializers as "ZEKR".
    /// </summary>
    [EnumMember(Value = "ZEKR")]
    [IsoId("_Vsg059p-Ed-ak6NoX_4Aeg_335333234")]
    [Description(@"Zentraler Kreditausschuss.")]
    ZentralerKreditausschuss,
    
    /// <summary>
    /// Hong KongCentral Clearing and Securities Settlement System.
    /// Encoded/decoded by serializers as "CCAS".
    /// </summary>
    [EnumMember(Value = "CCAS")]
    [IsoId("_Vsg06Np-Ed-ak6NoX_4Aeg_335333235")]
    [Description(@"Hong KongCentral Clearing and Securities Settlement System.")]
    HongKongCentralClearingSecuritiesSettlementSystem,
    
    /// <summary>
    /// Hong Kong National Clearing System.
    /// Encoded/decoded by serializers as "HKCH".
    /// </summary>
    [EnumMember(Value = "HKCH")]
    [IsoId("_Vsg06dp-Ed-ak6NoX_4Aeg_335333236")]
    [Description(@"Hong Kong National Clearing System.")]
    HongKongNationalClearing,
    
    /// <summary>
    /// India National Securities Depositary.
    /// Encoded/decoded by serializers as "NSDL".
    /// </summary>
    [EnumMember(Value = "NSDL")]
    [IsoId("_Vsql4Np-Ed-ak6NoX_4Aeg_335333245")]
    [Description(@"India National Securities Depositary.")]
    IndianNationalSecuritiesDepository,
    
    /// <summary>
    /// Indonesian Securities Central Depository.
    /// Encoded/decoded by serializers as "KDEI".
    /// </summary>
    [EnumMember(Value = "KDEI")]
    [IsoId("_Vsql4dp-Ed-ak6NoX_4Aeg_335333246")]
    [Description(@"Indonesian Securities Central Depository.")]
    IndonesianSecuritiesCentralDepository,
    
    /// <summary>
    /// Irish National Clearing Code.
    /// Encoded/decoded by serializers as "IESC".
    /// </summary>
    [EnumMember(Value = "IESC")]
    [IsoId("_Vsql4tp-Ed-ak6NoX_4Aeg_335333247")]
    [Description(@"Irish National Clearing Code.")]
    IrishNationalClearing,
    
    /// <summary>
    /// Israel Tel Aviv Stock Exchange.
    /// Encoded/decoded by serializers as "XTAE".
    /// </summary>
    [EnumMember(Value = "XTAE")]
    [IsoId("_Vsql49p-Ed-ak6NoX_4Aeg_335333248")]
    [Description(@"Israel Tel Aviv Stock Exchange.")]
    TelAvivStockExchange,
    
    /// <summary>
    /// Italian Domestic Identification Code.
    /// Encoded/decoded by serializers as "ITIT".
    /// </summary>
    [EnumMember(Value = "ITIT")]
    [IsoId("_Vsql5Np-Ed-ak6NoX_4Aeg_335333249")]
    [Description(@"Italian Domestic Identification Code.")]
    ItalianDomesticIdentification,
    
    /// <summary>
    /// Italy - Monte Titoli.
    /// Encoded/decoded by serializers as "MOTI".
    /// </summary>
    [EnumMember(Value = "MOTI")]
    [IsoId("_Vsql5dp-Ed-ak6NoX_4Aeg_335333250")]
    [Description(@"Italy - Monte Titoli.")]
    MonteTitoli,
    
    /// <summary>
    /// Japan Securities Clearing Corporation.
    /// Encoded/decoded by serializers as "JSCC".
    /// </summary>
    [EnumMember(Value = "JSCC")]
    [IsoId("_Vsql5tp-Ed-ak6NoX_4Aeg_335333251")]
    [Description(@"Japan Securities Clearing Corporation.")]
    JapanSecuritiesClearingCorporation,
    
    /// <summary>
    /// Japan Securities Depository Center.
    /// Encoded/decoded by serializers as "JSDC".
    /// </summary>
    [EnumMember(Value = "JSDC")]
    [IsoId("_Vsql59p-Ed-ak6NoX_4Aeg_335333252")]
    [Description(@"Japan Securities Depository Center.")]
    JapanSecuritiesDepositoryCenter,
    
    /// <summary>
    /// Korea Securities Depository.
    /// Encoded/decoded by serializers as "KSDC".
    /// </summary>
    [EnumMember(Value = "KSDC")]
    [IsoId("_Vsql6Np-Ed-ak6NoX_4Aeg_335333253")]
    [Description(@"Korea Securities Depository.")]
    KoreanSecuritiesDepository,
    
    /// <summary>
    /// Malaysian Central Depositary.
    /// Encoded/decoded by serializers as "MCDY".
    /// </summary>
    [EnumMember(Value = "MCDY")]
    [IsoId("_Vsql6dp-Ed-ak6NoX_4Aeg_335333254")]
    [Description(@"Malaysian Central Depositary.")]
    MalaysianCentralDepository,
    
    /// <summary>
    /// Mexico S.D. Indeval, S.A. de C.V.
    /// Encoded/decoded by serializers as "INDE".
    /// </summary>
    [EnumMember(Value = "INDE")]
    [IsoId("_Vsql6tp-Ed-ak6NoX_4Aeg_335333262")]
    [Description(@"Mexico S.D. Indeval, S.A. de C.V.")]
    IndevalSA,
    
    /// <summary>
    /// Amsterdamse Effectenbeurs.
    /// Encoded/decoded by serializers as "XAMS".
    /// </summary>
    [EnumMember(Value = "XAMS")]
    [IsoId("_Vs0W4Np-Ed-ak6NoX_4Aeg_335333263")]
    [Description(@"Amsterdamse Effectenbeurs.")]
    AmsterdamseEffectenbeurs,
    
    /// <summary>
    /// Nederlands Centraal Instituut voor Giraal Effectenverkeer.
    /// Encoded/decoded by serializers as "NECI".
    /// </summary>
    [EnumMember(Value = "NECI")]
    [IsoId("_Vs0W4dp-Ed-ak6NoX_4Aeg_335333264")]
    [Description(@"Nederlands Centraal Instituut voor Giraal Effectenverkeer.")]
    NECIGEF,
    
    /// <summary>
    /// New Zealand National Clearing Code.
    /// Encoded/decoded by serializers as "NZBA".
    /// </summary>
    [EnumMember(Value = "NZBA")]
    [IsoId("_Vs0W4tp-Ed-ak6NoX_4Aeg_335333265")]
    [Description(@"New Zealand National Clearing Code.")]
    NewZealandNationalClearing,
    
    /// <summary>
    /// New Zealand Stock Exchange.
    /// Encoded/decoded by serializers as "XNZE".
    /// </summary>
    [EnumMember(Value = "XNZE")]
    [IsoId("_Vs0W49p-Ed-ak6NoX_4Aeg_335333266")]
    [Description(@"New Zealand Stock Exchange.")]
    NewZealandStockExchange,
    
    /// <summary>
    /// Norway Verdipapirsentralen.
    /// Encoded/decoded by serializers as "VPSN".
    /// </summary>
    [EnumMember(Value = "VPSN")]
    [IsoId("_Vs0W5Np-Ed-ak6NoX_4Aeg_335333267")]
    [Description(@"Norway Verdipapirsentralen.")]
    Verdipapirsentralen,
    
    /// <summary>
    /// Philippine Central Depositary.
    /// Encoded/decoded by serializers as "PCDY".
    /// </summary>
    [EnumMember(Value = "PCDY")]
    [IsoId("_Vs0W5dp-Ed-ak6NoX_4Aeg_335333524")]
    [Description(@"Philippine Central Depositary.")]
    PhilippineCentralDepository,
    
    /// <summary>
    /// Poland National Depository for Securities.
    /// Encoded/decoded by serializers as "KDPW".
    /// </summary>
    [EnumMember(Value = "KDPW")]
    [IsoId("_Vs0W5tp-Ed-ak6NoX_4Aeg_335333525")]
    [Description(@"Poland National Depository for Securities.")]
    PolandNationalDepositorySecurities,
    
    /// <summary>
    /// Portugal Central de Valores de Mobiliaros.
    /// Encoded/decoded by serializers as "CVMP".
    /// </summary>
    [EnumMember(Value = "CVMP")]
    [IsoId("_Vs0W59p-Ed-ak6NoX_4Aeg_335333526")]
    [Description(@"Portugal Central de Valores de Mobiliaros.")]
    CentralValoresMobiliaros,
    
    /// <summary>
    /// Portuguese National Clearing Code.
    /// Encoded/decoded by serializers as "PTIF".
    /// </summary>
    [EnumMember(Value = "PTIF")]
    [IsoId("_Vs0W6Np-Ed-ak6NoX_4Aeg_335333527")]
    [Description(@"Portuguese National Clearing Code.")]
    PortugueseNationalClearing,
    
    /// <summary>
    /// Associacao para a Prestacao de Servicios as Bolsas de Valores.
    /// Encoded/decoded by serializers as "XCVM".
    /// </summary>
    [EnumMember(Value = "XCVM")]
    [IsoId("_Vs0W6dp-Ed-ak6NoX_4Aeg_335333528")]
    [Description(@"Associacao para a Prestacao de Servicios as Bolsas de Valores.")]
    INTERBOLSA,
    
    /// <summary>
    /// Russian Central Bank Identification Code.
    /// Encoded/decoded by serializers as "RUIC".
    /// </summary>
    [EnumMember(Value = "RUIC")]
    [IsoId("_Vs0W6tp-Ed-ak6NoX_4Aeg_335333529")]
    [Description(@"Russian Central Bank Identification Code.")]
    RussianCentralBankIdentification,
    
    /// <summary>
    /// Central Depository Pte Ltd.
    /// Encoded/decoded by serializers as "CDPL".
    /// </summary>
    [EnumMember(Value = "CDPL")]
    [IsoId("_Vs9g0Np-Ed-ak6NoX_4Aeg_335333530")]
    [Description(@"Central Depository Pte Ltd.")]
    SingaporeCentralDepositoryLtd,
    
    /// <summary>
    /// Singapore International Monetary Exchange Limited.
    /// Encoded/decoded by serializers as "XSIM".
    /// </summary>
    [EnumMember(Value = "XSIM")]
    [IsoId("_Vs9g0dp-Ed-ak6NoX_4Aeg_335333531")]
    [Description(@"Singapore International Monetary Exchange Limited.")]
    SingaporeInternationalMonetaryExchange,
    
    /// <summary>
    /// The Bratislava Stock Exchange.
    /// Encoded/decoded by serializers as "XBRA".
    /// </summary>
    [EnumMember(Value = "XBRA")]
    [IsoId("_Vs9g0tp-Ed-ak6NoX_4Aeg_335333532")]
    [Description(@"The Bratislava Stock Exchange.")]
    BratislavaStockExchange,
    
    /// <summary>
    /// South African National Clearing Code.
    /// Encoded/decoded by serializers as "ZABS".
    /// </summary>
    [EnumMember(Value = "ZABS")]
    [IsoId("_Vs9g09p-Ed-ak6NoX_4Aeg_335333533")]
    [Description(@"South African National Clearing Code.")]
    SouthAfricanNationalClearing,
    
    /// <summary>
    /// Strate Clearing and Settlement (Proprietary) Limited.
    /// Encoded/decoded by serializers as "STRA".
    /// </summary>
    [EnumMember(Value = "STRA")]
    [IsoId("_Vs9g1Np-Ed-ak6NoX_4Aeg_335333541")]
    [Description(@"Strate Clearing and Settlement (Proprietary) Limited.")]
    StrateClearingSettlementLtd,
    
    /// <summary>
    /// Banco de Espana.
    /// Encoded/decoded by serializers as "ESPB".
    /// </summary>
    [EnumMember(Value = "ESPB")]
    [IsoId("_Vs9g1dp-Ed-ak6NoX_4Aeg_335333542")]
    [Description(@"Banco de Espana.")]
    BancoEspana,
    
    /// <summary>
    /// Servicio de Compensacion y Liquidacion de Valores.
    /// Encoded/decoded by serializers as "SCLV".
    /// </summary>
    [EnumMember(Value = "SCLV")]
    [IsoId("_Vs9g1tp-Ed-ak6NoX_4Aeg_335333543")]
    [Description(@"Servicio de Compensacion y Liquidacion de Valores.")]
    ServicioCompensacionLiquidacionValores,
    
    /// <summary>
    /// Spanish Domestic Interbanking Code.
    /// Encoded/decoded by serializers as "ESES".
    /// </summary>
    [EnumMember(Value = "ESES")]
    [IsoId("_Vs9g19p-Ed-ak6NoX_4Aeg_335333544")]
    [Description(@"Spanish Domestic Interbanking Code.")]
    SpanishDomesticInterbanking,
    
    /// <summary>
    /// Sweden Vardepapperscentralen.
    /// Encoded/decoded by serializers as "VPCS".
    /// </summary>
    [EnumMember(Value = "VPCS")]
    [IsoId("_Vs9g2Np-Ed-ak6NoX_4Aeg_335333545")]
    [Description(@"Sweden Vardepapperscentralen.")]
    Vardepapperscentralen,
    
    /// <summary>
    /// SIS - SEGA/Intersettle.
    /// Encoded/decoded by serializers as "SCOM".
    /// </summary>
    [EnumMember(Value = "SCOM")]
    [IsoId("_Vs9g2dp-Ed-ak6NoX_4Aeg_335333546")]
    [Description(@"SIS - SEGA/Intersettle.")]
    SISSEGAIntersettle,
    
    /// <summary>
    /// Swiss Clearing System.
    /// Encoded/decoded by serializers as "CHSW".
    /// </summary>
    [EnumMember(Value = "CHSW")]
    [IsoId("_VtHR0Np-Ed-ak6NoX_4Aeg_335333555")]
    [Description(@"Swiss Clearing System.")]
    SwissClearingCode,
    
    /// <summary>
    /// Thailand Securities Depository Company Limited.
    /// Encoded/decoded by serializers as "TSDC".
    /// </summary>
    [EnumMember(Value = "TSDC")]
    [IsoId("_VtHR0dp-Ed-ak6NoX_4Aeg_335333556")]
    [Description(@"Thailand Securities Depository Company Limited.")]
    ThailandSecuritiesDepositoryCompany,
    
    /// <summary>
    /// Taiwan Securities Central Depository Co Limited.
    /// Encoded/decoded by serializers as "TSCD".
    /// </summary>
    [EnumMember(Value = "TSCD")]
    [IsoId("_VtHR0tp-Ed-ak6NoX_4Aeg_335333557")]
    [Description(@"Taiwan Securities Central Depository Co Limited.")]
    TaiwanSecuritiesCentralDepository,
    
    /// <summary>
    /// Turkey Takasbank.
    /// Encoded/decoded by serializers as "TVSB".
    /// </summary>
    [EnumMember(Value = "TVSB")]
    [IsoId("_VtHR09p-Ed-ak6NoX_4Aeg_335333558")]
    [Description(@"Turkey Takasbank.")]
    Takasbank,
    
    /// <summary>
    /// UK Domestic Sort Code.
    /// Encoded/decoded by serializers as "GBSC".
    /// </summary>
    [EnumMember(Value = "GBSC")]
    [IsoId("_VtHR1Np-Ed-ak6NoX_4Aeg_335333559")]
    [Description(@"UK Domestic Sort Code.")]
    UKDomesticSort,
    
    /// <summary>
    /// Bank of England (Central Moneymarkets Office).
    /// Encoded/decoded by serializers as "BKEN".
    /// </summary>
    [EnumMember(Value = "BKEN")]
    [IsoId("_VtHR1dp-Ed-ak6NoX_4Aeg_335333560")]
    [Description(@"Bank of England (Central Moneymarkets Office).")]
    BankOfEnglandCMO,
    
    /// <summary>
    /// CRESTCo Ltd. Company operating two real-time securities settlement services: CREST (for UK, Irish and international securities and government bonds) and CMO (UK money market instrument settlement).
    /// Encoded/decoded by serializers as "CRST".
    /// </summary>
    [EnumMember(Value = "CRST")]
    [IsoId("_VtHR1tp-Ed-ak6NoX_4Aeg_335333561")]
    [Description(@"CRESTCo Ltd. Company operating two real-time securities settlement services: CREST (for UK, Irish and international securities and government bonds) and CMO (UK money market instrument settlement).")]
    CrestCo,
    
    /// <summary>
    /// UK Financial Services Authority.
    /// Encoded/decoded by serializers as "FSAU".
    /// </summary>
    [EnumMember(Value = "FSAU")]
    [IsoId("_VtHR19p-Ed-ak6NoX_4Aeg_335333562")]
    [Description(@"UK Financial Services Authority.")]
    FinancialServicesAuthority,
    
    /// <summary>
    /// The London Clearing House.
    /// Encoded/decoded by serializers as "LCHL".
    /// </summary>
    [EnumMember(Value = "LCHL")]
    [IsoId("_VtHR2Np-Ed-ak6NoX_4Aeg_335333563")]
    [Description(@"The London Clearing House.")]
    LondonClearingHouse,
    
    /// <summary>
    /// UK - International Securities Market Association.
    /// Encoded/decoded by serializers as "XISM".
    /// </summary>
    [EnumMember(Value = "XISM")]
    [IsoId("_VtHR2dp-Ed-ak6NoX_4Aeg_335333564")]
    [Description(@"UK - International Securities Market Association.")]
    InternationalSecuritiesMarketAssociation,
    
    /// <summary>
    /// London Stock Exchange.
    /// Encoded/decoded by serializers as "XLON".
    /// </summary>
    [EnumMember(Value = "XLON")]
    [IsoId("_VtRC0Np-Ed-ak6NoX_4Aeg_335333572")]
    [Description(@"London Stock Exchange.")]
    LondonStockExchange,
    
    /// <summary>
    /// American Stock Exchange.
    /// Encoded/decoded by serializers as "XASE".
    /// </summary>
    [EnumMember(Value = "XASE")]
    [IsoId("_VtRC0dp-Ed-ak6NoX_4Aeg_335333573")]
    [Description(@"American Stock Exchange.")]
    AmericanStockExchange,
    
    /// <summary>
    /// Depository Trust Company.
    /// Encoded/decoded by serializers as "DTCC".
    /// </summary>
    [EnumMember(Value = "DTCC")]
    [IsoId("_VtRC0tp-Ed-ak6NoX_4Aeg_335333574")]
    [Description(@"Depository Trust Company.")]
    DepositoryTrustCompany,
    
    /// <summary>
    /// USA Emerging Markets Clearing Corporation.
    /// Encoded/decoded by serializers as "EMCC".
    /// </summary>
    [EnumMember(Value = "EMCC")]
    [IsoId("_VtRC09p-Ed-ak6NoX_4Aeg_335333575")]
    [Description(@"USA Emerging Markets Clearing Corporation.")]
    EmergingMarketsClearingCorporation,
    
    /// <summary>
    /// Fedwire Routing Number.
    /// Encoded/decoded by serializers as "USFW".
    /// </summary>
    [EnumMember(Value = "USFW")]
    [IsoId("_VtRC1Np-Ed-ak6NoX_4Aeg_335333576")]
    [Description(@"Fedwire Routing Number.")]
    FedwireRoutingNumber,
    
    /// <summary>
    /// Provider of trade netting and settlement for the US Government securities marketplace.
    /// Encoded/decoded by serializers as "GSCC".
    /// </summary>
    [EnumMember(Value = "GSCC")]
    [IsoId("_VtRC1dp-Ed-ak6NoX_4Aeg_335333577")]
    [Description(@"Provider of trade netting and settlement for the US Government securities marketplace.")]
    GovernmentSecuritiesClearingCorporation,
    
    /// <summary>
    /// International Securities Clearing Corporation.
    /// Encoded/decoded by serializers as "ISCC".
    /// </summary>
    [EnumMember(Value = "ISCC")]
    [IsoId("_VtRC1tp-Ed-ak6NoX_4Aeg_335333586")]
    [Description(@"International Securities Clearing Corporation.")]
    InternationalSecuritiesClearingCorporation,
    
    /// <summary>
    /// Mortgage Backed Securities Clearing Corporation.
    /// Encoded/decoded by serializers as "MBSC".
    /// </summary>
    [EnumMember(Value = "MBSC")]
    [IsoId("_VtRC19p-Ed-ak6NoX_4Aeg_335333587")]
    [Description(@"Mortgage Backed Securities Clearing Corporation.")]
    MortgageBackedSecuritiesClearingCorporation,
    
    /// <summary>
    /// National Association Securities Dealers.
    /// Encoded/decoded by serializers as "XNAS".
    /// </summary>
    [EnumMember(Value = "XNAS")]
    [IsoId("_VtRC2Np-Ed-ak6NoX_4Aeg_335333588")]
    [Description(@"National Association Securities Dealers.")]
    NationalAssociationSecuritiesDealers,
    
    /// <summary>
    /// National Association of Securities Dealers Automated Quotation Service "NASDAQ" / National Market System.
    /// Encoded/decoded by serializers as "XNMS".
    /// </summary>
    [EnumMember(Value = "XNMS")]
    [IsoId("_VtRC2dp-Ed-ak6NoX_4Aeg_335333589")]
    [Description(@"National Association of Securities Dealers Automated Quotation Service ""NASDAQ"" / National Market System.")]
    NASDAQ,
    
    /// <summary>
    /// National Securities Clearing Corporation.
    /// Encoded/decoded by serializers as "NSCC".
    /// </summary>
    [EnumMember(Value = "NSCC")]
    [IsoId("_VtaMwNp-Ed-ak6NoX_4Aeg_335333590")]
    [Description(@"National Securities Clearing Corporation.")]
    NationalSecuritiesClearingCorporation,
    
    /// <summary>
    /// New York Clearing House.
    /// Encoded/decoded by serializers as "NYCH".
    /// </summary>
    [EnumMember(Value = "NYCH")]
    [IsoId("_VtaMwdp-Ed-ak6NoX_4Aeg_335333591")]
    [Description(@"New York Clearing House.")]
    NewYorkClearingHouse,
    
    /// <summary>
    /// New York Stock Exchange.
    /// Encoded/decoded by serializers as "XNYS".
    /// </summary>
    [EnumMember(Value = "XNYS")]
    [IsoId("_VtaMwtp-Ed-ak6NoX_4Aeg_335333592")]
    [Description(@"New York Stock Exchange.")]
    NewYorkStockExchange,
    
    /// <summary>
    /// Options Clearing Corporation.
    /// Encoded/decoded by serializers as "OCCX".
    /// </summary>
    [EnumMember(Value = "OCCX")]
    [IsoId("_VtaMw9p-Ed-ak6NoX_4Aeg_335333593")]
    [Description(@"Options Clearing Corporation.")]
    OptionsClearingCorporation,
    
    /// <summary>
    /// Participant Trust Company.
    /// Encoded/decoded by serializers as "PTCY".
    /// </summary>
    [EnumMember(Value = "PTCY")]
    [IsoId("_VtaMxNp-Ed-ak6NoX_4Aeg_335333594")]
    [Description(@"Participant Trust Company.")]
    ParticipantTrustCompany,
    
    /// <summary>
    /// X-Clear, clearing and risk management services for the Swiss banking industry.
    /// Encoded/decoded by serializers as "XCLR".
    /// </summary>
    [EnumMember(Value = "XCLR")]
    [IsoId("_VtaMxdp-Ed-ak6NoX_4Aeg_335333595")]
    [Description(@"X-Clear, clearing and risk management services for the Swiss banking industry.")]
    XClear,
    
}
