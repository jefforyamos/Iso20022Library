﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for EUPSD2SCADataSD1V01.  ISO2002 ID# _g7hKgAMdEeujMs2LsB3mMw.
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
/// This record is an implementation of the supl.035.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Extends the ATICA message set to address the requirement of the European Banking Authority (EBA) related to the Regulatory Technical Standard (RTS) on Strong Customer Authentication (SCA) imposed by the EU regulation.
/// </summary>
[Description(@"Extends the ATICA message set to address the requirement of the European Banking Authority (EBA) related to the Regulatory Technical Standard (RTS) on Strong Customer Authentication (SCA) imposed by the EU regulation.")]
[IsoId("_g7hKgAMdEeujMs2LsB3mMw")]
[DisplayName("EUPSD 2 SCA Data SD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EUPSD2SCADataSD1V01 : IOuterRecord<EUPSD2SCADataSD1V01,EUPSD2SCADataSD1V01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.035.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "EUPSD2SCADataSD1";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => EUPSD2SCADataSD1V01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EUPSD2SCADataSD1V01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EUPSD2SCADataSD1V01( StrongCustomerAuthentication1 reqStrongCustomerAuthentication )
    {
        StrongCustomerAuthentication = reqStrongCustomerAuthentication;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// EU PSD2 Strong Consumer Authentication data.
    /// </summary>
    [IsoId("_dWMeEAMnEeubkNI1IXQTVQ")]
    [DisplayName("Strong Customer Authentication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrngCstmrAuthntcn")]
    #endif
    [IsoXmlTag("StrngCstmrAuthntcn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StrongCustomerAuthentication1 StrongCustomerAuthentication { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StrongCustomerAuthentication1 StrongCustomerAuthentication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StrongCustomerAuthentication1 StrongCustomerAuthentication { get; init; } 
    #else
    public StrongCustomerAuthentication1 StrongCustomerAuthentication { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;EUPSD2SCADataSD1V01Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public EUPSD2SCADataSD1V01Document ToDocument()
    {
        return new EUPSD2SCADataSD1V01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;EUPSD2SCADataSD1V01&quot;/&gt;.
/// </summary>
[Serializable]
public partial record EUPSD2SCADataSD1V01Document : IOuterDocument<EUPSD2SCADataSD1V01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.035.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;EUPSD2SCADataSD1V01&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EUPSD2SCADataSD1V01 Message { get; init; }
    #else
    public EUPSD2SCADataSD1V01 Message { get; init; }
    #endif
}
