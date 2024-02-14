﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PriceValuation3.  ISO2002 ID# _SbJx2tp-Ed-ak6NoX_4Aeg_-1025425136.
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
/// Calculation of the net asset value for an investment fund/fund class.
/// </summary>
[IsoId("_SbJx2tp-Ed-ak6NoX_4Aeg_-1025425136")]
[DisplayName("Price Valuation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceValuation3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PriceValuation3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PriceValuation3( System.String reqIdentification,DateAndDateTimeChoice_ reqNAVDateTime,FinancialInstrument8 reqFinancialInstrumentDetails,ValuationTiming1Code reqValuationType,System.String reqOfficialValuationIndicator,System.String reqSuspendedIndicator )
    {
        Identification = reqIdentification;
        NAVDateTime = reqNAVDateTime;
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
        ValuationType = reqValuationType;
        OfficialValuationIndicator = reqOfficialValuationIndicator;
        SuspendedIndicator = reqSuspendedIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a price valuation within a price report, as assigned by the issuer of the report.
    /// </summary>
    [IsoId("_SbJx29p-Ed-ak6NoX_4Aeg_-1024504079")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the price valuation for the investment fund/fund class.
    /// </summary>
    [IsoId("_SbJx3Np-Ed-ak6NoX_4Aeg_-1025425076")]
    [DisplayName("Valuation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnDtTm")]
    #endif
    [IsoXmlTag("ValtnDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? ValuationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? ValuationDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? ValuationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus. The NAV date is also known as the trade date. The NAV date becomes the trade date in an order.
    /// </summary>
    [IsoId("_SbJx3dp-Ed-ak6NoX_4Aeg_-1025424733")]
    [DisplayName("NAV Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NAVDtTm")]
    #endif
    [IsoXmlTag("NAVDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ NAVDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ NAVDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ NAVDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_ NAVDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Investment fund class for which the net asset value is calculated.
    /// </summary>
    [IsoId("_SbJx3tp-Ed-ak6NoX_4Aeg_-1024503845")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument8 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument8 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument8 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument8 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Issuer of the fund.
    /// </summary>
    [IsoId("_SbTi0Np-Ed-ak6NoX_4Aeg_-691476443")]
    [DisplayName("Fund Management Company")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndMgmtCpny")]
    #endif
    [IsoXmlTag("FndMgmtCpny")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? FundManagementCompany { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? FundManagementCompany { get; init; } 
    #else
    public PartyIdentification2Choice_? FundManagementCompany { get; set; } 
    #endif
    
    /// <summary>
    /// Value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_SbTi0dp-Ed-ak6NoX_4Aeg_-1025424673")]
    [DisplayName("Total NAV")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNAV")]
    #endif
    [IsoXmlTag("TtlNAV")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAndAmount? TotalNAV { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TotalNAV { get; init; } 
    #else
    public System.Decimal? TotalNAV { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_SbTi0tp-Ed-ak6NoX_4Aeg_-1025424596")]
    [DisplayName("Total Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlUnitsNb")]
    #endif
    [IsoXmlTag("TtlUnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the next price valuation for the investment fund/fund class.
    /// </summary>
    [IsoId("_SbTi09p-Ed-ak6NoX_4Aeg_-1025424517")]
    [DisplayName("Next Valuation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtValtnDtTm")]
    #endif
    [IsoXmlTag("NxtValtnDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? NextValuationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? NextValuationDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? NextValuationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the previous price valuation for the investment fund/fund class.
    /// </summary>
    [IsoId("_SbTi1Np-Ed-ak6NoX_4Aeg_-1025424457")]
    [DisplayName("Previous Valuation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsValtnDtTm")]
    #endif
    [IsoXmlTag("PrvsValtnDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? PreviousValuationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? PreviousValuationDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? PreviousValuationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how the valuation is done, based on the schedule stated in the prospectus.
    /// </summary>
    [IsoId("_SbTi1dp-Ed-ak6NoX_4Aeg_-1025424170")]
    [DisplayName("Valuation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnTp")]
    #endif
    [IsoXmlTag("ValtnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ValuationTiming1Code ValuationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ValuationTiming1Code ValuationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValuationTiming1Code ValuationType { get; init; } 
    #else
    public ValuationTiming1Code ValuationType { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency of the valuation.
    /// </summary>
    [IsoId("_SbTi1tp-Ed-ak6NoX_4Aeg_643321375")]
    [DisplayName("Valuation Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnFrqcy")]
    #endif
    [IsoXmlTag("ValtnFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EventFrequency1Code? ValuationFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventFrequency1Code? ValuationFrequency { get; init; } 
    #else
    public EventFrequency1Code? ValuationFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the valuation is an official valuation.
    /// </summary>
    [IsoId("_SbTi19p-Ed-ak6NoX_4Aeg_1135954512")]
    [DisplayName("Official Valuation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OffclValtnInd")]
    #endif
    [IsoXmlTag("OffclValtnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator OfficialValuationIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OfficialValuationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OfficialValuationIndicator { get; init; } 
    #else
    public System.String OfficialValuationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the valuation of the investment fund class is suspended.
    /// </summary>
    [IsoId("_SbTi2Np-Ed-ak6NoX_4Aeg_-1025424110")]
    [DisplayName("Suspended Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SspdInd")]
    #endif
    [IsoXmlTag("SspdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator SuspendedIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SuspendedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SuspendedIndicator { get; init; } 
    #else
    public System.String SuspendedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_SbTi2dp-Ed-ak6NoX_4Aeg_-1024503551")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitPrice15? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitPrice15? PriceDetails { get; init; } 
    #else
    public UnitPrice15? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the price variations of an investment fund class.
    /// </summary>
    [IsoId("_SbdT0Np-Ed-ak6NoX_4Aeg_-1024503940")]
    [DisplayName("Valuation Statistics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnSttstcs")]
    #endif
    [IsoXmlTag("ValtnSttstcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ValuationStatistics3? ValuationStatistics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValuationStatistics3? ValuationStatistics { get; init; } 
    #else
    public ValuationStatistics3? ValuationStatistics { get; set; } 
    #endif
    
    /// <summary>
    /// Factors that give indications about the performance of a fund.
    /// </summary>
    [IsoId("_SbdT0dp-Ed-ak6NoX_4Aeg_-1837109466")]
    [DisplayName("Performance Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrfrmncDtls")]
    #endif
    [IsoXmlTag("PrfrmncDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PerformanceFactors1? PerformanceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PerformanceFactors1? PerformanceDetails { get; init; } 
    #else
    public PerformanceFactors1? PerformanceDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
