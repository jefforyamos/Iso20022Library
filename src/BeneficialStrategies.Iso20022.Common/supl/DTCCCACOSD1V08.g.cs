﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCACOSD1V08.  ISO2002 ID# _x6QSMwB6EeqouY-yI_q3qQ.
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
/// This record is an implementation of the supl.011.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCACOSD1 message extends ISO corporate action movement confirmation message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(@"The DTCCCACOSD1 message extends ISO corporate action movement confirmation message with DTCC corporate action elements not covered in the standard message.")]
[IsoId("_x6QSMwB6EeqouY-yI_q3qQ")]
[DisplayName("DTCCCACOSD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCCCACOSD1V08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.011.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACOSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.011.001.08";
    
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
    [IsoId("_x6QSNQB6EeqouY-yI_q3qQ")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionGeneralInformationSD44? CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformationSD44? CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformationSD44? CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_x6QSPQB6EeqouY-yI_q3qQ")]
    [DisplayName("Underlying Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygScty")]
    #endif
    [IsoXmlTag("UndrlygScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributesSD17? UnderlyingSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributesSD17? UnderlyingSecurity { get; init; } 
    #else
    public FinancialInstrumentAttributesSD17? UnderlyingSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_x6QSPwB6EeqouY-yI_q3qQ")]
    [DisplayName("Corporate Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtls")]
    #endif
    [IsoXmlTag("CorpActnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionSD20? CorporateActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionSD20? CorporateActionDetails { get; init; } 
    #else
    public CorporateActionSD20? CorporateActionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Extension block for the information to be extended as account balance.
    /// </summary>
    [IsoId("_x6QSQQB6EeqouY-yI_q3qQ")]
    [DisplayName("Account Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctBal")]
    #endif
    [IsoXmlTag("AcctBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountBalanceSD14? AccountBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountBalanceSD14? AccountBalance { get; init; } 
    #else
    public AccountBalanceSD14? AccountBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as corporate action confirmation details.
    /// </summary>
    [IsoId("_x6QSQwB6EeqouY-yI_q3qQ")]
    [DisplayName("Corporate Action Confirmation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnConfDtls")]
    #endif
    [IsoXmlTag("CorpActnConfDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionConfirmationDetailsSD2? CorporateActionConfirmationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionConfirmationDetailsSD2? CorporateActionConfirmationDetails { get; init; } 
    #else
    public CorporateActionConfirmationDetailsSD2? CorporateActionConfirmationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as corporate action confirmation securities movement details.
    /// </summary>
    [IsoId("_x6QSRQB6EeqouY-yI_q3qQ")]
    [DisplayName("Corporate Action Confirmation Securities Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnConfSctiesMvmntDtls")]
    #endif
    [IsoXmlTag("CorpActnConfSctiesMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionConfirmationSecuritiesMovementDetailsSD6? CorporateActionConfirmationSecuritiesMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionConfirmationSecuritiesMovementDetailsSD6? CorporateActionConfirmationSecuritiesMovementDetails { get; init; } 
    #else
    public CorporateActionConfirmationSecuritiesMovementDetailsSD6? CorporateActionConfirmationSecuritiesMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action confirmation cash movement details.
    /// </summary>
    [IsoId("_x6QSTQB6EeqouY-yI_q3qQ")]
    [DisplayName("Corporate Action Confirmation Cash Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnConfCshMvmntDtls")]
    #endif
    [IsoXmlTag("CorpActnConfCshMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionConfirmationCashMovementDetailsSD5? CorporateActionConfirmationCashMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionConfirmationCashMovementDetailsSD5? CorporateActionConfirmationCashMovementDetails { get; init; } 
    #else
    public CorporateActionConfirmationCashMovementDetailsSD5? CorporateActionConfirmationCashMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action option details.
    /// </summary>
    [IsoId("_x6QSVQB6EeqouY-yI_q3qQ")]
    [DisplayName("Option Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTxDtls")]
    #endif
    [IsoXmlTag("OptnTxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionTransactionSD6? OptionTransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionTransactionSD6? OptionTransactionDetails { get; init; } 
    #else
    public OptionTransactionSD6? OptionTransactionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since DTCCCACOSD1V08Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCACOSD1V08.

