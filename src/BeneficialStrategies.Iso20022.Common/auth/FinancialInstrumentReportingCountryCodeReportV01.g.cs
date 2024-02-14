﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstrumentReportingCountryCodeReportV01.  ISO2002 ID# _4LK8MURNEee7JdgA9zPESA.
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


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.047.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FinancialInstrumentReportingCountryCodeReport message provides the details of the two character country codes and is created by ESMA for distribution to national competent authorities.
/// </summary>
[Description(@"The FinancialInstrumentReportingCountryCodeReport message provides the details of the two character country codes and is created by ESMA for distribution to national competent authorities.")]
[IsoId("_4LK8MURNEee7JdgA9zPESA")]
[DisplayName("Financial Instrument Reporting Country Code Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentReportingCountryCodeReportV01 : IOuterRecord<FinancialInstrumentReportingCountryCodeReportV01,FinancialInstrumentReportingCountryCodeReportV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.047.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgCtryCdRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => FinancialInstrumentReportingCountryCodeReportV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentReportingCountryCodeReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentReportingCountryCodeReportV01( SecuritiesCountryIdentification2 reqCountryData )
    {
        CountryData = reqCountryData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Report detailing all countries and their 2 character ISO 3166 code.
    /// </summary>
    [IsoId("_4LK8M0RNEee7JdgA9zPESA")]
    [DisplayName("Country Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryData")]
    #endif
    [IsoXmlTag("CtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesCountryIdentification2 CountryData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesCountryIdentification2 CountryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesCountryIdentification2 CountryData { get; init; } 
    #else
    public SecuritiesCountryIdentification2 CountryData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_4LK8NURNEee7JdgA9zPESA")]
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
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;FinancialInstrumentReportingCountryCodeReportV01Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstrumentReportingCountryCodeReportV01Document ToDocument()
    {
        return new FinancialInstrumentReportingCountryCodeReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;FinancialInstrumentReportingCountryCodeReportV01&quot;/&gt;.
/// </summary>
[Serializable]
public partial record FinancialInstrumentReportingCountryCodeReportV01Document : IOuterDocument<FinancialInstrumentReportingCountryCodeReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.047.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;FinancialInstrumentReportingCountryCodeReportV01&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentReportingCountryCodeReportV01 Message { get; init; }
    #else
    public FinancialInstrumentReportingCountryCodeReportV01 Message { get; init; }
    #endif
}
