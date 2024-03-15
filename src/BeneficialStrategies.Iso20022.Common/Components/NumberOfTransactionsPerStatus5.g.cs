﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NumberOfTransactionsPerStatus5.  ISO2002 ID# _-qEw2ZRuEeazAtAtDSg0Nw.
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
/// Set of elements used to provide detailed information on the number of transactions that are reported with a specific transaction status.
/// </summary>
[IsoId("_-qEw2ZRuEeazAtAtDSg0Nw")]
[DisplayName("Number Of Transactions Per Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NumberOfTransactionsPerStatus5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NumberOfTransactionsPerStatus5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NumberOfTransactionsPerStatus5( System.String reqDetailedNumberOfTransactions,ExternalPaymentTransactionStatus1Code reqDetailedStatus )
    {
        DetailedNumberOfTransactions = reqDetailedNumberOfTransactions;
        DetailedStatus = reqDetailedStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of individual transactions contained in the message, detailed per status.
    /// </summary>
    [IsoId("_-1rj05RuEeazAtAtDSg0Nw")]
    [DisplayName("Detailed Number Of Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldNbOfTxs")]
    #endif
    [IsoXmlTag("DtldNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText DetailedNumberOfTransactions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DetailedNumberOfTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DetailedNumberOfTransactions { get; init; } 
    #else
    public System.String DetailedNumberOfTransactions { get; set; } 
    #endif
    
    /// <summary>
    /// Common transaction status for all individual transactions reported.
    /// </summary>
    [IsoId("_-1rj1ZRuEeazAtAtDSg0Nw")]
    [DisplayName("Detailed Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldSts")]
    #endif
    [IsoXmlTag("DtldSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPaymentTransactionStatus1Code DetailedStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPaymentTransactionStatus1Code DetailedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentTransactionStatus1Code DetailedStatus { get; init; } 
    #else
    public ExternalPaymentTransactionStatus1Code DetailedStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies, detailed per status.
    /// </summary>
    [IsoId("_-1rj15RuEeazAtAtDSg0Nw")]
    [DisplayName("Detailed Control Sum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldCtrlSum")]
    #endif
    [IsoXmlTag("DtldCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? DetailedControlSum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? DetailedControlSum { get; init; } 
    #else
    public System.UInt64? DetailedControlSum { get; set; } 
    #endif
    
    
    #nullable disable
    
}
