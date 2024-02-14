﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RemittanceAmount1.  ISO2002 ID# _QGJCSNp-Ed-ak6NoX_4Aeg_-903711790.
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
/// Nature of the amount and currency on a document referred to in the remittance section, typically either the original amount due/payable or the amount actually remitted for the referenced document.
/// </summary>
[IsoId("_QGJCSNp-Ed-ak6NoX_4Aeg_-903711790")]
[DisplayName("Remittance Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RemittanceAmount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount specified is the exact amount due and payable to the creditor.
    /// </summary>
    [IsoId("_QGJCSdp-Ed-ak6NoX_4Aeg_-902791779")]
    [DisplayName("Due Payable Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DuePyblAmt")]
    #endif
    [IsoXmlTag("DuePyblAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAndAmount? DuePayableAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? DuePayableAmount { get; init; } 
    #else
    public System.Decimal? DuePayableAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that results from the application of an agreed discount to the amount due and payable to the creditor.
    /// </summary>
    [IsoId("_QGJCStp-Ed-ak6NoX_4Aeg_-902791719")]
    [DisplayName("Discount Applied Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DscntApldAmt")]
    #endif
    [IsoXmlTag("DscntApldAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAndAmount? DiscountAppliedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? DiscountAppliedAmount { get; init; } 
    #else
    public System.Decimal? DiscountAppliedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount specified for the referred document is the amount of a credit note.
    /// </summary>
    [IsoId("_QGSzQNp-Ed-ak6NoX_4Aeg_-902791574")]
    [DisplayName("Credit Note Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtNoteAmt")]
    #endif
    [IsoXmlTag("CdtNoteAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAndAmount? CreditNoteAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CreditNoteAmount { get; init; } 
    #else
    public System.Decimal? CreditNoteAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of cash resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_QGSzQdp-Ed-ak6NoX_4Aeg_-902791543")]
    [DisplayName("Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxAmt")]
    #endif
    [IsoXmlTag("TaxAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAndAmount? TaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxAmount { get; init; } 
    #else
    public System.Decimal? TaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide information on the amount and reason of the document adjustment.
    /// </summary>
    [IsoId("_QGSzQtp-Ed-ak6NoX_4Aeg_1253864295")]
    [DisplayName("Adjustment Amount And Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjstmntAmtAndRsn")]
    #endif
    [IsoXmlTag("AdjstmntAmtAndRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentAdjustment1? AdjustmentAmountAndReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentAdjustment1? AdjustmentAmountAndReason { get; init; } 
    #else
    public DocumentAdjustment1? AdjustmentAmountAndReason { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money remitted for the referred document.
    /// </summary>
    [IsoId("_QGSzQ9p-Ed-ak6NoX_4Aeg_-902791697")]
    [DisplayName("Remitted Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtdAmt")]
    #endif
    [IsoXmlTag("RmtdAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? RemittedAmount { get; init; } 
    #else
    public System.Decimal? RemittedAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
