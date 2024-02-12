﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProceedsDelivery1.  ISO2002 ID# _UK6fTNp-Ed-ak6NoX_4Aeg_-1336818380.
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
/// Provides information about the account.
/// </summary>
[IsoId("_UK6fTNp-Ed-ak6NoX_4Aeg_-1336818380")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Proceeds Delivery")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProceedsDelivery1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProceedsDelivery1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProceedsDelivery1( System.String reqSecuritiesAccountIdentification,CashAccountIdentification1Choice_ reqCashAccountIdentification )
    {
        SecuritiesAccountIdentification = reqSecuritiesAccountIdentification;
        CashAccountIdentification = reqCashAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// identification of the securities account to which the securities have to be delivered.
    /// </summary>
    [IsoId("_ULEQQNp-Ed-ak6NoX_4Aeg_-1218609739")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Securities Account Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text SecuritiesAccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String SecuritiesAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SecuritiesAccountIdentification { get; init; } 
    #else
    public System.String SecuritiesAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the cash account to which the cash has to be delivered.
    /// </summary>
    [IsoId("_ULEQQdp-Ed-ak6NoX_4Aeg_-1258318117")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash Account Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccountIdentification1Choice_ CashAccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CashAccountIdentification1Choice_ CashAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountIdentification1Choice_ CashAccountIdentification { get; init; } 
    #else
    public CashAccountIdentification1Choice_ CashAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    [IsoId("_ULEQQtp-Ed-ak6NoX_4Aeg_-1318346642")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Owner Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the institution servicing the account.
    /// </summary>
    [IsoId("_ULEQQ9p-Ed-ak6NoX_4Aeg_-1220127792")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Servicer Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? AccountServicerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? AccountServicerIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_? AccountServicerIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
