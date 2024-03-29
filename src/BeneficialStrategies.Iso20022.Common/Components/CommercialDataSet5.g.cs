﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CommercialDataSet5.  ISO2002 ID# _L6FU0TckEeSaC-PiOaz_KQ.
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
/// Goods or services that are part of a commercial trade agreement.
/// </summary>
[IsoId("_L6FU0TckEeSaC-PiOaz_KQ")]
[DisplayName("Commercial Data Set")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CommercialDataSet5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CommercialDataSet5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CommercialDataSet5( DocumentIdentification1 reqDataSetIdentification,InvoiceIdentification1 reqCommercialDocumentReference,PartyIdentification26 reqBuyer,PartyIdentification26 reqSeller,SettlementTerms3 reqSettlementTerms )
    {
        DataSetIdentification = reqDataSetIdentification;
        CommercialDocumentReference = reqCommercialDocumentReference;
        Buyer = reqBuyer;
        Seller = reqSeller;
        SettlementTerms = reqSettlementTerms;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the commercial data set.
    /// </summary>
    [IsoId("_MQGoITckEeSaC-PiOaz_KQ")]
    [DisplayName("Data Set Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSetId")]
    #endif
    [IsoXmlTag("DataSetId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification1 DataSetIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification1 DataSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification1 DataSetIdentification { get; init; } 
    #else
    public DocumentIdentification1 DataSetIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the identification of the underlying commercial document.
    /// </summary>
    [IsoId("_MQGoIzckEeSaC-PiOaz_KQ")]
    [DisplayName("Commercial Document Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComrclDocRef")]
    #endif
    [IsoXmlTag("ComrclDocRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvoiceIdentification1 CommercialDocumentReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvoiceIdentification1 CommercialDocumentReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvoiceIdentification1 CommercialDocumentReference { get; init; } 
    #else
    public InvoiceIdentification1 CommercialDocumentReference { get; set; } 
    #endif
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_MQGoJTckEeSaC-PiOaz_KQ")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification26 Buyer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification26 Buyer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26 Buyer { get; init; } 
    #else
    public PartyIdentification26 Buyer { get; set; } 
    #endif
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_MQGoJzckEeSaC-PiOaz_KQ")]
    [DisplayName("Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sellr")]
    #endif
    [IsoXmlTag("Sellr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification26 Seller { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification26 Seller { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26 Seller { get; init; } 
    #else
    public PartyIdentification26 Seller { get; set; } 
    #endif
    
    /// <summary>
    /// Party to be invoiced for the purchase.
    /// </summary>
    [IsoId("_MQGoKTckEeSaC-PiOaz_KQ")]
    [DisplayName("Bill To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BllTo")]
    #endif
    [IsoXmlTag("BllTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification26? BillTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26? BillTo { get; init; } 
    #else
    public PartyIdentification26? BillTo { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the goods and/or services of the underlying transaction.
    /// </summary>
    [IsoId("_MQGoKzckEeSaC-PiOaz_KQ")]
    [DisplayName("Goods")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Goods")]
    #endif
    [IsoXmlTag("Goods")]
    public ValueList<LineItem15> Goods { get; init; } = new ValueList<LineItem15>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _MQGoKzckEeSaC-PiOaz_KQ
    
    /// <summary>
    /// Specifies the payment terms by means of a code and a limit in time.
    /// </summary>
    [IsoId("_MQGoLTckEeSaC-PiOaz_KQ")]
    [DisplayName("Payment Terms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTerms")]
    #endif
    [IsoXmlTag("PmtTerms")]
    public ValueList<PaymentTerms4> PaymentTerms { get; init; } = new ValueList<PaymentTerms4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _MQGoLTckEeSaC-PiOaz_KQ
    
    /// <summary>
    /// Specifies how the transaction should be settled.
    /// </summary>
    [IsoId("_MQGoLzckEeSaC-PiOaz_KQ")]
    [DisplayName("Settlement Terms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTerms")]
    #endif
    [IsoXmlTag("SttlmTerms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTerms3 SettlementTerms { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTerms3 SettlementTerms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTerms3 SettlementTerms { get; init; } 
    #else
    public SettlementTerms3 SettlementTerms { get; set; } 
    #endif
    
    
    #nullable disable
    
}
