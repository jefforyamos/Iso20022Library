﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeCounterpartyReport8.  ISO2002 ID# _B0JdkZQEEeiILOjNP8ro1w.
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
/// Specifies the details of the trade counterparties in the contract.
/// </summary>
[IsoId("_B0JdkZQEEeiILOjNP8ro1w")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Trade Counterparty Report")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeCounterpartyReport8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeCounterpartyReport8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeCounterpartyReport8( Counterparty25 reqReportingCounterparty,Counterparty28 reqOtherCounterparty )
    {
        ReportingCounterparty = reqReportingCounterparty;
        OtherCounterparty = reqOtherCounterparty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the reporting counterparty.
    /// </summary>
    [IsoId("_CBU98ZQEEeiILOjNP8ro1w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reporting Counterparty")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Counterparty25 ReportingCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Counterparty25 ReportingCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Counterparty25 ReportingCounterparty { get; init; } 
    #else
    public Counterparty25 ReportingCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the other counterparty in the transaction.
    /// </summary>
    [IsoId("_CBU985QEEeiILOjNP8ro1w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Other Counterparty")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Counterparty28 OtherCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Counterparty28 OtherCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Counterparty28 OtherCounterparty { get; init; } 
    #else
    public Counterparty28 OtherCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the broker as an intermediary for the reporting counterparty.
    /// </summary>
    [IsoId("_CBU99ZQEEeiILOjNP8ro1w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Broker")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification9Choice_? Broker { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification9Choice_? Broker { get; init; } 
    #else
    public OrganisationIdentification9Choice_? Broker { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the submitting agent in the case where the reporting counterparty has delegated the submission of the report to a third party or to the other counterparty.
    /// </summary>
    [IsoId("_CBU995QEEeiILOjNP8ro1w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Submitting Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification9Choice_? SubmittingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification9Choice_? SubmittingAgent { get; init; } 
    #else
    public OrganisationIdentification9Choice_? SubmittingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the clearing member in the case where the trade is cleared.
    /// </summary>
    [IsoId("_CBU9-ZQEEeiILOjNP8ro1w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Clearing Member")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification9Choice_? ClearingMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification9Choice_? ClearingMember { get; init; } 
    #else
    public OrganisationIdentification9Choice_? ClearingMember { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the beneficiary who is subject to the rights and obligations arising from the contract.
    /// </summary>
    [IsoId("_CBU9-5QEEeiILOjNP8ro1w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Beneficiary")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification9Choice_? Beneficiary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification9Choice_? Beneficiary { get; init; } 
    #else
    public OrganisationIdentification9Choice_? Beneficiary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
