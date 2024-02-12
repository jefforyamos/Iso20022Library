﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferOut10.  ISO2002 ID# _1HPi8RgkEeK-_89we2b-bA.
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
/// Information about the confirmation of a transfer out transaction.
/// </summary>
[IsoId("_1HPi8RgkEeK-_89we2b-bA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Transfer Out")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferOut10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransferOut10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferOut10( InvestmentAccount22 reqAccountDetails )
    {
        AccountDetails = reqAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_1cQJpRgkEeK-_89we2b-bA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transfer Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public Transfer24? TransferDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _1cQJpRgkEeK-_89we2b-bA
    
    /// <summary>
    /// Information related to the account from which the financial instrument was withdrawn.
    /// </summary>
    [IsoId("_1cQJqRgkEeK-_89we2b-bA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccount22 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public InvestmentAccount22 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount22 AccountDetails { get; init; } 
    #else
    public InvestmentAccount22 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    [IsoId("_1cQJrRgkEeK-_89we2b-bA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReceiveInformation11? SettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReceiveInformation11? SettlementDetails { get; init; } 
    #else
    public ReceiveInformation11? SettlementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_1cQJsRgkEeK-_89we2b-bA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Extension")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}
