﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAPASD1V04.  ISO2002 ID# _X0irYZ2EEeW-bsa36JFb9A.
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
/// This record is an implementation of the supl.009.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCAPASD1 messge extends ISO corporate action movement preliminary advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(@"The DTCCCAPASD1 messge extends ISO corporate action movement preliminary advice message with DTCC corporate action elements not covered in the standard message.")]
[IsoId("_X0irYZ2EEeW-bsa36JFb9A")]
[DisplayName("DTCCCAPASD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCCCAPASD1V04 : IOuterRecord<DTCCCAPASD1V04,DTCCCAPASD1V04Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.009.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAPASD1";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DTCCCAPASD1V04Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action general information.
    /// </summary>
    [IsoId("_X0irY52EEeW-bsa36JFb9A")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionGeneralInformationSD21? CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformationSD21? CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformationSD21? CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_X0ira52EEeW-bsa36JFb9A")]
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
    /// Information to be extended as supplementary data to corporate action balance details.
    /// </summary>
    [IsoId("_X0scMZ2EEeW-bsa36JFb9A")]
    [DisplayName("Corporate Action Balance Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnBalDtls")]
    #endif
    [IsoXmlTag("CorpActnBalDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionBalanceSD1? CorporateActionBalanceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionBalanceSD1? CorporateActionBalanceDetails { get; init; } 
    #else
    public CorporateActionBalanceSD1? CorporateActionBalanceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_X0scM52EEeW-bsa36JFb9A")]
    [DisplayName("Corporate Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtls")]
    #endif
    [IsoXmlTag("CorpActnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionSD8? CorporateActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionSD8? CorporateActionDetails { get; init; } 
    #else
    public CorporateActionSD8? CorporateActionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action movement securities movement details.
    /// </summary>
    [IsoId("_X0scNZ2EEeW-bsa36JFb9A")]
    [DisplayName("Corporate Action Movement Securities Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnMvmntSctiesMvmntDtls")]
    #endif
    [IsoXmlTag("CorpActnMvmntSctiesMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionMovementSecuritiesMovementDetailsSD4? CorporateActionMovementSecuritiesMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionMovementSecuritiesMovementDetailsSD4? CorporateActionMovementSecuritiesMovementDetails { get; init; } 
    #else
    public CorporateActionMovementSecuritiesMovementDetailsSD4? CorporateActionMovementSecuritiesMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action movement cash movement details.
    /// </summary>
    [IsoId("_X0scPZ2EEeW-bsa36JFb9A")]
    [DisplayName("Corporate Action Movement Cash Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnMvmntCshMvmntDtls")]
    #endif
    [IsoXmlTag("CorpActnMvmntCshMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionMovementCashMovementDetailsSD3? CorporateActionMovementCashMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionMovementCashMovementDetailsSD3? CorporateActionMovementCashMovementDetails { get; init; } 
    #else
    public CorporateActionMovementCashMovementDetailsSD3? CorporateActionMovementCashMovementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;DTCCCAPASD1V04Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAPASD1V04Document ToDocument()
    {
        return new DTCCCAPASD1V04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;DTCCCAPASD1V04&quot;/&gt;.
/// </summary>
[Serializable]
public partial record DTCCCAPASD1V04Document : IOuterDocument<DTCCCAPASD1V04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.009.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;DTCCCAPASD1V04&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DTCCCAPASD1V04 Message { get; init; }
    #else
    public DTCCCAPASD1V04 Message { get; init; }
    #endif
}
