﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccountModification4.  ISO2002 ID# _cOgZ4ZTIEemqYPWMBuVawg.
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
/// Information about the modification of an account.
/// </summary>
[IsoId("_cOgZ4ZTIEemqYPWMBuVawg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Investment Account Modification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentAccountModification4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for the modification to the investment account information.
    /// </summary>
    [IsoId("_chsbo5TIEemqYPWMBuVawg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Modification Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? ModificationReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ModificationReason { get; init; } 
    #else
    public System.String? ModificationReason { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of the account modification request.
    /// </summary>
    [IsoId("_chsbpZTIEemqYPWMBuVawg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Application Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountApplicationIdentification { get; init; } 
    #else
    public System.String? AccountApplicationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous investor's identification of a transfer.
    /// </summary>
    [IsoId("_chsbp5TIEemqYPWMBuVawg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Client Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientReference { get; init; } 
    #else
    public System.String? ClientReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the transaction, for example, a transfer, as allocated by the counterparty.
    /// </summary>
    [IsoId("_chsbqZTIEemqYPWMBuVawg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Counterparty Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference13? CounterpartyReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference13? CounterpartyReference { get; init; } 
    #else
    public AdditionalReference13? CounterpartyReference { get; set; } 
    #endif
    
    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    [IsoId("_chsbq5TIEemqYPWMBuVawg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Existing Account Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account23? ExistingAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account23? ExistingAccountIdentification { get; init; } 
    #else
    public Account23? ExistingAccountIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
