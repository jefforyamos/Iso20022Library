﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Quantity5.  ISO2002 ID# _UdF0btp-Ed-ak6NoX_4Aeg_1583075318.
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
/// Details on the quantity, account and other related information involved in a transaction.
/// </summary>
[IsoId("_UdF0btp-Ed-ak6NoX_4Aeg_1583075318")]
[DisplayName("Quantity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Quantity5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Quantity5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Quantity5( FinancialInstrumentQuantity1Choice_ reqSettlementQuantity )
    {
        SettlementQuantity = reqSettlementQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_UdF0b9p-Ed-ak6NoX_4Aeg_1583076297")]
    [DisplayName("Settlement Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmQty")]
    #endif
    [IsoXmlTag("SttlmQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1Choice_ SettlementQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1Choice_ SettlementQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_ SettlementQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_ SettlementQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Denomination of the security to be received or delivered.
    /// </summary>
    [IsoId("_UdF0cNp-Ed-ak6NoX_4Aeg_1583075433")]
    [DisplayName("Denomination Choice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DnmtnChc")]
    #endif
    [IsoXmlTag("DnmtnChc")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? DenominationChoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DenominationChoice { get; init; } 
    #else
    public System.String? DenominationChoice { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_UdF0cdp-Ed-ak6NoX_4Aeg_635399869")]
    [DisplayName("Certificate Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertNb")]
    #endif
    [IsoXmlTag("CertNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesCertificate1? CertificateNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesCertificate1? CertificateNumber { get; init; } 
    #else
    public SecuritiesCertificate1? CertificateNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series, etc.
    /// </summary>
    [IsoId("_UdF0ctp-Ed-ak6NoX_4Aeg_-851463689")]
    [DisplayName("Quantity Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyBrkdwn")]
    #endif
    [IsoXmlTag("QtyBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityBreakdown3? QuantityBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityBreakdown3? QuantityBreakdown { get; init; } 
    #else
    public QuantityBreakdown3? QuantityBreakdown { get; set; } 
    #endif
    
    
    #nullable disable
    
}
