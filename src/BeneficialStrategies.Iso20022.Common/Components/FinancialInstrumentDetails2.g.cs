﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentDetails2.  ISO2002 ID# _TxujO9p-Ed-ak6NoX_4Aeg_-1625514395.
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
/// Reporting per financial instrument.
/// </summary>
[IsoId("_TxujO9p-Ed-ak6NoX_4Aeg_-1625514395")]
[DisplayName("Financial Instrument Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentDetails2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentDetails2( SecurityIdentification11 reqFinancialInstrumentIdentification )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_TxujPNp-Ed-ak6NoX_4Aeg_-1222860243")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification11 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification11 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification11 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification11 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information regarding the price of the instrument.
    /// </summary>
    [IsoId("_Tx4UMNp-Ed-ak6NoX_4Aeg_126074644")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceInformation6? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceInformation6? PriceDetails { get; init; } 
    #else
    public PriceInformation6? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_Tx4UMdp-Ed-ak6NoX_4Aeg_-1373659052")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    [IsoId("_Tx4UMtp-Ed-ak6NoX_4Aeg_-1285958551")]
    [DisplayName("Opening Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngBal")]
    #endif
    [IsoXmlTag("OpngBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OpeningBalance1? OpeningBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OpeningBalance1? OpeningBalance { get; init; } 
    #else
    public OpeningBalance1? OpeningBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    [IsoId("_Tx4UM9p-Ed-ak6NoX_4Aeg_-1184371237")]
    [DisplayName("Closing Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgBal")]
    #endif
    [IsoXmlTag("ClsgBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClosingBalance1? ClosingBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClosingBalance1? ClosingBalance { get; init; } 
    #else
    public ClosingBalance1? ClosingBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction details.
    /// </summary>
    [IsoId("_Tx4UNNp-Ed-ak6NoX_4Aeg_-1885617424")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    public Transaction6? Transaction { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _Tx4UNNp-Ed-ak6NoX_4Aeg_-1885617424
    
    
    #nullable disable
    
}
