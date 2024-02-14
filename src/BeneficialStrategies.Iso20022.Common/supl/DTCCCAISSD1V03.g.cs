﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAISSD1V03.  ISO2002 ID# _b_h_X-aHEei5aPS232E3Mw.
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
/// This record is an implementation of the supl.030.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCAISSD1 message extends ISO Corporate Action Instruction Status Advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(@"The DTCCCAISSD1 message extends ISO Corporate Action Instruction Status Advice message with DTCC corporate action elements not covered in the standard message.")]
[IsoId("_b_h_X-aHEei5aPS232E3Mw")]
[DisplayName("DTCCCAISSD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCCCAISSD1V03 : IOuterRecord<DTCCCAISSD1V03,DTCCCAISSD1V03Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.030.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAISSD1";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DTCCCAISSD1V03Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Supplementary data extending corporate action reorganisation instruction status message with corporate action elements not covered in the standard message.
    /// </summary>
    [IsoId("_b_h_YeaHEei5aPS232E3Mw")]
    [DisplayName("Reorganisation Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReorgInstrDtls")]
    #endif
    [IsoXmlTag("ReorgInstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReorganisationInstructionSD6? ReorganisationInstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReorganisationInstructionSD6? ReorganisationInstructionDetails { get; init; } 
    #else
    public ReorganisationInstructionSD6? ReorganisationInstructionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;DTCCCAISSD1V03Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAISSD1V03Document ToDocument()
    {
        return new DTCCCAISSD1V03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;DTCCCAISSD1V03&quot;/&gt;.
/// </summary>
[Serializable]
public partial record DTCCCAISSD1V03Document : IOuterDocument<DTCCCAISSD1V03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.030.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;DTCCCAISSD1V03&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DTCCCAISSD1V03 Message { get; init; }
    #else
    public DTCCCAISSD1V03 Message { get; init; }
    #endif
}
