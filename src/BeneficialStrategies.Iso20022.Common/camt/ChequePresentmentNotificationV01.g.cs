﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ChequePresentmentNotificationV01.  ISO2002 ID# _QqKNkbSJEeq3lpO-mRtrig.
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


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.107.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ChequePresentmentNotification message is sent by a drawer bank, or a bank acting on behalf of the drawer bank to the bank on which a/several cheque(s) has been drawn (the drawee bank).
/// It is used to advise the drawee bank, or confirm to an enquiring bank, the details concerning the cheque(s) referred to in the message.
/// </summary>
[Description(@"The ChequePresentmentNotification message is sent by a drawer bank, or a bank acting on behalf of the drawer bank to the bank on which a/several cheque(s) has been drawn (the drawee bank).|It is used to advise the drawee bank, or confirm to an enquiring bank, the details concerning the cheque(s) referred to in the message.")]
[IsoId("_QqKNkbSJEeq3lpO-mRtrig")]
[DisplayName("Cheque Presentment Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ChequePresentmentNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.107.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ChqPresntmntNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.107.001.01";
    
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
    /// <summary>
    /// Constructs a ChequePresentmentNotificationV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ChequePresentmentNotificationV01( GroupHeader103 reqGroupHeader,Cheque13 reqCheque )
    {
        GroupHeader = reqGroupHeader;
        Cheque = reqCheque;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics shared by all individual cheques included in the message.
    /// </summary>
    [IsoId("_GCVd0Sm6EeutWNGMV2XKIQ")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader103 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader103 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader103 GroupHeader { get; init; } 
    #else
    public GroupHeader103 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the details of the cheque.
    /// </summary>
    [IsoId("_tGFUsbtlEeq_cfXrH83Rcw")]
    [DisplayName("Cheque")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chq")]
    #endif
    [IsoXmlTag("Chq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Cheque13 Cheque { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Cheque13 Cheque { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cheque13 Cheque { get; init; } 
    #else
    public Cheque13 Cheque { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_V-H6o7tlEeq_cfXrH83Rcw")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ChequePresentmentNotificationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ChequePresentmentNotificationV01.

