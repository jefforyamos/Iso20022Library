﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCANOCSDDataSD1V09.  ISO2002 ID# _I7q0IZCEEeaSk9d1hvTrHg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// This record is an implementation of the supl.001.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCANOCSDDataSD1 message extends ISO corporate action notification (CANO) asset servicer data message (CSD type) with data elements that are not covered by the standard message, and additionally, with issuer/offeror/market values where DTC corresponding values are mapped to CANO. For example DTCC announced cash rate will be mapped to the CANO and issuer/offeror/ market declared cash rate will be extended in this message.
/// </summary>
[Description(@"The DTCCCANOCSDDataSD1 message extends ISO corporate action notification (CANO) asset servicer data message (CSD type) with data elements that are not covered by the standard message, and additionally, with issuer/offeror/market values where DTC corresponding values are mapped to CANO. For example DTCC announced cash rate will be mapped to the CANO and issuer/offeror/ market declared cash rate will be extended in this message.")]
[IsoId("_I7q0IZCEEeaSk9d1hvTrHg")]
[DisplayName("DTCCCANOCSD Data SD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCCCANOCSDDataSD1V09 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.001.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOCSDDataSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.001.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_I7rbMZCEEeaSk9d1hvTrHg")]
    [DisplayName("Notification General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnGnlInf")]
    #endif
    [IsoXmlTag("NtfctnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNotificationSD3? NotificationGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNotificationSD3? NotificationGeneralInformation { get; init; } 
    #else
    public CorporateActionNotificationSD3? NotificationGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_I7rbM5CEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionGeneralInformationSD23? CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformationSD23? CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformationSD23? CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_I7rbNZCEEeaSk9d1hvTrHg")]
    [DisplayName("Underlying Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygScty")]
    #endif
    [IsoXmlTag("UndrlygScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributesSD14? UnderlyingSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributesSD14? UnderlyingSecurity { get; init; } 
    #else
    public FinancialInstrumentAttributesSD14? UnderlyingSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_I7rbN5CEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtls")]
    #endif
    [IsoXmlTag("CorpActnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionSD14? CorporateActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionSD14? CorporateActionDetails { get; init; } 
    #else
    public CorporateActionSD14? CorporateActionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action date details.
    /// </summary>
    [IsoId("_I7rbOZCEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtDtls")]
    #endif
    [IsoXmlTag("CorpActnDtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionDateSD5? CorporateActionDateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDateSD5? CorporateActionDateDetails { get; init; } 
    #else
    public CorporateActionDateSD5? CorporateActionDateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as corporate action price supplementary data.
    /// </summary>
    [IsoId("_I7rbO5CEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnPricDtls")]
    #endif
    [IsoXmlTag("CorpActnPricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPriceSD3? CorporateActionPriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPriceSD3? CorporateActionPriceDetails { get; init; } 
    #else
    public CorporateActionPriceSD3? CorporateActionPriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action period.
    /// </summary>
    [IsoId("_I7rbPZCEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action Period Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnPrdDtls")]
    #endif
    [IsoXmlTag("CorpActnPrdDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPeriodSD2? CorporateActionPeriodDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPeriodSD2? CorporateActionPeriodDetails { get; init; } 
    #else
    public CorporateActionPeriodSD2? CorporateActionPeriodDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action rate and amount.
    /// </summary>
    [IsoId("_I7rbP5CEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action Rate And Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnRateAndAmtDtls")]
    #endif
    [IsoXmlTag("CorpActnRateAndAmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRateSD5? CorporateActionRateAndAmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRateSD5? CorporateActionRateAndAmountDetails { get; init; } 
    #else
    public CorporateActionRateSD5? CorporateActionRateAndAmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action securities quantity.
    /// </summary>
    [IsoId("_I7rbQZCEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnSctiesQty")]
    #endif
    [IsoXmlTag("CorpActnSctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionQuantitySD1? CorporateActionSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionQuantitySD1? CorporateActionSecuritiesQuantity { get; init; } 
    #else
    public CorporateActionQuantitySD1? CorporateActionSecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to option details.
    /// </summary>
    [IsoId("_I7rbQ5CEEeaSk9d1hvTrHg")]
    [DisplayName("Option Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnDtls")]
    #endif
    [IsoXmlTag("OptnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionOptionSD10? OptionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOptionSD10? OptionDetails { get; init; } 
    #else
    public CorporateActionOptionSD10? OptionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to option date details.
    /// </summary>
    [IsoId("_iSsHgJEYEeajS_7NioJdVA")]
    [DisplayName("Option Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnDtDtls")]
    #endif
    [IsoXmlTag("OptnDtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionDateSD7? OptionDateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDateSD7? OptionDateDetails { get; init; } 
    #else
    public CorporateActionDateSD7? OptionDateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement details.
    /// </summary>
    [IsoId("_I7rbRZCEEeaSk9d1hvTrHg")]
    [DisplayName("Securities Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntDtls")]
    #endif
    [IsoXmlTag("SctiesMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesOptionSD8? SecuritiesMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesOptionSD8? SecuritiesMovementDetails { get; init; } 
    #else
    public SecuritiesOptionSD8? SecuritiesMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement security details.
    /// </summary>
    [IsoId("_I7rbR5CEEeaSk9d1hvTrHg")]
    [DisplayName("Securities Movement Security Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntSctyDtls")]
    #endif
    [IsoXmlTag("SctiesMvmntSctyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributesSD13? SecuritiesMovementSecurityDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributesSD13? SecuritiesMovementSecurityDetails { get; init; } 
    #else
    public FinancialInstrumentAttributesSD13? SecuritiesMovementSecurityDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement rate details.
    /// </summary>
    [IsoId("_I7rbSZCEEeaSk9d1hvTrHg")]
    [DisplayName("Securities Movement Rate Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntRateDtls")]
    #endif
    [IsoXmlTag("SctiesMvmntRateDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRateSD8? SecuritiesMovementRateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRateSD8? SecuritiesMovementRateDetails { get; init; } 
    #else
    public CorporateActionRateSD8? SecuritiesMovementRateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as securities movement cash in lieu supplementary data.
    /// </summary>
    [IsoId("_I7rbS5CEEeaSk9d1hvTrHg")]
    [DisplayName("Securities Movement Cash In Lieu Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntCshInLieuDtls")]
    #endif
    [IsoXmlTag("SctiesMvmntCshInLieuDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPriceSD1? SecuritiesMovementCashInLieuDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPriceSD1? SecuritiesMovementCashInLieuDetails { get; init; } 
    #else
    public CorporateActionPriceSD1? SecuritiesMovementCashInLieuDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement fraction disposition.
    /// </summary>
    [IsoId("_I7rbTZCEEeaSk9d1hvTrHg")]
    [DisplayName("Securities Movement Fraction Disposition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntFrctnDspstn")]
    #endif
    [IsoXmlTag("SctiesMvmntFrctnDspstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FractionDispositionTypeSD2? SecuritiesMovementFractionDisposition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FractionDispositionTypeSD2? SecuritiesMovementFractionDisposition { get; init; } 
    #else
    public FractionDispositionTypeSD2? SecuritiesMovementFractionDisposition { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to cash movement details.
    /// </summary>
    [IsoId("_I7rbT5CEEeaSk9d1hvTrHg")]
    [DisplayName("Cash Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshMvmntDtls")]
    #endif
    [IsoXmlTag("CshMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashOptionSD10? CashMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashOptionSD10? CashMovementDetails { get; init; } 
    #else
    public CashOptionSD10? CashMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended new agent block. Used when required ISO Agent Type does not exist and entire new component must be generated.
    /// </summary>
    [IsoId("_I7rbUZCEEeaSk9d1hvTrHg")]
    [DisplayName("New Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewAgt")]
    #endif
    [IsoXmlTag("NewAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationSD1? NewAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationSD1? NewAgent { get; init; } 
    #else
    public PartyIdentificationSD1? NewAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information to agent details (to message agent like &quot;issuer agent&quot;, &quot;reselling agent&quot;, etc). Used when required &quot;ISO agent type&quot; exists and only additional details need to be extended.
    /// </summary>
    [IsoId("_I7rbU5CEEeaSk9d1hvTrHg")]
    [DisplayName("Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agt")]
    #endif
    [IsoXmlTag("Agt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationSD2? Agent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationSD2? Agent { get; init; } 
    #else
    public PartyIdentificationSD2? Agent { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since DTCCCANOCSDDataSD1V09Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCANOCSDDataSD1V09.

