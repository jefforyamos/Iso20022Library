﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DuplicateV03.  ISO2002 ID# _X-6wYtE-Ed-BzquC8wXy7w_654549647.
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
/// This record is an implementation of the camt.034.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Duplicate message is used by financial institutions, with their own offices, and/or with other financial institutions with which they have established bilateral agreements. It allows to exchange duplicate payment instructions.
/// Usage
/// This message must be sent in response to a Request For Duplicate message.
/// The Duplicate Data element must contain a well formed XML document. This means XML special characters such as &apos;&lt;&apos; must be used in a way that is consistent with XML well-formedness criteria.|.
/// </summary>
[Description(@"Scope|The Duplicate message is used by financial institutions, with their own offices, and/or with other financial institutions with which they have established bilateral agreements. It allows to exchange duplicate payment instructions.|Usage|This message must be sent in response to a Request For Duplicate message.|The Duplicate Data element must contain a well formed XML document. This means XML special characters such as '<' must be used in a way that is consistent with XML well-formedness criteria.|.")]
[IsoId("_X-6wYtE-Ed-BzquC8wXy7w_654549647")]
[DisplayName("Duplicate V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DuplicateV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.034.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "Dplct";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.034.001.03";
    
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
    /// Constructs a DuplicateV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DuplicateV03( CaseAssignment2 reqAssignment,Case2 reqCase,ProprietaryData4 reqDuplicate )
    {
        Assignment = reqAssignment;
        Case = reqCase;
        Duplicate = reqDuplicate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_X-6wY9E-Ed-BzquC8wXy7w_-1056990922")]
    [DisplayName("Assignment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnmt")]
    #endif
    [IsoXmlTag("Assgnmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CaseAssignment2 Assignment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CaseAssignment2 Assignment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CaseAssignment2 Assignment { get; init; } 
    #else
    public CaseAssignment2 Assignment { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_X-6wZNE-Ed-BzquC8wXy7w_-1056990861")]
    [DisplayName("Case")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Case")]
    #endif
    [IsoXmlTag("Case")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Case2 Case { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Case2 Case { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Case2 Case { get; init; } 
    #else
    public Case2 Case { get; set; } 
    #endif
    
    /// <summary>
    /// Duplicate of a previously sent message.
    /// </summary>
    [IsoId("_X-6wZdE-Ed-BzquC8wXy7w_654549710")]
    [DisplayName("Duplicate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dplct")]
    #endif
    [IsoXmlTag("Dplct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProprietaryData4 Duplicate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProprietaryData4 Duplicate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProprietaryData4 Duplicate { get; init; } 
    #else
    public ProprietaryData4 Duplicate { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since DuplicateV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DuplicateV03.

