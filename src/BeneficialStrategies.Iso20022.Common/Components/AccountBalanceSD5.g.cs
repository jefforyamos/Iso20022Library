﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountBalanceSD5.  ISO2002 ID# _oKuCA3oAEeO2o_OAyvnbZw.
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
/// Provides additional information regarding account balance. Contains transaction details of the stock loans, repurchase agreements (REPOs) and undelivered trades (FAILs).
/// </summary>
[IsoId("_oKuCA3oAEeO2o_OAyvnbZw")]
[DisplayName("Account Balance SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountBalanceSD5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountBalanceSD5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountBalanceSD5( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_oKuCDHoAEeO2o_OAyvnbZw")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Position that is concerned in transaction.
    /// </summary>
    [IsoId("_oKuCDnoAEeO2o_OAyvnbZw")]
    [DisplayName("Transaction Position")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxPos")]
    #endif
    [IsoXmlTag("TxPos")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdjustedBalanceTypeSD1Choice_? TransactionPosition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdjustedBalanceTypeSD1Choice_? TransactionPosition { get; init; } 
    #else
    public AdjustedBalanceTypeSD1Choice_? TransactionPosition { get; set; } 
    #endif
    
    /// <summary>
    /// Effective date of the transaction.
    /// </summary>
    [IsoId("_oKuCEnoAEeO2o_OAyvnbZw")]
    [DisplayName("As Of Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsOfDt")]
    #endif
    [IsoXmlTag("AsOfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? AsOfDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? AsOfDate { get; init; } 
    #else
    public System.DateOnly? AsOfDate { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction contra participant identification for stock loans, repurchase agreements (REPOs).
    /// </summary>
    [IsoId("_oKuCCHoAEeO2o_OAyvnbZw")]
    [DisplayName("Contra Participant Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ContraPtcptNb")]
    #endif
    [IsoXmlTag("ContraPtcptNb")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ContraParticipantNumber { get; init; } 
    #else
    public System.String? ContraParticipantNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
