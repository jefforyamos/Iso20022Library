﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxInformation8.  ISO2002 ID# _wuFOYf7IEeifc-yx3AlK3Q.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// Details about tax paid, or to be paid, to the government in accordance with the law, including pre-defined parameters such as thresholds and type of account.
/// </summary>
[IsoId("_wuFOYf7IEeifc-yx3AlK3Q")]
[DisplayName("Tax Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxInformation8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party on the credit side of the transaction to which the tax applies.
    /// </summary>
    [IsoId("_w6R3U_7IEeifc-yx3AlK3Q")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxParty1? Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxParty1? Creditor { get; init; } 
    #else
    public TaxParty1? Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Party on the debit side of the transaction to which the tax applies.
    /// </summary>
    [IsoId("_w6R3Vf7IEeifc-yx3AlK3Q")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxParty2? Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxParty2? Debtor { get; init; } 
    #else
    public TaxParty2? Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Territorial part of a country to which the tax payment is related.
    /// </summary>
    [IsoId("_w6R3V_7IEeifc-yx3AlK3Q")]
    [DisplayName("Administration Zone")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdmstnZone")]
    #endif
    [IsoXmlTag("AdmstnZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AdministrationZone { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdministrationZone { get; init; } 
    #else
    public System.String? AdministrationZone { get; set; } 
    #endif
    
    /// <summary>
    /// Tax reference information that is specific to a taxing agency.
    /// </summary>
    [IsoId("_w6R3Wf7IEeifc-yx3AlK3Q")]
    [DisplayName("Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefNb")]
    #endif
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? ReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReferenceNumber { get; init; } 
    #else
    public System.String? ReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Method used to indicate the underlying business or how the tax is paid.
    /// </summary>
    [IsoId("_w6R3W_7IEeifc-yx3AlK3Q")]
    [DisplayName("Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mtd")]
    #endif
    [IsoXmlTag("Mtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Method { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Method { get; init; } 
    #else
    public System.String? Method { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money on which the tax is based.
    /// </summary>
    [IsoId("_w6R3Xf7IEeifc-yx3AlK3Q")]
    [DisplayName("Total Taxable Base Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlTaxblBaseAmt")]
    #endif
    [IsoXmlTag("TtlTaxblBaseAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxableBaseAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxableBaseAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxableBaseAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money as result of the calculation of the tax.
    /// </summary>
    [IsoId("_w6R3X_7IEeifc-yx3AlK3Q")]
    [DisplayName("Total Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlTaxAmt")]
    #endif
    [IsoXmlTag("TtlTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which tax is due.
    /// </summary>
    [IsoId("_w6R3Yf7IEeifc-yx3AlK3Q")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? Date { get; init; } 
    #else
    public System.DateOnly? Date { get; set; } 
    #endif
    
    /// <summary>
    /// Sequential number of the tax report.
    /// </summary>
    [IsoId("_w6R3Y_7IEeifc-yx3AlK3Q")]
    [DisplayName("Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqNb")]
    #endif
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? SequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SequenceNumber { get; init; } 
    #else
    public System.UInt64? SequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Record of tax details.
    /// </summary>
    [IsoId("_w6bBQf7IEeifc-yx3AlK3Q")]
    [DisplayName("Record")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcrd")]
    #endif
    [IsoXmlTag("Rcrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxRecord2? Record { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxRecord2? Record { get; init; } 
    #else
    public TaxRecord2? Record { get; set; } 
    #endif
    
    
    #nullable disable
    
}
