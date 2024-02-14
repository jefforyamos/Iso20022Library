﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentReceipt5.  ISO2002 ID# _dacLQXG-Ee2TbaNWBpRZpQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer or merchant receipts generated by the POI system.
/// </summary>
[IsoId("_dacLQXG-Ee2TbaNWBpRZpQ")]
[DisplayName("Payment Receipt")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentReceipt5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentReceipt5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentReceipt5( DocumentType7Code reqDocumentQualifier,ActionMessage10 reqOutputContent )
    {
        DocumentQualifier = reqDocumentQualifier;
        OutputContent = reqOutputContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Qualification of the document to print to the Cashier or the Customer.
    /// </summary>
    [IsoId("_dhCigXG-Ee2TbaNWBpRZpQ")]
    [DisplayName("Document Qualifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocQlfr")]
    #endif
    [IsoXmlTag("DocQlfr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentType7Code DocumentQualifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentType7Code DocumentQualifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentType7Code DocumentQualifier { get; init; } 
    #else
    public DocumentType7Code DocumentQualifier { get; set; } 
    #endif
    
    /// <summary>
    /// Flag is the print is integrated to other prints.
    /// </summary>
    [IsoId("_dhCig3G-Ee2TbaNWBpRZpQ")]
    [DisplayName("Integrated Print Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntgrtdPrtFlg")]
    #endif
    [IsoXmlTag("IntgrtdPrtFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? IntegratedPrintFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IntegratedPrintFlag { get; init; } 
    #else
    public System.String? IntegratedPrintFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to indicate that the cardholder payment receipt requires a signature by the customer.
    /// </summary>
    [IsoId("_dhCihXG-Ee2TbaNWBpRZpQ")]
    [DisplayName("Required Signature Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqrdSgntrFlg")]
    #endif
    [IsoXmlTag("ReqrdSgntrFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? RequiredSignatureFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RequiredSignatureFlag { get; init; } 
    #else
    public System.String? RequiredSignatureFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Document to print.
    /// </summary>
    [IsoId("_dhCih3G-Ee2TbaNWBpRZpQ")]
    [DisplayName("Output Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutptCntt")]
    #endif
    [IsoXmlTag("OutptCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActionMessage10 OutputContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActionMessage10 OutputContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage10 OutputContent { get; init; } 
    #else
    public ActionMessage10 OutputContent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
