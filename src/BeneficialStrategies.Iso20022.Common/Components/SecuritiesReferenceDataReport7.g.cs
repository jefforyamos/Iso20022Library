﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesReferenceDataReport7.  ISO2002 ID# _ENzaIUmXEeqmSrLQiFB8FA.
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
/// Provides details on the securities reference data for the required financial instruments.
/// </summary>
[IsoId("_ENzaIUmXEeqmSrLQiFB8FA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Securities Reference Data Report")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesReferenceDataReport7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesReferenceDataReport7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesReferenceDataReport7( SecurityInstrumentDescription17 reqFinancialInstrumentGeneralAttributes )
    {
        FinancialInstrumentGeneralAttributes = reqFinancialInstrumentGeneralAttributes;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    [IsoId("_EO4YNUmXEeqmSrLQiFB8FA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Technical Record Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TechnicalRecordIdentification { get; init; } 
    #else
    public System.String? TechnicalRecordIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Attributes and characteristics of the financial instrument.
    /// </summary>
    [IsoId("_EO4YN0mXEeqmSrLQiFB8FA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Financial Instrument General Attributes")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityInstrumentDescription17 FinancialInstrumentGeneralAttributes { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecurityInstrumentDescription17 FinancialInstrumentGeneralAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityInstrumentDescription17 FinancialInstrumentGeneralAttributes { get; init; } 
    #else
    public SecurityInstrumentDescription17 FinancialInstrumentGeneralAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// LEI of Issuer or trading venue operator.
    /// </summary>
    [IsoId("_EO4YOUmXEeqmSrLQiFB8FA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Issuer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Issuer { get; init; } 
    #else
    public System.String? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Traded venue related attributes.
    /// </summary>
    [IsoId("_EO4YO0mXEeqmSrLQiFB8FA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trading Venue Related Attributes")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public TradingVenueAttributes2? TradingVenueRelatedAttributes { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _EO4YO0mXEeqmSrLQiFB8FA
    
    /// <summary>
    /// Attributes specific to debt instruments.
    /// </summary>
    [IsoId("_EO4YPUmXEeqmSrLQiFB8FA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Debt Instrument Attributes")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DebtInstrument2? DebtInstrumentAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebtInstrument2? DebtInstrumentAttributes { get; init; } 
    #else
    public DebtInstrument2? DebtInstrumentAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Attributes specific to derivative instruments.
    /// </summary>
    [IsoId("_EO4YP0mXEeqmSrLQiFB8FA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Derivative Instrument Attributes")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DerivativeInstrument5? DerivativeInstrumentAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DerivativeInstrument5? DerivativeInstrumentAttributes { get; init; } 
    #else
    public DerivativeInstrument5? DerivativeInstrumentAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Technical attributes.
    /// </summary>
    [IsoId("_EO4YQUmXEeqmSrLQiFB8FA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Technical Attributes")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RecordTechnicalData4? TechnicalAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RecordTechnicalData4? TechnicalAttributes { get; init; } 
    #else
    public RecordTechnicalData4? TechnicalAttributes { get; set; } 
    #endif
    
    
    #nullable disable
    
}
