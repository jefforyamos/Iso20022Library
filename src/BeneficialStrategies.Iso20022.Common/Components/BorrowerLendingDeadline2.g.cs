﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BorrowerLendingDeadline2.  ISO2002 ID# _U-_Ck5nPEeWLs7cvLxlyAg.
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
/// Stock lending deadline assigned to a borrower of the stock.
/// </summary>
[IsoId("_U-_Ck5nPEeWLs7cvLxlyAg")]
[DisplayName("Borrower Lending Deadline")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BorrowerLendingDeadline2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BorrowerLendingDeadline2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BorrowerLendingDeadline2( DateFormat34Choice_ reqStockLendingDeadline,PartyIdentification103Choice_ reqBorrower )
    {
        StockLendingDeadline = reqStockLendingDeadline;
        Borrower = reqBorrower;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date/time set as the deadline to respond, with instructions, to an outstanding event, for which the underlying security is out on loan.
    /// </summary>
    [IsoId("_U-_ClZnPEeWLs7cvLxlyAg")]
    [DisplayName("Stock Lending Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StockLndgDdln")]
    #endif
    [IsoXmlTag("StockLndgDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat34Choice_ StockLendingDeadline { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat34Choice_ StockLendingDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat34Choice_ StockLendingDeadline { get; init; } 
    #else
    public DateFormat34Choice_ StockLendingDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Party who has borrowed stocks on loan.
    /// </summary>
    [IsoId("_U-_ClJnPEeWLs7cvLxlyAg")]
    [DisplayName("Borrower")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brrwr")]
    #endif
    [IsoXmlTag("Brrwr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification103Choice_ Borrower { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification103Choice_ Borrower { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification103Choice_ Borrower { get; init; } 
    #else
    public PartyIdentification103Choice_ Borrower { get; set; } 
    #endif
    
    
    #nullable disable
    
}
