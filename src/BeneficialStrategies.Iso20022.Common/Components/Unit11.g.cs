﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Unit11.  ISO2002 ID# _b2mNAW1bEeiqaPNRWUnGNA.
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
/// Information about units to transfer.
/// </summary>
[IsoId("_b2mNAW1bEeiqaPNRWUnGNA")]
[DisplayName("Unit")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Unit11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Unit11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Unit11( System.UInt64 reqUnitsNumber )
    {
        UnitsNumber = reqUnitsNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity of units.
    /// </summary>
    [IsoId("_cHHVQ21bEeiqaPNRWUnGNA")]
    [DisplayName("Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitsNb")]
    #endif
    [IsoXmlTag("UnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoDecimalNumber UnitsNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 UnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 UnitsNumber { get; init; } 
    #else
    public System.UInt64 UnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date the investor or its agent placed the original order.
    /// </summary>
    [IsoId("_cHHVRW1bEeiqaPNRWUnGNA")]
    [DisplayName("Order Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrDt")]
    #endif
    [IsoXmlTag("OrdrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? OrderDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? OrderDate { get; init; } 
    #else
    public System.DateOnly? OrderDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date the investor purchased the financial instrument.
    /// </summary>
    [IsoId("_cHHVR21bEeiqaPNRWUnGNA")]
    [DisplayName("Acquisition Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqstnDt")]
    #endif
    [IsoXmlTag("AcqstnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? AcquisitionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? AcquisitionDate { get; init; } 
    #else
    public System.DateOnly? AcquisitionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Certificate representing the security that is delivered.
    /// </summary>
    [IsoId("_cHHVSW1bEeiqaPNRWUnGNA")]
    [DisplayName("Certificate Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertNb")]
    #endif
    [IsoXmlTag("CertNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CertificateNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificateNumber { get; init; } 
    #else
    public System.String? CertificateNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_cHHVS21bEeiqaPNRWUnGNA")]
    [DisplayName("Group 1 Or 2 Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Grp1Or2Units")]
    #endif
    [IsoXmlTag("Grp1Or2Units")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; } 
    #else
    public UKTaxGroupUnit1Code? Group1Or2Units { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the units number. This may be the order reference of the original acquisition, the identification of a lot, a client reference, a sub-position reference or other related reference.
    /// </summary>
    [IsoId("_cHHVTW1bEeiqaPNRWUnGNA")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reference { get; init; } 
    #else
    public System.String? Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the price. This may specify the price of original order confirmation.
    /// </summary>
    [IsoId("_cHHVT21bEeiqaPNRWUnGNA")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitPrice23? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitPrice23? PriceDetails { get; init; } 
    #else
    public UnitPrice23? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Fees and taxes. This may specify the fees and taxes related to the original order confirmation.
    /// </summary>
    [IsoId("_cHHVUW1bEeiqaPNRWUnGNA")]
    [DisplayName("Transaction Overhead")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxOvrhd")]
    #endif
    [IsoXmlTag("TxOvrhd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TotalFeesAndTaxes41? TransactionOverhead { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalFeesAndTaxes41? TransactionOverhead { get; init; } 
    #else
    public TotalFeesAndTaxes41? TransactionOverhead { get; set; } 
    #endif
    
    /// <summary>
    /// Amount not covered in the price, fee or tax.
    /// </summary>
    [IsoId("_cHHVU21bEeiqaPNRWUnGNA")]
    [DisplayName("Other Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAmt")]
    #endif
    [IsoXmlTag("OthrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherAmount1? OtherAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherAmount1? OtherAmount { get; init; } 
    #else
    public OtherAmount1? OtherAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
