﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCACOSD1V03.  ISO2002 ID# _2E1Z8aFJEeSK_vfd3NHBGg.
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
/// This record is an implementation of the supl.011.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCACOSD1 message extends ISO corporate action movement confirmation message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(@"The DTCCCACOSD1 message extends ISO corporate action movement confirmation message with DTCC corporate action elements not covered in the standard message.")]
[IsoId("_2E1Z8aFJEeSK_vfd3NHBGg")]
[DisplayName("DTCCCACOSD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCCCACOSD1V03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.011.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACOSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.011.001.03";
    
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
    /// Extension block for the information to be extended as corporate action general information.
    /// </summary>
    [IsoId("_2E1Z86FJEeSK_vfd3NHBGg")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionGeneralInformationSD14? CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformationSD14? CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformationSD14? CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_2E1Z-6FJEeSK_vfd3NHBGg")]
    [DisplayName("Underlying Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygScty")]
    #endif
    [IsoXmlTag("UndrlygScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributesSD9? UnderlyingSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributesSD9? UnderlyingSecurity { get; init; } 
    #else
    public FinancialInstrumentAttributesSD9? UnderlyingSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_2E1Z_aFJEeSK_vfd3NHBGg")]
    [DisplayName("Corporate Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtls")]
    #endif
    [IsoXmlTag("CorpActnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionSD10? CorporateActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionSD10? CorporateActionDetails { get; init; } 
    #else
    public CorporateActionSD10? CorporateActionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Extension block for the information to be extended as account balance.
    /// </summary>
    [IsoId("_2E1Z_6FJEeSK_vfd3NHBGg")]
    [DisplayName("Account Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctBal")]
    #endif
    [IsoXmlTag("AcctBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountBalanceSD4? AccountBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountBalanceSD4? AccountBalance { get; init; } 
    #else
    public AccountBalanceSD4? AccountBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as corporate action confirmation securities movement details.
    /// </summary>
    [IsoId("_2E1aAaFJEeSK_vfd3NHBGg")]
    [DisplayName("Corporate Action Confirmation Securities Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnConfSctiesMvmntDtls")]
    #endif
    [IsoXmlTag("CorpActnConfSctiesMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionConfirmationSecuritiesMovementDetailsSD3? CorporateActionConfirmationSecuritiesMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionConfirmationSecuritiesMovementDetailsSD3? CorporateActionConfirmationSecuritiesMovementDetails { get; init; } 
    #else
    public CorporateActionConfirmationSecuritiesMovementDetailsSD3? CorporateActionConfirmationSecuritiesMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action confirmation cash movement details.
    /// </summary>
    [IsoId("_2E1aCaFJEeSK_vfd3NHBGg")]
    [DisplayName("Corporate Action Confirmation Cash Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnConfCshMvmntDtls")]
    #endif
    [IsoXmlTag("CorpActnConfCshMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionConfirmationCashMovementDetailsSD3? CorporateActionConfirmationCashMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionConfirmationCashMovementDetailsSD3? CorporateActionConfirmationCashMovementDetails { get; init; } 
    #else
    public CorporateActionConfirmationCashMovementDetailsSD3? CorporateActionConfirmationCashMovementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since DTCCCACOSD1V03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCACOSD1V03.

