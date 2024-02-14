﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorConfigurationUpdateV10.  ISO2002 ID# _6QnekS1vEeuZtpnZJ4v-5Q.
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


namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// This record is an implementation of the catm.003.001.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorConfigurationUpdate message is sent by a TM to a POI to update configurations.
/// </summary>
[Description(@"The AcceptorConfigurationUpdate message is sent by a TM to a POI to update configurations.")]
[IsoId("_6QnekS1vEeuZtpnZJ4v-5Q")]
[DisplayName("Acceptor Configuration Update V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorConfigurationUpdateV10 : IOuterRecord<AcceptorConfigurationUpdateV10,AcceptorConfigurationUpdateV10Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.003.001.10";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCfgtnUpd";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AcceptorConfigurationUpdateV10Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorConfigurationUpdateV10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorConfigurationUpdateV10( TMSHeader1 reqHeader,AcceptorConfiguration10 reqAcceptorConfiguration )
    {
        Header = reqHeader;
        AcceptorConfiguration = reqAcceptorConfiguration;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics related to the transfer of the acceptor parameters.
    /// </summary>
    [IsoId("_6QnelS1vEeuZtpnZJ4v-5Q")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TMSHeader1 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TMSHeader1 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TMSHeader1 Header { get; init; } 
    #else
    public TMSHeader1 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor configuration to be downloaded from the terminal management system.
    /// </summary>
    [IsoId("_6Qnely1vEeuZtpnZJ4v-5Q")]
    [DisplayName("Acceptor Configuration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptrCfgtn")]
    #endif
    [IsoXmlTag("AccptrCfgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorConfiguration10 AcceptorConfiguration { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcceptorConfiguration10 AcceptorConfiguration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptorConfiguration10 AcceptorConfiguration { get; init; } 
    #else
    public AcceptorConfiguration10 AcceptorConfiguration { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_6QnemS1vEeuZtpnZJ4v-5Q")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType25? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType25? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType25? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;AcceptorConfigurationUpdateV10Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorConfigurationUpdateV10Document ToDocument()
    {
        return new AcceptorConfigurationUpdateV10Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;AcceptorConfigurationUpdateV10&quot;/&gt;.
/// </summary>
[Serializable]
public partial record AcceptorConfigurationUpdateV10Document : IOuterDocument<AcceptorConfigurationUpdateV10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.003.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;AcceptorConfigurationUpdateV10&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorConfigurationUpdateV10 Message { get; init; }
    #else
    public AcceptorConfigurationUpdateV10 Message { get; init; }
    #endif
}
