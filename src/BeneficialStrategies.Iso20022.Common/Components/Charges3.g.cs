﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Charges3.  ISO2002 ID# _tisYa1kyEeGeoaLUQk__nA_-1567404898.
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
/// Provides further details on the charges related to the payment transaction.
/// </summary>
[IsoId("_tisYa1kyEeGeoaLUQk__nA_-1567404898")]
[DisplayName("Charges")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Charges3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Total of all charges and taxes applied to the entry.
    /// </summary>
    [IsoId("_ti2JYFkyEeGeoaLUQk__nA_307776817")]
    [DisplayName("Total Charges And Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlChrgsAndTaxAmt")]
    #endif
    [IsoXmlTag("TtlChrgsAndTaxAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAndAmount? TotalChargesAndTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TotalChargesAndTaxAmount { get; init; } 
    #else
    public System.Decimal? TotalChargesAndTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details of the individual charges record.
    /// </summary>
    [IsoId("_ti2JYVkyEeGeoaLUQk__nA_313328146")]
    [DisplayName("Record")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcrd")]
    #endif
    [IsoXmlTag("Rcrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargesRecord1? Record { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargesRecord1? Record { get; init; } 
    #else
    public ChargesRecord1? Record { get; set; } 
    #endif
    
    
    #nullable disable
    
}
